using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestLogin01.Models.db
{
    public partial class FARMContext : DbContext
    {
        public FARMContext()
        {
        }

        public FARMContext(DbContextOptions<FARMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\JENKINS;Database=FARM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMERS");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("customer_id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .HasColumnName("customer_name");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasColumnName("email_address");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.LoginPassword)
                    .HasMaxLength(50)
                    .HasColumnName("login_password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.Property(e => e.Picture)
                    .HasColumnType("image")
                    .HasColumnName("picture");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCTS");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductDescription).HasColumnName("product_description");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice).HasColumnName("product_price");

                entity.Property(e => e.ProductTypeCode).HasColumnName("product_type_code");

                entity.Property(e => e.ProductUnit).HasColumnName("product_unit");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.HasOne(d => d.ProductNavigation)
                    .WithOne(p => p.Product)
                    .HasForeignKey<Product>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCTS_PRODUCTS");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.ToTable("SELLERS");

                entity.Property(e => e.SellerId)
                    .ValueGeneratedNever()
                    .HasColumnName("seller_id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasColumnName("email_address");

                entity.Property(e => e.LoginPassword)
                    .HasMaxLength(50)
                    .HasColumnName("login_password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.Property(e => e.Picture)
                    .HasColumnType("image")
                    .HasColumnName("picture");

                entity.Property(e => e.SellerName)
                    .HasMaxLength(100)
                    .HasColumnName("seller_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
