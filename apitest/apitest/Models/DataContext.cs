namespace apitest.Models;

using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<Autos> Auto { get; set; }
    public DbSet<Concesionarios> Concesionario { get; set; }
    public DbSet<AutoConcesionario> AutoConcecionario { get; set; }
}