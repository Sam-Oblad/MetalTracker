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
        private string dateAcquired;
        private Metal metal;
        private float amountPaid;
        private string location;

        public InventoryEntry(string dateAcquired, Metal metal, float amountPaid, string location)
        {
            this.dateAcquired = dateAcquired;
            this.metal = metal;
            this.amountPaid = amountPaid;
            this.location = location;
        }
    }
}
