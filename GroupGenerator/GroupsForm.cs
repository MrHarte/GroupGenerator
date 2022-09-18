using ExtensionMethods;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GroupGenerator
{
    public partial class GroupsForm : Form
    {
        private BindingList<Person> _personList;

        private Random _rng;

        public GroupsForm()
        {
            InitializeComponent();
            this._personList = new BindingList<Person>();
            groupsListBox.DataSource = this._personList;
            groupsListBox.DisplayMember = "Name";
            _rng = new Random();
            this.editListButton_Click(this, new EventArgs());
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            _personList.Shuffle();
        }

        private void pickOneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(20 * i);
                groupsListBox.SetSelected(_rng.Next(_personList.Count), true);
            }
        }

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

        private void splitIntoGroupsOfButton_Click(object sender, EventArgs e)
        {
            int maxGroupSize = getNumberFrom(groupSizeBox);
            if (maxGroupSize == 0)
                return;

            _personList.Shuffle();

            int numberOfGroups = _personList.Count / maxGroupSize;
            if (_personList.Count % maxGroupSize != 0)
                numberOfGroups++;

            Person[,] groups = splitIntoGroups(_personList, numberOfGroups, maxGroupSize);

            DisplayGroupsForm displayGroupsForm = new DisplayGroupsForm(groups);
            displayGroupsForm.ShowDialog();
        }

        private void groupSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                splitIntoGroupsOfButton_Click(this, new EventArgs());
        }

        private void splitIntoGroupsButton_Click(object sender, EventArgs e)
        {
            int numberOfGroups = this.getNumberFrom(numberOfGroupsBox);
            if (numberOfGroups == 0)
                return;

            _personList.Shuffle();

            int maxGroupSize = _personList.Count / numberOfGroups;
            if (_personList.Count % numberOfGroups != 0)
            {
                maxGroupSize++;
            }

            Person[,] groups = splitIntoGroups(_personList, numberOfGroups, maxGroupSize);

            DisplayGroupsForm displayGroupsForm = new DisplayGroupsForm(groups);
            displayGroupsForm.ShowDialog();
        }

        private void numberOfGroupsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                splitIntoGroupsButton_Click(this, new EventArgs());
        }

        private void editListButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this._personList);
            // Attention, there is an error in the book about this (p. 634)!
            // Modeless forms are displayed with the Show() function. 
            // However, we want a modal form:
            importForm.ShowDialog();
        }

        private int getNumberFrom(TextBox textBox)
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

        private Person[,] splitIntoGroups(Collection<Person> persons, int numberOfGroups, int maxGroupSize)
        {
            Person[,] groups = new Person[numberOfGroups, maxGroupSize];
            // Go through persons in group
            for (int personNr = 0; personNr < maxGroupSize; personNr++)
            {
                // Go through groups
                for (int groupNr = 0; groupNr < numberOfGroups; groupNr++)
                {
                    if (groupNr + personNr * numberOfGroups < persons.Count)
                    {
                        groups[groupNr, personNr] = persons[groupNr + personNr * numberOfGroups];
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