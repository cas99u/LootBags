using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBags
{
    public class Amounts
    {
        public static int common = 50;
        public static int uncommon = 30;
        public static int rare = 15;
        public static int veryRare = 5;

        public static int barMin = 8;
        public static int barMax = 12;

        public static int gemMin = 5;
        public static int gemMax = 7;

        public static int potionMin = 3;
        public static int potionMax = 5;

        public static int ammoMin = 100;
        public static int ammoMax = 200;

        public static int tierOneChance = LootBags.config.LootBag1DropChance;
        public static int tierTwoChance = LootBags.config.LootBag2DropChance;
        public static int tierThreeChance = LootBags.config.LootBag3DropChance;
        public static int tierFourChance = LootBags.config.LootBag4DropChance;
        public static int tierFiveChance = LootBags.config.LootBag5DropChance;
    }
}
