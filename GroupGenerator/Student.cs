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
    internal class Student : Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private static int DisplayNumber = 1;


        public Student(string input)
        {
            input = input.Trim();
        }

        //Methods

        //Sudent (name: string)
        //Student (FirstName, LastName)

        public override string ToString()
        {
            if (DisplayNumber == 1)
            {

            }
            return this.Name;
        }

    }
}
