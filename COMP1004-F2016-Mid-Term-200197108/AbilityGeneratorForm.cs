using System;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200197108
{
    public partial class AbilityGeneratorForm : Form
    {

        public GenerateNameForm previousForm;

        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Generate abilities based on random roll from utility
        /// </summary>
        private void GenerateAbilities()
        {
            StrengthTextBox.Text = Utility.Roll().ToString();
            DexterityTextBox.Text = Utility.Roll().ToString();
            ConstitutionTextBox.Text = Utility.Roll().ToString();
            IntelligenceTextBox.Text = Utility.Roll().ToString();
            WisdomTextBox.Text = Utility.Roll().ToString();
            CharismaTextBox.Text = Utility.Roll().ToString();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            GenerateAbilities();

        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = StrengthTextBox.Text;
            character.Dexterity = DexterityTextBox.Text;
            character.Constitution = ConstitutionTextBox.Text;
            character.Intelligence = IntelligenceTextBox.Text;
            character.Wisdom = WisdomTextBox.Text;
            character.Charisma = CharismaTextBox.Text;

            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }
    }
}
