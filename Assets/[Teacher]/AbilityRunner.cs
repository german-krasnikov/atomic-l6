// using System.Collections.Generic;
// using Atomic.Contexts;
//
// namespace SampleGame
// {
//     public sealed class AbilityRunner :
//         IContextInit<IPlayerContext>,
//         IContextEnable,
//         IContextDisable,
//         IContextDispose,
//         IContextFixedUpdate,
//         IContextUpdate
//     {
//         private List<Ability> _abilities;
//
//         public void Init(IPlayerContext context)
//         {
//             _abilities = new List<Ability>(context.GetAbilities().Values);
//
//             foreach (Ability ability in _abilities)
//                 ability.Init();
//         }
//
//         public void Enable(IContext context)
//         {
//             foreach (Ability ability in _abilities)
//                 ability.Enable();
//         }
//
//         public void Disable(IContext context)
//         {
//             foreach (Ability ability in _abilities)
//                 ability.Disable();
//         }
//
//         public void OnUpdate(IContext context, float deltaTime)
//         {
//             foreach (Ability ability in _abilities)
//                 ability.OnUpdate(deltaTime);
//         }
//
//         public void OnFixedUpdate(IContext context, float deltaTime)
//         {
//             foreach (Ability ability in _abilities)
//                 ability.OnFixedUpdate(deltaTime);
//         }
//
//         public void Dispose(IContext context)
//         {
//             foreach (Ability ability in _abilities)
//                 ability.Dispose();
//         }
//     }
// }