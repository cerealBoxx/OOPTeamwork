namespace AlexandreDumasOOP.Common.Items
{
    using System;

    abstract class Weapon
        : Item
    {
        private int damage;
        private int attackSpeed;

        protected Weapon(string name, int price) 
            : base(name, price)
        {
        }

        public int Damage
        {
            get
            { return this.damage; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage can not be negative!");
                }
                this.damage = value;
            }
        }

        public int AttackSpeed
        {
            get
            { return this.attackSpeed; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack speed can not be negative!");
                }
                this.attackSpeed = value;
            }
        }
    }
}
