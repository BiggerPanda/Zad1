using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Plecak
    {
        public List<Item> itemList;
        public int valueMax;
        public int weightMax;

        private int valueCurrent;
        private int weightCurrent;
        private int itemsAmount;
        private List<Item> itemsInsideBackpack;

        

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
        public  bool Equals(Plecak obj)
        {
            if (obj.itemList == this.itemList && obj.valueMax==this.valueMax && obj.weightMax == this.weightMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GatherItems()
        {
            foreach(var item in itemList)
            {
                if()
               weightCurrent += item.Weight;
               valueCurrent += item.Value;
                
            }
            Console.WriteLine("weight" + weightCurrent.ToString());
            Console.WriteLine("value" + valueCurrent.ToString());
        }
    }
}
