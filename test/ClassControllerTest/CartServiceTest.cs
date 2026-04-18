namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.CartService"/> class.
    /// </summary>
    [TestClass]
    public class CartServiceTest
    {
        /// <summary>
        /// Gets the current cart should return empty cart when no items added.
        /// </summary>
        [TestMethod]
            public void GetCurrentCart_ShouldReturnEmptyCart_WhenNoItemsAdded()
            {
                // Arrange
                var cartService = new ClassController.CartService(new List<ClassModels.Product>(), new List<ClassModels.InventoryItem>(), new List<ClassModels.DatesRecord>());
                // Act
                var cart = cartService.GetCurrentCart();
                // Assert
                Assert.IsNotNull(cart);
                Assert.AreEqual(0, cart.Items.Count);
        }
        /// <summary>
        /// Sets the current user and diet should set username and diet identifier.
        /// </summary>
        [TestMethod]
        public void SetCurrentUserAndDiet_ShouldSetUsernameAndDietId()
        {
            // Arrange
            var cartService = new ClassController.CartService(new List<ClassModels.Product>(), new List<ClassModels.InventoryItem>(), new List<ClassModels.DatesRecord>());
            // Act
            cartService.SetCurrentUserAndDiet("testuser", 1);
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual("testuser", cart.Username);
            Assert.AreEqual(1, cart.DietId);
        }
    }
}