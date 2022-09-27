using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    internal class Student : Person
    {
        /// <summary>
        /// Constructor for a person optionally adding their name.
        /// </summary>
        private static int displayMode = 0;
        public const int DisplayModeLastNameF = 1;
        public const int DisplayModeLastNameFirstName = 2;
        public const int DisplayModeFirstNameLastNameId = 3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Constructor for a student optionally adding their full name.
        /// </summary>
        /// <param name="fullName">Student's full name empty by default.</param>
        public Student(string fullName)
        {
            string str = fullName;
            char[] delim = { ',', '(', ')' };
            string[] tokens = str.Split(delim);
            this.FirstName = tokens[0];
            this.LastName = tokens[1];
            this.Id = tokens[2];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Constructor for a student optionally adding their first, last name and ID.
        /// </summary>
        /// <param name="firstName">Student's first name empty by default.</param>
        /// <param name="lastName">Student's last name empty by default.</param>
        /// <param name="iD">Student's ID empty by default.</param>
        public Student(string firstName, string lastName, string iD)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = iD;
        }

        /// <summary>
        /// Method that will change the order from the data depending from the DisplayMode.
        /// </summary>
        /// <returns>The first, last name and ID in different order depending from the DisplayMode</returns>
        public override string ToString()
        {
            if (DisplayMode == Student.DisplayModeLastNameF)
            {
                return LastName + ", " + FirstName[0] + ".";
            }
            if (DisplayMode == Student.DisplayModeLastNameFirstName)
            {
                return LastName + " " + FirstName;
            }
            if (DisplayMode == Student.DisplayModeFirstNameLastNameId)
            {
                return FirstName + ", " + LastName + " " + Id;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Save the full name from the student.
        /// </summary>
        public override string Name { get { return FirstName + ", " + LastName + " " + Id; } }

        /// <summary>
        /// Save the first name from the student.
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Save the last name from the student.
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Save the ID from the student.
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Made posible the change the value from DisplayMode.
        /// </summary>
        public static int DisplayMode { get { return Student.displayMode; } set { Student.displayMode = value; } }
    }
}
