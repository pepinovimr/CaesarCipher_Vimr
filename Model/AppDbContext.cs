using Microsoft.EntityFrameworkCore;

namespace CaesarCipher_Vimr.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<CryptoContent> Cryptos { get; set; }
    }
}
