namespace FSM_Application
{
    partial class Statepanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statename
            // 
            this.statename.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statename.Location = new System.Drawing.Point(54, 14);
            this.statename.Name = "statename";
            this.statename.Size = new System.Drawing.Size(131, 28);
            this.statename.TabIndex = 0;
            this.statename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Statepanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.statename);
            this.Name = "Statepanel";
            this.Size = new System.Drawing.Size(234, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statename;
    }
}
