using ForoEFapi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ForoEFapi
{
    public class ApplicationBdContext : DbContext
    {
        public ApplicationBdContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(g => g.Id);
           modelBuilder.Entity<Usuario>().Property(g => g.Nombre).HasMaxLength(30);
        }
        public DbSet<Usuario> Usuarios => Set<Usuario>();
    }
}
