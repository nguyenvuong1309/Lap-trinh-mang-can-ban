namespace Lab2
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
            this.bai1 = new System.Windows.Forms.Button();
            this.bai2 = new System.Windows.Forms.Button();
            this.bai3 = new System.Windows.Forms.Button();
            this.bai4 = new System.Windows.Forms.Button();
            this.bai5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1
            // 
            this.bai1.Location = new System.Drawing.Point(52, 25);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(75, 23);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "Bai1";
            this.bai1.UseVisualStyleBackColor = true;
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.Location = new System.Drawing.Point(52, 83);
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(75, 23);
            this.bai2.TabIndex = 1;
            this.bai2.Text = "Bai2";
            this.bai2.UseVisualStyleBackColor = true;
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // bai3
            // 
            this.bai3.Location = new System.Drawing.Point(52, 143);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(75, 23);
            this.bai3.TabIndex = 2;
            this.bai3.Text = "Bai3";
            this.bai3.UseVisualStyleBackColor = true;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bai4
            // 
            this.bai4.Location = new System.Drawing.Point(52, 217);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(75, 23);
            this.bai4.TabIndex = 3;
            this.bai4.Text = "Bài 4";
            this.bai4.UseVisualStyleBackColor = true;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // bai5
            // 
            this.bai5.Location = new System.Drawing.Point(52, 286);
            this.bai5.Name = "bai5";
            this.bai5.Size = new System.Drawing.Size(75, 23);
            this.bai5.TabIndex = 4;
            this.bai5.Text = "Bài 5";
            this.bai5.UseVisualStyleBackColor = true;
            this.bai5.Click += new System.EventHandler(this.bai5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bai5);
            this.Controls.Add(this.bai4);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai2);
            this.Controls.Add(this.bai1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bai1;
        private System.Windows.Forms.Button bai2;
        private System.Windows.Forms.Button bai3;
        private System.Windows.Forms.Button bai4;
        private System.Windows.Forms.Button bai5;
    }
}

