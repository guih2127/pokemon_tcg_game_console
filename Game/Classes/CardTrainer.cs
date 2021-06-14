using Game.Interfaces;

namespace Game.Classes
{
    public class CardTrainer : Card, ICardTrainer
    {
        public Match Effect(Match game)
        {
            return game;
        }
    }
}