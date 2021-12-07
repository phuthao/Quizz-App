
namespace TRACNGHIEMBYWINFORM
{
    partial class UC_control_Account
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_control_Account));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupbox_question = new System.Windows.Forms.GroupBox();
            this.cbox_delete = new System.Windows.Forms.CheckBox();
            this.cbox_import = new System.Windows.Forms.CheckBox();
            this.cbox_edit = new System.Windows.Forms.CheckBox();
            this.cbox_upload = new System.Windows.Forms.CheckBox();
            this.cbox_add = new System.Windows.Forms.CheckBox();
            this.groupbox_allow = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_questionfunction = new System.Windows.Forms.CheckBox();
            this.cbox_allow_document = new System.Windows.Forms.CheckBox();
            this.cbox_allow_account = new System.Windows.Forms.CheckBox();
            this.cbox_allow_history = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbox_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_msv = new System.Windows.Forms.TextBox();
            this.tbox_dob = new System.Windows.Forms.TextBox();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupbox_question.SuspendLayout();
            this.groupbox_allow.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MSV";
            this.Column1.HeaderText = "User";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name";
            this.Column4.HeaderText = "Full Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "phone";
            this.Column5.HeaderText = "Phone";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dayofbirth";
            this.Column6.HeaderText = "Day Of Birth";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 145;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 165;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Image";
            this.Column2.HeaderText = "Image";
            this.Column2.Image = ((System.Drawing.Image)(resources.GetObject("Column2.Image")));
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(163, 216);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(148, 43);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Add";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(577, 215);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(148, 43);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Delete";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.groupbox_question);
            this.panel1.Controls.Add(this.groupbox_allow);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pic_avatar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 571);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // groupbox_question
            // 
            this.groupbox_question.AutoSize = true;
            this.groupbox_question.Controls.Add(this.cbox_delete);
            this.groupbox_question.Controls.Add(this.cbox_import);
            this.groupbox_question.Controls.Add(this.cbox_edit);
            this.groupbox_question.Controls.Add(this.cbox_upload);
            this.groupbox_question.Controls.Add(this.cbox_add);
            this.groupbox_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox_question.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_question.Location = new System.Drawing.Point(735, 164);
            this.groupbox_question.Name = "groupbox_question";
            this.groupbox_question.Size = new System.Drawing.Size(258, 90);
            this.groupbox_question.TabIndex = 8;
            this.groupbox_question.TabStop = false;
            this.groupbox_question.Visible = false;
            // 
            // cbox_delete
            // 
            this.cbox_delete.AutoSize = true;
            this.cbox_delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_delete.Location = new System.Drawing.Point(172, 14);
            this.cbox_delete.Name = "cbox_delete";
            this.cbox_delete.Size = new System.Drawing.Size(80, 24);
            this.cbox_delete.TabIndex = 26;
            this.cbox_delete.Text = "Delete";
            this.cbox_delete.UseVisualStyleBackColor = true;
            this.cbox_delete.CheckedChanged += new System.EventHandler(this.cbox_delete_CheckedChanged);
            // 
            // cbox_import
            // 
            this.cbox_import.AutoSize = true;
            this.cbox_import.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_import.Location = new System.Drawing.Point(91, 44);
            this.cbox_import.Name = "cbox_import";
            this.cbox_import.Size = new System.Drawing.Size(79, 24);
            this.cbox_import.TabIndex = 25;
            this.cbox_import.Text = "Import";
            this.cbox_import.UseVisualStyleBackColor = true;
            this.cbox_import.CheckedChanged += new System.EventHandler(this.cbox_import_CheckedChanged);
            // 
            // cbox_edit
            // 
            this.cbox_edit.AutoSize = true;
            this.cbox_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_edit.Location = new System.Drawing.Point(91, 14);
            this.cbox_edit.Name = "cbox_edit";
            this.cbox_edit.Size = new System.Drawing.Size(57, 24);
            this.cbox_edit.TabIndex = 25;
            this.cbox_edit.Text = "Edit";
            this.cbox_edit.UseVisualStyleBackColor = true;
            this.cbox_edit.CheckedChanged += new System.EventHandler(this.cbox_edit_CheckedChanged);
            // 
            // cbox_upload
            // 
            this.cbox_upload.AutoSize = true;
            this.cbox_upload.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_upload.Location = new System.Drawing.Point(6, 44);
            this.cbox_upload.Name = "cbox_upload";
            this.cbox_upload.Size = new System.Drawing.Size(85, 24);
            this.cbox_upload.TabIndex = 24;
            this.cbox_upload.Text = "Upload";
            this.cbox_upload.UseVisualStyleBackColor = true;
            this.cbox_upload.CheckedChanged += new System.EventHandler(this.cbox_upload_CheckedChanged);
            // 
            // cbox_add
            // 
            this.cbox_add.AutoSize = true;
            this.cbox_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_add.Location = new System.Drawing.Point(6, 14);
            this.cbox_add.Name = "cbox_add";
            this.cbox_add.Size = new System.Drawing.Size(62, 24);
            this.cbox_add.TabIndex = 24;
            this.cbox_add.Text = "Add";
            this.cbox_add.UseVisualStyleBackColor = true;
            this.cbox_add.CheckedChanged += new System.EventHandler(this.cbox_add_CheckedChanged);
            // 
            // groupbox_allow
            // 
            this.groupbox_allow.Controls.Add(this.label8);
            this.groupbox_allow.Controls.Add(this.cbox_questionfunction);
            this.groupbox_allow.Controls.Add(this.cbox_allow_document);
            this.groupbox_allow.Controls.Add(this.cbox_allow_account);
            this.groupbox_allow.Controls.Add(this.cbox_allow_history);
            this.groupbox_allow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_allow.Location = new System.Drawing.Point(725, 5);
            this.groupbox_allow.Name = "groupbox_allow";
            this.groupbox_allow.Size = new System.Drawing.Size(281, 270);
            this.groupbox_allow.TabIndex = 24;
            this.groupbox_allow.TabStop = false;
            this.groupbox_allow.Text = "Permission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(36, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Question Function";
            // 
            // cbox_questionfunction
            // 
            this.cbox_questionfunction.AutoSize = true;
            this.cbox_questionfunction.Location = new System.Drawing.Point(19, 137);
            this.cbox_questionfunction.Name = "cbox_questionfunction";
            this.cbox_questionfunction.Size = new System.Drawing.Size(18, 17);
            this.cbox_questionfunction.TabIndex = 8;
            this.cbox_questionfunction.UseVisualStyleBackColor = true;
            this.cbox_questionfunction.CheckedChanged += new System.EventHandler(this.cbox_questionfunction_CheckedChanged);
            // 
            // cbox_allow_document
            // 
            this.cbox_allow_document.AutoSize = true;
            this.cbox_allow_document.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_allow_document.Location = new System.Drawing.Point(19, 30);
            this.cbox_allow_document.Name = "cbox_allow_document";
            this.cbox_allow_document.Size = new System.Drawing.Size(136, 27);
            this.cbox_allow_document.TabIndex = 21;
            this.cbox_allow_document.Text = "Document";
            this.cbox_allow_document.UseVisualStyleBackColor = true;
            this.cbox_allow_document.CheckedChanged += new System.EventHandler(this.cbox_allow_document_CheckedChanged);
            // 
            // cbox_allow_account
            // 
            this.cbox_allow_account.AutoSize = true;
            this.cbox_allow_account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_allow_account.Location = new System.Drawing.Point(19, 101);
            this.cbox_allow_account.Name = "cbox_allow_account";
            this.cbox_allow_account.Size = new System.Drawing.Size(195, 27);
            this.cbox_allow_account.TabIndex = 23;
            this.cbox_allow_account.Text = "Account Control";
            this.cbox_allow_account.UseVisualStyleBackColor = true;
            this.cbox_allow_account.CheckedChanged += new System.EventHandler(this.cbox_allow_account_CheckedChanged);
            // 
            // cbox_allow_history
            // 
            this.cbox_allow_history.AutoSize = true;
            this.cbox_allow_history.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_allow_history.Location = new System.Drawing.Point(19, 68);
            this.cbox_allow_history.Name = "cbox_allow_history";
            this.cbox_allow_history.Size = new System.Drawing.Size(94, 27);
            this.cbox_allow_history.TabIndex = 22;
            this.cbox_allow_history.Text = "History";
            this.cbox_allow_history.UseVisualStyleBackColor = true;
            this.cbox_allow_history.CheckedChanged += new System.EventHandler(this.cbox_allow_history_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbox_email);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbox_name);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbox_phone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbox_msv);
            this.panel3.Controls.Add(this.tbox_dob);
            this.panel3.Location = new System.Drawing.Point(292, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 269);
            this.panel3.TabIndex = 20;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // tbox_email
            // 
            this.tbox_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbox_email.Location = new System.Drawing.Point(151, 218);
            this.tbox_email.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.Size = new System.Drawing.Size(250, 21);
            this.tbox_email.TabIndex = 16;
            this.tbox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email :";
            // 
            // tbox_name
            // 
            this.tbox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbox_name.Location = new System.Drawing.Point(151, 68);
            this.tbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(180, 21);
            this.tbox_name.TabIndex = 5;
            this.tbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(60, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day of Birth :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User :";
            // 
            // tbox_phone
            // 
            this.tbox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_phone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbox_phone.Location = new System.Drawing.Point(151, 165);
            this.tbox_phone.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_phone.Name = "tbox_phone";
            this.tbox_phone.Size = new System.Drawing.Size(150, 21);
            this.tbox_phone.TabIndex = 8;
            this.tbox_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // tbox_msv
            // 
            this.tbox_msv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_msv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_msv.Enabled = false;
            this.tbox_msv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_msv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbox_msv.Location = new System.Drawing.Point(151, 29);
            this.tbox_msv.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_msv.Name = "tbox_msv";
            this.tbox_msv.Size = new System.Drawing.Size(150, 21);
            this.tbox_msv.TabIndex = 7;
            this.tbox_msv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_dob
            // 
            this.tbox_dob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_dob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_dob.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_dob.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbox_dob.Location = new System.Drawing.Point(158, 118);
            this.tbox_dob.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_dob.Name = "tbox_dob";
            this.tbox_dob.Size = new System.Drawing.Size(143, 21);
            this.tbox_dob.TabIndex = 6;
            this.tbox_dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_avatar
            // 
            this.pic_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_avatar.Location = new System.Drawing.Point(46, 34);
            this.pic_avatar.Margin = new System.Windows.Forms.Padding(4);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(238, 208);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 19;
            this.pic_avatar.TabStop = false;
            this.pic_avatar.Click += new System.EventHandler(this.pic_avatar_Click);
            this.pic_avatar.MouseHover += new System.EventHandler(this.pic_avatar_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 288);
            this.panel2.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(783, 215);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(148, 43);
            this.btn_close.TabIndex = 29;
            this.btn_close.Text = "Home";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(368, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_control_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_control_Account";
            this.Size = new System.Drawing.Size(1152, 571);
            this.Load += new System.EventHandler(this.UC_ControlAccont_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UC_control_Account_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupbox_question.ResumeLayout(false);
            this.groupbox_question.PerformLayout();
            this.groupbox_allow.ResumeLayout(false);
            this.groupbox_allow.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_msv;
        private System.Windows.Forms.TextBox tbox_dob;
        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_email;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbox_allow_account;
        private System.Windows.Forms.CheckBox cbox_allow_history;
        private System.Windows.Forms.CheckBox cbox_allow_document;
        private System.Windows.Forms.GroupBox groupbox_allow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupbox_question;
        private System.Windows.Forms.CheckBox cbox_questionfunction;
        private System.Windows.Forms.CheckBox cbox_delete;
        private System.Windows.Forms.CheckBox cbox_edit;
        private System.Windows.Forms.CheckBox cbox_add;
        private System.Windows.Forms.CheckBox cbox_import;
        private System.Windows.Forms.CheckBox cbox_upload;
    }
}
