// using Atomic.Elements;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public sealed class MoveSpeedAbility : Ability, IActionAbility
//     {
//         private readonly IValue<float> _multiplier;
//         private readonly IPlayerContext _context;
//         
//         public MoveSpeedAbility(AbilityConfig config, IPlayerContext context) : base(config)
//         {
//             _context = context;
//         }
//
//         public bool CanUse()
//         {
//             return true;
//         }
//
//         public void Use()
//         {
//             _context.GetCharacter().GetMoveSpeed().Value *= _multiplier.Value;
//             Debug.Log("Move Speed Activated!");
//         }
//     }
// }