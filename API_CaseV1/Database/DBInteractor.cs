using Microsoft.EntityFrameworkCore;

namespace API_CaseV1
{
    public class DBInteractor : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source = Adresgegevens.db;");
        }

        public DbSet<Adressen>? Adressen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adressen>().HasData(

            new Adressen() { Id = 1, Straat = "Gildeplein", Huisnummer = 20, Postcode = "1446BE", Plaats = "Purmerend", Land = "Nederland" },
            new Adressen() { Id = 2, Straat = "Kalverstraat", Huisnummer = 31, Postcode = "1012PC", Plaats = "Amsterdam", Land = "Nederland" }
            );
        }
    }
}
