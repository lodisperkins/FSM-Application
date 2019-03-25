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
        public int x = 0;
        public int y = 10;
        public Createstate createstate_Window = new Createstate();
        
        public Modify()
        {
            InitializeComponent();
            createstate_Window.Controls[1].Click += createButton;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    
        private void createButton (object sender, EventArgs e)
        {
            Panel state = new Panel();
            state.Size = new Size(234, 55);
            state.Location = new Point(x, y);
            state.BorderStyle = BorderStyle.Fixed3D;
            state.BackColor = Color.White;

            Label stateName = new Label();
            stateName.Text = createstate_Window.Controls[2].Text;
            
            stateName.Font= new Font(stateName.Font.FontFamily,18,stateName.Font.Style,stateName.Font.Unit);
            stateName.Location = new Point(70, 10);
            state.Controls.Add(stateName);
            statepanel.Controls.Add(state);

            createstate_Window.Hide();
            y += 60;
        }
        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            createstate_Window.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
