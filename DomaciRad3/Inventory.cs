
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Domaci
{
    public class Inventory
    {
        public Guid SerialNumber { get; set; }
        public int WarrantyLength { get; set; }
        public float PurchasePrice { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Inventory(Guid serialnumber, int warrantylength, float purchaseprice, string description, string manufacturer, DateTime purchasedate)
        {
            SerialNumber = serialnumber;
            WarrantyLength = warrantylength;
            PurchasePrice = purchaseprice;
            Description = description;
            Manufacturer = manufacturer;
            PurchaseDate = purchasedate;

        }


    }
}
