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
            // bag.AddItem(ItemID., Amounts.);
            // Basic Resources
            //bag.AddItem(ItemID.GreaterHealingPotion, 3, 5, Amounts.common);
            //bag.AddItem(ItemID.SuperHealingPotion, 3, 5, Amounts.uncommon);
            //// Pillars/Moonlord
            //bag.AddItem(ItemID.FragmentSolar, 15, 30, Amounts.common);
            //bag.AddItem(ItemID.FragmentVortex, 15, 30, Amounts.common);
            //bag.AddItem(ItemID.FragmentNebula, 15, 30, Amounts.common);
            //bag.AddItem(ItemID.FragmentStardust, 15, 30, Amounts.common);
            //bag.AddItem(ItemID.CelestialSigil, Amounts.uncommon);
            //bag.AddItem(ItemID.LunarBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            //// Martian Madness
            //bag.AddItem(ItemID.LaserDrill, Amounts.uncommon);
            //bag.AddItem(ItemID.ChargedBlasterCannon, Amounts.uncommon);
            //bag.AddItem(ItemID.AntiGravityHook, Amounts.uncommon);
            //bag.AddItem(ItemID.BrainScrambler, Amounts.uncommon);

            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Loot Bag : Tier 5");
            // Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
            ItemID.Sets.ShimmerTransformToItem[Type] = ModContent.ItemType<LootBag4>();
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
    }

}