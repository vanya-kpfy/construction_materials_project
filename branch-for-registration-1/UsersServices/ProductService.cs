using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace branch_for_registration_1.UsersServices
{
    public class ProductService : IDisposable
    {
        private readonly AppDbContext db;

        public ProductService()
        {
            db = new AppDbContext();
        }

        // Для тестов / DI
        public ProductService(AppDbContext context)
        {
            db = context;
        }

        /// <summary>
        /// Получить список товаров для отображения
        /// </summary>
        public List<ProductDto> GetProducts()
        {
            return db.Products
                .AsNoTracking()
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Article = p.Article,
                    Name = p.Name,
                    CategoryName = p.Category.Name,
                    Unit = p.Unit,
                    PurchasePrice = p.PurchasePrice,
                    CurrentStock = p.CurrentStock
                })
                .OrderBy(p => p.Name)
                .ToList();
        }

        /// <summary>
        /// Получить товары по категории
        /// </summary>
        public List<ProductDto> GetProductsByCategory(Guid categoryId)
        {
            return db.Products
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Article = p.Article,
                    Name = p.Name,
                    CategoryName = p.Category.Name,
                    Unit = p.Unit,
                    PurchasePrice = p.PurchasePrice,
                    CurrentStock = p.CurrentStock
                })
                .OrderBy(p => p.Name)
                .ToList();
        }

        /// <summary>
        /// Поиск товаров
        /// </summary>
        public List<ProductDto> SearchProducts(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return GetProducts();

            return db.Products
                .AsNoTracking()
                .Where(p =>
                    p.Article.Contains(searchText) ||
                    p.Name.Contains(searchText))
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Article = p.Article,
                    Name = p.Name,
                    CategoryName = p.Category.Name,
                    Unit = p.Unit,
                    PurchasePrice = p.PurchasePrice,
                    CurrentStock = p.CurrentStock
                })
                .OrderBy(p => p.Name)
                .ToList();
        }

        /// <summary>
        /// Получить товар по Id
        /// </summary>
        public Product GetProductById(Guid id)
        {
            return db.Products
                .FirstOrDefault(p => p.Id == id);
        }

        public void CreateProduct(Product product)
        {
            if (db.Products.Any(p => p.Article == product.Article))
                throw new Exception("Product with this article already exists");

            product.Id = Guid.NewGuid();

            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product updated)
        {
            var existing = db.Products.FirstOrDefault(p => p.Id == updated.Id);

            if (existing == null)
                throw new Exception("Product not found");

            if (existing.Article != updated.Article &&
                db.Products.Any(p => p.Article == updated.Article))
            {
                throw new Exception("Product with this article already exists");
            }

            existing.Name = updated.Name;
            existing.Article = updated.Article;
            existing.CategoryId = updated.CategoryId;
            existing.Unit = updated.Unit;
            existing.PurchasePrice = updated.PurchasePrice;
            existing.CurrentStock = updated.CurrentStock;

            db.SaveChanges();
        }

        public void DeleteProduct(Guid id)
        {
            var product = db.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return;

            bool usedInShipment = db.ShipmentItems.Any(si => si.ProductId == id);

            if (usedInShipment)
                throw new Exception("Cannot delete product used in shipments");

            db.Products.Remove(product);
            db.SaveChanges();
        }

        public List<ProductDto> SearchProductsAdvanced(string article, string name, Guid? categoryId)
        {
            var query = db.Products.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(article))
            {
                query = query.Where(p => p.Article.Contains(article));
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

            return query
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Article = p.Article,
                    Name = p.Name,
                    CategoryName = p.Category.Name,
                    Unit = p.Unit,
                    PurchasePrice = p.PurchasePrice,
                    CurrentStock = p.CurrentStock
                })
                .OrderBy(p => p.Name)
                .ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}