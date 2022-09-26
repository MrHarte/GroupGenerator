using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    internal class Student:Person
    {
        private List<Student> students;
        private string _firstName;
        private string _lastName;
        private string _studentNumber;
        private bool _isChecked;
       public Student(string firstName,string lastName, string studentNumber):base("")
       {
            firstName = _firstName;
            lastName = _lastName;
            studentNumber = _studentNumber;
           
           
            
       }
        public string StudentNumber { get; set; }
           
        public override string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    

       
        public string FirstMode(string _firstName, string _lastName, string _studentNumber)
        {
            return (_lastName+", "   + _firstName + " ("+ _studentNumber+")" );
            
        }
        public string SecondMode(string _firstName, string _lastName, string _studentNumber)
        {
           
            return ( _firstName + " "+ _lastName[0]+".");

        }

    }
}
