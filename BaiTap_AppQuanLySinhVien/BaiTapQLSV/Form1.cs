namespace BaiTapQLSV
{
    public partial class Form1 : Form
    {
        public DanhSachSinhVien list;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(tbMaSV.Text);
            string ten = tbTenSV.Text;
            string gioiTinh = "Nam";
            if (rbtnNam.Checked)
            {
                gioiTinh = "Nam";
            } else if (rbtnNu.Checked)
            {
                gioiTinh = "Nu";
            }
            DateOnly ngaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
            string diaChi = tbDiaChi.Text;
            string email = tbEmail.Text;
            string sdt = tbSoDienThoai.Text;
            SinhVien sv = new SinhVien(ma, ten, gioiTinh, ngaySinh, diaChi, email, sdt);
            list.themSinhVien(sv);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
