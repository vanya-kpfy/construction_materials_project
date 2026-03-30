//using branch_for_registration_1.Classes;
//using branch_for_registration_1.UsersServices;
//using branch_for_registration_1Tests.Infrastructure.Helpers;
//using Microsoft.EntityFrameworkCore;

//namespace branch_for_registration_1Tests
//{
//    [TestClass]
//    public sealed class WorkingWithUsersTest
//    {
//        private AppDbContextHelper contextHelper { get; set; }
//        private WorkingWithUsers workingWithUsers { get; set; }

//        [TestInitialize]
//        public void Setup()
//        {
//            contextHelper = new AppDbContextHelper();
//            contextHelper.AddUserAndRole_ForTest();
//            workingWithUsers = new WorkingWithUsers(contextHelper.Context);
//        }

//        [TestCleanup]
//        public void Cleanup()
//        {
//            contextHelper.Context.Database.EnsureDeleted();
//            contextHelper = null;
//            workingWithUsers = null;
//        }

//        [TestMethod]
//        public void EmailExists_CorrectEmail()
//        {
//            var email = "EMAIL@mail.ru";

//            var result = workingWithUsers.EmailExists(email);

//            Assert.IsTrue(result);
            
//        }

//        [TestMethod]
//        public void EmailExists_UncorrectEmail()
//        {
//            var email = "EMAIL@";

//            var result = workingWithUsers.EmailExists(email);

//            Assert.IsFalse(result);
//        }

//        [TestMethod]
//        public void GetOrCreateWorkerRole_WithRole()
//        {
//            // Arrange
//            var role = new Role { Id = Guid.NewGuid(), Title = "Worker" };
//            contextHelper.Context.Roles.Add(role);
//            contextHelper.Context.SaveChanges();

//            // Act
//            var result = workingWithUsers.GetOrCreateWorkerRole();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual(result.Id,role.Id);
//            Assert.AreEqual("Worker", result.Title);
//        }

//        [TestMethod]
//        public void GetOrCreateWorkerRole_WithoutRole()
//        {
//            // Arrange

//            // Act
//            var result = workingWithUsers.GetOrCreateWorkerRole();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual("Worker", result.Title);
//        }

//        [TestMethod]
//        public void AddUser_WhenDataValid()
//        {
//            // Arrange
//            var fName = "Игорь";
//            var lName = "Новиков";
//            var mName = "Игоревич";
//            var email = "igor@mail.ru";
//            var passwordHash = "qwerty123";

//            // Act
//            workingWithUsers.AddUser(fName, lName, mName, email, passwordHash);

//            // Assert
//            var user = contextHelper.Context.Users.Where(u => u.FirstName == fName && u.LastName == lName && u.MiddleName == mName && u.Email == email && u.PasswordHash == passwordHash).FirstOrDefault();
//            Assert.IsNotNull(user);
//            //Assert.AreEqual(fName, user.FirstName);
//            //Assert.AreEqual(lName, user.LastName);
//            //Assert.AreEqual(mName, user.MiddleName);
//            //Assert.AreEqual(email, user.Email);
//            //Assert.AreEqual(passwordHash, user.PasswordHash);
//        }

//        [TestMethod]
//        public void AddUser_WhenMNameIsEmpty()
//        {
//            // Arrange
//            var fName = "Игорь";
//            var lName = "Новиков";
//            var email = "igor@mail.ru";
//            var passwordHash = "qwerty123";

//            // Act
//            workingWithUsers.AddUser(fName, lName, string.Empty, email, passwordHash);

//            // Assert
//            var user = contextHelper.Context.Users.Where(u => u.FirstName == fName && u.LastName == lName && u.MiddleName == null && u.Email == email && u.PasswordHash == passwordHash).FirstOrDefault();
//            Assert.IsNotNull(user);
//            Assert.AreEqual(fName, user.FirstName);
//            Assert.AreEqual(lName, user.LastName);
//            Assert.AreEqual(null, user.MiddleName);
//            Assert.AreEqual(email, user.Email);
//            Assert.AreEqual(passwordHash, user.PasswordHash);
//        }

//        [TestMethod]
//        public void ValidateUser_WhenValid()
//        {
//            // Arrange
//            var fName = "Игорь";
//            var lName = "Новиков";
//            var email = "igor@mail.ru";
//            var passwordHash = "qwerty123";

//            // Act
//            workingWithUsers.AddUser(fName, lName, string.Empty, email, passwordHash);
//            var userRole = workingWithUsers.ValidateUser(email, passwordHash);

//            // Assert
//            Assert.AreEqual("Worker", userRole);
//        }

//        [TestMethod]
//        public void ValidateUser_WhenInactive()
//        {
//            // Arrange
//            var user = new User()
//            {
//                FirstName = "Иван",
//                LastName = "Иванов",
//                Email = "ivan@mail.ru",
//                PasswordHash = "qwerty123"
//            };

//            // Act
//            contextHelper.Context.Users.Add(user);
//            user.IsActive = false;
//            var userRole = workingWithUsers.ValidateUser(user.Email, user.PasswordHash);

//            // Assert
//            Assert.AreNotEqual("Worker", userRole);
//        }
//    }
//}
