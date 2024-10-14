
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
            if (!long.TryParse(input, out userItemNumber))
            {
                Console.WriteLine("The appliance is not available to be checkedout.\n");
                return;
            }
            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (Appliance appliance in Appliances)
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
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.\n");
            }
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance ''{userItemNumber}'' has been checked out.\n");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.\n");
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
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Brand.Equals(userBrand, StringComparison.OrdinalIgnoreCase))
                {
                    foundAppliances.Add(appliance);
                }
            }


            // Display found appliances
            if (foundAppliances.Count == 0)
            {
                Console.WriteLine($"No appliances found for the brand: {userBrand}\n");
            }
            else
            {
                DisplayAppliancesFromList(foundAppliances, 0);
            }
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
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            string userDoors;

            // Get user input as string and assign to variable
            userDoors = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            int numberOfDoors;
            if (!int.TryParse(userDoors, out numberOfDoors))
            {
                Console.WriteLine("Invalid Input: Please enter a valid input\n");
                return;
            }

            // Create list to hold found Appliance objects
            List<Refrigerator> foundAppliances = new List<Refrigerator>();

            // Iterate/loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
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

            if (foundAppliances.Count == 0)
            {
                Console.WriteLine($"No refrigerators found with {numberOfDoors}\n");
            }
            else
            {
                DisplayAppliancesFromList(foundAppliances.Cast<Appliance>().ToList(), 0);
            }
        }


        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any\n1 - Residential\n2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine("Enter Grade: ");

            // Get user input as string and assign to variable
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string userInput = Console.ReadLine();
            string grade = "";

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Invalid option.
            // Return to calling (previous) method
            // return;
            if (userInput == "0")
            {
                grade = "Any";
            }
            else if (userInput == "1")
            {
                grade = "Residential";
            }
            else if (userInput == "2")
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
                return;
            }

            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any\n1 - 18 Volt\n2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter Voltage: ");

            // Get user input as string
            // Create variable to hold voltage
            string userInputVoltage = Console.ReadLine();
            int voltage = 0;

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
            if (userInputVoltage == "0")
            {
                voltage = 0;
            }
            else if (userInputVoltage == "1")
            {
                voltage = 18;
            }
            else if (userInputVoltage == "2")
            {
                voltage = 24;
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Vacuum> found = new List<Vacuum>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;

                    if ((grade == "Any" || vacuum.Grade.Equals(grade, StringComparison.OrdinalIgnoreCase)) &&
                        (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        found.Add(vacuum);
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            if (found.Count == 0)
            {
                Console.WriteLine("No vacuums found with the specified criteria.\n");
            }
            else
            {
                DisplayAppliancesFromList(found.Cast<Appliance>().ToList(), 0);
            }
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            Console.WriteLine("0 _ Any"); // Write "0 - Any"
            Console.WriteLine("1 - Kitchen");// Write "1 - Kitchen"
            Console.WriteLine("2 - Work Site");// Write "2 - Work site"

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");

            // Get user input as string and assign to variable
            string userRoom;
            userRoom = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;
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
            if (userRoom == "0")
            {
                roomType = 'A';
            }
            else if (userRoom == "1")
            {
                roomType = 'K';
            }
            else if (userRoom == "2")
            {
                roomType = 'W';
            }
            else
            {
                Console.WriteLine("Invalid Option.\n");
                return;
            }
            // Create variable that holds list of 'found' appliances
            List<Microwave> found = new List<Microwave>();
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        found.Add(microwave);
                    }
                }
            }

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            if (found.Count == 0)
            {
                Console.WriteLine("No microwaves found with the specified criteria.\n");
            }
            else
            {
                DisplayAppliancesFromList(found.Cast<Appliance>().ToList(), 0);
            }
        }


        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options:");

            Console.WriteLine("0 - Any"); // Write "0 - Any"
            Console.WriteLine("1 - Quiestest"); // Write "1 - Quietest"
            Console.WriteLine("2 - Quieter");// Write "2 - Quieter"
            Console.WriteLine("3 - Quiet");// Write "3 - Quiet"
            Console.WriteLine("4 - Moderate");// Write "4 - Moderate"

            // Write "Enter sound rating
            Console.WriteLine("Enter Sound Rating:");

            // Get user input as string and assign to variable
            string userRating;
            userRating = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating;

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

            if (userRating == "0")
            {
                soundRating = "0";
            }
            else if (userRating == "1")
            {
                soundRating = "Qt";
            }
            else if (userRating == "2")
            {
                soundRating = "Qr";
            }
            else if (userRating == "3")
            {
                soundRating = "Qu";
            }
            else if (userRating == "4")
            {
                soundRating = "M";
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
                return;
            }

            // Create variable that holds list of found appliances
            List<Dishwasher> found = new List<Dishwasher>();

            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;

                    if (soundRating == "Any" || dishwasher.SoundRatingDisplay == soundRating)
                    {
                        found.Add(dishwasher);
                    }
                }
            }
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            if (found.Count == 0)
            {
                Console.WriteLine("No dishwashers found with the specified criteria.\n");
            }
            else
            {
                DisplayAppliancesFromList(found.Cast<Appliance>().ToList(), 0);
            }
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
            string userapplianceType = Console.ReadLine();

            Console.WriteLine("Enter number of appliances: ");// Write "Enter number of appliances: "

            string userNumAppliances;// Get user input as string and assign to variable
            userNumAppliances = Console.ReadLine();

            // Convert user input from string to int
            if (!int.TryParse(userNumAppliances, out int numAppliances))
            {
                Console.WriteLine("Invalid number of appliances input.Please enter a valid number\n");
                return;
            }

            // Create variable to hold list of found appliances
            List<Appliance> foundappliances = new List<Appliance>();
            // Loop through appliances
            foreach (Appliance appliance in Appliances)
            {
                switch (userapplianceType)
                {
                    case "0":
                        foundappliances.Add(appliance);
                        break;
                    case "1":
                        if (appliance is Refrigerator)
                            foundappliances.Add(appliance);
                        break;
                    case "2":
                        if (appliance is Vacuum)
                            foundappliances.Add(appliance);
                        break;
                    case "3":
                        if (appliance is Microwave)
                            foundappliances.Add(appliance);
                        break;
                    case "4":
                        if (appliance is Dishwasher)
                            foundappliances.Add(appliance);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        return;

                }
            }

            // Randomize list of found appliances

            foundappliances.Sort(new RandomComparer());


            // Display found appliances (up to max. number inputted)
            if (foundappliances.Count == 0)
            {
                Console.WriteLine("No Appliances");
            }
            else
            {
                DisplayAppliancesFromList(foundappliances, 0);
            }
        }
    }
}
