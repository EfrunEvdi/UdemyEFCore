using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EFRUN\\SQLEXPRESS; Initial Catalog=UdemyEFCoreDatabaseFirstDb; Integrated Security=True; Trust Server Certificate=False;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
