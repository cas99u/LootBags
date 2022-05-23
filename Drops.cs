using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace LootBags
{
	public class Drops : GlobalNPC
	{

        public override void ModifyGlobalLoot(GlobalLoot globalLoot)
        {
                if (NPC.downedMoonlord)
                {
                    globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.LootBag5>(), Amounts.tierFiveChance));
                }
                else if (NPC.downedPlantBoss)
                {
                    globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.LootBag4>(), Amounts.tierFourChance));
                }
                else if (Main.hardMode)
                {
                    globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.LootBag3>(), Amounts.tierThreeChance));
                }
                else if (NPC.downedBoss3)
                {
                    globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.LootBag2>(), Amounts.tierTwoChance));
                }
                else
                {
                    globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.LootBag1>(), Amounts.tierOneChance));
                }
            
        }
		

	}

}
