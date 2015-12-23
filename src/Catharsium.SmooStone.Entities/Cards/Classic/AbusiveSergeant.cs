using Catharsium.SmooStone.Entities.Cards.Base;

namespace Catharsium.SmooStone.Entities.Cards.Classic
{
    public class AbusiveSergeant : Card, IBattlecryCard
    {
        public override int Attack
        {
            get { return 2; }
        }


        public override int Cost
        {
            get { return 1; }
        }


        public override int Health
        {
            get { return 1; }
        }


        public void Battlecry()
        {
            
        }
    }
}