namespace QuanLyCuaHangGear
{
    partial class Product_Control
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.Product_dtgv = new System.Windows.Forms.DataGridView();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_priceDown = new System.Windows.Forms.Button();
            this.btn_priceUp = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Check_Amount = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Product_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(718, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1);
            this.panel2.TabIndex = 142;
            // 
            // cbb_Category
            // 
            this.cbb_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.cbb_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Category.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(931, 139);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(219, 31);
            this.cbb_Category.TabIndex = 137;
            this.cbb_Category.SelectedIndexChanged += new System.EventHandler(this.cbb_Category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(821, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 136;
            this.label5.Text = "Phân loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(95, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 135;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.White;
            this.txt_Search.Location = new System.Drawing.Point(718, 31);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(321, 23);
            this.txt_Search.TabIndex = 119;
            this.txt_Search.Text = "Nhập tên hàng";
            this.txt_Search.Click += new System.EventHandler(this.txt_Search_Click);
            // 
            // Product_dtgv
            // 
            this.Product_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_dtgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.Product_dtgv.Location = new System.Drawing.Point(99, 189);
            this.Product_dtgv.MultiSelect = false;
            this.Product_dtgv.Name = "Product_dtgv";
            this.Product_dtgv.ReadOnly = true;
            this.Product_dtgv.RowHeadersWidth = 51;
            this.Product_dtgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.Product_dtgv.RowTemplate.Height = 24;
            this.Product_dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Product_dtgv.Size = new System.Drawing.Size(1051, 380);
            this.Product_dtgv.TabIndex = 113;
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.cbb_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Sort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Items.AddRange(new object[] {
            "Đơn giá nhập",
            "Đơn giá bán"});
            this.cbb_Sort.Location = new System.Drawing.Point(494, 611);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(192, 31);
            this.cbb_Sort.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(247, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 144;
            this.label3.Text = "Sắp xếp hàng hóa theo:";
            // 
            // btn_priceDown
            // 
            this.btn_priceDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_priceDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_priceDown.FlatAppearance.BorderSize = 0;
            this.btn_priceDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_priceDown.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priceDown.ForeColor = System.Drawing.Color.White;
            this.btn_priceDown.Image = global::QuanLyCuaHangGear.Properties.Resources.Price_Down;
            this.btn_priceDown.Location = new System.Drawing.Point(869, 599);
            this.btn_priceDown.Name = "btn_priceDown";
            this.btn_priceDown.Size = new System.Drawing.Size(86, 57);
            this.btn_priceDown.TabIndex = 141;
            this.btn_priceDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_priceDown.UseVisualStyleBackColor = false;
            this.btn_priceDown.Click += new System.EventHandler(this.btn_priceDown_Click);
            // 
            // btn_priceUp
            // 
            this.btn_priceUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_priceUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_priceUp.FlatAppearance.BorderSize = 0;
            this.btn_priceUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_priceUp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priceUp.ForeColor = System.Drawing.Color.White;
            this.btn_priceUp.Image = global::QuanLyCuaHangGear.Properties.Resources.PriceUp;
            this.btn_priceUp.Location = new System.Drawing.Point(736, 599);
            this.btn_priceUp.Name = "btn_priceUp";
            this.btn_priceUp.Size = new System.Drawing.Size(86, 57);
            this.btn_priceUp.TabIndex = 139;
            this.btn_priceUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_priceUp.UseVisualStyleBackColor = false;
            this.btn_priceUp.Click += new System.EventHandler(this.btn_priceUp_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::QuanLyCuaHangGear.Properties.Resources.add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(30, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Add.Size = new System.Drawing.Size(128, 57);
            this.btn_Add.TabIndex = 116;
            this.btn_Add.Text = "    THÊM";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = global::QuanLyCuaHangGear.Properties.Resources.edit;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(192, 19);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Edit.Size = new System.Drawing.Size(128, 57);
            this.btn_Edit.TabIndex = 115;
            this.btn_Edit.Text = "    SỬA";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::QuanLyCuaHangGear.Properties.Resources.Search;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(1058, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Search.Size = new System.Drawing.Size(158, 57);
            this.btn_Search.TabIndex = 117;
            this.btn_Search.Text = "   TÌM KIẾM";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Check_Amount
            // 
            this.btn_Check_Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Check_Amount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Check_Amount.FlatAppearance.BorderSize = 0;
            this.btn_Check_Amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check_Amount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check_Amount.ForeColor = System.Drawing.Color.White;
            this.btn_Check_Amount.Image = global::QuanLyCuaHangGear.Properties.Resources.Product;
            this.btn_Check_Amount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Check_Amount.Location = new System.Drawing.Point(516, 19);
            this.btn_Check_Amount.Name = "btn_Check_Amount";
            this.btn_Check_Amount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Check_Amount.Size = new System.Drawing.Size(157, 57);
            this.btn_Check_Amount.TabIndex = 118;
            this.btn_Check_Amount.Text = "    KIỂM KHO";
            this.btn_Check_Amount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Check_Amount.UseVisualStyleBackColor = false;
            this.btn_Check_Amount.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = global::QuanLyCuaHangGear.Properties.Resources.Delete;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(354, 19);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Delete.Size = new System.Drawing.Size(128, 57);
            this.btn_Delete.TabIndex = 114;
            this.btn_Delete.Text = "    XÓA";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Product_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_Sort);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_priceDown);
            this.Controls.Add(this.btn_priceUp);
            this.Controls.Add(this.cbb_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Check_Amount);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.Product_dtgv);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Product_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            this.Click += new System.EventHandler(this.Product_Control_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Product_dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_priceDown;
        private System.Windows.Forms.Button btn_priceUp;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Check_Amount;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Product_dtgv;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Label label3;
    }
}
