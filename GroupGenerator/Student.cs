namespace GroupGenerator
{
    /// <summary>
    /// Represents one student saving their name.
    /// </summary>
    internal class Student : Person
    {
        // Properties

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public override string Name { get => base.Name; set => base.Name = value; }

        /// <summary>
        /// Gets or sets the first name of the student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the id of the student.
        /// </summary>
        public string StudentID { get; set; }

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="name">Student's name, empty by default.</param>
        public Student(string name = "")
            : base(name)
        {
            this.Name = name;

            this.GetDetails();
        }

        // Methods

        /// <summary>
        /// Gets the possible first name, last name and student id from the full name.
        /// </summary>
        public void GetDetails()
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            string studentID = string.Empty;

            if (this.Name.Contains('('))
            {
                studentID = this.Name.Split('(', ')')[1].Trim();
            }

            if (this.Name.Contains(','))
            {
                lastName = this.Name.Split(',', '(')[0].Trim();
                firstName = this.Name.Split(',', '(')[1].Trim();
            }
            else
            {
                firstName = this.Name.Split(' ', '(')[0].Trim();
                lastName = this.Name.Split(' ', '(')[1].Trim();
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentID = studentID;
        }
    }
}
