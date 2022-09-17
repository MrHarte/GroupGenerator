using ExtensionMethods;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupGenerator
{
    public partial class GroupsForm : Form
    {
        public BindingList<Person> personList;

        public GroupsForm()
        {
            InitializeComponent();
            this.personList = new BindingList<Person>();
            groupsListBox.DataSource = this.personList;
            groupsListBox.DisplayMember = "Name";
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            personList.Shuffle();
        }

        private void pickOneButton_Click(object sender, EventArgs e)
        {

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
    }
}