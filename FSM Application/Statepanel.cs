using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSM_Application
{
    public partial class Statepanel : UserControl
    {
        public Statepanel()
        {
            InitializeComponent();
        }
        public Statepanel(string value)
        {
            InitializeComponent();
            statename.Text = value;
        }
        
        public string name
        {
            get
            {
                return statename.Text;
            }
            set
            {
                statename.Text = value;
            }
        }
            

    }
}
