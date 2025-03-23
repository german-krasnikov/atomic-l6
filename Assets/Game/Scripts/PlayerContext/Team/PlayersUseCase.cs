using Atomic.Entities;

namespace SampleGame
{
    public static partial class PlayersUseCase
    {
        public static bool IsEnemy(in IPlayerContext context, in IEntity character)
        {
            return context.GetPlayerId().Value != character.GetPlayerId().Value;
        }
    }
}