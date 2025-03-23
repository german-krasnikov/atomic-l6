using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CarExitController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        private IGameContext _gameContext;

        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
            _gameContext = GameContext.Instance;
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            IEntity currentCar = _character.GetCurrentCar().Value;
            if (currentCar == null)
                return;

            if (Input.GetKeyDown(KeyCode.Q))
                CarUseCase.ExitCar(_character, currentCar, _gameContext);
        }
    }
}