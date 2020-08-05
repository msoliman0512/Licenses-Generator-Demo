using FluentMigrator.Runner;
using Licenses_Generator_Demo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Reflection;

namespace Licenses_Generator_Demo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddTransient<GovernoratesService>(); // add GovernoratesService
            services.AddTransient<CitiesService>();
            services.AddTransient<AddressesService>();
            services.AddTransient<ClientsService>();
            services.AddFluentMigratorCore().ConfigureRunner(config => config.AddSqlServer()
                .WithGlobalConnectionString("Data Source=DESKTOP-T5SCRE7;Initial Catalog=Licenses-Generator;Persist Security Info=True;User ID=SA;Password=Mahmoud_Soliman0512")
                .ScanIn(Assembly.GetExecutingAssembly()).For.All()).AddLogging(config => config.AddFluentMigratorConsole());   /* .ScanIn(typeof(AddLogTable).Assembly).For.Migrations())
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                // Build the service provider
                .BuildServiceProvider(false); */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
            });

            using var scope = app.ApplicationServices.CreateScope();
            var migrator = scope.ServiceProvider.GetService<IMigrationRunner>();
            migrator.MigrateUp();
            // migrator.MigrateDown(0);

            LLBLGen(Configuration);
        }

        public static void LLBLGen(IConfiguration config)
        {
            RuntimeConfiguration.AddConnectionString("ConnectionString.SQL Server (SqlClient)", config["ConnectionStrings:Licenses_Generator.Module"]);
            RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c =>
            {
                c.AddDbProviderFactory(typeof(System.Data.SqlClient.SqlClientFactory))
                    .SetDefaultCompatibilityLevel(SqlServerCompatibilityLevel.SqlServer2012);

                c.SetTraceLevel(System.Diagnostics.TraceLevel.Verbose);
            });
        }
    }
}