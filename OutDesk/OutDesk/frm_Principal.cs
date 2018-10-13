using OutDesk.Clases;
using OutDesk.Controles;
using OutDesk.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutDesk
{
  public partial class frm_Principal : Form
  {
    #region "Propiedades"
    private uc_CrearArbolTipificacion _uc_CrearArbolTipificacion;
    private frm_BaseDatos _frm_BaseDatos;
    private Opciones _opcion;
    private const string menuBaseDatos = "tsm_BaseDatos";

    protected enum Opciones : byte
    {
      CrearArbolTipificacion = 1
    }
    #endregion

    #region "Constructores"
    public frm_Principal()
    {
      InitializeComponent();
    }
    #endregion

    #region "Métodos"
    private void SeleccionarBaseDatos()
    {
      _frm_BaseDatos = new frm_BaseDatos();

      if (_frm_BaseDatos.ShowDialog() == DialogResult.OK)
      {
        AppGlobal.baseDatos = _frm_BaseDatos.ObtenerSeleccion();
        BloquearMenu(string.Empty);
      }
      else {
        if (AppGlobal.baseDatos == null) {
          BloquearMenu(menuBaseDatos);
        }        
      }
    }

    private void BloquearMenu(string nombreMenu)
    {      
      foreach (ToolStripItem item in menuStrip.Items)
      {
        if (!string.IsNullOrEmpty(nombreMenu) && item.Name != nombreMenu)
        {
          item.Enabled = false;
        }
        else {
          item.Enabled = true;
        }
      }
    }

    #endregion

    #region "Eventos"
    private void frm_Principal_Load(object sender, EventArgs e)
    {      
      SeleccionarBaseDatos();      
    }

    private void tsm_CrearArbolTipificacion_Click(object sender, EventArgs e)
    {
      if (!pnl_Contenedor.Controls.Contains(_uc_CrearArbolTipificacion))
      {
        _opcion = Opciones.CrearArbolTipificacion;
        bgw_Principal.RunWorkerAsync();
      }
    }

    private void bgw_Principal_DoWork(object sender, DoWorkEventArgs e)
    {
      Invoke(new Action(() => {
        pnl_Contenedor.Controls.Clear();

        switch (_opcion)
        {
          case Opciones.CrearArbolTipificacion:
            _uc_CrearArbolTipificacion = new uc_CrearArbolTipificacion();
            pnl_Contenedor.Controls.Add(_uc_CrearArbolTipificacion);
            break;
        }
      }));      
    }
    #endregion

    private void tsm_BaseDatos_Click(object sender, EventArgs e)
    {
      SeleccionarBaseDatos();
    }
  }
}