using System.Data;
using ClassModels;

namespace ClassController
{

    /// <summary>
    /// implementation of market controller
    /// </summary>
    public class MarketController
    {
        /// <summary>
        /// The loader
        /// </summary>
        private readonly IDataLoader _loader;

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public List<Customer> Username { get; private set; } = new();

        /// <summary>
        /// Gets the peoples.
        /// </summary>
        /// <value>
        /// The peoples.
        /// </value>
        public List<People> Peoples { get; private set; } = new();

        /// <summary>
        /// Gets the diets.
        /// </summary>
        /// <value>
        /// The diets.
        /// </value>
        public List<Diet> Diets { get; private set; } = new();

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public List<Product> Products { get; private set; } = new();

        /// <summary>
        /// Gets the inventory.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public List<InventoryItem> Inventory { get; private set; } = new();

        /// <summary>
        /// Gets the expense history.
        /// </summary>
        /// <value>
        /// The expense history.
        /// </value>
        public List<DatesRecord> DatesHistory { get; private set; } = new();

        /// <summary>
        /// The cart
        /// </summary>
        private ICartService _cart;

        /// <summary>
        /// The stats
        /// </summary>
        private IStatisticsService _stats;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketController"/> class.
        /// </summary>
        public MarketController()
        {
            _loader = new DataLoaderCsv();
        }

        public MarketController(IDataLoader @object)
        {
        }

        /// <summary>
        /// Loads the CSV files.
        /// </summary>
        /// <param name="usersCsv">The users CSV.</param>
        /// <param name="peopleCsv">The people CSV.</param>
        /// <param name="dietCsv">The diet CSV.</param>
        /// <param name="productsCsv">The products CSV.</param>
        /// <param name="inventoryCsv">The inventory CSV.</param>
        /// <param name="datesCsv">The dates CSV.</param>
        public void LoadCsvFiles(
            string usersCsv,
            string peopleCsv,
            string dietCsv,
            string productsCsv,
            string inventoryCsv,
            string datesCsv)
        {
            Username = _loader.LoadCsv<Customer>(usersCsv);
            Peoples = _loader.LoadCsv<People>(peopleCsv);
            Diets = _loader.LoadCsv<Diet>(dietCsv);
            Products = _loader.LoadCsv<Product>(productsCsv);
            Inventory = _loader.LoadCsv<InventoryItem>(inventoryCsv);
            DatesHistory = _loader.LoadCsv<DatesRecord>(datesCsv);

            _cart = new CartService(Products, Inventory, DatesHistory);
            _stats = new StatisticsService(DatesHistory, Peoples, Products);

        }

        /// <summary>
        /// Carts this instance.
        /// </summary>
        /// <returns></returns>
        public ICartService Cart() => _cart;

        /// <summary>
        /// Statisticses this instance.
        /// </summary>
        /// <returns></returns>
        public IStatisticsService Statistics() => _stats;
    }
}
