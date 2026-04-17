using System;
using System.Windows.Forms;
using ClassController;

namespace ClassProyecto
{
    public partial class FormStatistics : Form
    {
        private readonly IStatisticsService _stats;

        public FormStatistics(IStatisticsService stats)
        {
            InitializeComponent();
            _stats = stats;
        }
        private void btnExportStats_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt";
            saveDialog.DefaultExt = "txt";
            saveDialog.FileName = $"Statistics_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    
                    var from = dtpFrom.Value;
                    var to = dtpTo.Value;
                    var topPeoples = _stats.GetTopPeoples(from, to);
                    var topProducts = _stats.GetTopProducts(from, to);
                    var monthlySummary = _stats.GetMonthlySummary();
                    var bestMonth = _stats.GetMonthWithMoreConsumption();

                    
                    writer.WriteLine("=".PadRight(60, '='));
                    writer.WriteLine("STATISTICS REPORT");
                    writer.WriteLine("=".PadRight(60, '='));
                    writer.WriteLine($"Generated: {DateTime.Now}");
                    writer.WriteLine($"Period: {from:yyyy-MM-dd} to {to:yyyy-MM-dd}");
                    writer.WriteLine();

                    
                    writer.WriteLine("-".PadRight(60, '-'));
                    writer.WriteLine("BEST MONTH:");
                    if (bestMonth != null)
                    {
                        writer.WriteLine($"  {bestMonth.Year}-{bestMonth.Month:00} - Total: {bestMonth.TotalAmount:N2} kcal");
                    }
                    else
                    {
                        writer.WriteLine("  No data available");
                    }
                    writer.WriteLine();

                    
                    writer.WriteLine("-".PadRight(60, '-'));
                    writer.WriteLine("TOP PEOPLE (by consumption):");
                    writer.WriteLine();
                    writer.WriteLine($"{"Name",-25} {"Total Kcal",15}");
                    writer.WriteLine(new string('-', 42));

                    foreach (var person in topPeoples.Take(10))
                    {
                        writer.WriteLine($"{person.PeopleName,-25} {person.TotalAmount,15:N2}");
                    }
                    writer.WriteLine();

                    
                    writer.WriteLine("-".PadRight(60, '-'));
                    writer.WriteLine("TOP PRODUCTS (by quantity):");
                    writer.WriteLine();
                    writer.WriteLine($"{"Product",-30} {"Quantity",15}");
                    writer.WriteLine(new string('-', 47));

                    foreach (var product in topProducts.Take(10))
                    {
                        writer.WriteLine($"{product.ProductName,-30} {product.TotalQuantity,15:N2}");
                    }
                    writer.WriteLine();

                    
                    writer.WriteLine("-".PadRight(60, '-'));
                    writer.WriteLine("MONTHLY SUMMARY:");
                    writer.WriteLine();
                    writer.WriteLine($"{"Year",-10} {"Month",-10} {"Total Kcal",15}");
                    writer.WriteLine(new string('-', 37));

                    foreach (var month in monthlySummary.OrderBy(m => m.Year).ThenBy(m => m.Month))
                    {
                        writer.WriteLine($"{month.Year,-10} {month.Month,-10} {month.TotalAmount,15:N2}");
                    }
                    writer.WriteLine();

                    writer.WriteLine("=".PadRight(60, '='));
                    writer.WriteLine("END OF REPORT");
                    writer.WriteLine("=".PadRight(60, '='));
                }

                MessageBox.Show($"Statistics exported successfully to:\n{saveDialog.FileName}");
            }
        }
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            LoadStatistics();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            var from = dtpFrom.Value;
            var to = dtpTo.Value;

            dgvPeoples.DataSource = _stats.GetTopPeoples(from, to);
            dgvProducts.DataSource = _stats.GetTopProducts(from, to);
            dgvMonths.DataSource = _stats.GetMonthlySummary();


            dgvMonths.Columns["TotalAmount"].HeaderText = "Total Kcal";
            dgvPeoples.Columns["TotalAmount"].HeaderText = "Total Kcal";

            var bestMonth = _stats.GetMonthWithMoreConsumption();
            lblBestMonth.Text = bestMonth == null
                ? "No data"
                : $"{bestMonth.Year}-{bestMonth.Month:00} Total: {bestMonth.TotalAmount:N2}";
        }
    }
}
