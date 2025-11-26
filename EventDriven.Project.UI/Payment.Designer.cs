namespace EventDriven.Project.UI
{
    partial class Payment
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
            datagridPaymentList = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)datagridPaymentList).BeginInit();
            SuspendLayout();
            // 
            // datagridPaymentList
            // 
            datagridPaymentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridPaymentList.Location = new Point(14, 56);
            datagridPaymentList.Name = "datagridPaymentList";
            datagridPaymentList.Size = new Size(497, 617);
            datagridPaymentList.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Location = new Point(530, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 617);
            panel1.TabIndex = 1;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            Controls.Add(panel1);
            Controls.Add(datagridPaymentList);
            Name = "Payment";
            Size = new Size(1104, 691);
            ((System.ComponentModel.ISupportInitialize)datagridPaymentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagridPaymentList;
        private Panel panel1;
    }
}
