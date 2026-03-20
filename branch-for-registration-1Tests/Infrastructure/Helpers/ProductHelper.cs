using branch_for_registration_1.Classes;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public static class ProductHelper
    {
        public static Product GetOne()
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Article = $"ARTICLE_{Guid.NewGuid()}",
                Name = "NAME",
                // CategoryId
                Unit = "PCS",
                PurchasePrice = 10,
                CurrentStock = 0
                // Category
            };
        }

        public static Product GetOne_WithConnectCategory(Category category)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Article = $"ARTICLE_{Guid.NewGuid()}",
                Name = "NAME",
                CategoryId = category.Id,
                Unit = "PCS",
                PurchasePrice = 10,
                CurrentStock = 0,
                Category = category
            };
        }

        public static Product GetOne_WithConnectCategory_AndName(Category category, string name)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Article = $"ARTICLE_{Guid.NewGuid()}",
                Name = name,
                CategoryId = category.Id,
                Unit = "PCS",
                PurchasePrice = 10,
                CurrentStock = 0,
                Category = category
            };
        }

        public static IEnumerable<Product> GetMany()
        {
            yield return GetOne();
        }
    }
}
