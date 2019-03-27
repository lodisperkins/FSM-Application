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
        public List<Statepanel> statePanels = new List<Statepanel>();
        
        Statepanel StateClicked;
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
                StateClicked = sender as Statepanel;
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
                Statepanel panel = new Statepanel();
                panel.MouseDown += new MouseEventHandler(panel_RightClick);
                panel.Location = new Point(x, y);
                panel.name = "New State";
                State state = new State();
                state.Name = panel.name;

                states.Add(state);
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
            for (int i = 0; i < statePanels.Count;i ++)
            {
                states[i].Name = statePanels[i].name;
            }
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
                    statePanels[i].name = statePanels[i + 1].name;
                }
                statePanels[statePanels.Count-1].Dispose();
                statePanels.RemoveAt(statePanels.Count - 1);
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
