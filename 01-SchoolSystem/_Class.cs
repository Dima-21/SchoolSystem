﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    [Serializable]
    class _Class
    {
        List<Pupil> pupils = new List<Pupil>();
        public string NameClass { get; set; }
        public int Count { get
            {
                return pupils.Count;
            }
        }
        public _Class(string n)
        {
            NameClass = n;
        }
        public void AddPupil(Pupil p)
        {
            pupils.Add(p);
        }
        public int RemovePupil(int id)
        {
            foreach (var item in pupils)
                if (item.IDp == id)
                {
                    pupils.RemoveAt(id - 1);
                    return 1;
                }
            return 0;
        }
        public override string ToString()
        {
            return FormatToString(); 
        }

        private string FormatToString()
        {
            StringBuilder sb = new StringBuilder($"{NameClass} {Environment.NewLine}",512);
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
