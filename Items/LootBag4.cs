using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.Creative;
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
            bag.Add(ItemID.Keybrand, Amounts.rare)
            .Add(ItemID.TacticalShotgun, Amounts.rare)
            .Add(ItemID.PaladinsShield, Amounts.rare)
            .Add(ItemID.BlackBelt, Amounts.rare)
            .Add(ItemID.Tabi, Amounts.rare)
            .Add(ItemID.ChlorophyteBar, 8, 12, Amounts.common)
            .Add(ItemID.ChlorophyteBullet, 100, 200, Amounts.uncommon)
            .Add(ItemID.WispinaBottle, Amounts.rare)
            .Add(ItemID.HallowedBar, 8, 12, Amounts.common)
            .Add(ItemID.ChlorophyteArrow, 100, 200, Amounts.common)
            .Add(ItemID.SniperRifle, Amounts.rare)
            .Add(ItemID.MagnetSphere, Amounts.rare)
            .Add(ItemID.LihzahrdPowerCell, Amounts.rare)
            .Add(ItemID.RifleScope, Amounts.rare)
            .Add(ItemID.RodofDiscord, Amounts.rare)
            .Add(ItemID.DeathSickle, Amounts.uncommon)
            .Add(ItemID.Ectoplasm, 5, 10, Amounts.common)
            .Add(ItemID.PaladinsHammer, Amounts.rare)
            .Add(ItemID.ShroomiteBar, 8, 12, Amounts.rare)
            .Add(ItemID.BrokenHeroSword, Amounts.veryRare)
            .Add(ItemID.PumpkinMoonMedallion, Amounts.rare)
            .Add(ItemID.SniperScope, Amounts.rare)
            .Add(ItemID.PulseBow, Amounts.uncommon)
            .Add(ItemID.TruffleWorm, Amounts.rare)
            .Add(ItemID.LunarTabletFragment, 3, 5, Amounts.common)
            .Add(ItemID.ButchersChainsaw, Amounts.uncommon)
            .Add(ItemID.ToxicFlask, Amounts.uncommon)
            .Add(ItemID.PsychoKnife, Amounts.uncommon)
            .Add(ItemID.NailGun, Amounts.uncommon)
            .Add(ItemID.DeadlySphereStaff, Amounts.uncommon)
            .Add(ItemID.SpectreBar, 8, 12, Amounts.rare)
            .Add(ItemID.EmpressButterfly, Amounts.rare);

            currentTooltip = LootBags.myTooltips[0].text;

        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Loot Bag : Tier 4");
            // Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
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
                .AddIngredient<LootBag4>()
                .AddCustomShimmerResult(ModContent.ItemType<LootBag3>(), 2)
                .Register();
        }
    }

}