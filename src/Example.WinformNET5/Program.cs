using Example.Persistence.Contexts;
using Example.Persistence.GenericRepository;
using Example.Persistence.Repositories.DeveloperRepository;
using Example.Persistence.Repositories.ProjectRepository;
using Example.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace Example.WinformNET5
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder()
              .ConfigureServices((hostContext, services) =>
              {
                  services.AddScoped<Form1>();
                  // -- Using File Configuration appsetting.json
                  // "ConnectionStrings": {
                  //    "DefaultConnection": "Data Source=dbexample.db"
                  //  }
                  //

                  //services.AddDbContext<ApplicationContext>(options =>
                  //options.UseSqlite(
                  //    Configuration.GetConnectionString("DefaultConnection"),
                  //    b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
                  //
                  // Or
                  services.AddDbContext<ApplicationDbContext>(options =>
                     options.UseSqlite("Data Source=dbexample.db"));

                  #region Repositories
                  services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                  services.AddTransient<IDeveloperRepository, DeveloperRepository>();
                  services.AddTransient<IProjectRepository, ProjectRepository>();
                  #endregion
                  services.AddTransient<IUnitOfWork, UnitOfWork>();
              });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var service = serviceScope.ServiceProvider;
                var form1 = service.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
    }
}
