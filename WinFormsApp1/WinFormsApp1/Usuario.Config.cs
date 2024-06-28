using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class WinFormsApp1 : DbContext
    {
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=sad.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}

