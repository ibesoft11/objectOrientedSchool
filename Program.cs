using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dependency injection occurs here, I called the addNew without having to re-write it here
            */
            School school = new School();
            school.viewSchool();
            school.addNew("ibesoft");
            school.addNew("kenny gee", "500");
            school.addNew("val");
            school.getStudents();
            Console.ReadKey();
        }
    }
}
