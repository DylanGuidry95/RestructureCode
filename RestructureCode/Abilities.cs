using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace RestructureCode
{
    class Abilities : IAbility
    {
        private string m_Name;
        private int m_Dmg;
        private int m_Cost;

        public string Name { get { return m_Name; } }
        public int Damage { get { return m_Dmg; } }
        public int Cost { get { return m_Cost; } }

        public Abilities(string n, int d, int c)
        {
            m_Name = n;
            m_Dmg = d;
            m_Cost = c;
        }

        public Abilities() { }
    }
}
