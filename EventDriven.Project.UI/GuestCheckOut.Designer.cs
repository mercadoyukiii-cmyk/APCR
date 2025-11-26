namespace EventDriven.Project.UI
{
    partial class GuestCheckOut
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
            dataGridView1 = new DataGridView();
            btnEdit = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 498);
            dataGridView1.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(17, 135);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 35);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(591, 17);
            button1.Name = "button1";
            button1.Size = new Size(109, 35);
            button1.TabIndex = 7;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(726, 17);
            button2.Name = "button2";
            button2.Size = new Size(109, 35);
            button2.TabIndex = 8;
            button2.Text = "REFRESH";
            button2.UseVisualStyleBackColor = true;
            // 
            // GuestCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Controls.Add(txtboxSearch);
            Name = "GuestCheckOut";
            Size = new Size(1104, 691);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxSearch;
        private DataGridView dataGridView1;
        private Button btnEdit;
        private Button button1;
        private Button button2;
    }
}
