using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    class Authorization
    {
        static List<Teacher> users = new List<Teacher>();
        static Admin admin = new Admin();
        public Authorization()
        {
            users.Add(new Teacher("teacher1", "123"));
            users.Add(new Teacher("teacher2", "123"));
            users.Add(new Teacher("teacher3", "123"));
        }
        public IMenu Login()
        {
            string login;
            string password;
            do
            {
                Console.WriteLine("--- Вход ---");
                Console.Write("Login: ");
                login = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (admin.Login == login && admin.Password == password)
                    return new MenuAdmin();
                foreach (var item in users)
                {
                    if (item.Login == login && item.Password == password)
                        return new MenuTeacher(item);
                }
                Console.WriteLine("Неверный Логин и/или Пароль...");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
    }
    class Admin
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Admin()
        {
            Login = "Admin";
            Password = "111";
        }
    }

}
