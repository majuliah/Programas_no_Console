namespace SalaryIncrease
{
    public class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Salary { get; set; }
        
        public Employee(){}

        public Employee(string name, string id, double salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentage)
        {
            Salary = (Salary * porcentage) + Salary;
        }
        
        public override string ToString()
        {
            return ($"ID: {ID}, Name: {Name}, Salary: U${Salary} ");
        }
    }
}