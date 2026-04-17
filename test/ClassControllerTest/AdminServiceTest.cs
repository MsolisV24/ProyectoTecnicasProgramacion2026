using ClassModels;
using ClassController;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.AdminService"/> class.
    /// </summary>
    [TestClass]
    public class AdminServiceTest
    {
        /// <summary>
        /// Adds the user should return true when user is added successfully.
        /// </summary>
        [TestMethod]
        public void AddUser_ShouldReturnTrue_WhenUserIsAddedSuccessfully()
        {
            // Arrange
            var users = new List<Customer>();
            var products = new List<Product>();
            var inventory = new List<InventoryItem>();
            var adminService = new AdminService(users, products, inventory, "users.csv", "products.csv", "inventory.csv");
            var newUser = new Customer { Username = "johndoe" };
            // Act
            var result = adminService.AddUser(newUser);
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, users.Count);
            Assert.AreEqual("johndoe", users[0].Username);
        }
        /// <summary>
        /// Deletes the user should return true when user is deleted successfully.
        /// </summary>
        [TestMethod]
        public void DeleteUser_ShouldReturnTrue_WhenUserIsDeletedSuccessfully()
        {
            // Arrange
            var users = new List<Customer> { new Customer { Username = "johndoe" } };
            var products = new List<Product>();
            var inventory = new List<InventoryItem>();
            var adminService = new AdminService(users, products, inventory, "users.csv", "products.csv", "inventory.csv");
            // Act
            var result = adminService.DeleteUser("johndoe");
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(0, users.Count);
        }
        /// <summary>
        /// Adds the product should return true when product is added successfully.
        /// </summary>
        [TestMethod]
        public void AddProduct_ShouldReturnTrue_WhenProductIsAddedSuccessfully()
        {
            // Arrange
            var users = new List<Customer>();
            var products = new List<Product>();
            var inventory = new List<InventoryItem>();
            var adminService = new AdminService(users, products, inventory, "users.csv", "products.csv", "inventory.csv");
            var newProduct = new Product { Name = "Laptop" };
            // Act
            var result = adminService.AddProduct(newProduct);
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, products.Count);
            Assert.AreEqual("Laptop", products[0].Name);
        }
    }
}