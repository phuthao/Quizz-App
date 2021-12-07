namespace TRACNGHIEMBYWINFORM
{
    partial class form_DangKy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DangKy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_xacnhanpw = new System.Windows.Forms.TextBox();
            this.btn_dangky_dangky = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_checkuser = new System.Windows.Forms.Button();
            this.lbl_hover_re_pass = new System.Windows.Forms.Label();
            this.lbl_hover_pass = new System.Windows.Forms.Label();
            this.lbl_hover_email = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_username.Location = new System.Drawing.Point(392, 256);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(131, 25);
            this.txt_username.TabIndex = 2;
            // 
            // txt_pw
            // 
            this.txt_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_pw.Location = new System.Drawing.Point(392, 356);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(131, 25);
            this.txt_pw.TabIndex = 3;
            this.txt_pw.UseSystemPasswordChar = true;
            this.txt_pw.TextChanged += new System.EventHandler(this.txt_pw_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(193, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-Check Password :";
            // 
            // txt_xacnhanpw
            // 
            this.txt_xacnhanpw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_xacnhanpw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xacnhanpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_xacnhanpw.Location = new System.Drawing.Point(392, 413);
            this.txt_xacnhanpw.Name = "txt_xacnhanpw";
            this.txt_xacnhanpw.Size = new System.Drawing.Size(131, 25);
            this.txt_xacnhanpw.TabIndex = 5;
            this.txt_xacnhanpw.UseSystemPasswordChar = true;
            this.txt_xacnhanpw.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_dangky_dangky
            // 
            this.btn_dangky_dangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangky_dangky.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_dangky_dangky.ForeColor = System.Drawing.Color.White;
            this.btn_dangky_dangky.Location = new System.Drawing.Point(412, 461);
            this.btn_dangky_dangky.Name = "btn_dangky_dangky";
            this.btn_dangky_dangky.Size = new System.Drawing.Size(148, 35);
            this.btn_dangky_dangky.TabIndex = 6;
            this.btn_dangky_dangky.Text = "CONFIRM";
            this.btn_dangky_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky_dangky.Click += new System.EventHandler(this.btn_dangky_dangky_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(217, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(315, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email :";
            // 
            // tbox_email
            // 
            this.tbox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbox_email.Location = new System.Drawing.Point(392, 303);
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.Size = new System.Drawing.Size(181, 25);
            this.tbox_email.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(222, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 37);
            this.label5.TabIndex = 28;
            this.label5.Text = "SIGN UP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_checkuser
            // 
            this.btn_checkuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_checkuser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_checkuser.FlatAppearance.BorderSize = 0;
            this.btn_checkuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkuser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_checkuser.ForeColor = System.Drawing.Color.White;
            this.btn_checkuser.Image = ((System.Drawing.Image)(resources.GetObject("btn_checkuser.Image")));
            this.btn_checkuser.Location = new System.Drawing.Point(529, 247);
            this.btn_checkuser.Name = "btn_checkuser";
            this.btn_checkuser.Size = new System.Drawing.Size(44, 38);
            this.btn_checkuser.TabIndex = 29;
            this.btn_checkuser.UseVisualStyleBackColor = false;
            this.btn_checkuser.Click += new System.EventHandler(this.btn_checkuser_Click);
            this.btn_checkuser.MouseHover += new System.EventHandler(this.btn_checkuser_MouseHover);
            // 
            // lbl_hover_re_pass
            // 
            this.lbl_hover_re_pass.AutoSize = true;
            this.lbl_hover_re_pass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hover_re_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_hover_re_pass.Location = new System.Drawing.Point(546, 413);
            this.lbl_hover_re_pass.Name = "lbl_hover_re_pass";
            this.lbl_hover_re_pass.Size = new System.Drawing.Size(27, 34);
            this.lbl_hover_re_pass.TabIndex = 32;
            this.lbl_hover_re_pass.Text = "*";
            this.lbl_hover_re_pass.MouseHover += new System.EventHandler(this.lbl_hover_re_pass_MouseHover);
            // 
            // lbl_hover_pass
            // 
            this.lbl_hover_pass.AutoSize = true;
            this.lbl_hover_pass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hover_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_hover_pass.Location = new System.Drawing.Point(546, 356);
            this.lbl_hover_pass.Name = "lbl_hover_pass";
            this.lbl_hover_pass.Size = new System.Drawing.Size(27, 34);
            this.lbl_hover_pass.TabIndex = 31;
            this.lbl_hover_pass.Text = "*";
            this.lbl_hover_pass.MouseHover += new System.EventHandler(this.lbl_hover_pass_MouseHover);
            // 
            // lbl_hover_email
            // 
            this.lbl_hover_email.AutoSize = true;
            this.lbl_hover_email.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hover_email.ForeColor = System.Drawing.Color.White;
            this.lbl_hover_email.Location = new System.Drawing.Point(588, 303);
            this.lbl_hover_email.Name = "lbl_hover_email";
            this.lbl_hover_email.Size = new System.Drawing.Size(27, 34);
            this.lbl_hover_email.TabIndex = 30;
            this.lbl_hover_email.Text = "*";
            this.lbl_hover_email.MouseHover += new System.EventHandler(this.lbl_hover_email_MouseHover);
            // 
            // form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.lbl_hover_re_pass);
            this.Controls.Add(this.lbl_hover_pass);
            this.Controls.Add(this.lbl_hover_email);
            this.Controls.Add(this.btn_checkuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbox_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_dangky_dangky);
            this.Controls.Add(this.txt_xacnhanpw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_DangKy";
            this.Load += new System.EventHandler(this.form_DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_xacnhanpw;
        private System.Windows.Forms.Button btn_dangky_dangky;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_checkuser;
        private System.Windows.Forms.Label lbl_hover_re_pass;
        private System.Windows.Forms.Label lbl_hover_pass;
        private System.Windows.Forms.Label lbl_hover_email;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}