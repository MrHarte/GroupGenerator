using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    public class Student: Person
    {

        string _studentNumber;

        public Student(string firstName, string lastName, string studentNumber)
        {

        }

        string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }
    }
}
