using System.ComponentModel.DataAnnotations.Schema;

namespace OutDesk.Model
{
  [Table("Configuracion.FormularioCampana")]
  public class FormularioCampana
  {
    public long Id { get; set; }
    public long? CampanaId { get; set; }
    public long FormularioId { get; set; }
    public string Campo { get; set; }
    public byte Visible { get; set; }
    public byte Obligatorio { get; set; }
    public long TipoDato { get; set; }
    public long? TablaId { get; set; }
    public string Nombre { get; set; }
    public string PropiedadAlmacena { get; set; }
    public byte Longitud { get; set; }
    public long? ListaId { get; set; }
    public long? EncuestaId { get; set; }
    public string Ayuda { get; set; }
    public long? ClienteId { get; set; }
    public byte InsertarHijo { get; set; }
    public long? PadreId { get; set; }
    public byte Orden { get; set; }
  }
}