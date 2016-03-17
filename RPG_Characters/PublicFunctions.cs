using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPG_Characters
{
    class PublicFunctions
    {
        public static int DiceRoll(int sides)
        {
            int roll;
            Thread.Sleep(10);
            Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            roll = r.Next(1, sides);
            return roll;
        }
    }
}
