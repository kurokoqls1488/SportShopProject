using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SportShopProject.Models;

namespace SportShopProject;

public partial class SportShopDbContext : DbContext
{
    public SportShopDbContext()
    {
    }

    public SportShopDbContext(DbContextOptions<SportShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<DeliveryPoint> DeliveryPoints { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersStortGood> OrdersStortGoods { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SportsGood> SportsGoods { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("host=localhost;port=5432;username=postgres;database=sport_shop_db;password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<DeliveryPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("delivery_point_pkey");

            entity.ToTable("delivery_points");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('delivery_point_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.DeliveryAddres).HasColumnName("delivery_addres");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturers_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameManufacturer).HasColumnName("name_manufacturer");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.IdDeliveryPoint).HasColumnName("id_delivery_point");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");

            entity.HasOne(d => d.IdDeliveryPointNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdDeliveryPoint)
                .HasConstraintName("orders_id_delivery_point_fkey");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("orders_id_status_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("orders_id_user_fkey");
        });

        modelBuilder.Entity<OrdersStortGood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_stort_goods_pkey");

            entity.ToTable("orders_stort_goods");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdSportGood).HasColumnName("id_sport_good");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.OrdersStortGoods)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("orders_stort_goods_id_order_fkey");

            entity.HasOne(d => d.IdSportGoodNavigation).WithMany(p => p.OrdersStortGoods)
                .HasForeignKey(d => d.IdSportGood)
                .HasConstraintName("orders_stort_goods_id_sport_good_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameRole).HasColumnName("name_role");
        });

        modelBuilder.Entity<SportsGood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sports_goods_pkey");

            entity.ToTable("sports_goods");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Articul).HasColumnName("articul");
            entity.Property(e => e.CountInStock).HasColumnName("count_in_stock");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdUnitsOfMeasurement).HasColumnName("id_units_of_measurement");
            entity.Property(e => e.NameGoods).HasColumnName("name_goods");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.SportsGoods)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("sports_goods_id_category_fkey");

            entity.HasOne(d => d.IdManufacturerNavigation).WithMany(p => p.SportsGoods)
                .HasForeignKey(d => d.IdManufacturer)
                .HasConstraintName("sports_goods_id_manufacturer_fkey");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.SportsGoods)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("sports_goods_id_supplier_fkey");

            entity.HasOne(d => d.IdUnitsOfMeasurementNavigation).WithMany(p => p.SportsGoods)
                .HasForeignKey(d => d.IdUnitsOfMeasurement)
                .HasConstraintName("sports_goods_id_units_of_measurement_fkey");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameStatus).HasColumnName("name_status");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameSupplier).HasColumnName("name_supplier");
        });

        modelBuilder.Entity<UnitsOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("units_of_measurement_pkey");

            entity.ToTable("units_of_measurement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameUnits).HasColumnName("name_units");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
