using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;

namespace LootBags
{
    public class Bag
    {
        List<Loot> pool = new List<Loot>();
        private int totalWeight = 0;
        private Random rand = new Random();

        public void AddItem(int id, int min, int max, int weight)
        {
            totalWeight += weight;
            pool.Add(new Loot(id, min, max, weight));
        }
        public void AddItem(int id, int weight)
        {
            totalWeight += weight;
            pool.Add(new Loot(id, weight));
        }

        public void AddItem(Loot loot)
        {
            pool.Add(loot);
        }

        public Loot Roll(Player player)
        {
            double r = rand.Next(0, totalWeight);
            r = Math.Min(totalWeight - 1, r + (int)(player.luck * 50));
            foreach (Loot loot in pool)
            {
                if (loot.weight > r)
                {
                    return loot;
                }

                r -= loot.weight;
            }
            return new Loot(ItemID.DirtBlock, 1);
        }

        public void getModdedLoot(int bagType)
        {
            
        }

    }
}
