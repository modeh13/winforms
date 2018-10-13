using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutDesk.Clases
{
  public static class Util
  {
    #region "Extensiones"
    public static byte ToByte(this bool valor)
    {
      return Convert.ToByte(valor);
    }

    public static string ToUpperTrim(this object valor)
    {
      return valor.ToString().ToUpperTrim();
    }

    public static string ToUpperTrim(this string valor)
    {
      return valor.Trim().ToUpper();
    }
    #endregion

    #region "Métodos"
    public static void EnlazarGrid<T>(DataGridView grid, List<T> lista)
    {
      var bindingList = new BindingList<T>(lista);
      var source = new BindingSource(bindingList, null);
      grid.DataSource = source;
    }
    #endregion
  }
}