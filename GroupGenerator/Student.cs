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
            _isChecked = false;
            students=new List<Student>();
            
       }
        public string StudentNumber { get; set; }
           
        public override string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    

        public bool IsChecked { get; set; }
        public List<Student> Students { get { return students; } }

        public string FirstMode(string _firstName, string _lastName, string _studentNumber)
        {
            Name = _lastName + ", " + _firstName + " (" + _studentNumber + ")";
            return Name;
        }
        public bool CheckedMode()
        {
           _isChecked= true;
            return _isChecked;
        }

    }
}
