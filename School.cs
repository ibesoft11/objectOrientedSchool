using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class School : schoolStructure
    {
        int studCount = 0;
        public void addNew(string studentName)
        {
            studCount++;
            Console.WriteLine("New student added, Name : {0}", studentName);
        }
        public void addNew(string studentName, string level) {
            studCount++;
            Console.WriteLine("New student added, Name : {0},  Level : {1}", studentName, level);
        }
        public void getStudents()
        {
            Console.WriteLine(studCount);
        }
        public void deleteStudent(string studentName)
        {
            studCount--;
            Console.WriteLine("Name : {0}, has been deleted", studentName);
        }
    }
}
