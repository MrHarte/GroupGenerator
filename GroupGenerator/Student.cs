using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    internal class Student : Person
    {

        private int _displayMode;

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public override string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public Student(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
