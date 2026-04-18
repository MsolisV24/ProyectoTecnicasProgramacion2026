using ClassController;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.CaloriasService"/> class.
    /// </summary>
    [TestClass]
    public class CaloriasServiceTest
    {
        /// <summary>
        /// Calculates for male returns correct calories.
        /// </summary>
        [TestMethod]
        public void Calculate_ForMale_ReturnsCorrectCalories()
        {
            // Arrange
            CaloriasService service = new CaloriasService();
            double weight = 70;
            double height = 1.75;
            int age = 30;
            string gender = "M";
            int activity = 1;
            // Act
            double resultado = service.Calculate(weight, height, age, gender, activity);
            // Assert
            Assert.AreEqual(2267.03, resultado, 0.01);
        }
        /// <summary>
        /// Calculates for female returns correct calories.
        /// </summary>
        [TestMethod]
        public void Calculate_ForFemale_ReturnsCorrectCalories()
        {
            // Arrange
            CaloriasService service = new CaloriasService();
            double weight = 60;
            double height = 1.65;
            int age = 25;
            string gender = "F";
            int activity = 0;
            // Act
            double resultado = service.Calculate(weight, height, age, gender, activity);
            // Assert
            Assert.AreEqual(1614.3, resultado, 0.01);
        }
    }
}
