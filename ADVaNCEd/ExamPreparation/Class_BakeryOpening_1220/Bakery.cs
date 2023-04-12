using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {

        public List<Employee> Employees;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Employees = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => Employees.Count;
        public void Add(Employee employee)
        {
            if (Count < Capacity)
            {
                Employees.Add(employee);
            }
        }
        public bool Remove(string name)
            => (Employees.RemoveAll(e => e.Name == name) > 0);
        public Employee GetOldestEmployee()
            => Employees.OrderByDescending(e => e.Age).FirstOrDefault();
        public Employee GetEmployee(string name)
            => Employees.Where(e => e.Name == name).FirstOrDefault();

        public string Report()
        {
            return $"Employees working at Bakery {Name}:{Environment.NewLine}{string.Join(Environment.NewLine, Employees)}";
        }
    }
}
