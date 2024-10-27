using Microsoft.VisualBasic;
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

namespace WindowGUI
{
    public partial class FrmDPAdd : Form
    {

        public FrmDPAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Khởi tạo thông điệp thông báo
            List<string> missingFields = new List<string>();

            // Kiểm tra từng trường
            if (string.IsNullOrEmpty(tbID.Text))
            {
                missingFields.Add("Mã phòng ban");
            }
            else
            {
                if (IsValueExists("MaPhongBan", tbID.Text))
                {
                    MessageBox.Show($"Mã phòng ban [{tbID.Text}] đã tồn tại. Vui lòng nhập lại.");
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbName.Text))
            {
                missingFields.Add("Tên phòng ban");
            }
            else
            {
                if (IsValueExists("TenPhongBan", tbName.Text))
                {
                    MessageBox.Show($"Tên phòng ban [{tbName.Text}] đã tồn tại. Vui lòng nhập lại.");
                    return;
                }
            }
            // Kiểm tra xem có trường nào thiếu không
            if (missingFields.Count > 0)
            {
                string message = "Vui lòng nhập: " + string.Join(", ", missingFields);
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddDepartment(tbID.Text, tbName.Text);
            this.Close();
        }
        private void FrmDPAdd_Load(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValueExists(string column, string value)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM PhongBan WHERE {column} = @{column}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue($"@{column}", value);
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

        private void AddDepartment(string id, string name)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO PhongBan (MaPhongBan, TenPhongBan) VALUES (@MaPhongBan, @TenPhongBan)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MaPhongBan", id);
                        sqlCommand.Parameters.AddWithValue("@TenPhongBan", name);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void FrmDPAdd_Load_1(object sender, EventArgs e)
        {

        }
    }
}
