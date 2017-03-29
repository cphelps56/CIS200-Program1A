using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoDayAirPackage : AirPackage
{
    public enum Delivery{Early,Saver}; // Enumerated type for the delivery type

    public Delivery DeliveryType 
    { 
        // Precondition: none
        // Postcondition: The package's delivery type is returned
        get; 
        // Precondition: none
        // Postcondition: The package's delivery type is set to the specified delivery type (early or saver)
        set; 
    }

    // Precondition: Length, Width, Height, and Weight must be greater than zero
    // Postcondition: The two day air package is created with the specified values for
    //                origin address, destination address, length, width, height, weight, and delivery type
    public TwoDayAirPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth, double packageHeight, double packageWeight, Delivery delivery)
        : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
    {
        DeliveryType = delivery;
    }

    // Precondition: none
    // Postcondition: The package's cost is returned
    public override decimal CalcCost()
    {
        const decimal VOL_FACTOR = .25m; // constant to hold the volume cost
        const decimal WEIGHT_FACTOR = .25m; // constant to hold the weight cost
        const decimal SAVER_DISCOUNT = .9m; // constant to hodl the discount if the package delivery type is a saver type

        decimal cost;

        cost = VOL_FACTOR * ((decimal)Length + (decimal)Width + (decimal)Height) + WEIGHT_FACTOR * (decimal)(Weight);

        if (DeliveryType == Delivery.Saver)
        {
            cost *= SAVER_DISCOUNT;
        }
        return cost;
    }

    // Precondtion: none
    // Postcondition: Returns the item's data as a formatted string 
    public override string ToString()
    {
        return base.ToString() + string.Format("{0}Delivery Type: {1}", System.Environment.NewLine, DeliveryType.ToString());
    }
}

