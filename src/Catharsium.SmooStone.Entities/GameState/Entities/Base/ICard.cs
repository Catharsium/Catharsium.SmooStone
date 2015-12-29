namespace Catharsium.SmooStone.Entities.GameState.Entities.Base
{
    public interface ICard : IEntity
    {

        string BaseDescription { get; }

        string CurrentDescription { get; }

        int BaseCost { get; }

        int CurrentCost { get; }
    }
}