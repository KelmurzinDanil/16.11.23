using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    internal class Mousetrap : IBigRaces
    {
        public void startGame()
        {
            Console.WriteLine("Игра мышеловка...");
        }
    }
}
