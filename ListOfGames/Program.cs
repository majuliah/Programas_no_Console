using System;
using System.Globalization;
using System.Threading;
using static System.Console;
using System.Threading.Tasks;
using ListOfGames.Entities;
using ListOfGames.Entities.Enums;

namespace ListOfGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] informations = new string[15];
            //selecting the number of games name, dateofbirth, country
            WriteLine($"***********************************************************************************");
            WriteLine($"Welcome to the controller of games! ╰(*°▽°*)╯ ");
            WriteLine($"Here you control how much money you spent with digital games (●'◡'●)");
            WriteLine($"Soo, come on! I need some informations. Type your name, date of birth and your country ");
            informations[0] = ReadLine();
            informations[1] = ReadLine();
            informations[2] = ReadLine();
            Client client = new Client(informations[0], DateTime.Parse(informations[1]), informations[2] );
            
            WriteLine($"Nice to meet you {informations[0]}! Now I need you to type how many games do you want to register :) ");
            informations[3] = ReadLine();
            WriteLine($"\nOkay, it will be {informations[3]} games! ");
            WriteLine($"***********************************************************************************");
            Cls();

            
            //setting informations to pu at invoices list:
            WriteLine($"***********************************************************");
            WriteLine($"Now, I need to know the informations to make your list :)"  );
            WriteLine($"***********************************************************");
            
            for (int i = 1; i <= int.Parse(informations[3]); i++)
            {
                WriteLine($"{i}º game!");
                WriteLine("Enter the games title, date of purchase, company, status of release and the value");
                informations[4] = ReadLine();
                informations[5] = ReadLine();
                informations[6] = ReadLine();
                informations[7] = ReadLine();
                informations[8] = ReadLine();

                Company gamesCompany = new Company(informations[6]);
                ReleaseStatus status = Enum.Parse<ReleaseStatus>(informations[7]);
                Invoice invoice = new Invoice(informations[4], DateTime.Parse(informations[5]), gamesCompany, status, double.Parse(informations[8]));
                
                client.AddPurchasing(invoice);
                WriteLine("Next!");
                Cls();
            }
            WriteLine("************************************************************************************");
            WriteLine(" Yay! We did it! Tell me a month/year you want to check how much did you spent      ");

            informations[9] = ("YES");
            do
            {
                informations[10] = ReadLine();
                informations[11] = ReadLine();

                WriteLine($"At month {informations[10]}/{informations[11]}, you spend " +
                          $"{client.MonthValue(int.Parse(informations[10]), int.Parse(informations[11])).ToString($"F2", CultureInfo.InvariantCulture)}");

                WriteLine($"\nTotally, you spend {client.TotalValue().ToString($"F2", CultureInfo.InvariantCulture)}");
                Cls();
                
                WriteLine("Do you want check another month? [YES / NO]");
                informations[9] = ReadLine();
            } while (informations[9].ToUpper() == "YES");
            
            WriteLine("************************************************************************************");
            WriteLine($"It was fun to made your calculations! Have a nice day ( ﾉ ﾟｰﾟ)ﾉ");
            WriteLine("************************************************************************************");
        }
        static void Cls()
        {
            Thread.Sleep(4500);
            Clear();
        }
    }
}