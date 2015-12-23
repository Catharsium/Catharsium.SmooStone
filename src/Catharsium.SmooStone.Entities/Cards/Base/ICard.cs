namespace Catharsium.SmooStone.Entities.Cards.Base
{
    public interface ICard
    {
        string Name { get; }

        int Cost { get; }

        int Attack { get; }

        int Health { get; }
    }
}