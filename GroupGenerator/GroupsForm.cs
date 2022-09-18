using ExtensionMethods;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupGenerator
{
    public partial class GroupsForm : Form
    {
        private BindingList<Person> personList;

        private Random rng;

        public GroupsForm()
        {
            InitializeComponent();
            this.personList = new BindingList<Person>();
            groupsListBox.DataSource = this.personList;
            groupsListBox.DisplayMember = "Name";
            rng = new Random();
            // TODO remove next line
            this.loadExampleListButton_Click(this, new EventArgs());
            // and add the next
            // this.editListButton_Click(this, new EventArgs());
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            personList.Shuffle();
        }

        private void pickOneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(20*i);
                groupsListBox.SetSelected(rng.Next(personList.Count), true);
            }
        }

        private void loadExampleListButton_Click(object sender, EventArgs e)
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

        private void splitIntoGroupsOfButton_Click(object sender, EventArgs e)
        {
            int groupSize;
            try
            {
                groupSize = int.Parse(groupSizeBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numbers only!");
                return;
            }

            personList.Shuffle();
        }

        private void groupSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                splitIntoGroupsOfButton_Click(this, new EventArgs());
            }
        }

        private void splitIntoGroupsButton_Click(object sender, EventArgs e)
        {
            int numberOfGroups;
            try
            {
                numberOfGroups = int.Parse(numberOfGroupsBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numbers only!");
                return;
            }

            personList.Shuffle();
        }

        private void numberOfGroupsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                splitIntoGroupsButton_Click(this, new EventArgs());
            }
        }

        private void editListButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this.personList);
            // Attention, there is an error in the book about this (p. 634)!
            // Modeless forms are displayed with the Show() function. 
            // However, we want a modal form:
            importForm.ShowDialog();
        }
    }
}