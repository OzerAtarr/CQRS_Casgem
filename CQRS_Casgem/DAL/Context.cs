using Microsoft.EntityFrameworkCore;

namespace CQRS_Casgem.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FCHRJ42\\SQLEXPRESS;initial catalog=CasgemCQRSDb;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
