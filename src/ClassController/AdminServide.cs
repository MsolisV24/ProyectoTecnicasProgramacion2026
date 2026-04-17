using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements the logic for managing users and products, including adding, deleting, and retrieving data. It interacts with the underlying data storage (files) to persist changes made to users and products.
    /// </summary>
    public class AdminService
    {
        private readonly List<Customer> _users;
        private readonly List<Product> _products;
        private readonly List<InventoryItem> _inventory;
        private readonly string _usersPath;
        private readonly string _productsPath;
        private readonly string _inventoryPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminService"/> class.
        /// </summary>
        /// <param name="users">The users.</param>
        /// <param name="products">The products.</param>
        /// <param name="inventory">The inventory.</param>
        /// <param name="usersPath">The users path.</param>
        /// <param name="productsPath">The products path.</param>
        /// <param name="inventoryPath">The inventory path.</param>
        public AdminService(
            List<Customer> users,
            List<Product> products,
            List<InventoryItem> inventory,
            string usersPath,
            string productsPath,
            string inventoryPath)
        {
            _users = users;
            _products = products;
            _inventory = inventory;
            _usersPath = usersPath;
            _productsPath = productsPath;
            _inventoryPath = inventoryPath;
        }
        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllUsers()
        {
            return _users.ToList();
        }
        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="newUser">The new user.</param>
        /// <returns></returns>
        public bool AddUser(Customer newUser)
        {
            if (_users.Any(u => u.Username == newUser.Username))
                return false;

            int newId = _users.Count > 0 ? _users.Max(u => u.Id) + 1 : 1;
            newUser.Id = newId;

            _users.Add(newUser);
            SaveUsers();
            return true;
        }
        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public bool DeleteUser(string username)
        {
            if (username == "admin")
                return false;

            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return false;

            _users.Remove(user);
            SaveUsers();
            return true;
        }

        private void SaveUsers()
        {
            var lines = new List<string>();
            foreach (var u in _users)
            {
                lines.Add($"{u.Name},{u.LastName},{u.Username},{u.Password},{u.Directions ?? "[]"}");
            }
            File.WriteAllLines(_usersPath, lines);
        }
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            return _products.ToList();
        }
        /// <summary>
        /// Adds the product.
        /// </summary>
        /// <param name="newProduct">The new product.</param>
        /// <returns></returns>
        public bool AddProduct(Product newProduct)
        {
            if (_products.Any(p => p.Name == newProduct.Name))
                return false;

            int newId = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            newProduct.Id = newId;

            _products.Add(newProduct);

            _inventory.Add(new InventoryItem
            {
                ProductId = newId,
                QuantityAvailable = 100
            });

            SaveProducts();
            SaveInventory();
            return true;
        }
        /// <summary>
        /// Deletes the product.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public bool DeleteProduct(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
                return false;

            _products.Remove(product);

            var inventory = _inventory.FirstOrDefault(i => i.ProductId == productId);
            if (inventory != null)
                _inventory.Remove(inventory);

            SaveProducts();
            SaveInventory();
            return true;
        }

        private void SaveProducts()
        {
            var lines = new List<string>();
            foreach (var p in _products)
            {
                lines.Add($"{p.Id},{p.PeopleId},{p.DietId},{p.Name},{p.Unit},{p.Price}");
            }
            File.WriteAllLines(_productsPath, lines);
        }

        private void SaveInventory()
        {
            var lines = new List<string>();
            foreach (var i in _inventory)
            {
                lines.Add($"{i.ProductId},{i.QuantityAvailable}");
            }
            File.WriteAllLines(_inventoryPath, lines);
        }
    }
}
