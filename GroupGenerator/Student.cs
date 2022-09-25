using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    internal class Student : Person
    {
        private int _studentNumber;
        private string _nameWNumber;

        /// <summary>
        /// to create a student
        /// </summary>
        /// <param name="name"></param>
        /// <param name="StudentNumber"></param>
        public Student(string name, int StudentNumber = 0) : base(name)
        {
            _studentNumber = StudentNumber;
            _nameWNumber = Name + " " + StudentNumber.ToString();

        }

        /// <summary>
        /// To access the student number
        /// </summary>
        public int StudentNumber
        {
            get { return _studentNumber; }
        }

        /// <summary>
        /// To return the name with the student number after
        /// </summary>
        public string NameWNumber
        {
            get { return _nameWNumber; }
        }
    }
}
