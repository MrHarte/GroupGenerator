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
    /// <summary>
    /// Import form class to edit or import a list of people
    /// </summary>
    public partial class ImportForm : Form
    {
        /// <summary>
        /// List of people when the form was instantiated
        /// </summary>
        BindingList<Person> personList;

        /// <summary>
        /// Constructor of the form adding the list of people to the textBox
        /// </summary>
        /// <param name="personList">Existing list of people</param>
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
                    importBox.Text += Environment.NewLine;
            }
        }

        /// <summary>
        /// Clears the personList, adds the people from the textBox and closes the form
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void importButton_Click(object sender, EventArgs e)
        {
            this.personList.Clear();
            foreach (string personString in importBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                this.personList.Add(new Person(personString));
            }

            this.Close();
        }

        /// <summary>
        /// Closes the form without saving the textBox contents
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
