namespace Lab2
{
    partial class Bai1
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
            this.write = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(64, 371);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 1;
            this.read.Text = "Đọc ";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(622, 371);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(75, 23);
            this.write.TabIndex = 2;
            this.write.Text = "Ghi";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(29, 27);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(731, 308);
            this.message.TabIndex = 3;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.TextBox message;
    }
}