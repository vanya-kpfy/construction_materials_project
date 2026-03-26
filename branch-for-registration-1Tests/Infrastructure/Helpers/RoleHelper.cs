using branch_for_registration_1.Classes;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public static class RoleHelper
    {
        public static Role GetOne()
        {
            return new Role
            {
                Id = Guid.NewGuid(),
                Title = "ROLE",
                //Users = new List<User> { UserHelper.GetOne() }
            };
        }

        public static IEnumerable<Role> GetMany()
        {
            yield return GetOne();
        }
    }
}
