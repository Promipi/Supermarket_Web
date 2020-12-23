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
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Family)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Gmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.DateMade).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("Fk_Orders_Clients");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasOne(d => d.ArticleNavigation);
                    

                entity.HasOne(d => d.OrderNavigation)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("Fk_Purchases_Order");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
