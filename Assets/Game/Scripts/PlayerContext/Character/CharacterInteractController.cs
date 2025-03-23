using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterInteractController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        
        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.E)) 
                InteractUseCase.InteractAsCharacter(_character);
        }
    }
}