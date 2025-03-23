// using Atomic.Elements;
// using Atomic.Entities;
// using UnityEngine;
//
// namespace SampleGame
// {
//     [CreateAssetMenu(
//         fileName = "TeleportAbilityConfig",
//         menuName = "SampleGame/Abilities/New TeleportAbilityConfig"
//     )]
//     public sealed class TeleportAbilityConfig : AbilityConfig
//     {
//         [SerializeField]
//         private int _charges;
//
//         [SerializeField]
//         private Const<float> _radius = 5;
//
//         protected override void Install(Ability ability, IPlayerContext context)
//         {
//             ability.AddPointTag();
//
//             ability.AddCharges(new ReactiveInt(_charges));
//             ability.AddRadius(_radius);
//
//             ability.AddPointCondition(new BaseFunction<Vector3, bool>(point =>
//             {
//                 int count = ability.GetCharges().Value;
//                 IEntity character = context.GetCharacter();
//                 return count > 0 && VectorUseCase.LessOrEqualsDistance(character, point, _radius.Value);
//             }));
//
//             ability.AddPointAction(new BaseAction<Vector3>(point =>
//             {
//                 IEntity character = context.GetCharacter();
//                 character.GetTransform().position = point;
//                 ability.GetCharges().Value--;
//             }));
//
//             ability.AddPointEvent(new BaseEvent<Vector3>());
//             
//             ability.WhenUpdate(_ =>
//             {
//                 if (Input.GetKey(KeyCode.T) && Input.GetMouseButtonDown(0) && 
//                     RaycastUseCase.RaycastGround(context, out var point))
//                     AbilityUseCase.Use(ability, point);
//             });
//         }
//     }
// }