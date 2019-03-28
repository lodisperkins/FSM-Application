using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
