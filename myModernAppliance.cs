﻿
using Classes_Inheritance_Assignment.Entities;
using Classes_Inheritance_Assignment.Entities.Abstract;
using Classes_Inheritance_Assignment.Helpers;

namespace Classes_Inheritance_Assignment                           // This is the one we should be working on, we have to fill out all methods
{
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long userItemNumber;

            // Get user input as string and assign to variable.
            string input = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            if (long.TryParse(input, out userItemNumber))
            {
                return;
            }
            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;
            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == userItemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }
;
            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
            if (foundAppliance != null)
            {
                Console.WriteLine("No appliances with that item number.");

            }
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }
        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string userBrand = Console.ReadLine();
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (true)
                {
                    foundAppliances.Add(appliance);
                }
            }


            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");// Write "0 - Any"
            Console.WriteLine("2 - Double Doors");// Write "2 - Double doors"
            Console.WriteLine("3 - Three Doors");// Write "3 - Three doors"
            Console.WriteLine("4 - Four Doors");// Write "4 - Four doors"

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors; ");

            // Create variable to hold entered number of doors
            string userDoors;

            // Get user input as string and assign to variable
            userDoors = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            int numberOfDoors;
            if (int.TryParse(userDoors, out numberOfDoors))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator refrigerator)
                {
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors) // || is an or statement
                    {
                        foundAppliances.Add(refrigerator);
                    }
                }
            }
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            //Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible Options: ");

            Console.WriteLine("0 - Any"); // Write "0 - Any"
            Console.WriteLine("1 - Residential"); // Write "1 - Residential"
            Console.WriteLine("2 - Commercial"); // Write "2 - Commercial"

            // Write "Enter grade:"
            Console.WriteLine("Enter Grade: ");

            // Get user input as string and assign to variable
            string userGrade;
            userGrade = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."


            switch (userGrade)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residental";
                    break;
                case "2":
                    grade = "Commercial";
                        break;
                default:
                    Console.WriteLine("Invalid Option");
                    return;
            }                                         
            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            Console.WriteLine("Possible Options: ");

            Console.WriteLine("0 - Any"); // Write "0 - Any"
            Console.WriteLine("1 - 18 Volt"); // Write "1 - 18 Volt"
            Console.WriteLine("2 - 24 Volt");// Write "2 - 24 Volt"

            Console.WriteLine("Enter Voltage: ");// Write "Enter voltage:"

            // Get user input as string
            string userVoltage;
            userVoltage = Console.ReadLine();
            // Create variable to hold voltage
            string volts;

            switch (userVoltage)
            {
                case "0":
                    volts = "Any";
                    break;
                case "1":
                    volts = "18";
                    break;
                case "2":
                    volts = "24";
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    return;
            }

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            // Create found variable to hold list of found appliances.
            List<Vacuum> foundVacuums = new List<Vacuum>();

            
            foreach (var appliance in Appliances)// Loop through Appliances
            {
                if (appliance is Vacuum vacuum)
                {
                    if ((grade == "Any" || vacuum.Grade == grade) && (userVoltage == "0" || vacuum.BatteryVoltage == (short)volts))
                    {
                        foundVacuums.Add(vacuum);
                    }
                }
            }
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(foundVacuums, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");


            Console.WriteLine("0 - Any");// Write "0 - Any"
            Console.WriteLine("1 - Refrigerators");// Write "1 – Refrigerators"
            Console.WriteLine("2 - Vacuums");// Write "2 – Vacuums"
            Console.WriteLine("3 - Microwaves");// Write "3 – Microwaves"
            Console.WriteLine("4 - Dishwashers");// Write "4 – Dishwashers"

            Console.WriteLine("Enter type of appliance: ");// Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable
            Appliance userAppliance;

            Console.WriteLine("Enter number of appliances: ");// Write "Enter number of appliances: "

            string userNumAppliances;// Get user input as string and assign to variable
            userNumAppliances = Console.ReadLine();
            // Convert user input from string to int
            if (int.TryParse(userNumAppliances))
            {

            }

            // Create variable to hold list of found appliances

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
