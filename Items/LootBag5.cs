using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class LootBag5 : ModItem
    {
        Bag bag = new Bag();
        private Random rand = new Random();
        private Loot loot;
        private String currentTooltip;
        public LootBag5()
        {
            bag.Add(ItemID.GoldBird, Amounts.uncommon)
            .Add(ItemID.GoldBunny, Amounts.uncommon)
            .Add(ItemID.GoldButterfly, Amounts.uncommon)
            .Add(ItemID.GoldFrog, Amounts.uncommon)
            .Add(ItemID.GoldGrasshopper, Amounts.uncommon)
            .Add(ItemID.GoldMouse, Amounts.uncommon)
            .Add(ItemID.GoldWorm, Amounts.uncommon)
            .Add(ItemID.FragmentVortex, 8, 12, Amounts.common)
            .Add(ItemID.FragmentNebula, 8, 12, Amounts.common)
            .Add(ItemID.FragmentSolar, 8, 12, Amounts.common)
            .Add(ItemID.FragmentStardust, 8, 12, Amounts.common)
            .Add(ItemID.LunarBar, 8, 12, Amounts.common)
            .Add(ItemID.SuperHealingPotion, 3, 5, Amounts.common)
            .Add(ItemID.SquirrelGold, Amounts.uncommon)
            .Add(ItemID.MoonlordBullet, 100, 200, Amounts.common)
            .Add(ItemID.MoonlordArrow, 100, 200, Amounts.common)
            .Add(ItemID.CelestialSigil, Amounts.rare)
            .Add(ItemID.GoldGoldfish, Amounts.uncommon)
            .Add(ItemID.GoldDragonfly, Amounts.uncommon)
            .Add(ItemID.GoldLadyBug, Amounts.uncommon)
            .Add(ItemID.GoldWaterStrider, Amounts.uncommon)
            .Add(ItemID.GoldSeahorse, Amounts.uncommon)
            .Add(ItemID.TerraToilet, Amounts.veryRare)
            .Add(ItemID.MoonLordLegs, Amounts.veryRare)
            .Add(ItemID.BottomlessShimmerBucket, Amounts.rare);

            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Loot Bag : Tier 5");
            // Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 30;
            Item.rare = ItemRarityID.Cyan;
            Item.maxStack = 999;
            Item.value = 0;
        }

        public override bool CanRightClick()
        {
            return true;
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

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<LootBag5>()
                .AddCustomShimmerResult(ModContent.ItemType<LootBag4>(), 2)
                .Register();
        }
    }

}