 using Biblioteca.Components;
using Biblioteca.Models;
using Biblioteca.Services;
using Biblioteca.Services.Book;
using Biblioteca.Services.Category;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

//controllers
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("v1",new OpenApiInfo { Title = "Library API",Version = "v1"});
}); 

builder.Services.AddDbContext<LibraryDbContext>(
    options => options.UseSqlServer("Server=localhost;Database=library;Trusted_Connection=True;TrustServerCertificate=True;")
);

//Mappers
builder.Services.AddTransient<IBookMapper, BookMapper>();
builder.Services.AddTransient<ICategoryMapper, CategoryMapper>();

//Services
builder.Services.AddTransient<IBookService,BookService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

//Http
builder.Services.AddHttpClient("Library App",HttpClient => { HttpClient.BaseAddress = new Uri("http://localhost:5273/"); });

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{   
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//swagger conf
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Library API V1");
});

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
