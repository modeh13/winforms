using System;

namespace OutDesk.Clases
{
  public class Nodo
  {
    public Guid Id { get; set; }
    public string Valor { get; set; }
    public string Herencia { get; set; }
    public Nodo Padre { get; set; }
    public Model.Dato Dato { get; set; }
  }
}