using Game.Interfaces;
using System.Collections.Generic;

namespace Game.Classes
{
    public class Deck : IDeck
    {
        public string Name { get; set; }
        public IList<Card> Cards { get; set; }
    }
}