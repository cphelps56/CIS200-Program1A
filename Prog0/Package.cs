using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Package : Parcel
{
    private double _length; // field to hold length
    private double _width; // field to hold width
    private double _height; // field to hold height
    private double _weight; // field to hold weight

    // Precondition: Length, Width, Height, and Weight must be greater than zero
    // Postcondition: The package is created with the specified values for
    //                origin address, destination address, length, width, height, and weight.
    public Package(Address originAddress, Address destAddress, double packageLength, double packageWidth, double packageHeight, double packageWeight)
        : base(originAddress, destAddress)
    {
        Length = packageLength;
        Width = packageWidth;
        Height = packageHeight;
        Weight = packageWeight;
    }

    public double Length
    {
        // Precondition: None
        // Postcondition: The package's Length is returned
        get
        {
            return _length;
        }
        // Precondition: value > 0
        // Postcondition: The package's length is set to a specified value
        set
        {
            if (value > 0)
            {
                _length = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }

    public double Width
    {
        // Precondition: None
        // Postcondition: The package's Width is returned
        get
        {
            return _width;
        }
        // Precondition: value > 0
        // Postcondition: The package's Width is set to a specified value
        set
        {
            if (value > 0)
            {
                _width = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }

    public double Height
    {
        // Precondition: None
        // Postcondition: The package's Height is returned
        get
        {
            return _height;
        }
        // Precondition: value > 0
        // Postcondition: The package's Height is set to a specified value
        set
        {
            if (value > 0)
            {
                _height = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }

    public double Weight
    {
        // Precondition: None
        // Postcondition: The package's Weight is returned
        get
        {
            return _weight;
        }
        // Precondition: value > 0
        // Postcondition: The package's Weight is set to a specified value
        set
        {
            if (value > 0)
            {
                _weight = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }
    
    // Precondtion: none
    // Postcondition: Returns the item's data as a formatted string 
    public override string ToString()
    {
        return base.ToString() + String.Format("{0}{0}Length: {1}{0}Width: {2}{0}Height: {3}{0}Weight: {4}{0}", 
            System.Environment.NewLine, Length.ToString(), Width.ToString(), Height.ToString(), Weight.ToString());
    }

}