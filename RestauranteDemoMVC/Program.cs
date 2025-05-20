var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient("CoverManager", client =>
{
    var config = builder.Configuration.GetSection("CoverManager");
    var baseUrl = config["BaseUrl"];
    if (string.IsNullOrEmpty(baseUrl))
    {
        throw new InvalidOperationException("El valor de configuración 'BaseUrl' para 'CoverManager' está vacío.");
    }
    client.BaseAddress = new Uri(baseUrl);
    client.DefaultRequestHeaders.Add("x-api-key", config["ApiKey"] ?? throw new InvalidOperationException("Falta el valor de configuración 'ApiKey' para 'CoverManager'."));
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

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
