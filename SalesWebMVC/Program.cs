using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMVC.Data;
using SalesWebMVC.Repositories;
using SalesWebMVC.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SalesWebMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWebMVCContext") ?? throw new InvalidOperationException("Connection string 'SalesWebMVCContext' not found.")));

 void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IDepartmentRepository, DepartmentRepository>();
    services.AddTransient<ISalesRecordRepository, SalesRecordRepository>();
    services.AddTransient<ISellerRepository, SellerRepository>();
    //services.AddTransient<ISeedingRepository, SeedingRepository>();

    services.AddControllersWithViews();
}
builder.Services.AddControllersWithViews();
// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

//builder.Services.AddTransient<ISeedingService, SeedingService>

//pp.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.Run();
