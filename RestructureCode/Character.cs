using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using PublicEnums;

namespace RestructureCode
{
    [Serializable()]
    public class Character : IBaseStats, ICharInfo
    {
        /// <summary>
        /// Stat Calculations
        ///     Health = class hp + Con modifiers
        /// </summary>

        private int m_Int; //Intelligence stat
        private int m_Str; //Strength stat
        private int m_Dex; //Dexterity stat
        private int m_Con; //Constitution stat
        private int m_Wis; //Wisdom stat
        private int m_Cha; //Charisma stat
        private string m_Name; //Character name

        private int m_MaxHP; //Max hp the character can have
        private int m_CurrentHP; //Current hp the character has
        private int m_Level; //Level of the object
        private int m_MaxResource; //Max amout of ability resource the charater can have
        private int m_CurrentResource; //Amout of abilty resource the character has
        private JobsAndRaces m_Race; //Race of the character
        private JobsAndRaces m_Class; //Class of the character
        
        //Implementation of the IBaseStats interface
        public int Intelligence { get { return m_Int; } }
        public int Strength { get { return m_Str; } }
        public int Dexterity { get { return m_Dex; } }
        public int Constitution { get { return m_Con; } }
        public int Wisdom { get { return m_Wis; } }
        public int Charisma { get { return m_Cha; } }
        public string Name { get { return m_Name; } }

        //Implements the ICharInfo interface
        public int MaxHealth { get { return m_MaxHP; } }
        public int CurrentHealth { get { return m_CurrentHP; } set { m_CurrentHP = value; } }
        public int Level { get { return m_Level; } }
        public int MaxResource { get { return m_MaxResource; } }
        public int Resource { get { return m_CurrentResource; } }
        public JobsAndRaces CharRace { get { return m_Race; } }
        public JobsAndRaces CharClass { get { return m_Class; } }

        //Constructor to be called when want to create a new Character
        public Character(string n, int i, int s, int d, int con, int w, int cha , JobsAndRaces race, JobsAndRaces job)
        {
            m_Name = n;
            m_Int = i;
            m_Str = s;
            m_Dex = d;
            m_Con = con;
            m_Wis = w;
            m_Cha = cha;
            m_Race = race;
            m_Class = job;
            GenerateStats();
        }

        //Default Constructor
        public Character() { }

        /// <summary>
        /// Modifys the value of our stats based on the modifiers of our Class and Race
        /// </summary>
        public void GenerateStats()
        {
            m_Int += m_Race.Intelligence;
            m_Int += m_Class.Intelligence;

            m_Str += m_Race.Strength;
            m_Str += m_Class.Strength;

            m_Dex += m_Race.Dexterity;
            m_Dex += m_Class.Dexterity;

            m_Con += m_Race.Constitution;
            m_Con += m_Class.Constitution;

            m_Wis += m_Race.Wisdom;
            m_Wis += m_Class.Wisdom;

            m_Cha += m_Race.Charisma;
            m_Cha += m_Class.Charisma;

            m_MaxHP = m_Con + m_Race.Constitution + m_Class.Constitution;
        }
    }
}
