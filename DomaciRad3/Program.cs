using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domaci
{

    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle[] Vechiles = new Vehicle[0];
            //Vehicle Vehicles[100];
            List<Vehicle> InventoryVehicles = new List<Vehicle>();
            List<Computer> InventoryComputer = new List<Computer>();
            List<Telephone> InventoryTelephones = new List<Telephone>();

            int BatteryCounter = 0;

            Console.WriteLine("Dobro dosli u invertar!");
            Console.WriteLine("\t~Meni~");
            Console.WriteLine(" 1.Unos objekta\n 2.Ispis svih komada invertara na uneseni serijski broj\n 3.Ispis koliko komada tehnološke opreme ima baterije \n 4.Ispis svih mobitela po proizvodacu\n 5.Ispis svih racunala po operacijskom sustavu\n 6.Ispis telefona kojima istice garancija za manje od godinu dana \n 7.Ispis vozila kojima registracija istice u sljedecih mjesec dana \n 8.Izracun pada cijene svih vozila \n 9.Izracun pada cijene cijele opreme  0.Izlaz iz programa");
            char decision;

            do
            {

                Console.WriteLine("Sto zelite napravti s invertrom:");
                decision = char.Parse(Console.ReadLine());
                if (decision == '1')
                {
                    char subdecision1;
                    Console.WriteLine("Sto zelite unijeti:\n(Unesite 1 za Vozilo, a 0 za Tehnolosku Opremu) ");
                    subdecision1 = char.Parse(Console.ReadLine());
                    if (subdecision1 == '1')
                    {
                        int TmpWarrantyLength;
                        float TmpPurchasePrice;
                        string TmpDescription;
                        string TmpManufacturer;
                        int TmpDistanceDriven;
                        DateTime TmpRegistrationExpireDate;
                        DateTime TmpPurchaseDate;
                        Guid TmpGuid = Guid.NewGuid();



                        Console.WriteLine("Upisite naziv/opis:");
                        TmpDescription = Console.ReadLine();
                        Console.WriteLine("Upisite duljinu garancije:\n(U mjesecima)");
                        TmpWarrantyLength = int.Parse(Console.ReadLine());
                        Console.WriteLine("Upisite cijenu pri kupnji:\n(U kunama)");
                        TmpPurchasePrice = float.Parse(Console.ReadLine());
                        Console.WriteLine("Upisite datum kupnje:\n(godina(broj), mjesec(broj), dan(broj))");
                        TmpPurchaseDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Upisite ime proizvodaca");
                        TmpManufacturer = Console.ReadLine();
                        Console.WriteLine("Upisite pređenu udaljenost:\n(U kilometrima)");
                        TmpDistanceDriven = int.Parse(Console.ReadLine());
                        Console.WriteLine("Upisite datum isteka garancije:\n(godina(broj), mjesec(broj), dan(broj))");
                        TmpRegistrationExpireDate = DateTime.Parse(Console.ReadLine());


                        Vehicle Vehicles = new Vehicle(TmpGuid, TmpWarrantyLength, TmpPurchasePrice, TmpDescription, TmpManufacturer, TmpPurchaseDate, TmpDistanceDriven, TmpRegistrationExpireDate);

                        //InventoryVehicles.Add(new Vehicle() { SerialNumber = TmpGuid, WarrantyLength = TmpWarrantyLength, Description = TmpDescription, PurchasePrice = TmpPurchasePrice, Manufacturer = TmpManufacturer, PurchaseDate = TmpPurchaseDate, DistanceDriven = TmpDistanceDriven, RegistrationExpireDate = TmpRegistrationExpireDate });
                        InventoryVehicles.Add(Vehicles);

                        continue;

                    }
                    else if (subdecision1 == '0')
                    {
                        char finaldecision;
                        Console.WriteLine("Je li ima baterije;\n(Unesite 1 za da, a 0 za ne");
                        finaldecision = char.Parse(Console.ReadLine());
                        if (finaldecision == '1')
                        {
                            Console.WriteLine("Onda je telefon!");
                            BatteryCounter++;
                            int TmpWarrantyLength;
                            float TmpPurchasePrice;
                            string TmpDescription;
                            string TmpManufacturer;
                            int TmpPhoneNumber;
                            string TmpUserName;
                            DateTime TmpPurchaseDate;
                            Guid TmpGuid = Guid.NewGuid();



                            Console.WriteLine("Upisite naziv/opis:");
                            TmpDescription = Console.ReadLine();
                            Console.WriteLine("Upisite duljinu garancije:\n(U mjesecima)");
                            TmpWarrantyLength = int.Parse(Console.ReadLine());
                            Console.WriteLine("Upisite cijenu pri kupnji:\n(U kunama)");
                            TmpPurchasePrice = float.Parse(Console.ReadLine());
                            Console.WriteLine("Upisite datum kupnje:\n(godina(broj), mjesec(broj), dan(broj))");
                            TmpPurchaseDate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Upisite ime proizvodaca");
                            TmpManufacturer = Console.ReadLine();
                            Console.WriteLine("Upisite ime korisnika:");
                            TmpUserName = Console.ReadLine();
                            Console.WriteLine("Upisite broj telefona:");
                            TmpPhoneNumber = int.Parse(Console.ReadLine());

                            Telephone Phones = new Telephone(TmpGuid, TmpWarrantyLength, TmpPurchasePrice, TmpDescription, TmpManufacturer, TmpPurchaseDate, TmpPhoneNumber, TmpUserName);



                            //InventoryVehicles.Add(new Telephone() { SerialNumber = TmpGuid, WarrantyLength = TmpWarrantyLength, Description = TmpDescription, PurchasePrice = TmpPurchasePrice, Manufacturer = TmpManufacturer, PurchaseDate = TmpPurchaseDate, PhoneNumber = TmpPhoneNumber, UserName = TmpUserName });
                            InventoryTelephones.Add(Phones);

                            continue;
                        }
                        else if (finaldecision == '0')
                        {
                            Console.WriteLine("Onda je racunalo!");
                            int TmpWarrantyLength;
                            float TmpPurchasePrice;
                            string TmpDescription;
                            string TmpManufacturer;
                            string TmpOperatingSystem;
                            string TmpDesktoporLaptop;
                            DateTime TmpPurchaseDate;
                            Guid TmpGuid = Guid.NewGuid();



                            Console.WriteLine("Upisite naziv/opis:");
                            TmpDescription = Console.ReadLine();
                            Console.WriteLine("Upisite duljinu garancije:\n(U mjesecima)");
                            TmpWarrantyLength = int.Parse(Console.ReadLine());
                            Console.WriteLine("Upisite cijenu pri kupnji:\n(U kunama)");
                            TmpPurchasePrice = float.Parse(Console.ReadLine());
                            Console.WriteLine("Upisite datum kupnje:\n(godina(broj), mjesec(broj), dan(broj))");
                            TmpPurchaseDate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Upisite ime proizvodaca");
                            TmpManufacturer = Console.ReadLine();
                            Console.WriteLine("Upisite operacijski sustav koji koristi:\n(Velikim pocetnim slovom i razmak izmedu imena i verzije)");
                            TmpOperatingSystem = Console.ReadLine();
                            Console.WriteLine("Je li racunalo prenosivo ili:\n(Upisit Desktop ako nije, a Laptop ako je");
                            TmpDesktoporLaptop = Console.ReadLine();

                            Computer Computers = new Computer(TmpGuid, TmpWarrantyLength, TmpPurchasePrice, TmpDescription, TmpManufacturer, TmpPurchaseDate, TmpOperatingSystem, TmpDesktoporLaptop);

                            //InventoryVehicles.Add(new Computer() { SerialNumber = TmpGuid, WarrantyLength = TmpWarrantyLength, Description = TmpDescription, PurchasePrice = TmpPurchasePrice, Manufacturer = TmpManufacturer, PurchaseDate = TmpPurchaseDate, OperatingSystem = TmpOperatingSystem, DesktopOrLaptop = TmpDesktoporLaptop});

                            InventoryComputer.Add(Computers);

                            continue;

                        }
                        else
                        {
                            Console.WriteLine("Krivi unos!");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos!");
                        continue;
                    }
                }
                else if (decision == '2')
                {
                    Console.WriteLine("Ispis Tehnologija");
                    Console.WriteLine("Ispis svih racunala... ");
                    foreach (Computer c in InventoryComputer)
                    {
                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Operacijski sustav: {5} \n Tip: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.OperatingSystem, c.DesktopOrLaptop, c.WarrantyLength);
                    }

                    Console.WriteLine("Ispis svih telefona... ");
                    foreach (Telephone c in InventoryTelephones)
                    {
                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Ime korisnika: {5} \n Broj telefona: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.UserName, c.PhoneNumber, c.WarrantyLength);
                    }

                    Console.WriteLine("Ispis vozila...");
                    foreach (Vehicle c in InventoryVehicles)
                    {
                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Prijedeni kilometri: {5} \n Datum isteka garancije: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.DistanceDriven, c.RegistrationExpireDate, c.WarrantyLength);
                    }
                }
                else if (decision == '3')
                {
                    Console.WriteLine($"Broj uredaja s baterijom iznosi:{BatteryCounter}");
                }
                else if (decision == '4')
                {
                    string ManufacturerSearch;
                    Console.WriteLine("Kojeg proizvodaca mobitela trazite:");
                    ManufacturerSearch = Console.ReadLine();
                    List<Telephone> FoundPhones = InventoryTelephones.FindAll(i => i.Manufacturer == ManufacturerSearch);
                    Console.WriteLine("Pronadeni telefoni zadanog proizvodaca su:");
                    foreach (Telephone c in FoundPhones)
                    {
                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Ime korisnika: {5} \n Broj telefona: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.UserName, c.PhoneNumber, c.WarrantyLength);
                    }
                }
                else if (decision == '5')
                {
                    string OperatingSystemSearch;
                    Console.WriteLine("Racunala s kojim operacijskim sustavom trazite:");
                    OperatingSystemSearch = Console.ReadLine();
                    List<Computer> FoundComputers = InventoryComputer.FindAll(i => i.OperatingSystem == OperatingSystemSearch);
                    Console.WriteLine("Pronadeni telefoni zadanog proizvodaca su:");
                    foreach (Computer c in FoundComputers)
                    {
                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Operacijski sustav: {5} \n Tip: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.OperatingSystem, c.DesktopOrLaptop, c.WarrantyLength);
                    }
                }
                else if (decision == '6')
                {
                    DateTime Today;
                    DateTime PurchaseTmp;
                    TimeSpan TimeDiff;
                    Console.WriteLine("Teto upisite datum:\n(godina(broj), mjesec(broj), dan(broj))");
                    Today = DateTime.Parse(Console.ReadLine());
                    foreach (Telephone c in InventoryTelephones)
                    {

                        PurchaseTmp = c.PurchaseDate.AddDays(c.WarrantyLength * 30);
                        TimeDiff = PurchaseTmp - Today;
                        if (TimeDiff.TotalDays < 366)
                        {
                            Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Ime korisnika: {5} \n Broj telefona: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.UserName, c.PhoneNumber, c.WarrantyLength);

                        }
                    }

                }
                else if (decision == '7')
                {
                    DateTime Today;
                    TimeSpan TimeDiff;
                    Console.WriteLine("Teto upisite datum:\n(godina(broj), mjesec(broj), dan(broj))");
                    Today = DateTime.Parse(Console.ReadLine());
                    foreach (Vehicle c in InventoryVehicles)
                    {
                        TimeDiff = Today - c.RegistrationExpireDate;
                        if (TimeDiff.TotalDays < 31)
                        {
                            Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Serijski broj:{2} \n Datum kupnje:{3} \n Proizvodac: {4} \n Kilometara predeno: {5} \n Datum isteka registracije: {6} \n Duljina garancije: {7} ", c.Description, c.PurchasePrice, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.DistanceDriven, c.RegistrationExpireDate, c.WarrantyLength);

                        }
                    }

                }
                else if (decision == '8')
                {
                    foreach (Vehicle c in InventoryVehicles)
                    {
                        int NewPrice = 0;
                        int PriceDelta = 0;
                        int Coeff = c.DistanceDriven / 20000;
                        if (Coeff > 4)
                        {
                            NewPrice = (int)c.PurchasePrice / 5;
                        }
                        else
                        {
                            NewPrice = (int)c.PurchasePrice / (5 / (5 - Coeff));
                        }

                        PriceDelta = (int)c.PurchasePrice - NewPrice;

                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Nova cijena:{2} \n Razlika u cijeni:{3}\n Serijski broj:{4} \n Datum kupnje:{5} \n Proizvodac: {6} \n Kilometara predeno: {7} \n Datum isteka registracije: {8} \n Duljina garancije: {9} ", c.Description, c.PurchasePrice, NewPrice, PriceDelta, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.DistanceDriven, c.RegistrationExpireDate, c.WarrantyLength);


                    }

                }
                else if (decision == '9')
                {
                    DateTime Today;
                    TimeSpan TimeDiff;
                    float NewPrice = 0;
                    float PriceDelta = 0;
                    Console.WriteLine("Teto upisite datum:\n(godina(broj), mjesec(broj), dan(broj))");
                    Today = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Telefoni...");

                    foreach (Telephone c in InventoryTelephones)
                    {

                        TimeDiff = Today - c.PurchaseDate;
                        int Coeff = (int)TimeDiff.TotalDays / 31;
                        if (Coeff > 14)
                        {
                            NewPrice = c.PurchasePrice / (33 / 10);
                        }
                        else
                        {
                            NewPrice = c.PurchasePrice / (20 / (20 - Coeff));
                        }

                        PriceDelta = c.PurchasePrice - NewPrice;

                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Nova cijena:{2} \n Razlika u cijeni:{3}\n Serijski broj:{4} \n Datum kupnje:{5} \n Proizvodac: {6} \n Ime korisnika: {7} \n Broj korisnika: {8} \n Duljina garancije: {9} ", c.Description, c.PurchasePrice, NewPrice, PriceDelta, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.UserName, c.PhoneNumber, c.WarrantyLength);


                    }

                    Console.WriteLine("Racunala...");

                    foreach (Computer c in InventoryComputer)
                    {

                        TimeDiff = Today - c.PurchaseDate;
                        int Coeff = (int)TimeDiff.TotalDays / 31;
                        if (Coeff > 14)
                        {
                            NewPrice = c.PurchasePrice / (33 / 10);
                        }
                        else
                        {
                            NewPrice = c.PurchasePrice / (20 / (20 - Coeff));
                        }

                        PriceDelta = c.PurchasePrice - NewPrice;

                        Console.WriteLine(" Opis:{0}\n Cijena:{1}\n Nova cijena:{2} \n Razlika u cijeni:{3}\n Serijski broj:{4} \n Datum kupnje:{5} \n Proizvodac: {6} \n Tip: {7} \n Operacijski sustav: {8} \n Duljina garancije: {9} ", c.Description, c.PurchasePrice, NewPrice, PriceDelta, c.SerialNumber, c.PurchaseDate, c.Manufacturer, c.DesktopOrLaptop, c.OperatingSystem, c.WarrantyLength);


                    }

                }
                else if (decision == '0')
                {
                    break;
                }
                else
                {
                    continue;
                }
            } while (decision != '0');




        }
    }
}

