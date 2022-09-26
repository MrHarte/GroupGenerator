using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{/// <summary>
/// Represents one student saving their name.
/// </summary>
    internal class Student : Person
    {
        /// <summary>
        /// string first name to hold student first name.
        /// </summary>
        private string _firstName;
        /// <summary>
        /// string to hold student last name.
        /// </summary>
        private string _lastName;
        /// <summary>
        /// string to hold student number.
        /// </summary>
        private string _studentNumber;

        /// <summary>
        /// string to hold student name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Create paramaterised constructor for Student Class <see cref="Student"/> class.
        /// </summary>
        /// <param name="name">student Name</param>
        public Student(string name) : base(name)
        {
             _name = name;
        }
        /// <summary>
        /// Create another constructer for student.
        /// </summary>
        /// <param name="firstName">student first name.</param>
        /// <param name="lastName">student last name.</param>
        /// <param name="studentNumber">student student number.</param>
        public Student(string firstName,string lastName, string studentNumber) : base("")
       {
            firstName = _firstName;
            lastName = _lastName;
            studentNumber = _studentNumber;
       }
        /// <summary>
        /// student number property which return the student number.
        /// </summary>
        public string StudentNumber
        {
            get
            {
                _studentNumber = _name.Split('(', ')')[1];
                return _studentNumber;

            }
        }
        /// <summary>
        /// Name property to return student name, it is overridede from person class
        /// </summary>
        public override string Name { get; set; }
        /// <summary>
        /// First name property to return student first name
        /// </summary>
        public string FirstName
        {
            get
            {
                // Check if name is seperated with "," or "(" to split name and get the correct first name
                if(!_name.Contains(',')||!_name.Contains('('))
                {
                    _firstName = _name.Split(' ')[0];

                }
                else
                {
                    _firstName = _name.Split(',', ' ')[2];
                }
                    return _firstName;
            }
        }
            
        /// <summary>
        /// Last name property to get the student last name.
        /// </summary>
        public string LastName
        {
            get
            {
               // Check if name is seperated with "," or "(" to split name and get the correct last name
                if (!_name.Contains(',') || !_name.Contains('('))
                {
                    _lastName = _name.Split(' ')[1];
                }
                else
                {
                    _lastName = _name.Split(',', ' ')[0];
                }
                
                return _lastName;

            }
        }    
        /// <summary>
        /// Method to get the formatted name.
        /// </summary>
        /// <param name="_firstName">student first name</param>
        /// <param name="_lastName">student last name</param>
        /// <param name="_studentNumber">student number</param>
        /// <returns>return the formatted name</returns>
        public string FirstMode(string _firstName, string _lastName, string _studentNumber)
        {
            Name= (_lastName+", "   + _firstName + " ("+ _studentNumber+")" );
            return Name;
        }
        /// <summary>
        /// Method to get the second formate for student name
        /// </summary>
        /// <param name="_firstName"> student first name</param>
        /// <param name="_lastName">student last name</param>
        /// <returns> formatted name</returns>
        public string SecondMode(string _firstName, string _lastName)
        {
            Name=( _firstName + " "+ _lastName[0]+".");
            return Name;
        }
        /// <summary>
        ///  Method to get the Third formate for student name
        /// </summary>
        /// <param name="_firstName"> student first name</param>
        /// <param name="_lastName">student last name</param>
        /// <param name="_studentNumber">student number</param>
        /// <returns> formatted name</returns>
        public string ThirdMode(string _firstName, string _lastName,string _studentNumber)
        {
            Name=(_firstName + " " + _lastName);
            return Name;

        }
    }
}
