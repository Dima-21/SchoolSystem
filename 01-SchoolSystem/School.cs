using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    [Serializable]
    class School
    {
        public string NameSchool { get; set; }
        public int SchoolNumber { get; set; }
        List<_Class> classes= new List<_Class>();
        public School(string name, int number)
        {
            NameSchool = name;
            SchoolNumber = number;
        }

        public int ShowClass(string c)
        {
            foreach (var item in classes)
                if (c == item.NameClass)
                {
                    Console.WriteLine(item);
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
            StringBuilder sb = new StringBuilder($"{NameSchool} №{SchoolNumber} {Environment.NewLine}" , 512);
            foreach (var item in classes)
            {
                sb.Append(item.ToString());
                sb.Append(Environment.NewLine);
            }
            return Convert.ToString(sb);
        }

        public int AddPupil(Pupil p, string c)
        {
            foreach (var item in classes)
                if (c == item.NameClass)
                {
                    item.AddPupil(p);
                    return 1;
                }
            return 0;
        }
        public int RemovePupil(int id)
        {
            foreach (var item in classes)
            {
                if (item.RemovePupil(id) == 1)
                    return 1;
            }
            return 0;
        }

        public int NewClass(string c)
        {
            foreach (var item in classes)
            {
                if (item.NameClass == c)
                    return 0;
            }
            classes.Add(new _Class(c));
            return 1;
        }


        public int RemoveClass(string c)
        {
            foreach (var item in classes)
            {
                if (item.NameClass == c)
                {
                    classes.Remove(item);
                    return 1;
                }
            }
            return 0;
        }
    }
}
