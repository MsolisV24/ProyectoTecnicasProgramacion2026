using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements the Builder pattern for constructing Summary objects.
    /// </summary>
    public class SummaryBuilder
    {
        protected Summary summary = new();

        /// <summary>
        /// Sets the diet.
        /// </summary>
        /// <param name="diet">The diet.</param>
        /// <returns></returns>
        public SummaryBuilder SetDiet(string diet)
        {
            summary.Diet = diet;
            return this;
        }

        /// <summary>
        /// Sets the subtotal.
        /// </summary>
        /// <param name="subtotal">The subtotal.</param>
        /// <returns></returns>
        public SummaryBuilder SetSubtotal(decimal subtotal)
        {
            summary.Subtotal = subtotal;
            return this;
        }

        /// <summary>
        /// Sets the total.
        /// </summary>
        /// <returns></returns>
        public SummaryBuilder SetTotal()
        {
            summary.Total = summary.Subtotal;
            return this;
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public SummaryBuilder SetDate(DateTime date)
        {
            summary.Date = date;
            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Summary Build()
        {
            return summary;
        }
    }
}
