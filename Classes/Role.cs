using System.Collections.Generic;
using System;

namespace branch_for_registration_1.Classes
{
    // Таблица Roles (роли)
    public class Role
    {
        // Идентификатор роли (Guid). Для EF нужен public set, чтобы присваивать при загрузке из БД
        public Guid Id { get; set; }

        public string Title { get; set; }

        // Связь с пользователями (один ко многим)
        public List<User> Users { get; set; }
    }
}