using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Assignment
{
    internal abstract class Appliance
    {
        //Fields
        private string _brand;
        private string _color;
        private long _itemNumber;
        private double _price;
        private int _quantity;
        private int _wattage;

        //Properties
        public string Brand
        {
            get 
            { 
                return _brand; 
            }
            set 
            { 
                _brand = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public bool IsAvailable
        {
            get
            {
                return true;
            }
        }
        
        public long ItemNumber
        {
            get
            {
                return _itemNumber;
            }
            set
            {
                _itemNumber = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public int Wattage
        {
            get
            {
                return _wattage;
            }
            set
            {
                _wattage = value;
            }
        }
        public void Type
        {
            get
            {
                return _type; //placeholder not sure what they want to  return.
            }
        }
        //Methods
        public void Appliances()
        {

        }
        public void Checkout()
        {

        }

        public void DetermineAppliance()
        {

        }

        public void FormatForFile()
        {

        }

    }
}


//•	Each of the following appliance types is represented differently in the supplied appliances.txt file. 
//•	Each line in the file represents a different appliance and each piece of information for an appliance is separated by a semi-colon. 
//•	The first digit of the Item Number indicates the type of the appliance. Each item number is 9 digits long.
