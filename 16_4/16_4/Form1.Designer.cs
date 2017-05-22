namespace _16_4
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
            this.txtValueA = new System.Windows.Forms.TextBox();
            this.txtValueB = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValueA
            // 
            this.txtValueA.Location = new System.Drawing.Point(12, 11);
            this.txtValueA.Name = "txtValueA";
            this.txtValueA.Size = new System.Drawing.Size(132, 20);
            this.txtValueA.TabIndex = 0;
            // 
            // txtValueB
            // 
            this.txtValueB.Location = new System.Drawing.Point(150, 11);
            this.txtValueB.Name = "txtValueB";
            this.txtValueB.Size = new System.Drawing.Size(132, 20);
            this.txtValueB.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(194, 37);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(88, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "CompareTo()";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 66);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(266, 20);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 99);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtValueB);
            this.Controls.Add(this.txtValueA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValueA;
        private System.Windows.Forms.TextBox txtValueB;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtResult;
    }
}

