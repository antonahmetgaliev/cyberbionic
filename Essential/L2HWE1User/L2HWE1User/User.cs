using System;

namespace L2HWE1User
{
    class User
    {
        private string Login { get; }
        private string Name { get; }
        private string Surname { get; }
        private string Age { get; }
        private string Data { get; }

        public User(string login, string name, string surname, string age, string data)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Data = data;
        }

        public void Show()
        {
            Console.WriteLine("\nLogin - {0}", Login);
            Console.WriteLine("\nName of user - {0}", Name);
            Console.WriteLine("Surname of user - {0}", Surname);
            Console.WriteLine("Age of user - {0}", Age);
        }
    }
}
