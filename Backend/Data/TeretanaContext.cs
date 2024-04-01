using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class TeretanaContext : DbContext
    {

        public TeretanaContext(DbContextOptions<TeretanaContext> options) : base(options) {
        
        
        
        
        }
        public DbSet<Korisnik> Korisnici { get; set; }
      

  

    }
}
