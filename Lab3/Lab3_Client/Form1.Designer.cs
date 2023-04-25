namespace Lab4_Client
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
            this.bai3 = new System.Windows.Forms.Button();
            this.bai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1
            // 
            this.bai1.Location = new System.Drawing.Point(59, 62);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(136, 45);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "Bai 1 client";
            this.bai1.UseVisualStyleBackColor = true;
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai3
            // 
            this.bai3.Location = new System.Drawing.Point(59, 213);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(136, 53);
            this.bai3.TabIndex = 2;
            this.bai3.Text = "Bai 3 client";
            this.bai3.UseVisualStyleBackColor = true;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bai4
            // 
            this.bai4.Location = new System.Drawing.Point(59, 311);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(136, 57);
            this.bai4.TabIndex = 3;
            this.bai4.Text = "Bai 4 client";
            this.bai4.UseVisualStyleBackColor = true;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bai4);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai1);
            this.Name = "Form1";
            this.Text = "Bài 1 Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bai1;
        private System.Windows.Forms.Button bai3;
        private System.Windows.Forms.Button bai4;
    }
}

