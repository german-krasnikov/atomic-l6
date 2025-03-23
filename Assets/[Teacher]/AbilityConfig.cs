// using UnityEngine;
//
// namespace SampleGame
// {
//     public abstract class AbilityConfig : ScriptableObject
//     {
//         [field: SerializeField]
//         public string Name { get; private set; }
//
//         [field: SerializeField]
//         public string Description { get; private set; }
//
//         [field: SerializeField]
//         public Sprite Icon { get; private set; }
//
//         public Ability Create(IPlayerContext context)
//         {
//             var ability = new Ability(this.Name);
//             ability.AddConfig(this);
//             this.Install(ability, context);
//             return ability;
//         }
//
//         protected abstract void Install(Ability ability, IPlayerContext context);
//     }
// }