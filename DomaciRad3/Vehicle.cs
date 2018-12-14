using System;
using System.Collections.Generic;
using System.Text;

namespace DomaciRad3
{
    class Vehicle
    {
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Domaci
{
    public class Vehicle : Inventory

    {
        public int DistanceDriven { get; set; }
        public DateTime RegistrationExpireDate { get; set; }

        public Vehicle(Guid serialnumber, int warrantylength, float purchaseprice, string description, string manufacturer, DateTime purchasedate, int distancedriven, DateTime registrationexpiredate)
            : base(serialnumber, warrantylength, purchaseprice, description, manufacturer, purchasedate)
        {
            DistanceDriven = distancedriven;
            RegistrationExpireDate = registrationexpiredate;
        }
    }
}