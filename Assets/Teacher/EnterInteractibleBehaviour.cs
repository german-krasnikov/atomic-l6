// using Atomic.Entities;
// using Modules.Gameplay;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public sealed class EnterInteractibleBehaviour : IEntityInit, IEntityDispose
//     {
//         private TriggerEventReceiver _trigger;
//         private IEntity _entity;
//         
//         public void Init(in IEntity entity)
//         {
//             _entity = entity;
//             _trigger = entity.GetTrigger();
//             _trigger.OnEntered += this.OnTriggerEntered;
//         }
//
//         public void Dispose(in IEntity entity)
//         {
//             _trigger.OnEntered -= this.OnTriggerEntered;
//         }
//
//         private void OnTriggerEntered(Collider collider)
//         {
//             if (collider.TryGetEntity(out IEntity target)) 
//                 InteractUseCase.Interact(_entity, target);
//         }
//     }
// }