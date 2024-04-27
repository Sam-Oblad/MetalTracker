using Models;
namespace InventoryTracker
{
    public class MetalInventoryTracker
    {
        /// <summary>
        /// A collection of InventoryEntry objects that represent a users metal inventory
        /// </summary>
        public HashSet<InventoryEntry> metalInventory;

        /// <summary>
        /// Represents the total ounces within the users inventory
        /// </summary>
        private float totalOunces;

        /// <summary>
        /// Represents the total amount paid for the inventory
        /// </summary>
        private float totalPricePaid;

        /// <summary>
        /// Default constructor for MetalInventoryTracker
        /// </summary>
        public MetalInventoryTracker()
        {
            metalInventory = new HashSet<InventoryEntry>();
            totalOunces = 0f;
            totalPricePaid = 0f;
        }

        /// <summary>
        /// Adds an InventoryEntry to the InventoryTracker object
        /// </summary>
        /// <param name="entry">The entry to be added</param>
        public void addEntry(InventoryEntry entry)
        {
            metalInventory.Add(entry);
            totalOunces += entry.ounces;
            totalPricePaid += entry.amountPaid;
        }

        /// <summary>
        /// Removes an InventoryEntry from the InventoryTracker object
        /// </summary>
        /// <param name="entry">The entry to be removed</param>
        public void removeEntry(InventoryEntry entry) 
        {
            if (metalInventory.TryGetValue(entry, out var e))
            {
                metalInventory.Remove(entry);
                totalOunces -= entry.ounces;
                totalPricePaid -= entry.amountPaid;
            }
        }
    }
}
