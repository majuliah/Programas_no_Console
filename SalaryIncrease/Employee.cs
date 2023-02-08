using System.Globalization;

namespace SalaryIncrease
{
    public class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        private double Salary { get; set; }
        
        public Employee(){}

        public Employee(string name, string id, double salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentage)
        {
            Salary += (Salary * (porcentage / 100));
        }
        
        public override string ToString()
        {
            return ($"ID: {ID}, Name: {Name}, Salary: U${Salary.ToString($"F2", CultureInfo.InvariantCulture)} ");
        }
    }
}