using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    /// <summary>
    /// Student class, derived from the Person class
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Holds the first name field
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Holds the last name field
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Holds the student ID field
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// Holds the int that decides the display mode
        /// </summary>
        public int DisplayMode { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Student(string name)
        {
            FirstName = " ";
            LastName = " ";
            DisplayMode = 0;

        }
    }
}
