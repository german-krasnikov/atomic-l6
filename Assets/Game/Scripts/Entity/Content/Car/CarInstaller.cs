using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CarInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private CarObject _carObject;

        [SerializeField]
        private Transform _exitPoint;
        
        public override void Install(IEntity entity)
        {
            entity.AddTransform(this.transform);
            entity.AddInteractibleTag();
            entity.AddInteractAction(new BaseAction<IEntity>(character => CarUseCase.EnterCar(character, entity)));
            entity.AddCarObject(_carObject);
            entity.AddExitPoint(_exitPoint);
        }
    }
}