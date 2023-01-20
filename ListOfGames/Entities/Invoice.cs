using System;
using ListOfGames.Entities.Enums;

namespace ListOfGames.Entities
{
    public class Invoice
    {
        public string GamesTitle { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public Company ReleaseCompany { get; set; }
        public ReleaseStatus Release { get; set; }
        public double ValueOfGame { get; set; }

        public Invoice(){}
        public Invoice(string gamesTitle, DateTime dateOfPurchase, Company releaseCompany, ReleaseStatus release, double valueOfGame)
        {
            GamesTitle = gamesTitle;
            DateOfPurchase = dateOfPurchase;
            ReleaseCompany = releaseCompany;
            Release = release;
            ValueOfGame = valueOfGame;
        }
    }
}