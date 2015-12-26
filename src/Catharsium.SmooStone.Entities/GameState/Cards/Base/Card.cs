namespace Catharsium.SmooStone.Entities.GameState.Cards.Base
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

        
        private int? _currentCost;
        public virtual int CurrentCost
        {
            get
            {
                if (!_currentCost.HasValue)
                {
                    _currentCost = BaseCost;
                }
                return _currentCost.Value;
            }
            set { if (value >= 0) _currentCost = value; }
        }

        #endregion
    }
}