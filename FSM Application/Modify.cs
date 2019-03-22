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
    public partial class Modify : Form
    {
        public int x = 23;
        public int y = 27;
        Createstate createstate_Window = new Createstate();
        
        public Modify()
        {
            InitializeComponent();
            Controls[0].Hide();
            createstate_Window.Controls[1].Click += createButton;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void createButton (object sender, EventArgs e)
        {
            Button state = new Button();
            state.Size = Controls[0].Size;
            state.Location = new Point(x, y);
            state.Text = createstate_Window.Controls[2].Text;
            Controls.Add(state);
            createstate_Window.Hide();
            y += y;
        }
        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createstate_Window.Show();
        }
    }
}
