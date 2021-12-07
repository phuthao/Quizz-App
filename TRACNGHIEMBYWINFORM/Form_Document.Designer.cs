namespace TRACNGHIEMBYWINFORM
{
    partial class Form_Document
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Document));
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapanA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapanB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapanD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_trondethi = new System.Windows.Forms.Button();
            this.btn_lamde = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rabtn_hard = new System.Windows.Forms.RadioButton();
            this.rabtn_easy = new System.Windows.Forms.RadioButton();
            this.rabtn_medium = new System.Windows.Forms.RadioButton();
            this.cbox_advanced = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_timkiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(97, 8);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(102, 29);
            this.txt_timkiem.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 25);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madt,
            this.chude,
            this.cau,
            this.noidung,
            this.dapanA,
            this.dapanB,
            this.dapanC,
            this.dapanD,
            this.STT,
            this.DapAn});
            this.dataGridView1.Location = new System.Drawing.Point(2, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1317, 432);
            this.dataGridView1.TabIndex = 10;
            // 
            // madt
            // 
            this.madt.DataPropertyName = "madt";
            this.madt.HeaderText = "Code";
            this.madt.MinimumWidth = 6;
            this.madt.Name = "madt";
            this.madt.ReadOnly = true;
            this.madt.Width = 80;
            // 
            // chude
            // 
            this.chude.DataPropertyName = "chude";
            this.chude.HeaderText = "Topic";
            this.chude.MinimumWidth = 6;
            this.chude.Name = "chude";
            this.chude.ReadOnly = true;
            this.chude.Width = 80;
            // 
            // cau
            // 
            this.cau.DataPropertyName = "cau";
            this.cau.HeaderText = "Question";
            this.cau.MinimumWidth = 6;
            this.cau.Name = "cau";
            this.cau.ReadOnly = true;
            this.cau.Width = 90;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Content";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            this.noidung.Width = 280;
            // 
            // dapanA
            // 
            this.dapanA.DataPropertyName = "dapanA";
            this.dapanA.HeaderText = "A";
            this.dapanA.MinimumWidth = 6;
            this.dapanA.Name = "dapanA";
            this.dapanA.ReadOnly = true;
            this.dapanA.Width = 110;
            // 
            // dapanB
            // 
            this.dapanB.DataPropertyName = "dapanB";
            this.dapanB.HeaderText = "B";
            this.dapanB.MinimumWidth = 6;
            this.dapanB.Name = "dapanB";
            this.dapanB.ReadOnly = true;
            this.dapanB.Width = 110;
            // 
            // dapanC
            // 
            this.dapanC.DataPropertyName = "dapanC";
            this.dapanC.HeaderText = "C";
            this.dapanC.MinimumWidth = 6;
            this.dapanC.Name = "dapanC";
            this.dapanC.ReadOnly = true;
            this.dapanC.Width = 110;
            // 
            // dapanD
            // 
            this.dapanD.DataPropertyName = "dapanD";
            this.dapanD.HeaderText = "D";
            this.dapanD.MinimumWidth = 6;
            this.dapanD.Name = "dapanD";
            this.dapanD.ReadOnly = true;
            this.dapanD.Width = 110;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "Index";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 80;
            // 
            // DapAn
            // 
            this.DapAn.DataPropertyName = "DapAn";
            this.DapAn.HeaderText = "Result";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.ReadOnly = true;
            this.DapAn.Width = 80;
            // 
            // btn_import
            // 
            this.btn_import.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_import.Enabled = false;
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Image = ((System.Drawing.Image)(resources.GetObject("btn_import.Image")));
            this.btn_import.Location = new System.Drawing.Point(555, 564);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(228, 57);
            this.btn_import.TabIndex = 11;
            this.btn_import.Text = "EXPORT ANSWER";
            this.btn_import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.button2_Click_1);
            this.btn_import.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btn_trondethi
            // 
            this.btn_trondethi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trondethi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_trondethi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_trondethi.FlatAppearance.BorderSize = 0;
            this.btn_trondethi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trondethi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trondethi.ForeColor = System.Drawing.Color.White;
            this.btn_trondethi.Image = ((System.Drawing.Image)(resources.GetObject("btn_trondethi.Image")));
            this.btn_trondethi.Location = new System.Drawing.Point(939, 8);
            this.btn_trondethi.Name = "btn_trondethi";
            this.btn_trondethi.Size = new System.Drawing.Size(186, 57);
            this.btn_trondethi.TabIndex = 9;
            this.btn_trondethi.Text = "Random";
            this.btn_trondethi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_trondethi.UseVisualStyleBackColor = false;
            this.btn_trondethi.Click += new System.EventHandler(this.btn_trondethi_Click);
            // 
            // btn_lamde
            // 
            this.btn_lamde.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_lamde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_lamde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_lamde.Enabled = false;
            this.btn_lamde.FlatAppearance.BorderSize = 0;
            this.btn_lamde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lamde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamde.ForeColor = System.Drawing.Color.White;
            this.btn_lamde.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamde.Image")));
            this.btn_lamde.Location = new System.Drawing.Point(827, 564);
            this.btn_lamde.Name = "btn_lamde";
            this.btn_lamde.Size = new System.Drawing.Size(228, 57);
            this.btn_lamde.TabIndex = 7;
            this.btn_lamde.Text = "   DO TEST";
            this.btn_lamde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lamde.UseVisualStyleBackColor = false;
            this.btn_lamde.Click += new System.EventHandler(this.button2_Click);
            this.btn_lamde.MouseHover += new System.EventHandler(this.btn_lamde_MouseHover);
            // 
            // btn_export
            // 
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Image = global::TRACNGHIEMBYWINFORM.Properties.Resources.Graphicloads_Filetype_Word_doc;
            this.btn_export.Location = new System.Drawing.Point(299, 564);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(228, 57);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "EXPORT FILE ";
            this.btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            this.btn_export.MouseHover += new System.EventHandler(this.btn_export_MouseHover);
            // 
            // btn_tim
            // 
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tim.FlatAppearance.BorderSize = 0;
            this.btn_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ForeColor = System.Drawing.Color.White;
            this.btn_tim.Image = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Search;
            this.btn_tim.Location = new System.Drawing.Point(224, 7);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(63, 54);
            this.btn_tim.TabIndex = 0;
            this.btn_tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.rabtn_hard);
            this.panel1.Controls.Add(this.rabtn_easy);
            this.panel1.Controls.Add(this.rabtn_medium);
            this.panel1.Controls.Add(this.cbox_advanced);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_tim);
            this.panel1.Controls.Add(this.btn_trondethi);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 71);
            this.panel1.TabIndex = 17;
            // 
            // rabtn_hard
            // 
            this.rabtn_hard.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtn_hard.Location = new System.Drawing.Point(525, 35);
            this.rabtn_hard.Name = "rabtn_hard";
            this.rabtn_hard.Size = new System.Drawing.Size(87, 23);
            this.rabtn_hard.TabIndex = 31;
            this.rabtn_hard.TabStop = true;
            this.rabtn_hard.Text = "Hard";
            this.rabtn_hard.UseVisualStyleBackColor = true;
            this.rabtn_hard.CheckedChanged += new System.EventHandler(this.rabtn_hard_CheckedChanged);
            // 
            // rabtn_easy
            // 
            this.rabtn_easy.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtn_easy.Location = new System.Drawing.Point(320, 32);
            this.rabtn_easy.Name = "rabtn_easy";
            this.rabtn_easy.Size = new System.Drawing.Size(81, 31);
            this.rabtn_easy.TabIndex = 18;
            this.rabtn_easy.TabStop = true;
            this.rabtn_easy.Text = "Easy";
            this.rabtn_easy.UseVisualStyleBackColor = true;
            this.rabtn_easy.CheckedChanged += new System.EventHandler(this.rabtn_easy_CheckedChanged);
            // 
            // rabtn_medium
            // 
            this.rabtn_medium.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtn_medium.Location = new System.Drawing.Point(407, 35);
            this.rabtn_medium.Name = "rabtn_medium";
            this.rabtn_medium.Size = new System.Drawing.Size(96, 24);
            this.rabtn_medium.TabIndex = 20;
            this.rabtn_medium.TabStop = true;
            this.rabtn_medium.Text = "Medium";
            this.rabtn_medium.UseVisualStyleBackColor = true;
            this.rabtn_medium.CheckedChanged += new System.EventHandler(this.rabtn_medium_CheckedChanged);
            // 
            // cbox_advanced
            // 
            this.cbox_advanced.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_advanced.ForeColor = System.Drawing.Color.Black;
            this.cbox_advanced.Location = new System.Drawing.Point(398, 8);
            this.cbox_advanced.Name = "cbox_advanced";
            this.cbox_advanced.Size = new System.Drawing.Size(138, 24);
            this.cbox_advanced.TabIndex = 21;
            this.cbox_advanced.Text = "Advanced";
            this.cbox_advanced.UseVisualStyleBackColor = true;
            this.cbox_advanced.CheckedChanged += new System.EventHandler(this.cbox_advanced_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Code :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Subject :";
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(1131, 10);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(186, 46);
            this.btn_home.TabIndex = 15;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.White;
            this.lbl_1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_1.Image")));
            this.lbl_1.Location = new System.Drawing.Point(405, 552);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(21, 19);
            this.lbl_1.TabIndex = 31;
            this.lbl_1.Text = "   ";
            this.lbl_1.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.Color.White;
            this.lbl_2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_2.Image")));
            this.lbl_2.Location = new System.Drawing.Point(661, 552);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(17, 19);
            this.lbl_2.TabIndex = 32;
            this.lbl_2.Text = "  ";
            this.lbl_2.Visible = false;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.Color.White;
            this.lbl_3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_3.Image")));
            this.lbl_3.Location = new System.Drawing.Point(932, 552);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(17, 19);
            this.lbl_3.TabIndex = 33;
            this.lbl_3.Text = "  ";
            this.lbl_3.Visible = false;
            // 
            // Form_Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 632);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_lamde);
            this.Controls.Add(this.btn_export);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Document";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.FormDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_lamde;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_trondethi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbox_advanced;
        private System.Windows.Forms.RadioButton rabtn_easy;
        private System.Windows.Forms.RadioButton rabtn_medium;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.RadioButton rabtn_hard;
        private System.Windows.Forms.DataGridViewTextBoxColumn madt;
        private System.Windows.Forms.DataGridViewTextBoxColumn chude;
        private System.Windows.Forms.DataGridViewTextBoxColumn cau;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapanA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapanB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapanD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
    }
}