using System.Collections.Generic;
using System;

namespace branch_for_registration_1.Classes
{
    /// <summary>
    /// Класс Role представляет роль пользователя в системе (Admin или Worker)
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Уникальный идентификатор роли (GUID)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название роли, например "Admin" или "Worker"
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Список пользователей, у которых эта роль.
        /// </summary>
        public List<User> Users { get; set; }
    }
}