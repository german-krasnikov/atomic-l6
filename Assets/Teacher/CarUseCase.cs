// using Atomic.Elements;
// using Atomic.Entities;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public static class CarUseCase
//     {
//         public static bool EnterCar(in IEntity character, in IEntity car)
//         {
//             IReactiveVariable<IEntity> currentCar = character.GetCurrentCar();
//             if (currentCar.Value != null)
//                 return false;
//
//             currentCar.Value = car;
//             character.GetMoveCondition().Append(FalseCondition);
//             character.GetAngularDirection().Value = Vector3.zero;
//             character.GetGameObject().SetActive(false);
//             
//             
//             Transform characterTransform = character.GetTransform();
//             characterTransform.SetParent(car.GetTransform());
//             characterTransform.localPosition = Vector3.zero;
//             characterTransform.localRotation = Quaternion.identity;
//
//             return true;
//         }
//
//         public static bool ExitCar(in IEntity character, in IEntity car, in IGameContext gameContext)
//         {
//             IReactiveVariable<IEntity> currentCar = character.GetCurrentCar();
//
//             if (currentCar.Value == null)
//                 return false;
//
//             currentCar.Value = null;
//             character.GetMoveCondition().Remove(FalseCondition);
//
//             Transform characterTransform = character.GetTransform();
//             characterTransform.SetParent(gameContext.GetWorldTransform());
//             Transform exitPoint = car.GetExitPoint();
//             characterTransform.SetPositionAndRotation(exitPoint.position, exitPoint.rotation);
//             character.GetGameObject().SetActive(true);
//             
//             return true;
//         }
//
//         private static bool FalseCondition() => false;
//     }
// }