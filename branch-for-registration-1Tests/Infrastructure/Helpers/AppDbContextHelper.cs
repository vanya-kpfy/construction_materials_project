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
            builder.UseInMemoryDatabase("UNIT_TESTING");
            
            var options = builder.Options;
            Context = new AppDbContext(options);

            Context.AddRange(UserHelper.GetMany());
           // Context.AddRange(RoleHelper.GetMany());
            Context.SaveChanges();
        }
        
    }
}
