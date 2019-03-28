using System;
using System.Windows.Forms;

namespace FSM_Application
{
    public partial class warning : Form
    {
        public warning()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            
        }
        //Hides window if clicked
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
