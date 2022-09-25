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
            this.personList.Add(new Person("Ted Mosby"));
            this.personList.Add(new Person("Marshall Eriksen"));
            this.personList.Add(new Person("Robin Scherbatsky"));
            this.personList.Add(new Person("Barney Stinson"));
            this.personList.Add(new Person("Lily Aldrin"));
            this.personList.Add(new Person("Tracy McConnell"));
            this.personList.Add(new Person("Ranjit Singh"));
            this.personList.Add(new Person("Sandy Rivers"));
            this.personList.Add(new Person("Carl MacLaren"));
            this.personList.Add(new Person("Marvin Eriksen"));
            this.personList.Add(new Person("Judy Eriksen"));
            this.personList.Add(new Person("Gary Blauman"));
            this.personList.Add(new Person("Loretta Stinson"));
            this.personList.Add(new Person("Stella Zinman"));
            this.personList.Add(new Person("Randy Wharmpess"));
            this.personList.Add(new Person("Tony Grafanello"));
            this.personList.Add(new Person("Zoey Pierson"));
            this.personList.Add(new Person("Jerome Whittaker"));
            this.personList.Add(new Person("Quinn Garvey"));
            this.personList.Add(new Person("William Zabka"));
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
        /// Updates the displayed items in the groupsListBox.
        /// </summary>
        private void RefreshListBox()
        {
            this.personList.ResetBindings();
        }

        /// <summary>
        /// Changes the DisplayMode in the Student class to 1.
        /// </summary>
        /// <param name="sender">The radioButton that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void display1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Student.DisplayMode = 1;
            this.RefreshListBox();
        }

        /// <summary>
        /// Changes the DisplayMode in the Student class to 2.
        /// </summary>
        /// <param name="sender">The radioButton that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void display2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Student.DisplayMode = 2;
            this.RefreshListBox();
        }

        /// <summary>
        /// Changes the DisplayMode in the Student class to 3.
        /// </summary>
        /// <param name="sender">The radioButton that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void display3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Student.DisplayMode = 3;
            this.RefreshListBox();
        }
    }
}