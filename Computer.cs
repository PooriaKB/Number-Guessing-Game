using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Computer
    {
        public static int chooseANumber()
        {
           return Random.Shared.Next(1, 101);
        }
    }
}
