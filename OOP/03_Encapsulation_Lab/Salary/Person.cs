
namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => firstName;
            private set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            private set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get => age;
            private set
            {
                age = value;
            }
        }
        public decimal Salary
        {
            get => salary;
            private set
            {
                salary = value;
            }
        }
        public void IncreaseSalary(decimal percentage)
        {
            var increasingPerscentage = Salary * percentage / 100;
            if (Age < 30)
            {
                salary += increasingPerscentage / 2;
            }
            else
            salary += increasingPerscentage;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
