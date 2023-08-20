using FornecedorCRUD.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

app.UseEnviromentConfiguration();
app.UseDatabaseConfiguration();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.RegisterRoutesConfiguration();
app.Run();
