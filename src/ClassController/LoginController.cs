using ClassController.Abstractions;

namespace ClassController
{
    /// <summary>
    /// initializes a new instance of the <see cref="LoginController"/> class, which is responsible for handling user login functionality. It interacts with the UserHandler to verify user credentials and manage the current user's login state.
    /// </summary>
    public class LoginController
    {
        /// <summary>
        /// The user handler
        /// </summary>
        public readonly UserHandler UserHandler;
        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <value>
        /// The current user.
        /// </value>
        public string CurrentUser { get; private set; } = string.Empty;
        /// <summary>
        /// Gets a value indicating whether this instance is admin.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is admin; otherwise, <c>false</c>.
        /// </value>
        public bool IsAdmin { get; private set; } = false;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="userHandler">The user handler.</param>
        public LoginController(UserHandler userHandler)
        {
            this.UserHandler = userHandler;
        }
        /// <summary>
        /// Logins the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return false;

            if (userName == "admin" && password == "admin")
            {
                CurrentUser = "admin";
                IsAdmin = true;
                return true;
            }

            foreach (var customer in UserHandler.Customers)
            {
                if (customer.Username == userName && customer.Password == password)
                {
                    CurrentUser = userName;
                    IsAdmin = false;
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Gets the name of the current user.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUserName() => CurrentUser;
    }
}
