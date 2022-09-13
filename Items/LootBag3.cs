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
            // bag.AddItem(ItemID., Amounts.);
            // Basic Resources
            bag.AddItem(ItemID.HealingPotion, 3, 5, Amounts.common);
            bag.AddItem(ItemID.GreaterHealingPotion, 3, 5, Amounts.uncommon);
            bag.AddItem(ItemID.CobaltBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.PalladiumBar, Amounts.barMin, Amounts.barMax, Amounts.common);
            bag.AddItem(ItemID.MythrilBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            bag.AddItem(ItemID.OrichalcumBar, Amounts.barMin, Amounts.barMax, Amounts.uncommon);
            bag.AddItem(ItemID.AdamantiteBar, Amounts.barMin, Amounts.barMax, Amounts.rare);
            bag.AddItem(ItemID.TitaniumBar, Amounts.barMin, Amounts.barMax, Amounts.rare);
            bag.AddItem(ItemID.BeamSword, Amounts.rare);
            bag.AddItem(ItemID.MagicQuiver, Amounts.uncommon);
            bag.AddItem(ItemID.Marrow, Amounts.uncommon);
            bag.AddItem(ItemID.MoonCharm, Amounts.uncommon);
            bag.AddItem(ItemID.MechanicalEye, Amounts.rare);
            bag.AddItem(ItemID.MechanicalWorm, Amounts.rare);
            bag.AddItem(ItemID.MechanicalSkull, Amounts.rare);
            bag.AddItem(ItemID.AdhesiveBandage, Amounts.uncommon);
            bag.AddItem(ItemID.TrifoldMap, Amounts.uncommon);
            bag.AddItem(ItemID.ArmorPolish, Amounts.uncommon);
            // Biome Keys
            bag.AddItem(ItemID.JungleKey, Amounts.veryRare);
            bag.AddItem(ItemID.CorruptionKey, Amounts.veryRare);
            bag.AddItem(ItemID.CrimsonKey, Amounts.veryRare);
            bag.AddItem(ItemID.HallowedKey, Amounts.veryRare);
            bag.AddItem(ItemID.FrozenKey, Amounts.veryRare);
            bag.AddItem(ItemID.DungeonDesertKey, Amounts.veryRare);
            // Mimics
            bag.AddItem(ItemID.DualHook, Amounts.uncommon);
            bag.AddItem(ItemID.MagicDagger, Amounts.uncommon);
            bag.AddItem(ItemID.TitanGlove, Amounts.uncommon);
            bag.AddItem(ItemID.PhilosophersStone, Amounts.uncommon);
            bag.AddItem(ItemID.CrossNecklace, Amounts.uncommon);
            bag.AddItem(ItemID.StarCloak, Amounts.uncommon);
            bag.AddItem(ItemID.Frostbrand, Amounts.uncommon);
            bag.AddItem(ItemID.IceBow, Amounts.uncommon);
            bag.AddItem(ItemID.FlowerofFrost, Amounts.uncommon);
            bag.AddItem(ItemID.ToySled, Amounts.rare);
            bag.AddItem(ItemID.DartRifle, Amounts.rare);
            bag.AddItem(ItemID.WormHook, Amounts.rare);
            bag.AddItem(ItemID.ChainGuillotines, Amounts.rare);
            bag.AddItem(ItemID.ClingerStaff, Amounts.rare);
            bag.AddItem(ItemID.PutridScent, Amounts.rare);
            bag.AddItem(ItemID.DartPistol, Amounts.rare);
            bag.AddItem(ItemID.TendonHook, Amounts.rare);
            bag.AddItem(ItemID.FetidBaghnakhs, Amounts.rare);
            bag.AddItem(ItemID.SoulDrain, Amounts.rare);
            bag.AddItem(ItemID.FleshKnuckles, Amounts.rare);
            bag.AddItem(ItemID.DaedalusStormbow, Amounts.rare);
            bag.AddItem(ItemID.IlluminantHook, Amounts.rare);
            bag.AddItem(ItemID.FlyingKnife, Amounts.rare);
            bag.AddItem(ItemID.CrystalVileShard, Amounts.rare);
            // Ice
            bag.AddItem(ItemID.FrozenTurtleShell, Amounts.rare);
            bag.AddItem(ItemID.IceSickle, Amounts.uncommon);
            bag.AddItem(ItemID.FrostStaff, Amounts.uncommon);
            bag.AddItem(ItemID.FrostCore, Amounts.uncommon);
            // Desert
            bag.AddItem(ItemID.DjinnLamp, Amounts.uncommon);
            bag.AddItem(ItemID.DjinnsCurse, Amounts.uncommon);
            bag.AddItem(ItemID.AncientHorn, Amounts.uncommon);
            bag.AddItem(ItemID.AncientBattleArmorMaterial, Amounts.uncommon);
            // Hallow
            bag.AddItem(ItemID.BlessedApple, Amounts.rare);
            bag.AddItem(ItemID.LightShard, 1, 2, Amounts.common);
            bag.AddItem(ItemID.PixieDust, 10, 20, Amounts.common);
            bag.AddItem(ItemID.UnicornHorn, Amounts.common);
            bag.AddItem(ItemID.RodofDiscord, Amounts.rare);
            bag.AddItem(ItemID.SoulofLight, 5, 10, Amounts.common);
            bag.AddItem(ItemID.CrystalShard, 5, 10, Amounts.common);
            bag.AddItem(ItemID.QueenSlimeCrystal, Amounts.uncommon);
            bag.AddItem(ItemID.Megaphone, Amounts.uncommon);
            bag.AddItem(ItemID.FastClock, Amounts.uncommon);
            // Corruption/Crimson
            bag.AddItem(ItemID.CursedFlame, 10, 15, Amounts.common);
            bag.AddItem(ItemID.Ichor, 10, 15, Amounts.common);
            bag.AddItem(ItemID.SoulofNight, 5, 10, Amounts.common);
            bag.AddItem(ItemID.DarkShard, 1, 2, Amounts.common);
            bag.AddItem(ItemID.Vitamins, Amounts.uncommon);
            bag.AddItem(ItemID.Nazar, Amounts.uncommon);
            bag.AddItem(ItemID.Blindfold, Amounts.uncommon);
            // Blood Moon
            bag.AddItem(ItemID.Bananarang, 1, 3, Amounts.uncommon);
            bag.AddItem(ItemID.BloodHamaxe, Amounts.uncommon);
            bag.AddItem(ItemID.SharpTears, Amounts.uncommon);
            bag.AddItem(ItemID.DripplerFlail, Amounts.uncommon);
            // Pirates
            bag.AddItem(ItemID.CoinGun, Amounts.rare);
            bag.AddItem(ItemID.Cutlass, Amounts.uncommon);
            bag.AddItem(ItemID.DiscountCard, Amounts.rare);
            bag.AddItem(ItemID.GoldRing, Amounts.rare);
            bag.AddItem(ItemID.LuckyCoin, Amounts.rare);
            bag.AddItem(ItemID.PirateStaff, Amounts.uncommon);
            // Fishing
            bag.AddItem(ItemID.Toxikarp, Amounts.uncommon);
            bag.AddItem(ItemID.Bladetongue, Amounts.uncommon);
            bag.AddItem(ItemID.CrystalSerpent, Amounts.uncommon);
            bag.AddItem(ItemID.Anchor, Amounts.uncommon);
            bag.AddItem(ItemID.Sundial, Amounts.rare);
            // Potions
            bag.AddItem(ItemID.LifeforcePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.LovePotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.LuckPotionGreater, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.TeleportationPotion, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.Dragonfruit, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.Starfruit, Amounts.potionMin, Amounts.potionMax, Amounts.common);
            bag.AddItem(ItemID.ApplePie, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.Bacon, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.ChocolateChipCookie, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.FriedEgg, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.Grapes, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            bag.AddItem(ItemID.Milkshake, Amounts.potionMin, Amounts.potionMax, Amounts.rare);
            bag.AddItem(ItemID.Nachos, Amounts.potionMin, Amounts.potionMax, Amounts.uncommon);
            // Traveling Merchant
            bag.AddItem(ItemID.ZapinatorOrange, Amounts.veryRare);
            bag.AddItem(ItemID.BouncingShield, Amounts.veryRare);
            bag.AddItem(ItemID.Gatligator, Amounts.veryRare);

            currentTooltip = LootBags.myTooltips[0].text;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Loot Bag : Tier 3");
            Tooltip.SetDefault("Right click to open");
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

        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ModContent.ItemType<LootBag4>(), 1)
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