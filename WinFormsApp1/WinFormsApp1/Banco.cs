using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

        public class Banco : DbContext
        {
            public DbSet<User> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder
           optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=UserOne.db");
            }
        }
    
}
         
