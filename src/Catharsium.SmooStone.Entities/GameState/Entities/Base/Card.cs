namespace Catharsium.SmooStone.Entities.GameState.Entities.Base
{
    public abstract class Card : ICard
    {
        #region IAgent

        public virtual string Name => GetType().Name;

        public abstract string BaseDescription { get; }

        public virtual string CurrentDescription => BaseDescription;
        
        
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