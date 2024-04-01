using Microsoft.EntityFrameworkCore;
using TransacoesProjeto.Models;

namespace TransacoesProjeto.Data.context
{
    public class ApplicationDbContext(IConfiguration configuration) : DbContext
    {

        protected readonly IConfiguration Configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

    }
}
