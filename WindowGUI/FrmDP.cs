using System.Data;
using System.Data.SqlClient;

namespace WindowGUI
{
    public partial class FrmDP : Form
    {
        public FrmDP()
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


    }
}
