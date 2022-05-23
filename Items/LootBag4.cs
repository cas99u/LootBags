using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class LootBag4 : ModItem
    {
        Bag bag = new Bag();
        private Random rand = new Random();
        private Loot loot;
        private String currentTooltip;
        public LootBag4()
        {
            // bag.AddItem(ItemID., Amounts.);
            // Basic Resources
            bag.AddItem(ItemID.GreaterHealingPotion, 3, 5, Amounts.common);
            bag.AddItem(ItemID.HallowedBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.LihzahrdPowerCell, 1, 3, Amounts.uncommon);
            bag.AddItem(ItemID.TruffleWorm, 1, 3, Amounts.uncommon);
            // Biome Keys
            bag.AddItem(ItemID.JungleKey, Amounts.rare);
            bag.AddItem(ItemID.CorruptionKey, Amounts.rare);
            bag.AddItem(ItemID.CrimsonKey, Amounts.rare);
            bag.AddItem(ItemID.HallowedKey, Amounts.rare);
            bag.AddItem(ItemID.FrozenKey, Amounts.rare);
            bag.AddItem(ItemID.DungeonDesertKey, Amounts.rare);
            // Jungle
            bag.AddItem(ItemID.Yelets, Amounts.uncommon);
            bag.AddItem(ItemID.Uzi, Amounts.uncommon);
            bag.AddItem(ItemID.ButterflyDust, Amounts.uncommon);
            bag.AddItem(ItemID.TatteredBeeWing, Amounts.uncommon);
            bag.AddItem(ItemID.TurtleShell, Amounts.uncommon);
            bag.AddItem(ItemID.LifeFruit, 1, 3, Amounts.uncommon);
            bag.AddItem(ItemID.ChlorophyteBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            // Solar Eclipse
            bag.AddItem(ItemID.EyeSpring, Amounts.rare);
            bag.AddItem(ItemID.BrokenBatWing, Amounts.rare);
            bag.AddItem(ItemID.MoonStone, Amounts.uncommon);
            bag.AddItem(ItemID.NeptunesShell, Amounts.uncommon);
            bag.AddItem(ItemID.BrokenHeroSword, Amounts.rare);
            bag.AddItem(ItemID.DeathSickle, Amounts.uncommon);
            bag.AddItem(ItemID.ButchersChainsaw, Amounts.uncommon);
            bag.AddItem(ItemID.DeadlySphereStaff, Amounts.uncommon);
            bag.AddItem(ItemID.ToxicFlask, Amounts.uncommon);
            bag.AddItem(ItemID.NailGun, Amounts.uncommon);
            bag.AddItem(ItemID.PsychoKnife, Amounts.uncommon);
            bag.AddItem(ItemID.SolarTablet, Amounts.uncommon);
            // Dungeon
            bag.AddItem(ItemID.BoneFeather, Amounts.rare);
            bag.AddItem(ItemID.Keybrand, Amounts.uncommon);
            bag.AddItem(ItemID.WispinaBottle, Amounts.uncommon);
            bag.AddItem(ItemID.MagnetSphere, Amounts.uncommon);
            bag.AddItem(ItemID.PaladinsShield, Amounts.rare);
            bag.AddItem(ItemID.PaladinsHammer, Amounts.rare);
            bag.AddItem(ItemID.ShadowbeamStaff, Amounts.uncommon);
            bag.AddItem(ItemID.SpectreStaff, Amounts.uncommon);
            bag.AddItem(ItemID.InfernoFork, Amounts.uncommon);
            bag.AddItem(ItemID.RocketLauncher, Amounts.uncommon);
            bag.AddItem(ItemID.RifleScope, Amounts.uncommon);
            bag.AddItem(ItemID.SniperRifle, Amounts.uncommon);
            bag.AddItem(ItemID.TacticalShotgun, Amounts.uncommon);
            bag.AddItem(ItemID.BlackBelt, Amounts.uncommon);
            bag.AddItem(ItemID.Tabi, Amounts.uncommon);
            bag.AddItem(ItemID.Kraken, Amounts.uncommon);
            bag.AddItem(ItemID.MaceWhip, Amounts.uncommon);
            bag.AddItem(ItemID.ShadowJoustingLance, Amounts.uncommon);
            bag.AddItem(ItemID.Ectoplasm, 10, 15, Amounts.uncommon);
            // Pumpkin Moon
            bag.AddItem(ItemID.StakeLauncher, Amounts.rare);
            bag.AddItem(ItemID.NecromanticScroll, Amounts.rare);
            bag.AddItem(ItemID.SpookyHook, Amounts.rare);
            bag.AddItem(ItemID.SpookyTwig, Amounts.rare);
            bag.AddItem(ItemID.CursedSapling, Amounts.rare);
            bag.AddItem(ItemID.SpookyWood, 50, 150, Amounts.rare);
            // Frost Moon
            bag.AddItem(ItemID.ChristmasTreeSword, Amounts.rare);
            bag.AddItem(ItemID.Razorpine, Amounts.rare);
            bag.AddItem(ItemID.FestiveWings, Amounts.rare);
            bag.AddItem(ItemID.ChristmasHook, Amounts.rare);
            bag.AddItem(ItemID.EldMelter, Amounts.rare);
            bag.AddItem(ItemID.ChainGun, Amounts.rare);

            currentTooltip = LootBags.myTooltips[0].text;

        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Loot Bag : Tier 4");
            Tooltip.SetDefault("Right click to open");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 30;
            Item.rare = ItemRarityID.Yellow;
            Item.maxStack = 999;
            Item.value = 0;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ModContent.ItemType<LootBag5>(), 1)
                .Register();
        }


        public override void RightClick(Player player)
        {
            loot = bag.Roll(player);
            player.QuickSpawnItem(player.GetSource_OpenItem(loot.item), loot.item, rand.Next(loot.min, loot.max + 1));

            currentTooltip = getTooltip(LootBags.myTooltips, player);
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(Mod, "FlavorText", currentTooltip));
        }

        public override bool OnPickup(Player player)
        {
            currentTooltip = getTooltip(LootBags.myTooltips, player);
            return true;
        }

        private String getTooltip(List<CustomTooltip> tooltips, Player player)
        {
            bool playerLucky = player.luck >= 0 ? true : false;
            int ran = Main.rand.Next(0, tooltips.Count);
            if (tooltips[ran].lucky == playerLucky)
            {
                return tooltips[ran].text;
            }
            else
            {
                return getTooltip(tooltips, player);
            }
        }
    }

}