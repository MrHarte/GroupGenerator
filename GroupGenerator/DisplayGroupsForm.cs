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
    public partial class DisplayGroupsForm : Form
    {
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
            
        }
    }
}
