namespace QuanLyCuaHangGear
{
    partial class Form_Login
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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.label_Warning = new System.Windows.Forms.Label();
            this.pic_Password = new System.Windows.Forms.PictureBox();
            this.pic_Username = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Username)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Username.HideSelection = false;
            this.txt_Username.Location = new System.Drawing.Point(129, 271);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(217, 23);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TabStop = false;
            this.txt_Username.Text = "Username";
            this.txt_Username.Click += new System.EventHandler(this.txt_Username_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(61, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Password.HideSelection = false;
            this.txt_Password.Location = new System.Drawing.Point(129, 355);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(217, 23);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TabStop = false;
            this.txt_Password.Text = "Password";
            this.txt_Password.Click += new System.EventHandler(this.txt_Password_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(61, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 2;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btn_SignUp.Location = new System.Drawing.Point(60, 484);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(300, 51);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.TabStop = false;
            this.btn_SignUp.Text = "Sign up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(375, 9);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(27, 27);
            this.label_Exit.TabIndex = 4;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label_Welcome.CausesValidation = false;
            this.label_Welcome.Font = new System.Drawing.Font("Freestyle Script", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_Welcome.Location = new System.Drawing.Point(79, 128);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(255, 98);
            this.label_Welcome.TabIndex = 1;
            this.label_Welcome.Text = "Welcome!";
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreName.ForeColor = System.Drawing.Color.White;
            this.label_StoreName.Location = new System.Drawing.Point(134, 66);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(142, 21);
            this.label_StoreName.TabIndex = 6;
            this.label_StoreName.Text = "QuocAn Store";
            // 
            // label_Warning
            // 
            this.label_Warning.AutoSize = true;
            this.label_Warning.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_Warning.Location = new System.Drawing.Point(62, 437);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(262, 20);
            this.label_Warning.TabIndex = 7;
            this.label_Warning.Text = "Sai tên đăng nhập hoặc mật khẩu.";
            this.label_Warning.Visible = false;
            // 
            // pic_Password
            // 
            this.pic_Password.BackgroundImage = global::QuanLyCuaHangGear.Properties.Resources.pass;
            this.pic_Password.Location = new System.Drawing.Point(60, 344);
            this.pic_Password.Name = "pic_Password";
            this.pic_Password.Size = new System.Drawing.Size(38, 38);
            this.pic_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Password.TabIndex = 0;
            this.pic_Password.TabStop = false;
            // 
            // pic_Username
            // 
            this.pic_Username.BackgroundImage = global::QuanLyCuaHangGear.Properties.Resources.user;
            this.pic_Username.Location = new System.Drawing.Point(60, 260);
            this.pic_Username.Name = "pic_Username";
            this.pic_Username.Size = new System.Drawing.Size(38, 38);
            this.pic_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Username.TabIndex = 0;
            this.pic_Username.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(414, 592);
            this.Controls.Add(this.label_Warning);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.pic_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.pic_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Username)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.Label label_Warning;
    }
}

