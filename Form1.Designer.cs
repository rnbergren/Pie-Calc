namespace PI_Calculation
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
            this.cmdPI = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdPI
            // 
            this.cmdPI.Location = new System.Drawing.Point(367, 181);
            this.cmdPI.Name = "cmdPI";
            this.cmdPI.Size = new System.Drawing.Size(75, 23);
            this.cmdPI.TabIndex = 0;
            this.cmdPI.Text = "Pi!";
            this.cmdPI.UseVisualStyleBackColor = true;
            this.cmdPI.Click += new System.EventHandler(this.cmdPI_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(198, 117);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(35, 13);
            this.lblAns.TabIndex = 1;
            this.lblAns.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(201, 75);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(181, 20);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = "18446372036854775807";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "higher=slower but better";
            // 
            // lblo
            // 
            this.lblo.AutoSize = true;
            this.lblo.Location = new System.Drawing.Point(121, 218);
            this.lblo.Name = "lblo";
            this.lblo.Size = new System.Drawing.Size(13, 13);
            this.lblo.TabIndex = 4;
            this.lblo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current value calculated";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.cmdPI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPI;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblo;
        private System.Windows.Forms.Label label2;
    }
}

