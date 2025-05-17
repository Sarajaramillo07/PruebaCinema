using System.ComponentModel.DataAnnotations;

namespace Lib_Dominio.Entidades
{
    public class Peliculas
    {
      [Key]  public int Id { get; set; }// key es añadido 
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
    }
}
