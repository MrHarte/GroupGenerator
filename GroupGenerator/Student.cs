using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{/// <summary>
/// Represent a student object saving their first name, last name, last name abriviation, id and display mode seperatly
/// </summary>
    internal class Student : Person
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="Student"/> class based on the <see cref="Person"/> .
        /// </summary>
        /// <param name="firstName">The student's first name. </param>
        /// <param name="lastName">The student's last name.</param>
        /// <param name="lastNameAbriviation">The student's abriviated last name.</param>
        /// <param name="id">The student's id number.</param>

        public Student(string firstName, string lastName, string lastNameAbriviation, string id )
        {
            FirstName = firstName;
            LastName = lastName;
            LastNameAbriviation = lastNameAbriviation;
            Id = id;
            
        }
        /// <summary>
        /// The gets and sets for the student's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The gets and sets for the students's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// the gets and sets for the student's abriviated last name.
        /// </summary>
        public string LastNameAbriviation { get; set; }
        /// <summary>
        /// The gets and sets for the students's ID number.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Get the first name and the abriviated last name of the student class and murge them together.
        /// </summary>
        /// <remarks>Not completed</remarks>
        /// <returns>The line to be printed.</returns>
        public string DisplayFirstName()
        {
              string line = "";
              line = FirstName + " " + LastNameAbriviation;
              return line;

        }

        /// <summary>
        /// Get the first name and the last name of the student class and murge them together.
        /// </summary>
        /// <remarks>Not completed.</remarks>
        /// <returns>The first name and the last name.</returns>
        public static string DisplayLastName()
        { 
             return FirstName + " " + LastName;
        }

        /// <summary>
        /// Get the first name, the last name, and the ID of the student class and murge them together.
        /// </summary>
        /// <remarks>Not completed.</remarks>
        /// <returns>The first name, last name, and id</returns>
        public static string DisplayID()
        {
            return FirstName + " " + LastName + " " + Id;
        }


    }
}
