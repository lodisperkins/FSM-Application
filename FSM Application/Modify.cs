using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FSM_Application
{
    public partial class Modify : Form
    {
        //Location of each statepanel added
        public int x = 0;
        public int y = 10;
        //Stores a list of the states added
        public List<State> states = new List<State>();
        //List of the custom controls
        public List<Statepanel> statePanels = new List<Statepanel>();
        
        Statepanel StateClicked;
        public Modify()
        {
            InitializeComponent();
            FormClosing +=hideWindow;
        }
        //Hides the window instead of closing if the close button is pressed
        private void hideWindow(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        //Adds a right click menu to each of the custom controls
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
        //Loads the states from a previous session into the list of states
        public void loadStates(List<State> value)
        {
            for  (int i = 0; i < value.Count;i++)
            {
                //Checks the position of the last control added to see if the maximum number of controls has been reached
                if (y < 370)
                {
                    Statepanel panel = new Statepanel();
                    panel.MouseDown += new MouseEventHandler(panel_RightClick);
                    panel.Location = new Point(x, y);
                    panel.name = value[i].Name;
                    State state = new State();
                    state.Name = panel.name;

                    states.Add(state);
                    statePanelList.Controls.Add(panel);
                    statePanels.Add(panel);

                    y += 60;
                }
                else
                {
                    return;
                }
            }
        }
        //Creates a new state and a new custom control to represent that state
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
                statePanelList.Controls.Add(panel);
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
        //Updates the names of the states in the state list to the names of the custom controls and hides the window
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < statePanels.Count;i ++)
            {
                states[i].Name = statePanels[i].name;
            }
            Hide();
        }
        //Removes a state and a custom control from their respective lists
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
        //Calls the remove state function if clicked
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
