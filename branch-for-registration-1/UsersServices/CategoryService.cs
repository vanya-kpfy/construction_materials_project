using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branch_for_registration_1.UsersServices
{
    /// <summary>
    /// Сервис для работы с категориями товаров
    /// </summary>
    public class CategoryService
    {
        /// <summary>
        /// Возвращает все категории, отсортированные по названию
        /// </summary>
        /// <returns></returns>
        public async Task<List<Category>> GetAllCategories()
        {
            using (var db = new AppDbContext())
            {
                return await db.Categories.OrderBy(c => c.Name).ToListAsync();
            }
        }

        /// <summary>
        /// Добавить категорию (только для админа)
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="Exception"></exception>
        public async Task AddCategory(string name)
        {
            using (var db = new AppDbContext())
            {
                if (await db.Categories.AnyAsync(c => c.Name == name))
                {
                    throw new Exception("CategoryExisted");
                }

                await db.Categories.AddAsync(new Category { Name = name });
                await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Обновляет название категории
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <exception cref="Exception"></exception>
        public async Task UpdateCategory(Guid id, string newName)
        {
            using (var db = new AppDbContext())
            {
                var cat = await db.Categories.FindAsync(id);
                if (cat is null)
                {
                    throw new Exception("CategoryNull");
                }

                if (await db.Categories.AnyAsync(c => c.Name == newName && c.Id != id))
                {
                    throw new Exception("CategoryExisted");
                }

                cat.Name = newName;
                await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Удалить категорию (только если нет товаров)
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public async Task DeleteCategory(Guid id)
        {
            using (var db = new AppDbContext())
            {
                var category = await db.Categories.FindAsync(id);

                if (category is null)
                {
                    throw new Exception("CategoryNull");
                }

                bool hasProducts = await db.Products.AnyAsync(p => p.CategoryId == id);

                if (hasProducts)
                {
                    throw new Exception("CategoryWithProductsForDelete");
                }

                db.Categories.Remove(category);
                await db.SaveChangesAsync();
            }
        }
    }
}