using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBags
{
    public class Loot
    {
        public int item { get; private set; }
        public int min { get; private set; }
        public int max { get; private set; }
        public int weight { get; private set; }
        public Loot(int item, int min, int max, int weight)
        {
            this.item = item;
            this.min = min;
            this.max = max;
            this.weight = weight;
        }

        public Loot(int item, int weight)
        {
            this.item = item;
            this.min = 1;
            this.max = 1;
            this.weight = weight;
        }

    }
}
