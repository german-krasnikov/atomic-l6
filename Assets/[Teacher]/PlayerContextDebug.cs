// using System.Collections.Generic;
// using Atomic.Entities;
// using Sirenix.OdinInspector;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public sealed class PlayerContextDebug : MonoBehaviour
//     {
//         [SerializeField]
//         private PlayerContext _playerContext;
//
//         [Button]
//         public void Use(string name)
//         {
//             Ability ability = _playerContext.GetAbilities()[name];
//             AbilityUseCase.Use(ability);
//         }
//         
//         [Button]
//         public void Use(string name, Transform point)
//         {
//             Ability ability = _playerContext.GetAbilities()[name];
//             Debug.Log($"DISTANCE {VectorUseCase.GetDistance(_playerContext.GetCharacter(), point.position)}");
//             AbilityUseCase.Use(ability, point.position);
//         }
//         
//         [Button]
//         public void Use(string name, SceneEntity target)
//         {
//             Ability ability = _playerContext.GetAbilities()[name];
//             AbilityUseCase.Use(ability, target);
//         }
//     }
// }