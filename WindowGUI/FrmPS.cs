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

        }
    }
}
