
namespace TRACNGHIEMBYWINFORM
{
    partial class Form_Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Search));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socaudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socausai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetocomplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solanthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_msv = new System.Windows.Forms.TextBox();
            this.lbl_MSVstatic = new System.Windows.Forms.Label();
            this.btn_xoalichsu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.panel_blank = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSV,
            this.STT,
            this.Column1,
            this.phone,
            this.dayofbirth,
            this.Date,
            this.socaudung,
            this.socausai,
            this.timetocomplete,
            this.Solanthi,
            this.MonTHI,
            this.MaDT});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1539, 551);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_blank_MouseHover);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_blank_MouseMove);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_blank_MouseUp);
            // 
            // MSV
            // 
            this.MSV.DataPropertyName = "MSV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.MSV.DefaultCellStyle = dataGridViewCellStyle7;
            this.MSV.HeaderText = "STUDENT CODE";
            this.MSV.MinimumWidth = 6;
            this.MSV.Name = "MSV";
            this.MSV.ReadOnly = true;
            this.MSV.Visible = false;
            this.MSV.Width = 125;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "SERIAL";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.STT.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.FillWeight = 32.08555F;
            this.Column1.HeaderText = "FULL NAME";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.FillWeight = 32.08555F;
            this.phone.HeaderText = "PHONE";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 110;
            // 
            // dayofbirth
            // 
            this.dayofbirth.DataPropertyName = "dayofbirth";
            this.dayofbirth.FillWeight = 32.08555F;
            this.dayofbirth.HeaderText = "DAY OF BIRTH";
            this.dayofbirth.MinimumWidth = 6;
            this.dayofbirth.Name = "dayofbirth";
            this.dayofbirth.ReadOnly = true;
            this.dayofbirth.Width = 110;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 32.08555F;
            this.Date.HeaderText = "DAY";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 110;
            // 
            // socaudung
            // 
            this.socaudung.DataPropertyName = "socaudung";
            this.socaudung.FillWeight = 32.08555F;
            this.socaudung.HeaderText = "CORRECT";
            this.socaudung.MinimumWidth = 6;
            this.socaudung.Name = "socaudung";
            this.socaudung.ReadOnly = true;
            this.socaudung.Width = 105;
            // 
            // socausai
            // 
            this.socausai.DataPropertyName = "socausai";
            this.socausai.FillWeight = 32.08555F;
            this.socausai.HeaderText = "WRONG";
            this.socausai.MinimumWidth = 6;
            this.socausai.Name = "socausai";
            this.socausai.ReadOnly = true;
            this.socausai.Width = 105;
            // 
            // timetocomplete
            // 
            this.timetocomplete.DataPropertyName = "timetocomplete";
            this.timetocomplete.FillWeight = 32.08555F;
            this.timetocomplete.HeaderText = "TIME TO COMPLETE";
            this.timetocomplete.MinimumWidth = 6;
            this.timetocomplete.Name = "timetocomplete";
            this.timetocomplete.ReadOnly = true;
            this.timetocomplete.Width = 160;
            // 
            // Solanthi
            // 
            this.Solanthi.DataPropertyName = "Solanthi";
            this.Solanthi.FillWeight = 32.08555F;
            this.Solanthi.HeaderText = "TIMES";
            this.Solanthi.MinimumWidth = 6;
            this.Solanthi.Name = "Solanthi";
            this.Solanthi.ReadOnly = true;
            this.Solanthi.Width = 125;
            // 
            // MonTHI
            // 
            this.MonTHI.DataPropertyName = "MonTHI";
            this.MonTHI.FillWeight = 32.08555F;
            this.MonTHI.HeaderText = "TOPIC";
            this.MonTHI.MinimumWidth = 6;
            this.MonTHI.Name = "MonTHI";
            this.MonTHI.ReadOnly = true;
            this.MonTHI.Width = 105;
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.FillWeight = 32.08555F;
            this.MaDT.HeaderText = "CODE";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            this.MaDT.Width = 125;
            // 
            // txt_msv
            // 
            this.txt_msv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_msv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_msv.Location = new System.Drawing.Point(66, 28);
            this.txt_msv.Name = "txt_msv";
            this.txt_msv.Size = new System.Drawing.Size(110, 28);
            this.txt_msv.TabIndex = 10;
            // 
            // lbl_MSVstatic
            // 
            this.lbl_MSVstatic.AutoSize = true;
            this.lbl_MSVstatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbl_MSVstatic.Location = new System.Drawing.Point(110, 3);
            this.lbl_MSVstatic.Name = "lbl_MSVstatic";
            this.lbl_MSVstatic.Size = new System.Drawing.Size(59, 17);
            this.lbl_MSVstatic.TabIndex = 15;
            this.lbl_MSVstatic.Text = "lbl_MSV";
            this.lbl_MSVstatic.Visible = false;
            this.lbl_MSVstatic.Click += new System.EventHandler(this.lbl_MSVstatic_Click);
            // 
            // btn_xoalichsu
            // 
            this.btn_xoalichsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoalichsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoalichsu.FlatAppearance.BorderSize = 0;
            this.btn_xoalichsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoalichsu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xoalichsu.ForeColor = System.Drawing.Color.White;
            this.btn_xoalichsu.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoalichsu.Image")));
            this.btn_xoalichsu.Location = new System.Drawing.Point(1039, 3);
            this.btn_xoalichsu.Name = "btn_xoalichsu";
            this.btn_xoalichsu.Size = new System.Drawing.Size(192, 55);
            this.btn_xoalichsu.TabIndex = 17;
            this.btn_xoalichsu.Text = "Delete History";
            this.btn_xoalichsu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoalichsu.UseVisualStyleBackColor = false;
            this.btn_xoalichsu.Click += new System.EventHandler(this.btn_xoalichsu_Click);
            this.btn_xoalichsu.MouseCaptureChanged += new System.EventHandler(this.btn_xoalichsu_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1315, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tim.FlatAppearance.BorderSize = 0;
            this.btn_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ForeColor = System.Drawing.Color.Black;
            this.btn_tim.Image = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Search;
            this.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tim.Location = new System.Drawing.Point(201, 3);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(69, 61);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // panel_blank
            // 
            this.panel_blank.AllowDrop = true;
            this.panel_blank.BackColor = System.Drawing.Color.Gray;
            this.panel_blank.Location = new System.Drawing.Point(304, 42);
            this.panel_blank.Name = "panel_blank";
            this.panel_blank.Size = new System.Drawing.Size(737, 478);
            this.panel_blank.TabIndex = 18;
            this.panel_blank.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_blank_Paint);
            this.panel_blank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_blank_MouseDown);
            this.panel_blank.MouseLeave += new System.EventHandler(this.panel_blank_MouseLeave);
            this.panel_blank.MouseHover += new System.EventHandler(this.panel_blank_MouseHover);
            this.panel_blank.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_blank_MouseMove);
            this.panel_blank.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_blank_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_MSVstatic);
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.txt_msv);
            this.panel2.Controls.Add(this.btn_xoalichsu);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1518, 64);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "User :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel_blank);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(8, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 551);
            this.panel1.TabIndex = 19;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Search";
            this.Load += new System.EventHandler(this.Form_TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_msv;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_MSVstatic;
        private System.Windows.Forms.Button btn_xoalichsu;
        private System.Windows.Forms.Panel panel_blank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn socaudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn socausai;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetocomplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solanthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
    }
}