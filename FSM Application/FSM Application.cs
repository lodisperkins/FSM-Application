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
        //The lists used for updating the first two columns drop down boxes
        List<ComboBox> current_Boxes;
        List<ComboBox> transition_Boxes;
        //The finite state machine that will be pop[ulated with the values entered
        public Fsm fsm = new Fsm();
        //The controls that will populate each of the columns
        public ComboBox current_Drop = new ComboBox();
        public ComboBox transition_Drop = new ComboBox();
        public ComboBox condition_Drop = new ComboBox();
        //Used to represent location of each control
        public Point Point = new Point();
        public int x = 10;
        public int y = new int();
        //Default text for each drop down box
        public string state_Text = "Enter State Name...";
        public string cond_Text = "Enter Condition...";
        public string cond_True = "True";
        public string cond_False = "False";
        //Name of the file that will be written to
        public string file_Name = "FSM";
        public Modify mod_Form = new Modify();
        public TreeView state;
        bool has_Saved = false;
        public Form1()
        {
            transition_Boxes = new List<ComboBox>();
            current_Boxes = new List<ComboBox>();
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
                mod_Form.Show();
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

        private void conditions_Enter(object sender, EventArgs e)
        {

        }

        private void currentStateBox_Enter(object sender, EventArgs e)
        {
            
        }
        //creates and adds states to the FSM and then saves it to a json file
        private void save()
        {
            ///<summary>
            /// Grabs each of the names of the states in current dropdown boxes. 
            /// Names in the current state column are set as the states name once created
            /// while names in the transitions to column are set to the new states destination state once created.
            ///</summary>
            for (int i = 0; i < currentStateBox.Controls.Count; i++)
            {
                State state = new State(currentStateBox.Controls[i].Text, transitionBox.Controls[i].Text);
                if (conditionsBox.Controls[i].Text == "True")
                {
                    state.condition = true;
                }
                else
                {
                    state.condition = false;
                }
                fsm.Add(state);
            }
            // After all states are created and added to the fsm they are serialized
            JsonSerializer serializer = new JsonSerializer();
            TextWriter writer = new StreamWriter(file_Name);
            serializer.Serialize(writer, fsm);
            writer.Close();
        }
        //Checks to see if the file exists. If so, it loads the file into the fsm app
        private void load()
        {
            if(!System.IO.File.Exists(file_Name))
            {
                return;
            }
            else
            {
                //resets the position of the drop down boxes
                y = 0;
                //loads the contents of the frile and stores it in the fsm variable
                fsm = JsonConvert.DeserializeObject<Fsm>(File.ReadAllText(file_Name));
                //clears all the current drop down boxes on the screen
                currentStateBox.Controls.Clear();
                transitionBox.Controls.Clear();
                conditionsBox.Controls.Clear();
                //loops through each new state loaded and updates the screen 
                for (int i = 0; i < fsm.statesList.Count;i++)
                {
                    //set the new y value used in the position of the dropdown box
                    y += x * 3;
                    //creates new comboboxes for each column
                    current_Drop = new ComboBox();
                    transition_Drop = new ComboBox();
                    transition_Drop.DropDownStyle = ComboBoxStyle.DropDownList;
                    condition_Drop = new ComboBox();
                    //sets the location of each combobox
                    current_Drop.Location = new Point(x, y);
                    transition_Drop.Location = new Point(x, y);
                    condition_Drop.Location = new Point(x, y);
                    //sets default text for each combobox
                    current_Drop.Text = fsm.statesList[i].Name;
                    transition_Drop.Text = fsm.statesList[i].destinationName;
                    //adds the current and transition column boxes to a list to be used in the updatetext function
                    current_Boxes.Add(current_Drop);
                    transition_Boxes.Add(transition_Drop);
                    //adds the controls to the columns
                    currentStateBox.Controls.Add(current_Drop);
                    transitionBox.Controls.Add(transition_Drop);
                    conditionsBox.Controls.Add(condition_Drop);
                    //adds the options for the condtions drop down boxes
                    condition_Drop.Items.Add(cond_True);
                    condition_Drop.Items.Add(cond_False);
                    if(fsm.statesList[i].condition == true)
                    {
                        condition_Drop.Text = "True";
                    }
                    else
                    {
                        condition_Drop.Text = "False";
                    }
                    //updates the text in the dropwdown list once the drop button is clicked
                    current_Drop.DropDown += updateText;
                    transition_Drop.DropDown += updateText;
                }
            }
        }
        private void close(object sender,EventArgs e)
        {
            Close();
        }
        //shows the save window once clicked 
        private void saveButton_Click(object sender, EventArgs e)
        {
            var save_Window = new SaveFileDialog();
            save_Window.InitialDirectory = Environment.CurrentDirectory;
            save_Window.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = save_Window.ShowDialog();
            save_Window.FilterIndex = 2;
            if (result == DialogResult.OK)
            {
                file_Name = save_Window.FileName;
                has_Saved = true;
                save();
            }
        }
        //shows the load window once clicked
        private void loadbutton_Click(object sender, EventArgs e)
        {
            var load_Window = new OpenFileDialog();
            load_Window.InitialDirectory = Environment.CurrentDirectory;
            load_Window.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = load_Window.ShowDialog();
            if (result == DialogResult.OK)
            {
                file_Name = load_Window.FileName;
                
                load();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (has_Saved)
            {
                Close();
            }
            else
            {
                warning warning_Window = new warning();
                warning_Window.Show();
                warning_Window.Controls[1].Click += close;
            }
        }
    }
}
