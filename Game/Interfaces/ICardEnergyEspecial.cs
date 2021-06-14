using Game.Classes;

namespace Game.Interfaces
{
    public interface ICardEnergyEspecial : ICardEnergy
    {
        public CardPokemon Effect(CardPokemon cardPokemon);
    }
}