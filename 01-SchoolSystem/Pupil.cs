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
        public Pupil(string n, string s, string p, DateTime d, string id) : base(n, s, p, d, id)
        {
            IDps++;
            IDp = IDps;
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
