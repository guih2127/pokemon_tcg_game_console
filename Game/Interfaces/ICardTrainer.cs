using Game.Classes;

namespace Game.Interfaces
{
    interface ICardTrainer : ICard
    {
        public Match Effect(Match game);
    }
}