namespace ClassController
{
    /// <summary>
    /// interface that defines the method to calculate the calories needed for a person based on their weight
    /// </summary>
    public interface ICaloriasService
    {
        double Calculate(double weight, double height, int age, string gender, int activity);
    }

    /// <summary>
    /// implements the logic to calculate the calories needed for a person based on their weight, height, age
    /// </summary>
    /// <seealso cref="ClassController.ICaloriasService" />
    public class CaloriasService : ICaloriasService
    {
        /// <summary>
        /// Calculates the calories.
        /// </summary>
        /// <param name="weight">The weight in kilograms.</param>
        /// <param name="height">The height in meters.</param>
        /// <param name="age">The age in years.</param>
        /// <param name="gender">The gender (M for male, F for female).</param>
        /// <param name="activity">The activity level index.</param>
        /// <returns></returns>
        public double Calculate(double weight, double height, int age, string gender, int activity)
        {
            double bmr;

            if (gender == "M")
            {
                bmr = (10 * weight) + (6.25 * height * 100) - (5 * age) + 5;
            }
            else
            {
                bmr = (10 * weight) + (6.25 * height * 100) - (5 * age) - 161;
            }

            double[] factors = { 1.2, 1.375, 1.55, 1.725 };

            return bmr * factors[activity];
        }
    }
}
