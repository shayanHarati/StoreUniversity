using Microsoft.EntityFrameworkCore;
using StoreUniversity.Context.DataBase;
using StoreUniversity.Services;
using StoreUniversity.Services.RoleServices;
using StoreUniversity.Services.UserServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DB>(c=>c.UseSqlServer(builder.Configuration.GetConnectionString("Server")));

builder.Services.AddTransient<IUser, UserService>();
builder.Services.AddTransient<IUser_Role, User_RoleService>();





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
