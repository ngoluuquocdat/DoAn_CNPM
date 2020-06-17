namespace QuanLyCuaHangGear
{
    partial class Welcome_Control
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
            this.label_StoreName = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.pic_BigLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_StoreName.Location = new System.Drawing.Point(599, 499);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(270, 44);
            this.label_StoreName.TabIndex = 6;
            this.label_StoreName.Text = "QuocAn Store";
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.label_Welcome.CausesValidation = false;
            this.label_Welcome.Font = new System.Drawing.Font("Freestyle Script", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_Welcome.Location = new System.Drawing.Point(403, 122);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(742, 294);
            this.label_Welcome.TabIndex = 5;
            this.label_Welcome.Text = "Welcome!";
            // 
            // pic_BigLogo
            // 
            this.pic_BigLogo.Image = global::QuanLyCuaHangGear.Properties.Resources.Store_Logo;
            this.pic_BigLogo.Location = new System.Drawing.Point(461, 458);
            this.pic_BigLogo.Name = "pic_BigLogo";
            this.pic_BigLogo.Size = new System.Drawing.Size(142, 102);
            this.pic_BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_BigLogo.TabIndex = 4;
            this.pic_BigLogo.TabStop = false;
            // 
            // Welcome_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.pic_BigLogo);
            this.Name = "Welcome_Control";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.PictureBox pic_BigLogo;
    }
}
