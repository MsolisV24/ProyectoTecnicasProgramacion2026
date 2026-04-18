using ClassController;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.CalculatorIMC"/> class.
    /// </summary>
    [TestClass]
    public class CalculatorIMCTest
    {
        /// <summary>
        /// Calculates the imc should return correct imc.
        /// </summary>
        [TestMethod]
        public void CalculateIMC_ShouldReturnCorrectIMC()
        {
            // Arrange
            var calculator = new ClassController.IMCService();
            double weight = 70; // kg
            double height = 1.75; // meters
            // Act
            double imc = calculator.Calculate(weight, height);
            // Assert
            Assert.AreEqual(22.86, Math.Round(imc, 2));
        }

    }
}