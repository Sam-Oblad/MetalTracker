namespace Models
{
    /// <summary>
    /// Represents a metal within an inventory
    /// </summary>
    public class MetalType
    {
        /// <summary>
        /// Represents the market price of the metal
        /// </summary>
        float price;

        /// <summary>
        /// Reflects the name of the metal
        /// </summary>
        string name;

        /// <summary>
        /// Default metal constructor
        /// </summary>
        /// <param name="price">The price of the metal</param>
        public MetalType(string name)
        {
            this.name = name;
        }
    }
}
