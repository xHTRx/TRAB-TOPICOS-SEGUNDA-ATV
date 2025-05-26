// src/Context/PetContext.cs
using Microsoft.EntityFrameworkCore;
using API_AdocaoPets.src.Models;

namespace src.Context
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        // Se quiser adicionar outros modelos no futuro:
        // public DbSet<Caes> Caes { get; set; }
        // public DbSet<Gatos> Gatos { get; set; }
        // public DbSet<Canil> Canis { get; set; }
        // public DbSet<Contabilidade> Contabilidades { get; set; }

         // Caso precise configurar manualmente o SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=adocaopets.db");
            }
        }

        // Configurações adicionais do modelo (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().ToTable("Pets");

            // Exemplo de configuração de campo obrigatório
            modelBuilder.Entity<Pet>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
    