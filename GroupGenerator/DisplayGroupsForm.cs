using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupGenerator
{
    /// <summary>
    /// Form to display groups given in a 2D array
    /// </summary>
    public partial class DisplayGroupsForm : Form
    {
        /// <summary>
        /// Constructor of the form displaying the groups in the listBox
        /// </summary>
        /// <param name="groups">Groups to be displayed in a 2D array</param>
        public DisplayGroupsForm(Person[,] groups)
        {
            InitializeComponent();
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                groupsListBox.Items.Add("Group " + (i+1).ToString() + ":");
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    if (groups[i, j] != null)
                    {
                        groupsListBox.Items.Add(groups[i, j].ToString());
                    }
                }
                groupsListBox.Items.Add("");
            }
            closeButton.Select();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Additional event arguments</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
