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
            this.layoutGroupBox = new System.Windows.Forms.GroupBox();
            this.layout3RadioButton = new System.Windows.Forms.RadioButton();
            this.layout2RadioButton = new System.Windows.Forms.RadioButton();
            this.layout1RadioButton = new System.Windows.Forms.RadioButton();
            this.layoutGroupBox.SuspendLayout();
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
            // layoutGroupBox
            // 
            this.layoutGroupBox.Controls.Add(this.layout3RadioButton);
            this.layoutGroupBox.Controls.Add(this.layout2RadioButton);
            this.layoutGroupBox.Controls.Add(this.layout1RadioButton);
            this.layoutGroupBox.Location = new System.Drawing.Point(312, 311);
            this.layoutGroupBox.Name = "layoutGroupBox";
            this.layoutGroupBox.Size = new System.Drawing.Size(190, 157);
            this.layoutGroupBox.TabIndex = 12;
            this.layoutGroupBox.TabStop = false;
            this.layoutGroupBox.Text = "Layout Options";
            // 
            // layout3RadioButton
            // 
            this.layout3RadioButton.AutoSize = true;
            this.layout3RadioButton.Location = new System.Drawing.Point(10, 86);
            this.layout3RadioButton.Name = "layout3RadioButton";
            this.layout3RadioButton.Size = new System.Drawing.Size(122, 24);
            this.layout3RadioButton.TabIndex = 2;
            this.layout3RadioButton.TabStop = true;
            this.layout3RadioButton.Text = "First, Last, (ID)";
            this.layout3RadioButton.UseVisualStyleBackColor = true;
            this.layout3RadioButton.CheckedChanged += new System.EventHandler(this.layout3RadioButton_CheckedChanged);
            // 
            // layout2RadioButton
            // 
            this.layout2RadioButton.AutoSize = true;
            this.layout2RadioButton.Location = new System.Drawing.Point(10, 56);
            this.layout2RadioButton.Name = "layout2RadioButton";
            this.layout2RadioButton.Size = new System.Drawing.Size(178, 24);
            this.layout2RadioButton.TabIndex = 1;
            this.layout2RadioButton.TabStop = true;
            this.layout2RadioButton.Text = "First Name, Last Name";
            this.layout2RadioButton.UseVisualStyleBackColor = true;
            this.layout2RadioButton.CheckedChanged += new System.EventHandler(this.layout2RadioButton_CheckedChanged);
            // 
            // layout1RadioButton
            // 
            this.layout1RadioButton.AutoSize = true;
            this.layout1RadioButton.Location = new System.Drawing.Point(10, 26);
            this.layout1RadioButton.Name = "layout1RadioButton";
            this.layout1RadioButton.Size = new System.Drawing.Size(145, 24);
            this.layout1RadioButton.TabIndex = 0;
            this.layout1RadioButton.TabStop = true;
            this.layout1RadioButton.Text = "First Name, Initial";
            this.layout1RadioButton.UseVisualStyleBackColor = true;
            this.layout1RadioButton.CheckedChanged += new System.EventHandler(this.layout1RadioButton_CheckedChanged);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 600);
            this.Controls.Add(this.layoutGroupBox);
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
            this.layoutGroupBox.ResumeLayout(false);
            this.layoutGroupBox.PerformLayout();
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
        private GroupBox layoutGroupBox;
        private RadioButton layout3RadioButton;
        private RadioButton layout2RadioButton;
        private RadioButton layout1RadioButton;
    }
}