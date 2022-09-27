namespace GroupGenerator
{
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Drawing.Text;
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
            this.displayModeOneRadioButton.Checked = true;
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
            this.personList.Add(new Student("Ted, Mosby (6978639)"));
            this.personList.Add(new Student("Marshall, Eriksen (6961326)"));
            this.personList.Add(new Student("Robin, Scherbatsky (6375003)"));
            this.personList.Add(new Student("Barney, Stinson (6236471)"));
            this.personList.Add(new Student("Lily, Aldrin (0756495)"));
            this.personList.Add(new Student("Tracy, McConnell (7936213)"));
            this.personList.Add(new Student("Ranjit, Singh (3874496)"));
            this.personList.Add(new Student("Sandy, Rivers (4193406)"));
            this.personList.Add(new Student("Carl, MacLaren (2965287)"));
            this.personList.Add(new Student("Marvin, Eriksen (1085283)"));
            this.personList.Add(new Student("Judy, Eriksen (8177263)"));
            this.personList.Add(new Student("Gary, Blauman (2935123)"));
            this.personList.Add(new Student("Loretta, Stinson (0573661)"));
            this.personList.Add(new Student("Stella, Zinman (6227188)"));
            this.personList.Add(new Student("Randy, Wharmpess (1029002)"));
            this.personList.Add(new Student("Tony, Grafanello (7676278)"));
            this.personList.Add(new Student("Zoey, Pierson (9120366)"));
            this.personList.Add(new Student("Jerome, Whittaker (9203043)"));
            this.personList.Add(new Student("Quinn, Garvey (9872536)"));
            this.personList.Add(new Student("William, Zabka (2819372)"));
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
        /// Empty the file and allow to keep adding more names.
        /// </summary>
        private void RefreshGroupsListBox()
        {
            this.groupsListBox.DataSource = null;
            this.groupsListBox.DataSource = this.personList;
        }

        /// <summary>
        /// Change the DisplayMode depending on the ifs that will change the order of the names.
        /// </summary>
        public void ChangeDisplay()
        {
            if(displayModeOneRadioButton.Checked == true)
            {
                Student.DisplayMode = Student.DisplayModeLastNameF;
            }
            if(displayModeTwoRadioButton.Checked == true)
            {
                Student.DisplayMode = Student.DisplayModeLastNameFirstName;
            }
            if(displayModeThreeRadioButton.Checked == true)
            {
                Student.DisplayMode = Student.DisplayModeFirstNameLastNameId;
            }

            RefreshGroupsListBox();
        }

        /// <summary>
        /// Change the order of the names to FirstName and the first letter of LastName
        /// </summary>
        /// <param name="sender">RadioButton clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void displayModeOneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDisplay();
        }

        /// <summary>
        /// Change the order of the names to LastName and FirstName.
        /// </summary>
        /// <param name="sender">RadioButton clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void displayModeTwoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDisplay();
        }

        /// <summary>
        /// Change the order of the names to LastName, FirstName and ID.
        /// </summary>
        /// <param name="sender">RadioButton clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void displayModeThreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDisplay();
        }
    }
}