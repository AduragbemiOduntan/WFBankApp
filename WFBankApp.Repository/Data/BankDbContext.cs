using Microsoft.EntityFrameworkCore;
using WFbankApp.Models.Models;

namespace WFBankApp.Repository.Data
{
    public class BankDbContext : DbContext
    {
        private string connectionString;

        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options) { }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BankTransaction> Transactions { get; set; }
    }
}
