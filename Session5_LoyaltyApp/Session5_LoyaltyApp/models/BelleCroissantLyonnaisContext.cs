using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Session5_LoyaltyApp.models;

public partial class BelleCroissantLyonnaisContext : DbContext
{
    public BelleCroissantLyonnaisContext()
    {
    }

    public BelleCroissantLyonnaisContext(DbContextOptions<BelleCroissantLyonnaisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<LoyaltyProgram> LoyaltyPrograms { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<QuantityBasedRuleDetail> QuantityBasedRuleDetails { get; set; }

    public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS02;Initial Catalog=BelleCroissantLyonnais;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Addresse__091C2AFBA5A9DDF8");

            entity.HasIndex(e => e.Type, "UQ__Addresse__F9B8A48B12D1F290").IsUnique();

            entity.Property(e => e.Address1).HasColumnName("Address");
            entity.Property(e => e.Type).HasMaxLength(10);

            entity.HasOne(d => d.User).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Addresses__UserI__6AEFE058");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D83F1FD861");

            entity.HasIndex(e => e.Email, "UQ__Customer__A9D105346AEA6CD5").IsUnique();

            entity.Property(e => e.AverageOrderValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(1);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MembershipStatus)
                .HasMaxLength(20)
                .HasDefaultValue("Basic");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.PreferredCategory).HasMaxLength(50);
            entity.Property(e => e.TotalSpending).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<LoyaltyProgram>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__LoyaltyP__A4AE64D80FFBF29B");

            entity.ToTable("LoyaltyProgram");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.MembershipTier)
                .HasMaxLength(20)
                .HasDefaultValue("Basic");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Orders__55433A6B468104CE");

            entity.Property(e => e.Channel).HasMaxLength(20);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Pending");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Customers");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK__OrderIte__57ED068170000CF4");

            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItems_Products");

            entity.HasOne(d => d.Transaction).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItems_Orders");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6CDAC719391");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PK__Promotio__52C42FCFA137560A");

            entity.Property(e => e.DiscountType).HasMaxLength(20);
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MinimumOrderValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PromotionName).HasMaxLength(100);
        });

        modelBuilder.Entity<QuantityBasedRuleDetail>(entity =>
        {
            entity.HasKey(e => e.RuleId).HasName("PK__Quantity__110458E273B98EE7");

            entity.Property(e => e.DiscountValue).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Promotion).WithMany(p => p.QuantityBasedRuleDetails)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("FK__QuantityB__Promo__7D0E9093");
        });

        modelBuilder.Entity<SecurityQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Security__3214EC077FD5084E");

            entity.HasIndex(e => e.Question, "UQ__Security__6B387A684CA2E345").IsUnique();

            entity.Property(e => e.Question).HasMaxLength(255);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CD14A216B");

            entity.HasIndex(e => e.PhoneNumber, "UQ__Users__85FB4E38FE6ABCA7").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D1053467A5DA41").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(13);
            entity.Property(e => e.PreferredDeliveryMethod).HasMaxLength(8);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
