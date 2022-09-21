using System.Reflection;

namespace GroupGenerator
{
    partial class GroupsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.groupsOfLabel = new System.Windows.Forms.Label();
            this.groupSizeBox = new System.Windows.Forms.TextBox();
            this.numberOfGroupsLabel = new System.Windows.Forms.Label();
            this.numberOfGroupsBox = new System.Windows.Forms.TextBox();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.splitIntoGroupsOfButton = new System.Windows.Forms.Button();
            this.splitIntoGroupsButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.editListButton = new System.Windows.Forms.Button();
            this.pickOneButton = new System.Windows.Forms.Button();
            this.loadExampleListButton = new System.Windows.Forms.Button();
            this.formatGroupBox = new System.Windows.Forms.GroupBox();
            this.firstLastRadioButton = new System.Windows.Forms.RadioButton();
            this.firstLRadioButton = new System.Windows.Forms.RadioButton();
            this.LastFirstIDRadioButton = new System.Windows.Forms.RadioButton();
            this.formatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 20;
            this.groupsListBox.Location = new System.Drawing.Point(14, 16);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(287, 564);
            this.groupsListBox.TabIndex = 0;
            // 
            // groupsOfLabel
            // 
            this.groupsOfLabel.AutoSize = true;
            this.groupsOfLabel.Location = new System.Drawing.Point(312, 161);
            this.groupsOfLabel.Name = "groupsOfLabel";
            this.groupsOfLabel.Size = new System.Drawing.Size(137, 20);
            this.groupsOfLabel.TabIndex = 1;
            this.groupsOfLabel.Text = "Split into groups of";
            // 
            // groupSizeBox
            // 
            this.groupSizeBox.Location = new System.Drawing.Point(442, 157);
            this.groupSizeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupSizeBox.Name = "groupSizeBox";
            this.groupSizeBox.Size = new System.Drawing.Size(57, 27);
            this.groupSizeBox.TabIndex = 2;
            this.groupSizeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GroupSizeBox_KeyDown);
            // 
            // numberOfGroupsLabel
            // 
            this.numberOfGroupsLabel.AutoSize = true;
            this.numberOfGroupsLabel.Location = new System.Drawing.Point(312, 239);
            this.numberOfGroupsLabel.Name = "numberOfGroupsLabel";
            this.numberOfGroupsLabel.Size = new System.Drawing.Size(69, 20);
            this.numberOfGroupsLabel.TabIndex = 3;
            this.numberOfGroupsLabel.Text = "Split into";
            // 
            // numberOfGroupsBox
            // 
            this.numberOfGroupsBox.Location = new System.Drawing.Point(378, 235);
            this.numberOfGroupsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberOfGroupsBox.Name = "numberOfGroupsBox";
            this.numberOfGroupsBox.Size = new System.Drawing.Size(57, 27);
            this.numberOfGroupsBox.TabIndex = 4;
            this.numberOfGroupsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberOfGroupsBox_KeyDown);
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Location = new System.Drawing.Point(442, 239);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(55, 20);
            this.groupsLabel.TabIndex = 5;
            this.groupsLabel.Text = "groups";
            // 
            // splitIntoGroupsOfButton
            // 
            this.splitIntoGroupsOfButton.Location = new System.Drawing.Point(312, 196);
            this.splitIntoGroupsOfButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitIntoGroupsOfButton.Name = "splitIntoGroupsOfButton";
            this.splitIntoGroupsOfButton.Size = new System.Drawing.Size(187, 31);
            this.splitIntoGroupsOfButton.TabIndex = 6;
            this.splitIntoGroupsOfButton.Text = "Split";
            this.splitIntoGroupsOfButton.UseVisualStyleBackColor = true;
            this.splitIntoGroupsOfButton.Click += new System.EventHandler(this.SplitIntoGroupsOfButton_Click);
            // 
            // splitIntoGroupsButton
            // 
            this.splitIntoGroupsButton.Location = new System.Drawing.Point(312, 273);
            this.splitIntoGroupsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitIntoGroupsButton.Name = "splitIntoGroupsButton";
            this.splitIntoGroupsButton.Size = new System.Drawing.Size(187, 31);
            this.splitIntoGroupsButton.TabIndex = 7;
            this.splitIntoGroupsButton.Text = "Split";
            this.splitIntoGroupsButton.UseVisualStyleBackColor = true;
            this.splitIntoGroupsButton.Click += new System.EventHandler(this.SplitIntoGroupsButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(312, 55);
            this.shuffleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(187, 31);
            this.shuffleButton.TabIndex = 8;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // editListButton
            // 
            this.editListButton.Location = new System.Drawing.Point(312, 16);
            this.editListButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(187, 31);
            this.editListButton.TabIndex = 9;
            this.editListButton.Text = "Edit List";
            this.editListButton.UseVisualStyleBackColor = true;
            this.editListButton.Click += new System.EventHandler(this.EditListButton_Click);
            // 
            // pickOneButton
            // 
            this.pickOneButton.Location = new System.Drawing.Point(312, 492);
            this.pickOneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pickOneButton.Name = "pickOneButton";
            this.pickOneButton.Size = new System.Drawing.Size(187, 31);
            this.pickOneButton.TabIndex = 10;
            this.pickOneButton.Text = "Pick One Randomly";
            this.pickOneButton.UseVisualStyleBackColor = true;
            this.pickOneButton.Click += new System.EventHandler(this.PickOneButton_Click);
            // 
            // loadExampleListButton
            // 
            this.loadExampleListButton.Location = new System.Drawing.Point(312, 551);
            this.loadExampleListButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadExampleListButton.Name = "loadExampleListButton";
            this.loadExampleListButton.Size = new System.Drawing.Size(187, 31);
            this.loadExampleListButton.TabIndex = 11;
            this.loadExampleListButton.Text = "Load Example List";
            this.loadExampleListButton.UseVisualStyleBackColor = true;
            this.loadExampleListButton.Click += new System.EventHandler(this.LoadExampleListButton_Click);
            // 
            // formatGroupBox
            // 
            this.formatGroupBox.Controls.Add(this.LastFirstIDRadioButton);
            this.formatGroupBox.Controls.Add(this.firstLRadioButton);
            this.formatGroupBox.Controls.Add(this.firstLastRadioButton);
            this.formatGroupBox.Location = new System.Drawing.Point(312, 339);
            this.formatGroupBox.Name = "formatGroupBox";
            this.formatGroupBox.Size = new System.Drawing.Size(187, 120);
            this.formatGroupBox.TabIndex = 12;
            this.formatGroupBox.TabStop = false;
            this.formatGroupBox.Text = "Choose a format";
            // 
            // firstLastRadioButton
            // 
            this.firstLastRadioButton.AutoSize = true;
            this.firstLastRadioButton.Location = new System.Drawing.Point(6, 26);
            this.firstLastRadioButton.Name = "firstLastRadioButton";
            this.firstLastRadioButton.Size = new System.Drawing.Size(87, 24);
            this.firstLastRadioButton.TabIndex = 0;
            this.firstLastRadioButton.TabStop = true;
            this.firstLastRadioButton.Text = "First Last";
            this.firstLastRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstLRadioButton
            // 
            this.firstLRadioButton.AutoSize = true;
            this.firstLRadioButton.Location = new System.Drawing.Point(6, 56);
            this.firstLRadioButton.Name = "firstLRadioButton";
            this.firstLRadioButton.Size = new System.Drawing.Size(71, 24);
            this.firstLRadioButton.TabIndex = 1;
            this.firstLRadioButton.TabStop = true;
            this.firstLRadioButton.Text = "First L.";
            this.firstLRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastFirstIDRadioButton
            // 
            this.LastFirstIDRadioButton.AutoSize = true;
            this.LastFirstIDRadioButton.Location = new System.Drawing.Point(6, 86);
            this.LastFirstIDRadioButton.Name = "LastFirstIDRadioButton";
            this.LastFirstIDRadioButton.Size = new System.Drawing.Size(109, 24);
            this.LastFirstIDRadioButton.TabIndex = 2;
            this.LastFirstIDRadioButton.TabStop = true;
            this.LastFirstIDRadioButton.Text = "Last, First ID";
            this.LastFirstIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 600);
            this.Controls.Add(this.formatGroupBox);
            this.Controls.Add(this.loadExampleListButton);
            this.Controls.Add(this.pickOneButton);
            this.Controls.Add(this.editListButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.splitIntoGroupsButton);
            this.Controls.Add(this.splitIntoGroupsOfButton);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.numberOfGroupsBox);
            this.Controls.Add(this.numberOfGroupsLabel);
            this.Controls.Add(this.groupSizeBox);
            this.Controls.Add(this.groupsOfLabel);
            this.Controls.Add(this.groupsListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GroupsForm";
            this.Text = "Group Generator";
            this.formatGroupBox.ResumeLayout(false);
            this.formatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox groupsListBox;
        private Label groupsOfLabel;
        private TextBox groupSizeBox;
        private Label numberOfGroupsLabel;
        private TextBox numberOfGroupsBox;
        private Label groupsLabel;
        private Button splitIntoGroupsOfButton;
        private Button splitIntoGroupsButton;
        private Button shuffleButton;
        private Button editListButton;
        private Button pickOneButton;
        private Button loadExampleListButton;
        private GroupBox formatGroupBox;
        private RadioButton LastFirstIDRadioButton;
        private RadioButton firstLRadioButton;
        private RadioButton firstLastRadioButton;
    }
}