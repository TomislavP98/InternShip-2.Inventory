
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Domaci
{
    public class Computer : Inventory
    {
        public string OperatingSystem { get; set; }
        public string DesktopOrLaptop { get; set; }

        public Computer(Guid serialnumber, int warrantylength, float purchaseprice, string description, string manufacturer, DateTime purchasedate, string operatingsystem, string desktoporlaptop)
            : base(serialnumber, warrantylength, purchaseprice, description, manufacturer, purchasedate)
        {
            OperatingSystem = operatingsystem;
            DesktopOrLaptop = desktoporlaptop;
        }
    }
}

