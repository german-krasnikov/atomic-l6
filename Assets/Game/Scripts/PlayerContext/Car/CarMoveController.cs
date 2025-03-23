using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CarMoveController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;

        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            IEntity currentCar = _character.GetCurrentCar().Value;
            if (currentCar == null)
                return;

            float forwardDirection = Input.GetAxis("Vertical");
            float turnDirection = Input.GetAxis("Horizontal");
            
            CarObject carObject = currentCar.GetCarObject();
            carObject.ForwardDirection = forwardDirection;
            carObject.TurnDirection = turnDirection;
        }
    }
}