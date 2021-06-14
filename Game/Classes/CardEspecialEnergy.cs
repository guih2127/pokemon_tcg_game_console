using Game.Interfaces;

namespace Game.Classes
{
    public class CardEspecialEnergy : CardEnergy, ICardEnergyEspecial
    {
        public CardPokemon Effect(CardPokemon cardPokemon)
        {
            return cardPokemon;
        }
    }
}