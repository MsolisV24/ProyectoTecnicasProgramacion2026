using ClassController;
using Moq;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.MarketController"/> class.
    /// </summary>
    [TestClass]
    public class MarketControllerTest
    {
        /// <summary>
        /// Markets the controller should initialize with loader.
        /// </summary>
        [TestMethod]
        public void MarketController_ShouldInitializeWithLoader()
        {
            // Arrange
            var mockLoader = new Mock<IDataLoader>();
            // Act
            var marketController = new MarketController(mockLoader.Object);
            // Assert
            Assert.IsNotNull(marketController);
        }
}
}
