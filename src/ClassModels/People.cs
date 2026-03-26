namespace ClassModels
{

    /// <summary>
    /// model class for the people, implemented for the purpose of storing the data of the people in the database, and to be used as a model for the people in the application.
    /// </summary>
    public class People
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
    }
}
