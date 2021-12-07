
namespace TRACNGHIEMBYWINFORM
{
    partial class Form_comment_String
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_comment_String));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbox_label = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_italic = new System.Windows.Forms.Button();
            this.btn_underline = new System.Windows.Forms.Button();
            this.btn_bold = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.tbox_label);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 43);
            this.panel1.TabIndex = 0;
            // 
            // tbox_label
            // 
            this.tbox_label.BackColor = System.Drawing.Color.White;
            this.tbox_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_label.Location = new System.Drawing.Point(51, 3);
            this.tbox_label.Multiline = true;
            this.tbox_label.Name = "tbox_label";
            this.tbox_label.Size = new System.Drawing.Size(287, 37);
            this.tbox_label.TabIndex = 4;
            this.tbox_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_label.TextChanged += new System.EventHandler(this.tbox_label_TextChanged);
            this.tbox_label.MouseEnter += new System.EventHandler(this.tbox_label_MouseEnter);
            this.tbox_label.MouseLeave += new System.EventHandler(this.tbox_label_MouseLeave);
            this.tbox_label.MouseHover += new System.EventHandler(this.tbox_label_MouseHover);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(336, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 40);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_exit.Location = new System.Drawing.Point(351, -1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 33);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_italic);
            this.panel3.Controls.Add(this.btn_underline);
            this.panel3.Controls.Add(this.btn_bold);
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 49);
            this.panel3.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(318, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(62, 40);
            this.btn_save.TabIndex = 5;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_italic
            // 
            this.btn_italic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_italic.FlatAppearance.BorderSize = 0;
            this.btn_italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_italic.Image = ((System.Drawing.Image)(resources.GetObject("btn_italic.Image")));
            this.btn_italic.Location = new System.Drawing.Point(65, 5);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(40, 40);
            this.btn_italic.TabIndex = 3;
            this.btn_italic.UseVisualStyleBackColor = false;
            this.btn_italic.Click += new System.EventHandler(this.btn_italic_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_underline.FlatAppearance.BorderSize = 0;
            this.btn_underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_underline.Image = ((System.Drawing.Image)(resources.GetObject("btn_underline.Image")));
            this.btn_underline.Location = new System.Drawing.Point(122, 4);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(40, 40);
            this.btn_underline.TabIndex = 2;
            this.btn_underline.UseVisualStyleBackColor = false;
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // btn_bold
            // 
            this.btn_bold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_bold.FlatAppearance.BorderSize = 0;
            this.btn_bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bold.Image = ((System.Drawing.Image)(resources.GetObject("btn_bold.Image")));
            this.btn_bold.Location = new System.Drawing.Point(3, 5);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(40, 40);
            this.btn_bold.TabIndex = 1;
            this.btn_bold.UseVisualStyleBackColor = false;
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click);
            this.btn_bold.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_bold_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(381, 280);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            this.richTextBox1.MouseEnter += new System.EventHandler(this.richTextBox1_MouseEnter);
            this.richTextBox1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            // 
            // Form_comment_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form_comment_String";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Brown;
            this.Load += new System.EventHandler(this.Form_Comment_String_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_italic;
        private System.Windows.Forms.Button btn_underline;
        private System.Windows.Forms.Button btn_bold;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbox_label;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}