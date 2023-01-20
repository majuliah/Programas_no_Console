using System;
using System.Collections.Generic;

namespace ListOfGames.Entities
{
    public class Client
    {
        public string ClientsName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }

        public List<Invoice> Purchasing { get; set; } = new List<Invoice>();

        public Client(){}

        public Client(string clientsName, DateTime dateOfBirth, string adress)
        {
            ClientsName = clientsName;
            DateOfBirth = dateOfBirth;
            Country = adress;
        }

        public void AddPurchasing(Invoice invoice)
        {
            Purchasing.Add(invoice);
        }

        public void RemovePurchasing(Invoice invoice)
        {
            Purchasing.Remove(invoice);
        }

        public double TotalValue()
        {
            double sum = 0.0;

            foreach (var value in Purchasing)
            {
                sum += value.ValueOfGame;
            }

            return sum;
        }

        public double MonthValue(int month, int year)
        {
            double sum = 0.0;

            foreach (Invoice invoice in Purchasing)
            {
                if (invoice.DateOfPurchase.Month == month && invoice.DateOfPurchase.Year == year)
                {
                    sum += invoice.ValueOfGame;
                }
            }
            return sum;
        }
    }
}