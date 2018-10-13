using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutDesk.Model
{
  [Table("Configuracion.Dato")]
  public class Dato
  {
    public long Id { get; set; }
    public long TablaId { get; set; }
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Valor { get; set; }
    public byte Activo { get; set; }
    public DateTime FechaRegistro { get; set; }
    public long UsuarioId { get; set; }
    public long? PadreId { get; set; }
    public string Equivalente { get; set; }
    public string Herencia { get; set; }
  }
}