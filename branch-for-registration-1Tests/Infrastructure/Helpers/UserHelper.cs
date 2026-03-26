using branch_for_registration_1.Classes;
using branch_for_registration_1.HeshSHA256;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public static class UserHelper
    {
        public static User GetOne(string password = "QWERTY123")
        {
            return new User
            {
                Id = Guid.NewGuid(),
                FirstName = "FNAME",
                LastName = "LNAME",
                MiddleName = "MNAME",
                Email = "EMAIL@mail.ru",
                PasswordHash = HashHelper.GetHash(password),
                //Role = role,
                IsActive = true,
                //RoleId = role.Id,
            };
        }

        public static IEnumerable<User> GetMany()
        {
            yield return GetOne();
        }
    }
}
