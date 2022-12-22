using Sample_OOP.Vehicles;

namespace Sample_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(45f, "Diesel");
            car1.Go("Car 1");

            Car car2 = new Car(55f, "Gasoline");
            car1.Go("Car 2");

            Boat boat1 = new Boat("Wind");
            boat1.Go();

            Vehicle.PrintNumberOfVehicles();

            // Polymorphism - objects can be identified by more than one type
            //                e.g. a Car object and a Boat object are both Vehicle objects
            // Car[] vehicles = { car1, car2, boat1 }; // Will throw an error bc boat1 is not a Car
            Vehicle[] vehicles = { car1, car2, boat1 }; // This is ok
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            // Generics:   Not specific to a particular data type
            //             Add <T> to: class, method, field, etc
            //             Allows for code reusability
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0f, 2.0f, 3.0f };
            string[] stringArray = { "1", "2", "3" };

            Console.WriteLine();
            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }

        public static void displayElements<T>(T[] array)
        {
            foreach (T element in array) 
            {
                Console.Write( $"{element} ");
            }
            Console.WriteLine();
        }
    }
}

