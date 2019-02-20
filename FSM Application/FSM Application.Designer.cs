namespace FSM_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addStateButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.conditions = new System.Windows.Forms.GroupBox();
            this.transitionBox = new System.Windows.Forms.GroupBox();
            this.currentStateBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.currentStateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.addStateButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.conditions);
            this.panel1.Controls.Add(this.transitionBox);
            this.panel1.Controls.Add(this.currentStateBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 266);
            this.panel1.TabIndex = 0;
            // 
            // addStateButton
            // 
            this.addStateButton.Location = new System.Drawing.Point(413, 226);
            this.addStateButton.Name = "addStateButton";
            this.addStateButton.Size = new System.Drawing.Size(107, 25);
            this.addStateButton.TabIndex = 4;
            this.addStateButton.Text = "Add State";
            this.addStateButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove State";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // conditions
            // 
            this.conditions.BackColor = System.Drawing.SystemColors.ControlDark;
            this.conditions.Location = new System.Drawing.Point(374, 3);
            this.conditions.Name = "conditions";
            this.conditions.Size = new System.Drawing.Size(166, 217);
            this.conditions.TabIndex = 2;
            this.conditions.TabStop = false;
            this.conditions.Text = "Condition";
            // 
            // transitionBox
            // 
            this.transitionBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.transitionBox.Location = new System.Drawing.Point(210, 3);
            this.transitionBox.Name = "transitionBox";
            this.transitionBox.Size = new System.Drawing.Size(167, 217);
            this.transitionBox.TabIndex = 1;
            this.transitionBox.TabStop = false;
            this.transitionBox.Text = "Transitions to";
            // 
            // currentStateBox
            // 
            this.currentStateBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.currentStateBox.Controls.Add(this.comboBox1);
            this.currentStateBox.Location = new System.Drawing.Point(48, 3);
            this.currentStateBox.Name = "currentStateBox";
            this.currentStateBox.Size = new System.Drawing.Size(164, 217);
            this.currentStateBox.TabIndex = 0;
            this.currentStateBox.TabStop = false;
            this.currentStateBox.Text = "Current State";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(60, 304);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(425, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 35);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 351);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FSM Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.currentStateBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox conditions;
        private System.Windows.Forms.GroupBox transitionBox;
        private System.Windows.Forms.GroupBox currentStateBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addStateButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

