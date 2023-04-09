namespace Lab2
{
    partial class Bai2
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
            this.readFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.nameFile = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.numberRow = new System.Windows.Forms.TextBox();
            this.numberWord = new System.Windows.Forms.TextBox();
            this.numberChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readFile
            // 
            this.readFile.Location = new System.Drawing.Point(74, 33);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(204, 44);
            this.readFile.TabIndex = 0;
            this.readFile.Text = "Đọc file";
            this.readFile.UseVisualStyleBackColor = true;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số kí tự";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(342, 28);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(446, 410);
            this.message.TabIndex = 12;
            // 
            // nameFile
            // 
            this.nameFile.Location = new System.Drawing.Point(107, 99);
            this.nameFile.Name = "nameFile";
            this.nameFile.Size = new System.Drawing.Size(205, 22);
            this.nameFile.TabIndex = 13;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(102, 161);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(210, 22);
            this.URL.TabIndex = 14;
            // 
            // numberRow
            // 
            this.numberRow.Location = new System.Drawing.Point(102, 237);
            this.numberRow.Name = "numberRow";
            this.numberRow.Size = new System.Drawing.Size(210, 22);
            this.numberRow.TabIndex = 15;
            // 
            // numberWord
            // 
            this.numberWord.Location = new System.Drawing.Point(102, 319);
            this.numberWord.Name = "numberWord";
            this.numberWord.Size = new System.Drawing.Size(210, 22);
            this.numberWord.TabIndex = 16;
            // 
            // numberChar
            // 
            this.numberChar.Location = new System.Drawing.Point(102, 388);
            this.numberChar.Name = "numberChar";
            this.numberChar.Size = new System.Drawing.Size(210, 22);
            this.numberChar.TabIndex = 17;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberChar);
            this.Controls.Add(this.numberWord);
            this.Controls.Add(this.numberRow);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.nameFile);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readFile);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox nameFile;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox numberRow;
        private System.Windows.Forms.TextBox numberWord;
        private System.Windows.Forms.TextBox numberChar;
    }
}