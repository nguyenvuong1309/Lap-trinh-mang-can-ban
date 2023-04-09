namespace Lab2
{
    partial class Bai5
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
            this.IN = new System.Windows.Forms.Button();
            this.OUT = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // IN
            // 
            this.IN.Location = new System.Drawing.Point(12, 12);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(75, 23);
            this.IN.TabIndex = 0;
            this.IN.Text = "<<";
            this.IN.UseVisualStyleBackColor = true;
            this.IN.Click += new System.EventHandler(this.IN_Click);
            // 
            // OUT
            // 
            this.OUT.Location = new System.Drawing.Point(105, 12);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(75, 23);
            this.OUT.TabIndex = 1;
            this.OUT.Text = ">>";
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(713, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 2;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(211, 12);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(78, 23);
            this.path.TabIndex = 3;
            this.path.Text = "Path:";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(274, 12);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(433, 22);
            this.textPath.TabIndex = 4;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 51);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(776, 387);
            this.webBrowser.TabIndex = 5;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.path);
            this.Controls.Add(this.open);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.IN);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IN;
        private System.Windows.Forms.Button OUT;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}