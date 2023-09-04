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
            bag.Add(ItemID.IronPickaxe, Amounts.uncommon)
                .Add(ItemID.DirtBlock, 25, 100, Amounts.common)
                .Add(ItemID.StoneBlock, 25, 100, Amounts.common)
                .Add(ItemID.IronBroadsword, Amounts.uncommon)
                .Add(ItemID.Mushroom, 7, 10, Amounts.common)
                .Add(ItemID.IronHammer, Amounts.uncommon)
                .Add(ItemID.Torch, 50, 100, Amounts.common)
                .Add(ItemID.Wood, 25, 100, Amounts.common)
                .Add(ItemID.IronAxe, Amounts.uncommon)
                .Add(ItemID.GoldWatch, Amounts.rare)
                .Add(ItemID.DepthMeter, Amounts.rare)
                .Add(ItemID.GoldBar, 8, 12, Amounts.uncommon)
                .Add(ItemID.CopperBar, 8, 12, Amounts.common)
                .Add(ItemID.SilverBar, 8, 12, Amounts.uncommon)
                .Add(ItemID.IronBar, 8, 12, Amounts.common)
                .Add(ItemID.Gel, 10, 15, Amounts.common)
                .Add(ItemID.LesserHealingPotion, 3, 5, Amounts.common)
                .Add(ItemID.LifeCrystal, Amounts.veryRare)
                .Add(ItemID.Lens, 1, 2, Amounts.uncommon)
                .Add(ItemID.WoodenArrow, 100, 200, Amounts.common)
                .Add(ItemID.FlamingArrow, 100, 200, Amounts.uncommon)
                .Add(ItemID.Shuriken, 100, 200, Amounts.common)
                .Add(ItemID.SuspiciousLookingEye, Amounts.rare)
                .Add(ItemID.Chest, 1, 3, Amounts.uncommon)
                .Add(ItemID.BandofRegeneration, Amounts.uncommon)
                .Add(ItemID.MagicMirror, Amounts.uncommon)
                .Add(ItemID.JestersArrow, 100, 200, Amounts.rare)
                .Add(ItemID.AngelStatue, Amounts.veryRare)
                .Add(ItemID.CloudinaBottle, Amounts.uncommon)
                .Add(ItemID.HermesBoots, Amounts.uncommon)
                .Add(ItemID.VileMushroom, 3, 5, Amounts.uncommon)
                .Add(ItemID.Sunflower, 2, 3, Amounts.common)
                .Add(ItemID.PurificationPowder, 20, 30, Amounts.uncommon)
                .Add(ItemID.VilePowder, 20, 30, Amounts.uncommon)
                .Add(ItemID.RottenChunk, 3, 5, Amounts.uncommon)
                .Add(ItemID.WormTooth, 3, 8, Amounts.rare)
                .Add(ItemID.WormFood, Amounts.rare)
                .Add(ItemID.CopperCoin, 50, 99, Amounts.common)
                .Add(ItemID.SilverCoin, 50, 99, Amounts.uncommon)
                .Add(ItemID.GoldCoin, 1, 10, Amounts.rare)
                .Add(ItemID.FallenStar, 2, 5, Amounts.common)
                .Add(ItemID.GrapplingHook, Amounts.uncommon)
                .Add(ItemID.PiggyBank, Amounts.veryRare)
                .Add(ItemID.MiningHelmet, Amounts.rare)
                .Add(ItemID.IronBow, Amounts.uncommon)
                .Add(ItemID.ManaCrystal, 1, 2, Amounts.rare)
                .Add(ItemID.LesserManaPotion, 3, 5, Amounts.common)
                .Add(ItemID.Hook, Amounts.uncommon)
                .Add(ItemID.Cobweb, 20, 50, Amounts.common)
                .Add(ItemID.Bomb, 10, 15, Amounts.common)
                .Add(ItemID.Dynamite, 5, 10, Amounts.uncommon)
                .Add(ItemID.Grenade, 15, 30, Amounts.common)
                .Add(ItemID.SandBlock, 25, 100, Amounts.common)
                .Add(ItemID.MudBlock, 25, 100, Amounts.common)
                .Add(ItemID.Sapphire, 5, 7, Amounts.uncommon)
                .Add(ItemID.Ruby, 5, 7, Amounts.rare)
                .Add(ItemID.Emerald, 5, 7, Amounts.uncommon)
                .Add(ItemID.Topaz, 5, 7, Amounts.common)
                .Add(ItemID.Amethyst, 5, 7, Amounts.common)
                .Add(ItemID.Diamond, 5, 7, Amounts.rare)
                .Add(ItemID.GlowingMushroom, 7, 10, Amounts.uncommon)
                .Add(ItemID.BreathingReed, Amounts.uncommon)
                .Add(ItemID.Flipper, Amounts.uncommon)
                .Add(ItemID.HealingPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.ManaPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.WhoopieCushion, Amounts.rare)
                .Add(ItemID.Shackle, Amounts.rare)
                .Add(ItemID.Silk, 5, 10, Amounts.common)
                .Add(ItemID.RestorationPotion, 3, 5, Amounts.rare)
                .Add(ItemID.BlackLens, Amounts.veryRare)
                .Add(ItemID.GoldCrown, Amounts.rare)
                .Add(ItemID.DivingHelmet, Amounts.rare)
                .Add(ItemID.Coral, 3, 5, Amounts.uncommon)
                .Add(ItemID.Cactus, 20, 30, Amounts.common)
                .Add(ItemID.Trident, Amounts.uncommon)
                .Add(ItemID.ThrowingKnife, 100, 200, Amounts.uncommon)
                .Add(ItemID.Spear, Amounts.uncommon)
                .Add(ItemID.Blowpipe, Amounts.uncommon)
                .Add(ItemID.Glowstick, 50, 75, Amounts.common)
                .Add(ItemID.WoodenBoomerang, Amounts.uncommon)
                .Add(ItemID.Aglet, Amounts.uncommon)
                .Add(ItemID.RegenerationPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.SwiftnessPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.GillsPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.IronskinPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.ManaRegenerationPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.MagicPowerPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.FeatherfallPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.SpelunkerPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.InvisibilityPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.ShinePotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.NightOwlPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.BattlePotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.ThornsPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.WaterWalkingPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.ArcheryPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.HunterPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.GoldChest, 1, 3, Amounts.rare)
                .Add(ItemID.Daybloom, 3, 5, Amounts.common)
                .Add(ItemID.Moonglow, 3, 5, Amounts.common)
                .Add(ItemID.Blinkroot, 3, 5, Amounts.common)
                .Add(ItemID.Deathweed, 3, 5, Amounts.common)
                .Add(ItemID.Waterleaf, 3, 5, Amounts.common)
                .Add(ItemID.SharkFin, 1, 2, Amounts.common)
                .Add(ItemID.AntlionMandible, 2, 3, Amounts.common)
                .Add(ItemID.Toilet, Amounts.veryRare)
                .Add(ItemID.TatteredCloth, 3, 5, Amounts.uncommon)
                .Add(ItemID.GoblinBattleStandard, Amounts.rare)
                .Add(ItemID.Compass, Amounts.rare)
                .Add(ItemID.MiningShirt, Amounts.rare)
                .Add(ItemID.MiningPants, Amounts.rare)
                .Add(ItemID.SiltBlock, 50, 100, Amounts.uncommon)
                .Add(ItemID.SlimeCrown, Amounts.rare)
                .Add(ItemID.Ebonwood, 25, 100, Amounts.common)
                .Add(ItemID.Fish, Amounts.uncommon)
                .Add(ItemID.IceBoomerang, Amounts.uncommon)
                .Add(ItemID.TinBar, 8, 12, Amounts.common)
                .Add(ItemID.LeadBar, 8, 12, Amounts.common)
                .Add(ItemID.TungstenBar, 8, 12, Amounts.uncommon)
                .Add(ItemID.PlatinumBar, 8, 12, Amounts.uncommon)
                .Add(ItemID.PlatinumWatch, Amounts.rare)
                .Add(ItemID.IceBlade, Amounts.uncommon)
                .Add(ItemID.AsphaltBlock, 25, 100, Amounts.veryRare)
                .Add(ItemID.SandstorminaBottle, Amounts.rare)
                .Add(ItemID.WaterWalkingBoots, Amounts.uncommon)
                .Add(ItemID.VikingHelmet, Amounts.rare)
                .Add(ItemID.LavaCharm, Amounts.rare)
                .Add(ItemID.FlareGun, Amounts.uncommon)
                .Add(ItemID.LeafWand, Amounts.uncommon)
                .Add(ItemID.FlyingCarpet, Amounts.rare)
                .Add(ItemID.WebSlinger, Amounts.veryRare)
                .Add(ItemID.Umbrella, Amounts.uncommon)
                .Add(ItemID.IceSkates, Amounts.uncommon)
                .Add(ItemID.ClimbingClaws, Amounts.uncommon)
                .Add(ItemID.Rope, 25, 100, Amounts.common)
                .Add(ItemID.ShoeSpikes, Amounts.uncommon)
                .Add(ItemID.BlizzardinaBottle, Amounts.uncommon)
                .Add(ItemID.FrostburnArrow, 100, 200, Amounts.uncommon)
                .Add(ItemID.EnchantedSword, Amounts.rare)
                .Add(ItemID.Extractinator, Amounts.uncommon)
                .Add(ItemID.Amber, 5, 7, Amounts.rare)
                .Add(ItemID.BoneSword, Amounts.uncommon)
                .Add(ItemID.JellyfishNecklace, Amounts.uncommon)
                .Add(ItemID.SnowballCannon, Amounts.uncommon)
                .Add(ItemID.BonePickaxe, Amounts.rare)
                .Add(ItemID.ChainKnife, Amounts.rare)
                .Add(ItemID.Vertebrae, 3, 5, Amounts.uncommon)
                .Add(ItemID.BloodySpine, Amounts.rare)
                .Add(ItemID.FlurryBoots, Amounts.uncommon)
                .Add(ItemID.Pumpkin, 15, 25, Amounts.common)
                .Add(ItemID.Duck, Amounts.veryRare)
                .Add(ItemID.BrickLayer, Amounts.rare)
                .Add(ItemID.ExtendoGrip, Amounts.rare)
                .Add(ItemID.PaintSprayer, Amounts.rare)
                .Add(ItemID.PortableCementMixer, Amounts.rare)
                .Add(ItemID.Katana, Amounts.uncommon)
                .Add(ItemID.Bass, 3, 5, Amounts.common)
                .Add(ItemID.MiningPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.HeartreachPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.CalmingPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.BuilderPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.FlipperPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.SummoningPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.TrapsightPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.RecallPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.Shiverthorn, 3, 5, Amounts.common)
                .Add(ItemID.WarmthPotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.FrogLeg, Amounts.rare)
                .Add(ItemID.Seashell, 3, 5, Amounts.uncommon)
                .Add(ItemID.Starfish, 3, 5, Amounts.uncommon)
                .Add(ItemID.ApprenticeBait, 3, 5, Amounts.common)
                .Add(ItemID.ViciousPowder, 20, 30, Amounts.uncommon)
                .Add(ItemID.ViciousMushroom, 3, 5, Amounts.uncommon)
                .Add(ItemID.WormholePotion, 3, 5, Amounts.uncommon)
                .Add(ItemID.CordageGuide, Amounts.uncommon)
                .Add(ItemID.WandofSparking, Amounts.uncommon)
                .Add(ItemID.Radar, Amounts.uncommon)
                .Add(ItemID.NightVisionHelmet, Amounts.rare)
                .Add(ItemID.PinkGel, 25, 50, Amounts.rare)
                .Add(ItemID.FrostDaggerfish, 100, 200, Amounts.uncommon)
                .Add(ItemID.IceMirror, Amounts.uncommon)
                .Add(ItemID.SailfishBoots, Amounts.uncommon)
                .Add(ItemID.TsunamiInABottle, Amounts.rare)
                .Add(ItemID.SharkToothNecklace, Amounts.rare)
                .Add(ItemID.MoneyTrough, Amounts.veryRare)
                .Add(ItemID.BalloonPufferfish, Amounts.rare)
                .Add(ItemID.FossilOre, 8, 12, Amounts.uncommon)
                .Add(ItemID.LeadBow, Amounts.uncommon)
                .Add(ItemID.PlatinumPickaxe, Amounts.rare)
                .Add(ItemID.LeadHammer, Amounts.uncommon)
                .Add(ItemID.LeadAxe, Amounts.uncommon)
                .Add(ItemID.LeadPickaxe, Amounts.uncommon)
                .Add(ItemID.GoldPickaxe, Amounts.rare)
                .Add(ItemID.AntlionClaw, Amounts.rare)
                .Add(ItemID.SandBoots, Amounts.uncommon)
                .Add(ItemID.AncientChisel, Amounts.uncommon)
                .Add(ItemID.CarbonGuitar, Amounts.veryRare)
                .Add(ItemID.ThunderSpear, Amounts.uncommon)
                .Add(ItemID.ThunderStaff, Amounts.uncommon)
                .Add(ItemID.Terragrim, Amounts.veryRare)
                .Add(ItemID.MysticCoilSnake, Amounts.uncommon)
                .Add(ItemID.MagicConch, Amounts.uncommon)
                .Add(ItemID.BloodMoonStarter, Amounts.rare)
                .Add(ItemID.CatBast, Amounts.uncommon)
                .Add(ItemID.BabyBirdStaff, Amounts.uncommon)
                .Add(ItemID.PortableStool, Amounts.uncommon)
                .Add(ItemID.EncumberingStone, Amounts.uncommon)
                .Add(ItemID.WhitePearl, Amounts.uncommon)
                .Add(ItemID.BlackPearl, Amounts.rare)
                .Add(ItemID.PinkPearl, Amounts.veryRare)
                .Add(ItemID.ScarabBomb, 10, 15, Amounts.uncommon)
                .Add(ItemID.SandcastleBucket, Amounts.uncommon)
                .Add(ItemID.Gladius, Amounts.rare)
                .Add(ItemID.LuckPotionLesser, 3, 5, Amounts.uncommon)
                .Add(ItemID.ChumBucket, 7, 10, Amounts.uncommon)
                .Add(ItemID.Shroomerang, Amounts.uncommon)
                .Add(ItemID.Mace, Amounts.uncommon)
                .Add(ItemID.FlinxFur, 3, 5, Amounts.common)
                .Add(ItemID.PoopBlock, 100, 200, Amounts.veryRare);


            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Loot Bag : Tier 1");
            // Tooltip.SetDefault("Right click to open");
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