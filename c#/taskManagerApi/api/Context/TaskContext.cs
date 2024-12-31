using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<API.Entities.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<API.Entities.Task>(entity =>
            {
                entity.ToTable("Task");
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Id)
                      .ValueGeneratedOnAdd()
                      .HasColumnName("TaskId")
                      .IsRequired();

                entity.Property(x => x.Title)
                      .HasMaxLength(255)
                      .IsRequired();

                entity.Property(x => x.Description)
                      .HasMaxLength(1000);

                entity.Property(x => x.Date)
                      .IsRequired();

                entity.Property(x => x.Status)
                      .HasMaxLength(50)
                      .IsRequired();
            });
        }
    }
}
