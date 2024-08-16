using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-R6HQSGCC;Database=BOTAS_db;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;", null);
        }
    }
}
