namespace Lab4_Server
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bai4 = new System.Windows.Forms.Button();
            this.bai3 = new System.Windows.Forms.Button();
            this.bai1 = new System.Windows.Forms.Button();
            this.bai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bai4
            // 
            this.bai4.Location = new System.Drawing.Point(91, 371);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(122, 51);
            this.bai4.TabIndex = 6;
            this.bai4.Text = "Bai 4 server";
            this.bai4.UseVisualStyleBackColor = true;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // bai3
            // 
            this.bai3.Location = new System.Drawing.Point(91, 264);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(122, 52);
            this.bai3.TabIndex = 7;
            this.bai3.Text = "Bai 3 server";
            this.bai3.UseVisualStyleBackColor = true;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bai1
            // 
            this.bai1.Location = new System.Drawing.Point(91, 44);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(122, 48);
            this.bai1.TabIndex = 8;
            this.bai1.Text = "Bai 1 server";
            this.bai1.UseVisualStyleBackColor = true;
            this.bai1.Click += new System.EventHandler(this.button4_Click);
            // 
            // bai2
            // 
            this.bai2.Location = new System.Drawing.Point(91, 153);
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(122, 51);
            this.bai2.TabIndex = 9;
            this.bai2.Text = "Bai 2 server";
            this.bai2.UseVisualStyleBackColor = true;
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bai2);
            this.Controls.Add(this.bai1);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai4);
            this.Name = "Form1";
            this.Text = "Bài 1 server";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bai4;
        private System.Windows.Forms.Button bai3;
        private System.Windows.Forms.Button bai1;
        private System.Windows.Forms.Button bai2;
    }
}

