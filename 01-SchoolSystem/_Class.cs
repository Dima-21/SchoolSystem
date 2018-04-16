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
}
