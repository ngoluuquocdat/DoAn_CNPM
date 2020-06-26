namespace QuanLyCuaHangGear
{
    partial class Report_Control
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Report_dtgv = new System.Windows.Forms.DataGridView();
            this.btn_details = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.label_To = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label_From = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Report_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Report_dtgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Report_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Report_dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Report_dtgv.Location = new System.Drawing.Point(62, 215);
            this.Report_dtgv.Name = "Report_dtgv";
            this.Report_dtgv.RowHeadersWidth = 51;
            this.Report_dtgv.RowTemplate.Height = 24;
            this.Report_dtgv.RowTemplate.ReadOnly = true;
            this.Report_dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_dtgv.Size = new System.Drawing.Size(1124, 420);
            this.Report_dtgv.TabIndex = 64;
            // 
            // btn_details
            // 
            this.btn_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_details.FlatAppearance.BorderSize = 0;
            this.btn_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_details.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.ForeColor = System.Drawing.Color.White;
            this.btn_details.Image = global::QuanLyCuaHangGear.Properties.Resources.display;
            this.btn_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_details.Location = new System.Drawing.Point(1004, 90);
            this.btn_details.Name = "btn_details";
            this.btn_details.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_details.Size = new System.Drawing.Size(182, 57);
            this.btn_details.TabIndex = 62;
            this.btn_details.Text = "  XEM CHI TIẾT";
            this.btn_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_details.UseVisualStyleBackColor = false;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_View.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.White;
            this.btn_View.Image = global::QuanLyCuaHangGear.Properties.Resources.Search;
            this.btn_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_View.Location = new System.Drawing.Point(733, 90);
            this.btn_View.Name = "btn_View";
            this.btn_View.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_View.Size = new System.Drawing.Size(182, 57);
            this.btn_View.TabIndex = 63;
            this.btn_View.Text = "   TRUY XUẤT";
            this.btn_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_To.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_To.Location = new System.Drawing.Point(223, 131);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(402, 30);
            this.dateTimePicker_To.TabIndex = 60;
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label_To.Location = new System.Drawing.Point(56, 129);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(143, 32);
            this.label_To.TabIndex = 58;
            this.label_To.Text = "Đến ngày:";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_From.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_From.Location = new System.Drawing.Point(223, 71);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(402, 30);
            this.dateTimePicker_From.TabIndex = 61;
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label_From.Location = new System.Drawing.Point(56, 69);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(127, 32);
            this.label_From.TabIndex = 59;
            this.label_From.Text = "Từ ngày:";
            // 
            // Report_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.Report_dtgv);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.dateTimePicker_To);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.dateTimePicker_From);
            this.Controls.Add(this.label_From);
            this.Name = "Report_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.Report_dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Report_dtgv;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Label label_From;
    }
}
