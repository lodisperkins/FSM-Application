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
        public int x = 20;
        public int y = 10;
        public Createstate createstate_Window = new Createstate();
        public List<State> states = new List<State>();
      
        public Modify()
        {
            InitializeComponent();
            createstate_Window.Controls[1].Click += renameState;
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void panel_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
            else
            {
                return;
            }
        }
        private void renameState(object sender,EventArgs e)
        {

        }
        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (y < 370)
            {
                Panel panel = new Panel();
                panel.Size = new Size(200, 55);
                panel.Location = new Point(x, y);
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.MouseDown += panel_RightClick;
                TextBox stateName = new TextBox();
                stateName.Text = "State" + states.Count;
                stateName.BorderStyle = BorderStyle.None;
                stateName.Size = panel.Size;
                stateName.Font = new Font(stateName.Font.FontFamily, 18, stateName.Font.Style, stateName.Font.Unit);
                stateName.Location = new Point(50, 10);
                State state = new State();
                states.Add(state);
                panel.Controls.Add(stateName);
                statepanel.Controls.Add(panel);

                createstate_Window.Hide();
                y += 60;
            }
            else
            {
                return;
            }
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
        private bool isthere()
        {

        }
        private void setTransitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            states.FindIndex();
            createstate_Window.Show();
        }
    }
}
