using Gurka.Models;
using System.Data.Entity;

namespace Gurka.Data
{
    public class GurkaDbContext : DbContext
    {
        public GurkaDbContext() : base("GurkaConnection")
        {
        }

        public DbSet<Person> Persons { get; set; } 
    }
}