using System;
using Microsoft.VisualBasic;

namespace VehicleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVehicle = new Vehicle
            {
                Year = 2018,
                Make = "Ford",
                Model = "Fiesta"
            };

            var myCar1 = new Car
            {
                Year = 2017,
                Make = "Honda",
                Model = "Civic",
                NumberOfDoors = 4,
                TrunkSpaceInCubicFeet = 6.4M
            };

            Vehicle myVehicle2 = new Vehicle(2015, "Ford", "Focus");
            Vehicle myVehicle3 = new Vehicle(2020, "Toyota", "Prius");

            var myCar3 = new Car
            {
                Year = 2019,
                Make = "Honda",
                Model = "Odyssee",
                NumberOfDoors = 5,
                TrunkSpaceInCubicFeet = 10.1M
            };

            LogVehicleName(myVehicle);
            LogVehicleName(myCar1);
            LogVehicleName(myCar3);
            

            //Console.WriteLine($"Year: {myVehicle.GetFullName()}");
            //Console.WriteLine(myCar1.GetFullName());

        }

        private static void LogVehicleName (Vehicle veh)
        {
            Console.WriteLine(veh.GetFullName());
        }
    }
}
