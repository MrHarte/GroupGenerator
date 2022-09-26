using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupGenerator
{
    internal class Student : Person
    {
        public Student()
        {
            Name = " ";
            LastName = " ";
            Id = " ";
            TextMode = 0;
        }

        public Student(string lastName, string name, string id, int textMode)
        {
            LastName = lastName;
            Name = name;
            Id = id;
            TextMode = TextMode;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public static int TextMode { get; set; }
    }

    public Student(string nameCollecter = "")
    {
        
    }

    public override string ToString()
    {

    }






} 
