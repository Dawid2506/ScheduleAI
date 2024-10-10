using API.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ApplicationDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<User> Users { get; set; }
    public DbSet<WeatherForecast> WeatherForecast { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Predefiniowane dane dla tabeli WeatherForecast
        modelBuilder.Entity<WeatherForecast>().HasData(
            new WeatherForecast { Id = 1, Date = new DateOnly(2024, 9, 18), TemperatureC = 69, Summary = "Sunny" },
            new WeatherForecast { Id = 2, Date = new DateOnly(2024, 9, 19), TemperatureC = 15, Summary = "Cloudy" },
            new WeatherForecast { Id = 3, Date = new DateOnly(2024, 9, 20), TemperatureC = 10, Summary = "Rainy" }
        );
    }
}
