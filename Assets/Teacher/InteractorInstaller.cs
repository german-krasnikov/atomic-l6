// using System;
// using Atomic.Elements;
// using Atomic.Entities;
// using UnityEngine;
//
// namespace SampleGame
// {
//     [Serializable]
//     public sealed class InteractorInstaller : IEntityInstaller
//     {
//         [SerializeField]
//         private float _radius = 5;
//
//         [SerializeField]
//         private LayerMask _layerMask;
//         
//         [SerializeField]
//         private Transform _center;
//
//         [SerializeField]
//         private float _period = 0.25f;
//
//         public void Install(IEntity entity)
//         {
//             entity.AddInteractTarget(new ReactiveVariable<IEntity>());
//             entity.AddBehaviour(new DetectInteractibleBehaviour(_center, _radius, _layerMask, _period));
//         }
//     }
// }