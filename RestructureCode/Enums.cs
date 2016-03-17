using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicEnums
{
    //Weapon groups availaible when creating new weapons
    public enum WEAPONGROUPS
    {
        Axe,
        Bow,
        Crossbow,
        Flail,
        Hammer,
        Heavyblade,
        Lightblade,
        Mace,
        Pick,
        Polearm,
        Sling,
        Spear,
        Staff,
        Unarmed,
        count
    }

    //Weapon types available when creating new weapons
    public enum WEAPONTYPES
    {
        Ranged,
        Melee,
        count
    }

    //Available groups when creating new arrmor
    public enum ARMORGROUPS
    {
        Light,
        Heavy,
        SpecialLight,
        SpecialHeavy,
        Shield,
        count
    }
}
