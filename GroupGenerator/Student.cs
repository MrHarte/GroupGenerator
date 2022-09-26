namespace GroupGenerator
    {/// <summary>
    /// Represents one Student holding their name, student number and a display mode attribute which changes the way the list is displayed.
    /// </summary>
    internal class Student : Person
    {
        /// <summary>
        /// the displayMode field holds an integer that defines which kind of display will be shown in the listBox.
        /// </summary>
        private static int displayMode = 1;

        /// <summary>
        /// the lastName field will hold the last name of the Student.
        /// </summary>
        private string lastName = string.Empty;

        /// <summary>
        /// the firstNames field will hold the first and middle name of the Student.
        /// </summary>
        private string firstNames = string.Empty;

        /// <summary>
        /// the studentNumber field will hold the Student's Student Number.
        /// </summary>
        private string studentNumber = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Constructor for a Student optionally adding their name.
        /// </summary>
        /// <param name="personString">Student's name, empty by default.</param>
        public Student(string personString = "")
        {
            int indexStudentNumberStart;
            int indexStudentNumberEnd;
            int lengthStudentNumber;
            indexStudentNumberStart = personString.IndexOf("(");
            indexStudentNumberEnd = personString.IndexOf(")");
            lengthStudentNumber = indexStudentNumberEnd - indexStudentNumberStart;
            this.studentNumber = personString.Substring(indexStudentNumberStart + 1, lengthStudentNumber - 1);
            int indexFirstName = personString.IndexOf(",");
            this.firstNames = personString.Substring(indexFirstName + 1, personString.Length - (lengthStudentNumber + indexFirstName + 3)).Trim();
            this.lastName = personString.Substring(0, personString.Length - (lengthStudentNumber + this.firstNames.Length + 4)).Trim();
        }

        /// <summary>
        /// Gets or sets the value that the displayMode attribute has been asigned to and returns it as an Integer.
        /// </summary>
        public static int DisplayMode
        {
            get { return displayMode; }
            set { displayMode = value; }
        }


        /// <summary>
        /// Gets the students first names and their last name and returns a string holding those values.
        /// </summary>
        public override string Name
        {
            get { return this.firstNames + " " + this.lastName; }
        }

        /// <summary>
        /// Gets the students first names, their last name and their student number and returns a string holding those values.
        /// </summary>
        public string FullDisplay
        {
            get { return this.lastName + ", " + this.firstNames + " " + "(" + this.studentNumber + ")"; }
        }

        /// <summary>
        /// Gets the students the first name of the student's first names (if it had more than one) and their last name first letter and returns a string holding those values.
        /// </summary>
        public string AbbreviatedDisplay
        {
            get
            {
                if (this.firstNames.Contains(" "))
                {
                    return this.firstNames.Substring(0, this.firstNames.IndexOf(" ")) + " " + this.lastName.Substring(0, 1) + ".";
                }
                else
                {
                    return this.firstNames + " " + this.lastName.Substring(0, 1) + ".";
                }
            }
        }

        /// <summary>
        /// The method will override the ToString() method and will add the desired display corresponding to which displayMode was chosen by clicking on the GroupForms's displays button.
        /// </summary>
        /// <returns> Returns the string that the designated by the DisplayMode attribute.</returns>
        public override string ToString()
        {
            // Depending on which button is clicked the display mode attribute will change and the list will be seen differently.
            if (displayMode == 1)
            {
                return this.FullDisplay;
            }
            else if (displayMode == 2)
            {
                return this.Name;
            }
           else
            {
                return this.AbbreviatedDisplay;
            }
        }
    }
}
