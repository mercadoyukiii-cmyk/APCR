namespace EventDriven.Project.UI
{
    partial class AdminDashBoard
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
            btnLogout = new Button();
            btnRoomMaintenance = new Button();
            btnGuestInfo = new Button();
            button3 = new Button();
            btnPayments = new Button();
            MainPanel = new Panel();
            btnDashboard = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            designline = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)designline).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.Location = new Point(61, 650);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRoomMaintenance
            // 
            btnRoomMaintenance.Font = new Font("Lucida Sans Typewriter", 11.25F);
            btnRoomMaintenance.ForeColor = Color.Black;
            btnRoomMaintenance.Location = new Point(23, 360);
            btnRoomMaintenance.Name = "btnRoomMaintenance";
            btnRoomMaintenance.Size = new Size(190, 39);
            btnRoomMaintenance.TabIndex = 5;
            btnRoomMaintenance.Text = "ROOM MAINTENANCE";
            btnRoomMaintenance.UseVisualStyleBackColor = true;
            btnRoomMaintenance.Click += btnRoomMaintenance_Click;
            // 
            // btnGuestInfo
            // 
            btnGuestInfo.Font = new Font("Lucida Sans Typewriter", 11.25F);
            btnGuestInfo.ForeColor = Color.Black;
            btnGuestInfo.Location = new Point(23, 217);
            btnGuestInfo.Name = "btnGuestInfo";
            btnGuestInfo.Size = new Size(190, 39);
            btnGuestInfo.TabIndex = 6;
            btnGuestInfo.Text = "GUEST INFORMATION";
            btnGuestInfo.UseVisualStyleBackColor = true;
            btnGuestInfo.Click += btnGuestInfo_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Sans Typewriter", 11.25F);
            button3.Location = new Point(23, 286);
            button3.Name = "button3";
            button3.Size = new Size(190, 39);
            button3.TabIndex = 7;
            button3.Text = "CREATE RESERVATIONS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnPayments
            // 
            btnPayments.Font = new Font("Lucida Sans Typewriter", 11.25F);
            btnPayments.Location = new Point(23, 514);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(190, 39);
            btnPayments.TabIndex = 8;
            btnPayments.Text = "PAYMENTS";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Tan;
            MainPanel.Location = new Point(260, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1104, 691);
            MainPanel.TabIndex = 12;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(23, 145);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(190, 39);
            btnDashboard.TabIndex = 13;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.Location = new Point(23, 585);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(190, 39);
            btnCheckOut.TabIndex = 14;
            btnCheckOut.Text = "CHECK-OUT";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckIn.Location = new Point(23, 435);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(190, 39);
            btnCheckIn.TabIndex = 15;
            btnCheckIn.Text = "CHECK-IN";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // designline
            // 
            designline.BackColor = Color.FromArgb(255, 192, 128);
            designline.Location = new Point(250, 0);
            designline.Name = "designline";
            designline.Size = new Size(13, 691);
            designline.TabIndex = 0;
            designline.TabStop = false;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1364, 691);
            Controls.Add(designline);
            Controls.Add(btnCheckIn);
            Controls.Add(btnCheckOut);
            Controls.Add(btnDashboard);
            Controls.Add(MainPanel);
            Controls.Add(btnPayments);
            Controls.Add(button3);
            Controls.Add(btnGuestInfo);
            Controls.Add(btnRoomMaintenance);
            Controls.Add(btnLogout);
            Name = "AdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashBoard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)designline).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnRoomMaintenance;
        private Button btnGuestInfo;
        private Button button3;
        private Button btnPayments;
        private Panel MainPanel;
        private Button btnDashboard;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private PictureBox designline;
    }
}