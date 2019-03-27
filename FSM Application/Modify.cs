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
        public List<State> states = new List<State>();
        public List<Panel> statePanels = new List<Panel>();
        Panel StateClicked;
        public Modify()
        {
            InitializeComponent();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void panel_RightClick(object sender,MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                contextMenuStrip1.Show(sender as Control,new Point(e.X,e.Y));
                StateClicked = sender as Panel;
            }
            else
            {
                return;
            }
        }
        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (y < 370)
            {
                Panel panel = new Panel();
                panel.Size = new Size(234, 55);
                panel.Location = new Point(x, y);
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.White;
                panel.MouseDown += new MouseEventHandler(panel_RightClick);

                Label stateName = new Label();
                stateName.Text = "State" + statepanel.Controls.Count;
                stateName.Font = new Font(stateName.Font.FontFamily, 18, stateName.Font.Style, stateName.Font.Unit);
                stateName.Location = new Point(70, 10);
                stateName.MouseDown += new MouseEventHandler(panel_RightClick);

                State state = new State();
                state.Name = stateName.Text;

                states.Add(state);
                panel.Controls.Add(stateName);
                statepanel.Controls.Add(panel);
                statePanels.Add(panel);

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
        private void removeState(int index)
        {
            if(statePanels.Count==1)
            {
                statePanels[index].Dispose();
                statePanels.RemoveAt(index);
                states.RemoveAt(index);
                y -= 60;
            }
            else if (index + 1 == statePanels.Count)
            {
                statePanels[index].Dispose();
                statePanels.RemoveAt(index);
                states.RemoveAt(index);
                y -= 60;
            }
            else
            {
                for (int i = index; i < statePanels.Count-1; i++)
                {
                    statePanels[i].Controls[0].Text = statePanels[i + 1].Controls[0].Text;
                }
                statePanels[statePanels.Count-1].Dispose();
                statePanels.RemoveAt(index);
                states.RemoveAt(index);
                y -= 60;
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StateClicked == null)
            {
                return;
            }
            else
            {
                int index = statePanels.IndexOf(StateClicked);
                removeState(index);
            }
        }
    }
}
