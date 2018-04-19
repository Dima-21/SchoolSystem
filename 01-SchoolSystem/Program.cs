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
            Authorization a = new Authorization();
            IMenu manager = a.Login();
            manager.LoadFromFile();
            manager.MainMenu();
            manager.SaveToFile();
        }
    }
}