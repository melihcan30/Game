using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class SummerHoliday : IGameSaleService
    {
        public void Sale()
        {
            Console.WriteLine("Yaz tatiline özel kampanyalarımız vardır.");
        }
    }
}
