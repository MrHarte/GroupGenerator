using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GroupGenerator
{
    /// <summary>
    /// Represents one student.
    /// </summary>
    /// <remarks>
    /// Saves the first name, last name, student number, and
    /// the display mode to be used by its ToString method.
    /// </remarks>
    public class Student: Person
    {
        string _firstName;
        string _lastName;
        string _studentNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class with the given string.
        /// </summary>
        /// <remarks>
        /// Takes the student information formated as "Lastname, Firstname (Studentnumber)" and splits
        /// it into the appropriate properties.
        /// </remarks>
        /// <param name="studentString">The student's full name and student number in one string.</param>
        public Student(string studentString)
        {
            string[] studentData = new string[3];

            // Put the entered data into an array
            char[] delimiters = { ',', '(', ')' };
            studentData = studentString.Split(delimiters, StringSplitOptions.TrimEntries);

            // Assign the data from the array to the appropriate properties
            _firstName = studentData[1];
            _lastName = studentData[0];
            _studentNumber = studentData[2];
        }

        /// <summary>
        /// Gets or sets the first name of a student.
        /// </summary>
        /// <remarks>
        /// May also include the middles name(s).
        /// </remarks>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name of a student.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Gets or sets the student number of a student.
        /// </summary>
        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }

        /// <summary>
        /// Gets or sets the display mode of the <see cref="Student"/> class.
        /// </summary>
        /// <remarks>
        /// Determines how the <see cref="ToString"/> method displays the student's data.
        /// Should be either 1, 2, or 3.
        /// </remarks>
        public static int DisplayMode { get; set; }

        /// <summary>
        /// Returns the student data formatted according to the current <see cref="DisplayMode"/>.
        /// </summary>
        /// <remarks>
        /// Format 1: "Firstname, L."<br></br>
        /// Format 2: "Firstname Lastname"<br></br>
        /// Format 3: "Firstname Lastname (Studentnumber)"
        /// </remarks>
        /// <returns>The student data.</returns>
        public override string ToString()
        {
            switch (DisplayMode)
            {
                case 1:
                    return FirstName + ", " + LastName.Substring(0, 1) + ".";
                    break;
                case 2:
                    return FirstName + " " + LastName;
                    break;
                case 3:
                    return FirstName + " " + LastName + " (" + StudentNumber + ")";
                default:
                    return FirstName + ", " + LastName[0] + ".";
            }
        }
    }
}
