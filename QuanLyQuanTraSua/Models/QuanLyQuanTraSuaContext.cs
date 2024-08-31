using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace QuanLyQuanTraSua.Models
{
    public partial class QuanLyQuanTraSuaContext : DbContext
    {
        public QuanLyQuanTraSuaContext()
        {
        }

        public QuanLyQuanTraSuaContext(DbContextOptions<QuanLyQuanTraSuaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillInformation> BillInformations { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<FoodCategory> FoodCategories { get; set; } = null!;
        public virtual DbSet<RoleAccount> RoleAccounts { get; set; } = null!;
        public virtual DbSet<TableFood> TableFoods { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
                IConfiguration con = builder.Build();
                string connect = con.GetValue<string>("ConnectionStrings:value");
                optionsBuilder.UseSqlServer(connect);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__Account__591D27A4F64048F7");

                entity.ToTable("Account");

                entity.Property(e => e.UserName)
                    .HasMaxLength(300)
                    .HasColumnName("user_Name");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(300)
                    .HasColumnName("display_Name")
                    .HasDefaultValueSql("(N'Fpter')");

                entity.Property(e => e.IdRole).HasColumnName("id_Role");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password")
                    .HasDefaultValueSql("((123))");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_role");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.IdBill)
                    .HasName("PK__Bill__A9BEA432A7783F75");

                entity.ToTable("Bill");

                entity.Property(e => e.IdBill).HasColumnName("id_Bill");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasColumnName("date_CheckIn")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut)
                    .HasColumnType("date")
                    .HasColumnName("date_CheckOut");

                entity.Property(e => e.IdTable).HasColumnName("id_Table");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdTableNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.IdTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_Bill");
            });

            modelBuilder.Entity<BillInformation>(entity =>
            {
                entity.HasKey(e => e.IdBillInfor)
                    .HasName("PK__BillInfo__4C720976F1B532AC");

                entity.ToTable("BillInformation");

                entity.Property(e => e.IdBillInfor).HasColumnName("id_Bill_Infor");

                entity.Property(e => e.IdBill).HasColumnName("id_Bill");

                entity.Property(e => e.IdFood).HasColumnName("id_Food");

                entity.Property(e => e.Quanlity)
                    .HasColumnName("quanlity")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdBillNavigation)
                    .WithMany(p => p.BillInformations)
                    .HasForeignKey(d => d.IdBill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BillInformation_Bill");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.BillInformations)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BillInformation_Food");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.IdFood)
                    .HasName("PK__Food__E99B0E54FF8B294F");

                entity.ToTable("Food");

                entity.Property(e => e.IdFood).HasColumnName("id_Food");

                entity.Property(e => e.IdCategory).HasColumnName("id_Category");

                entity.Property(e => e.NameFood)
                    .HasMaxLength(200)
                    .HasColumnName("name_Food")
                    .HasDefaultValueSql("(N'Unknown name')");

                entity.Property(e => e.PriceFood).HasColumnName("price_Food");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Category_Food");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__FoodCate__5C2BE25970813AB1");

                entity.ToTable("FoodCategory");

                entity.Property(e => e.IdCategory).HasColumnName("id_Category");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(300)
                    .HasColumnName("name_Category")
                    .HasDefaultValueSql("(N'Unknown name')");
            });

            modelBuilder.Entity<RoleAccount>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__RoleAcco__5E5EB16B5FD88265");

                entity.ToTable("RoleAccount");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("id_Role");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .HasColumnName("description");

                entity.Property(e => e.NameRole)
                    .HasMaxLength(200)
                    .HasColumnName("name_Role");
            });

            modelBuilder.Entity<TableFood>(entity =>
            {
                entity.HasKey(e => e.IdTable)
                    .HasName("PK__TableFoo__271C2814E0CAC045");

                entity.ToTable("TableFood");

                entity.Property(e => e.IdTable).HasColumnName("id_Table");

                entity.Property(e => e.MaximunPeople).HasColumnName("maximun_People");

                entity.Property(e => e.NameTable)
                    .HasMaxLength(300)
                    .HasColumnName("name_Table")
                    .HasDefaultValueSql("(N'Unknown name')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
