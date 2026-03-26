namespace ClassModels
{
    /// <summary>
    /// implements the Summary class.
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// Gets or sets the diet.
        /// </summary>
        /// <value>
        /// The diet.
        /// </value>
        public string Diet { get; set; }
        /// <summary>
        /// Gets or sets the subtotal.
        /// </summary>
        /// <value>
        /// The subtotal.
        /// </value>
        public decimal Subtotal { get; set; }
        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        /// <value>
        /// The tax.
        /// </value>
        public decimal Tax { get; set; }
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public decimal Total { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Diet: {Diet}\n" +
                   $"Date: {Date}\n" +
                   $"Subtotal: {Subtotal:C}\n" +
                   $"Tax: {Tax:C}\n" +
                   $"Total: {Total:C}\n";
        }
    }
}
