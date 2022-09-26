using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    /// <summary>
    /// Student Class Is used to define the properties of one Student.
    /// </summary>
    /// <remarks>
    /// Inherits Name from Person class to create the basis of a Student.
    /// </remarks>
    public class Student : Person
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// non-paramaterized constructors for Student class.
        /// </summary>
        /// <param name="firstName">Students first name.</param>
        /// <param name="lastName">Students last name.</param>
        /// <param name="studentNumber">Students Id Number.</param>
        /// <param name="displayMode">Display mode for showing information in a specific order.</param>
        public Student(string firstName, string lastName, string studentNumber, int displayMode)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;
            DisplayMode = displayMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Paramaterized Constructors to hold default values for properties.
        /// </summary>
        /// <remarks>
        /// Every String Value, FirstName, LastName, StudentNumber, hold empty strings when empty.
        /// Displaymode holds a 0 when empty because it is an Interger Value.
        /// </remarks>
        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentNumber = string.Empty;
            DisplayMode = 0;
        }

        /// <summary>
        /// Gets or Sets Display mode for the way information is ordered.
        /// </summary>
        public static int DisplayMode { get; set; }

        /// <summary>
        /// Gets or Sets First Name of Student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///  Gets or Sets Last Name of Student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Student ID number.
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Takes information from TextList in ImportForm and splits it into class properties.
        /// </summary>
        /// <param name="all">Information recived from importform TextList i.e. Names. </param>
        public Student(string all = "")
        {
            char[] delim = { ',', '(', ')' };
            string[] tokens = all.Split(delim);

            LastName = tokens[0].ToString();
            FirstName = tokens[1].ToString();
            StudentNumber = tokens[2].ToString();
        }

        /// <summary>
        /// Takes Information from Student method and turns it into a string.
        /// </summary>
        /// <remarks>
        /// Incomplete.
        /// </remarks>
        /// <returns> Returns entire name in a string format.
        /// </returns>
        public override string ToString()
        {
            
        }

        /// <summary>
        /// Switch case to switch between different display mode strings depending on selected display mode.
        /// </summary>
        /// <remarks>
        /// Incomplete Missing final case for First name and Last name shortened.
        /// </remarks>
        public DisplayMode()
        {
            switch (DisplayMode)
            {
                case 0:
                    Name = LastName + " " + FirstName;
                    break;
                case 1:
                    Name = FirstName + " " + LastName + " " + StudentNumber;
                    break;
                default: 
                    Console.WriteLine("Nothing");
                    break;

                    return Name; 

            }
        }
    }
}
