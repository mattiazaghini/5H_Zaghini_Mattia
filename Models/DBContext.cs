using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using _5H_Zaghini_Mattia.Models;

public class DBContext : IdentityDbContext
{
    private readonly DbContextOptions _options;
    public DBContext(){}

    public DBContext(DbContextOptions options): base(options)
    {
        _options = options; 
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=database.db");
    public DbSet<Condominio> Condomini { get ; set; }
    public DbSet<AggiungeUnitaImm> AggiungiUnitaImm { get ; set; }
}
