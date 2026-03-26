using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с категориями товаров
    /// </summary>
    public class CategoryService : IDisposable
    {
        private AppDbContext db;
        public CategoryService()
        {
            db = new AppDbContext();
        }

        /// <summary>
        /// Возвращает все категории, отсортированные по названию
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategories()
        {
            return db.Categories.OrderBy(c => c.Name).ToList();
        }

        /// <summary>
        /// Возвращает категорию по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetCategoryById(Guid id)
        {
            return db.Categories.Find(id);
        }

        /// <summary>
        /// Добавить категорию (только для админа)
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="Exception"></exception>
        public void AddCategory(string name)
        {
            if (db.Categories.Any(c => c.Name == name))
                throw new Exception("A category with this name already exists.");
            db.Categories.Add(new Category { Id = Guid.NewGuid(), Name = name });
            db.SaveChanges();
        }

        /// <summary>
        /// Обновляет название категории
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <exception cref="Exception"></exception>
        public void UpdateCategory(Guid id, string newName)
        {
            var cat = db.Categories.Find(id);
            if (cat == null) 
                throw new Exception("Category not found.");
            if (db.Categories.Any(c => c.Name == newName && c.Id != id))
                throw new Exception("A category with this name already exists.");
            cat.Name = newName;
            db.SaveChanges();
        }

        /// <summary>
        /// Удалить категорию (только если нет товаров)
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void DeleteCategory(Guid id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null) return;
            bool hasProducts = db.Products.Any(p => p.CategoryId == id);
            if (hasProducts)
                throw new Exception("Cannot delete a category that contains products.");
            db.Categories.Remove(cat);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}