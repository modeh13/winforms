using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using System.IO;
using ExcelDataReader;
using OutDesk.Clases;

namespace OutDesk.Controles
{
  public partial class uc_CrearArbolTipificacion : UserControl
  {
    #region "Propiedades"
    private Procedimientos procedimientosBD;
    private string rutaArchivo;
    private long FormularioId;
    private long ClienteId;
    private long TablaId;
    private List<Columna> columnas;
    private DataTable dt;
    private Proceso proceso;

    private enum Proceso : byte { 
      Procesar = 1,
      Guardar
    }
    #endregion

    #region "Constructores"
    public uc_CrearArbolTipificacion()
    {
      InitializeComponent();

      procedimientosBD = new Procedimientos();
      ofd_Archivo.Filter = "Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx";
      CargarClientes();
      CargarTablas();
      CargarFormularios();
    }
    #endregion

    #region "Métodos"
    protected void CargarClientes()
    {
      var dt = procedimientosBD.ObtenerClientes();

      cbx_Cliente.DisplayMember = "Nombre";
      cbx_Cliente.ValueMember = "Id";
      cbx_Cliente.DataSource = dt;
      cbx_Cliente.SelectedIndex = -1;
    }

    protected void CargarTablas()
    {
      var dt = procedimientosBD.ObtenerTablas();

      cbx_Tablas.DisplayMember = "Nombre";
      cbx_Tablas.ValueMember = "Id";
      cbx_Tablas.DataSource = dt;
      cbx_Tablas.SelectedIndex = -1;
    }

    protected void CargarFormularios()
    {
      var dt = procedimientosBD.ObtenerFormularios();

      cbx_Formularios.DisplayMember = "Nombre";
      cbx_Formularios.ValueMember = "Id";
      cbx_Formularios.DataSource = dt;
      cbx_Formularios.SelectedIndex = -1;
    }

    protected void NormalizarDatos()
    {
      string valor = string.Empty;
      string valorAnterior = string.Empty;
      string valorPadre = string.Empty;
      string valorPadreAnterior = string.Empty;
      int filas = dt.Rows.Count;

      foreach (DataColumn columna in dt.Columns)
      {
        valor = string.Empty;
        valorAnterior = string.Empty;
        valorPadre = string.Empty;
        valorPadreAnterior = string.Empty;

        for (int i = 0; i < filas; i++)
        {
          valor = dt.Rows[i][columna.ColumnName].ToString().Trim();

          if (columna.Ordinal > 0)
          {
            // Revisar Columna Anterior
            valorPadre = dt.Rows[i][columna.Ordinal - 1].ToString().Trim();

            if (string.IsNullOrEmpty(valor) && (valorPadre == valorPadreAnterior))
            {
              dt.Rows[i][columna.ColumnName] = valorAnterior;
              valor = valorAnterior;
            }
            valorPadreAnterior = valorPadre;
          }
          else {
            // Columna Inicial            
            if (string.IsNullOrEmpty(valor))
            {
              dt.Rows[i][columna.ColumnName] = valorAnterior;
              valor = valorAnterior;
            }
          }

          valorAnterior = valor;
        }
      }
    }

    protected void ProcesarColumnas(List<Columna> colProceso)
    {
      List<string> valores;
      Columna colPadre;

      foreach (Columna col in colProceso)
      {
        col.Nodos = new List<Nodo>();
   
        if (!string.IsNullOrEmpty(col.ColumnaPadre))
        {
          // Tiene Padre
          colPadre = columnas.FirstOrDefault(x => x.Nombre == col.ColumnaPadre);

          foreach (Nodo nodo in colPadre.Nodos)
          {
            if (!string.IsNullOrEmpty(colPadre.ColumnaPadre))
            {
              valores = (from dtRow in dt.AsEnumerable()
                         where dtRow[colPadre.ColumnaPadre].ToUpperTrim() == nodo.Padre.Valor && dtRow[colPadre.Nombre].ToUpperTrim() == nodo.Valor 
                         && !string.IsNullOrEmpty(dtRow[col.Nombre].ToString())                  
                         select dtRow[col.Nombre].ToUpperTrim()).Distinct().ToList();
            }
            else
            {
              valores = (from dtRow in dt.AsEnumerable()
                         where dtRow[colPadre.Nombre].ToUpperTrim() == nodo.Valor && !string.IsNullOrEmpty(dtRow[col.Nombre].ToString())
                         select dtRow[col.Nombre].ToUpperTrim()).Distinct().ToList();
              
            }
            valores.ForEach(x => col.Nodos.Add(new Nodo() { Id = Guid.NewGuid(), Valor = x.ToUpperTrim(), Padre = nodo, Herencia = $"{nodo.Herencia};{x.ToUpperTrim()}"  }));
          }          
        }
        else {
          // No tiene Padre
          valores = dt.AsEnumerable().Where(r => !string.IsNullOrEmpty(r[col.Nombre].ToString())).Select(x => x[col.Nombre].ToUpperTrim()).Distinct().ToList();
          valores.ForEach(x => col.Nodos.Add(new Nodo() { Id = Guid.NewGuid(), Valor = x.ToUpperTrim(), Herencia = x.ToUpperTrim() }));
        }

        if (columnas.Any(x => x.ColumnaPadre == col.Nombre))
        {
          ProcesarColumnas(columnas.Where(x => x.ColumnaPadre == col.Nombre).ToList());
        }
      }
    }

