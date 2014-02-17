namespace AlexandreDumasOOP.Common.Items
{
    using System;

    class Armour
        : Item
    {
        private int defence;
        private int evasionRatio;

        public Armour(string name, int price, int defence, int evasionRatio) 
            : base(name, price)
        {
            this.Defence = defence;
            this.EvasionRatio = evasionRatio;
        }

        public int Defence
        {
            get { return this.defence; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Defence can not be negative!");
                }
                this.defence = value;
            }
        }

        public int EvasionRatio
        {
            get { return this.evasionRatio; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Evasion ratio can not be negative or bigger than 50!");
                }
                this.evasionRatio = value;
            }
        }
    }
}
