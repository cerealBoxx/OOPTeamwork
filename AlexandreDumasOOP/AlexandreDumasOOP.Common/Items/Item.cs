namespace AlexandreDumasOOP.Common.Items
{
    //using AlexandreDumasOOP.Common.Interfaces;
    using System;

    abstract class Item
    {
        private int price;

        protected Item(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; protected set; }
        public int Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Item price can not be negative!");
                }
                this.price = value;   
            }
        }
    }
}
