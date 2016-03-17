using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicEnums;
using RestructureCode;

namespace Interfaces
{
    public interface IBaseStats
    {
        int Intelligence { get; }
        int Strength { get; }
        int Dexterity { get; }
        int Constitution { get; }
        int Wisdom { get; }
        int Charisma { get; }
        string Name { get; } 
    }

    public interface ICharInfo
    {
        int MaxHealth { get; } //Gets the MaxHealth of the object
        int CurrentHealth { get; set; } //Gets and Sets the current health of the object
        int Level { get; } //Gets the current level of the object
        int MaxResource { get; }
        int Resource { get; }
        IBaseStats CharClass { get; }
        IBaseStats CharRace { get; }

        void GenerateStats();
    }

    public interface IPlayer
    {
        int Experience { get; } //Gets the current amount of experience of the object
    }

    public interface IAbility
    {
        string Name { get; } //Name of the ability
        int Damage { get; } //Damage the ability can do
        int Cost { get; } //How much resource the ability cost to use
    }

    public interface IEquipable<T>
    {
        string Name { get; } //Name of equipable
        float Weight { get; } //How much the object weighs
        int Price { get; } //Sell price or buy price
        string Description { get; } //Description of the object 
        T Item { get; }
    }

    public interface IWeapon
    {
        WEAPONGROUPS WeaponGroup { get; } //Group the weapon belongs too
        WEAPONTYPES WeaponType { get; } //Type of weapon 
        int Damage { get; } //Damage the weapon can deal
        int WeaponProficiency { get; } //Bonus to weapon attributes
        int Range { get; }
        int RangePenalty { get; }
    }

    public interface IArmor
    { 
        ARMORGROUPS ArmorGroup { get; } //Group the arrmor belongs too
        int ShieldBonus { get; } //Shield bonus the arrmor gives
        int SpeedModifier { get; } //Modifys how fast the object can move
        int PenaltyCheck { get; } //Modifies object stats
        float ArcaneSpellFailChance { get; } //Chance for an arcane spell to fail
    }
}
