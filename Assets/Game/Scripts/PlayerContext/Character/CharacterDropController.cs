using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterDropController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        private IGameContext _gameContext;
        private IPlayerContext _playerContext;
        
        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
            _gameContext = GameContext.Instance;
            _playerContext = context;
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            if (InputUseCase.IsDrop(_playerContext)) 
                CurrentWeaponUseCase.DropWeapon(_character, _gameContext);
        }
    }
}