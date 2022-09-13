using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class LootBag1 : ModItem
    {
        Bag bag = new Bag();
        private Random rand = new Random();
        private Loot loot;
        private String currentTooltip;
        public LootBag1()
        {
            // bag.AddItem(ItemID., Amounts.);
            // Basic Surface/Underground Resources
            bag.AddItem(ItemID.Wood, 25, 100, Amounts.common);
            bag.AddItem(ItemID.StoneBlock, 25, 100, Amounts.common);
            bag.AddItem(ItemID.Gel, 5, 20, Amounts.common);
            bag.AddItem(ItemID.Torch, 10, 30, Amounts.common);
            bag.AddItem(ItemID.Grenade, 5, 10, Amounts.common);
            bag.AddItem(ItemID.Bomb, 10, 15, Amounts.uncommon);
            bag.AddItem(ItemID.Dynamite, 1, 3, Amounts.rare);
            bag.AddItem(ItemID.Rope, 50, 100, Amounts.common);
            bag.AddItem(ItemID.WoodenArrow, 20, 50, Amounts.common);
            bag.AddItem(ItemID.FlamingArrow, 20, 40, Amounts.uncommon);
            bag.AddItem(ItemID.Shuriken, 100, 200, Amounts.common);
            bag.AddItem(ItemID.LesserHealingPotion, 5, 7, Amounts.common);
            bag.AddItem(ItemID.HealingPotion, 3, 5, Amounts.rare);
            bag.AddItem(ItemID.SlimeCrown, Amounts.uncommon);
            bag.AddItem(ItemID.SuspiciousLookingEye, Amounts.rare);
            bag.AddItem(ItemID.WormFood, Amounts.rare);
            bag.AddItem(ItemID.BloodySpine, Amounts.rare);
            bag.AddItem(ItemID.ZombieArm, Amounts.uncommon);
            bag.AddItem(ItemID.SlimeStaff, Amounts.rare);
            bag.AddItem(ItemID.Lens, 2, 5, Amounts.common);
            bag.AddItem(ItemID.BlackLens, 1, 2, Amounts.rare);
            bag.AddItem(ItemID.PinkGel, 25, 50, Amounts.rare);
            bag.AddItem(ItemID.Sunflower, 1, 3, Amounts.common);
            bag.AddItem(ItemID.DPSMeter, Amounts.uncommon);
            bag.AddItem(ItemID.Stopwatch, Amounts.uncommon);
            bag.AddItem(ItemID.LifeformAnalyzer, Amounts.uncommon);
            // Living Tree
            bag.AddItem(ItemID.LeafWand, Amounts.uncommon);
            bag.AddItem(ItemID.LivingWoodWand, Amounts.uncommon);
            bag.AddItem(ItemID.LivingLoom, Amounts.uncommon);
            bag.AddItem(ItemID.BabyBirdStaff, Amounts.uncommon);
            bag.AddItem(ItemID.GardenGnome, Amounts.rare);
            // Surface CHest
            bag.AddItem(ItemID.Spear, Amounts.uncommon);
            bag.AddItem(ItemID.Blowpipe, Amounts.uncommon);
            bag.AddItem(ItemID.WoodenBoomerang, Amounts.uncommon);
            bag.AddItem(ItemID.Glowstick, 30, 40, Amounts.uncommon);
            bag.AddItem(ItemID.ThrowingKnife, 100, 200, Amounts.uncommon);
            bag.AddItem(ItemID.Aglet, Amounts.uncommon);
            bag.AddItem(ItemID.ClimbingClaws, Amounts.uncommon);
            bag.AddItem(ItemID.Umbrella, Amounts.uncommon);
            bag.AddItem(ItemID.CordageGuide, Amounts.uncommon);
            bag.AddItem(ItemID.WandofSparking, Amounts.uncommon);
            bag.AddItem(ItemID.Radar, Amounts.uncommon);
            bag.AddItem(ItemID.PortableStool, Amounts.uncommon);
            bag.AddItem(ItemID.HerbBag, 1, 3, Amounts.uncommon);
            bag.AddItem(ItemID.CanOfWorms, 1, 3, Amounts.uncommon);
            // Underground
            bag.AddItem(ItemID.BandofRegeneration, Amounts.uncommon);
            bag.AddItem(ItemID.MagicMirror, Amounts.uncommon);
            bag.AddItem(ItemID.CloudinaBottle, Amounts.uncommon);
            bag.AddItem(ItemID.HermesBoots, Amounts.uncommon);
            bag.AddItem(ItemID.Mace, Amounts.uncommon);
            bag.AddItem(ItemID.EnchantedBoomerang, Amounts.uncommon);
            bag.AddItem(ItemID.ShoeSpikes, Amounts.uncommon);
            bag.AddItem(ItemID.FlareGun, Amounts.uncommon);
            bag.AddItem(ItemID.Extractinator, Amounts.uncommon);
            bag.AddItem(ItemID.LavaCharm, Amounts.rare);
            bag.AddItem(ItemID.LuckyHorseshoe, Amounts.rare);
            bag.AddItem(ItemID.AngelStatue, Amounts.common);
            bag.AddItem(ItemID.JestersArrow, 30, 50, Amounts.rare);
            bag.AddItem(ItemID.CopperBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.TinBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.IronBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            bag.AddItem(ItemID.LeadBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            bag.AddItem(ItemID.SilverBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            bag.AddItem(ItemID.TungstenBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            bag.AddItem(ItemID.GoldBar, Amounts.barMin, Amounts.barMax, Amounts.rare);
            bag.AddItem(ItemID.PlatinumBar, Amounts.barMin, Amounts.barMax, Amounts.rare);
            bag.AddItem(ItemID.Amethyst, Amounts.gemMin, Amounts.gemMax, Amounts.common);
            bag.AddItem(ItemID.Topaz, Amounts.gemMin, Amounts.gemMax, Amounts.common);
            bag.AddItem(ItemID.Sapphire, Amounts.gemMin, Amounts.gemMax, Amounts.uncommon);
            bag.AddItem(ItemID.Emerald, Amounts.gemMin, Amounts.gemMax, Amounts.uncommon);
            bag.AddItem(ItemID.Ruby, Amounts.gemMin, Amounts.gemMax, Amounts.rare);
            bag.AddItem(ItemID.Diamond, Amounts.gemMin, Amounts.gemMax, Amounts.rare);
            bag.AddItem(ItemID.Emerald, Amounts.gemMin, Amounts.gemMax, Amounts.rare);
            bag.AddItem(ItemID.Cobweb, 50, 100, Amounts.common);
            bag.AddItem(ItemID.EnchantedSword, Amounts.uncommon);
            bag.AddItem(ItemID.Terragrim, Amounts.veryRare);
            bag.AddItem(ItemID.ChainKnife, Amounts.uncommon);
            bag.AddItem(ItemID.BonePickaxe, Amounts.rare);
            bag.AddItem(ItemID.MiningHelmet, Amounts.rare);
            bag.AddItem(ItemID.Shackle, Amounts.uncommon);
            bag.AddItem(ItemID.LifeCrystal, Amounts.uncommon);
            bag.AddItem(ItemID.DepthMeter, Amounts.uncommon);
            bag.AddItem(ItemID.Compass, Amounts.uncommon);
            bag.AddItem(ItemID.MetalDetector, Amounts.uncommon);
            // Ocean
            bag.AddItem(ItemID.BreathingReed, Amounts.uncommon);
            bag.AddItem(ItemID.Flipper, Amounts.uncommon);
            bag.AddItem(ItemID.Trident, Amounts.uncommon);
            bag.AddItem(ItemID.FloatingTube, Amounts.uncommon);
            bag.AddItem(ItemID.SharkBait, Amounts.uncommon);
            bag.AddItem(ItemID.WaterWalkingBoots, Amounts.uncommon);
            bag.AddItem(ItemID.BeachBall, Amounts.uncommon);
            bag.AddItem(ItemID.SandcastleBucket, Amounts.uncommon);
            bag.AddItem(ItemID.JellyfishNecklace, Amounts.uncommon);
            bag.AddItem(ItemID.DivingHelmet, Amounts.uncommon);
            // Desert
            bag.AddItem(ItemID.AncientChisel, Amounts.uncommon);
            bag.AddItem(ItemID.SandBoots, Amounts.uncommon);
            bag.AddItem(ItemID.ThunderSpear, Amounts.uncommon);
            bag.AddItem(ItemID.ThunderStaff, Amounts.uncommon);
            bag.AddItem(ItemID.MagicConch, Amounts.uncommon);
            bag.AddItem(ItemID.EncumberingStone, Amounts.uncommon);
            bag.AddItem(ItemID.CatBast, Amounts.uncommon);
            bag.AddItem(ItemID.MysticCoilSnake, Amounts.uncommon);
            bag.AddItem(ItemID.DesertMinecart, Amounts.uncommon);
            bag.AddItem(ItemID.AntlionMandible, 2, 5, Amounts.common);
            bag.AddItem(ItemID.AntlionClaw, Amounts.uncommon);
            bag.AddItem(ItemID.FossilOre, 7, 10, Amounts.common);
            // Ice
            bag.AddItem(ItemID.IceBoomerang, Amounts.uncommon);
            bag.AddItem(ItemID.IceBlade, Amounts.uncommon);
            bag.AddItem(ItemID.IceSkates, Amounts.uncommon);
            bag.AddItem(ItemID.SnowballCannon, Amounts.uncommon);
            bag.AddItem(ItemID.BlizzardinaBottle, Amounts.uncommon);
            bag.AddItem(ItemID.FlurryBoots, Amounts.uncommon);
            bag.AddItem(ItemID.IceMirror, Amounts.uncommon);
            bag.AddItem(ItemID.Fish, Amounts.uncommon);
            bag.AddItem(ItemID.IceMachine, Amounts.uncommon);
            bag.AddItem(ItemID.SnowballLauncher, Amounts.rare);
            bag.AddItem(ItemID.FlinxFur, 3, 5, Amounts.common);
            // Corruption and Crimson
            bag.AddItem(ItemID.RottenChunk, 5, 7, Amounts.common);
            bag.AddItem(ItemID.Vertebrae, 5, 7, Amounts.common);
            bag.AddItem(ItemID.WormTooth, 5, 10, Amounts.uncommon);
            bag.AddItem(ItemID.Musket, Amounts.rare);
            bag.AddItem(ItemID.ShadowOrb, Amounts.rare);
            bag.AddItem(ItemID.Vilethorn, Amounts.rare);
            bag.AddItem(ItemID.BallOHurt, Amounts.rare);
            bag.AddItem(ItemID.BandofStarpower, Amounts.rare);
            bag.AddItem(ItemID.TheUndertaker, Amounts.rare);
            bag.AddItem(ItemID.CrimsonHeart, Amounts.rare);
            bag.AddItem(ItemID.PanicNecklace, Amounts.rare);
            bag.AddItem(ItemID.CrimsonRod, Amounts.rare);
            bag.AddItem(ItemID.TheRottedFork, Amounts.rare);
            // Blood Moon
            bag.AddItem(ItemID.BloodRainBow, Amounts.rare);
            bag.AddItem(ItemID.VampireFrogStaff, Amounts.rare);
            bag.AddItem(ItemID.BloodFishingRod, Amounts.rare);
            bag.AddItem(ItemID.MoneyTrough, Amounts.uncommon);
            bag.AddItem(ItemID.SharkToothNecklace, Amounts.uncommon);
            bag.AddItem(ItemID.CombatBook, Amounts.rare);
            bag.AddItem(ItemID.ChumBucket, 3, 5, Amounts.uncommon);
            bag.AddItem(ItemID.BloodMoonStarter, Amounts.uncommon);
            // Fishing
            bag.AddItem(ItemID.FishermansGuide, Amounts.uncommon);
            bag.AddItem(ItemID.WeatherRadio, Amounts.uncommon);
            bag.AddItem(ItemID.Sextant, Amounts.uncommon);
            bag.AddItem(ItemID.FrogLeg, Amounts.rare);
            bag.AddItem(ItemID.BalloonPufferfish, Amounts.rare);
            bag.AddItem(ItemID.PurpleClubberfish, Amounts.rare);
            bag.AddItem(ItemID.ReaverShark, Amounts.rare);
            bag.AddItem(ItemID.SawtoothShark, Amounts.rare);
            bag.AddItem(ItemID.FrostDaggerfish, 25, 75, Amounts.uncommon);
            bag.AddItem(ItemID.Swordfish, Amounts.uncommon);
            bag.AddItem(ItemID.SailfishBoots, Amounts.uncommon);
            bag.AddItem(ItemID.TsunamiInABottle, Amounts.rare);
            bag.AddItem(ItemID.FalconBlade, Amounts.uncommon);
            bag.AddItem(ItemID.HardySaddle, Amounts.rare);
            // Potions
            bag.AddItem(ItemID.ArcheryPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.BattlePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.TrapsightPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.EndurancePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.FlipperPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.GillsPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.HeartreachPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.HunterPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.IronskinPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.LuckPotionLesser, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.MiningPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.NightOwlPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.RagePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.RegenerationPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.ShinePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.SonarPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.StinkPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.SwiftnessPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.WarmthPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.WaterWalkingPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.WrathPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.RecallPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.WormholePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.Apple, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Apricot, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Banana, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.BlackCurrant, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.BloodOrange, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Cherry, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Coconut, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Elderberry, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Grapefruit, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Lemon, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Mango, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Peach, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Pineapple, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Plum, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Rambutan, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.BananaSplit, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.Burger, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.MilkCarton, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.Fries, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.IceCream, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.PotatoChips, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.ShrimpPoBoy, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.Spaghetti, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.Steak, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.Pizza, Amounts.potionMin, Amounts.potionMax, Amounts.veryRare);
            // Traveling Merchant
            bag.AddItem(ItemID.ZebraSkin, Amounts.common);
            bag.AddItem(ItemID.LeopardSkin, Amounts.common);
            bag.AddItem(ItemID.TigerSkin, Amounts.common);
            bag.AddItem(ItemID.Katana, Amounts.uncommon);
            bag.AddItem(ItemID.ActuationAccessory, Amounts.uncommon);
            bag.AddItem(ItemID.PortableCementMixer, Amounts.uncommon);
            bag.AddItem(ItemID.PaintSprayer, Amounts.uncommon);
            bag.AddItem(ItemID.ExtendoGrip, Amounts.uncommon);
            bag.AddItem(ItemID.BrickLayer, Amounts.uncommon);
            bag.AddItem(ItemID.Gi, Amounts.rare);
            bag.AddItem(ItemID.MagicHat, Amounts.rare);
            bag.AddItem(ItemID.GypsyRobe, Amounts.rare);
            bag.AddItem(ItemID.AmmoBox, Amounts.rare);
            bag.AddItem(ItemID.CelestialMagnet, Amounts.veryRare);
            bag.AddItem(ItemID.WaterGun, Amounts.veryRare);


            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Loot Bag : Tier 1");
            Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 30;
            Item.rare = ItemRarityID.White;
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
                .AddIngredient(ModContent.ItemType<LootBag2>(), 1)
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