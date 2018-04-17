using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    class _Class
    {
        List<Pupil> pupils = new List<Pupil>();
        public string NameClass { get; set; }
        public int Count { get; set; }
        public _Class(string n)
        {
            NameClass = n;
            Count = 0;
        }
        public void Add(Pupil p)
        {
            pupils.Add(p);
            Count++;
        }
        public void Remove(int id)
        {
            pupils.RemoveAt(id-1);
            Count--;
        }
        public override string ToString()
        {
            return FormatToString(); 
        }

        private string FormatToString()
        {
            StringBuilder sb = new StringBuilder(NameClass + Environment.NewLine,512);
            foreach (var item in pupils)
            {
                sb.Append(item.ToString());
                sb.Append(Environment.NewLine);
            }
            return Convert.ToString(sb);
        }
    }

    abstract class Lessons
    {
        static public string[] less = { "Украинский язык", "Русский язык", "Английский язык", "Алгебра", "Геометрия", "Биология", "Физика", "Физкультура", "География", "Химия", "Украинская литература", "Зарубежная литература" };
        static public void AddLesson(string l)
        {
            if(l.Length > 2 && l.Length < 30)
            {
                Array.Resize(ref less, less.Length + 1);
                Char.ToUpper(l.First());
                less[less.Length] = l;
            }
        }

    }
}
