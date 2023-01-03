using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
        }

        public void Configure(IApplicationBuilder app)
        {
            // configurar la aplicación aquí
        }
    }
}
