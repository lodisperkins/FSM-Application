using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSM_Application
{
    public partial class Form1 : Form
    {
        List<ComboBox> boxes;
        List<State> states;
        
        public ComboBox current_Drop = new ComboBox();
        public ComboBox transition_Drop = new ComboBox();
        public ComboBox condition_Drop = new ComboBox();

        public Point Point = new Point();

        public int x = 10;
        public int y = new int();

        public string state_Text = "Enter State Name...";
        public string cond_Text = "Enter Condition...";
        public Form1()
        {
            boxes = new List<ComboBox>();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //checks if there are any boxes left in the list by checking the position of the y value
            if (y < 30)
            {
                y = new int();
                return;
            }
            //if there are any boxes in the list it removes them
            else
            {
                y -= x * 3;

                currentStateBox.Controls.Remove(boxes[boxes.Count - 3]);
                transitionBox.Controls.Remove(boxes[boxes.Count - 2]);
                conditionsBox.Controls.Remove(boxes[boxes.Count - 1]);

                boxes.Remove(boxes[boxes.Count - 3]);
                boxes.Remove(boxes[boxes.Count - 2]);
                boxes.Remove(boxes[boxes.Count - 1]);
            }

        }
        private void createState(object sender, EventArgs e)
        {
            State state = new State();
            state.Name = current_Drop.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void addStateButton_Click(object sender, EventArgs e)
        {
            //adds a new row of boxes after checking if there's room on the table
            if (y > 150)
            {
                return;
            }
            else
            {
                y += x * 3;

                current_Drop = new ComboBox();
                transition_Drop = new ComboBox();
                condition_Drop = new ComboBox();
 
                boxes.Add(current_Drop);
                boxes.Add(transition_Drop);
                boxes.Add(condition_Drop);

                current_Drop.Location = new Point(x, y);
                transition_Drop.Location = new Point(x, y);
                condition_Drop.Location = new Point(x, y);
                
                current_Drop.Text = state_Text;
                transition_Drop.Text = state_Text;
                condition_Drop.Text = cond_Text;
                current_Drop.TextChanged += createState;
                currentStateBox.Controls.Add(boxes[boxes.Count-3]);
                transitionBox.Controls.Add(boxes[boxes.Count-2]);
                conditionsBox.Controls.Add(boxes[boxes.Count -1]);
            }
        }

        private void conditions_Enter(object sender, EventArgs e)
        {

        }

        private void currentStateBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void currentStateBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
