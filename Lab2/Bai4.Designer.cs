using DocumentFormat.OpenXml.Spreadsheet;

namespace Lab2
{
    partial class Bai4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.importData = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.renderData = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MathScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Literaturescore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // importData
            // 
            this.importData.Location = new System.Drawing.Point(12, 44);
            this.importData.Name = "importData";
            this.importData.Size = new System.Drawing.Size(143, 52);
            this.importData.TabIndex = 2;
            this.importData.Text = "Nhập thông tin";
            this.importData.UseVisualStyleBackColor = true;
            this.importData.Click += new System.EventHandler(this.importData_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(12, 141);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(143, 52);
            this.export.TabIndex = 3;
            this.export.Text = "Xuất ra file excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // renderData
            // 
            this.renderData.Location = new System.Drawing.Point(12, 362);
            this.renderData.Name = "renderData";
            this.renderData.Size = new System.Drawing.Size(143, 52);
            this.renderData.TabIndex = 2;
            this.renderData.Text = "Hiên thị thông tin";
            this.renderData.UseVisualStyleBackColor = true;
            this.renderData.Click += new System.EventHandler(this.renderData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(997, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.PhoneNumber,
            this.MathScore,
            this.Literaturescore,
            this.average});
            this.dataGrid.Location = new System.Drawing.Point(173, 44);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(809, 370);
            this.dataGrid.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Bai4";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // MathScore
            // 
            this.MathScore.HeaderText = "MathScore";
            this.MathScore.MinimumWidth = 6;
            this.MathScore.Name = "MathScore";
            this.MathScore.ReadOnly = true;
            this.MathScore.Width = 125;
            // 
            // Literaturescore
            // 
            this.Literaturescore.HeaderText = "Literaturescore";
            this.Literaturescore.MinimumWidth = 6;
            this.Literaturescore.Name = "Literaturescore";
            this.Literaturescore.ReadOnly = true;
            this.Literaturescore.Width = 125;
            // 
            // average
            // 
            this.average.HeaderText = "average";
            this.average.MinimumWidth = 6;
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Width = 125;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 248);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(143, 55);
            this.save.TabIndex = 7;
            this.save.Text = "Lưu thành file excel";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 445);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.renderData);
            this.Controls.Add(this.export);
            this.Controls.Add(this.importData);
            this.Name.HeaderText = "Bai4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button importData;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button renderData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MathScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Literaturescore;
        private System.Windows.Forms.DataGridViewTextBoxColumn average;
        private System.Windows.Forms.Button save;
    }
}
