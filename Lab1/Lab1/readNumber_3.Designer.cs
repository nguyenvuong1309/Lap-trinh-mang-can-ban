namespace Lab1
{
    partial class readNumber_3
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
            this.label_nhap = new System.Windows.Forms.Label();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đọc số từ 0 đến 9";
            // 
            // label_nhap
            // 
            this.label_nhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhap.Location = new System.Drawing.Point(109, 140);
            this.label_nhap.Name = "label_nhap";
            this.label_nhap.Size = new System.Drawing.Size(140, 40);
            this.label_nhap.TabIndex = 1;
            this.label_nhap.Text = "Nhập số";
            // 
            // label_ketqua
            // 
            this.label_ketqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ketqua.Location = new System.Drawing.Point(109, 211);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(140, 40);
            this.label_ketqua.TabIndex = 2;
            this.label_ketqua.Text = "Kết quả";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(307, 140);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(300, 40);
            this.input.TabIndex = 3;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(307, 211);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(300, 40);
            this.output.TabIndex = 4;
            // 
            // read
            // 
            this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.Location = new System.Drawing.Point(87, 296);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(140, 40);
            this.read.TabIndex = 5;
            this.read.Text = "Đọc";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(324, 296);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 40);
            this.delete.TabIndex = 6;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(529, 296);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 40);
            this.exit.TabIndex = 7;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // readNumber_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.read);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label_ketqua);
            this.Controls.Add(this.label_nhap);
            this.Controls.Add(this.label1);
            this.Name = "readNumber_3";
            this.Text = "readNumber_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nhap;
        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
    }
}