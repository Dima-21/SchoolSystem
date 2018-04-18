using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    class MenuAdmin
    {
        static private School school = new School("Kiev", 12);
        static public void MainMenu()
        {
            Console.WriteLine("1. Список всех школьников");
            Console.WriteLine("2. Список школьников в классе");
            Console.WriteLine("3. Добавить школьника");
            Console.WriteLine("4. Удалить школьника");
            Console.WriteLine("5. Создать новый класс");
            Console.WriteLine("6. Удалить 11 класс и создать новый (1 класс)");
            Console.WriteLine("0. Выход");

            ConsoleKey key;
            do
            {
               key = Console.ReadKey().Key;
            } while (CallMethods(key) != 0);
        }
        static private int CallMethods(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.NumPad0:
                    return 0;
                case ConsoleKey.NumPad1:
                    Console.WriteLine(school);
                    return 1;
                case ConsoleKey.NumPad2:
                    
                    return 1;
                case ConsoleKey.NumPad3:

                    return 1;
                case ConsoleKey.NumPad4:

                    return 1;
                case ConsoleKey.NumPad5:

                    return 1;
                case ConsoleKey.NumPad6:

                    return 1;
            }
            return 1;
        }
    }
}
