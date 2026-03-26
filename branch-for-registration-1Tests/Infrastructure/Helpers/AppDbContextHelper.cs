using Microsoft.EntityFrameworkCore;
using branch_for_registration_1.DataBase;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public class AppDbContextHelper
    {
        public AppDbContext Context { get; set; }

        public AppDbContextHelper()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseInMemoryDatabase($"UNIT_TEST_{Guid.NewGuid()}");
            
            var options = builder.Options;
            Context = new AppDbContext(options);
        }

        public AppDbContextHelper(string nameDb)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseInMemoryDatabase(nameDb);

            var options = builder.Options;
            Context = new AppDbContext(options);
        }

        public void AddUserAndRole_ForTest()
        {
            Context.AddRange(UserHelper.GetMany());
            //Context.AddRange(RoleHelper.GetMany());
            Context.AddRange(ProductHelper.GetMany());
            Context.SaveChanges();
        }

        public void AddProductAndCategory_ForTest()
        {
            var categoryHelper = CategoryHelper.GetOne();
            var productHelper1 = ProductHelper.GetOne_WithConnectCategory(categoryHelper);
            var productHelper2 = ProductHelper.GetOne_WithConnectCategory(categoryHelper);
            var productHelper3 = ProductHelper.GetOne_WithConnectCategory(categoryHelper);
            
            categoryHelper.Products.AddRange(new[] { productHelper1, productHelper2, productHelper3 });
            Context.SaveChanges();
        }

        public void AddProductAndCategory_ForTest(string name1, string name2, string name3)
        {
            var categoryHelper = CategoryHelper.GetOne();
            var productHelper1 = ProductHelper.GetOne_WithConnectCategory_AndName(categoryHelper, name1);
            var productHelper2 = ProductHelper.GetOne_WithConnectCategory_AndName(categoryHelper, name2);
            var productHelper3 = ProductHelper.GetOne_WithConnectCategory_AndName(categoryHelper, name3);
            Context.AddRange(new[] { productHelper1, productHelper2, productHelper3 });

            categoryHelper.Products.AddRange(new[] { productHelper1, productHelper2, productHelper3 });
            Context.SaveChanges();
        }
    }
}
