using Game.Interfaces;

namespace Game.Classes
{
    public class CardEnergy : Card, ICardEnergy
    {
        public int Type { get; set; }
    }
}