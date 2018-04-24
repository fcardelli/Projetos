using Microsoft.EntityFrameworkCore;

namespace EFMvcProject.Models
{
    public class EfDbWebContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=EfDbWebDemo;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=EfDbWebDemo;User Id=SA;
Password=fe@811738;");

        }

        /*public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EfDbWebContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("EfDbWebDemo")));
        }*/
    }
}






