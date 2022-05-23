using LootBags.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags
{
    public class LootBags : Mod
    {
        internal static Config config;
        public static List<CustomTooltip> myTooltips = new List<CustomTooltip>()
            {
                new CustomTooltip("'I wonder what's inside?'", true),
                new CustomTooltip("'I don't wonder what's inside...'", false),
                new CustomTooltip("'This bag feels lucky!'", true),
                new CustomTooltip("'This bag feels unlucky...'", false),
                new CustomTooltip("'I have a good feeling about this one!'", true),
                new CustomTooltip("'I have a bad feeling about this one...'", false),
                new CustomTooltip("'I feel a positive aura emanating from this one!'", true),
                new CustomTooltip("'I feel a negative aura emanating from this one...'", false)
            };
        public LootBags()
        {

        }

        public override void Load()
        {
            
        }        

        public override void Unload()
        {
            config = null;
            myTooltips = null;
        }
    }

    public class ModdedItem
    {
        public Loot loot { get; private set; }
        public int bagType { get; private set; }
        public ModdedItem(Loot loot, int bagType)
        {
            this.loot = loot;
            this.bagType = bagType;
        }
    }

    public class CustomTooltip
    {
        public string text { get; private set; }
        public bool lucky { get; private set; }

        public CustomTooltip(String text, bool lucky)
        {
            this.text = text;
            this.lucky = lucky;
        }
    }
}