namespace WindowGUI
{
    partial class FrmPS
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
            dgvPosition = new DataGridView();
            MaChucVu = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPosition).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(430, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvPosition
            // 
            dgvPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosition.Columns.AddRange(new DataGridViewColumn[] { MaChucVu, TenChucVu, edit, delete });
            dgvPosition.Location = new Point(12, 60);
            dgvPosition.Name = "dgvPosition";
            dgvPosition.RowHeadersWidth = 51;
            dgvPosition.Size = new Size(512, 342);
            dgvPosition.TabIndex = 16;
            dgvPosition.CellContentClick += dgvPosition_CellContentClick;
            // 
            // MaChucVu
            // 
            MaChucVu.DataPropertyName = "MaChucVu";
            MaChucVu.HeaderText = "Mã Chức Vụ";
            MaChucVu.MinimumWidth = 6;
            MaChucVu.Name = "MaChucVu";
            MaChucVu.ReadOnly = true;
            MaChucVu.Width = 125;
            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Tên Chức Vụ";
            TenChucVu.MinimumWidth = 6;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.ReadOnly = true;
            TenChucVu.Width = 125;
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
            // FrmPS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 430);
            Controls.Add(dgvPosition);
            Controls.Add(btnAdd);
            Name = "FrmPS";
            Text = "FrmPS";
            Load += FrmPS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPosition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvPosition;
        private DataGridViewTextBoxColumn MaChucVu;
        private DataGridViewTextBoxColumn TenChucVu;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}