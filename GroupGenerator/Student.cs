using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GroupGenerator
{
    public class Student: Person
    {

        string _firstName;
        string _lastName;
        string _studentNumber;

        public Student(string studentString)
        {
            string[] studentData = new string[3];

            // Put the entered data into an array
            char[] delimiters = { ',', '(', ')' };
            studentData = studentString.Split(delimiters, StringSplitOptions.TrimEntries);

            // Transfer the data from the array to the appropriate properties
            FirstName = studentData[1];
            LastName = studentData[0];
            StudentNumber = studentData[2];
        }

        string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }

        public static int DisplayMode { get; set; }

        public override string ToString()
        {
            switch(DisplayMode)
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
