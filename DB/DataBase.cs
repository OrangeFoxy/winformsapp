using Microsoft.EntityFrameworkCore;

namespace WinFormsApp.DB
{
    public class DataBase : DbContext
    {
        public string nameDB { get; private set; } = "money.db";
        public DbSet<User> Users { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DataBase() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={nameDB}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Login);
            modelBuilder.Entity<User>().Property(u => u.Pass).IsRequired();

            modelBuilder.Entity<Operation>().Property(o => o.Sum).HasDefaultValue(0);

        }
    }
}
