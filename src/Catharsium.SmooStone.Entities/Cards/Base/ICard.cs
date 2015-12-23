namespace Catharsium.SmooStone.Entities.Cards.Base
{
    public interface ICard
    {
        int Cost { get; set; }

        int Attack { get; set; }

        int Health { get; set; }

        string ToString();
    }
}