using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WFBankApp.Repository.Data;

namespace WFBankApp
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

            /*  Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);

              // Configuration setup
              var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

              IConfiguration configuration = configurationBuilder.Build();

              // Get the connection string from the configuration
              string connectionString = configuration.GetConnectionString("DefaultConnection");
  */
            // Pass the connection string to the main form


            /*            Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);

                        // Configuration setup
                        var configurationBuilder = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                        IConfiguration configuration = configurationBuilder.Build();
                        var connectionString = configuration.GetConnectionString("DefaultConnection");

                        var optionsBuilder = new DbContextOptionsBuilder<BankDbContext>();
                        optionsBuilder.UseSqlServer(connectionString);

                        // Create the YourDbContext instance using dependency injection
                        using (var dbContext = new BankDbContext(optionsBuilder.Options))
                        {
                            Application.Run(new Form1(dbContext));
                        }*/


        }
    }
}