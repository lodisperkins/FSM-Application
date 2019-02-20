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
        public Form1()
        {
            boxes = new List<ComboBox>();
            InitializeComponent();
            var newText = new ComboBox();
            newText.Location = new Point(this.Size.Height / 2, this.Size.Width / 2);
            boxes.Add(newText);
            var newText1 = new ComboBox();
            newText1.Location = new Point(this.Size.Height / 2 - 5, this.Size.Width / 2 - 5);
            boxes.Add(newText1);
            this.Controls.Add(newText);
            this.Controls.Add(newText1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
