using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public Car(string manifacturer, string model, int year)
        {
            Manufacturer = manifacturer;
            Model = model;
            Year = year;
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year})".ToString();
        }
    }
}
