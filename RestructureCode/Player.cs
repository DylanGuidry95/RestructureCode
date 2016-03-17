using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicEnums;
using Interfaces;

namespace RestructureCode
{
    class Player : IPlayer
    {
        private int m_Exp;

        //Implementation of the IPlayer interface
        public int Experience { get { return m_Exp; } }

        //Constructor to create a new Player object
        public Player(int exp)
        {
            m_Exp = exp;
        }

        //Defualt constructor
        public Player() { }
    }
}
