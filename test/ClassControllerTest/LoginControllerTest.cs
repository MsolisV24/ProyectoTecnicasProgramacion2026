using ClassController;
using ClassController.Abstractions;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.LoginController"/> class, which is responsible for handling user login functionality. It interacts with the UserHandler to verify user credentials and manage the current user's login state.
    /// </summary>
    [TestClass]
    public class LoginControllerTest
    {
        /// <summary>
        /// Logins the should return true when credentials are valid.
        /// </summary>
        [TestMethod]
        public void Login_ShouldReturnTrue_WhenCredentialsAreValid()
        {
            // Arrange
            var userHandler = new UserHandler(null);
            userHandler.Customers.Add(new ClassModels.Customer { Username = "user1", Password = "pass1" });
            var loginController = new LoginController(userHandler);
            // Act
            var result = loginController.Login("user1", "pass1");
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("user1", loginController.CurrentUser);
            Assert.IsFalse(loginController.IsAdmin);
        }
        /// <summary>
        /// Logins the should return false when credentials are invalid.
        /// </summary>
        [TestMethod]
        public void Login_ShouldReturnFalse_WhenCredentialsAreInvalid()
        {
            // Arrange
            var userHandler = new UserHandler(null);
            userHandler.Customers.Add(new ClassModels.Customer { Username = "user1", Password = "pass1" });
            var loginController = new LoginController(userHandler);
            // Act
            var result = loginController.Login("user1", "wrongpass");
            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(string.Empty, loginController.CurrentUser);
            Assert.IsFalse(loginController.IsAdmin);
        }
        /// <summary>
        /// Currents the user should be admin when admin credentials are used.
        /// </summary>
        [TestMethod]
        public void CurrentUser_ShouldBeAdmin_WhenAdminCredentialsAreUsed()
        {
            // Arrange
            var userHandler = new UserHandler(null);
            var loginController = new LoginController(userHandler);
            // Act
            var result = loginController.Login("admin", "admin");
            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("admin", loginController.CurrentUser);
            Assert.IsTrue(loginController.IsAdmin);
        }
    }
}
