using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMod1
{
    public enum Types
    {
        Fire,
        Silver,
        Gold,
        BloodDragon
    }

    public class ItemType
    {
        public static Types GetItemType(int level)
        {
            Dictionary<int, Types> itemTypeByLevel = new Dictionary<int, Types>
            {
                {0, Types.Silver},
                {1, Types.Fire},
                {2, Types.Gold},
                {3, Types.Gold },
                {4, Types.Fire},
                {5, Types.Silver},
                {6, Types.Silver},
                {7, Types.BloodDragon},
                {8, Types.Gold },
                {9, Types.Gold },
                {10, Types.BloodDragon},
                {11, Types.Gold }
            };

            return itemTypeByLevel[level];
        }
    }
}
