using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        //public List<Car> car;
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Car = new List<Car>();
        }

        public List<Car> Car;
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => Car.Count;
        public void Add(Car car)
        {
            if (Count < Capacity)
            {
                Car.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model) => Car.RemoveAll(c => c.Manufacturer == manufacturer && c.Model == model) > 0;
       
        public Car GetLatestCar() => Car.OrderByDescending(c => c.Year).FirstOrDefault();
        public Car GetCar(string manufacturer, string model) => Car.Where(c => c.Manufacturer == manufacturer && c.Model == model).FirstOrDefault();
        public string GetStatistics()
        {
            return $"The cars are parked in {Type}:{Environment.NewLine}{string.Join(Environment.NewLine, Car)}";
        }

    }
}
