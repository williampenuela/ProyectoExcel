using ResultadoExcel.Context;
using ResultadoExcel.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Se agregaron estos builder para que el proyecto inicie correctamente
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<ICombustibleService, CombustibleService>();

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
    pattern: "{controller=Combustibles}/{action=Index}/{id?}");

app.Run();
