using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupGenerator
{
    public partial class ImportForm : Form
    {
        BindingList<Person> personList;

        public ImportForm(BindingList<Person> personList)
        {
            InitializeComponent();
            this.personList = personList;

            // Add existing list to the text box on separate lines
            importBox.Text = "";
            for (int i = 0; i < personList.Count; i++)
            {
                importBox.Text += personList[i].ToString();
                if (i < personList.Count - 1)
                {
                    importBox.Text += Environment.NewLine;
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            // Clear list and import from text box
            personList.Clear();
            foreach (string personString in importBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                personList.Add(new Person(personString));
            }

            this.Close();
        }
    }
}
