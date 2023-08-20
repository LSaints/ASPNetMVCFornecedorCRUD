namespace FornecedorCRUD.Configuration
{
    public static class EnviromentConfiguration
    {
        public static void UseEnviromentConfiguration(this IApplicationBuilder appBuilder)
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                appBuilder.UseDeveloperExceptionPage();
                appBuilder.UseHsts();
            }
        }
    }
}
