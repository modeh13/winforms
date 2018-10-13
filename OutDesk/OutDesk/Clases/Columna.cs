using System.Collections.Generic;

namespace OutDesk.Clases
{
  public class Columna
  {
    #region "Propiedades"
    public string Nombre { get; set; }
    public string Etiqueta { get; set; }    
    public bool EsNivel { get; set; }
    public long TipoDato { get; set; }
    public bool EsVisible { get; set; }
    public bool EsObligatorio { get; set; }
    public string PropiedadAlmacena { get; set; }
    public byte Nivel { get; set; }
    public bool Principal { get; set; }
    public string ColumnaPadre { get; set; }
    public List<Nodo> Nodos { get; set; }
    #endregion

    #region "Constructores"
    public Columna() { }
    #endregion

    #region "Métodos"
    public List<Columna> CrearColumnas()
    {
      List<Columna> lista = new List<Columna>() { 
        new Columna(){
          Nombre = "PQRS",
          Etiqueta = "PQRS",
          EsNivel = true,
          EsVisible = true,
          EsObligatorio = true,
          TipoDato = 1,
          Nivel = 1,
          Principal = true,
          ColumnaPadre = string.Empty  
        },
        new Columna(){
          Nombre = "TIPO",
          Etiqueta = "Tipo",
          EsNivel = true,
          EsVisible = true,
          EsObligatorio = true,
          TipoDato = 1,
          Nivel = 2,
          ColumnaPadre = "PQRS"
        },
        new Columna(){
          Nombre = "MOTIVO",
          Etiqueta = "Motivo",
          EsNivel = true,
          EsVisible = true,
          EsObligatorio = true,
          TipoDato = 1,
          Nivel = 3,
          ColumnaPadre = "TIPO"
        },
        new Columna(){
          Nombre = "IdNivel4",
          Etiqueta = "Concepto",
          EsNivel = true,
          EsVisible = true,
          EsObligatorio = true,
          TipoDato = 1,
          Nivel = 4,
          ColumnaPadre = "MOTIVO"
        },
      };
      return lista;
    }
    #endregion
  }
}