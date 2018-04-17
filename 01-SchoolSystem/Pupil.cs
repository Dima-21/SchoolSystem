using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    class Person
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Patronymic { get; set; }
        protected DateTime DateOfBirth { get; set; }
        protected string ID { get; set; }
        public Person(string n, string s, string p, DateTime d)
        {
            Name = n;
            Surname = s;
            Patronymic = p;
            DateOfBirth = d;
        }
        public Person(string n, string s, string p, DateTime d, string id) : this(n, s, p, d)
        {
            if ((DateTime.Now.Date - d.Date).Days/365 >= 14)
                ID = id;
        }

        public override string ToString()
        {
            return $"ФИО: {Surname} {Name} {Patronymic}; День рождения: {DateOfBirth.ToString("dd.mm.yyyy")}"; 
        }
    }

    class Pupil : Person
    {
        public static int IDps { get; set; }
        public int IDp { get; set; }
        string[] lessons;
        int[][] marks;
        const int nlessons = 3;

        //public void SetMark(int mark, int index)
        //{
        //    if (mark < 1 || mark > 12)
        //        return;
        //    if (index == 1)
        //    {
        //        Array.Resize(ref marks[0], nprog + 1);
        //        marks[0][nprog] = mark;
        //    }
        //    else if (index == 2)
        //    {
        //        Array.Resize(ref marks[1], nadmin + 1);
        //        marks[1][nadmin] = mark;
        //        nadmin++;
        //    }
        //    else if (index == 3)
        //    {
        //        Array.Resize(ref marks[2], ndes + 1);
        //        marks[2][ndes] = mark;
        //        ndes++;
        //    }
        //}
        public int[] GetMark(int index)
        {
            if (index == 1)
            {
                return marks[0];
            }
            else if (index == 2)
            {
                return marks[1];
            }
            return marks[2];
        }

        public double AverageMark(int index)
        {
            int sum = 0;

            if (index == 1)
            {
                foreach (var item in marks[0])
                    sum += item;
                return (double)sum / marks[0].Length;
            }

            else if (index == 2)
            {
                foreach (var item in marks[1])
                    sum += item;
                return (double)sum / marks[1].Length;
            }

            foreach (var item in marks[2])
                sum += item;

            return (double)sum / marks[2].Length;
        }

        public void ShowMarksProgramming()
        {
            Console.WriteLine($"Programming: {String.Join(", ", marks[0])}");
        }
        public void ShowMarksAdministration()
        {
            Console.WriteLine($"Administration: {String.Join(", ", marks[1])}");
        }
        public void ShowMarksDesign()
        {
            Console.WriteLine($"Design: {String.Join(", ", marks[2])}");
        }

        public string ToStringMarksProgramming()
        {
            return String.Join(", ", marks[0]);
        }
        public string ToStringMarksAdministration()
        {
            return String.Join(", ", marks[1]);
        }
        public string ToStringMarksDesign()
        {
            return String.Join(", ", marks[2]);
        }
    public Pupil(string n, string s, string p, DateTime d, string id) : base(n, s, p, d, id)
        {
            IDps++;
            IDp = IDps;
            lessons = new string[] { "Украинский язык", "Русский язык", "Английский язык", "Алгебра", "Геометрия", "Биология", "Физика", "Физкультура", "География", "Химия", "Украинская литература", "Зарубежная литература" };
            marks = new int[nlessons][];
            
        }
        public Pupil(string n, string s, string p, DateTime d) : base(n, s, p, d)
        {
            IDps++;
            IDp = IDps;
        }
        public override string ToString()
        {
            return $"{IDp}. {base.ToString()}"; 
        }
    }
}
