

using MetalixDemoErp.Entitiy;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MetalixDemoErp.DataAccessLayer
{
    public class Context : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=LAPTOP-B8EPBOM7;database=MetalixDemoDbDemo; integrated security=true;TrustServerCertificate=True;Trusted_Connection=True", options => options.EnableRetryOnFailure());
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(c => c.CompanyId)
                .ValueGeneratedOnAdd();

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<DangilNo> DangilNoes { get; set; }

        

    }
}
