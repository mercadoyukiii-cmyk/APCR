namespace EventDriven.Project.UI
{
    partial class AdminGuestCheckIn
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
            txtboxSearch = new TextBox();
            btnSearchGuest = new Button();
            btnRefresh = new Button();
            datagridAdminCheckInList = new DataGridView();
            tbnDelete = new Button();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridAdminCheckInList).BeginInit();
            SuspendLayout();
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(17, 19);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(550, 33);
            txtboxSearch.TabIndex = 3;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.Location = new Point(591, 17);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(109, 35);
            btnSearchGuest.TabIndex = 7;
            btnSearchGuest.Text = "SEARCH";
            btnSearchGuest.UseVisualStyleBackColor = true;
            btnSearchGuest.Click += btnSearchGuest_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(726, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 35);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // datagridAdminCheckInList
            // 
            datagridAdminCheckInList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridAdminCheckInList.Location = new Point(17, 176);
            datagridAdminCheckInList.Name = "datagridAdminCheckInList";
            datagridAdminCheckInList.Size = new Size(1068, 498);
            datagridAdminCheckInList.TabIndex = 9;
            // 
            // tbnDelete
            // 
            tbnDelete.Location = new Point(214, 135);
            tbnDelete.Name = "tbnDelete";
            tbnDelete.Size = new Size(109, 35);
            tbnDelete.TabIndex = 10;
            tbnDelete.Text = "Delete";
            tbnDelete.UseVisualStyleBackColor = true;
            tbnDelete.Click += tbnDelete_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(17, 135);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(163, 35);
            btnPay.TabIndex = 11;
            btnPay.Text = "Add to Payments";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // AdminGuestCheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(btnPay);
            Controls.Add(tbnDelete);
            Controls.Add(datagridAdminCheckInList);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchGuest);
            Controls.Add(txtboxSearch);
            Name = "AdminGuestCheckIn";
            Size = new Size(1104, 691);
            Load += AdminGuestCheckIn_Load;
            ((System.ComponentModel.ISupportInitialize)datagridAdminCheckInList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxSearch;
        private Button btnSearchGuest;
        private Button btnRefresh;
        private DataGridView datagridAdminCheckInList;
        private Button tbnDelete;
        private Button btnPay;
    }
}
