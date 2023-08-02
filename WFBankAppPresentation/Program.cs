using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WFBankApp.Repository.Data;

namespace WFBankAppPresentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IConfiguration Configuration;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            ServiceCollection services = new ServiceCollection();
            //Add Services Here
            services.AddTransient<Form1>();
            services.AddDbContext<BankDbContext>(option => option
                .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
            
        }
    }
}