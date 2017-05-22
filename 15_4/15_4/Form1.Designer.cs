namespace _15_4
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
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.removedStatesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // statesComboBox
            // 
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(12, 12);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(177, 21);
            this.statesComboBox.TabIndex = 0;
            this.statesComboBox.SelectedIndexChanged += new System.EventHandler(this.statesComboBox_SelectedIndexChanged);
            // 
            // removedStatesListBox
            // 
            this.removedStatesListBox.FormattingEnabled = true;
            this.removedStatesListBox.Location = new System.Drawing.Point(208, 12);
            this.removedStatesListBox.Name = "removedStatesListBox";
            this.removedStatesListBox.Size = new System.Drawing.Size(120, 147);
            this.removedStatesListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 171);
            this.Controls.Add(this.removedStatesListBox);
            this.Controls.Add(this.statesComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statesComboBox;
        private System.Windows.Forms.ListBox removedStatesListBox;
    }
}

