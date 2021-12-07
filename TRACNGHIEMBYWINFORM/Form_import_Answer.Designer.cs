
namespace TRACNGHIEMBYWINFORM
{
    partial class Form_import_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_import_Answer));
            this.btn_import = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_Sheet = new System.Windows.Forms.ComboBox();
            this.txt_File = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_browse = new System.Windows.Forms.Button();
            this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANSWER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_import.Location = new System.Drawing.Point(289, 59);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(103, 43);
            this.btn_import.TabIndex = 13;
            this.btn_import.Text = "Add ";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Path";
            // 
            // cbox_Sheet
            // 
            this.cbox_Sheet.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Sheet.FormattingEnabled = true;
            this.cbox_Sheet.Location = new System.Drawing.Point(138, 67);
            this.cbox_Sheet.Name = "cbox_Sheet";
            this.cbox_Sheet.Size = new System.Drawing.Size(130, 29);
            this.cbox_Sheet.TabIndex = 11;
            this.cbox_Sheet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_File
            // 
            this.txt_File.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_File.Location = new System.Drawing.Point(138, 25);
            this.txt_File.Name = "txt_File";
            this.txt_File.ReadOnly = true;
            this.txt_File.Size = new System.Drawing.Size(432, 28);
            this.txt_File.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sheet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMBER,
            this.TOPIC,
            this.CODE,
            this.ANSWER});
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 296);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.cbox_Sheet);
            this.panel1.Controls.Add(this.btn_import);
            this.panel1.Controls.Add(this.txt_File);
            this.panel1.Controls.Add(this.btn_browse);
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 14;
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse.Image")));
            this.btn_browse.Location = new System.Drawing.Point(592, 15);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(58, 46);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // NUMBER
            // 
            this.NUMBER.DataPropertyName = "NUMBER";
            this.NUMBER.HeaderText = "NUMBER";
            this.NUMBER.MinimumWidth = 6;
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.ReadOnly = true;
            this.NUMBER.Width = 125;
            // 
            // TOPIC
            // 
            this.TOPIC.DataPropertyName = "TOPIC";
            this.TOPIC.HeaderText = "TOPIC";
            this.TOPIC.MinimumWidth = 6;
            this.TOPIC.Name = "TOPIC";
            this.TOPIC.ReadOnly = true;
            this.TOPIC.Width = 125;
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "CODE";
            this.CODE.MinimumWidth = 6;
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            this.CODE.Width = 125;
            // 
            // ANSWER
            // 
            this.ANSWER.DataPropertyName = "ANSWER";
            this.ANSWER.HeaderText = "ANSWER";
            this.ANSWER.MinimumWidth = 6;
            this.ANSWER.Name = "ANSWER";
            this.ANSWER.ReadOnly = true;
            this.ANSWER.Width = 125;
            // 
            // Form_import_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Enabled = false;
            this.Name = "Form_import_Answer";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_import_Dapan_FormClosing);
            this.Load += new System.EventHandler(this.ImportForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_Sheet;
        private System.Windows.Forms.TextBox txt_File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANSWER;
    }
}