using Microsoft.EntityFrameworkCore;
using MigrateDataPAKN.ModelsPostGre;
using MigrateDataPAKN.ModelsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<PhanAnhKienNghiContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnect")));
builder.Services.AddDbContext<quanlyduanContext>(option => option.UseNpgsql(builder.Configuration.GetConnectionString("PostGreConnect")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
