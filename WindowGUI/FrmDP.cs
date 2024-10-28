using System.Data;
using System.Data.SqlClient;

namespace WindowGUI
{
    public partial class FrmDP : Form
    {
        public FrmDP()
        {
            InitializeComponent();
            dgvDepartment.AutoGenerateColumns = false;
        }

        private void loadData()
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM PhongBan";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvDepartment.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDPAdd frmDPAdd = new FrmDPAdd();
            frmDPAdd.FormClosed += Dialog_FormClosed;
            frmDPAdd.ShowDialog();


        }

        private void Dialog_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadData();

        }
        private void FrmDP_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột là cột button
            if (e.ColumnIndex == dgvDepartment.Columns["edit"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột đầu tiên (cột 0)
                string id = dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                string name = dgvDepartment.Rows[e.RowIndex].Cells[1].Value.ToString()!;
                eidt_department(id, name);
            }
            if (e.ColumnIndex == dgvDepartment.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị từ cột đầu tiên (cột 0)
                string? value = dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                delete_department(value!);
            }
        }

        private void delete_department(string id)
        {
            DialogResult result = MessageBox.Show($"Bạn có muốn xóa Phòng [{id}] này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                // Thực hiện hành động xóa ở đây       
                if (IsEmployeeExists(id))
                {
                    MessageBox.Show("Phòng ban đang tồn tại nhân viên, vui lòng chuyển phòng ban cho nhân viên để tiếp tục xoá!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(AppData.connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM PhongBan WHERE MaPhongBan = @MaPhongBan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaPhongBan", id);
                        command.ExecuteNonQuery();
                    }
                }
                loadData();
            }
        }

        private void eidt_department(string id, string name)
        {

            FrmDPAdd frmDPAdd = new FrmDPAdd();
            frmDPAdd.id = id;
            frmDPAdd.name = name;
            frmDPAdd.FormClosed += Dialog_FormClosed;
            frmDPAdd.ShowDialog();
        }

        private bool IsEmployeeExists(string id)
        {
            string query = @"
                SELECT COUNT(*)
                FROM NhanVien
                WHERE MaPhongBan = (
                    SELECT MaPhongBan 
                    FROM PhongBan 
                    WHERE MaPhongBan = @MaPhongBan)";

            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                command.Parameters.AddWithValue("@MaPhongBan", id);
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
