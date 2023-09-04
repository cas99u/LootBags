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

        public Bag Add(int id, int min, int max, int weight)
        {
            totalWeight += weight;
            pool.Add(new Loot(id, min, max, weight));
            return this;
        }
        public Bag Add(int id, int weight)
        {
            totalWeight += weight;
            pool.Add(new Loot(id, weight));
            return this;
        }

        public Bag Add(Loot loot)
        {
            pool.Add(loot);
            return this;
        }

        public Loot Roll(Player player)
        {
            double r = rand.Next(0, totalWeight);
            foreach (Loot loot in pool)
            {
                if (loot.weight > r)
                {
                    return loot;
                }

                r -= loot.weight;
            }
            return new Loot(ItemID.AlphabetStatue0, 1); // This shouldn't happen
        }


    }
}
