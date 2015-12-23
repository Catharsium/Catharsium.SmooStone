using Catharsium.SmooStone.Entities.Cards.Base;

namespace Catharsium.SmooStone.Entities.Decks
{
    public interface IDeck
    {
        ICard Draw();
    }
}