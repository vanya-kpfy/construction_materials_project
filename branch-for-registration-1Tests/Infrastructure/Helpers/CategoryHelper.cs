using branch_for_registration_1.Classes;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public static class CategoryHelper
    {
        public static Category GetOne()
        {
            return new Category
            {
                Id = Guid.NewGuid(),
                Name = "CATEGORY",
            };
        }

        public static IEnumerable<Category> GetMany()
        {
            yield return GetOne();
        }
    }
}
