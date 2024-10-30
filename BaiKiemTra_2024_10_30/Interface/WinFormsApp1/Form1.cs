using ProductManagement;
namespace BaiKiemTra
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart;
        private OrderCalculator calculator;
        public Form1()
        {
            InitializeComponent();
            cart = new ShoppingCart(new Order());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var product = new Product
                {
                    Name = selectedRow.Cells["ColumnName"].Value.ToString(),
                    Price = Convert.ToDecimal(selectedRow.Cells["ColumnPrice"].Value),
                    Quantity = 1 // Mặc định số lượng là 1
                };

                cart.addProduct(product); // shoppingCart là đối tượng ShoppingCart của bạn

                // Cập nhật DataGridView cho giỏ hàng
                dataGridView2.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                dataGridView2.DataSource = cart.obj; // Cập nhật nguồn dữ liệu
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm vào giỏ hàng.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];
                var productName = selectedRow.Cells["ColumnName"].Value.ToString();

                var productToRemove = cart.obj.FirstOrDefault(p => p.Name == productName);
                if (productToRemove != null)
                {
                    cart.removeProduct(productToRemove); // Xóa sản phẩm khỏi giỏ hàng

                    // Cập nhật DataGridView cho giỏ hàng
                    dataGridView2.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                    dataGridView2.DataSource = cart.obj; // Cập nhật nguồn dữ liệu
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa khỏi giỏ hàng.");
            }
        }
    }
}
