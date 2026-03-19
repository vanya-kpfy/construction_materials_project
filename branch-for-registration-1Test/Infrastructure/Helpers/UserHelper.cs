using branch_for_registration_1.Classes;
using branch_for_registration_1.HeshSHA256;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public static class UserHelper
    {
        public static User GetOne(string id = "7551d313-5182-43c5-a180-f048eb494891", string password = "QWERTY123")
        {
            var role = RoleHelper.GetOne();
            var useExisting = Guid.TryParse(id, out var userId);
            return new User
            {
                Id = useExisting ? userId : Guid.NewGuid(),
                FirstName = "FNAME",
                LastName = "LNAME",
                MiddleName = "MNAME",
                Email = "EMAIL@mail.ru",
                PasswordHash = HashHelper.GetHash(password),
                Role = role,
                IsActive = true,
                RoleId = role.Id,
            };
        }

        public static IEnumerable<User> GetMany()
        {
            yield return GetOne();
        }
    }
}
