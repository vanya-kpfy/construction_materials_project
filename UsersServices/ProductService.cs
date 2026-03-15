using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace branch_for_registration_1.UsersServices
{
    public class ProductService : IDisposable
    {
        private AppDbContext db;

        public ProductService()
        {
            db = new AppDbContext();
        }

        // Получить все товары с категориями (для DataGridView)
        public List<Product> GetAllProducts()
        {
            // Загружаем вместе с категориями
            var query = from p in db.Products.Include(p => p.Category)
                        orderby p.Name
                        select p;
            return query.ToList();
        }

        // Получить товары по категории
        public List<Product> GetProductsByCategory(Guid categoryId)
        {
            var query = from p in db.Products.Include(p => p.Category)
                        where p.CategoryId == categoryId
                        orderby p.Name
                        select p;
            return query.ToList();
        }

        // Поиск товаров по артикулу или названию
        public List<Product> SearchProducts(string searchText)
        {
            var query = from p in db.Products.Include(p => p.Category)
                        where p.Article.ToLower().Contains(searchText.ToLower()) || p.Name.ToLower().Contains(searchText.ToLower())
                        orderby p.Name
                        select p;
            return query.ToList();
        }

        // Добавить товар (админ)
        public void AddProduct(Product product)
        {
            if (db.Products.Any(p => p.Article == product.Article))
                throw new Exception("Товар с таким артикулом уже существует");

            product.Id = Guid.NewGuid();
            db.Products.Add(product);
            db.SaveChanges();
        }

        // Обновить товар
        public void UpdateProduct(Product product)
        {
            var existing = db.Products.Find(product.Id);
            if (existing == null) throw new Exception("Товар не найден");

            // Проверка уникальности артикула (если изменился)
            if (existing.Article != product.Article &&
                db.Products.Any(p => p.Article == product.Article))
                throw new Exception("Товар с таким артикулом уже существует");

            db.Entry(existing).CurrentValues.SetValues(product);
            db.SaveChanges();
        }

        // Удалить товар (админ)
        public void DeleteProduct(Guid id)
        {
            var product = db.Products.Find(id);
            if (product == null) return;

            // Проверяем, есть ли отгрузки с этим товаром
            bool inShipments = db.ShipmentItems.Any(si => si.ProductId == id);
            if (inShipments)
                throw new Exception("Нельзя удалить товар, который участвует в отгрузках");

            db.Products.Remove(product);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
