using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace LootBags
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Tier 1 Loot Bag Drop Chance")]
        [DefaultValue(30)]
        [ReloadRequired]
        public int LootBag1DropChance { get; set; }

        [Label("Tier 2 Loot Bag Drop Chance")]
        [DefaultValue(35)]
        [ReloadRequired]
        public int LootBag2DropChance { get; set; }

        [Label("Tier 3 Loot Bag Drop Chance")]
        [DefaultValue(40)]
        [ReloadRequired]
        public int LootBag3DropChance { get; set; }

        [Label("Tier 4 Loot Bag Drop Chance")]
        [DefaultValue(45)]
        [ReloadRequired]
        public int LootBag4DropChance { get; set; }

        [Label("Tier 5 Loot Bag Drop Chance")]
        [DefaultValue(50)]
        [ReloadRequired]
        public int LootBag5DropChance { get; set; }

        public override void OnLoaded()
        {
            LootBags.config = this;
        }
    }
}
