using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace SalaryIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Salary Increase: Welcome Carls!");
            WriteLine($"-------------------------\n");
            
            WriteLine($"Please, enter with a number of employees");
            short numberOfEmployees = short.Parse(ReadLine());
            WriteLine($"-------------------------\n");
            
            WriteLine($"Nice! Will be {numberOfEmployees} employees :)");
            WriteLine($"Now, you will type the ID, Name and Salary from each employee. Id doesn't repeat. ");

            List<Employee> DataEmployees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                WriteLine($"{i+1} employee: ");
                WriteLine($"Enter with an Id");
                string id = ReadLine();

                foreach (Employee person in DataEmployees)
                {
                    if (id == person.ID)
                    {
                        do
                        {
                            WriteLine($"Ids cant be the same! Enter with a valid one");
                            id = ReadLine();
                        } while (person.ID == id);
                    }
                }
                WriteLine($"Enter with a name: ");
                string name = ReadLine();
                WriteLine($"Enter with the salary");
                double salary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                Employee employee = new Employee(name, id, salary);
                DataEmployees.Add(employee);
            }

            WriteLine($"Nice! Now I'll list everyone:");
            foreach (Employee person in DataEmployees)
            {
                WriteLine($"{person}\n");
            }
            
            // employees registered 
            //check id exists
            bool answer = true;
            do
            {
                WriteLine($"Now, enter an employee's Id to increase salary");
                string idForIncrease = ReadLine();

                Employee employeeSalaryIncrease = DataEmployees.Find(person => person.ID == idForIncrease);

            if (employeeSalaryIncrease != null)
            {
                WriteLine($"I found! Now type the porcentage: ");
                double porcentege = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                employeeSalaryIncrease.IncreaseSalary(porcentege);
            }
            else
            {
                WriteLine($"Hmm.. Didnt find anyone here.. Wanna try again?");
                WriteLine($"Yes - 1  / No - 0");
                char yesOrno = char.Parse(ReadLine());
                
                if (yesOrno == '0')
                    answer = false;
                
            }
            } while (answer);
        }
    }
}