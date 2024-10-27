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
                    string query = "SELECT * FROM NhanVien";
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
                    MessageBox.Show("Lỗi: " + ex.Message);
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

        }
    }
}
