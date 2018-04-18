using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //_Class c = new _Class("1-В");
            //c.Add(new Pupil("s", "z", "y", new DateTime(2001, 2, 10)));
            //c.Add(new Pupil("s", "z", "y", new DateTime(2001, 2, 12)));
            //_Class c1 = new _Class("1-A");
            //c1.Add(new Pupil("s", "z", "y", new DateTime(2002, 2, 10)));
            //c1.Add(new Pupil("s", "z", "y", new DateTime(2002, 2, 12)));
            //School s = new School("Киев", 1);
            //s.Add(c);
            //s.Add(c1);
            //Console.WriteLine(s);
            List<int> lst = new List<int>() { 1,4,6,34,4,6,7,5,3,243,56,68,7,65,2};
            BinaryFormatter bf = new BinaryFormatter();
            var file = File.Open("1.txt", FileMode.Create);
            bf.Serialize(file, lst);
            file.Close();

            var file2 = File.Open("1.txt", FileMode.Open);
            var lst2 = bf.Deserialize(file2) as List<int>;
            file2.Close();
            foreach (var item in lst2)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}