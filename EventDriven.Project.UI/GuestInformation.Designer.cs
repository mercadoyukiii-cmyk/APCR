namespace EventDriven.Project.UI
{
    partial class GuestInformation
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
            datagridGuestInfo = new DataGridView();
            txtboxSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnCheckIn = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridGuestInfo).BeginInit();
            SuspendLayout();
            // 
            // datagridGuestInfo
            // 
            datagridGuestInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridGuestInfo.Location = new Point(17, 176);
            datagridGuestInfo.Name = "datagridGuestInfo";
            datagridGuestInfo.Size = new Size(1068, 498);
            datagridGuestInfo.TabIndex = 0;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(165, 21);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(550, 33);
            txtboxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(745, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(871, 21);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(17, 135);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(163, 35);
            btnCheckIn.TabIndex = 6;
            btnCheckIn.Text = "Add To Check-In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // GuestInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(btnCheckIn);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(datagridGuestInfo);
            Name = "GuestInformation";
            Size = new Size(1104, 691);
            Load += GuestInformation_Load;
            ((System.ComponentModel.ISupportInitialize)datagridGuestInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridGuestInfo;
        private TextBox txtboxSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnCheckIn;
    }
}
