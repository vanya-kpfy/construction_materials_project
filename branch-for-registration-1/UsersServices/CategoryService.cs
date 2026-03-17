using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace branch_for_registration_1.UsersServices
{
    public class CategoryService : IDisposable
    {
        private AppDbContext db;

        public CategoryService()
        {
            db = new AppDbContext();
        }

        // Получить все категории (для отображения в TreeView)
        public List<Category> GetAllCategories()
        {
            var query = from c in db.Categories
                        orderby c.Name
                        select c;
            return query.ToList();
        }

        // Добавить категорию (только для админа)
        public void AddCategory(string name)
        {
            if (db.Categories.Any(c => c.Name == name))
                throw new Exception("Категория с таким названием уже существует");

            Category cat = new Category
            {
                Id = Guid.NewGuid(),
                Name = name
            };
            db.Categories.Add(cat);
            db.SaveChanges();
        }

        // Удалить категорию (только если нет товаров)
        public void DeleteCategory(Guid id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null) return;

            bool hasProducts = db.Products.Any(p => p.CategoryId == id);
            if (hasProducts)
                throw new Exception("Нельзя удалить категорию, в которой есть товары");

            db.Categories.Remove(cat);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}