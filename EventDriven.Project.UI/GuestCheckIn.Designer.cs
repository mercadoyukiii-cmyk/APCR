namespace EventDriven.Project.UI
{
    partial class GuestCheckIn
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
            datagridCheckInList = new DataGridView();
            txtboxSearch = new TextBox();
            btnSearchGuest = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridCheckInList).BeginInit();
            SuspendLayout();
            // 
            // datagridCheckInList
            // 
            datagridCheckInList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridCheckInList.Location = new Point(17, 176);
            datagridCheckInList.Name = "datagridCheckInList";
            datagridCheckInList.Size = new Size(1068, 498);
            datagridCheckInList.TabIndex = 1;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(17, 19);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(550, 33);
            txtboxSearch.TabIndex = 2;
            // 
            // btnSearchGuest
            // 
            btnSearchGuest.Location = new Point(591, 17);
            btnSearchGuest.Name = "btnSearchGuest";
            btnSearchGuest.Size = new Size(109, 35);
            btnSearchGuest.TabIndex = 6;
            btnSearchGuest.Text = "SEARCH";
            btnSearchGuest.UseVisualStyleBackColor = true;
            btnSearchGuest.Click += btnSearchGuest_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(726, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 35);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // GuestCheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchGuest);
            Controls.Add(txtboxSearch);
            Controls.Add(datagridCheckInList);
            Name = "GuestCheckIn";
            Size = new Size(1104, 691);
            Load += GuestCheckIn_Load;
            ((System.ComponentModel.ISupportInitialize)datagridCheckInList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridCheckInList;
        private TextBox txtboxSearch;
        private Button btnSearchGuest;
        private Button btnRefresh;
    }
}
