using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class CarUseCase
    {
        public static bool EnterCar(in IEntity character, in IEntity car)
        {
            IReactiveVariable<IEntity> currentCar = character.GetCurrentCar();
            if (currentCar.Value != null)
                return false;

            currentCar.Value = car;

            character.GetMoveCondition().Append(Consts.False);
            character.GetGameObject().SetActive(false);

            Transform characterTransform = character.GetTransform();
            characterTransform.SetParent(car.GetTransform());
            characterTransform.localPosition = Vector3.zero;
            characterTransform.localRotation = Quaternion.identity;

            return true;
        }

        public static bool ExitCar(in IEntity character, in IEntity car, in IGameContext gameContext)
        {
            IReactiveVariable<IEntity> currentCar = character.GetCurrentCar();

            IEntity currentCarValue = currentCar.Value;
            if (currentCarValue == null)
                return false;

            currentCar.Value = null;
            character.GetMoveCondition().Remove(Consts.False);

            Transform characterTransform = character.GetTransform();
            Transform worldTransform = gameContext.GetWorldTransform();
            
            characterTransform.SetParent(worldTransform);
            Transform exitPoint = car.GetExitPoint();
            characterTransform.SetPositionAndRotation(exitPoint.position, exitPoint.rotation);
            character.GetGameObject().SetActive(true);

            CarObject carObject = car.GetCarObject();
            
            Debug.Log("Exit CAR");
            carObject.Car_Rigidbody.velocity = Vector3.zero;
            carObject.TurnDirection = 0;
            carObject.ForwardDirection = 0;
            carObject.Turn_Off_Car();
            
            return true;
        }
    }
}