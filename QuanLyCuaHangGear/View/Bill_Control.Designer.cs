namespace QuanLyCuaHangGear
{
    partial class Bill_Control
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dtgv_buy = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name_customer = new System.Windows.Forms.TextBox();
            this.txt_id_hang = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_danhmuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_CustomerInfo = new System.Windows.Forms.Panel();
            this.btn_SearchPhone = new System.Windows.Forms.Button();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_add_to_bill = new System.Windows.Forms.Button();
            this.btn_SearchID = new System.Windows.Forms.Button();
            this.btn_del_from_bill = new System.Windows.Forms.Button();
            this.numUpDown_count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_buy)).BeginInit();
            this.panel_CustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_count)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(705, -18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 1);
            this.panel2.TabIndex = 45;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(684, 616);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 44);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "HỦY BỎ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(452, 616);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(111, 44);
            this.btn_confirm.TabIndex = 31;
            this.btn_confirm.Text = "XÁC NHẬN";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // dtgv_buy
            // 
            this.dtgv_buy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_buy.Location = new System.Drawing.Point(684, 332);
            this.dtgv_buy.MultiSelect = false;
            this.dtgv_buy.Name = "dtgv_buy";
            this.dtgv_buy.ReadOnly = true;
            this.dtgv_buy.RowHeadersWidth = 51;
            this.dtgv_buy.RowTemplate.Height = 24;
            this.dtgv_buy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_buy.Size = new System.Drawing.Size(501, 192);
            this.dtgv_buy.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 27);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(165, 131);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(254, 33);
            this.txt_email.TabIndex = 21;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name_customer
            // 
            this.txt_name_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_name_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name_customer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_customer.ForeColor = System.Drawing.Color.White;
            this.txt_name_customer.Location = new System.Drawing.Point(165, 72);
            this.txt_name_customer.Multiline = true;
            this.txt_name_customer.Name = "txt_name_customer";
            this.txt_name_customer.Size = new System.Drawing.Size(254, 33);
            this.txt_name_customer.TabIndex = 16;
            this.txt_name_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_id_hang
            // 
            this.txt_id_hang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_id_hang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_hang.ForeColor = System.Drawing.Color.White;
            this.txt_id_hang.Location = new System.Drawing.Point(209, 92);
            this.txt_id_hang.Multiline = true;
            this.txt_id_hang.Name = "txt_id_hang";
            this.txt_id_hang.Size = new System.Drawing.Size(273, 33);
            this.txt_id_hang.TabIndex = 20;
            this.txt_id_hang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id_hang.Click += new System.EventHandler(this.txt_id_hang_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.White;
            this.txt_phone.Location = new System.Drawing.Point(165, 11);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(254, 33);
            this.txt_phone.TabIndex = 19;
            this.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_phone.Click += new System.EventHandler(this.txt_phone_Click);
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_tenhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tenhang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhang.ForeColor = System.Drawing.Color.White;
            this.txt_tenhang.Location = new System.Drawing.Point(209, 242);
            this.txt_tenhang.Multiline = true;
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.ReadOnly = true;
            this.txt_tenhang.Size = new System.Drawing.Size(268, 33);
            this.txt_tenhang.TabIndex = 18;
            this.txt_tenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_danhmuc
            // 
            this.txt_danhmuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_danhmuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_danhmuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_danhmuc.ForeColor = System.Drawing.Color.White;
            this.txt_danhmuc.Location = new System.Drawing.Point(209, 167);
            this.txt_danhmuc.Multiline = true;
            this.txt_danhmuc.Name = "txt_danhmuc";
            this.txt_danhmuc.ReadOnly = true;
            this.txt_danhmuc.Size = new System.Drawing.Size(268, 33);
            this.txt_danhmuc.TabIndex = 17;
            this.txt_danhmuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(680, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sản phẩm khách mua:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label6.Location = new System.Drawing.Point(71, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày tạo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(71, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label11.Location = new System.Drawing.Point(17, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label8.Location = new System.Drawing.Point(71, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mã hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tên khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label9.Location = new System.Drawing.Point(16, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(71, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tên hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label7.Location = new System.Drawing.Point(71, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Danh mục: ";
            // 
            // panel_CustomerInfo
            // 
            this.panel_CustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.panel_CustomerInfo.Controls.Add(this.txt_phone);
            this.panel_CustomerInfo.Controls.Add(this.label9);
            this.panel_CustomerInfo.Controls.Add(this.label10);
            this.panel_CustomerInfo.Controls.Add(this.label11);
            this.panel_CustomerInfo.Controls.Add(this.btn_SearchPhone);
            this.panel_CustomerInfo.Controls.Add(this.txt_name_customer);
            this.panel_CustomerInfo.Controls.Add(this.btn_Add_Customer);
            this.panel_CustomerInfo.Controls.Add(this.txt_email);
            this.panel_CustomerInfo.Location = new System.Drawing.Point(684, 15);
            this.panel_CustomerInfo.Name = "panel_CustomerInfo";
            this.panel_CustomerInfo.Size = new System.Drawing.Size(501, 260);
            this.panel_CustomerInfo.TabIndex = 47;
            // 
            // btn_SearchPhone
            // 
            this.btn_SearchPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_SearchPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SearchPhone.FlatAppearance.BorderSize = 0;
            this.btn_SearchPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchPhone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SearchPhone.Image = global::QuanLyCuaHangGear.Properties.Resources.Search;
            this.btn_SearchPhone.Location = new System.Drawing.Point(429, 5);
            this.btn_SearchPhone.Name = "btn_SearchPhone";
            this.btn_SearchPhone.Size = new System.Drawing.Size(58, 47);
            this.btn_SearchPhone.TabIndex = 23;
            this.btn_SearchPhone.UseVisualStyleBackColor = false;
            this.btn_SearchPhone.Click += new System.EventHandler(this.btn_SearchPhone_Click);
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Add_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Customer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Add_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Add_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Customer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Customer.Image = global::QuanLyCuaHangGear.Properties.Resources.add;
            this.btn_Add_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Customer.Location = new System.Drawing.Point(130, 182);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Add_Customer.Size = new System.Drawing.Size(250, 53);
            this.btn_Add_Customer.TabIndex = 27;
            this.btn_Add_Customer.Text = "   THÊM KHÁCH HÀNG";
            this.btn_Add_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add_Customer.UseVisualStyleBackColor = false;
            this.btn_Add_Customer.Visible = false;
            this.btn_Add_Customer.Click += new System.EventHandler(this.btn_Add_Customer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label12.Location = new System.Drawing.Point(739, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tổng tiền:";
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_Total.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(866, 540);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(180, 33);
            this.txt_Total.TabIndex = 24;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label13.Location = new System.Drawing.Point(1052, 545);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "VND";
            // 
            // btn_add_to_bill
            // 
            this.btn_add_to_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_add_to_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_to_bill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_add_to_bill.FlatAppearance.BorderSize = 0;
            this.btn_add_to_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_to_bill.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_to_bill.ForeColor = System.Drawing.Color.White;
            this.btn_add_to_bill.Image = global::QuanLyCuaHangGear.Properties.Resources.add;
            this.btn_add_to_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_to_bill.Location = new System.Drawing.Point(147, 403);
            this.btn_add_to_bill.Name = "btn_add_to_bill";
            this.btn_add_to_bill.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_add_to_bill.Size = new System.Drawing.Size(275, 53);
            this.btn_add_to_bill.TabIndex = 29;
            this.btn_add_to_bill.Text = "   THÊM VÀO HÓA ĐƠN";
            this.btn_add_to_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_to_bill.UseVisualStyleBackColor = false;
            this.btn_add_to_bill.Click += new System.EventHandler(this.btn_add_to_bill_Click);
            // 
            // btn_SearchID
            // 
            this.btn_SearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_SearchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SearchID.FlatAppearance.BorderSize = 0;
            this.btn_SearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SearchID.Image = global::QuanLyCuaHangGear.Properties.Resources.Search;
            this.btn_SearchID.Location = new System.Drawing.Point(487, 85);
            this.btn_SearchID.Name = "btn_SearchID";
            this.btn_SearchID.Size = new System.Drawing.Size(58, 47);
            this.btn_SearchID.TabIndex = 23;
            this.btn_SearchID.UseVisualStyleBackColor = false;
            this.btn_SearchID.Click += new System.EventHandler(this.btn_SearchID_Click);
            // 
            // btn_del_from_bill
            // 
            this.btn_del_from_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_del_from_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del_from_bill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_del_from_bill.FlatAppearance.BorderSize = 0;
            this.btn_del_from_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_from_bill.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_from_bill.ForeColor = System.Drawing.Color.White;
            this.btn_del_from_bill.Image = global::QuanLyCuaHangGear.Properties.Resources.Delete;
            this.btn_del_from_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del_from_bill.Location = new System.Drawing.Point(147, 491);
            this.btn_del_from_bill.Name = "btn_del_from_bill";
            this.btn_del_from_bill.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_del_from_bill.Size = new System.Drawing.Size(275, 53);
            this.btn_del_from_bill.TabIndex = 48;
            this.btn_del_from_bill.Text = "   XÓA KHỎI HÓA ĐƠN";
            this.btn_del_from_bill.UseVisualStyleBackColor = false;
            this.btn_del_from_bill.Click += new System.EventHandler(this.btn_del_from_bill_Click);
            // 
            // numUpDown_count
            // 
            this.numUpDown_count.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_count.Location = new System.Drawing.Point(209, 312);
            this.numUpDown_count.Name = "numUpDown_count";
            this.numUpDown_count.Size = new System.Drawing.Size(66, 34);
            this.numUpDown_count.TabIndex = 49;
          
            // 
            // Bill_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.numUpDown_count);
            this.Controls.Add(this.btn_del_from_bill);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.panel_CustomerInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_add_to_bill);
            this.Controls.Add(this.btn_SearchID);
            this.Controls.Add(this.dtgv_buy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_id_hang);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_danhmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Name = "Bill_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_buy)).EndInit();
            this.panel_CustomerInfo.ResumeLayout(false);
            this.panel_CustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_SearchPhone;
        private System.Windows.Forms.Button btn_Add_Customer;
        private System.Windows.Forms.Button btn_add_to_bill;
        private System.Windows.Forms.DataGridView dtgv_buy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name_customer;
        private System.Windows.Forms.TextBox txt_id_hang;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_danhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_CustomerInfo;
        private System.Windows.Forms.Button btn_SearchID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_del_from_bill;
        private System.Windows.Forms.NumericUpDown numUpDown_count;
    }
}
