namespace EventDriven.Project.UI
{
    partial class FrontDeskDashboard
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
            components = new System.ComponentModel.Container();
            btnLogout = new Button();
            btnGuestInfo = new Button();
            btnCreateReservations = new Button();
            btnPayments = new Button();
            UpdateTimer = new System.Windows.Forms.Timer(components);
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
            btnLogout.Location = new Point(66, 618);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnGuestInfo
            // 
            btnGuestInfo.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuestInfo.ForeColor = Color.Black;
            btnGuestInfo.Location = new Point(23, 217);
            btnGuestInfo.Name = "btnGuestInfo";
            btnGuestInfo.Size = new Size(190, 39);
            btnGuestInfo.TabIndex = 7;
            btnGuestInfo.Text = "GUEST INFORMATION";
            btnGuestInfo.UseVisualStyleBackColor = true;
            btnGuestInfo.Click += btnGuestInfo_Click;
            // 
            // btnCreateReservations
            // 
            btnCreateReservations.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateReservations.Location = new Point(23, 286);
            btnCreateReservations.Name = "btnCreateReservations";
            btnCreateReservations.Size = new Size(190, 39);
            btnCreateReservations.TabIndex = 8;
            btnCreateReservations.Text = "CREATE RESERVATIONS";
            btnCreateReservations.UseVisualStyleBackColor = true;
            btnCreateReservations.Click += btnCreateReservations_Click;
            // 
            // btnPayments
            // 
            btnPayments.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayments.Location = new Point(23, 435);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(190, 39);
            btnPayments.TabIndex = 10;
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
            MainPanel.TabIndex = 11;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(23, 145);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(190, 39);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.Location = new Point(23, 514);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(190, 39);
            btnCheckOut.TabIndex = 13;
            btnCheckOut.Text = "CHECK-OUT";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckIn.Location = new Point(23, 360);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(190, 39);
            btnCheckIn.TabIndex = 14;
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
            designline.TabIndex = 15;
            designline.TabStop = false;
            // 
            // FrontDeskDashboard
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
            Controls.Add(btnCreateReservations);
            Controls.Add(btnGuestInfo);
            Controls.Add(btnLogout);
            Name = "FrontDeskDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrontDeskDashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)designline).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnGuestInfo;
        private Button btnCreateReservations;
        private Button btnPayments;
        private System.Windows.Forms.Timer UpdateTimer;
        private Panel MainPanel;
        private Button btnDashboard;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private PictureBox designline;
    }
}