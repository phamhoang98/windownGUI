using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class FrmPS : Form
    {
        public FrmPS()
        {
            InitializeComponent();
            dgvPosition.AutoGenerateColumns = false;
        }
        private void loadData()
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM ChucVu";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvPosition.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void FrmPS_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPSAdd frmPSAdd = new FrmPSAdd();
            frmPSAdd.FormClosed += Dialog_FormClosed;
            frmPSAdd.ShowDialog();
        }
        private void Dialog_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadData();
        }

        private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột là cột button
            if (e.ColumnIndex == dgvPosition.Columns["edit"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột đầu tiên (cột 0)
                string id = dgvPosition.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                string name = dgvPosition.Rows[e.RowIndex].Cells[1].Value.ToString()!;
                eidt_position(id, name);
            }
            if (e.ColumnIndex == dgvPosition.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột đầu tiên (cột 0)
                string? value = dgvPosition.Rows[e.RowIndex].Cells[0].Value.ToString();
                delete_position(value!);
            }
        }

        private void delete_position(string id)
        {
            DialogResult result = MessageBox.Show($"Bạn có muốn xóa Chức vụ [{id}] này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                // Thực hiện hành động xóa ở đây       

                if (IsEmployeeExists(id))
                {
                    MessageBox.Show("Có nhân viên đang đảm nhận chức vụ này, vui lòng chuyển chức vụ cho nhân viên để tiếp tục xoá!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM ChucVu WHERE MaChucVu = @MaChucVu";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaChucVu", id);
                        command.ExecuteNonQuery();
                    }
                }
                loadData();
            }
        }
        private void eidt_position(string id, string name)
        {

            FrmPSAdd frmPSAdd = new FrmPSAdd();
            frmPSAdd.id = id;
            frmPSAdd.name = name;
            frmPSAdd.FormClosed += Dialog_FormClosed;
            frmPSAdd.ShowDialog();
        }

        private bool IsEmployeeExists(string id)
        {
            string query = @"
                SELECT COUNT(*)
                FROM NhanVien
                WHERE MaChucVu = (
                    SELECT MaChucVu 
                    FROM ChucVu 
                    WHERE MaChucVu = @MaChucVu)";

            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                command.Parameters.AddWithValue("@MaChucVu", id);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
