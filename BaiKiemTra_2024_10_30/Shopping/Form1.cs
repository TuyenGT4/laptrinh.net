using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Shopping
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart;
        private OrderCalculator calculator;
        private decimal totalOrderValue = 0;

        public Form1()
        {
            InitializeComponent();
            cart = new ShoppingCart(new Order());

        }

        private void UpdateTotalOrderValue()
        {
            totalOrderValue = cart.GetTotalOrderValue();
            //lblTotalValue.Text = $"Tổng giá trị: {totalOrderValue:C}";
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

                cart.addProduct(product);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cart.obj;

                UpdateTotalOrderValue(); // Cập nhật tổng giá trị
                MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng.");
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
                    cart.removeProduct(productToRemove);

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = cart.obj;

                    UpdateTotalOrderValue(); // Cập nhật tổng giá trị
                    MessageBox.Show("Sản phẩm đã được xóa khỏi giỏ hàng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa khỏi giỏ hàng.");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cart.obj.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống. Vui lòng thêm sản phẩm trước khi thanh toán.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Xác nhận thanh toán {totalOrderValue:C}?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Xóa sạch giỏ hàng
                cart.obj.Clear();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cart.obj;

                // Đặt lại tổng giá trị
                totalOrderValue = 0;
                UpdateTotalOrderValue();

                MessageBox.Show("Thanh toán thành công. Giỏ hàng đã được xóa.");
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {

        }
    }
}
