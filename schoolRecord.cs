using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //My interface, shows the structure of my program
    interface schoolRecord
    {
        void addNew(string studentName);
        void getStudents();
        void deleteStudent(string studentName);
        void viewSchool();
    }
}
