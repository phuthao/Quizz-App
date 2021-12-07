
namespace TRACNGHIEMBYWINFORM
{
    partial class UC_checkDapan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_checkDapan));
            this.datagirdview_checkDapAn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_note = new System.Windows.Forms.Button();
            this.check_box = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Your_DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagirdview_checkDapAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagirdview_checkDapAn
            // 
            this.datagirdview_checkDapAn.AllowUserToAddRows = false;
            this.datagirdview_checkDapAn.BackgroundColor = System.Drawing.Color.Silver;
            this.datagirdview_checkDapAn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagirdview_checkDapAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagirdview_checkDapAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagirdview_checkDapAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_box,
            this.Cau,
            this.DapAn,
            this.Your_DapAn,
            this.MonThi,
            this.Date,
            this.Column1,
            this.STT});
            this.datagirdview_checkDapAn.Location = new System.Drawing.Point(0, 0);
            this.datagirdview_checkDapAn.Name = "datagirdview_checkDapAn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagirdview_checkDapAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagirdview_checkDapAn.RowHeadersVisible = false;
            this.datagirdview_checkDapAn.RowHeadersWidth = 51;
            this.datagirdview_checkDapAn.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagirdview_checkDapAn.RowTemplate.Height = 24;
            this.datagirdview_checkDapAn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.datagirdview_checkDapAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagirdview_checkDapAn.Size = new System.Drawing.Size(524, 470);
            this.datagirdview_checkDapAn.TabIndex = 0;
            this.datagirdview_checkDapAn.BackgroundColorChanged += new System.EventHandler(this.dataGridView1_BackgroundColorChanged);
            this.datagirdview_checkDapAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.datagirdview_checkDapAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datagirdview_checkDapAn.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.datagirdview_checkDapAn.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
            this.datagirdview_checkDapAn.MouseHover += new System.EventHandler(this.datagirdview_checkDapAn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label_test";
            this.label1.Visible = false;
            // 
            // btn_note
            // 
            this.btn_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_note.ForeColor = System.Drawing.Color.White;
            this.btn_note.Image = ((System.Drawing.Image)(resources.GetObject("btn_note.Image")));
            this.btn_note.Location = new System.Drawing.Point(212, 507);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(122, 44);
            this.btn_note.TabIndex = 2;
            this.btn_note.Text = "Note";
            this.btn_note.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_note.UseVisualStyleBackColor = false;
            this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
            // 
            // check_box
            // 
            this.check_box.HeaderText = "Save";
            this.check_box.MinimumWidth = 6;
            this.check_box.Name = "check_box";
            this.check_box.Width = 50;
            // 
            // Cau
            // 
            this.Cau.DataPropertyName = "Cau";
            this.Cau.HeaderText = "Number";
            this.Cau.MinimumWidth = 6;
            this.Cau.Name = "Cau";
            this.Cau.Width = 125;
            // 
            // DapAn
            // 
            this.DapAn.DataPropertyName = "DapAn";
            this.DapAn.HeaderText = "Result";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.Width = 130;
            // 
            // Your_DapAn
            // 
            this.Your_DapAn.DataPropertyName = "Your_DapAn";
            this.Your_DapAn.HeaderText = "Your result";
            this.Your_DapAn.MinimumWidth = 6;
            this.Your_DapAn.Name = "Your_DapAn";
            this.Your_DapAn.Width = 130;
            // 
            // MonThi
            // 
            this.MonThi.DataPropertyName = "MonThi";
            this.MonThi.HeaderText = "Subject";
            this.MonThi.MinimumWidth = 6;
            this.MonThi.Name = "MonThi";
            this.MonThi.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "_INDEX";
            this.Column1.HeaderText = "SecondIdentity";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "Number";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.datagirdview_checkDapAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 592);
            this.panel1.TabIndex = 3;
            // 
            // UC_checkDapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_note);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_checkDapan";
            this.Size = new System.Drawing.Size(524, 592);
            this.Load += new System.EventHandler(this.UC_checkDapan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagirdview_checkDapAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagirdview_checkDapAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Your_DapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Panel panel1;
    }
}
