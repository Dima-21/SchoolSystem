using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSystem
{
    interface IAuthorization
    {
        int MainMenu();
    }

    class Teacher : IAuthorization
    {
        public int MainMenu()
        {
            throw new NotImplementedException();
        }
    }

    class Schoolmaster : IAuthorization
    {
        public int MainMenu()
        {
            throw new NotImplementedException();
        }
    }
}
