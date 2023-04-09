namespace Lab2
{
    partial class Bai3
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
            this.read = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(91, 33);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(98, 35);
            this.read.TabIndex = 2;
            this.read.Text = "Đọc";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(360, 33);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(89, 35);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Tính";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(635, 33);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(97, 35);
            this.write.TabIndex = 4;
            this.write.Text = "Ghi";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(35, 98);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(337, 321);
            this.input.TabIndex = 5;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(426, 98);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(331, 321);
            this.output.TabIndex = 6;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.write);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.read);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
    }
}