    protected List<TreeNode> EnlazarArbol(List<Columna> colProceso) 
    {
      List<TreeNode> nodes = new List<TreeNode>(); // Listado de Retorno
      List<TreeNode> nodesCol; // Listado de Recursividad
      TreeNode node;

      foreach (Columna col in colProceso)
      {
        if (columnas.Any(x => x.ColumnaPadre == col.Nombre))
        {
          // Recursividad;
          nodesCol = EnlazarArbol(columnas.Where(x => x.ColumnaPadre == col.Nombre).ToList());

          if (nodesCol.Any())
          {
            foreach (Nodo nodo in col.Nodos)
            {
              node = new TreeNode()
              {
                Text = nodo.Valor,
                Name = (nodo.Padre != null) ? $"tnd_{nodo.Padre.Id}_{nodo.Id}" : $"tnd_{nodo.Id}"
              };

              node.Nodes.AddRange(nodesCol.Where(x => x.Name.StartsWith($"tnd_{nodo.Id}_")).ToArray());
              nodes.Add(node);
            }
          }
        }
        else if (col.Nodos.Any()) {
          col.Nodos.ForEach(x => nodes.Add(new TreeNode() { Text = x.Valor, Name = $"tnd_{x.Padre.Id}_{x.Id}" }));
        }
      }

      return nodes;
    }

