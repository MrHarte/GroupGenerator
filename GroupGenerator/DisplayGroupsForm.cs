namespace GroupGenerator
{
    /// <summary>
    /// Form to display groups given in a 2D array.
    /// </summary>
    public partial class DisplayGroupsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayGroupsForm"/> class.
        /// Constructor of the form displaying the groups in the listBox.
        /// </summary>
        /// <param name="groups">Groups to be displayed in a 2D array.</param>
       
        public DisplayGroupsForm(Person[,] groups)
        {
            this.InitializeComponent();
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                this.groupsListBox.Items.Add("Group " + (i + 1).ToString() + ":");
                for (int j = 0; j < groups.GetLength(1); j++)
                {
                    if (groups[i, j] != null)
                    {
                        this.groupsListBox.Items.Add(groups[i, j].ToString());
                    }
                }

                this.groupsListBox.Items.Add(string.Empty);
            }

            this.closeButton.Select();
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
