using System;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200197108
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;



        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;
            bool isChecked = selectedRace.Checked;
            if (isChecked)
            {
                Program.character.Race = selectedRace.Text;
                HandleCheckedChanged(selectedRace.Text);
                this._selectedRace = selectedRace.Text;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            _selectedRace = Program.character.Race;
            if(_selectedRace==null)
            {
                _selectedRace = "Human";
            }
            HandleCheckedChanged(_selectedRace);
        }

        private void HandleCheckedChanged(string selectedRace)
        {
            switch (selectedRace)
            {
                case "Human":
                    if(!HumanRadioButton.Checked)
                        HumanRadioButton.Checked = true;
                    ImagePictureBox.BackgroundImage = Properties.Resources.Human_Male;
                    break;
                case "Elf":
                    if (!ElfRadioButton.Checked)
                        ElfRadioButton.Checked = true;
                    ImagePictureBox.BackgroundImage = Properties.Resources.Elf_Male;
                    break;
                case "Dwarf":
                    if (!DwarfRadioButton.Checked)
                        DwarfRadioButton.Checked = true;
                    ImagePictureBox.BackgroundImage = Properties.Resources.Dwarf_Male;
                    break;
                case "Halfling":
                    if (!HalflingRadioButton.Checked)
                        HalflingRadioButton.Checked = true;
                    ImagePictureBox.BackgroundImage = Properties.Resources.Halfling_Male;
                    break;
                default:
                    return;
            }
        }

      
    }
}
