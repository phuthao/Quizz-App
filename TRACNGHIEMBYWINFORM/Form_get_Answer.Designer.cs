
namespace TRACNGHIEMBYWINFORM
{
    partial class Form_get_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_get_Answer));
            this.DATAGRIDDAPAN = new System.Windows.Forms.DataGridView();
            this.btn_Export = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDDAPAN)).BeginInit();
            this.SuspendLayout();
            // 
            // DATAGRIDDAPAN
            // 
            this.DATAGRIDDAPAN.AllowUserToAddRows = false;
            this.DATAGRIDDAPAN.AllowUserToDeleteRows = false;
            this.DATAGRIDDAPAN.BackgroundColor = System.Drawing.Color.White;
            this.DATAGRIDDAPAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDDAPAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MonTHI,
            this.MaDT,
            this.DapAn});
            this.DATAGRIDDAPAN.Location = new System.Drawing.Point(2, 114);
            this.DATAGRIDDAPAN.Name = "DATAGRIDDAPAN";
            this.DATAGRIDDAPAN.ReadOnly = true;
            this.DATAGRIDDAPAN.RowHeadersWidth = 51;
            this.DATAGRIDDAPAN.RowTemplate.Height = 24;
            this.DATAGRIDDAPAN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGRIDDAPAN.Size = new System.Drawing.Size(1210, 360);
            this.DATAGRIDDAPAN.TabIndex = 0;
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.Image")));
            this.btn_Export.Location = new System.Drawing.Point(503, 16);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(230, 81);
            this.btn_Export.TabIndex = 22;
            this.btn_Export.Text = "Export File Answer";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "NUMBER";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // MonTHI
            // 
            this.MonTHI.DataPropertyName = "chude";
            this.MonTHI.HeaderText = "TOPIC";
            this.MonTHI.MinimumWidth = 6;
            this.MonTHI.Name = "MonTHI";
            this.MonTHI.ReadOnly = true;
            this.MonTHI.Width = 125;
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "madt";
            this.MaDT.HeaderText = "CODE";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            this.MaDT.Width = 125;
            // 
            // DapAn
            // 
            this.DapAn.DataPropertyName = "DapAn";
            this.DapAn.HeaderText = "ANSWER";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.ReadOnly = true;
            this.DapAn.Width = 125;
            // 
            // Form_get_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 478);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.DATAGRIDDAPAN);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_get_Answer";
            this.Padding = new System.Windows.Forms.Padding(22, 64, 22, 21);
            this.Load += new System.EventHandler(this.GETDAPAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDDAPAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DATAGRIDDAPAN;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
    }
}