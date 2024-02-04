using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UdemyEFCore.DatabaseFirstByScaffold.Models
{
    public partial class UdemyEFCoreDatabaseFirstDbContext : DbContext
    // Bu kısmı Package Manager Console Scaffold-DbContext "Data Source=EFRUN\\SQLEXPRESS; Initial Catalog=UdemyEFCoreDatabaseFirstDb; Integrated Security=True; Trust Server Certificate=False;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models yazarak yaprık.
    {
        public UdemyEFCoreDatabaseFirstDbContext()
        {
        }

        public UdemyEFCoreDatabaseFirstDbContext(DbContextOptions<UdemyEFCoreDatabaseFirstDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=EFRUN\\SQLEXPRESS; Initial Catalog=UdemyEFCoreDatabaseFirstDb; Integrated Security=True; Trust Server Certificate=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
