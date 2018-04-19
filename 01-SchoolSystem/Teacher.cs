using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    [Serializable]
    class Teacher
    {
        public string Login { get; set; }
        public string Password { get; set; }
        Dictionary<_Class, List<string>> subjects = new Dictionary<_Class, List<string>>();
        public Teacher(string log, string pass)
        {
            Login = log;
            Password = pass;
        }
        public int AddClass(_Class c, List<string> s)
        {
            foreach (var dict in subjects)
            {
                if (dict.Key == c)
                    return 0;
            }
            subjects.Add(c, s);
            return 1;
        }
        public int AddSubject(_Class c, string s)
        {
            foreach (var dict in subjects)
            {
                if (dict.Key == c)
                    return 0;
            }
            subjects[c].Add(s);
            return 1;
        }
    }
}
