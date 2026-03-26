using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с товарами
    /// </summary>
    public class ProductService : IDisposable
    {
        private AppDbContext db;

        public ProductService()
        {
            db = new AppDbContext();
        }

        /// <summary>
        /// Возвращает все товары с категориями, отсортированные по названию
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            return db.Products.Include(p => p.Category).OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Возвращает товары по категории
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<Product> GetProductsByCategory(Guid categoryId)
        {
            return db.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Поиск товаров по артикулу или названию
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public List<Product> SearchProducts(string searchText)
        {
            var lower = searchText.ToLower();
            return db.Products.Include(p => p.Category).Where(p => p.Article.ToLower().Contains(lower) ||p.Name.ToLower().Contains(lower)).OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Расширенный поиск товаров (артикул, название, категория)
        /// </summary>
        /// <param name="article"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<Product> SearchProductsAdvanced(string article, string name, Guid? categoryId)
        {
            var query = db.Products.Include(p => p.Category).AsQueryable();
            if (!string.IsNullOrEmpty(article))
            {
                var lower = article.ToLower();
                query = query.Where(p => p.Article.ToLower().Contains(lower));
            }
            if (!string.IsNullOrEmpty(name))
            {
                var lower = name.ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(lower));
            }
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }
            return query.OrderBy(p => p.Name).ToList();
        }

        /// <summary>
        /// Возвращает товар по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(Guid id)
        {
            return db.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Добавляет новый товар
        /// </summary>
        /// <param name="product"></param>
        /// <exception cref="Exception"></exception>
        public void AddProduct(Product product)
        {
            if (db.Products.Any(p => p.Article == product.Article))
                throw new Exception("A product with this article already exists.");
            product.Id = Guid.NewGuid();
            db.Products.Add(product);
            db.SaveChanges();
        }

        /// <summary>
        /// Обновляет товар
        /// </summary>
        /// <param name="product"></param>
        /// <exception cref="Exception"></exception>
        public void UpdateProduct(Product product)
        {
            var existing = db.Products.Find(product.Id);
            if (existing == null)
                throw new Exception("Product not found.");
            if (existing.Article != product.Article && db.Products.Any(p => p.Article == product.Article))
                throw new Exception("A product with this article already exists.");
            db.Entry(existing).CurrentValues.SetValues(product);
            db.SaveChanges();
        }

        /// <summary>
        /// Удаляет товар (если нет в отгрузках)
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void DeleteProduct(Guid id)
        {
            var product = db.Products.Find(id);
            if (product == null) return;
            bool inShipments = db.ShipmentItems.Any(si => si.ProductId == id);
            if (inShipments)
                throw new Exception("Cannot delete a product that is part of a shipment.");
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}