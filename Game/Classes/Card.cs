using Game.Interfaces;

namespace Game.Classes
{
    public class Card : ICard
    {
        public string Name { get; set; }
        public int Set { get; set; }
    }
}