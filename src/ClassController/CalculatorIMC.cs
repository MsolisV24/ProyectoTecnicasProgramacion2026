namespace ClassController
{
    /// <summary>
    /// interface that defines the method to calculate the body mass index (BMI) and classify it
    /// </summary>
    public interface IIMCService
    {
        double Calculate(double weight, double height);
        string Classify(double bmi);
    }

    /// <summary>
    /// implements the logic to calculate the body mass index (BMI) and classify it
    /// </summary>
    /// <seealso cref="ClassController.IIMCService" />
    public class IMCService : IIMCService
    {
        /// <summary>
        /// Calculates the BMI.
        /// </summary>
        /// <param name="weight">The weight in kilograms.</param>
        /// <param name="height">The height in meters.</param>
        /// <returns></returns>
        public double Calculate(double weight, double height)
        {
            return weight / (height * height);
        }

        /// <summary>
        /// Classifies the BMI.
        /// </summary>
        /// <param name="bmi">The BMI value.</param>
        /// <returns></returns>
        public string Classify(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25) return "Normal";
            if (bmi < 30) return "Overweight";
            return "Obese";
        }
    }
}
