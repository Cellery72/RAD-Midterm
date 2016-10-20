/*
 *       Author: Justin Ellery
 *         Date: 2016-10-20
 *  Description: This is the final form to display output of Character
 */
using System;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200197108
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Intelligence;
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            RaceTextBox.Text = Program.character.Race;

            switch (Program.character.Race)
            {
                case "Human":
                    CharacterPictureBox.BackgroundImage = Properties.Resources.Human_Male;
                    break;
                case "Elf":
                    CharacterPictureBox.BackgroundImage = Properties.Resources.Elf_Male;
                    break;
                case "Dwarf":
                    CharacterPictureBox.BackgroundImage = Properties.Resources.Dwarf_Male;
                    break;
                case "Halfling":
                    CharacterPictureBox.BackgroundImage = Properties.Resources.Halfling_Male;
                    break;
                default:
                    return;
            }
        }
    }
}
