namespace Catharsium.SmooStone.Entities.Cards.Base
{
    public abstract class Card : ICard
    {
        #region ICard

        public virtual string Name
        {
            get { return GetType().Name; }
        }


        public virtual string CurrentDescription
        {
            get { return BaseDescription; }
        }


        public abstract string BaseDescription { get; }
        
        public abstract int BaseCost { get; }

        public abstract int CurrentCost { get; set; }
        
        #endregion
    }
}