namespace ClassModels
{

    /// <summary>
    /// implments the diet class for the purpose of storing the data of the diet in the database, and to be used as a model for the diet in the application.
    /// </summary>
    public class Diet
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the province.
        /// </summary>
        /// <value>
        /// The province.
        /// </value>
        public string Province { get; set; } = string.Empty;
    }
}
