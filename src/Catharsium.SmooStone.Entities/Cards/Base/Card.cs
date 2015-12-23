namespace Catharsium.SmooStone.Entities.Cards.Base
{
    public abstract class Card : ICard
    {
        public abstract int Attack { get; }

        public abstract int Cost { get; }

        public abstract int Health { get; }


        public string Name
        {
            get { return GetType().Name; }
        }
    }
}