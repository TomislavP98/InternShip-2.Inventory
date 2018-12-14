
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Domaci
{
    public class Telephone1 : Inventory
    {
        public int PhoneNumber { get; set; }
        public string UserName { get; set; }

        public Telephone1(Guid serialnumber, int warrantylength, float purchaseprice, string description, string manufacturer, DateTime purchasedate, int phonenumber, string username)
            : base(serialnumber, warrantylength, purchaseprice, description, manufacturer, purchasedate)
        {
            PhoneNumber = phonenumber;
            UserName = username;
        }


    }
}


