namespace WindowGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thiết lập form để hiển thị ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form currentChildForm;
        private void ShowChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false; // Không hiển thị tiêu đề
            childForm.FormBorderStyle = FormBorderStyle.None; // Không viền
            childForm.Dock = DockStyle.Fill; // Để lấp đầy panel

            pnlForm.Controls.Clear(); // Xóa các điều khiển cũ (nếu cần)
            pnlForm.Controls.Add(childForm); // Thêm form con vào panel
            childForm.Show(); // Hiển thị form
        }


        private void mnuMenuEmploy_Click(object sender, EventArgs e)
        {
            FrmEM frmEM = new FrmEM();
            ShowChildForm(frmEM);
        }

        private void mnuMenuDepartment_Click(object sender, EventArgs e)
        {
            FrmDP frmDp = new FrmDP();
            ShowChildForm(frmDp);
        }

        private void mnuMenuPosition_Click(object sender, EventArgs e)
        {
            FrmPS frmDp = new FrmPS();
            ShowChildForm(frmDp);
        }
    }
}
