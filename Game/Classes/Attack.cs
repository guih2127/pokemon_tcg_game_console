using Game.Interfaces;

namespace Game.Classes
{
    public class Attack : IAttack
    {
        public string Nome { get; set; }
        public int Damage { get; set; }

        public Match Effect(Match match)
        {
            return match;
        }
    }
}