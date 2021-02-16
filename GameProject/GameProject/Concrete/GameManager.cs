using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Sell(Gamer gamer)
        {
            Console.WriteLine("Oyun satıldı.");
        }
    }
}
