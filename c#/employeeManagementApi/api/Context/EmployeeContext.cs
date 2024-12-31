using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLog> EmployeeLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("hr_system");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Extension).HasMaxLength(10);
                entity.Property(e => e.WorkEmail).HasMaxLength(100);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.Salary).HasColumnType("decimal(18,2)");
                entity.Property(e => e.HireDate).IsRequired();
            });

            modelBuilder.Entity<EmployeeLog>(entity =>
            {
                entity.ToTable("EmployeeLogs");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().IsRequired();
                entity.Property(e => e.PartitionKey).HasMaxLength(50).IsRequired();
                entity.Property(e => e.RowKey).HasMaxLength(50).IsRequired();
                entity.Property(e => e.ActionType).IsRequired();
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Extension).HasMaxLength(10);
                entity.Property(e => e.WorkEmail).HasMaxLength(100);
                entity.Property(e => e.Department).HasMaxLength(50);
                entity.Property(e => e.Salary).HasColumnType("decimal(18,2)");
                entity.Property(e => e.HireDate).IsRequired();
            });
        }
    }
}
