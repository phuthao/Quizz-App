
namespace TRACNGHIEMBYWINFORM
{
    partial class Form_Random
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Random));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_chude = new System.Windows.Forms.ComboBox();
            this.tbox_socau = new System.Windows.Forms.TextBox();
            this.btn_tao = new System.Windows.Forms.Button();
            this.btn_exportDA = new System.Windows.Forms.Button();
            this.datagridviewrandom = new System.Windows.Forms.DataGridView();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewrandom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topic :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // comboBox1_chude
            // 
            this.comboBox1_chude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1_chude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_chude.FormattingEnabled = true;
            this.comboBox1_chude.Location = new System.Drawing.Point(82, 59);
            this.comboBox1_chude.Name = "comboBox1_chude";
            this.comboBox1_chude.Size = new System.Drawing.Size(125, 28);
            this.comboBox1_chude.TabIndex = 2;
            this.comboBox1_chude.TextChanged += new System.EventHandler(this.comboBox1_chude_TextChanged);
            // 
            // tbox_socau
            // 
            this.tbox_socau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_socau.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_socau.Location = new System.Drawing.Point(112, 17);
            this.tbox_socau.Multiline = true;
            this.tbox_socau.Name = "tbox_socau";
            this.tbox_socau.Size = new System.Drawing.Size(52, 22);
            this.tbox_socau.TabIndex = 3;
            this.tbox_socau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_socau.MouseHover += new System.EventHandler(this.tbox_socau_MouseHover);
            // 
            // btn_tao
            // 
            this.btn_tao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tao.ForeColor = System.Drawing.Color.White;
            this.btn_tao.Image = ((System.Drawing.Image)(resources.GetObject("btn_tao.Image")));
            this.btn_tao.Location = new System.Drawing.Point(6, 156);
            this.btn_tao.Name = "btn_tao";
            this.btn_tao.Size = new System.Drawing.Size(201, 46);
            this.btn_tao.TabIndex = 4;
            this.btn_tao.Text = "CREATE";
            this.btn_tao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tao.UseVisualStyleBackColor = true;
            this.btn_tao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exportDA
            // 
            this.btn_exportDA.Enabled = false;
            this.btn_exportDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportDA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportDA.ForeColor = System.Drawing.Color.White;
            this.btn_exportDA.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportDA.Image")));
            this.btn_exportDA.Location = new System.Drawing.Point(3, 364);
            this.btn_exportDA.Name = "btn_exportDA";
            this.btn_exportDA.Size = new System.Drawing.Size(201, 46);
            this.btn_exportDA.TabIndex = 6;
            this.btn_exportDA.Text = "EXPORT TO EXCEL";
            this.btn_exportDA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exportDA.UseVisualStyleBackColor = true;
            this.btn_exportDA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // datagridviewrandom
            // 
            this.datagridviewrandom.AllowUserToAddRows = false;
            this.datagridviewrandom.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewrandom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewrandom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewrandom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.chude,
            this.DapAn,
            this.madt});
            this.datagridviewrandom.Location = new System.Drawing.Point(215, 32);
            this.datagridviewrandom.Name = "datagridviewrandom";
            this.datagridviewrandom.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagridviewrandom.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewrandom.RowTemplate.Height = 24;
            this.datagridviewrandom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewrandom.Size = new System.Drawing.Size(826, 649);
            this.datagridviewrandom.TabIndex = 7;
            // 
            // btn_xuat
            // 
            this.btn_xuat.Enabled = false;
            this.btn_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.ForeColor = System.Drawing.Color.White;
            this.btn_xuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_xuat.Image")));
            this.btn_xuat.Location = new System.Drawing.Point(6, 257);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(201, 46);
            this.btn_xuat.TabIndex = 8;
            this.btn_xuat.Text = "EXPORT PDF FILE";
            this.btn_xuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btn_test);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_xuat);
            this.panel1.Controls.Add(this.btn_exportDA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_tao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbox_socau);
            this.panel1.Controls.Add(this.comboBox1_chude);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 662);
            this.panel1.TabIndex = 9;
            // 
            // btn_test
            // 
            this.btn_test.Enabled = false;
            this.btn_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test.ForeColor = System.Drawing.Color.White;
            this.btn_test.Image = ((System.Drawing.Image)(resources.GetObject("btn_test.Image")));
            this.btn_test.Location = new System.Drawing.Point(3, 484);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(201, 46);
            this.btn_test.TabIndex = 9;
            this.btn_test.Text = "  DO TEST";
            this.btn_test.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(6, 597);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(201, 46);
            this.btn_home.TabIndex = 8;
            this.btn_home.Text = "  BACK";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "NUMBER";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 190;
            // 
            // chude
            // 
            this.chude.DataPropertyName = "chude";
            this.chude.HeaderText = "TOPIC";
            this.chude.MinimumWidth = 6;
            this.chude.Name = "chude";
            this.chude.Width = 190;
            // 
            // DapAn
            // 
            this.DapAn.DataPropertyName = "DapAn";
            this.DapAn.HeaderText = "ANSWER";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.Width = 190;
            // 
            // madt
            // 
            this.madt.DataPropertyName = "madt";
            this.madt.HeaderText = "CODE";
            this.madt.MinimumWidth = 6;
            this.madt.Name = "madt";
            this.madt.Width = 200;
            // 
            // Form_Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridviewrandom);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Random";
            this.Padding = new System.Windows.Forms.Padding(20, 64, 20, 21);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.RANDOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewrandom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_chude;
        private System.Windows.Forms.TextBox tbox_socau;
        private System.Windows.Forms.Button btn_tao;
        private System.Windows.Forms.Button btn_exportDA;
        private System.Windows.Forms.DataGridView datagridviewrandom;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn chude;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madt;
    }
}