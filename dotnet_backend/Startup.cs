using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using dotnet_backend.Data;
using dotnet_backend.Common;
using dotnet_backend.Contracts.V1;
using FluentValidation.AspNetCore;
//using static dotnet_backend.ProductService;
namespace dotnet_backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(fv =>
                    fv.RegisterValidatorsFromAssemblyContaining<ProductCreateModelValidator>());
            services.AddDbContext<ProductDbContext>(opt => opt.UseInMemoryDatabase("ProductDb"));
            services.AddTransient<ProductService>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            app.UseSpa(config => config.UseProxyToSpaDevelopmentServer("http://localhost:8080/"));
        }
    }
}