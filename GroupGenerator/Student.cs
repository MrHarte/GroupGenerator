namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public partial class Student : Person
    {
        /*
         * +Have student number as string
         * +Student name (first, last names) as string
         * +A constructor Student(string Name)
         * +static display mode as int
         * Student constructor giving first name, last name and ID
         * Changes = import form for student
         */

        /// <summary>
        /// Store First Name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Stores Last Name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Store Student Number.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// To Change Display Mode.
        /// </summary>
        private static int displayMode = 0;
        /// <summary>
        /// Get Name from Person Class.
        /// </summary>
        public override string Name { get; set; }
        /// <summary>
        /// Get List Of Persons.
        /// </summary>
        private BindingList<Person> personList;

        /// <summary>
        /// Constructor To Split Name Into 3 Display Modes.
        /// </summary>
        /// <param name="name"></param>
        public Student(string name)
        {
            string[] fullName;
            fullName = name.Split(',', '(', ')');
            name = fullName[0] + " " + fullName[1] + " " + fullName[2];
        }

        /// <summary>
        /// Initializes Student With First Name, Last Name And Id.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        public Student(string firstName, string lastName, string id)
        {
            firstName = FirstName;
            lastName = LastName;
            id = Id;
        }
    }
}
