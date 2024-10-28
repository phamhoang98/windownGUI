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
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            Ngaysinh = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
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
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { MaNhanvien, TenNhanvien, Email, DiaChi, GioiTinh, TenPhongBan, TenChucVu, Ngaysinh, edit, delete });
            dgvEmployee.Location = new Point(12, 57);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(776, 402);
            dgvEmployee.TabIndex = 1;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // MaNhanvien
            // 
            MaNhanvien.DataPropertyName = "MaNhanvien";
            MaNhanvien.HeaderText = "Mã nhân viên";
            MaNhanvien.MinimumWidth = 6;
            MaNhanvien.Name = "MaNhanvien";
            MaNhanvien.ReadOnly = true;
            MaNhanvien.Resizable = DataGridViewTriState.True;
            MaNhanvien.Width = 126;
            // 
            // TenNhanvien
            // 
            TenNhanvien.DataPropertyName = "TenNhanvien";
            TenNhanvien.HeaderText = "Tên nhân viên";
            TenNhanvien.MinimumWidth = 6;
            TenNhanvien.Name = "TenNhanvien";
            TenNhanvien.ReadOnly = true;
            TenNhanvien.Width = 128;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 75;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 84;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 94;
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Phòng ban";
            TenPhongBan.MinimumWidth = 6;
            TenPhongBan.Name = "TenPhongBan";
            TenPhongBan.ReadOnly = true;
            TenPhongBan.Width = 109;
            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Chức vụ";
            TenChucVu.MinimumWidth = 6;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.ReadOnly = true;
            TenChucVu.Width = 90;
            // 
            // Ngaysinh
            // 
            Ngaysinh.DataPropertyName = "Ngaysinh";
            Ngaysinh.HeaderText = "Ngày sinh";
            Ngaysinh.MinimumWidth = 6;
            Ngaysinh.Name = "Ngaysinh";
            Ngaysinh.ReadOnly = true;
            Ngaysinh.Width = 103;
            // 
            // edit
            // 
            edit.HeaderText = "Sửa";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Width = 40;
            // 
            // delete
            // 
            delete.HeaderText = "Xoá";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Width = 41;
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
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn TenPhongBan;
        private DataGridViewTextBoxColumn TenChucVu;
        private DataGridViewTextBoxColumn Ngaysinh;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}