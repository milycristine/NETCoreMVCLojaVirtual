using LojaVirtual.Database;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using LojaVirtual.Repositories;
using LojaVirtual.Repositories.Contracts;
using LojaVirtual.Libraries.Sessao;
using LojaVirtual.Libraries.Login;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
// Padrão Repository
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<INewsletterRepository, NewsletterRepository>();

builder.Services.AddHttpContextAccessor();


//Configurações - Session
builder.Services.AddMemoryCache(); //Guardar os dados na memoria
builder.Services.AddSession(options=>
{
   
});

builder.Services.AddScoped<Sessao>();
builder.Services.AddScoped<LoginCliente>();

builder.Services.AddControllersWithViews();
string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
builder.Services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
    