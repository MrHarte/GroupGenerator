using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    /// <summary>
    /// 
    /// </summary>
    internal class Student : Person
    {
        private string firstName;
        private string lastName;
        private string studentID;
        private int displayMode;

        public Student(string studentInfo)
        {
            this.SplitStudent(studentInfo);

            this.Name = FullName();
        }

        public void SplitStudent(string studentInfo)
        {

            string[] splitInfo = studentInfo.Split(',', '(');

            this.lastName = splitInfo[0].Trim();

            this.firstName = splitInfo[1].Trim();

            if (splitInfo.Length == 3)
            {
                this.studentID = "(" + splitInfo[2].Trim();
            }
            else
            {
                this.studentID = string.Empty;
            }
        }

        public string FirstName()
        {
            return this.firstName + " " + this.lastName.Substring(0, 1);
        }

        public string FullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public string FullNameWithID()
        {
            return this.firstName + " " + this.lastName + " " + this.studentID;
        }
    }
}
