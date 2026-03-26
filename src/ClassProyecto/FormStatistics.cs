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
