using Microsoft.EntityFrameworkCore;
using TaskOneProgress.Models;

namespace TaskOneProgress.Brokres
{
    internal partial class StorageBroker
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Kampaniya");
            modelBuilder.Entity<Company>().HasKey(a => a.Id).HasName("KompaniyaRaqami");
            modelBuilder.Entity<Company>().Property(b => b.CompanyName).HasColumnName("KompaniyaNomi").HasMaxLength(40);
            modelBuilder.Entity<User>().ToTable("Foydalanuvchilar");
            modelBuilder.Entity<User>().HasKey(c => c.Id).HasName("FoydalanuvchiRaqami");
            modelBuilder.Entity<User>().Property(d => d.FirstName).HasColumnName("Ismi").HasMaxLength(40);
            modelBuilder.Entity<User>().Property(d => d.Age).HasColumnName("Yoshi");
            modelBuilder.Entity<User>().HasOne(g=>g.Company).WithMany(h=>h.Users).HasForeignKey(g=>g.ComIdFK);
        }
    }
}
