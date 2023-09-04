using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class LootBag2 : ModItem
    {
        Bag bag = new Bag();
        private Random rand = new Random();
        private Loot loot;
        private String currentTooltip;
        public LootBag2()
        {
            bag.Add(ItemID.LifeCrystal, 2, 3, Amounts.uncommon)
            .Add(ItemID.UnholyArrow, 100, 200, Amounts.common)
            .Add(ItemID.JestersArrow, 100, 200, Amounts.uncommon)
            .Add(ItemID.DemoniteBar, 8, 12, Amounts.uncommon)
            .Add(ItemID.Vilethorn, Amounts.uncommon)
            .Add(ItemID.Starfury, Amounts.uncommon)
            .Add(ItemID.GoldCoin, 5, 10, Amounts.rare)
            .Add(ItemID.PlatinumCoin, Amounts.veryRare)
            .Add(ItemID.FallenStar, 15, 25, Amounts.common)
            .Add(ItemID.Musket, Amounts.uncommon)
            .Add(ItemID.MusketBall, 100, 200, Amounts.common)
            .Add(ItemID.BandofStarpower, Amounts.uncommon)
            .Add(ItemID.FlowerofFire, Amounts.rare)
            .Add(ItemID.MagicMissile, Amounts.rare)
            .Add(ItemID.ShadowOrb, Amounts.uncommon)
            .Add(ItemID.MeteoriteBar, 8, 12, Amounts.common)
            .Add(ItemID.Bone, 10, 25, Amounts.common)
            .Add(ItemID.Muramasa, Amounts.rare)
            .Add(ItemID.CobaltShield, Amounts.rare)
            .Add(ItemID.AquaScepter, Amounts.rare)
            .Add(ItemID.LuckyHorseshoe, Amounts.uncommon)
            .Add(ItemID.ShinyRedBalloon, Amounts.uncommon)
            .Add(ItemID.Harpoon, Amounts.uncommon)
            .Add(ItemID.BallOHurt, Amounts.uncommon)
            .Add(ItemID.BlueMoon, Amounts.rare)
            .Add(ItemID.Handgun, Amounts.rare)
            .Add(ItemID.WaterBolt, Amounts.rare)
            .Add(ItemID.AshBlock, 25, 100, Amounts.common)
            .Add(ItemID.Obsidian, 15, 25, Amounts.common)
            .Add(ItemID.HellstoneBar, 8, 12, Amounts.common)
            .Add(ItemID.HealingPotion, 3, 5, Amounts.common)
            .Add(ItemID.ManaPotion, 3, 5, Amounts.common)
            .Add(ItemID.Stinger, 3, 5, Amounts.common)
            .Add(ItemID.Vine, 1, 3, Amounts.uncommon)
            .Add(ItemID.FeralClaws, Amounts.rare)
            .Add(ItemID.AnkletoftheWind, Amounts.rare)
            .Add(ItemID.StaffofRegrowth, Amounts.rare)
            .Add(ItemID.Flamelash, Amounts.rare)
            .Add(ItemID.Sunfury, Amounts.rare)
            .Add(ItemID.NaturesGift, Amounts.rare)
            .Add(ItemID.RestorationPotion, 3, 5, Amounts.common)
            .Add(ItemID.MeteorShot, 100, 200, Amounts.uncommon)
            .Add(ItemID.HellfireArrow, 100, 200, Amounts.rare)
            .Add(ItemID.GuideVoodooDoll, Amounts.rare)
            .Add(ItemID.DemonScythe, Amounts.veryRare)
            .Add(ItemID.DarkLance, Amounts.rare)
            .Add(ItemID.SilverBullet, 100, 200, Amounts.uncommon)
            .Add(ItemID.ObsidianSkinPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.GravitationPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.Fireblossom, 3, 5, Amounts.common)
            .Add(ItemID.Feather, 3, 5, Amounts.common)
            .Add(ItemID.GoldenKey, 1, 2, Amounts.uncommon)
            .Add(ItemID.ShadowKey, Amounts.rare)
            .Add(ItemID.JungleSpores, 3, 5, Amounts.uncommon)
            .Add(ItemID.RichMahogany, 25, 100, Amounts.common)
            .Add(ItemID.RedPotion, Amounts.veryRare)
            .Add(ItemID.Marrow, Amounts.rare)
            .Add(ItemID.Cloud, 25, 100, Amounts.common)
            .Add(ItemID.Seaweed, Amounts.rare)
            .Add(ItemID.TheUndertaker, Amounts.uncommon)
            .Add(ItemID.TheMeatball, Amounts.uncommon)
            .Add(ItemID.TheRottedFork, Amounts.uncommon)
            .Add(ItemID.Bezoar, Amounts.rare)
            .Add(ItemID.Megaphone, Amounts.rare)
            .Add(ItemID.Nazar, Amounts.rare)
            .Add(ItemID.BoneWand, Amounts.rare)
            .Add(ItemID.Boomstick, Amounts.rare)
            .Add(ItemID.Abeemination, Amounts.rare)
            .Add(ItemID.BottledHoney, 3, 7, Amounts.common)
            .Add(ItemID.CrimsonRod, Amounts.uncommon)
            .Add(ItemID.CrimtaneBar, 8, 12, Amounts.uncommon)
            .Add(ItemID.PanicNecklace, Amounts.uncommon)
            .Add(ItemID.ClothierVoodooDoll, Amounts.rare)
            .Add(ItemID.KOCannon, Amounts.rare)
            .Add(ItemID.PirateMap, Amounts.rare)
            .Add(ItemID.MagmaStone, Amounts.rare)
            .Add(ItemID.ObsidianRose, Amounts.rare)
            .Add(ItemID.HeartLantern, 2, 5, Amounts.uncommon)
            .Add(ItemID.CelestialMagnet, Amounts.uncommon)
            .Add(ItemID.Revolver, Amounts.uncommon)
            .Add(ItemID.TitanPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.AmmoReservationPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.EndurancePotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.RagePotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.InfernoPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.WrathPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.TeleportationPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.StinkPotion, 3, 5, Amounts.veryRare)
            .Add(ItemID.FishingPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.SonarPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.CratePotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.AnglerHat, Amounts.rare)
            .Add(ItemID.AnglerVest, Amounts.rare)
            .Add(ItemID.AnglerPants, Amounts.rare)
            .Add(ItemID.HighTestFishingLine, Amounts.rare)
            .Add(ItemID.AnglerEarring, Amounts.rare)
            .Add(ItemID.TackleBox, Amounts.rare)
            .Add(ItemID.JourneymanBait, 3, 5, Amounts.common)
            .Add(ItemID.GenderChangePotion, Amounts.veryRare)
            .Add(ItemID.BewitchingTable, Amounts.rare)
            .Add(ItemID.AlchemyTable, Amounts.rare)
            .Add(ItemID.FlowerBoots, Amounts.uncommon)
            .Add(ItemID.HellwingBow, Amounts.rare)
            .Add(ItemID.BottomlessBucket, Amounts.rare)
            .Add(ItemID.SuperAbsorbantSponge, Amounts.rare)
            .Add(ItemID.FishFinder, Amounts.rare)
            .Add(ItemID.WeatherRadio, Amounts.rare)
            .Add(ItemID.CrimsonHeart, Amounts.uncommon)
            .Add(ItemID.TallyCounter, Amounts.rare)
            .Add(ItemID.Sextant, Amounts.rare)
            .Add(ItemID.Stopwatch, Amounts.uncommon)
            .Add(ItemID.MetalDetector, Amounts.uncommon)
            .Add(ItemID.LifeformAnalyzer, Amounts.uncommon)
            .Add(ItemID.DPSMeter, Amounts.uncommon)
            .Add(ItemID.FishermansGuide, Amounts.rare)
            .Add(ItemID.SharpeningStation, Amounts.rare)
            .Add(ItemID.VampireFrogStaff, Amounts.uncommon)
            .Add(ItemID.BloodFishingRod, Amounts.rare)
            .Add(ItemID.ZapinatorGray, Amounts.rare)
            .Add(ItemID.BloodRainBow, Amounts.uncommon)
            .Add(ItemID.CombatBook, Amounts.rare)
            .Add(ItemID.LuckPotion, 3, 5, Amounts.uncommon)
            .Add(ItemID.GardenGnome, 1, 2, Amounts.rare)
            .Add(ItemID.DemonConch, Amounts.rare)
            .Add(ItemID.BottomlessLavaBucket, Amounts.rare)
            .Add(ItemID.FlameWakerBoots, Amounts.rare)
            .Add(ItemID.SuperheatedBlood, Amounts.rare)
            .Add(ItemID.LavaAbsorbantSponge, Amounts.rare)
            .Add(ItemID.CreativeWings, Amounts.uncommon)
            .Add(ItemID.TreasureMagnet, Amounts.rare)
            .Add(ItemID.BottomlessHoneyBucket, Amounts.rare)
            .Add(ItemID.HoneyAbsorbantSponge, Amounts.rare);

            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Loot Bag : Tier 2");
            // Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
            ItemID.Sets.ShimmerTransformToItem[Type] = ModContent.ItemType<LootBag1>();
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 30;
            Item.rare = ItemRarityID.Green;
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