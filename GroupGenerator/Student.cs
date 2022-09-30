using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    /// <summary>
    /// This class holds the information of student.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// This constant field holds the number 1 which is significant of the first display mode(Ted M.).
        /// </summary>
        private const int firstnameLastnameAbreviated = 1;

        /// <summary>
        /// This constant field holds the number 2 which is significant of the second display name(Ted Evelyn Mosby).
        /// </summary>
        private const int firstnameLastname = 2;

        /// <summary>
        /// This constant field holds the number 3 which is significant of the third display name(Mosby, Ted Evelyn (12345)).
        /// </summary>
        private const int lastnameFirstnameId = 3;


        /// <summary>
        /// This is the constructor which splits the name of a student.
        /// </summary>
        /// <param name="name">Holds the name input</param>
        public Student(string name)
        {
            string[] fullname;
            name.Trim();
            fullname = name.Split(',', '(', ')');
            Name = fullname[1].Trim() + " " + fullname[0].Trim();
            LastName = fullname[0].Trim();
            FirstName = fullname[1].Trim();
            Id = fullname[2].Trim();
        }

        /// <summary>
        /// This property holds the Id of student.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// This property holds the First name of student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// This property holds the Last name of student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// This property holds the display mode number.
        /// </summary>
        private static int DisplayMode { get; set; }

        /// <summary>
        /// This method displays the name of student in order of first name and then last name abreviated by first letter.
        /// </summary>
        /// <returns>The ordered name according to the display mode.</returns>
        public string DisplayModefirstnameLastnameAbreviated()
        {
            string result;
            DisplayMode = firstnameLastnameAbreviated;
            result = FirstName + " " + LastName[0] + ".";
            return result;
        }

        /// <summary>
        /// This method displays the name of student in order of first name and then last name.
        /// </summary>
        /// <returns>The ordered name according to the display mode.</returns>
        public string DisplayModeFirstnameLastname()
        {
            string result;
            DisplayMode = firstnameLastname;
            result = Name;
            return result;
        }

        /// <summary>
        /// This method displays the name of student in order of last name then a coma then first name and then he id inside a parantheses.
        /// </summary>
        /// <returns>The ordered name according to the display mode.</returns>
        public string DisplayModeLastnameFirstnameId()
        {
            string result;
            DisplayMode = lastnameFirstnameId;
            result = LastName + ", " + FirstName + " (" + Id + ")";
            return result;
        }
    }
}
