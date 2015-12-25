namespace Catharsium.SmooStone.Entities.Cards.Base
{
    public interface ICard
    {
        string Name { get; }

        string BaseDescription { get; }

        string CurrentDescription { get; }

        int BaseCost { get; }

        int CurrentCost { get; set; }
    }
}