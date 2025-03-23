using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class PlayerColorBehaviour : IEntityInit, IEntityDispose
    {
        private readonly MeshRenderer _meshRenderer;
        private readonly Material _blue;
        private readonly Material _red;
        private readonly Material _neutral;

        private IReactiveValue<PlayerId> _playerId;

        public PlayerColorBehaviour(
            MeshRenderer meshRenderer,
            Material blue,
            Material red,
            Material neutral
        )
        {
            _meshRenderer = meshRenderer;
            _blue = blue;
            _red = red;
            _neutral = neutral;
        }

        public void Init(in IEntity entity)
        {
            _playerId = entity.GetPlayerId();
            _playerId.Observe(this.OnPlayerChanged);
        }

        public void Dispose(in IEntity entity)
        {
            _playerId.Unsubscribe(this.OnPlayerChanged);
        }

        private void OnPlayerChanged(PlayerId playerId)
        {
            _meshRenderer.material = playerId switch
            {
                PlayerId.BLUE => _blue,
                PlayerId.RED => _red,
                PlayerId.NEUTRAL => _neutral,
                _ => throw new ArgumentOutOfRangeException(nameof(playerId), playerId, null)
            };
        }
    }
}