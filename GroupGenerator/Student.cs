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
        /*
        //todo:
        //+id: string
        //+FirstName: string
        //+LastName: string
        //-<<static>> dsiplayMode: int
        //Constructor:
        //+Student(name: string)
        //+Student(fistName, lastName, id)
        //+ToString : string
        //Change the entity type of the list from person to student
        //Save as static variable
        */

        // TODO constructory
  
        public Student(string firstName, string lastName, string LastNameAbriviation,string id)
        {
            FirstName = "";
            LastName = "";
            LastNameAbriviation = "";
            Id = "";
            
        }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            LastNameAbriviation = string.Empty;
            Id = string.Empty;
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastNameAbriviation { get; set; }
        public string Id { get; set; }


        public void SuperSplitter()
        {

        }

        public void DisplayFirstName()
        {
            
        }

        public void DisplayLastName()
        {

        }

        public void DisplayID()
        {

        }


    }
}
