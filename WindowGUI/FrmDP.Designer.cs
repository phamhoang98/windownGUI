namespace WindowGUI
{
    partial class FrmDP
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
            btnAdd = new Button();
            dgvDepartment = new DataGridView();
            MaPhongBan = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(561, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Columns.AddRange(new DataGridViewColumn[] { MaPhongBan, TenPhongBan, edit, delete });
            dgvDepartment.Location = new Point(12, 57);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.Size = new Size(643, 349);
            dgvDepartment.TabIndex = 9;
            dgvDepartment.CellContentClick += dgvDepartment_CellContentClick;
            // 
            // MaPhongBan
            // 
            MaPhongBan.DataPropertyName = "MaPhongBan";
            MaPhongBan.HeaderText = "Mã ";
            MaPhongBan.MinimumWidth = 6;
            MaPhongBan.Name = "MaPhongBan";
            MaPhongBan.ReadOnly = true;
            MaPhongBan.Width = 125;
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Phòng ban";
            TenPhongBan.MinimumWidth = 6;
            TenPhongBan.Name = "TenPhongBan";
            TenPhongBan.ReadOnly = true;
            TenPhongBan.Width = 125;
            // 
            // edit
            // 
            edit.HeaderText = "Sửa";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "Xoá";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Width = 125;
            // 
            // FrmDP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 416);
            Controls.Add(dgvDepartment);
            Controls.Add(btnAdd);
            Name = "FrmDP";
            Text = "FrmDP";
            Load += FrmDP_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvDepartment;
        private DataGridViewTextBoxColumn MaPhongBan;
        private DataGridViewTextBoxColumn TenPhongBan;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}