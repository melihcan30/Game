using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();

            gamer1.CustomerName = "Melihcan";
            gamer1.CustomerSurname = "Serbest";
            gamer1.TcNo = "12345678910";
            gamer1.DateOfBirth = "1999";

            Gamer gamer2 = new Gamer();

            gamer2.CustomerName = "Sena";
            gamer2.CustomerSurname = "Gedik";
            gamer2.TcNo = "01987654321";
            gamer2.DateOfBirth = "2000";

            Gamer gamer3 = new Gamer();

            gamer3.CustomerName = "İrem Sultan";
            gamer3.CustomerSurname = "Kızıl";
            gamer3.TcNo = "54321678908";
            gamer3.DateOfBirth = "1999";

            GamerManager customerManager = new GamerManager();

            customerManager.SignUp(gamer1);
            customerManager.Update(gamer2);
            customerManager.Delete(gamer3);

            IGameSaleService summerHoliday = new SummerHoliday();
            IGameSaleService christmasCampaign = new ChristmasCampaign();

            List<IGameSaleService> sales = new List<IGameSaleService>() { summerHoliday, christmasCampaign };

            Console.ReadLine();
        }
    }
}
