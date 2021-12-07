
namespace TRACNGHIEMBYWINFORM
{
    partial class UC_reset_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_reset_Password));
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.tbox_confirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_newpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_currentpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_hover_currentpass = new System.Windows.Forms.Label();
            this.lbl_hover_newpass = new System.Windows.Forms.Label();
            this.lbl_recheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(425, 449);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(148, 35);
            this.btn_xacnhan.TabIndex = 1;
            this.btn_xacnhan.Text = "CONFIRM";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // tbox_confirm
            // 
            this.tbox_confirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_confirm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbox_confirm.Location = new System.Drawing.Point(380, 383);
            this.tbox_confirm.Name = "tbox_confirm";
            this.tbox_confirm.Size = new System.Drawing.Size(131, 21);
            this.tbox_confirm.TabIndex = 23;
            this.tbox_confirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(140, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Re-check Your Password :";
            // 
            // tbox_newpass
            // 
            this.tbox_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_newpass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_newpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbox_newpass.Location = new System.Drawing.Point(380, 334);
            this.tbox_newpass.Name = "tbox_newpass";
            this.tbox_newpass.Size = new System.Drawing.Size(131, 21);
            this.tbox_newpass.TabIndex = 21;
            this.tbox_newpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Password :";
            // 
            // tbox_currentpassword
            // 
            this.tbox_currentpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_currentpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_currentpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbox_currentpassword.Location = new System.Drawing.Point(380, 288);
            this.tbox_currentpassword.Name = "tbox_currentpassword";
            this.tbox_currentpassword.PasswordChar = '*';
            this.tbox_currentpassword.Size = new System.Drawing.Size(131, 21);
            this.tbox_currentpassword.TabIndex = 19;
            this.tbox_currentpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(199, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Current Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "RESET YOUR PASSWORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hover_currentpass
            // 
            this.lbl_hover_currentpass.AutoSize = true;
            this.lbl_hover_currentpass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hover_currentpass.ForeColor = System.Drawing.Color.White;
            this.lbl_hover_currentpass.Location = new System.Drawing.Point(517, 288);
            this.lbl_hover_currentpass.Name = "lbl_hover_currentpass";
            this.lbl_hover_currentpass.Size = new System.Drawing.Size(27, 34);
            this.lbl_hover_currentpass.TabIndex = 28;
            this.lbl_hover_currentpass.Text = "*";
            this.lbl_hover_currentpass.MouseHover += new System.EventHandler(this.lbl_hover_currentpass_MouseHover);
            // 
            // lbl_hover_newpass
            // 
            this.lbl_hover_newpass.AutoSize = true;
            this.lbl_hover_newpass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hover_newpass.ForeColor = System.Drawing.Color.White;
            this.lbl_hover_newpass.Location = new System.Drawing.Point(517, 334);
            this.lbl_hover_newpass.Name = "lbl_hover_newpass";
            this.lbl_hover_newpass.Size = new System.Drawing.Size(27, 34);
            this.lbl_hover_newpass.TabIndex = 29;
            this.lbl_hover_newpass.Text = "*";
            this.lbl_hover_newpass.MouseHover += new System.EventHandler(this.lbl_hover_newpass_MouseHover);
            // 
            // lbl_recheck
            // 
            this.lbl_recheck.AutoSize = true;
            this.lbl_recheck.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recheck.ForeColor = System.Drawing.Color.White;
            this.lbl_recheck.Location = new System.Drawing.Point(517, 383);
            this.lbl_recheck.Name = "lbl_recheck";
            this.lbl_recheck.Size = new System.Drawing.Size(27, 34);
            this.lbl_recheck.TabIndex = 30;
            this.lbl_recheck.Text = "*";
            this.lbl_recheck.MouseHover += new System.EventHandler(this.lbl_recheck_MouseHover);
            // 
            // UC_reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.lbl_recheck);
            this.Controls.Add(this.lbl_hover_newpass);
            this.Controls.Add(this.lbl_hover_currentpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbox_confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_newpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_currentpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xacnhan);
            this.Name = "UC_reset_Password";
            this.Size = new System.Drawing.Size(750, 530);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.TextBox tbox_confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_newpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_currentpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_hover_currentpass;
        private System.Windows.Forms.Label lbl_hover_newpass;
        private System.Windows.Forms.Label lbl_recheck;
    }
}
