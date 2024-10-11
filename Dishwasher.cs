using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Assignment
{
    internal class Dishwasher :Appliance
    {   
        //Fields
        private string _feature;
        private string _soundRating;
        private string _soundRatingM;
        private string _soundRatingQA; // I cant see what these are on the Class Diagram
        private string _soundRatingQB;
        private string _soundRatingQC;

        //properties
        public string Feature
        {
            get
            {
                return _feature;
            }
            set
            {
                _feature = value;
            }
        } 
        public string SoundRating
        {
            get
            {
                return _soundRating;
            }
            set
            {
                _soundRating = value;
            }
        }
        //Property for other sound ratings


        //Methods
        public void Dishwashers()
        {

        }
        public void FormatForFile()
        {

        }
        public override string ToString()
        {
            Console.WriteLine("Dishwasher");
            return base.ToString();
        }
    }
}
