namespace QuanLyCuaHangGear
{
    partial class Account_Control
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
            this.btn_changePass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.txt_OldPass = new System.Windows.Forms.TextBox();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_WarningNew = new System.Windows.Forms.Label();
            this.label_WarningOld = new System.Windows.Forms.Label();
            this.label_WarningCf = new System.Windows.Forms.Label();
            this.label_Success = new System.Windows.Forms.Label();
            this.label_WarningCheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_changePass
            // 
            this.btn_changePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_changePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_changePass.FlatAppearance.BorderSize = 0;
            this.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePass.ForeColor = System.Drawing.Color.White;
            this.btn_changePass.Image = global::QuanLyCuaHangGear.Properties.Resources.reset;
            this.btn_changePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changePass.Location = new System.Drawing.Point(535, 397);
            this.btn_changePass.Margin = new System.Windows.Forms.Padding(2);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_changePass.Size = new System.Drawing.Size(180, 54);
            this.btn_changePass.TabIndex = 168;
            this.btn_changePass.Text = "     Đổi mật khẩu";
            this.btn_changePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(652, 375);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 1);
            this.panel2.TabIndex = 167;
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DisplayName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisplayName.ForeColor = System.Drawing.Color.White;
            this.txt_DisplayName.Location = new System.Drawing.Point(652, 341);
            this.txt_DisplayName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.ReadOnly = true;
            this.txt_DisplayName.Size = new System.Drawing.Size(232, 27);
            this.txt_DisplayName.TabIndex = 0;
            this.txt_DisplayName.TabStop = false;
            this.txt_DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.White;
            this.txt_UserName.Location = new System.Drawing.Point(652, 304);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(232, 27);
            this.txt_UserName.TabIndex = 164;
            this.txt_UserName.TabStop = false;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label16.Location = new System.Drawing.Point(370, 344);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 29);
            this.label16.TabIndex = 166;
            this.label16.Text = "Tên hiển thị:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label15.Location = new System.Drawing.Point(370, 302);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 29);
            this.label15.TabIndex = 165;
            this.label15.Text = "Tên tài khoản:";
            // 
            // pic_User
            // 
            this.pic_User.Image = global::QuanLyCuaHangGear.Properties.Resources.Staff_account;
            this.pic_User.Location = new System.Drawing.Point(456, 19);
            this.pic_User.Margin = new System.Windows.Forms.Padding(2);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(338, 251);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_User.TabIndex = 162;
            this.pic_User.TabStop = false;
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_OldPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.ForeColor = System.Drawing.Color.White;
            this.txt_OldPass.Location = new System.Drawing.Point(652, 465);
            this.txt_OldPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.Size = new System.Drawing.Size(232, 34);
            this.txt_OldPass.TabIndex = 169;
            this.txt_OldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_OldPass.Visible = false;
            this.txt_OldPass.Click += new System.EventHandler(this.txt_OldPass_Click);
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_NewPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.ForeColor = System.Drawing.Color.White;
            this.txt_NewPass.Location = new System.Drawing.Point(652, 512);
            this.txt_NewPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(232, 34);
            this.txt_NewPass.TabIndex = 170;
            this.txt_NewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NewPass.Visible = false;
            this.txt_NewPass.Click += new System.EventHandler(this.txt_NewPass_Click);
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPass.ForeColor = System.Drawing.Color.White;
            this.txt_ConfirmPass.Location = new System.Drawing.Point(652, 557);
            this.txt_ConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(232, 34);
            this.txt_ConfirmPass.TabIndex = 171;
            this.txt_ConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ConfirmPass.Visible = false;
            this.txt_ConfirmPass.Click += new System.EventHandler(this.txt_ConfirmPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(370, 470);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 172;
            this.label1.Text = "Mật khẩu hiện tại:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(370, 517);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 173;
            this.label2.Text = "Mật khẩu mới:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(370, 562);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 29);
            this.label3.TabIndex = 174;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            this.label3.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Location = new System.Drawing.Point(473, 626);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(111, 44);
            this.btn_Confirm.TabIndex = 175;
            this.btn_Confirm.Text = "XÁC NHẬN";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Visible = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(675, 626);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(111, 44);
            this.btn_Cancel.TabIndex = 176;
            this.btn_Cancel.Text = "HUỶ BỎ";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_WarningNew
            // 
            this.label_WarningNew.AutoSize = true;
            this.label_WarningNew.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_WarningNew.Location = new System.Drawing.Point(912, 512);
            this.label_WarningNew.Name = "label_WarningNew";
            this.label_WarningNew.Size = new System.Drawing.Size(248, 60);
            this.label_WarningNew.TabIndex = 177;
            this.label_WarningNew.Text = "Mật khẩu không đúng định dạng!\r\nMật khẩu phải bao gồm:\r\n- Từ 6-20 ký tự.\r\n";
            this.label_WarningNew.Visible = false;
            // 
            // label_WarningOld
            // 
            this.label_WarningOld.AutoSize = true;
            this.label_WarningOld.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_WarningOld.Location = new System.Drawing.Point(912, 473);
            this.label_WarningOld.Name = "label_WarningOld";
            this.label_WarningOld.Size = new System.Drawing.Size(112, 20);
            this.label_WarningOld.TabIndex = 177;
            this.label_WarningOld.Text = "Sai mật khẩu!\r\n";
            this.label_WarningOld.Visible = false;
            // 
            // label_WarningCf
            // 
            this.label_WarningCf.AutoSize = true;
            this.label_WarningCf.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningCf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_WarningCf.Location = new System.Drawing.Point(912, 568);
            this.label_WarningCf.Name = "label_WarningCf";
            this.label_WarningCf.Size = new System.Drawing.Size(249, 20);
            this.label_WarningCf.TabIndex = 177;
            this.label_WarningCf.Text = "Mật khẩu mới không trung khớp!\r\n";
            this.label_WarningCf.Visible = false;
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Success.ForeColor = System.Drawing.Color.Lime;
            this.label_Success.Location = new System.Drawing.Point(544, 506);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(193, 28);
            this.label_Success.TabIndex = 177;
            this.label_Success.Text = "Đã đổi mật khẩu!";
            this.label_Success.Visible = false;
            // 
            // label_WarningCheck
            // 
            this.label_WarningCheck.AutoSize = true;
            this.label_WarningCheck.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_WarningCheck.Location = new System.Drawing.Point(912, 522);
            this.label_WarningCheck.Name = "label_WarningCheck";
            this.label_WarningCheck.Size = new System.Drawing.Size(211, 40);
            this.label_WarningCheck.TabIndex = 177;
            this.label_WarningCheck.Text = "Mật khẩu mới không được\r\ntrùng với mật khẩu hiện tại!";
            this.label_WarningCheck.Visible = false;
            // 
            // Account_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label_Success);
            this.Controls.Add(this.label_WarningCheck);
            this.Controls.Add(this.label_WarningOld);
            this.Controls.Add(this.label_WarningCf);
            this.Controls.Add(this.label_WarningNew);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.txt_OldPass);
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pic_User);
            this.Name = "Account_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_changePass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.TextBox txt_OldPass;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label_WarningNew;
        private System.Windows.Forms.Label label_WarningOld;
        private System.Windows.Forms.Label label_WarningCf;
        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Label label_WarningCheck;
    }
}
