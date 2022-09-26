using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupGenerator
{
    /// <summary>
    /// This is an internal class that is the child to the Person class
    /// </summary>
    /// <remarks></remarks>
    public class Student : Person
    {
        /// <summary>
        /// Name of the student
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Last name of the student 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Id of the student
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Static int property that hold which textmode is selected
        /// </summary>
        public static int TextMode { get; set; }

        /// <summary>
        ///  Holds all null values for all varibles 
        /// </summary>
        public Student()
        {
            Name = " ";
            LastName = " ";
            Id = " ";
            TextMode = 0;
        }

        /// <summary>
        /// Non parameterized constructors
        /// </summary>
        /// <param name="lastName">Non parameterized constructor for lastName</param>
        /// <param name="name">Non parameterized constructor for name</param>
        /// <param name="id">Non parameterized constructor for id</param>
        /// <param name="textMode">Non parameterized constructor for textMode</param>
        public Student(string lastName, string name, string id, int textMode)
        {
            LastName = lastName;
            Name = name;
            Id = id;
            TextMode = TextMode;
        }
    }
    /// <summary>
    /// basis for tokenizing strings
    /// </summary>
    /// <param name="nameCollecter">varible that hold strings in importform</param>
    /// <remarks> This section is incomplete </remarks>
    public Student(string nameCollecter = "")
    {
        
    }
    /// <summary>
    /// ToString method turns class into strings
    /// </summary>
    /// <returns>class properites as string</returns>
    /// <remarks> This section is incomplete </remarks>
    public override string ToString()
    {

    }






} 
