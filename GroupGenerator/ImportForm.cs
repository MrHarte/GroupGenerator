namespace GroupGenerator
{
    using System.ComponentModel;

    /// <summary>
    /// Import form class to edit or import a list of people.
    /// </summary>
    public partial class ImportForm : Form
    {
        /// <summary>
        /// List of people when the form was instantiated.
        /// </summary>
        private BindingList<Person> personList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportForm"/> class.
        /// Constructor of the form adding the list of people to the textBox.
        /// </summary>
        /// <param name="personList">Existing list of people.</param>
        public ImportForm(BindingList<Person> personList)
        {
            this.InitializeComponent();
            this.personList = personList;

            // Add existing list to the text box on separate lines
            this.importBox.Text = string.Empty;
            for (int i = 0; i < personList.Count; i++)
            {
                this.importBox.Text += personList[i].ToString();
                if (i < personList.Count - 1)
                {
                    this.importBox.Text += Environment.NewLine;
                }
            }
        }

        /// <summary>
        /// Clears the personList, adds the people from the textBox and closes the form.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void ImportButton_Click(object sender, EventArgs e)
        {
            this.personList.Clear();
            foreach (string personString in this.importBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                this.personList.Add(new Student(personString));
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        /// <summary>
        /// Closes the form without saving the textBox contents.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
