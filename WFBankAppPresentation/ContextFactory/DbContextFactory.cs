using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBankApp.Repository.Data;

namespace WFBankAppPresentation.ContextFactory
{
    internal class DbContextFactory: IDesignTimeDbContextFactory<BankDbContext>
    {
        public BankDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BankDbContext>()
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("WFBankApp.Repository"));

            return new BankDbContext(builder.Options);
        }
    }
}
