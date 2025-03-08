using Cs2CaseOpener.BackgroundServices;
using Cs2CaseOpener.DB;
using Cs2CaseOpener.Extensions;
using Cs2CaseOpener.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddMemoryCache();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
});

builder.Services.AddHttpClient();
builder.Services.AddScoped<DatabaseInitializationService>();
builder.Services.AddScoped<SkinService>();
builder.Services.AddScoped<CrateService>();
builder.Services.AddScoped<ApiScraper>();
builder.Services.AddScoped<RarityService>();
builder.Services.AddScoped<PriceService>();

builder.Services.AddHostedService<ScrapeApiBackgroundService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.WithOrigins("http://localhost", "http://localhost:3000", "http://localhost:5173", "http://10.10.10.46:5020", "https://case.oki.gg")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseRequestLogging();
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("AllowLocalhost");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();

    var dbInitializer = scope.ServiceProvider.GetRequiredService<DatabaseInitializationService>();
    await dbInitializer.InitializeAsync();

    // var scraper = scope.ServiceProvider.GetRequiredService<ApiScraper>();
    // await scraper.ScrapeApi();
}

app.Run();
