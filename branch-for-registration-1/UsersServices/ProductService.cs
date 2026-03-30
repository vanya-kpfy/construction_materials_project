using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using branch_for_registration_1.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace branch_for_registration_1.UsersServices
{
    public class ProductService
    {
        /// <summary>
        /// Получить список товаров для отображения
        /// </summary>
        public async Task<List<ProductDto>> GetProducts()
        {
            using (var db = new AppDbContext())
            {
                return await db.Products
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
                    .ToListAsync();
            }
        }

        /// <summary>
        /// Получить товары по категории
        /// </summary>
        public async Task<List<ProductDto>> GetProductsByCategory(Guid categoryId)
        {
            using (var db = new AppDbContext())
            {
                return await db.Products
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
                    .ToListAsync();
            }
        }

        /// <summary>
        /// Поиск товаров
        /// </summary>
        public async Task<List<ProductDto>> SearchProducts(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return await GetProducts();
            }

            using (var db = new AppDbContext())
            {
                return await db.Products
                    .AsNoTracking()
                    .Where(p => p.Article.Contains(searchText) || p.Name.Contains(searchText))
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
                    .ToListAsync();
            }
        }

        /// <summary>
        /// Получить товар по Id
        /// </summary>
        public async Task<Product> GetProductById(Guid id)
        {
            using (var db = new AppDbContext())
            {
                return await db.Products.FirstOrDefaultAsync(p => p.Id == id);
            }
        }

        /// <summary>
        /// Метод создает товар
        /// </summary>
        /// <param name="product"></param>
        public async Task CreateProduct(Product product)
        {
            using (var db = new AppDbContext())
            {
                product.Id = Guid.NewGuid();
                product.Article = await GenerateArticle();

                await db.Products.AddAsync(product);
                await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Метод обновляет данные товара
        /// </summary>
        /// <param name="updated"></param>
        /// <exception cref="Exception"></exception>
        public async Task UpdateProduct(Product updated)
        {
            using (var db = new AppDbContext())
            {
                var existing = await db.Products.FirstOrDefaultAsync(p => p.Id == updated.Id);

                if (existing is null)
                {
                    throw new Exception("ProductNotFound");
                }

                if (existing.Article != updated.Article &&
                    db.Products.Any(p => p.Article == updated.Article))
                {
                    throw new Exception("ProductWithSimilarArticle");
                }

                existing.Name = updated.Name;
                existing.Article = updated.Article;
                existing.CategoryId = updated.CategoryId;
                existing.Unit = updated.Unit;
                existing.PurchasePrice = updated.PurchasePrice;
                existing.CurrentStock = updated.CurrentStock;

                await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Метод удаляет товар
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public async Task DeleteProduct(Guid id)
        {
            using (var db = new AppDbContext())
            {
                var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);

                if (product is null)
                {
                    return;
                }

                bool usedInShipment = await db.ShipmentItems.AnyAsync(si => si.ProductId == id);

                if (usedInShipment)
                {
                    throw new Exception("ProductCannotDeletedInShippment");
                }

                db.Products.Remove(product);
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<ProductDto>> SearchProductsAdvanced(string article, string name, Guid? categoryId)
        {
            using (var db = new AppDbContext())
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

                return await query
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
                    .ToListAsync();
            }
        }

        private async Task<string> GenerateArticle()
        {
            using (var db = new AppDbContext())
            {
                int count = await db.Products.CountAsync() + 1;
                return $"ART-{count}";
            }
        }
    }
}