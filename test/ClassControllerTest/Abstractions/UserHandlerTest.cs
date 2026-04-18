using ClassController.Abstractions;
using ClassModels;
using Moq;

namespace ClassControllerTest.Abstractions
{
    /// <summary>
    /// tests for the <see cref="ClassController.Abstractions.UserHandler"/> class.
    /// </summary>
    [TestClass]
    public class UserHandlerTest
    {
        /// <summary>
        /// Saves the users should return true when data is saved successfully.
        /// </summary>
        [TestMethod]
        public void saveUsers_ShouldReturnTrue_WhenDataIsSavedSuccessfully()
        {
            // Arrange
            var mockDataHandler = new Mock<IDataHandler<Customer>>();
            mockDataHandler.Setup(dh => dh.SaveData(It.IsAny<List<Customer>>(), It.IsAny<string>())).Returns(true);
            var userHandler = new UserHandler(mockDataHandler.Object);
            userHandler.Customers.Add(new Customer { Name = "John Doe" });
            // Act
            var result = userHandler.SaveUsers("users.csv");
            // Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Loads the users should return true when data is loaded successfully.
        /// </summary>
        [TestMethod]
        public void loadUsers_ShouldReturnTrue_WhenDataIsLoadedSuccessfully()
        {
            // Arrange
            var mockDataHandler = new Mock<IDataHandler<Customer>>();
            var customers = new List<Customer> { new Customer { Name = "John Doe" } };
            mockDataHandler.Setup(dh => dh.LoadData(It.IsAny<string>())).Returns(customers);
            var userHandler = new UserHandler(mockDataHandler.Object);
            // Act
            var result = userHandler.LoadUsers("users.csv");
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, userHandler.Customers.Count);
            Assert.AreEqual("John Doe", userHandler.Customers[0].Name);
        }
    }
}
