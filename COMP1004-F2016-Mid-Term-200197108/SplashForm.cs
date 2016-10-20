using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200197108
{
    public partial class SplashForm : Form
    {
        private bool isClosed = false;

        public SplashForm()
        {
            InitializeComponent();
            this.SplashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            Timer tim = sender as Timer;
            tim.Stop();
            this.Hide();
            GenerateNameForm generateNameForm = new GenerateNameForm();
            isClosed = true;
            generateNameForm.previousForm = this;
            generateNameForm.Show();
        }
    }
}
