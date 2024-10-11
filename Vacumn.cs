using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Assignment
{
    internal class Vacuum : Appliance
    {
        //Fields
        private string _batteryVoltage;
        private string _batterygrade;


        //Properties
        public string BatteryVolatage
        {
            get
            {
                return _batteryVoltage;

            }
            set
            {
                _batteryVoltage = value;
            }
        }
        public string BatteryGrade
        {
            get
            {
                return _batterygrade;
            }
            set
            {
                _batterygrade = value;
            }
        }


        //Methods
        public void FormatForFile()
        {
            
        }

        public override string ToString()
        {
           Console.WriteLine("Vacuum");
            return base.ToString();
        }

        public void Vacuums()
        {

        }



    }
}
