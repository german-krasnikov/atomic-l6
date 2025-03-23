// using Atomic.Contexts;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public sealed class TeleportVfxController : IContextInit<IPlayerContext>, IContextDispose
//     {
//         private readonly ParticleSystem _vfx;
//         private Ability _ability;
//
//         public TeleportVfxController(ParticleSystem vfx)
//         {
//             _vfx = vfx;
//         }
//
//         public void Init(IPlayerContext context)
//         {
//             _ability = context.GetAbilities()["Teleport"];
//             _ability.GetPointEvent().Subscribe(this.OnUsed);
//         }
//
//         public void Dispose(IContext context)
//         {
//             _ability.GetPointEvent().Unsubscribe(this.OnUsed);
//         }
//
//         private void OnUsed(Vector3 point)
//         {
//             point.y = 0.2f;
//             _vfx.transform.position = point;
//             _vfx.Play();
//         }
//     }
// }