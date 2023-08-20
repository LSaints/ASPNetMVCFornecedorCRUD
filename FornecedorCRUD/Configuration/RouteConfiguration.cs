namespace FornecedorCRUD.Configuration
{
    public static class RouteConfiguration
    {
        public static void RegisterRoutesConfiguration(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
