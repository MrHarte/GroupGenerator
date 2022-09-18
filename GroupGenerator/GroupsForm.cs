using ExtensionMethods;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GroupGenerator
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class GroupsForm : Form
    {
        /// <summary>
        /// List of people used to make groups
        /// </summary>
        /// <remarks>
        /// This list is bound to the ListBox displaying the people in the groups form.
        /// </remarks>
        private BindingList<Person> _personList;

        /// <summary>
        /// Random number generator for picking
        /// </summary>
        private Random _rng;

        /// <summary>
        /// Constructor of the main form
        /// </summary>
        public GroupsForm()
        {
            InitializeComponent();
            this._personList = new BindingList<Person>();
            groupsListBox.DataSource = this._personList;
            groupsListBox.DisplayMember = "Name";
            _rng = new Random();
            this.editListButton_Click(this, new EventArgs());
        }

        /// <summary>
        /// Shuffles the people list
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            _personList.Shuffle();
        }

        /// <summary>
        /// Picks one item of the listBox randomly
        /// </summary>
        /// <remarks>
        /// Jumps the selected item in the listBox 20 times slowing down gradually
        /// </remarks>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void pickOneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(20 * i);
                groupsListBox.SetSelected(_rng.Next(_personList.Count), true);
            }
        }

        /// <summary>
        /// Loads an example list of people into the listBox
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void loadExampleListButton_Click(object sender, EventArgs e)
        {
            this._personList.Clear();
            this._personList.Add(new Person("Ted Mosby"));
            this._personList.Add(new Person("Marshall Eriksen"));
            this._personList.Add(new Person("Robin Scherbatsky"));
            this._personList.Add(new Person("Barney Stinson"));
            this._personList.Add(new Person("Lily Aldrin"));
            this._personList.Add(new Person("Tracy McConnell"));
            this._personList.Add(new Person("Ranjit Singh"));
            this._personList.Add(new Person("Sandy Rivers"));
            this._personList.Add(new Person("Carl MacLaren"));
            this._personList.Add(new Person("Marvin Eriksen"));
            this._personList.Add(new Person("Judy Eriksen"));
            this._personList.Add(new Person("Gary Blauman"));
            this._personList.Add(new Person("Loretta Stinson"));
            this._personList.Add(new Person("Stella Zinman"));
            this._personList.Add(new Person("Randy Wharmpess"));
            this._personList.Add(new Person("Tony Grafanello"));
            this._personList.Add(new Person("Zoey Pierson"));
            this._personList.Add(new Person("Jerome Whittaker"));
            this._personList.Add(new Person("Quinn Garvey"));
            this._personList.Add(new Person("William Zabka"));
            this._personList.Shuffle();
        }

        /// <summary>
        /// Splits the people list into groups of a specified size and displays them
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void splitIntoGroupsOfButton_Click(object sender, EventArgs e)
        {
            int maxGroupSize = GroupsForm.getNumberFrom(groupSizeBox);
            if (maxGroupSize == 0)
                return;

            _personList.Shuffle();

            int numberOfGroups = _personList.Count / maxGroupSize;
            if (_personList.Count % maxGroupSize != 0)
                numberOfGroups++;

            Person[,] groups = GroupsForm.splitIntoGroups(_personList, numberOfGroups, maxGroupSize);

            DisplayGroupsForm displayGroupsForm = new DisplayGroupsForm(groups);
            displayGroupsForm.ShowDialog();
        }

        /// <summary>
        /// Executes the splitIntoGroupsOfButton_Click method on clicking "Enter" in the groupSizeBox
        /// </summary>
        /// <param name="sender">TextBox that was typed in</param>
        /// <param name="e">Additional event arguments</param>
        private void groupSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                splitIntoGroupsOfButton_Click(this, new EventArgs());
        }

        /// <summary>
        /// Splits the people list into specified number of groups and displays them
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void splitIntoGroupsButton_Click(object sender, EventArgs e)
        {
            int numberOfGroups = GroupsForm.getNumberFrom(numberOfGroupsBox);
            if (numberOfGroups == 0)
                return;

            _personList.Shuffle();

            int maxGroupSize = _personList.Count / numberOfGroups;
            if (_personList.Count % numberOfGroups != 0)
            {
                maxGroupSize++;
            }

            Person[,] groups = GroupsForm.splitIntoGroups(_personList, numberOfGroups, maxGroupSize);

            DisplayGroupsForm displayGroupsForm = new DisplayGroupsForm(groups);
            displayGroupsForm.ShowDialog();
        }

        /// <summary>
        /// Executes the splitIntoGroupsButton_Click method on clicking "Enter" in the numberOfGroupsBox
        /// </summary>
        /// <param name="sender">TextBox that was typed in</param>
        /// <param name="e">Additional event arguments</param>
        private void numberOfGroupsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                splitIntoGroupsButton_Click(this, new EventArgs());
        }

        /// <summary>
        /// Opens the ImportForm to modify the personList
        /// </summary>
        /// <remarks>
        /// Opened at the start for initial import
        /// </remarks>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void editListButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this._personList);
            // Attention, there is an error in the book about this (p. 634)!
            // Modeless forms are displayed with the Show() function. 
            // However, we want a modal form:
            importForm.ShowDialog();
        }

        /// <summary>
        /// Reads number from textBox and returns it
        /// </summary>
        /// <remarks>
        /// Displays an error message in a MessageBox and returns 0 if invalid number was read
        /// </remarks>
        /// <param name="textBox">textBox to read number from</param>
        /// <returns>entered integer, 0 if error</returns>
        private static int getNumberFrom(TextBox textBox)
        {
            int number;
            try
            {
                number = int.Parse(textBox.Text);
                if (number <= 0)
                    throw new ArgumentOutOfRangeException();
            }
            catch (SystemException)
            {
                MessageBox.Show("Please enter valid numbers only!");
                number = 0;
            }
            return number;
        }

        /// <summary>
        /// Splits the given collection of people into numberOfGroups groups with a max size of maxSizeOfGroups
        /// </summary>
        /// <param name="people">List of people to be split into groups</param>
        /// <param name="numberOfGroups">Number of groups to be created</param>
        /// <param name="maxGroupSize">Maximum size of groups</param>
        /// <returns>Person Array containing the groups</returns>
        /// <exception cref="ArgumentException">If the numberOfGroups or maxGroupSize do not make sense</exception>
        private static Person[,] splitIntoGroups(Collection<Person> people, int numberOfGroups, int maxGroupSize)
        {
            if (numberOfGroups <= 0 && maxGroupSize <= 0)
                throw new ArgumentException("Negative list size not possible!");
            if (numberOfGroups * maxGroupSize <= people.Count)
                throw new ArgumentException("Lists not long enough for people collection!");

            Person[,] groups = new Person[numberOfGroups, maxGroupSize];
            // Go through people in group
            for (int personNr = 0; personNr < maxGroupSize; personNr++)
            {
                // Go through groups
                for (int groupNr = 0; groupNr < numberOfGroups; groupNr++)
                {
                    if (groupNr + personNr * numberOfGroups < people.Count)
                    {
                        groups[groupNr, personNr] = people[groupNr + personNr * numberOfGroups];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return groups;
        }
    }
}