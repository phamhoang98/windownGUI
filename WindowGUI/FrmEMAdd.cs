using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowGUI
{
    public partial class FrmEMAdd : Form
    {

        private void LoadComboBoxData(ComboBox comboBox, string query, string column)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[$"{column}"].ToString()!);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        public FrmEMAdd()
        {
            InitializeComponent();
            // Thiết lập form để hiển thị ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            dtpDate.MaxDate = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Khởi tạo thông điệp thông báo
            List<string> missingFields = new List<string>();

            // Kiểm tra từng trường
            if (string.IsNullOrEmpty(txID.Text))
            {
                missingFields.Add("Mã nhân viên");
            }
            else
            {
                if (IsPrimaryKeyExists(txID.Text))
                {
                    MessageBox.Show($"Mã nhân viên [{txID.Text}] đã tồn tại. Vui lòng nhập lại.");
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbName.Text))
            {
                missingFields.Add("Tên");
            }
            if (!rbMale.Checked && !rbFeMale.Checked)
            {
                missingFields.Add("Giới tính");
            }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                missingFields.Add("Email");
            }
            else {
                if (IsValidEmail(tbEmail.Text) != true)
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.");
                    return;
                }
            }
            if (string.IsNullOrEmpty(cbDepartment.SelectedItem as string))
            {
                missingFields.Add("Phòng Ban");
            }
            if (string.IsNullOrEmpty(cbPosition.SelectedItem as string))
            {
                missingFields.Add("Chức Vụ");
            }
            // Kiểm tra xem có trường nào thiếu không
            if (missingFields.Count > 0)
            {
                string message = "Vui lòng nhập: " + string.Join(", ", missingFields);
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddEmployee(new Employee(txID.Text, tbName.Text, "0987654321", tbEmail.Text, tbAddress.Text, rbMale.Checked ? "Nam" : "Nữ", cbDepartment.SelectedItem as string ?? "", cbPosition.SelectedItem as string ?? "", dtpDate.Value.Date));
            this.Close();
        }

        private void FrmEMAdd_Load(object sender, EventArgs e)
        {
            LoadComboBoxData(cbDepartment, "SELECT * FROM PhongBan", "TenPhongBan");
            LoadComboBoxData(cbPosition, "SELECT * FROM ChucVu", "TenChucVu");
        }

        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsPrimaryKeyExists(string maNhanvien)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanvien = @MaNhanvien";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhanvien", maNhanvien);
                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Trả về true nếu có ít nhất 1 bản ghi
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        private void AddEmployee(Employee employee) {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO NhanVien (MaNhanvien, TenNhanvien,SDT,Email,DiaChi,GioiTinh,PhongBan,Chucvu,Ngaysinh) VALUES (@MaNhanvien, @TenNhanvien,@SDT,@Email,@DiaChi,@GioiTinh,@PhongBan,@Chucvu,@Ngaysinh)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MaNhanvien", employee.id);
                        sqlCommand.Parameters.AddWithValue("@TenNhanvien", employee.name);
                        sqlCommand.Parameters.AddWithValue("@SDT", employee.phone);
                        sqlCommand.Parameters.AddWithValue("@Email", employee.email);
                        sqlCommand.Parameters.AddWithValue("@DiaChi", employee.address);
                        sqlCommand.Parameters.AddWithValue("@GioiTinh", employee.sex);
                        sqlCommand.Parameters.AddWithValue("@PhongBan", employee.department);
                        sqlCommand.Parameters.AddWithValue("@Chucvu", employee.position);
                        sqlCommand.Parameters.AddWithValue("@Ngaysinh", employee.date);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

    }
}
