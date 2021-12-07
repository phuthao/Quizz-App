
namespace TRACNGHIEMBYWINFORM
{
    partial class Form_Rank
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
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel_blank = new System.Windows.Forms.Panel();
            this.listview_RANK = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_load = new System.Windows.Forms.Button();
            this.panel_blank.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chart
            // 
            this.panel_chart.AllowDrop = true;
            this.panel_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel_chart.Location = new System.Drawing.Point(5, 31);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(809, 671);
            this.panel_chart.TabIndex = 20;
            // 
            // panel_blank
            // 
            this.panel_blank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_blank.Controls.Add(this.listview_RANK);
            this.panel_blank.Controls.Add(this.btn_load);
            this.panel_blank.Location = new System.Drawing.Point(820, 31);
            this.panel_blank.Name = "panel_blank";
            this.panel_blank.Size = new System.Drawing.Size(498, 671);
            this.panel_blank.TabIndex = 0;
            // 
            // listview_RANK
            // 
            this.listview_RANK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_RANK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.listview_RANK.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_RANK.FullRowSelect = true;
            this.listview_RANK.GridLines = true;
            this.listview_RANK.HideSelection = false;
            this.listview_RANK.Location = new System.Drawing.Point(0, 3);
            this.listview_RANK.MultiSelect = false;
            this.listview_RANK.Name = "listview_RANK";
            this.listview_RANK.Size = new System.Drawing.Size(495, 665);
            this.listview_RANK.TabIndex = 0;
            this.listview_RANK.UseCompatibleStateImageBehavior = false;
            this.listview_RANK.View = System.Windows.Forms.View.Details;
            this.listview_RANK.SelectedIndexChanged += new System.EventHandler(this.listview_RANK_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Correct";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time Completed";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Times";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Top";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(327, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(64, 26);
            this.btn_load.TabIndex = 21;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 706);
            this.Controls.Add(this.panel_blank);
            this.Controls.Add(this.panel_chart);
            this.Name = "Form_Rank";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Rank_FormClosing);
            this.Load += new System.EventHandler(this.Form_Rank_Load);
            this.panel_blank.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.Panel panel_blank;
        private System.Windows.Forms.ListView listview_RANK;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}