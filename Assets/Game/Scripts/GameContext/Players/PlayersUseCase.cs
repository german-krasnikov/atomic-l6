using System.Collections.Generic;
using Atomic.Entities;

namespace SampleGame
{
    public static partial class PlayersUseCase
    {
        public static IEntity GetCharacter(in IGameContext gameContext, in PlayerId player)
        {
            IPlayerContext playerContext = GetPlayerContext(gameContext, player);
            return playerContext.GetCharacter();
        }

        public static IPlayerContext GetPlayerContext(in IGameContext gameContext, in IEntity character)
        {
            PlayerId playerId = character.GetPlayerId().Value;
            return GetPlayerContext(gameContext, playerId);
        }

        public static IPlayerContext GetPlayerContext(in IGameContext gameContext, in PlayerId player)
        {
            IDictionary<PlayerId, IPlayerContext> players = gameContext.GetPlayers();
            IPlayerContext playerContext = players[player];
            return playerContext;
        }
    }
}