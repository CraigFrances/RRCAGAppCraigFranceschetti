/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-28
 * Updated: 
 */
namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents car wash services.
    /// </summary>
    class CarWashServices
    {
        /// <summary>
        /// Description of the car wash service.
        /// </summary>
        public string Description
        {
            get;
        }

        /// <summary>
        /// Price of the car wash service.
        /// </summary>
        public decimal Price
        {
            get;
        }

        /// <summary>
        /// Initializes CarWashServices with a description and a price.
        /// </summary>
        /// <param name="description">Description of the car wash service.</param>
        /// <param name="price">Price associated with the car was service.</param>
        public CarWashServices(string description, decimal price)
        {
            this.Description = description;
            this.Price = price;
        }
    }
}
