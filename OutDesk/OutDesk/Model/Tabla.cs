using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutDesk.Model
{
  [Table("Configuracion.Tabla")]
  public class Tabla
  {
    public long Id { get; set; }
    public string Nombre { get; set; }
    public byte ListaDinamica { get; set; }
    public DateTime FechaRegistro { get; set; }
    public long UsuarioId { get; set; }
  }
}