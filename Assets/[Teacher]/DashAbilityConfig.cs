// using Atomic.Elements;
// using Atomic.Entities;
// using UnityEngine;
//
// namespace SampleGame
// {
//     [CreateAssetMenu(
//         fileName = "DashAbilityConfig",
//         menuName = "SampleGame/Abilities/New DashAbilityConfig"
//     )]
//     public sealed class DashAbilityConfig : AbilityConfig
//     {
//         [SerializeField]
//         private Const<int> _manaCost = 3;
//
//         [SerializeField]
//         private MoveSpeedEffectConfig _effect;
//
//         protected override void Install(Ability ability, IPlayerContext context)
//         {
//             ability.AddBaseTag();
//             ability.AddManaCost(_manaCost);
//
//             ability.AddBaseCondition(new BaseFunction<bool>(() =>
//             {
//                 int cost = ability.GetManaCost().Value;
//                 IEntity character = context.GetCharacter();
//                 return ManaUseCase.Enough(context, cost) && EffectUseCase.CanApply(character, _effect);
//             }));
//
//             ability.AddBaseAction(new BaseAction(() =>
//             {
//                 IEntity character = context.GetCharacter();
//                 EffectUseCase.Apply(character, _effect);
//
//                 int cost = ability.GetManaCost().Value;
//                 ManaUseCase.Spend(context, cost);
//             }));
//
//             ability.AddBaseEvent(new BaseEvent());
//
//             ability.WhenUpdate(_ =>
//             {
//                 if (Input.GetKeyDown(KeyCode.M))
//                     AbilityUseCase.Use(ability);
//             });
//         }
//     }
// }