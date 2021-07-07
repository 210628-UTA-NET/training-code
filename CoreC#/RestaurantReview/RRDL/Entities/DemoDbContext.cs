using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RRDL.Entities
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
        {
        }

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RestaurantName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RestaurantState)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Review");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Rating).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ReviewDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Restaurant)
                    .WithMany()
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("foreign_key");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
