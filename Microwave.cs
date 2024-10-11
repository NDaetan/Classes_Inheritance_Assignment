using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Assignment
{
    internal class Microwave : Appliance
    {
        private string _capacity;
        private string _roomType;
        private string roomTypeKitchen;
        private string roomTypeWord; // Cant see thsi one class Diagram

        //Properites
        public string Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        public string RoomType
        {
            get
            {
                return _roomType;
            }
            set
            {
                _roomType = value;
            }
        }
        //Methods
        public void FormatForFile()
        {

        }

        public void Microwaves()
        {

        }
        public override string ToString()
        {
            Console.WriteLine("Microwave");
            return base.ToString();
        }
    }
}
