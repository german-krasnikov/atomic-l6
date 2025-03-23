// using Atomic.Contexts;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public sealed class UseDashAbilityController : IContextInit<IPlayerContext>, IContextUpdate
//     {
//         private readonly KeyCode _keyCode;
//         private Ability _ability;
//
//         public UseDashAbilityController(KeyCode keyCode)
//         {
//             _keyCode = keyCode;
//         }
//
//         public void Init(IPlayerContext context)
//         {
//             _ability = context.GetDashAbility();
//         }
//
//         public void OnUpdate(IContext context, float deltaTime)
//         {
//             if (Input.GetKeyDown(_keyCode)) 
//                 AbilityUseCase.Use(_ability);
//         }
//     }
// }