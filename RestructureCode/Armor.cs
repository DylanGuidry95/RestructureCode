using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using PublicEnums;

namespace RestructureCode
{
    public class Armor : IArmor
    {
        private ARMORGROUPS m_ArmorGroup; //Group of armor the object belongs to
        private int m_ShieldBonus; //Shield bonus the armor gives
        private int m_SpeedModifier; //Speed bonus the armor gives
        private int m_PenaltyCheck; //Modifier to the objects stats using the armor
        private float m_SpellFailChance; //Chance for a spell to not cast

        //Methods being implemented from the IArmor interface
        public ARMORGROUPS ArmorGroup { get { return m_ArmorGroup; } }
        public int ShieldBonus { get { return m_PenaltyCheck; } }
        public int SpeedModifier { get { return m_SpeedModifier; } }
        public int PenaltyCheck { get { return m_PenaltyCheck; } }
        public float ArcaneSpellFailChance { get { return 0; } }

        //Contrutor to be called when we want to create a new Armor in our application
        public Armor(ARMORGROUPS ag, int shield, int speed, int check, float failure)
        {
            m_ArmorGroup = ag;
            m_ShieldBonus = shield;
            m_SpeedModifier = speed;
            m_PenaltyCheck = check;
            m_SpellFailChance = failure;
        }

        //Default Constructor
        public Armor() { }
    }
}
