using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PetInfoAPI.Models
{
    public partial class PetStoreDBContext : DbContext
    {
        public PetStoreDBContext()
        {
        }

        public PetStoreDBContext(DbContextOptions<PetStoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailablePet> AvailablePets { get; set; } = null!;
        public virtual DbSet<PetProduct> PetProducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PetStoreDB;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailablePet>(entity =>
            {
                entity.HasKey(e => e.PetId)
                    .HasName("PK__Availabl__48E53862A33F7A2F");

                entity.Property(e => e.Class).HasMaxLength(30);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Species).HasMaxLength(30);
            });

            modelBuilder.Entity<PetProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__PetProdu__B40CC6CDA5080CB2");

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Species).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
