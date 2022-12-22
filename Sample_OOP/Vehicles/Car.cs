using System;
using System.Collections.Generic;

namespace Sample_OOP.Vehicles
{
    internal class Car : Vehicle
    {
        // Fields
        private int wheels = 4;
        private string energySource;


        // Constuctors
        public Car()
        {
            energySource = VehicleEnergySources.None.ToString(); // Using enum to force consistency with overloaded method
            wheels = 0;
        }

        public Car(string energySource)  // Complains about a possible null string, but all three options are non-null
        {
            switch (energySource)
            {
                case "Diesel":
                    energySource = VehicleEnergySources.Diesel.ToString();
                    break;
                case "Gasoline":
                    energySource = VehicleEnergySources.Gasoline.ToString();
                    break;
                default:
                    energySource = VehicleEnergySources.None.ToString();
                    break;
            }
        }

        public Car(double speed)
        {
            energySource = VehicleEnergySources.None.ToString();
            this.Speed = speed;
        }

        public Car(double speed, string energySource)
        {
            this.Speed = speed;
            switch (energySource)
            {
                case "Diesel":
                    energySource = VehicleEnergySources.Diesel.ToString();
                    break;
                case "Gasoline":
                    energySource = VehicleEnergySources.Gasoline.ToString();
                    break;
                default:
                    energySource = VehicleEnergySources.None.ToString();
                    break;
            }
        }

        // Properties
        public string EnergySource
        {
            get { return energySource; } // Allow outside code to read energy source
            set { energySource = value; } // Allow outside code to change energy source
        }

        public int Wheels
        {
            get { return wheels; }
            // Don't want outside code to change number of wheels, therefore no setter
        }


        // Methods
        public override void Go() // overriden
        {
            // base.Go(); // This would call the parent implementation
            Console.WriteLine($"A car is travelling at {Speed} mph.\n");
        }

        public void Go(string name) // overloaded
        {
            Console.WriteLine($"{name} is travelling at {Speed} mph.\n");
        }
    }
}
