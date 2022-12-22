using System;
using System.Collections.Generic;

namespace Sample_OOP.Vehicles
{
    internal class Boat : Vehicle
    {
        // Fields
        private string energySource; 
        private bool hasSail;
        private bool hasPropeller;


        // Constuctors
        public Boat() 
        {
            energySource = VehicleEnergySources.None.ToString(); // Using enum to force consistency with overloaded method
            hasSail = false;
            hasPropeller = false;
        }

        public Boat(string energySource)
        {
            switch (energySource)
            {
                case "None":
                    energySource = VehicleEnergySources.None.ToString();  // Enum inherited from Vehicle class
                    hasSail = false;
                    hasPropeller = false;
                    break;
                case "Wind":
                    energySource = VehicleEnergySources.Wind.ToString();
                    hasSail = true;
                    hasPropeller = false; // Obbiously a sailboat could also have a gasoline engine and propeller, but this is just for example
                    break;
                case "Diesel":
                    energySource = VehicleEnergySources.Diesel.ToString();
                    hasSail = false;
                    hasPropeller = true;
                    break;
                case "Gasoline":
                    energySource = VehicleEnergySources.Gasoline.ToString();
                    hasSail = false;
                    hasPropeller = false;
                    break;
                default:
                    energySource = VehicleEnergySources.None.ToString();
                    hasSail = false;
                    hasPropeller = false;
                    break;
            }
        }


        // Properties
        // Note, but not implemented
        // For most basic get / set yopu can use autoimplmented properties. 
        // To do this: Do NOT declare the field, e.g. int field1;
        //             add line in properties section as follow:
        //                 public int Field1 { get; set; }

        public string EnergySource
        {
            get { return energySource; } // Allow outside code to read energy source
            set { energySource = value; } // Allow outside code to change energy source
        }

        public bool HasSail
        {
            get { return hasSail; } 
            set { hasSail = value; } 
        }

        public bool HasPropeller
        {
            get { return HasPropeller; } 
            set { HasPropeller = value; } 
        }


        // Methods
        public override void Go() 
        {
            // Note, this override does not use the base method at all
            if (hasSail)
            {
                Console.WriteLine("The boat is sailing.\n");
            }
            else if (hasPropeller)
            {
                Console.WriteLine("The boat is puttering along.\n");
            }
            else
            {
                Console.WriteLine("The boat is dead in the water.\n");
            }

        }

    }
}



