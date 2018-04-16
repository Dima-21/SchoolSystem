using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
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
        public void Add(_Class c)
        {
            classes.Add(c);
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
    }
}
