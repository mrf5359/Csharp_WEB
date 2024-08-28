namespace Lab6TRKVD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Ім'я користувача
        public string? LastName { get; set; } // Фамилия пользователя
        public string? Group { get; set; } // Группа пользователя
        public int Age { get; set; } // вік користувача
    }
}
