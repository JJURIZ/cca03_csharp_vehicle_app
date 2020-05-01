using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManager
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string GetFullName()
        {
            return $"{Year} {Make} {Model}";
        }

    }

}