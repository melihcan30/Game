using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CampaignManager : IGameSaleService
    {
        public void Sale()
        {
            void SignUp1()
            {
                Console.WriteLine("Kampanya Eklendi");
            }

            void Update1(Gamer customer)
            {
                Console.WriteLine("Kampanya güncellendi");
            }

            void Delete1(Gamer customer)
            {
                Console.WriteLine("Kampanya silindi.");
            }
        }
    }
}
