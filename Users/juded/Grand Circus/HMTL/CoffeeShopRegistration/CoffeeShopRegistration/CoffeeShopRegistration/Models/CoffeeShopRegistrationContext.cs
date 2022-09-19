using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeShopRegistration.Models
{
    public partial class CoffeeShopRegistrationContext : DbContext
    {
        public CoffeeShopRegistrationContext()
        {
        }

        public CoffeeShopRegistrationContext(DbContextOptions<CoffeeShopRegistrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegisteredUser> RegisteredUsers { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CoffeeShopRegistration; Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisteredUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
