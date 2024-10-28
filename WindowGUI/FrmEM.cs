using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class FrmEM : Form
    {

        private void loadData()
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    NhanVien.MaNhanvien, 
                    NhanVien.TenNhanvien, 
                    NhanVien.Email, 
                    NhanVien.DiaChi, 
                    NhanVien.GioiTinh, 
                    NhanVien.Ngaysinh, 
                    PhongBan.TenPhongBan, 
                    ChucVu.TenChucVu 
                FROM 
                    NhanVien
                JOIN 
                    PhongBan ON NhanVien.MaPhongBan = PhongBan.MaPhongBan
                JOIN 
                    ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvEmployee.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi : " + ex.Message);
                }
            }
        }
        public FrmEM()
        {
            InitializeComponent();
            dgvEmployee.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEM_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void add_employee(object sender, EventArgs e)
        {
            FrmEMAdd frmEMAdd = new FrmEMAdd();
            frmEMAdd.FormClosed += Dialog_FormClosed;
            frmEMAdd.ShowDialog();

        }

        private void Dialog_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột là cột button
            if (e.ColumnIndex == dgvEmployee.Columns["edit"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột đầu tiên (cột 0)
                string id = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                string name = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString()!;
                string email = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString()!;
                string address = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString()!;
                string sex = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString()!;
                string department = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString()!;
                string position = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString()!;
                DateTime date = DateTime.Parse(dgvEmployee.Rows[e.RowIndex].Cells[7].Value.ToString()!);
                eidt_employee(new Employee(id, name, null, email, address, sex, department, position, date));
            }
            if (e.ColumnIndex == dgvEmployee.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột đầu tiên (cột 0)
                string? value = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                delete_employee(value!);
            }
        }

        private void delete_employee(string id)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                // Thực hiện hành động xóa ở đây       


                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM NhanVien WHERE MaNhanvien = @MaNhanvien";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanvien", id);
                        command.ExecuteNonQuery();
                    }
                }
                loadData();
            }
        }

        private void eidt_employee(Employee employee)
        {

            FrmEMAdd frmEMAdd = new FrmEMAdd();
            frmEMAdd.DataToForm = employee;
            frmEMAdd.FormClosed += Dialog_FormClosed;
            frmEMAdd.ShowDialog();
        }
    }
}
