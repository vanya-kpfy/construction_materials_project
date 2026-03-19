using branch_for_registration_1.UsersServices;
using branch_for_registration_1Tests.Infrastructure.Helpers;

namespace branch_for_registration_1Tests
{
    [TestClass]
    public sealed class WorkingWithUsersTest
    {
        private AppDbContextHelper contextHelper { get; set; }
        private WorkingWithUsers workingWithUsers { get; set; }

        public WorkingWithUsersTest()
        {
            contextHelper = new AppDbContextHelper();
            workingWithUsers = new WorkingWithUsers(contextHelper.Context);
        }

        [TestMethod]
        public void EmailExists_CorrectEmail()
        {
            var email = "EMAIL@mail.ru";

            var result = workingWithUsers.EmailExists(email);

            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void EmailExists_UncorrectEmail()
        {
            var email = "EMAIL@";

            var result = workingWithUsers.EmailExists(email);

            Assert.IsFalse(result);
        }

    }
}
