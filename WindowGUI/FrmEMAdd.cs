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
        public Employee? DataToForm { get; set; }
        private void LoadComboBoxDepartment()
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM PhongBan", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbDepartment.Items.Add(reader["TenPhongBan"].ToString()!);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadComboBoxPosition()
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM ChucVu", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbPosition.Items.Add(reader["TenChucVu"].ToString()!);
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
                if (DataToForm == null && IsPrimaryKeyExists(txID.Text) )
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
            else
            {
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
            Employee employee = new Employee(txID.Text, tbName.Text, "098765432", tbEmail.Text,
                tbAddress.Text, rbMale.Checked ? "Nam" : "Nữ", GetIDDeparment(cbDepartment.SelectedItem as string ?? ""),
                 GetIDPosistion(cbPosition.SelectedItem as string ?? ""), dtpDate.Value.Date); ;

            if (DataToForm == null)
            {
                AddEmployee(employee);

            }
            else
            {
                EditEmployee(employee);
            }

            this.Close();
        }

        private void FrmEMAdd_Load(object sender, EventArgs e)
        {
            LoadComboBoxDepartment();
            LoadComboBoxPosition();
            if (DataToForm != null)
            {
                txID.Text = DataToForm.Id;
                txID.Enabled = false;
                tbName.Text = DataToForm.Name;
                if (DataToForm.Sex == "Nam")
                {
                    rbMale.Checked = true;

                }
                else
                {
                    rbFeMale.Checked = true;
                }


                dtpDate.Value = DataToForm.Date;
                tbEmail.Text = DataToForm.Email;
                tbAddress.Text = DataToForm.Address;
                if (cbDepartment.Items.Contains(DataToForm.Department))
                {
                    cbDepartment.SelectedItem = DataToForm.Department;
                }
                if (cbPosition.Items.Contains(DataToForm.Position))
                {
                    cbPosition.SelectedItem = DataToForm.Position;
                }

                btnSave.Text = "Edit";
            }
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

        private void AddEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien,SDT,Email,DiaChi,GioiTinh,MaPhongBan,MaChucvu,Ngaysinh) VALUES (@MaNhanVien, @TenNhanVien,@SDT,@Email,@DiaChi,@GioiTinh,@PhongBan,@Chucvu,@Ngaysinh)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MaNhanVien", employee.Id);
                        sqlCommand.Parameters.AddWithValue("@TenNhanVien", employee.Name);
                        sqlCommand.Parameters.AddWithValue("@SDT", employee.Phone);
                        sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                        sqlCommand.Parameters.AddWithValue("@DiaChi", employee.Address);
                        sqlCommand.Parameters.AddWithValue("@GioiTinh", employee.Sex);
                        sqlCommand.Parameters.AddWithValue("@PhongBan", employee.Department);
                        sqlCommand.Parameters.AddWithValue("@Chucvu", employee.Position);
                        sqlCommand.Parameters.AddWithValue("@Ngaysinh", employee.Date);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void EditEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE NhanVien SET " +
                        "TenNhanVien = @TenNhanVien,Email=@Email, DiaChi=@DiaChi, " +
                        "GioiTinh= @GioiTinh,MaPhongBan = @PhongBan,MaChucvu=@Chucvu,Ngaysinh=@Ngaysinh WHERE MaNhanVien= @MaNhanVien";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MaNhanVien", employee.Id);  
                        sqlCommand.Parameters.AddWithValue("@TenNhanVien", employee.Name);
                        sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                        sqlCommand.Parameters.AddWithValue("@DiaChi", employee.Address);
                        sqlCommand.Parameters.AddWithValue("@GioiTinh", employee.Sex);
                        sqlCommand.Parameters.AddWithValue("@PhongBan", employee.Department);
                        sqlCommand.Parameters.AddWithValue("@Chucvu", employee.Position);
                        sqlCommand.Parameters.AddWithValue("@Ngaysinh", employee.Date);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private string GetIDDeparment(string name)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT MaPhongBan FROM PhongBan WHERE TenPhongBan = @TenPhongBan", connection);

                    using (command)
                    {
                        command.Parameters.AddWithValue("@TenPhongBan", name);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return reader["MaPhongBan"].ToString()!;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            return "";
        }
        private string GetIDPosistion(string name)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT MaChucvu FROM Chucvu WHERE TenChucvu = @TenChucvu", connection);
                    using (command)
                    {
                        command.Parameters.AddWithValue("@TenChucvu", name);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return reader["MaChucvu"].ToString()!;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            return "";
        }
    }
}
