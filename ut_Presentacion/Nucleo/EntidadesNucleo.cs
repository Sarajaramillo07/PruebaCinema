using Lib_Dominio.Entidades;
namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Peliculas? Peliculas()
        {
            var entidad = new Peliculas();
            entidad.Nombre = "Pruebas"; //Preguntar si se deja acá 'Pruebas' o que se debe poner
            entidad.Tipo = "pruebas";

            return entidad;
        }
    }
}