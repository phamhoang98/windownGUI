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
using System.Xml.Linq;

namespace WindowGUI
{
    public partial class FrmPSAdd : Form
    {
        public string? id;
        public string? name;
        public FrmPSAdd()
        {
            InitializeComponent();
            // Thiết lập form để hiển thị ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo thông điệp thông báo
            List<string> missingFields = new List<string>();

            // Kiểm tra từng trường
            if (string.IsNullOrEmpty(tbID.Text))
            {
                missingFields.Add("Mã chức vụ");
            }
            else
            {
                if (id == null && IsValueExists("MaChucVu", tbID.Text))
                {
                    MessageBox.Show($"Mã chức vụ [{tbID.Text}] đã tồn tại. Vui lòng nhập lại.");
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbName.Text))
            {
                missingFields.Add("Tên chức vụ");
            }
            else
            {
                if (tbName.Text != name && IsValueExists("TenChucVu", tbName.Text))
                {
                    MessageBox.Show($"Tên chức vụ [{tbName.Text}] đã tồn tại. Vui lòng nhập lại.");
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
            if (id == null)
            {
                AddPosition(tbID.Text, tbName.Text);
            }
            else
            {
                EditPosition(tbID.Text, tbName.Text);
            }


            this.Close();
        }

        private bool IsValueExists(string column, string value)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM ChucVu WHERE {column} = @{column}";
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

        private void AddPosition(string id, string name)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO ChucVu (MaChucVu, TenChucVu) VALUES (@MaChucVu, @TenChucVu)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MaChucVu", id);
                        sqlCommand.Parameters.AddWithValue("@TenChucVu", name);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void EditPosition(string id, string name)
        {
            using (SqlConnection connection = new SqlConnection(AppData.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE  ChucVu SET TenChucVu = @TenChucVu WHERE MaChucVu= @MaChucVu";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MaChucVu", id);
                        sqlCommand.Parameters.AddWithValue("@TenChucVu", name);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }

        private void FrmPSAdd_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                tbID.Text = id;
                tbID.Enabled = false;
                btnAdd.Text = "Edit";
            }
            if (name != null)
            {
                tbName.Text = name;

            }
        }


    }
}
