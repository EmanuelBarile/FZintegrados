using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace FZintegrados
{
    public class Startup
    {

        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // agregar servicios aquí


            services.AddDbContext<FZIntegradosContext>(option => option.UseSqlServer(_configuration.GetConnectionString("FZIntegradosSQL")));
        /*
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FZIntegrados", Version = "v1" });

                c.AddFluentValidationRules();
                c.MapType<DateTime>(() => new OpenApiSchema { Type = "string", Format = "date" });
                c.MapType<DateTime?>(() => new OpenApiSchema { Type = "string", Format = "date" });
            });
        */
        }

        public void Configure(IApplicationBuilder app)
        {
            // configurar la aplicación aquí
        }
    }
}