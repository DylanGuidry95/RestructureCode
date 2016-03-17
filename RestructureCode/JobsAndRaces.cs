using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace RestructureCode
{
    [Serializable()]
    public class JobsAndRaces : IBaseStats
    {
        private int m_IntMod;
        private int m_StrMod;
        private int m_DexMod;
        private int m_ConMod;
        private int m_WisMod;
        private int m_ChaMod;
        private string m_RaceName;

        public int Intelligence { get { return m_IntMod; } }
        public int Strength { get { return m_StrMod; } }
        public int Dexterity { get { return m_DexMod; } }
        public int Constitution { get { return m_ConMod; } }
        public int Wisdom { get { return m_WisMod; } }
        public int Charisma { get { return m_ChaMod; } }
        public string Name { get { return m_RaceName; } }

        public JobsAndRaces(string s, int intMod, int strMod, int dexMod, int conMod, int wisMod, int chaMod)
        {
            m_RaceName = s;
            m_IntMod = intMod;
            m_StrMod = strMod;
            m_DexMod = dexMod;
            m_ConMod = conMod;
            m_WisMod = wisMod;
            m_ChaMod = chaMod;
        }

        public JobsAndRaces() { }
    }
}
