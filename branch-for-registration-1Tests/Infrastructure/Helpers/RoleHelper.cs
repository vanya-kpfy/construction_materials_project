using branch_for_registration_1.Classes;

namespace branch_for_registration_1Tests.Infrastructure.Helpers
{
    public static class RoleHelper
    {
        public static Role GetOne(string id = "8240a613-8c6b-47d8-b034-f6004a8be633")
        {
            var useExisting = Guid.TryParse(id, out var roleId);
            return new Role
            {
                Id = useExisting? roleId : Guid.NewGuid(),
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
