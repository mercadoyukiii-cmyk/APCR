namespace EventDriven.Project.UI
{
    partial class GuestInfoEdit
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtboxEmergencyContact = new TextBox();
            txtboxAddress = new TextBox();
            txtboxEmail = new TextBox();
            txtboxContactNo = new TextBox();
            comboboxSex = new ComboBox();
            datetimeBirth = new DateTimePicker();
            label3 = new Label();
            txtboxMI = new TextBox();
            txtboxFirstName = new TextBox();
            label2 = new Label();
            txtboxLastName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(65, 434);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 35;
            label9.Text = "Emergency Contact:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 362);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 34;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 293);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 33;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 210);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 32;
            label6.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 112);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 31;
            label5.Text = "Sex:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 112);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 30;
            label4.Text = "Date Of Birth:";
            // 
            // txtboxEmergencyContact
            // 
            txtboxEmergencyContact.Location = new Point(65, 452);
            txtboxEmergencyContact.Name = "txtboxEmergencyContact";
            txtboxEmergencyContact.Size = new Size(202, 23);
            txtboxEmergencyContact.TabIndex = 29;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(65, 380);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(202, 23);
            txtboxAddress.TabIndex = 28;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(65, 311);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(202, 23);
            txtboxEmail.TabIndex = 27;
            // 
            // txtboxContactNo
            // 
            txtboxContactNo.Location = new Point(65, 228);
            txtboxContactNo.Name = "txtboxContactNo";
            txtboxContactNo.Size = new Size(202, 23);
            txtboxContactNo.TabIndex = 26;
            // 
            // comboboxSex
            // 
            comboboxSex.FormattingEnabled = true;
            comboboxSex.Items.AddRange(new object[] { "M", "F" });
            comboboxSex.Location = new Point(302, 130);
            comboboxSex.Name = "comboboxSex";
            comboboxSex.Size = new Size(70, 23);
            comboboxSex.TabIndex = 25;
            // 
            // datetimeBirth
            // 
            datetimeBirth.Location = new Point(65, 130);
            datetimeBirth.Name = "datetimeBirth";
            datetimeBirth.Size = new Size(200, 23);
            datetimeBirth.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 21);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 23;
            label3.Text = "M.I";
            // 
            // txtboxMI
            // 
            txtboxMI.Location = new Point(524, 39);
            txtboxMI.Name = "txtboxMI";
            txtboxMI.Size = new Size(24, 23);
            txtboxMI.TabIndex = 22;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(302, 39);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(184, 23);
            txtboxFirstName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 21);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 20;
            label2.Text = "First Name: ";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(65, 39);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(202, 23);
            txtboxLastName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 18;
            label1.Text = "Last Name: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(505, 452);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GuestInfoEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(613, 497);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtboxEmergencyContact);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxContactNo);
            Controls.Add(comboboxSex);
            Controls.Add(datetimeBirth);
            Controls.Add(label3);
            Controls.Add(txtboxMI);
            Controls.Add(txtboxFirstName);
            Controls.Add(label2);
            Controls.Add(txtboxLastName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GuestInfoEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestInfoEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtboxEmergencyContact;
        private TextBox txtboxAddress;
        private TextBox txtboxEmail;
        private TextBox txtboxContactNo;
        private ComboBox comboboxSex;
        private DateTimePicker datetimeBirth;
        private Label label3;
        private TextBox txtboxMI;
        private TextBox txtboxFirstName;
        private Label label2;
        private TextBox txtboxLastName;
        private Label label1;
        private Button btnSave;
    }
}