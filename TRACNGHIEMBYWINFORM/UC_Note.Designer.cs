
namespace TRACNGHIEMBYWINFORM
{
    partial class UC_Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Note));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbox_selection_comment = new MetroFramework.Controls.MetroComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.tbox_note = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbox_made = new System.Windows.Forms.TextBox();
            this.tbox_monthi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbox_date = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_selection_comment
            // 
            this.cbox_selection_comment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbox_selection_comment.FormattingEnabled = true;
            this.cbox_selection_comment.ItemHeight = 24;
            this.cbox_selection_comment.Location = new System.Drawing.Point(71, 3);
            this.cbox_selection_comment.Name = "cbox_selection_comment";
            this.cbox_selection_comment.Size = new System.Drawing.Size(229, 30);
            this.cbox_selection_comment.TabIndex = 4;
            this.cbox_selection_comment.UseSelectable = true;
            this.cbox_selection_comment.SelectedIndexChanged += new System.EventHandler(this.cbox_selection_comment_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(62, 34);
            this.btn_close.TabIndex = 7;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_lamlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_lamlai.FlatAppearance.BorderSize = 0;
            this.btn_lamlai.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamlai.ForeColor = System.Drawing.Color.White;
            this.btn_lamlai.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamlai.Image")));
            this.btn_lamlai.Location = new System.Drawing.Point(559, 105);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(139, 52);
            this.btn_lamlai.TabIndex = 8;
            this.btn_lamlai.Text = "Re-Test";
            this.btn_lamlai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lamlai.UseVisualStyleBackColor = false;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.btn_fresh);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.cbox_selection_comment);
            this.panel3.Location = new System.Drawing.Point(5, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 38);
            this.panel3.TabIndex = 11;
            // 
            // btn_fresh
            // 
            this.btn_fresh.FlatAppearance.BorderSize = 0;
            this.btn_fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_fresh.Image")));
            this.btn_fresh.Location = new System.Drawing.Point(306, 3);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(39, 31);
            this.btn_fresh.TabIndex = 5;
            this.btn_fresh.UseVisualStyleBackColor = true;
            this.btn_fresh.Click += new System.EventHandler(this.btn_fresh_Click);
            // 
            // tbox_note
            // 
            this.tbox_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_note.Location = new System.Drawing.Point(25, 46);
            this.tbox_note.Name = "tbox_note";
            this.tbox_note.ReadOnly = true;
            this.tbox_note.Size = new System.Drawing.Size(332, 193);
            this.tbox_note.TabIndex = 12;
            this.tbox_note.Text = "";
            this.tbox_note.MouseHover += new System.EventHandler(this.tbox_note_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(435, 197);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // question
            // 
            this.question.DataPropertyName = "Cau";
            this.question.HeaderText = "Question";
            this.question.MinimumWidth = 6;
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.question.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDT";
            this.Column2.HeaderText = "Code";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DapAn";
            this.Column3.HeaderText = "Answer";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Your_DapAn";
            this.Column4.HeaderText = "Your Answer";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 236);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(788, 274);
            this.axAcroPDF1.TabIndex = 13;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter_2);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.Location = new System.Drawing.Point(593, 18);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 21);
            this.metroToggle1.TabIndex = 4;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.Controls.Add(this.metroToggle2);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.tbox_note);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(788, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 510);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Checked = true;
            this.metroToggle2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle2.Location = new System.Drawing.Point(145, 19);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 21);
            this.metroToggle2.TabIndex = 18;
            this.metroToggle2.Text = "On";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.metroToggle2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbox_made);
            this.panel2.Controls.Add(this.tbox_monthi);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbox_date);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(5, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 218);
            this.panel2.TabIndex = 17;
            // 
            // tbox_made
            // 
            this.tbox_made.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_made.Enabled = false;
            this.tbox_made.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_made.Location = new System.Drawing.Point(86, 142);
            this.tbox_made.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_made.Name = "tbox_made";
            this.tbox_made.ReadOnly = true;
            this.tbox_made.Size = new System.Drawing.Size(95, 27);
            this.tbox_made.TabIndex = 30;
            this.tbox_made.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_monthi
            // 
            this.tbox_monthi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_monthi.Enabled = false;
            this.tbox_monthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_monthi.Location = new System.Drawing.Point(86, 88);
            this.tbox_monthi.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_monthi.Name = "tbox_monthi";
            this.tbox_monthi.ReadOnly = true;
            this.tbox_monthi.Size = new System.Drawing.Size(177, 27);
            this.tbox_monthi.TabIndex = 31;
            this.tbox_monthi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Code :";
            // 
            // tbox_date
            // 
            this.tbox_date.Enabled = false;
            this.tbox_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_date.Location = new System.Drawing.Point(86, 32);
            this.tbox_date.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_date.Name = "tbox_date";
            this.tbox_date.ReadOnly = true;
            this.tbox_date.Size = new System.Drawing.Size(177, 27);
            this.tbox_date.TabIndex = 26;
            this.tbox_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Subject :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Date :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 197);
            this.panel5.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel7.Controls.Add(this.btn_lamlai);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(798, 510);
            this.panel7.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.metroToggle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 42);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UC_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Name = "UC_Note";
            this.Size = new System.Drawing.Size(798, 510);
            this.Load += new System.EventHandler(this.UC_Note_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbox_selection_comment;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_lamlai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox tbox_note;
        private System.Windows.Forms.Button btn_fresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbox_made;
        private System.Windows.Forms.TextBox tbox_monthi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbox_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
    }
}
