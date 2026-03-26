using ClassModels;

namespace ClassProyecto
{
    /// <summary>
    /// implementation of FormAddProduct, a form to add a product to the cart
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormAddProduct : Form
    {
        private List<Product> _products;

        /// <summary>
        /// Gets the selected product.
        /// </summary>
        /// <value>
        /// The selected product.
        /// </value>
        public Product SelectedProduct { get; private set; }
        /// <summary>
        /// Gets the selected quantity.
        /// </summary>
        /// <value>
        /// The selected quantity.
        /// </value>
        public decimal SelectedQuantity { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormAddProduct"/> class.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <param name="dietId">The diet identifier.</param>
        public FormAddProduct(List<Product> products, int dietId)
        {
            InitializeComponent();
            _products = products.Where(x => x.DietId == dietId).ToList();
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            cmbProducts.DataSource = _products;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Id";

            nudQuantity.Value = 1;
            nudQuantity.Minimum = 0.1M;
            nudQuantity.Maximum = 999;
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product p)
            {
                lblUnit.Text = p.Unit;
                lblPrice.Text = p.UnitPrice.ToString("N2");
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product p)
            {
                SelectedProduct = p;
                SelectedQuantity = nudQuantity.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
