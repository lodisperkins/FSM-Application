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
            this.conditionsBox = new System.Windows.Forms.GroupBox();
            this.transitionBox = new System.Windows.Forms.GroupBox();
            this.currentStateBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.addStateButton);
            this.panel1.Controls.Add(this.conditionsBox);
            this.panel1.Controls.Add(this.transitionBox);
            this.panel1.Controls.Add(this.currentStateBox);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 266);
            this.panel1.TabIndex = 0;
            // 
            // addStateButton
            // 
            this.addStateButton.Location = new System.Drawing.Point(403, 229);
            this.addStateButton.Name = "addStateButton";
            this.addStateButton.Size = new System.Drawing.Size(137, 37);
            this.addStateButton.TabIndex = 4;
            this.addStateButton.Text = "Modify FSM";
            this.addStateButton.UseVisualStyleBackColor = true;
            this.addStateButton.Click += new System.EventHandler(this.addStateButton_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 306);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FSM Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox conditionsBox;
        private System.Windows.Forms.GroupBox transitionBox;
        private System.Windows.Forms.GroupBox currentStateBox;
        private System.Windows.Forms.Button addStateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

