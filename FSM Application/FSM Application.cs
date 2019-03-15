using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
namespace FSM_Application
{
    
    public partial class Form1 : Form
    {
        List<ComboBox> current_Boxes;
        List<ComboBox> transition_Boxes;
        
        public Fsm fsm = new Fsm();
         
        public ComboBox current_Drop = new ComboBox();
        public ComboBox transition_Drop = new ComboBox();
        public ComboBox condition_Drop = new ComboBox();
        
        public Point Point = new Point();

        public int x = 10;
        public int y = new int();

        public string state_Text = "Enter State Name...";
        public string cond_Text = "Enter Condition...";
        public string cond_True = "True";
        public string cond_False = "False";
        public string file_Name;
        public Form1()
        {
            transition_Boxes = new List<ComboBox>();
            current_Boxes = new List<ComboBox>();
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

                currentStateBox.Controls.Remove(currentStateBox.Controls[currentStateBox.Controls.Count-1]);
                transitionBox.Controls.Remove(transitionBox.Controls[transitionBox.Controls.Count - 1]);
                conditionsBox.Controls.Remove(conditionsBox.Controls[conditionsBox.Controls.Count - 1]);
            }

        } 
        //updates the items in the list of each combobox 
        public void updateText(object sender, EventArgs e)
        {
           
            for (int i = 0; i < current_Boxes.Count; i++)
            {
                current_Boxes[i].Items.Clear();
                for (int h = 0; h < currentStateBox.Controls.Count; h++)
                {
                    current_Boxes[i].Items.Add(currentStateBox.Controls[h].Text);
                }
            }
            for (int i = 0; i < transition_Boxes.Count; i++)
            {
                transition_Boxes[i].Items.Clear();
                for (int h = 0; h < transitionBox.Controls.Count; h++)
                {
                    transition_Boxes[i].Items.Add(currentStateBox.Controls[h].Text);
                }
            }
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
                //set the new y value used in the position of the dropdown box
                y += x * 3;
                //creates new comboboxes for each column
                current_Drop = new ComboBox();
                transition_Drop = new ComboBox();
                condition_Drop = new ComboBox();
                //sets the location of each combobox
                current_Drop.Location = new Point(x, y);
                transition_Drop.Location = new Point(x, y);
                condition_Drop.Location = new Point(x, y);
                //sets default text for each combobox
                current_Drop.Text = state_Text;
                transition_Drop.Text = state_Text;
                condition_Drop.Text = cond_Text;
                //adds default selection choices for each combobox
                current_Drop.Items.Add(current_Drop.Text);
                transition_Drop.Items.Add(current_Drop.Text);
                condition_Drop.Items.Add(cond_True);
                condition_Drop.Items.Add(cond_False);
                //adds the current and transition column boxes to a list to be used in the updatetext function
                current_Boxes.Add(current_Drop);
                transition_Boxes.Add(transition_Drop);    
                //adds the controls to the columns
                currentStateBox.Controls.Add(current_Drop);
                transitionBox.Controls.Add(transition_Drop);
                conditionsBox.Controls.Add(condition_Drop);
                //updates the text in the dropwdown list once the button is clicked
                current_Drop.DropDown += updateText;
                transition_Drop.DropDown += updateText;
            }
        }
        private void changeFilename(object sender, EventArgs e)
        {
           
        }

        private void conditions_Enter(object sender, EventArgs e)
        {

        }

        private void currentStateBox_Enter(object sender, EventArgs e)
        {
            
        }
        //creates and adds states to the FSM and then saves it to an xml file
        private void saveButton_Click(object sender, EventArgs e)
        {
            Form2 test = new Form2();
            
            test.Show();
            
            for (int i = 0; i < currentStateBox.Controls.Count-1; i ++)
            {
                State state = new State(currentStateBox.Controls[i].Text, transitionBox.Controls[i].Text);
                if(conditionsBox.Controls[i].Text == "True")
                {
                    state.condition = true;
                }
                else
                {
                    state.condition = false;
                }
                fsm.Add(state);
            }

            JsonSerializer serializer = new JsonSerializer();
            //XmlSerializer serializer = new XmlSerializer(typeof(Fsm));
            TextWriter writer = new StreamWriter("FSM.json");
            serializer.Serialize(writer, fsm);
            writer.Close();
        }
    }
}
