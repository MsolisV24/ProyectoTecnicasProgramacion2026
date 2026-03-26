using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements the Director pattern for constructing Summary objects.
    /// </summary>
    public class SummaryDirector
    {
        /// <summary>
        /// Creates the summary.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="diet">The diet.</param>
        /// <param name="subtotal">The subtotal.</param>
        /// <returns></returns>
        public Summary CreateSummary(SummaryBuilder builder,
                                     string diet,
                                     decimal subtotal)
        {
            decimal tax = subtotal * 0.13m;

            return builder
                .SetDiet(diet)
                .SetSubtotal(subtotal)
                .SetTax(tax)
                .SetTotal()
                .SetDate(DateTime.Now)
                .Build();
        }
    }
}
