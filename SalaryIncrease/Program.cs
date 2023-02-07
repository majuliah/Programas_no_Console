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
            WriteLine($"Now, you will type the ID, Name and Salary from each employee. Id doesnt repeat. ");

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

            WriteLine($"Nice! Now Ill list everyone:");
            foreach (Employee person in DataEmployees)
            {
                WriteLine($"{person}\n");
            }
            
            // employees registered 
            //checar se a id existe

            bool yes = true;
            bool found = true;
            do
            {
                WriteLine($"Now, increase someones salary. Enter the Id:");
                string id = ReadLine();
                
                foreach (Employee person in DataEmployees)
                {
                    if (person.ID == id)
                    {
                        found = true;
                        WriteLine($"....");
                        WriteLine($"I found! How much do you want to increase {person.Name}'s salary?");
                        double increase = double.Parse(ReadLine());
                        person.IncreaseSalary(increase);
                    }
                    else
                    {
                        found = false;
                        WriteLine($"Hm.. Didn't found anyone here...Do you want to try again? [Y - Yes] / [N - No]");
                        char answer = char.Parse(ReadLine());
                        
                        if (answer == 'N')
                            yes = false;
                    }
                }

                if (found)
                {
                    
                }
                
            } while (yes == true);
            
            WriteLine($"Okay, the list now is this one:");
            foreach (Employee person in DataEmployees)
            {
                WriteLine($"{person}\n");
            }
            WriteLine($"Bye!");
        }
    }
}