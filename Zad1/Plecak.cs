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
        private List<Item> itemsInsideBackpack = new List<Item>();

        

        public Plecak(int itemsAmount,int valueMax,int weightMax)
        {
            this.itemsAmount = itemsAmount;
            this.valueMax = valueMax;
            this.weightMax = weightMax;
            GenerateItems();
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

        public void SortItemsByValue()
        {
            int n = itemList.Count;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (itemList[i].Value < itemList[i + 1].Value)
                    {
                        var tmp = itemList[i];
                        itemList[i] = itemList[i + 1];
                        itemList[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }
        
        public string WriteAllItems()
        {
            var retString = new System.Text.StringBuilder();
            SortItemsByValue();
            foreach (var x in itemList)
            {
                retString.Append(x.Value.ToString() + " " + x.Weight.ToString());
            }
            return retString.ToString();
        }

        public string WriteListBackpack()
        {
            var retString = new System.Text.StringBuilder();
            foreach (var x in itemsInsideBackpack)
            {
                retString.Append(x.Value.ToString() + " " + x.Weight.ToString());
            }
            return retString.ToString();
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
                if (weightCurrent+item.Weight < weightMax)
                {
                    weightCurrent += item.Weight;
                    valueCurrent += item.Value;
                    itemsInsideBackpack.Add(item);
                } 
            }
            Console.WriteLine("weight" + weightCurrent.ToString());
            Console.WriteLine("value" + valueCurrent.ToString());
        }
    }
}
