using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using PublicEnums;

namespace RestructureCode
{
    public class Weapon : IWeapon
    {
        private WEAPONGROUPS m_WeaponGroup; //Weapon group the weapon belongs to
        private WEAPONTYPES m_weaponType; //Weapon type the weapon is
        private int m_Damage; //How much damage the object does
        private int m_WeaponProficiency; //Weapon bonuses
        private int m_Range;
        private int m_RangePenalty;

        //Members of the IWeapon Interface
        public WEAPONGROUPS WeaponGroup { get { return m_WeaponGroup; } }
        public WEAPONTYPES WeaponType { get { return m_weaponType; } }
        public int Damage { get { return m_Damage; } }
        public int WeaponProficiency { get { return m_WeaponProficiency; } }
        public int Range { get { return m_Range; } }
        public int RangePenalty { get { return m_RangePenalty; } }
        //Constructor to be called when the user wants to create a new weapon
        public Weapon(WEAPONGROUPS wg, WEAPONTYPES wt, int dmg, int prof)
        {
            m_WeaponGroup = wg;
            m_weaponType = wt;
            m_Damage = dmg;
            m_WeaponProficiency = prof;
        }

        //Default constructor
        public Weapon() { }
    }
}
