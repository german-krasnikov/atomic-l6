// using System;
// using System.Collections.Generic;
// using Atomic.Contexts;
// using Atomic.Elements;
// using UnityEngine;
//
// namespace SampleGame
// {
//     
//     
//     [Serializable]
//     public sealed class AbilitySystemInstaller : IContextInstaller<IPlayerContext>
//     {
//         [SerializeField]
//         private AbilityConfig[] _abilities;
//
//         public void Install(IPlayerContext context)
//         {
//             context.AddAbilities(this.CreateAbilities(context));
//             context.AddController<AbilityRunner>();
//         }
//
//         private IReactiveDictionary<string, Ability> CreateAbilities(IPlayerContext context)
//         {
//             int count = _abilities.Length;
//             IReactiveDictionary<string, Ability> abilities = new ReactiveDictionary<string, Ability>(count);
//             for (int i = 0; i < count; i++)
//             {
//                 AbilityConfig config = _abilities[i];
//                 Ability ability = config.Create(context);
//                 abilities.Add(config.Name, ability);
//             }
//
//             return abilities;
//         }
//     }
//     
//     
//     
// }