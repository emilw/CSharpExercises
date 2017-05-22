namespace _14_3
{
    partial class CheckBoxTestForm
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.strikeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(46, 34);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(141, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Watch the font style change";
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(49, 66);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.boldCheckBox.TabIndex = 1;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(140, 66);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 2;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(49, 89);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 3;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.underlineCheckBox_CheckedChanged);
            // 
            // strikeoutCheckBox
            // 
            this.strikeoutCheckBox.AutoSize = true;
            this.strikeoutCheckBox.Location = new System.Drawing.Point(140, 89);
            this.strikeoutCheckBox.Name = "strikeoutCheckBox";
            this.strikeoutCheckBox.Size = new System.Drawing.Size(68, 17);
            this.strikeoutCheckBox.TabIndex = 4;
            this.strikeoutCheckBox.Text = "Strikeout";
            this.strikeoutCheckBox.UseVisualStyleBackColor = true;
            this.strikeoutCheckBox.CheckedChanged += new System.EventHandler(this.strikeoutCheckBox_CheckedChanged);
            // 
            // CheckBoxTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 146);
            this.Controls.Add(this.strikeoutCheckBox);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.outputLabel);
            this.Name = "CheckBoxTestForm";
            this.Text = "CheckBoxTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.CheckBox strikeoutCheckBox;
    }
}