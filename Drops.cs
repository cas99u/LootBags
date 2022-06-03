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
            IItemDropRule tier5Drop = new ItemDropWithConditionRule(ModContent.ItemType<Items.LootBag5>(), Amounts.tierFiveChance, 1 , 1, new NotCheese());
            IItemDropRule tier4Drop = new ItemDropWithConditionRule(ModContent.ItemType<Items.LootBag4>(), Amounts.tierFourChance, 1, 1, new NotCheese());
            IItemDropRule tier3Drop = new ItemDropWithConditionRule(ModContent.ItemType<Items.LootBag3>(), Amounts.tierThreeChance, 1, 1, new NotCheese());
            IItemDropRule tier2Drop = new ItemDropWithConditionRule(ModContent.ItemType<Items.LootBag2>(), Amounts.tierTwoChance, 1, 1, new NotCheese());
            IItemDropRule tier1Drop = new ItemDropWithConditionRule(ModContent.ItemType<Items.LootBag1>(), Amounts.tierOneChance, 1, 1, new NotCheese());

            LeadingConditionRule tier5Rule = new LeadingConditionRule(new DownedMoonlord());
            LeadingConditionRule tier4Rule = new LeadingConditionRule(new Conditions.DownedPlantera());
            LeadingConditionRule tier3Rule = new LeadingConditionRule(new Conditions.IsHardmode());
            LeadingConditionRule tier2Rule = new LeadingConditionRule(new DownedSkeletron());
            
            tier5Rule.OnSuccess(tier5Drop);
            tier5Rule.OnFailedConditions(tier4Rule);

            tier4Rule.OnSuccess(tier4Drop);
            tier4Rule.OnFailedConditions(tier3Rule);

            tier3Rule.OnSuccess(tier3Drop);
            tier3Rule.OnFailedConditions(tier2Rule);

            tier2Rule.OnSuccess(tier2Drop);
            tier2Rule.OnFailedConditions(tier1Drop);

            globalLoot.Add(tier5Rule);

            


        }
		

	}

    public class DownedMoonlord : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {

            return NPC.downedMoonlord;

        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drops after defeating Moon Lord";
        }
    }

    public class DownedSkeletron : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {

            return NPC.downedBoss3;

        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drops after defeating Skeletron";
        }
    }


    public class NotCheese : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {

             return !(info.npc.SpawnedFromStatue || info.npc.CountsAsACritter || info.npc.lifeMax <= 5);

        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Does not drop from statue or critter";
        }
    }
}
