namespace ClassModels
{

    /// <summary>
    ///model class to represent the result of top people based on total amount.
    /// </summary>
    public class TopPeopleResult
    {

        /// <summary>
        /// Gets or sets the people identifier.
        /// </summary>
        /// <value>
        /// The people identifier.
        /// </value>
        public int PeopleId { get; set; }

        /// <summary>
        /// Gets or sets the name of the people.
        /// </summary>
        /// <value>
        /// The name of the people.
        /// </value>
        public string PeopleName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total amount.
        /// </summary>
        /// <value>
        /// The total amount.
        /// </value>
        public decimal TotalAmount { get; set; }
    }
}
