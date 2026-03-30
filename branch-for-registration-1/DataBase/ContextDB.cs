using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace branch_for_registration_1.DataBase
{
    /// <summary>
    /// Класс работы с базой данных
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Модель таблицы Ролей
        /// </summary>
        public DbSet<Role> Roles { get; set; }
        /// <summary>
        /// Модель таблицы Пользователей
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Модель таблицы с Категориями
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// Модель таблицы с Товарами
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Модель таблицы Отрузок
        /// </summary>
        public DbSet<Shipment> Shipments { get; set; }
        /// <summary>
        /// Модель таблицы Айди отгрузок
        /// </summary>
        public DbSet<ShipmentItem> ShipmentItems { get; set; }

        /// <summary>
        /// Модель таблицы адресов
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        // Для тестировния
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public AppDbContext()
        { }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var connectionString = ConfigurationManager
                        .ConnectionStrings["DefaultConnection"]
                        .ConnectionString;

                    optionsBuilder.UseNpgsql(connectionString);
                }
            }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Роли
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(r => r.Id);
                // Автоматическая генерация Guid в PostgreSQL
                entity.Property(r => r.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(r => r.Title).IsRequired().HasMaxLength(50);
                entity.HasIndex(r => r.Title).IsUnique(); // уникальное название роли
            });

            // Пользователи 
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(u => u.LastName).IsRequired().HasMaxLength(50);
                entity.Property(u => u.MiddleName).HasMaxLength(50);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(100);
                entity.HasIndex(u => u.Email).IsUnique(); // уникальный email
                entity.Property(u => u.PasswordHash).IsRequired().HasMaxLength(256);
                entity.Property(u => u.RoleId).IsRequired();
                entity.Property(u => u.IsActive).HasDefaultValue(true);
                // Связь с Role
                entity.HasOne(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId).OnDelete(DeleteBehavior.Restrict);
            });

            // Категории 
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(c => c.Name).IsUnique();
            });

            // Товары 
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(p => p.Article).IsRequired().HasMaxLength(50);
                entity.HasIndex(p => p.Article).IsUnique(); // уникальный артикул
                entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Unit).HasMaxLength(20);
                entity.Property(p => p.PurchasePrice).HasColumnType("decimal(18,2)");
                entity.Property(p => p.CurrentStock).IsRequired();
                // Связь с Category
                entity.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
            });

            // Отгрузки 
            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(x => x.ShipmentDate).IsRequired();

                // Связь с User
                entity.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(x => x.Address).WithMany().HasForeignKey(x => x.AddressId).OnDelete(DeleteBehavior.Restrict);
            });

            // Адреса
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).HasDefaultValueSql("gen_random_uuid()");

                entity.Property(x => x.Country).IsRequired().HasMaxLength(100);
                entity.Property(x => x.City).IsRequired().HasMaxLength(100);
                entity.Property(x => x.Region).HasMaxLength(100);
                entity.Property(x => x.Street).IsRequired().HasMaxLength(150);
                entity.Property(x => x.Building).IsRequired().HasMaxLength(50);
            });

            // Позиции отгрузок 
            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.HasKey(si => si.Id);
                entity.Property(si => si.Id).HasDefaultValueSql("gen_random_uuid()");
                entity.Property(si => si.Quantity).IsRequired();
                // Связь с Shipment
                entity.HasOne(si => si.Shipment).WithMany(s => s.ShipmentItems).HasForeignKey(si => si.ShipmentId).OnDelete(DeleteBehavior.Cascade);
                // Связь с Product
                entity.HasOne(si => si.Product).WithMany().HasForeignKey(si => si.ProductId).OnDelete(DeleteBehavior.Restrict);
            });
        }

        /// <summary>
        /// Создаёт базу данных, если она не существует
        /// </summary>
        public void EnsureDatabaseCreated()
        {
            Database.EnsureCreated();
        }
    }
}