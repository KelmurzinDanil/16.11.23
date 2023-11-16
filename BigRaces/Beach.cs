using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    internal class Beach : IBigRaces
    {
        public void startGame()
        {
            Console.WriteLine("Игра пляж...");
        }
    }
}
