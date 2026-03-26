using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements a cart service.
    /// </summary>
    public interface ICartService
    {
        Cart GetCurrentCart();

        /// <summary>
        /// Sets the current user and diet.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="dietId">The diet identifier.</param>
        public void SetCurrentUserAndDiet(string username, int dietId);

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="qty">The qty.</param>
        public void AddItem(int productId, decimal qty);

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        public void RemoveItem(int productId);

        /// <summary>
        /// Clears the cart.
        /// </summary>
        public void ClearCart();

        /// <summary>
        /// Sets the delivery address.
        /// </summary>
        /// <param name="addressId">The address identifier.</param>
        public void SetDeliveryAddress(int addressId);
        List<DatesRecord> Checkout();
    }
}
