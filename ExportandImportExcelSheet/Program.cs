using ExportandImportExcelSheet.Data;
using ExportandImportExcelSheet.Interface;
using ExportandImportExcelSheet.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<SchooleDBPractice>
    (options =>options.UseSqlServer( builder.Configuration.GetConnectionString("DefaultConnection"),
     b => b.MigrationsAssembly(typeof(SchooleDBPractice).Assembly.FullName)));
builder.Services.AddMvc();

builder.Services.AddScoped<IBaseServices, BasicRepository>();

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
