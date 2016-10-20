/*
 *       Author: Justin Ellery
 *         Date: 2016-10-20
 *  Description: This is the form used to generate names.
 */
using System;
using System.Windows.Forms;


namespace COMP1004_F2016_Mid_Term_200197108
{
    public partial class GenerateNameForm : Form
    {
        public SplashForm previousForm;
        public GenerateNameForm()
        {
            InitializeComponent();  
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateNames()
        {
            // get random values
            int firstRandom = Utility.RollValue(FirstNameListBox.Items.Count);
            int secondRandom = Utility.RollValue(LastNameListBox.Items.Count);

            // change the value of the list box's
            FirstNameListBox.SelectedIndex = firstRandom;
            LastNameListBox.SelectedIndex = secondRandom;
        }

        private void ListBoxSelectedIndexChange(object sender, EventArgs e)
        {
            // get instance of sender
            ListBox lb = sender as ListBox;

            switch (lb.Name)
            {
                case "FirstNameListBox":
                    FirstNameTextBox.Text = lb.SelectedItem.ToString();
                    Program.character.FirstName = FirstNameTextBox.Text;
                    break;
                case "LastNameListBox":
                    LastNameTextBox.Text = lb.SelectedItem.ToString();
                    Program.character.LastName = LastNameTextBox.Text;
                    break;
            }

        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            AbilityGeneratorForm abilityForm = new AbilityGeneratorForm();
            abilityForm.previousForm = this;

            abilityForm.Show();
            this.Hide();
        }
    }
}
