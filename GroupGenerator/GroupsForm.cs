namespace GroupGenerator
{
    using System.ComponentModel;
    using System.Web;
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
        private BindingList<Person> personList;

        /// <summary>
        /// Random number generator for picking.
        /// </summary>
        private Random rng;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsForm"/> class.
        /// Constructor of the main form.
        /// </summary>
        public GroupsForm()
        {
            this.InitializeComponent();
            this.personList = new BindingList<Person>();
            this.groupsListBox.DataSource = this.personList;
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
            this.personList.Add(new Person("Ted, Mosby (524755)"));
            this.personList.Add(new Person("Marshall, Eriksen (952524)"));
            this.personList.Add(new Person("Robin, Scherbatsky (152364)"));
            this.personList.Add(new Person("Barney, Stinson (785427)"));
            this.personList.Add(new Person("Lily, Aldrin (235415)"));
            this.personList.Add(new Person("Tracy, McConnell (885524)"));
            this.personList.Add(new Person("Ranjit, Singh (555651)"));
            this.personList.Add(new Person("Sandy, Rivers (356821)"));
            this.personList.Add(new Person("Carl, MacLaren (952191)"));
            this.personList.Add(new Person("Marvin, Eriksen (678412)"));
            this.personList.Add(new Person("Judy, Eriksen (115239)"));
            this.personList.Add(new Person("Gary, Blauman (885464)"));
            this.personList.Add(new Person("Loretta, Stinson (852456)"));
            this.personList.Add(new Person("Stella, Zinman (984652)"));
            this.personList.Add(new Person("Randy, Wharmpess (649841)"));
            this.personList.Add(new Person("Tony, Grafanello (951753)"));
            this.personList.Add(new Person("Zoey, Pierson (193567)"));
            this.personList.Add(new Person("Jerome, Whittaker (784162)"));
            this.personList.Add(new Person("Quinn, Garvey (368715)"));
            this.personList.Add(new Person("William, Zabka (614688)"));
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

            Person[,] groups = GroupsFormHelpers.SplitIntoGroups(this.personList, numberOfGroups, maxGroupSize);

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

            Person[,] groups = GroupsFormHelpers.SplitIntoGroups(this.personList, numberOfGroups, maxGroupSize);

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
        /// Radio button to display the first Name and the abriviated last Name.
        /// </summary>
        /// <remarks>
        /// Not completed
        /// </remarks>
        /// <param name="sender">The radio button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void firstNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstNameRadioButton.Checked == true) {
                Student.DisplayFirstName(); 
            }
           
        }

        /// <summary>
        /// Radio button to display the first Name and the last Name.
        /// </summary>
        /// <remarks>
        /// Not completed.
        /// </remarks>
        /// <param name="sender">The radio button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void lastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lastNameRadioButton.Checked == true)
            {
                Student.DisplayLastName();
            }
        }

        /// <summary>
        /// Radio button to display the first Name, the last Name, and the student Number.
        /// </summary>
        /// <remarks>
        /// Not completed.
        /// </remarks>
        /// <param name="sender">The radio button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void studentNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (studentNumberRadioButton.Checked == true)
            {
                Student.DisplayID();
            }
        }
        /// <summary>
        /// Create a new Student object base on the person class.
        /// </summary>
        /// <remark>
        /// Goes through a loop of all person object in the person list in order to split it into an array and retreiving relevent informations.
        /// </remark>
        /// <param name="name">The full student information.</param>
        /// <param name="firstName">The first name of the student.</param>
        /// <param name="lastName">The last Name of the student.</param>
        /// <param name="lastNameAbriviation">The first letter of the last name.</param>
        /// <paran name="id">The ID number of the Student.</paran>
        public void sendStudentlist()
        {
            string[] name = {};
            string firstName = "";
            string lastName = "";
            string lastNameAbriviation = "";
            string id = "";

            for (int i = 0; i < this.personList.Count; i++)
            { 
                name = personList[i].Name.Split(new string[] { " ", ",", "(", ")" }, StringSplitOptions.None);
                firstName = name[0];
                lastName = name[1];
                lastNameAbriviation = lastName.Substring(0, 1) + ".";
                id = name[2];

                Student student = new Student(firstName, lastName, lastNameAbriviation, id);
            }
        }
    }
}