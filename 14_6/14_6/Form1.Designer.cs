namespace _14_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.fahrenheitInputText = new System.Windows.Forms.TextBox();
            this.lblCelsiusOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit:";
            // 
            // fahrenheitInputText
            // 
            this.fahrenheitInputText.Location = new System.Drawing.Point(78, 22);
            this.fahrenheitInputText.Name = "fahrenheitInputText";
            this.fahrenheitInputText.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitInputText.TabIndex = 1;
            this.fahrenheitInputText.Text = "0";
            this.fahrenheitInputText.TextChanged += new System.EventHandler(this.fahrenheitInputText_TextChanged);
            // 
            // lblCelsiusOutput
            // 
            this.lblCelsiusOutput.AutoSize = true;
            this.lblCelsiusOutput.Location = new System.Drawing.Point(251, 25);
            this.lblCelsiusOutput.Name = "lblCelsiusOutput";
            this.lblCelsiusOutput.Size = new System.Drawing.Size(13, 13);
            this.lblCelsiusOutput.TabIndex = 2;
            this.lblCelsiusOutput.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Celsius:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 56);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCelsiusOutput);
            this.Controls.Add(this.fahrenheitInputText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Celsius converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fahrenheitInputText;
        private System.Windows.Forms.Label lblCelsiusOutput;
        private System.Windows.Forms.Label label3;
    }
}

