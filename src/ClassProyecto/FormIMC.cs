using ClassController;

namespace ClassProyecto
{
    /// <summary>
    /// implements the graphical interface to calculate Body Mass Index (BMI) and recommended daily calories.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormIMC : Form
    {
        private readonly IIMCService _bmiService;
        private readonly ICaloriasService _caloriesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormIMC"/> class.
        /// </summary>
        public FormIMC()
        {
            InitializeComponent();

            _bmiService = new IMCService();
            _caloriesService = new CaloriasService();

            cmbGender.Items.AddRange(new string[] { "Male", "Female" });
            cmbActivity.Items.AddRange(new string[] { "Sedentary", "Light", "Moderate", "Intense" });
        }

        private void FormIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(txtWeight.Text);
            double height = double.Parse(txtHeight.Text);
            int age = int.Parse(txtAge.Text);
            string gender = cmbGender.SelectedItem.ToString();
            int activity = cmbActivity.SelectedIndex;

            double bmi = _bmiService.Calculate(weight, height);
            string classification = _bmiService.Classify(bmi);
            double calories = _caloriesService.Calculate(weight, height, age, gender, activity);

            lblResult.Text =
                $"BMI: {bmi:F2} ({classification})\n" +
                $"Maintenance: {calories:F0} kcal\n" +
                $"Gain mass: {(calories + 300):F0} kcal\n" +
                $"Lose fat: {(calories - 400):F0} kcal";
        }

        private void FormIMC_Load_1(object sender, EventArgs e)
        {

        }
    }
}
