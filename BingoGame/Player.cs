using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public class Player
    {
        public int BingoCount = 0;

        public int Input()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
