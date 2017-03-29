using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class GroundPackage : Package
{
    // Precondition: Length, Width, Height, and Weight must be greater than zero
    // Postcondition: The ground package is created with the specified values for
    //                origin address, destination address, length, width, height, and weight.
    public GroundPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth, double packageHeight, double packageWeight)
        : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
    {
    }

    public int ZoneDistance // Zone Distance Property
    {
        get
        {
            const int ZIP_FACTOR = 10000; // constant to hold the amount to divide zip codes by

            return Math.Abs((OriginAddress.Zip / ZIP_FACTOR) - (DestinationAddress.Zip / ZIP_FACTOR));
        }
    }
   
    const decimal VOL_FACTOR = .2M; // constant to hold volume cost
    const decimal DIST_FACTOR = .05M; // constant to hold distance cost

    // Precondition: none
    // Postcondition: The package's cost is returned
    public override decimal CalcCost()
    {
        return VOL_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height) + DIST_FACTOR * (ZoneDistance + 1) * ((decimal)Weight);
    }

    // Precondtion: none
    // Postcondition: Returns the item's data as a formatted string 
    public override string ToString()
    {
        return base.ToString() + string.Format("{0}Zone Distance:{1}",System.Environment.NewLine, ZoneDistance.ToString());
    }
}

