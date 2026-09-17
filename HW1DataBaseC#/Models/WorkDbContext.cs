using Microsoft.EntityFrameworkCore;

class WorkDbContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Category> Categorys { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=VIVOBOOK16\\MSSQLSERVER_2022;Database=P_51;Integrated Security=True;TrustServerCertificate=True;");
    }
}
