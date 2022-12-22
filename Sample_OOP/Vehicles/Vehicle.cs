using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace Sample_OOP.Vehicles
{
    // NOTES:

    // Virtual methods have an implementation and provide the derived classes with the option of overriding it.
    // Abstract methods do not provide an implementation and force the derived classes to override the method.
    // Static methods and fields belong to the class, not the instantiated object

    // Interface   Defines a "contract" that all the classes inheriting from should follow
    //             An interface declares "what a class should have"
    //             An inheriting class defines "how it should do it"
    //             Benefits = security + multiple inheritance + "plug-and-play"
    //             If child class does not implement contract, will throw error

    // Inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent
    // class ClassChild : ClassParent {}

    interface IMachine
    {
        void Go();
    }

    internal abstract class Vehicle : IMachine // Accessible within the assembly
                                               // Will throw an error if void Go(); is not implemented due to IMachine inheritance
                                               // Since it is abstract, cannot be instantiated, but static methods and fields can still be accessed
    {
        // Fields
        private double speed = 0f; // Speed in mph
        static private protected int numberOfVehicles; // Belongs to class, not instance
        private protected enum VehicleEnergySources // Only accessible from within class and derived class, same assembly
        {
            None,
            Wind,
            Diesel,
            Gasoline
        }


        // Constructor
        // Can't use **Implicit Constructor** because static numberOfVehicles needs to be updated if a Vehicle is instantiated
        public Vehicle()
        {
            numberOfVehicles++;  // This constructor MUST be invoked by the derived classes in addition to their own constructors
                                 // The base class constructor can be called using syntax similar to class inheritance, e.g. Derived-Constructor : Base-Constructor
        }

        // Properties = combine aspects of both fields and methods (share name with a field)
        public double Speed // Define property assciated with speed (same name, except uses a capital letter to start)
        {
            // Getters & Setters = Add security to fields by encapsulation
            //                     They're accessors found within properties
            get { return speed; }
            set { speed = value; } 
        }


        // Methods
        public virtual void Go()  // Needs to be virtual (or abstract) so that derived classes can override
        {
            Console.WriteLine("Using Vehicle Go Method.\n");
        }

        public static void PrintNumberOfVehicles()
        {
            Console.WriteLine($"There are {numberOfVehicles} vehicles");
        }

    }
}
