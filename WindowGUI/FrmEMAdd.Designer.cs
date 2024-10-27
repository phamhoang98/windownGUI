namespace WindowGUI
{
    partial class FrmEMAdd
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
            label1 = new Label();
            tbName = new TextBox();
            txID = new TextBox();
            label2 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            tbAddress = new TextBox();
            label4 = new Label();
            rbMale = new RadioButton();
            rbFeMale = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            colorDialog1 = new ColorDialog();
            cbDepartment = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cbPosition = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // tbName
            // 
            tbName.Location = new Point(473, 24);
            tbName.Name = "tbName";
            tbName.Size = new Size(233, 27);
            tbName.TabIndex = 1;
            // 
            // txID
            // 
            txID.Location = new Point(110, 24);
            txID.Name = "txID";
            txID.Size = new Size(233, 27);
            txID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 27);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã nv";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(473, 113);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(233, 27);
            tbEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 116);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(110, 113);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(233, 27);
            tbAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(110, 70);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFeMale
            // 
            rbFeMale.AutoSize = true;
            rbFeMale.Location = new Point(178, 70);
            rbFeMale.Name = "rbFeMale";
            rbFeMale.Size = new Size(50, 24);
            rbFeMale.TabIndex = 9;
            rbFeMale.TabStop = true;
            rbFeMale.Text = "Nữ";
            rbFeMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 72);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày sinh";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(473, 70);
            dtpDate.MaxDate = new DateTime(2024, 10, 25, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(233, 27);
            dtpDate.TabIndex = 12;
            dtpDate.Value = new DateTime(2024, 10, 25, 0, 0, 0, 0);
            // 
            // cbDepartment
            // 
            cbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(110, 165);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(233, 28);
            cbDepartment.TabIndex = 13;
            cbDepartment.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 168);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 14;
            label7.Text = "Phòng Ban";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 168);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 16;
            label8.Text = "Chức vụ";
            // 
            // cbPosition
            // 
            cbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(473, 165);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(233, 28);
            cbPosition.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(473, 218);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(604, 218);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmEMAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(768, 506);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label8);
            Controls.Add(cbPosition);
            Controls.Add(label7);
            Controls.Add(cbDepartment);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rbFeMale);
            Controls.Add(rbMale);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbAddress);
            Controls.Add(label4);
            Controls.Add(txID);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "FrmEMAdd";
            Text = " frmEMAdd";
            Load += FrmEMAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private TextBox txID;
        private Label label2;
        private TextBox tbEmail;
        private Label label3;
        private TextBox tbAddress;
        private Label label4;
        private RadioButton rbMale;
        private RadioButton rbFeMale;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDate;
        private ColorDialog colorDialog1;
        private ComboBox cbDepartment;
        private Label label7;
        private Label label8;
        private ComboBox cbPosition;
        private Button btnCancel;
        private Button btnSave;
    }
}