using Microsoft.EntityFrameworkCore;
using WebApplicationTEST.Models;

namespace WebApplicationTEST.Context
{
    public class PersonneContext : DbContext
    {
        public PersonneContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Personne> Personnes { get; set; }
    }
}
