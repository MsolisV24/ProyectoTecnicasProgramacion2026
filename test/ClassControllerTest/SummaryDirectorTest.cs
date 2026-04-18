using ClassController;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="SummaryDirector"/> class.
    /// </summary>
    [TestClass]
    public class SummaryDirectorTest
    {
        /// <summary>
        /// Creates the summary should handle empty diet.
        /// </summary>
        [TestMethod]
        public void CreateSummary_ShouldHandleEmptyDiet()
        {
            // Arrange
            var builder = new SummaryBuilder();
            var director = new SummaryDirector();
            string diet = "";
            decimal subtotal = 50m;
            // Act
            var summary = director.CreateSummary(builder, diet, subtotal);
            // Assert
            Assert.IsNotNull(summary);
            Assert.AreEqual(diet, summary.Diet);
            Assert.AreEqual(subtotal, summary.Subtotal);
        }
    }
}
