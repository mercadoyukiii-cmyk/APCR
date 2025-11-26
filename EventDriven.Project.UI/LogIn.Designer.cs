namespace EventDriven.Project.UI
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            HotelLogo1 = new Label();
            HotelLogo2 = new Label();
            label_username = new Label();
            label_password = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            btnLogin = new Button();
            PictureBox_Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).BeginInit();
            SuspendLayout();
            // 
            // HotelLogo1
            // 
            HotelLogo1.AutoSize = true;
            HotelLogo1.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HotelLogo1.ForeColor = Color.DarkGoldenrod;
            HotelLogo1.Location = new Point(73, 69);
            HotelLogo1.Name = "HotelLogo1";
            HotelLogo1.Size = new Size(289, 32);
            HotelLogo1.TabIndex = 0;
            HotelLogo1.Text = "EASY BREEZE HOTEL";
            // 
            // HotelLogo2
            // 
            HotelLogo2.AutoSize = true;
            HotelLogo2.Font = new Font("Lucida Bright", 20.25F);
            HotelLogo2.ForeColor = Color.DarkGoldenrod;
            HotelLogo2.Location = new Point(43, 112);
            HotelLogo2.Name = "HotelLogo2";
            HotelLogo2.Size = new Size(349, 32);
            HotelLogo2.TabIndex = 1;
            HotelLogo2.Text = "\"ENJOY. RELAX. REPEAT.\"";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.ForeColor = Color.DarkGoldenrod;
            label_username.Location = new Point(73, 205);
            label_username.Name = "label_username";
            label_username.Size = new Size(89, 20);
            label_username.TabIndex = 2;
            label_username.Text = "USERNAME:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_password.ForeColor = Color.DarkGoldenrod;
            label_password.Location = new Point(73, 272);
            label_password.Name = "label_password";
            label_password.Size = new Size(90, 20);
            label_password.TabIndex = 3;
            label_password.Text = "PASSWORD:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(73, 228);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(194, 29);
            txtboxUsername.TabIndex = 4;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPassword.Location = new Point(73, 295);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.PasswordChar = '*';
            txtboxPassword.Size = new Size(194, 29);
            txtboxPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.DarkGoldenrod;
            btnLogin.Location = new Point(117, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 32);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // PictureBox_Logo
            // 
            PictureBox_Logo.Image = (Image)resources.GetObject("PictureBox_Logo.Image");
            PictureBox_Logo.Location = new Point(408, 56);
            PictureBox_Logo.Name = "PictureBox_Logo";
            PictureBox_Logo.Size = new Size(361, 331);
            PictureBox_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Logo.TabIndex = 7;
            PictureBox_Logo.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(795, 450);
            Controls.Add(PictureBox_Logo);
            Controls.Add(btnLogin);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxUsername);
            Controls.Add(label_password);
            Controls.Add(label_username);
            Controls.Add(HotelLogo2);
            Controls.Add(HotelLogo1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HotelLogo1;
        private Label HotelLogo2;
        private Label label_username;
        private Label label_password;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Button btnLogin;
        private PictureBox PictureBox_Logo;
    }
}
