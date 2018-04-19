using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    interface IMenu
    {
        void MainMenu();
        void SaveToFile();
        void LoadFromFile();
    }

    class MenuAdmin : IMenu
    {
        private School school = new School("Kiev", 12);
        public void MainMenu()
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Список всех школьников");
                Console.WriteLine("2. Список школьников в классе");
                Console.WriteLine("3. Добавить школьника");
                Console.WriteLine("4. Удалить школьника");
                Console.WriteLine("5. Создать новый класс");
                Console.WriteLine("6. Удалить класс");
                Console.WriteLine("0. Выход");
                key = Console.ReadKey().Key;
                Console.Clear();
            } while (CallMethods(key) != 0);
        }
        private int CallMethods(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.NumPad0:
                    return 0;
                case ConsoleKey.NumPad1:
                    Console.WriteLine(school);
                    Console.ReadKey();
                    return 1;
                case ConsoleKey.NumPad2:
                    ShowClass();
                    Console.ReadKey();
                    return 1;
                case ConsoleKey.NumPad3:
                    AddPupil();
                    Console.ReadKey();
                    return 1;
                case ConsoleKey.NumPad4:
                    RemovePupil();
                    Console.ReadKey();
                    return 1;
                case ConsoleKey.NumPad5:
                    NewClass();
                    Console.ReadKey();
                    return 1;
                case ConsoleKey.NumPad6:
                    RemoveClass();
                    Console.ReadKey();
                    return 1;
                default:
                    SaveToFile();
                    return 1;
            }
        }

        private void ShowClass()
        {
            Console.Write("Класс который нужно вывести на экран: ");
            string c = Console.ReadLine();
            Console.Clear();
            if (school.ShowClass(c) == 0)
                Console.WriteLine("Данного класса не существует");
        }

        private void AddPupil()
        {
            Console.WriteLine("--- Добавление ученика ---");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Отчество: ");
            string patronymic = Console.ReadLine();
            Char.ToUpper(name.First());

            Console.Write("Год рождения (Формат: дд.мм.гггг): ");
            string date = Console.ReadLine().Replace('.', ',');
            DateTime dt = Convert.ToDateTime(date);
            Console.Write("Добавить в класс(Формат: N-L, Пример: 1-А):");
            string _class = Console.ReadLine();
            _class = _class.ToUpper();
            Console.Write("ID пасспорта: ");
            string id = Console.ReadLine();
            if(school.AddPupil(new Pupil(name, surname, patronymic, dt, id), _class) == 0)
                Console.WriteLine("Класса в который вы хотите добавить ученика не существует!");
            else
                Console.WriteLine("Ученик успешно добавлен!");
        }
        private void RemovePupil()
        {
            Console.WriteLine("--- Удаление ученика ---");
            Console.WriteLine(school);
            Console.Write("Введите номер ученика которого хотите удалить: ");
            int id = Console.Read();
            if(school.RemovePupil(id) == 0)
                Console.WriteLine("Школьник не найден!");
            else
                Console.WriteLine("Школьник успешно удален!");
        }

        private void NewClass()
        {
            Console.WriteLine("--- Создание нового класса ---");
            Console.Write("Класс(Формат: N-L, Пример: 1-А): ");
            string _class = Console.ReadLine();
            _class = _class.ToUpper();
            if (_class.Length == 3 && Char.IsDigit(_class.First()) && Char.IsLetter(_class.Last()) && _class[1] == '-')
            {
                if (school.NewClass(_class) == 0)
                    Console.WriteLine("Класс с таким же названием уже существует");
                else
                    Console.WriteLine("Класс успешно создан!");
            }
            else
                Console.WriteLine("Неверный формат класса!");
        }

        private void RemoveClass()
        {
            Console.WriteLine("--- Удаление класса ---");
            Console.Write("Класс который хотите удалить: ");
            string _class = Console.ReadLine().ToUpper();
            if (_class.Length == 3 && Char.IsDigit(_class.First()) && Char.IsLetter(_class.Last()) && _class[1] == '-')
            {
                if (school.RemoveClass(_class) == 0)
                    Console.WriteLine("Класса с данным именем не найдено!");
                else
                    Console.WriteLine("Класс успешно удален!");
            }
            else
                Console.WriteLine("Неверный формат класса!");
        }
        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            var file = File.Open("school.txt", FileMode.Create);
            bf.Serialize(file, school);
            file.Close();
        }

        public void LoadFromFile()
        {       
            BinaryFormatter bf = new BinaryFormatter();
            var file = File.Open("school.txt", FileMode.Open);
            school = bf.Deserialize(file) as School;
            file.Close();
        }

    }
    class MenuTeacher : IMenu
    {
        Teacher teacher;
        public MenuTeacher(Teacher t)
        {
            teacher = t;
        }


        public void MainMenu()
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine("--- Функционал находится в разработке... ---");
                Console.WriteLine("0. Выход");
                key = Console.ReadKey().Key;
                Console.Clear();
            } while (CallMethods(key) != 0);
        }

        public void SaveToFile()
        {
            return;
        }

        public void LoadFromFile()
        {
            return;
        }
        private int CallMethods(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.NumPad0:
                    Console.ReadKey();
                    return 0;
            }
            return 1;
        }
    }
    }
