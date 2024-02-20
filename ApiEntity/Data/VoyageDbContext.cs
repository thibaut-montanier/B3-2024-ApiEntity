using Microsoft.EntityFrameworkCore;

namespace ApiEntity.Data {
    public class VoyageDbContext : DbContext {

        public VoyageDbContext(DbContextOptions<VoyageDbContext> options) : base(options) { }


        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Cours> Cours { get; set; }
    }
}
