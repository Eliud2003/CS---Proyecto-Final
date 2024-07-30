using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proyecto___CS.Controller;
using Proyecto___CS.View;
using Proyecto___CS.Repository;
using static System.Formats.Asn1.AsnWriter;
using Proyecto___CS.Service.Interfaces;
using Proyecto___CS.Service.Services;

namespace Proyecto___CS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    File.WriteAllText("migration_errors.txt", ex.ToString());
                    MessageBox.Show($"Error during migration: {ex.Message}");
                }

                var services = scope.ServiceProvider;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var generalForm = services.GetRequiredService<GeneralForm>();
                Application.Run(generalForm);
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("ProjectConnection");

                    // Configurar el DbContext con la cadena de conexión
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Registrar servicios
                    services.AddScoped(typeof(IManagement<>), typeof(ManagementService<>));
                    services.AddScoped(typeof(IGetDriverBy), typeof(DriverService));
                    services.AddScoped(typeof(IGetVehicleBy), typeof(VehicleService));

                    // Registrar controladores
                    services.AddTransient<DriverController>();
                    services.AddTransient<RouteController>();
                    services.AddTransient<VehicleController>();

                    // Registrar formularios
                    services.AddTransient<VehicleForm>();
                    services.AddTransient<DriverForm>();
                    services.AddTransient<GeneralForm>();
                });
    }
}