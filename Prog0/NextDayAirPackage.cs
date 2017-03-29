using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NextDayAirPackage : AirPackage
{
    private decimal _expressFee; // field to hold express fee

    // Precondition: Length, Width, Height, Weight and Express Fee must be greater than zero
    // Postcondition: The next day air package is created with the specified values for
    //                origin address, destination address, length, width, height, weight, and express fee
    public NextDayAirPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth, double packageHeight, double packageWeight, decimal fee)
        : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
    {
        ExpressFee = fee;
    }

    public decimal ExpressFee // Express Fee property
    {
        // Precondition: None
        // Postcondition: The package's Express Fee is returned
        get
        {
            return _expressFee;
        }
        // Precondition: value >= 0
        // Postcondition: The package's Express Fee is set to a specified value
        private set
        {
            if(value >= 0)
            {
                _expressFee = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }

    // Precondition: none
    // Postcondition: The package's cost is returned
    public override decimal CalcCost()
    {
        const decimal VOL_FACTOR = .4m; // constant to hold volume cost
        const decimal WEIGHT_FACTOR = .3m; // constant to hold weight cost
        const decimal WEIGHT_CHARGE = .25m; // constant to hold charge if package is heavy
        const decimal SIZE_CHARGE = .25m; // costant to hold charge if package is large

        decimal Cost;

        Cost = VOL_FACTOR*((decimal)Length + (decimal)Width + (decimal)Height) + WEIGHT_FACTOR*((decimal)(Weight)) + ExpressFee;

        if(IsHeavy())
        {
            Cost += WEIGHT_CHARGE*(decimal)Weight;
        }
        if(IsLarge())
        {
            Cost += SIZE_CHARGE*((decimal)Length + (decimal)Width + (decimal)Height);
        }

        return Cost;
    }

    // Precondtion: none
    // Postcondition: Returns the item's data as a formatted string 
    public override string ToString()
    {
        return base.ToString() + string.Format("{0}Express Fee: {1}{0}", System.Environment.NewLine, ExpressFee.ToString("c"));
    }
}