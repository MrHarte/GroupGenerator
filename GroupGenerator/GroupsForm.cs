namespace GroupGenerator
{
    using System.ComponentModel;
    using ExtensionMethods;

    /// <summary>
    /// Main form class.
    /// </summary>
    public partial class GroupsForm : Form
    {
        /// <summary>
        /// List of people used to make groups.
        /// </summary>
        /// <remarks>
        /// This list is bound to the ListBox displaying the people in the groups form.
        /// </remarks>
        private BindingList<Student> personList;

        /// <summary>
        /// Random number generator for picking.
        /// </summary>
        private Random rng;


        /// <summary>
        /// List of students
        /// </summary>
        /// <remarks>
        /// This lis is bound to the ListBox displaying the students in the groups form.
        /// </remarks>
        private BindingList<string> studentList;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsForm"/> class.
        /// Constructor of the main form.
        /// </summary>
        public GroupsForm()
        {
            this.InitializeComponent();
            this.personList = new BindingList<Student>();
            this.studentList = new BindingList<string>();
            this.groupsListBox.DataSource = this.studentList;
            this.rng = new Random();
            this.EditListButton_Click(this, new EventArgs());
        }

        /// <summary>
        /// Shuffles the people list.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            this.personList.Shuffle();
        }

        /// <summary>
        /// Picks one item of the listBox randomly.
        /// </summary>
        /// <remarks>
        /// Jumps the selected item in the listBox 20 times slowing down gradually.
        /// </remarks>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void PickOneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(20 * i);
                this.groupsListBox.SetSelected(this.rng.Next(this.personList.Count), true);
            }
        }

        /// <summary>
        /// Loads an example list of people into the listBox.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void LoadExampleListButton_Click(object sender, EventArgs e)
        {
            this.personList.Clear();
            this.personList.Add(new Student("Ted Mosby"));
            this.personList.Add(new Student("Marshall Eriksen"));
            this.personList.Add(new Student("Robin Scherbatsky"));
            this.personList.Add(new Student("Barney Stinson"));
            this.personList.Add(new Student("Lily Aldrin"));
            this.personList.Add(new Student("Tracy McConnell"));
            this.personList.Add(new Student("Ranjit Singh"));
            this.personList.Add(new Student("Sandy Rivers"));
            this.personList.Add(new Student("Carl MacLaren"));
            this.personList.Add(new Student("Marvin Eriksen"));
            this.personList.Add(new Student("Judy Eriksen"));
            this.personList.Add(new Student("Gary Blauman"));
            this.personList.Add(new Student("Loretta Stinson"));
            this.personList.Add(new Student("Stella Zinman"));
            this.personList.Add(new Student("Randy Wharmpess"));
            this.personList.Add(new Student("Tony Grafanello"));
            this.personList.Add(new Student("Zoey Pierson"));
            this.personList.Add(new Student("Jerome Whittaker"));
            this.personList.Add(new Student("Quinn Garvey"));
            this.personList.Add(new Student("William Zabka"));
            this.personList.Shuffle();
        }

        /// <summary>
        /// Splits the people list into groups of a specified size and displays them.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void SplitIntoGroupsOfButton_Click(object sender, EventArgs e)
        {
            int maxGroupSize = GroupsFormHelpers.GetNumberFrom(this.groupSizeBox);
            if (maxGroupSize == 0)
            {
                return;
            }

            this.personList.Shuffle();

            int numberOfGroups = this.personList.Count / maxGroupSize;
            if (this.personList.Count % maxGroupSize != 0)
            {
                numberOfGroups++;
            }

            Student[,] groups = GroupsFormHelpers.SplitIntoGroups(this.personList, numberOfGroups, maxGroupSize);

            DisplayGroupsForm displayGroupsForm = new DisplayGroupsForm(groups);
            displayGroupsForm.ShowDialog();
        }

        /// <summary>
        /// Executes the SplitIntoGroupsOfButton_Click method on clicking "Enter" in the groupSizeBox.
        /// </summary>
        /// <param name="sender">TextBox that was typed in.</param>
        /// <param name="e">Additional event arguments.</param>
        private void GroupSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SplitIntoGroupsOfButton_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Splits the people list into specified number of groups and displays them.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void SplitIntoGroupsButton_Click(object sender, EventArgs e)
        {
            int numberOfGroups = GroupsFormHelpers.GetNumberFrom(this.numberOfGroupsBox);
            if (numberOfGroups == 0)
            {
                return;
            }

            this.personList.Shuffle();

            int maxGroupSize = this.personList.Count / numberOfGroups;
            if (this.personList.Count % numberOfGroups != 0)
            {
                maxGroupSize++;
            }

            Student[,] groups = GroupsFormHelpers.SplitIntoGroups(this.personList, numberOfGroups, maxGroupSize);

            DisplayGroupsForm displayGroupsForm = new DisplayGroupsForm(groups);
            displayGroupsForm.ShowDialog();
        }

        /// <summary>
        /// Executes the SplitIntoGroupsButton_Click method on clicking "Enter" in the numberOfGroupsBox.
        /// </summary>
        /// <param name="sender">TextBox that was typed in.</param>
        /// <param name="e">Additional event arguments.</param>
        private void NumberOfGroupsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SplitIntoGroupsButton_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Opens the ImportForm to modify the personList.
        /// </summary>
        /// <remarks>
        /// Opened at the start for initial import.
        /// </remarks>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void EditListButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this.personList);
            /* Attention, there is an error in the book about this (p. 634)!
             * Modeless forms are displayed with the Show() function.
             * However, we want a modal form:
             */
            importForm.ShowDialog();
        }


        /// <summary>
        /// This method displays the name of students according to the display mode(First name Last name abreviated with the first letter).
        /// </summary>
        /// <param name="sender">The radio button that was checked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void firstnameLastnameAbbreviatedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstnameLastnameAbbreviatedRadioButton.Checked)
            {
                this.groupsListBox.DataSource = null;
                this.studentList.Clear();
                for (int i = 0; i < this.personList.Count; i++)
                {
                    this.studentList.Add(personList[i].FirstName + " " + personList[i].LastName[0] + ".");
                }
                this.groupsListBox.DataSource = this.studentList;
            }
            
            /*Student newStudent = new Student("Khaliqyar, Munir (123456)");
            MessageBox.Show(newStudent.LastName);
            MessageBox.Show(newStudent.FirstName);
            MessageBox.Show(newStudent.Id);
            MessageBox.Show(newStudent.Name);*/
        }

        /// <summary>
        /// This method displays the name of students according to the display mode(Full name).
        /// </summary>
        /// <param name="sender">The radio button that was checked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void firstnameLastnameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstnameLastnameRadioButton.Checked)
            {
                this.groupsListBox.DataSource = null;
                this.studentList.Clear();
                for (int i = 0; i < this.personList.Count; i++)
                {
                    this.studentList.Add(personList[i].Name);
                }
                this.groupsListBox.DataSource = this.studentList;
            }
        }

        /// <summary>
        /// This method displays the name of students according to the display mode(Last name, First name (ID)).
        /// </summary>
        /// <param name="sender">The radio button that was checked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void lastnameFirstnameIdNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lastnameFirstnameIdNumberRadioButton.Checked)
            {
                this.groupsListBox.DataSource = null;
                this.studentList.Clear();
                for (int i = 0; i < this.personList.Count; i++)
                {
                    this.studentList.Add(personList[i].LastName + ", " + personList[i].FirstName + " (" + personList[i].Id + ")");
                }
                this.groupsListBox.DataSource = this.studentList;
            }
        }

        
    }
}