using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapeamento das Entidades

            #region Tarefa
            modelBuilder.Entity<Tarefa>(entity =>
            {
                entity.ToTable("Tarefas");
                entity.HasKey(x => x.Id);
                
                entity.Property(x => x.Id)
                      .ValueGeneratedOnAdd() 
                      .HasColumnName("TarefaId") 
                      .IsRequired();

                entity.Property(x => x.Titulo)
                      .HasMaxLength(255) 
                      .IsRequired();

                entity.Property(x => x.Descricao)
                      .HasMaxLength(1000); 

                entity.Property(x => x.Data)
                      .IsRequired(); 

                entity.Property(x => x.Status)
                      .HasMaxLength(50) 
                      .IsRequired();
            });
            #endregion

            #endregion
        }
    }
}
