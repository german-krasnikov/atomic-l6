// using Atomic.Elements;
// using Atomic.Entities;
// using Modules.Gameplay;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public sealed class DetectInteractibleBehaviour : IEntityInit, IEntityFixedUpdate, IEntityGizmos
//     {
//         private readonly Transform _center;
//         private readonly float _radius;
//         private readonly LayerMask _layerMask;
//         private readonly Cooldown _cooldown;
//
//         private IReactiveVariable<IEntity> _target;
//
//         public DetectInteractibleBehaviour(
//             Transform center,
//             float radius,
//             LayerMask layerMask,
//             float period
//         )
//         {
//             _center = center;
//             _radius = radius;
//             _layerMask = layerMask;
//             _cooldown = new Cooldown(period, period);
//         }
//
//         public void Init(in IEntity entity)
//         {
//             _target = entity.GetInteractTarget();
//         }
//
//         public void OnGizmosDraw(in IEntity entity)
//         {
//             Gizmos.DrawWireSphere(_center.position, _radius);
//         }
//
//         public void OnFixedUpdate(in IEntity entity, in float deltaTime)
//         {
//             _cooldown.Tick(deltaTime);
//             if (!_cooldown.IsExpired())
//                 return;
//
//             Vector3 center = _center.position;
//             InteractUseCase.FindClosest(center, _radius, _layerMask, out IEntity target);
//             
//             _target.Value = target;
//             _cooldown.Reset();
//         }
//     }
// }