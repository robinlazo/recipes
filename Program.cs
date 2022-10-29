using WebRecipe.Models;
using Microsoft.EntityFrameworkCore;
using WebRecipe.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string stringConnection = builder.Configuration.GetConnectionString("RecipesContext");
builder.Services.AddDbContext<RecipeContext>(options =>
{
    options.UseSqlServer(stringConnection);
});

builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddRouting(options => {
    options.LowercaseUrls = true;
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<IFav, Fav>();

builder.Services.AddControllersWithViews();


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
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Recipe}/{action=Index}/{id?}/{slug?}");
});

app.Run();
