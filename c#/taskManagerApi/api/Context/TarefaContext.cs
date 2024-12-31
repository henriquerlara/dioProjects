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
                entity.ToTable("Tarefas"); // Nome da tabela no banco
                entity.HasKey(x => x.Id); // Chave primária
                
                entity.Property(x => x.Id)
                      .ValueGeneratedOnAdd() // Auto incremento
                      .HasColumnName("TarefaId") // Nome da coluna no banco
                      .IsRequired();

                entity.Property(x => x.Titulo)
                      .HasMaxLength(255) // Limite de caracteres
                      .IsRequired();

                entity.Property(x => x.Descricao)
                      .HasMaxLength(1000); // Limite de caracteres (não obrigatório)

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
