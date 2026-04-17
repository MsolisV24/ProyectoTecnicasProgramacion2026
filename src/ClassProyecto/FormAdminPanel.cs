using System.Xml.Linq;
using ClassController;
using ClassModels;

namespace ClassProyecto
{
    /// <summary>
    /// initialize admin panel form, load users and products, handle add/delete operations for both users and products
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormAdminPanel : Form
    {
        private readonly AdminService _adminService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormAdminPanel"/> class.
        /// </summary>
        /// <param name="adminService">The admin service.</param>
        public FormAdminPanel(AdminService adminService)
        {
            InitializeComponent();
            _adminService = adminService;
            LoadUsers();
            LoadProducts();
        }

        private void LoadUsers()
        {
            var users = _adminService.GetAllUsers();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;

            if (dgvUsers.Columns.Contains("Password"))
                dgvUsers.Columns["Password"].Visible = false;
        }

        private void LoadProducts()
        {
            var products = _adminService.GetAllProducts();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var lastName = txtLastName.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            var newUser = new Customer
            {
                Name = name,
                LastName = lastName,
                Username = username,
                Password = password,
                Directions = "[]"
            };

            if (_adminService.AddUser(newUser))
            {
                MessageBox.Show("User added successfully");
                ClearUserFields();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("User already exists");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            var username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            if (MessageBox.Show($"Delete user {username}?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_adminService.DeleteUser(username))
                {
                    MessageBox.Show("User deleted");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Cannot delete this user");
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var name = txtProductName.Text.Trim();
            var price = nudPrice.Value;
            var peopleId = (int)nudPeopleId.Value;
            var dietId = (int)nudDietId.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter product name");
                return;
            }

            var newProduct = new Product
            {
                Name = name,
                Price = price,
                PeopleId = peopleId,
                DietId = dietId,
                Unit = "kcal"
            };

            if (_adminService.AddProduct(newProduct))
            {
                MessageBox.Show("Product added successfully");
                txtProductName.Clear();
                nudPrice.Value = 0;
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Product already exists");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            int productId = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
            string productName = dgvProducts.CurrentRow.Cells["Name"].Value.ToString();

            if (MessageBox.Show($"Delete product {productName}?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_adminService.DeleteProduct(productId))
                {
                    MessageBox.Show("Product deleted");
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Cannot delete this product");
                }
            }
        }

        private void ClearUserFields()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
