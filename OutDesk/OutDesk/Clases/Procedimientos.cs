using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutDesk.Model;
using UtilMaya.Datos;
using System.Data.Entity;

namespace OutDesk.Clases
{
  public class Procedimientos
  {
    #region "Propiedades"
    private ResultadoBD resultado;
    private DataTable dt;
    private string sentencia;
    #endregion

    #region "Métodos Entity"
    public T CrearEntidad<T>(T entidad) where T : class
    {  
      using (Model.Model context = new Model.Model())
      {
        using (var transaction = context.Database.BeginTransaction())
        {
          context.Entry(entidad).State = EntityState.Added;
          context.SaveChanges();
          transaction.Commit();
        }
      }
      return entidad;
    }

    #endregion

    #region "Métodos"
    protected DataTable ObtenerTabla(string sql)
    {
      dt = new DataTable();

      using (DataSql datos = new DataSql(AppGlobal.baseDatos.CadenaConexion))
      {        
        resultado = datos.EjecutarConsulta(sql);

        if (resultado.Exitoso && resultado.Tablas.Tables.Count > 0)
        {
          dt = resultado.Tablas.Tables[0];
        }
      }

      return dt;
    }

    protected int ObtenerEscalar(string sql)
    {
      int n = 0;
      dt = new DataTable();

      using (DataSql datos = new DataSql(AppGlobal.baseDatos.CadenaConexion))
      {
        resultado = datos.EjecutarConsulta(sql);

        if (resultado.Exitoso && resultado.Tablas.Tables.Count > 0)
        {
          dt = resultado.Tablas.Tables[0];
          n = Convert.ToInt32(dt.Rows[0][0]);
        }
      }

      return n;
    }

    public DataTable ObtenerClientes()
    {
      sentencia = "SELECT Id, Nombre FROM Proceso.Cliente WHERE Estado = 1 ORDER BY Nombre";
      return ObtenerTabla(sentencia);
    }

    public DataTable ObtenerTablas()
    {
      sentencia = "SELECT Id, Nombre FROM Configuracion.Tabla ORDER BY Nombre";
      return ObtenerTabla(sentencia);
    }

    public DataTable ObtenerFormularios()
    {
      sentencia = "SELECT DT.Id, DT.Nombre FROM Configuracion.Dato DT INNER JOIN Configuracion.Tabla TB ON TB.Id = DT.TablaId WHERE TB.Nombre = 'Formularios'";
      return ObtenerTabla(sentencia);
    }

    public DataTable ObtenerCampanasCliente(long ClienteId)
    {
      sentencia = "SELECT Id, Nombre FROM Proceso.Campana WHERE ClienteId = " + ClienteId;
      return ObtenerTabla(sentencia);
    }

    public int CantidadDatosTabla(long TablaId)
    {
      sentencia = "SELECT COUNT(1) AS N FROM Configuracion.Dato WHERE TablaId = " + TablaId;
      return ObtenerEscalar(sentencia);
    }
    #endregion
  }
}