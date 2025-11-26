namespace EventDriven.Project.UI
{
    partial class AdminGuestInfo
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
            datagridAdminGuestInfo = new DataGridView();
            txtboxSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnCheckIn = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridAdminGuestInfo).BeginInit();
            SuspendLayout();
            // 
            // datagridAdminGuestInfo
            // 
            datagridAdminGuestInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridAdminGuestInfo.Location = new Point(17, 176);
            datagridAdminGuestInfo.Name = "datagridAdminGuestInfo";
            datagridAdminGuestInfo.Size = new Size(1068, 498);
            datagridAdminGuestInfo.TabIndex = 1;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(17, 19);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(550, 33);
            txtboxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(591, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(726, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 35);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(17, 135);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(163, 35);
            btnCheckIn.TabIndex = 7;
            btnCheckIn.Text = "Add To Check-In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(345, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(210, 135);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // AdminGuestInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCheckIn);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(datagridAdminGuestInfo);
            Name = "AdminGuestInfo";
            Size = new Size(1104, 691);
            Load += AdminGuestInfo_Load;
            ((System.ComponentModel.ISupportInitialize)datagridAdminGuestInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridAdminGuestInfo;
        private TextBox txtboxSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnCheckIn;
        private Button btnDelete;
        private Button btnEdit;
    }
}
