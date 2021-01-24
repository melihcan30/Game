using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager
    {
        public void SignUp(Gamer customer)
        {
            Console.WriteLine("Oyuncu başarıyla kayıt oldu.");
        }

        public void Update(Gamer customer)
        {
            Console.WriteLine("Oyuncu bilgileri başarıyla güncellendi.");
        }

        public void Delete(Gamer customer)
        {
            Console.WriteLine("Oyuncu kaydı başarıyla silindi.");
        }
    }
}
