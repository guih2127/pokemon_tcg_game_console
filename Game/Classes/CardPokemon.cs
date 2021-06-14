using Game.Interfaces;
using System.Collections.Generic;

namespace Game.Classes
{
    public class CardPokemon : Card, ICardPokemon
    {
        public int Hp { get; set; }
        public int Type { get; set; }
        public int Stage { get; set; }
        public int Weakness { get; set; }
        public int Resistance { get; set; }
        public int RetreatCost { get; set; }
        public string BasePokemon { get; set; }
        public Ability Ability { get; set; }
        public IList<Attack> Attacks { get; set; }
    }
}