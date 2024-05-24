using Microsoft.EntityFrameworkCore;
using WebApiPerson2.Models;

namespace WebApiPerson2.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
