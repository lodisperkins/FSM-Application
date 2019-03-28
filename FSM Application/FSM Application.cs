using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace FSM_Application
{
    
    public partial class Form1 : Form
    {
        //The lists used for updating the first two columns drop down boxes
        List<Label> current_Boxes;
        List<ComboBox> transition_Boxes;
        List<string> condition_Text;
        //The finite state machine that will be pop[ulated with the values entered
        public Fsm fsm = new Fsm();
        //The controls that will populate each of the columns
        public Label current_Drop = new Label();
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
        //Child form used for adding states
        public Modify mod_Form = new Modify();
 
        //Keeps track of whether or not the user has saved
        bool has_Saved = false;
        public Form1()
        {
            transition_Boxes = new List<ComboBox>();
            current_Boxes = new List<Label>();
            condition_Text = new List<string>();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            FormClosing += warning;
            InitializeComponent();
            mod_Form.Owner = this;
            mod_Form.Controls[0].Click += updateTable;
            mod_Form.MaximizeBox = false;
            mod_Form.StartPosition = FormStartPosition.CenterParent;
        }
        /// <summary>
        /// If the user closes the program without saving, this function creates a new form warning 
        /// them. If the user has saved, the program closes as normal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void warning(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (has_Saved)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    warning warning_Window = new warning();
                    warning_Window.Owner = this;
                    warning_Window.StartPosition = FormStartPosition.CenterParent;
                    warning_Window.Controls[1].Click += close;
                    warning_Window.ShowDialog();
                }
            }
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //updates the items in the list of each combobox 
        public void updateText(object sender, EventArgs e)
        {
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
        //Updates the finite state machine after new states have been added in the modify FSM window
        private void updateTable(object sender, EventArgs e)
        {
            //Clears all previous data and resets position
            
            if (currentStateBox.Controls.Count > 0)
            {
                for (int i = 0; i < transitionBox.Controls.Count&&i<mod_Form.states.Count; i++)
                {

                    mod_Form.states[i].destinationName = transitionBox.Controls[i].Text;
                    string condition = conditionsBox.Controls[i].Text;
                    condition_Text.Add(condition);
                }
            }
            currentStateBox.Controls.Clear();
            transitionBox.Controls.Clear();
            conditionsBox.Controls.Clear();

            y = 0;

            for (int i = 0; i < mod_Form.states.Count; i++)
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
                    current_Drop = new Label();
                    current_Drop.Font = new Font(current_Drop.Font.Name, 12f);
                    transition_Drop = new ComboBox();
                    condition_Drop = new ComboBox();
                    //sets the location of each combobox
                    current_Drop.Location = new Point(x+30, y);
                    transition_Drop.Location = new Point(x, y);
                    condition_Drop.Location = new Point(x, y);
                    //sets default text for each combobox
                    current_Drop.Text = mod_Form.states[i].Name;
                    transition_Drop.Text = mod_Form.states[i].destinationName;
                    if (i > condition_Text.Count - 1)
                    {
                        condition_Drop.Text = cond_Text;
                    }
                    else
                    {
                        condition_Drop.Text = condition_Text[i];
                    }
                    //adds default selection choices for each combobox
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
                    transition_Drop.DropDown += updateText;
                }
            }
        }
        //Opens the modify FSM window if clicked
        private void addStateButton_Click(object sender, EventArgs e)
        {
            mod_Form.ShowDialog();
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
        //needs to be fixed
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
                mod_Form.loadStates(fsm.statesList);
                //loops through each new state loaded and updates the screen 
                for (int i = 0; i < fsm.statesList.Count;i++)
                {
                    //set the new y value used in the position of the dropdown box
                    y += x * 3;
                    
                    //creates new comboboxes for each column
                    current_Drop = new Label();
                    transition_Drop = new ComboBox();
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
                    transition_Drop.DropDown += updateText;
                }
            }
        }
        private void close(object sender,EventArgs e)
        {
            has_Saved = true;
            Close();
        }
        //shows the save window once clicked 
        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }
        //shows the load window once clicked
        private void loadbutton_Click(object sender, EventArgs e)
        {
           
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
        }
        //Allows the user to select which file path to save their FSM to
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
        //Allows the user to select which file path to load their FSM from
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
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
        //Checks the see if the user has saved. If so the program closes as normally. Otherwise the warning window displays.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
