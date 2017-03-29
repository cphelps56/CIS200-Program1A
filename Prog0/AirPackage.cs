using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class AirPackage : Package
{
    // Precondition: Length, Width, Height, and Weight must be greater than zero
    // Postcondition: The air package is created with the specified values for
    //                origin address, destination address, length, width, height, and weight.
    public AirPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth, double packageHeight, double packageWeight)
        : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
    {
    }

    const int HEAVY_WEIGHT = 75; // constant to hold the heavy package weight
    const int LARGE_SIZE = 100; // constant to hold the large package size

    // Precondition: none
    // Postcondition: If the package is heavy, return true. Else, return false.
    public bool IsHeavy()
    {
        if (Weight >= HEAVY_WEIGHT)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Precondition: none
    // Postcondition: If the package is large, return true. Else, return false.
    public bool IsLarge()
    {
        if ((Length + Width + Height) >= LARGE_SIZE)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Precondtion: none
    // Postcondition: Returns the item's data as a formatted string 
    public override string ToString()
    {
        return base.ToString() + string.Format("{0}Heavy?: {1}{0}Large?: {2}",System.Environment.NewLine,IsHeavy().ToString(),IsLarge().ToString());
    }
}

