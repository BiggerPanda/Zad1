namespace Zad1
{
    public class Item
    {
        private int weight;
        private int value;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public Item(int value,int weight)
        {
            Value = value;
            Weight = weight;
        }

        

        
    }
}