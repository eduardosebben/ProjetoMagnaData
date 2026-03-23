using Controlelistatarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Controlelistatarefas.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tarefa> Tarefas => Set<Tarefa>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=dna_vsf;Database=ControleListaTarefas;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>(entity =>
            {
                entity.ToTable("Tarefas");
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Descricao)
                      .IsRequired()
                      .HasMaxLength(250);

                entity.Property(t => t.DataCriacao)
                      .IsRequired();

                entity.Property(t => t.DataConclusao)
                      .IsRequired(false);
            });
        }
    }
}