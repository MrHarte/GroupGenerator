using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    /// <summary>
    /// Student class will adapt how the student names will show in the program.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Constructor to transform Person.Name instances in FirstName, LastName and ID.
        /// </summary>
        /// <param name="input">This is the input from the Person Class, from the Student.Name to be precise.</param>
        public Student(string input)
        {
            input = input.Trim();
            string[] splitInput;

            splitInput = input.Split(' ');
            LastName = splitInput[0];
            FirstName = splitInput[1];

            // If the user does not enter a ID number with the student, it does not save one
            if (splitInput.Length > 2)
            {
                Id = splitInput[2];
            }
        }

        /// <summary>
        /// This is to create an Student Id to save.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// This is to create a FirstName to save.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// This is to create a LastName to save.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// This is to register the way Student instances will be displaied.
        /// </summary>

        public static int DisplayNumber = 1;

        /// <summary>
        /// This Method is to control the display of the available options.
        /// </summary>
        /// <returns>This method returns</returns>
        public override string ToString()
        {
            // This is to change the value of the return depending on the DisplayNumber variable
            if (DisplayNumber == 2)
            {
                return this.FirstName + " " + this.LastName;
            }
            if (DisplayNumber == 3)
            {
                return this.FirstName + " " + this.LastName + " " + this.Id;
            }
            else
            {
                return this.FirstName + ", " + this.LastName[0];
            }
        }
    }
}
