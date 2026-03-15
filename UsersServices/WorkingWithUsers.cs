using System;
using branch_for_registration_1.Classes;
using branch_for_registration_1.DataBase;
using System.Linq;

namespace branch_for_registration_1.UsersServices
{
    public class WorkingWithUsers : IDisposable
    {
        private AppDbContext db;

        public WorkingWithUsers()
        {
            db = new AppDbContext();
            db.EnsureDatabaseCreated();
        }

        public bool EmailExists(string email)
        {
            var query = from u in db.Users
                        where u.Email.ToLower() == email.ToLower()
                        select u;
            return query.Any();
        }

        public void AddUser(string firstName, string lastName, string middleName, string email, string passwordHash)
        {
            var roleQuery = from r in db.Roles
                            where r.Title == "Worker"
                            select r;
            Role workerRole = roleQuery.FirstOrDefault();

            if (workerRole == null)
            {
                Guid adminId = Guid.NewGuid();
                Guid workerId = Guid.NewGuid();
                db.Roles.AddRange(
                    new Role { Id = adminId, Title = "Admin" },
                    new Role { Id = workerId, Title = "Worker" }
                );
                db.SaveChanges();
                workerRole = (from r in db.Roles where r.Title == "Worker" select r).First();
            }

            User newUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                MiddleName = string.IsNullOrEmpty(middleName) ? null : middleName,
                Email = email,
                PasswordHash = passwordHash,
                RoleId = workerRole.Id,
                IsActive = true  // всегда true при регистрации
            };

            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public string ValidateUser(string email, string passwordHash)
        {
            var query = from u in db.Users
                        join r in db.Roles on u.RoleId equals r.Id
                        where u.Email.ToLower() == email.ToLower()
                           && u.PasswordHash == passwordHash
                           && u.IsActive
                        select r.Title;

            return query.FirstOrDefault();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}