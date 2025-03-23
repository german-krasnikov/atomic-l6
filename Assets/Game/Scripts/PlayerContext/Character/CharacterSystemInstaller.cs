using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    [Serializable]
    public sealed class CharacterSystemInstaller : IContextInstaller<IPlayerContext>
    {
        [SerializeField]
        private SceneEntity _character;

        public void Install(IPlayerContext context)
        {
            context.AddCharacter(_character);
            context.AddController<CharacterFireController>();
            context.AddController<CharacterMoveController>();
            context.AddController<CharacterInteractController>();
            context.AddController<CharacterDropController>();
            context.AddController<CharacterJumpController>();
        }
    }
}