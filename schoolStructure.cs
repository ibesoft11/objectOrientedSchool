using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Abstract class
    public abstract class schoolStructure : schoolRecord
    {
        public void addNew(string studentName) { }
        public void addNew(string studentName, string level) { }
        public void getStudents(){}
        public void deleteStudent(string studentName) { }

        //implement viewSchool of interface
        public void viewSchool()
        {
            Console.WriteLine("Ibesoft Comprehensive School");
        }
    }
}
