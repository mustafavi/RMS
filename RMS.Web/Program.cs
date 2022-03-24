using RMS.Infrastructure;
using RMS.Infrastructure.Repositories;
using RMS.Data.Models2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddTransient<RMSContext>();
builder.Services.AddTransient<IRepository<Bill>, BillRepository>();
builder.Services.AddTransient<IRepository<Expense>, ExpenseRepository>();
builder.Services.AddTransient<IRepository<Flat>, FlatRepository>();
builder.Services.AddTransient<IRepository<Property>, PropertyRepository>();
builder.Services.AddTransient<IRepository<Rent>, RentRepository>();
builder.Services.AddTransient<IRepository<Tenant>, TenantRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
