// By: Colin Phelps
// Program 0
// CIS 200-10
// Summer 2015
// Due: 5/21/2015

// Also By: Andrew L. Wright

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45", 
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Tyler Durden", "537 Paper Street", "",
                "Bradford", "DE", 19808); // Test Address 5
            Address a6 = new Address("Robb Stark", "318 Snow Street", "",
                "Winterfell", "AK", 99502); // Test Address 6
            Address a7 = new Address("Sherlock Holmes", "221 Baker Street", "Apt B",
                "Boston", "MA", 02201); // Test Address 7


            Letter l1 = new Letter(a1, a3, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.75M); // Test Letter 3
            GroundPackage gp1 = new GroundPackage(a4, a5, 20, 30, 40, 25); // Test Ground Package 1
            GroundPackage gp2 = new GroundPackage(a6, a7, 50, 50, 50, 50); // Test Ground Package 2
            GroundPackage gp3 = new GroundPackage(a4, a6, 10, 15, 10, 80); // Test Ground Package 3
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a5, 20, 25, 27, 30, 5); // Test Next Day Air Package 1
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a6, 30, 40, 50, 25, 10); // Test Next Day Air Package 2
            NextDayAirPackage ndap3 = new NextDayAirPackage(a3, a4, 10, 10, 15, 85, 12); // Test Next Day Air Package 3
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a7, a2, 30, 30, 30, 30, TwoDayAirPackage.Delivery.Saver); // Test Two Day Air Package 1
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a3, a2, 43, 29, 32, 45, TwoDayAirPackage.Delivery.Early); // Test Two Day Air Package 2

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);


            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }
            Console.ReadLine();
        }
    }
}
