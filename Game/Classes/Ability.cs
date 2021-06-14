using Game.Interfaces;

namespace Game.Classes
{
    public class Ability : IAbility
    {
        public string Nome { get; set; }

        public Match Effect(Match match)
        {
            return match;
        }
    }
}