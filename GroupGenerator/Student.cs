using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    internal class Student : Person
    {
        public Student(string name, string firstName, string lastName, string studentNumber, int displayMode)
        {
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;
            DisplayMode = displayMode;
        }

        public Student()
        {
            Name = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentNumber = string.Empty;
            DisplayMode = 0;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentNumber { get; set; }

        public static int DisplayMode { get; set; }

        public override string Name { get; set; }

        public Student(string all = "")
        {
            char[] delim = { ',', '(', ')' };
            string[] tokens = all.Split(delim);

            LastName = tokens[0].ToString();
            FirstName = tokens[1].ToString();
            StudentNumber = tokens[2].ToString();


        }

        public override string ToString()
        {
            return this.Name;
        }

        //seems to lock up on first entry
        // how to unfreeze hold in variable?
        //display modes 
        //list?

        /*public DisplayMode1()
        {

        }
        public DisplayMode2()
        {

        }
        public DisplayMode3()
        {

        }*/


        //public string Student()
        //{
        //Person person = new Person();

        // return Name;
        // }

        //CREATE ARRAY USE SWITCH CASE FOR RADIO BUTTONS
        // take data from listbox and add it to class properties

        // QUESTIONS TO ASK SPLITTING TEXT INTO CLASS PROPS
        // () FOR STUDENT NUMBERS??
        // put a focus on a first radio button
    }
}
