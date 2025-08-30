using Microsoft.EntityFrameworkCore;

namespace HRManagement.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-F1C7MUGD\\SQLEXPRESS; database=hrmanagement; " +
                "integrated security=true");
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
