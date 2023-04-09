namespace Lab1
{
    partial class Management
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputScore = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notPassed = new System.Windows.Forms.Label();
            this.min_score = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.Label();
            this.passed = new System.Windows.Forms.Label();
            this.max_score = new System.Windows.Forms.Label();
            this.average_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm: ";
            // 
            // inputScore
            // 
            this.inputScore.Location = new System.Drawing.Point(205, 97);
            this.inputScore.Name = "inputScore";
            this.inputScore.Size = new System.Drawing.Size(532, 22);
            this.inputScore.TabIndex = 2;
            this.inputScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(642, 139);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(95, 29);
            this.Print.TabIndex = 3;
            this.Print.Text = "Xuất";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(47, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 223);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách môn học và điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm trung bình: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Xếp loại học lực: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Môn có điểm cao nhất: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Môn có điểm thấp nhất: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số môn đậu: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số môn không đậu: ";
            // 
            // notPassed
            // 
            this.notPassed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notPassed.Location = new System.Drawing.Point(642, 569);
            this.notPassed.Name = "notPassed";
            this.notPassed.Size = new System.Drawing.Size(94, 28);
            this.notPassed.TabIndex = 11;
            // 
            // min_score
            // 
            this.min_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.min_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_score.Location = new System.Drawing.Point(673, 510);
            this.min_score.Name = "min_score";
            this.min_score.Size = new System.Drawing.Size(94, 28);
            this.min_score.TabIndex = 12;
            // 
            // rank
            // 
            this.rank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.Location = new System.Drawing.Point(605, 447);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(183, 28);
            this.rank.TabIndex = 13;
            // 
            // passed
            // 
            this.passed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passed.Location = new System.Drawing.Point(205, 569);
            this.passed.Name = "passed";
            this.passed.Size = new System.Drawing.Size(94, 28);
            this.passed.TabIndex = 14;
            // 
            // max_score
            // 
            this.max_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.max_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_score.Location = new System.Drawing.Point(267, 509);
            this.max_score.Name = "max_score";
            this.max_score.Size = new System.Drawing.Size(94, 28);
            this.max_score.TabIndex = 15;
            // 
            // average_score
            // 
            this.average_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.average_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_score.Location = new System.Drawing.Point(219, 447);
            this.average_score.Name = "average_score";
            this.average_score.Size = new System.Drawing.Size(94, 28);
            this.average_score.TabIndex = 16;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.average_score);
            this.Controls.Add(this.max_score);
            this.Controls.Add(this.passed);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.min_score);
            this.Controls.Add(this.notPassed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.inputScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Management";
            this.Text = "Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputScore;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label notPassed;
        private System.Windows.Forms.Label min_score;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.Label passed;
        private System.Windows.Forms.Label max_score;
        private System.Windows.Forms.Label average_score;
    }
}