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
            // bag.AddItem(ItemID., Amounts.);
            // Basic Resources
            bag.AddItem(ItemID.HealingPotion, 3, 5, Amounts.common);
            bag.AddItem(ItemID.DemoniteBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.CrimtaneBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.MeteoriteBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.HellstoneBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            // Dungeon
            bag.AddItem(ItemID.Handgun, Amounts.uncommon);
            bag.AddItem(ItemID.AquaScepter, Amounts.uncommon);
            bag.AddItem(ItemID.MagicMissile, Amounts.uncommon);
            bag.AddItem(ItemID.BlueMoon, Amounts.uncommon);
            bag.AddItem(ItemID.CobaltShield, Amounts.uncommon);
            bag.AddItem(ItemID.Muramasa, Amounts.uncommon);
            bag.AddItem(ItemID.ShadowKey, Amounts.uncommon);
            bag.AddItem(ItemID.Valor, Amounts.uncommon);
            bag.AddItem(ItemID.BoneWelder, Amounts.uncommon);
            bag.AddItem(ItemID.GoldenKey, 1, 2, Amounts.common);
            bag.AddItem(ItemID.Bone, 5, 10, Amounts.common);
            bag.AddItem(ItemID.BoneWand, Amounts.rare);
            bag.AddItem(ItemID.ClothierVoodooDoll, Amounts.rare);
            bag.AddItem(ItemID.WaterBolt, Amounts.uncommon);
            bag.AddItem(ItemID.AlchemyTable, Amounts.uncommon);
            bag.AddItem(ItemID.BewitchingTable, Amounts.uncommon);
            bag.AddItem(ItemID.TallyCounter, Amounts.uncommon);
            // Jungle
            bag.AddItem(ItemID.AnkletoftheWind, Amounts.uncommon);
            bag.AddItem(ItemID.FeralClaws, Amounts.uncommon);
            bag.AddItem(ItemID.StaffofRegrowth, Amounts.uncommon);
            bag.AddItem(ItemID.FiberglassFishingPole, Amounts.uncommon);
            bag.AddItem(ItemID.Boomstick, Amounts.uncommon);
            bag.AddItem(ItemID.HoneyDispenser, Amounts.uncommon);
            bag.AddItem(ItemID.FlowerBoots, Amounts.uncommon);
            bag.AddItem(ItemID.Seaweed, Amounts.rare);
            bag.AddItem(ItemID.Stinger, 3, 5,  Amounts.common);
            bag.AddItem(ItemID.JungleSpores, 3, 5, Amounts.common);
            bag.AddItem(ItemID.NaturesGift, Amounts.uncommon);
            bag.AddItem(ItemID.Bezoar, Amounts.uncommon);
            // Hell
            bag.AddItem(ItemID.DarkLance, Amounts.uncommon);
            bag.AddItem(ItemID.Sunfury, Amounts.uncommon);
            bag.AddItem(ItemID.Flamelash, Amounts.uncommon);
            bag.AddItem(ItemID.FlowerofFire, Amounts.uncommon);
            bag.AddItem(ItemID.HellwingBow, Amounts.uncommon);
            bag.AddItem(ItemID.TreasureMagnet, Amounts.uncommon);
            bag.AddItem(ItemID.HellMinecart, Amounts.uncommon);
            bag.AddItem(ItemID.OrnateShadowKey, Amounts.uncommon);
            bag.AddItem(ItemID.HellCake, Amounts.uncommon);
            bag.AddItem(ItemID.ObsidianRose, Amounts.rare);
            bag.AddItem(ItemID.DemonScythe, Amounts.rare);
            bag.AddItem(ItemID.MagmaStone, Amounts.rare);
            bag.AddItem(ItemID.GuideVoodooDoll, Amounts.uncommon);
            bag.AddItem(ItemID.HellfireArrow, 25, 50, Amounts.common);
            bag.AddItem(ItemID.Cascade, Amounts.rare);
            // Sky
            bag.AddItem(ItemID.Starfury, Amounts.uncommon);
            bag.AddItem(ItemID.ShinyRedBalloon, Amounts.uncommon);
            bag.AddItem(ItemID.SkyMill, Amounts.uncommon);
            bag.AddItem(ItemID.CreativeWings, Amounts.uncommon);
            bag.AddItem(ItemID.Feather, 3, 5, Amounts.common);
            // Fishing
            bag.AddItem(ItemID.ObsidianSwordfish, Amounts.uncommon);
            bag.AddItem(ItemID.BottomlessLavaBucket, Amounts.rare);
            bag.AddItem(ItemID.LavaAbsorbantSponge, Amounts.rare);
            bag.AddItem(ItemID.DemonConch, Amounts.rare);
            bag.AddItem(ItemID.Oyster, Amounts.uncommon);
            bag.AddItem(ItemID.FlameWakerBoots, Amounts.uncommon);
            bag.AddItem(ItemID.SuperheatedBlood, Amounts.uncommon);
            bag.AddItem(ItemID.LavaFishbowl, Amounts.uncommon);
            bag.AddItem(ItemID.LavaFishingHook, Amounts.uncommon);
            bag.AddItem(ItemID.VolcanoSmall, Amounts.uncommon);
            bag.AddItem(ItemID.PotSuspended, 1, 2, Amounts.uncommon);
            bag.AddItem(ItemID.WetBomb, 7, 10,  Amounts.uncommon);
            // Potions
            bag.AddItem(ItemID.AmmoReservationPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.BuilderPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.CalmingPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.CratePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.FeatherfallPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.FishingPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.GravitationPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.InfernoPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.InvisibilityPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.LuckPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.MagicPowerPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.ManaRegenerationPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.ObsidianSkinPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.SpelunkerPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.SummoningPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.ThornsPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.TitanPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.GenderChangePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.PotionOfReturn, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.ChickenNugget, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.CoffeeCup, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.CreamSoda, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.Hotdog, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            // Traveling Merchant
            bag.AddItem(ItemID.Code1, Amounts.rare);
            bag.AddItem(ItemID.Revolver, Amounts.rare);
            bag.AddItem(ItemID.SittingDucksFishingRod, Amounts.veryRare);
            bag.AddItem(ItemID.ZapinatorGray, Amounts.veryRare);

            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Loot Bag : Tier 2");
            Tooltip.SetDefault("Right click to open");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
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

        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ModContent.ItemType<LootBag3>(), 1)
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