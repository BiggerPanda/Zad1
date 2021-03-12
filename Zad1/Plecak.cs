using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Plecak
    {
        public List<Item> itemList;
        public int valueMax;
        public int weightMax;

        private int valueCurrent;
        private int weightCurrent;
        private int itemsAmount;

        

        public Plecak(int itemsAmount,int valueMax,int weightMax)
        {
            this.itemsAmount = itemsAmount;
            this.valueMax = valueMax;
            this.weightMax = weightMax; 
        }

        public void GenerateItems()
        {
            itemList = new List<Item>();
            RandomNumberGenerator rng = new RandomNumberGenerator(2);
            for (int i = 0; i < itemsAmount; i++)
            {
                itemList.Add(new Item(rng.nextInt(1, 29), rng.nextInt(1, 29)));
            }
        }

        public void WriteList()
        {
            foreach (var x in itemList)
            {
                Console.WriteLine(x.Value.ToString() + " " + x.Weight.ToString());
            }
        }
    }
}
