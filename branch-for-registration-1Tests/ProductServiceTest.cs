//using branch_for_registration_1.UsersServices;
//using branch_for_registration_1Tests.Infrastructure.Helpers;

//namespace branch_for_registration_1Tests
//{
//    [TestClass]
//    public sealed class ProductServiceTest
//    {
//        private AppDbContextHelper contextHelper { get; set; }
//        private ProductService productService { get; set; }

//        [TestInitialize]
//        public void Setup()
//        {
//            contextHelper = new AppDbContextHelper();
//            productService = new ProductService(contextHelper.Context);
//        }

//        [TestCleanup]
//        public void Cleanup()
//        {
//            contextHelper.Context.Database.EnsureDeleted();
//            contextHelper = null;
//            productService = null;
//        }

//        [TestMethod]
//        public void GetAllProducts_ReturnsOrderedbyName()
//        {
//            // Arrange
//            contextHelper.AddProductAndCategory_ForTest("Brick", "Сement", "Paperboard");
//            // Act
//            var listProduct = productService.GetProducts();

//            // Accert
//            Assert.AreEqual(3, listProduct.Count);
//            Assert.AreEqual("Brick", listProduct[0].Name);
//            Assert.AreEqual("Cement", listProduct[1].Name);
//            Assert.AreEqual("Paperboard", listProduct[2].Name);
//        }

//        [TestMethod]
//        public void GetAllProducts_ReturnsEmptyList()
//        {
//            // Arrange

//            // Act
//            var listProduct = productService.GetProducts();

//            // Accert
//            Assert.AreEqual(0,listProduct.Count);
//        }
//    }
//}
