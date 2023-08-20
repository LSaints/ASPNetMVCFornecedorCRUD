using FornecedorCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace FornecedorCRUD.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FornecedorCRUDContext>(options
                => options.UseSqlServer(configuration.GetConnectionString("FornecedorCRUDContext")));
        }

        public static void UseDatabaseConfiguration(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<FornecedorCRUDContext>();
            context.Database.Migrate();
            context.Database.EnsureCreated();
        }
    }
}
