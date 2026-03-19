using branch_for_registration_1.UsersServices;
using branch_for_registration_1Tests.Infrastructure.Helpers;

namespace branch_for_registration_1Tests
{
    [TestClass]
    public sealed class WorkingWithUsersTest
    {
        [TestMethod]
        public void EmailExists_CorrectEmail()
        {
            var workingWithUsers = new WorkingWithUsers(new AppDbContextHelper().Context);
            var email = "EMAIL@mail.ru";

            var result = workingWithUsers.EmailExists(email);

            Assert.IsTrue(result);
        }
    }
}
