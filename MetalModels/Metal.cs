namespace MetalModels
{
    /// <summary>
    /// Represents a metal within an inventory
    /// </summary>
    public abstract class Metal
    {
        /// <summary>
        /// Represents the market price of the metal
        /// </summary>
        float price;


        /// <summary>
        /// Default metal constructor
        /// </summary>
        /// <param name="price">The price of the metal</param>
        public Metal(float price)
        {
            this.price = price;
        }
    }
}
