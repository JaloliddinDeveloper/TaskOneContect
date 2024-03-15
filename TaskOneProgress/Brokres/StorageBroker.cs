using EFxceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOneProgress.Models;

namespace TaskOneProgress.Brokres
{
    internal partial class StorageBroker: EFxceptionsContext
    {
        public StorageBroker()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=CompanyDB;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Company> Companys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
