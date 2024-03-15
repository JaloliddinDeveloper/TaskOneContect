//========
//Contacts
//========
using EFxceptions;
using Microsoft.EntityFrameworkCore;
namespace TaskOneContect.Models
{
    internal class StorageBroker:EFxceptionsContext
    {
        public StorageBroker()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=KontactDB;Integrated Security=True;TrustServerCertificate=True");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Foydalanuvchilar Jadvali");
            modelBuilder.Entity<User>().HasKey(a => a.UserId).HasName("Foydalanuvchi Raqami");
            modelBuilder.Entity<User>().Property(b => b.UserName).HasColumnName("Ismi").HasMaxLength(20);
            modelBuilder.Entity<User>().Property(c => c.UserPhoneNumber).HasColumnName("Tel Raqami").HasMaxLength(20);
        }
        public DbSet<User> Users { get; set; }
    }
}
