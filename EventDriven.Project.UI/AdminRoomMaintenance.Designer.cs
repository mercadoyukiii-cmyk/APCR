namespace EventDriven.Project.UI
{
    partial class AdminRoomMaintenance
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
            dataGridView1 = new DataGridView();
            btnEdit = new Button();
            btnSave = new Button();
            cmbboxSortBy = new ComboBox();
            label1 = new Label();
            txtboxSearch = new TextBox();
            btnSearchRoom = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 498);
            dataGridView1.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(17, 137);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 35);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(157, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbboxSortBy
            // 
            cmbboxSortBy.FormattingEnabled = true;
            cmbboxSortBy.Location = new Point(937, 149);
            cmbboxSortBy.Name = "cmbboxSortBy";
            cmbboxSortBy.Size = new Size(148, 23);
            cmbboxSortBy.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(937, 131);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 14;
            label1.Text = "Sort By :";
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(17, 19);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(550, 33);
            txtboxSearch.TabIndex = 15;
            // 
            // btnSearchRoom
            // 
            btnSearchRoom.Location = new Point(591, 17);
            btnSearchRoom.Name = "btnSearchRoom";
            btnSearchRoom.Size = new Size(109, 35);
            btnSearchRoom.TabIndex = 16;
            btnSearchRoom.Text = "SEARCH";
            btnSearchRoom.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(726, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 35);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // AdminRoomMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchRoom);
            Controls.Add(txtboxSearch);
            Controls.Add(label1);
            Controls.Add(cmbboxSortBy);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Name = "AdminRoomMaintenance";
            Size = new Size(1104, 691);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEdit;
        private Button btnSave;
        private ComboBox cmbboxSortBy;
        private Label label1;
        private TextBox txtboxSearch;
        private Button btnSearchRoom;
        private Button btnRefresh;
    }
}
