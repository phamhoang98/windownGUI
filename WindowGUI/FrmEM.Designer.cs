namespace WindowGUI
{
    partial class FrmEM
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
            button1 = new Button();
            dgvEmployee = new DataGridView();
            MaNhanvien = new DataGridViewTextBoxColumn();
            TenNhanvien = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            MaPhongBan = new DataGridViewTextBoxColumn();
            Chucvu = new DataGridViewTextBoxColumn();
            Ngaysinh = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(694, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += add_employee;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { MaNhanvien, TenNhanvien, SDT, Email, DiaChi, GioiTinh, MaPhongBan, Chucvu, Ngaysinh });
            dgvEmployee.Location = new Point(12, 57);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(776, 495);
            dgvEmployee.TabIndex = 1;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // MaNhanvien
            // 
            MaNhanvien.HeaderText = "MaNhanvien";
            MaNhanvien.MinimumWidth = 6;
            MaNhanvien.Name = "MaNhanvien";
            MaNhanvien.Width = 125;
            // 
            // TenNhanvien
            // 
            TenNhanvien.HeaderText = "TenNhanvien";
            TenNhanvien.MinimumWidth = 6;
            TenNhanvien.Name = "TenNhanvien";
            TenNhanvien.Width = 125;
            // 
            // SDT
            // 
            SDT.HeaderText = "SDT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "DiaChi";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "GioiTinh";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // MaPhongBan
            // 
            MaPhongBan.HeaderText = "MaPhongBan";
            MaPhongBan.MinimumWidth = 6;
            MaPhongBan.Name = "MaPhongBan";
            MaPhongBan.Width = 125;
            // 
            // Chucvu
            // 
            Chucvu.HeaderText = "Chucvu";
            Chucvu.MinimumWidth = 6;
            Chucvu.Name = "Chucvu";
            Chucvu.Width = 125;
            // 
            // Ngaysinh
            // 
            Ngaysinh.HeaderText = "Ngaysinh";
            Ngaysinh.MinimumWidth = 6;
            Ngaysinh.Name = "Ngaysinh";
            Ngaysinh.Width = 125;
            // 
            // FrmEM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 575);
            Controls.Add(dgvEmployee);
            Controls.Add(button1);
            Name = "FrmEM";
            Text = "FrmEM";
            Load += FrmEM_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn MaNhanvien;
        private DataGridViewTextBoxColumn TenNhanvien;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn MaPhongBan;
        private DataGridViewTextBoxColumn Chucvu;
        private DataGridViewTextBoxColumn Ngaysinh;
    }
}