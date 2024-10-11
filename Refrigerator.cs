using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Assignment
{
    internal class Refrigerator : Appliance
    {
        //Fields
        private enum _doors
        {
            two = 2,
            three = 3,
            four = 4

        }
        private int _height;
        private int _width;

        //Properties

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }


        //Methods

        public void FormatForFile()
        {

        }

        public void Refrigerators()
        {

        }

        public override string ToString()
        {
           Console.WriteLine("Refrigerator: " + Brand + ":" + Color + " " + ItemNumber + " " + Price + " " + Quantity + " " + Wattage + " " + Height + " " + Width);
            return base.ToString();
        }



    }

}
