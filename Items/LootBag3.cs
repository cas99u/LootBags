using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class LootBag3 : ModItem
    {
        Bag bag = new Bag();
        private Random rand = new Random();
        private Loot loot;
        private String currentTooltip;
        public LootBag3()
        {
            bag.Add(ItemID.CobaltBar, 8, 12, Amounts.common)
            .Add(ItemID.MythrilBar, 8, 12, Amounts.uncommon)
            .Add(ItemID.AdamantiteBar, 8, 12, Amounts.rare)
            .Add(ItemID.HolyWater, 10, 20, Amounts.uncommon)
            .Add(ItemID.UnholyWater, 10, 20, Amounts.uncommon)
            .Add(ItemID.DualHook, Amounts.rare)
            .Add(ItemID.MoonCharm, Amounts.rare)
            .Add(ItemID.NeptunesShell, Amounts.rare)
            .Add(ItemID.GreaterHealingPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.GreaterManaPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.PixieDust, 3, 5, Amounts.common)
            .Add(ItemID.CrystalShard, 5, 7, Amounts.common)
            .Add(ItemID.CrystalBullet, 100, 200, Amounts.uncommon)
            .Add(ItemID.HolyArrow, 100, 200, Amounts.uncommon)
            .Add(ItemID.MagicDagger, Amounts.rare)
            .Add(ItemID.SoulofLight, 5, 10, Amounts.common)
            .Add(ItemID.SoulofNight, 5, 10, Amounts.common)
            .Add(ItemID.CursedFlame, 5, 7, Amounts.common)
            .Add(ItemID.UnicornHorn, Amounts.uncommon)
            .Add(ItemID.DarkShard, Amounts.uncommon)
            .Add(ItemID.LightShard, Amounts.uncommon)
            .Add(ItemID.StarCloak, Amounts.rare)
            .Add(ItemID.PhilosophersStone, Amounts.rare)
            .Add(ItemID.TitanGlove, Amounts.rare)
            .Add(ItemID.MechanicalEye, Amounts.rare)
            .Add(ItemID.CursedArrow, 100, 200, Amounts.uncommon)
            .Add(ItemID.CursedBullet, 100, 200, Amounts.uncommon)
            .Add(ItemID.CrossNecklace, Amounts.rare)
            .Add(ItemID.MechanicalWorm, Amounts.rare)
            .Add(ItemID.MechanicalSkull, Amounts.rare)
            .Add(ItemID.SoulofFlight, 5, 10, Amounts.uncommon)
            .Add(ItemID.Pearlwood, 25, 100, Amounts.common)
            .Add(ItemID.Cutlass, Amounts.rare)
            .Add(ItemID.Frostbrand, Amounts.rare)
            .Add(ItemID.UnholyTrident, Amounts.rare)
            .Add(ItemID.BeamSword, Amounts.rare)
            .Add(ItemID.IceBow, Amounts.rare)
            .Add(ItemID.FrostStaff, Amounts.rare)
            .Add(ItemID.DiscountCard, Amounts.veryRare)
            .Add(ItemID.LuckyCoin, Amounts.veryRare)
            .Add(ItemID.UnicornonaStick, Amounts.veryRare)
            .Add(ItemID.StarVeil, Amounts.rare)
            .Add(ItemID.AdhesiveBandage, Amounts.rare)
            .Add(ItemID.ArmorPolish, Amounts.rare)
            .Add(ItemID.Blindfold, Amounts.rare)
            .Add(ItemID.FastClock, Amounts.rare)
            .Add(ItemID.Vitamins, Amounts.rare)
            .Add(ItemID.TrifoldMap, Amounts.rare)
            .Add(ItemID.MoonStone, Amounts.rare)
            .Add(ItemID.CoinGun, Amounts.veryRare)
            .Add(ItemID.PalladiumBar, 8, 12, Amounts.common)
            .Add(ItemID.OrichalcumBar, 8, 12, Amounts.uncommon)
            .Add(ItemID.TitaniumBar, 8, 12, Amounts.rare)
            .Add(ItemID.NimbusRod, Amounts.rare)
            .Add(ItemID.FrozenTurtleShell, Amounts.uncommon)
            .Add(ItemID.FlowerofFrost, Amounts.rare)
            .Add(ItemID.Uzi, Amounts.veryRare)
            .Add(ItemID.LifeFruit, 1, 3, Amounts.uncommon)
            .Add(ItemID.IceSickle, Amounts.rare)
            .Add(ItemID.MagicQuiver, Amounts.rare)
            .Add(ItemID.Bananarang, Amounts.rare)
            .Add(ItemID.MagicQuiver, Amounts.rare)
            .Add(ItemID.RodofDiscord, Amounts.veryRare)
            .Add(ItemID.TurtleShell, Amounts.rare)
            .Add(ItemID.Ichor, 5, 7, Amounts.common)
            .Add(ItemID.IchorArrow, 100, 200, Amounts.uncommon)
            .Add(ItemID.IchorBullet, 100, 200, Amounts.uncommon)
            .Add(ItemID.FrostCore, Amounts.uncommon)
            .Add(ItemID.SuperManaPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.Gatligator, Amounts.veryRare)
            .Add(ItemID.LifeforcePotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.LovePotion, 3, 5, Amounts.veryRare)
            .Add(ItemID.SpiderFang, 3, 5, Amounts.common)
            .Add(ItemID.MasterBait, 3, 5, Amounts.common)
            .Add(ItemID.LivingFireBlock, 25, 100, Amounts.common)
            .Add(ItemID.SoulDrain, Amounts.veryRare)
            .Add(ItemID.DartPistol, Amounts.veryRare)
            .Add(ItemID.DartRifle, Amounts.veryRare)
            .Add(ItemID.ChainGuillotines, Amounts.veryRare)
            .Add(ItemID.FetidBaghnakhs, Amounts.veryRare)
            .Add(ItemID.ClingerStaff, Amounts.veryRare)
            .Add(ItemID.PutridScent, Amounts.veryRare)
            .Add(ItemID.FleshKnuckles, Amounts.veryRare)
            .Add(ItemID.TendonHook, Amounts.veryRare)
            .Add(ItemID.IlluminantHook, Amounts.veryRare)
            .Add(ItemID.DaedalusStormbow, Amounts.veryRare)
            .Add(ItemID.FlyingKnife, Amounts.veryRare)
            .Add(ItemID.GoldRing, Amounts.veryRare)
            .Add(ItemID.CoinRing, Amounts.veryRare)
            .Add(ItemID.CrystalVileShard, Amounts.veryRare)
            .Add(ItemID.ShadowFlameBow, Amounts.veryRare)
            .Add(ItemID.ShadowFlameHexDoll, Amounts.veryRare)
            .Add(ItemID.ShadowFlameKnife, Amounts.veryRare)
            .Add(ItemID.CrystalSerpent, Amounts.uncommon)
            .Add(ItemID.Toxikarp, Amounts.uncommon)
            .Add(ItemID.Bladetongue, Amounts.uncommon)
            .Add(ItemID.BlessedApple, Amounts.rare)
            .Add(ItemID.StrangePlant1, Amounts.uncommon)
            .Add(ItemID.StrangePlant2, Amounts.uncommon)
            .Add(ItemID.StrangePlant3, Amounts.uncommon)
            .Add(ItemID.StrangePlant4, Amounts.uncommon)
            .Add(ItemID.BloodWater, 10, 20, Amounts.uncommon)
            .Add(ItemID.Bacon, 3, 5, Amounts.rare)
            .Add(ItemID.AncientHorn, Amounts.rare)
            .Add(ItemID.PocketMirror, Amounts.rare)
            .Add(ItemID.AncientBattleArmorMaterial, Amounts.uncommon)
            .Add(ItemID.SanguineStaff, Amounts.rare)
            .Add(ItemID.SharpTears, Amounts.rare)
            .Add(ItemID.DripplerFlail, Amounts.rare)
            .Add(ItemID.BloodHamaxe, Amounts.rare)
            .Add(ItemID.ZapinatorOrange, Amounts.rare)
            .Add(ItemID.LuckPotionGreater, 3, 5, Amounts.uncommon)
            .Add(ItemID.Smolstar, Amounts.rare)
            .Add(ItemID.QueenSlimeCrystal, Amounts.rare);

            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Loot Bag : Tier 3");
            // Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 30;
            Item.rare = ItemRarityID.LightRed;
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
                .AddIngredient<LootBag3>()
                .AddCustomShimmerResult(ModContent.ItemType<LootBag2>(), 2)
                .Register();
        }
    }

}