using Microsoft.EntityFrameworkCore;
using Net7.WebApi.Entidades;

namespace Net7.WebApi.Persistencia
{
    public class Context : DbContext    
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        public Context() { }
               
        public DbSet<Fruta> Frutas { get; set; } = null!;
    }
}
