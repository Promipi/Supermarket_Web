using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.SERVER.Models
{
    public partial class Supermarket_DbContext : DbContext
    {
        public Supermarket_DbContext() { }
        public Supermarket_DbContext(DbContextOptions<Supermarket_DbContext> options) : base(options) { }

        /*DB SETS */
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Direc.SqlConnection); //decimos que utilizaremos el gestor sql Server y le pasamos la cadena de conexion a la base de datos
            } 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("Articles");

                entity.Property(e => e.Id);

                entity.Property(e => e.Description).HasMaxLength(100);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
