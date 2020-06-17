namespace QuanLyCuaHangGear.View
{
    partial class Form_Staff
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
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pic_StoreLogo = new System.Windows.Forms.PictureBox();
            this.panel_Slide = new System.Windows.Forms.Panel();
            this.label_UserType = new System.Windows.Forms.Label();
            this.label_UpperLogo = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_Head = new System.Windows.Forms.Panel();
            this.pic_UpperLogo = new System.Windows.Forms.PictureBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StoreLogo)).BeginInit();
            this.panel_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpperLogo)).BeginInit();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panel_Logo.Controls.Add(this.label_StoreName);
            this.panel_Logo.Controls.Add(this.pic_StoreLogo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(250, 100);
            this.panel_Logo.TabIndex = 1;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_StoreName.Location = new System.Drawing.Point(98, 34);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(175, 29);
            this.label_StoreName.TabIndex = 2;
            this.label_StoreName.Text = "QuocAn Store";
            // 
            // pic_StoreLogo
            // 
            this.pic_StoreLogo.Image = global::QuanLyCuaHangGear.Properties.Resources.Store_Logo;
            this.pic_StoreLogo.Location = new System.Drawing.Point(3, 1);
            this.pic_StoreLogo.Name = "pic_StoreLogo";
            this.pic_StoreLogo.Size = new System.Drawing.Size(89, 97);
            this.pic_StoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_StoreLogo.TabIndex = 2;
            this.pic_StoreLogo.TabStop = false;
            this.pic_StoreLogo.Click += new System.EventHandler(this.pic_StoreLogo_Click);
            // 
            // panel_Slide
            // 
            this.panel_Slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel_Slide.Location = new System.Drawing.Point(3, 100);
            this.panel_Slide.Name = "panel_Slide";
            this.panel_Slide.Size = new System.Drawing.Size(10, 80);
            this.panel_Slide.TabIndex = 2;
            // 
            // label_UserType
            // 
            this.label_UserType.AutoSize = true;
            this.label_UserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.label_UserType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_UserType.Location = new System.Drawing.Point(889, 39);
            this.label_UserType.Name = "label_UserType";
            this.label_UserType.Size = new System.Drawing.Size(111, 24);
            this.label_UserType.TabIndex = 5;
            this.label_UserType.Text = "Nhân viên:";
            // 
            // label_UpperLogo
            // 
            this.label_UpperLogo.AutoSize = true;
            this.label_UpperLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.label_UpperLogo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpperLogo.ForeColor = System.Drawing.Color.White;
            this.label_UpperLogo.Location = new System.Drawing.Point(109, 48);
            this.label_UpperLogo.Name = "label_UpperLogo";
            this.label_UpperLogo.Size = new System.Drawing.Size(145, 27);
            this.label_UpperLogo.TabIndex = 2;
            this.label_UpperLogo.Text = "                   ";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.label_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Name.Location = new System.Drawing.Point(1006, 39);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(177, 24);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Ngô Lưu Quốc Đạt";
            // 
            // panel_Head
            // 
            this.panel_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.panel_Head.Controls.Add(this.label_Name);
            this.panel_Head.Controls.Add(this.label_UserType);
            this.panel_Head.Controls.Add(this.pic_UpperLogo);
            this.panel_Head.Controls.Add(this.label_UpperLogo);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Head.Location = new System.Drawing.Point(250, 0);
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(1250, 100);
            this.panel_Head.TabIndex = 9;
            // 
            // pic_UpperLogo
            // 
            this.pic_UpperLogo.Location = new System.Drawing.Point(42, 36);
            this.pic_UpperLogo.Name = "pic_UpperLogo";
            this.pic_UpperLogo.Size = new System.Drawing.Size(50, 50);
            this.pic_UpperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_UpperLogo.TabIndex = 3;
            this.pic_UpperLogo.TabStop = false;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panel_Left.Controls.Add(this.panel_Slide);
            this.panel_Left.Controls.Add(this.panel_Logo);
            this.panel_Left.Controls.Add(this.btn_Exit);
            this.panel_Left.Controls.Add(this.btn_Import);
            this.panel_Left.Controls.Add(this.btn_Bill);
            this.panel_Left.Controls.Add(this.btn_Account);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(250, 800);
            this.panel_Left.TabIndex = 8;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::QuanLyCuaHangGear.Properties.Resources.Exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(0, 687);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Exit.Size = new System.Drawing.Size(250, 80);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "   Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Image = global::QuanLyCuaHangGear.Properties.Resources.import;
            this.btn_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.Location = new System.Drawing.Point(0, 181);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Import.Size = new System.Drawing.Size(250, 80);
            this.btn_Import.TabIndex = 0;
            this.btn_Import.Text = "   Nhập hàng         ";
            this.btn_Import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Bill
            // 
            this.btn_Bill.FlatAppearance.BorderSize = 0;
            this.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Bill.Image = global::QuanLyCuaHangGear.Properties.Resources.bill;
            this.btn_Bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bill.Location = new System.Drawing.Point(0, 100);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btn_Bill.Size = new System.Drawing.Size(250, 80);
            this.btn_Bill.TabIndex = 0;
            this.btn_Bill.Text = "   Lập hóa đơn     ";
            this.btn_Bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bill.UseVisualStyleBackColor = true;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = global::QuanLyCuaHangGear.Properties.Resources.user;
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(0, 262);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.btn_Account.Size = new System.Drawing.Size(250, 80);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "   Tài khoản         ";
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(250, 100);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1250, 700);
            this.panel_Main.TabIndex = 10;
            // 
            // Form_Staff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Head);
            this.Controls.Add(this.panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Staff_FormClosed);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StoreLogo)).EndInit();
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpperLogo)).EndInit();
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pic_StoreLogo;
        private System.Windows.Forms.Panel panel_Slide;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label_UserType;
        private System.Windows.Forms.Label label_UpperLogo;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Panel panel_Head;
        private System.Windows.Forms.PictureBox pic_UpperLogo;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Panel panel_Main;
    }
}