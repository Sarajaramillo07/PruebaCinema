using Lib_Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace lib_repositorios.Interfaces
{                //Hicimos las referencias entre librerias, Lib_Repositorio contiene la dependencia de Lib_Dominio  
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Peliculas>? Peliculas { get; set; }
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}