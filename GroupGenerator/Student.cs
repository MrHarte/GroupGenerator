namespace GroupGenerator
{
    /// <summary>
    /// Represents one Student saving their first name, last name, and student ID.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Private field to hold the students first name.
        /// </summary>
        private string firstName;

        /// <summary>
        /// Private field to hold the students last name.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Private field to hold the students ID number.
        /// </summary>
        private string studentID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// Constructor for a Student seperating the information into an array.
        /// </summary>
        /// <param name="studentInfo">String that holds the students information.</param>
        public Student(string studentInfo)
        {
            this.SplitStudent(studentInfo);
            MessageBox.Show(this.FirstName);
            this.Name = this.FullNameMode();
        }

        /// <summary>
        /// Gets the first name of the student.
        /// </summary>
        public string FirstName
        {
            get { return this.firstName; }
        }

        /// <summary>
        /// Gets the last name of the student.
        /// </summary>
        public string LastName
        {
            get { return this.lastName; }
        }

        /// <summary>
        /// Gets the ID number of the student.
        /// </summary>
        public string StudentID
        {
            get { return this.studentID; }
        }

        /// <summary>
        /// This method splits the students information into 3 strings. firstName, lastName, and studentID.
        /// </summary>
        /// <param name="studentInfo">String that holds the students information.</param>
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

        /// <summary>
        /// This method concactinates the students information (firstName, first letter of lastName).
        /// </summary>
        /// <returns>Returns the students first name and initial of their last name.</returns>
        public string FirstNameMode()
        {
            return string.Concat(this.FirstName, " ", this.LastName.Substring(0, 1) + ".");
        }

        /// <summary>
        /// This method concactinates the students information (firstName, lastName).
        /// </summary>
        /// <returns>Returns students full name.</returns>
        public string FullNameMode()
        {
            return this.FirstName + " " + this.LastName;
        }

        /// <summary>
        /// This method concactinates the students information (firsName, lastName, studentID).
        /// </summary>
        /// <returns>Returns students full name with their student ID.</returns>
        public string FullNameWithIDMode()
        {
            return this.LastName + ", " + this.FirstName + " " + this.StudentID;
        }
    }
}
