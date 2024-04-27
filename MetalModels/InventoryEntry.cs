using MetalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class InventoryEntry
    {
        /// <summary>
        /// The date the metal was purchased
        /// </summary>
        private string dateAcquired;

        /// <summary>
        /// The specific metal
        /// </summary>
        private Metal metal;

        /// <summary>
        /// The amount the user paid for the metal
        /// </summary>
        private float amountPaid;

        /// <summary>
        /// Where the metal was purchased from
        /// </summary>
        private string location;

        /// <summary>
        /// Inventory Entry constructor
        /// </summary>
        /// <param name="dateAcquired">The date the metal was purchased</param>
        /// <param name="metal">The specific metal</param>
        /// <param name="amountPaid">The amount the user paid</param>
        /// <param name="location">Where the metal was purchased</param>
        public InventoryEntry(string dateAcquired, Metal metal, float amountPaid, string location)
        {
            this.dateAcquired = dateAcquired;
            this.metal = metal;
            this.amountPaid = amountPaid;
            this.location = location;
        }
    }
}
