using System;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base
{
    public abstract class Card : ICard
    {
        #region IAgent

        private Guid? _id;
        public Guid ID
        {
            get
            {
                if(!_id.HasValue)
                {
                    _id = Guid.NewGuid();
                }
                return _id.Value;
            }
        }


        public virtual string Name => GetType().Name;

        public abstract string BaseDescription { get; }


        private string _currentDescription;
        public virtual string CurrentDescription
        {
            get { return _currentDescription ?? (_currentDescription = BaseDescription); }
            set { _currentDescription = value; }
        }
        
        
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