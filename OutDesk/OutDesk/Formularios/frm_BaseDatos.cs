using OutDesk.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OutDesk.Formularios
{
  public partial class frm_BaseDatos : Form
  {
    #region "Propiedades"
    private List<BaseDatos> bases;
    private BaseDatos baseSeleccionada;
    #endregion

    #region "Constructores"
    public frm_BaseDatos()
    {
      InitializeComponent();      
    }
    #endregion

    #region "Eventos"
    private void frm_BaseDatos_Load(object sender, EventArgs e)
    {
      CargarDatos();   
    }
    #endregion

    #region "Métodos"
    private void CargarDatos()
    {
      bases = new List<BaseDatos>()
      {
        new BaseDatos() { Servidor = "MAYASOFT108", Nombre = "Ticketing-Tcc", CadenaConexion = "Data Source=MAYASOFT108;Initial Catalog=Ticketing-TCC;Persist Security Info=True;User ID=sa;Password=123456;MultipleActiveResultSets=True;Application Name=OutDesk" }
      };

      dgv_BaseDatos.AutoGenerateColumns = false;
      Util.EnlazarGrid<BaseDatos>(dgv_BaseDatos, bases);
    }

    public BaseDatos ObtenerSeleccion()
    {
      return baseSeleccionada;
    }
    #endregion

    private void btn_Seleccionar_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;

      if (dgv_BaseDatos.Rows.Count > 0 && dgv_BaseDatos.SelectedRows.Count > 0)
      {
        var dtRow = dgv_BaseDatos.SelectedRows[0];
        var servidor = dtRow.Cells["colServidor"].Value.ToString();
        var nombreBase = dtRow.Cells["colBaseDatos"].Value.ToString();
        baseSeleccionada = bases.FirstOrDefault(x => x.Servidor == servidor && x.Nombre == nombreBase);
        DialogResult = DialogResult.OK;
      }
      
      Close();
    }
  }
}