using Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }


        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>()
               .HasKey(p => p.Id);
  
            modelBuilder.Entity<Endereco>()
                .Property(p => p.Nome)
                .HasMaxLength(100);

            modelBuilder.Entity<Endereco>()
                .Property(p => p.Rua)
                .HasMaxLength(100);

            modelBuilder.Entity<Endereco>()
                .Property(p => p.Numero)
                .HasMaxLength(5);


            modelBuilder.Entity<Endereco>()
                .Property(p => p.Cep)
                .HasMaxLength(8);

            modelBuilder.Entity<Endereco>()
                .Property(p => p.Bairro)
                .HasMaxLength(100);

            modelBuilder.Entity<Endereco>()
                .Property(p => p.Cidade)
                .HasMaxLength(100);

            modelBuilder.Entity<Endereco>()
                .Property(p => p.Estado)
                .HasMaxLength(100);

        }
    }
}



