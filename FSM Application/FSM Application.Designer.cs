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
            this.removeStateButton = new System.Windows.Forms.Button();
            this.conditionsBox = new System.Windows.Forms.GroupBox();
            this.transitionBox = new System.Windows.Forms.GroupBox();
            this.currentStateBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.addStateButton);
            this.panel1.Controls.Add(this.removeStateButton);
            this.panel1.Controls.Add(this.conditionsBox);
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
            this.addStateButton.Text = "Create States";
            this.addStateButton.UseVisualStyleBackColor = true;
            this.addStateButton.Click += new System.EventHandler(this.addStateButton_Click);
            // 
            // removeStateButton
            // 
            this.removeStateButton.Location = new System.Drawing.Point(68, 226);
            this.removeStateButton.Name = "removeStateButton";
            this.removeStateButton.Size = new System.Drawing.Size(107, 25);
            this.removeStateButton.TabIndex = 3;
            this.removeStateButton.Text = "Remove State";
            this.removeStateButton.UseVisualStyleBackColor = true;
            this.removeStateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // conditionsBox
            // 
            this.conditionsBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.conditionsBox.Location = new System.Drawing.Point(374, 3);
            this.conditionsBox.Name = "conditionsBox";
            this.conditionsBox.Size = new System.Drawing.Size(166, 217);
            this.conditionsBox.TabIndex = 2;
            this.conditionsBox.TabStop = false;
            this.conditionsBox.Text = "Condition";
            this.conditionsBox.Enter += new System.EventHandler(this.conditions_Enter);
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
            this.currentStateBox.Location = new System.Drawing.Point(48, 3);
            this.currentStateBox.Name = "currentStateBox";
            this.currentStateBox.Size = new System.Drawing.Size(164, 217);
            this.currentStateBox.TabIndex = 0;
            this.currentStateBox.TabStop = false;
            this.currentStateBox.Text = "Current State";
            this.currentStateBox.Enter += new System.EventHandler(this.currentStateBox_Enter);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(60, 304);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(239, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 35);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save FSM";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(405, 304);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(127, 35);
            this.loadbutton.TabIndex = 3;
            this.loadbutton.Text = "Load FSM";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 351);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FSM Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox conditionsBox;
        private System.Windows.Forms.GroupBox transitionBox;
        private System.Windows.Forms.GroupBox currentStateBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button removeStateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addStateButton;
        private System.Windows.Forms.Button loadbutton;
    }
}