    protected void ProcesarArchivo()
    {
      var extArchivo = Path.GetExtension(rutaArchivo);
      var libro = new ExcelQueryFactory(rutaArchivo);
      bool xls97_2003 = (extArchivo.Equals(".xls") ? true : false);
      DataSet ds;

      using (FileStream stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
      {
        using (IExcelDataReader reader = (xls97_2003) ? ExcelReaderFactory.CreateBinaryReader(stream) : ExcelReaderFactory.CreateOpenXmlReader(stream))
        {
          ds = reader.AsDataSet(new ExcelDataSetConfiguration()
          {
            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
            {
              UseHeaderRow = true,
            }
          });
        }
      }

      // Procesar archivo
      if (ds.Tables.Count > 0)
      {
        List<TreeNode> nodes;
        string nombreColumna = string.Empty;        
        dt = ds.Tables[0];

        Invoke(new Action(() =>
        {
          FormularioId = Convert.ToInt64(cbx_Formularios.SelectedValue);
          ClienteId = Convert.ToInt64(cbx_Cliente.SelectedValue);
          TablaId = Convert.ToInt64(cbx_Tablas.SelectedValue);
        }));

        NormalizarDatos();
        columnas = new Columna().CrearColumnas();

        // Validar que no hayan registros en DATO para la TablaId
        int registros = procedimientosBD.CantidadDatosTabla(TablaId);

        if (registros == 0 && columnas.Count(x => x.Principal) == 1)
        {
          ProcesarColumnas(columnas.Where(x => x.Principal).ToList());
          nodes = EnlazarArbol(columnas.Where(x => x.Principal).ToList()); // Método únicamente para visualizar.

          Invoke(new Action(() => {
            btn_Guardar.Enabled = true;
            tvw_Arbol.Nodes.AddRange(nodes.ToArray());
          }));
        }
        else
        {
          MessageBox.Show("Se encontró información configurada, por favor revisar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    protected void GuardarRegistros(Model.Model context, List<Columna> colProceso)
    {
      Model.Dato dato;

      foreach (Columna col in colProceso)
      {        
        if (col.EsNivel)
        {
          if (col.Nivel == 1 && col.Principal)
          {
            //Crear FormularioCampana
            context.FormularioCampana.Add(new Model.FormularioCampana() {
              FormularioId = FormularioId,
              Visible = col.EsVisible.ToByte(),
              Obligatorio = col.EsObligatorio.ToByte(),
              TipoDato = col.TipoDato,
              TablaId = TablaId,
              Campo = $"dv{col.Nombre.Replace(" ", "")}",
              Nombre = col.Etiqueta,
              PropiedadAlmacena = "IdNivel1",
              Longitud = 0,
              ClienteId = ClienteId,
              Orden = col.Nivel
            });
          }

          // Crear un registro en DATO para cada NODO
          foreach (Nodo nodo in col.Nodos)
          {
            dato = new Model.Dato()
            {
              TablaId = TablaId,
              Codigo = col.Etiqueta,
              Nombre = nodo.Valor,
              Valor = col.Nivel.ToString(),
              Activo = 1,
              FechaRegistro = DateTime.Now,
              UsuarioId = 1,
              PadreId = (col.Nivel > 1) ? nodo.Padre.Dato.Id : (long?)null,
              Herencia = nodo.Herencia
            };

            context.Dato.Add(dato);            
            nodo.Dato = dato;
          }
          
          context.SaveChanges();                 

          // Validar si hay columnas HIJAS
          if (columnas.Any(x => x.ColumnaPadre == col.Nombre))
          {
            GuardarRegistros(context, columnas.Where(x => x.ColumnaPadre == col.Nombre).ToList());
          }
        }
        else {
          // Comodines
          if (col.Nivel == 1) { 
            // Crear FormularioCampana
          }
        
        }
      }
    }

    protected void GuardarArbol()
    {
      using (Model.Model context = new Model.Model())
      {
        using (var transaccion = context.Database.BeginTransaction())
        {
          try
          {
            // Guardar Registros Base de Datos
            GuardarRegistros(context, columnas.Where(x => x.Principal).ToList());
            context.SaveChanges();
            transaccion.Commit();
          }
          catch (Exception ex)
          {
            transaccion.Rollback();
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }
    #endregion

    #region "Eventos"
    private void cbx_Cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbx_Cliente.SelectedIndex != -1)
      {
        long ClienteID = Convert.ToInt64(cbx_Cliente.SelectedValue);
        var dt = procedimientosBD.ObtenerCampanasCliente(ClienteID);

        cbx_Campana.DisplayMember = "Nombre";
        cbx_Campana.ValueMember = "Id";
        cbx_Campana.DataSource = dt;
        cbx_Campana.SelectedIndex = -1;
        cbx_Campana.Enabled = true;
      }
    }

    private void btn_SubirArchivo_Click(object sender, EventArgs e)
    {
      if (ofd_Archivo.ShowDialog() == DialogResult.OK)
      {
        rutaArchivo = ofd_Archivo.FileName;
        txt_RutaArchivo.Text = Path.GetFileName(rutaArchivo);
      }
    }

    private void btn_Procesar_Click(object sender, EventArgs e)
    {
      // Validar Información necesaria
      //if (cbx_Cliente.SelectedIndex == -1) {
      //  MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //  return;
      //}

      //if (cbx_Tablas.SelectedIndex == -1) {
      //  MessageBox.Show("Debe seleccionar la tabla correspondiente a la Tipificación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //  return;
      //}

      //if (cbx_Formularios.SelectedIndex == -1)
      //{
      //  MessageBox.Show("Debe seleccionar el formulario al que se asociara el árbol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //  return;
      //}

      if (string.IsNullOrEmpty(rutaArchivo))
      {
        MessageBox.Show("Debe seleccionar un archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;    
      }

      gbx_CrearArbol.Enabled = false;
      proceso = Proceso.Procesar;      
      bgw_Principal.RunWorkerAsync();      
    }

    private void bgw_Procesar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      gbx_CrearArbol.Enabled = true;
    }

    private void bgw_Procesar_DoWork(object sender, DoWorkEventArgs e)
    {
      switch (proceso)
      {
        case Proceso.Procesar:
          ProcesarArchivo();
          break;

        case Proceso.Guardar:
          GuardarArbol();
          break;
      }     
    }

    private void btn_Guardar_Click(object sender, EventArgs e)
    {
      if (columnas.Any())
      {
        gbx_CrearArbol.Enabled = false;
        proceso = Proceso.Guardar;
        bgw_Principal.RunWorkerAsync();
      }
    }
    #endregion    
  }
}