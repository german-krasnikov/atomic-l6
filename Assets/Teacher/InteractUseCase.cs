// using System.Buffers;
// using Atomic.Elements;
// using Atomic.Entities;
// using UnityEngine;
//
// namespace SampleGame
// {
//     public static class InteractUseCase
//     {
//         public static bool Interact(in IEntity source, in Collider collider)
//         {
//             return collider.TryGetEntity(out IEntity target) &&
//                    target.HasInteractibleTag() &&
//                    Interact(source, target);
//         }
//
//         public static bool InteractWithTarget(in IEntity source)
//         {
//             return Interact(source, source.GetInteractTarget().Value);
//         }
//
//         public static bool Interact(in IEntity source, in IEntity target)
//         {
//             if (target == null)
//                 return false;
//
//             if (!target.HasInteractibleTag())
//                 return false;
//
//             IFunction<IEntity, bool> action = target.GetInteractAction();
//             return action.Invoke(source);
//         }
//
//         public static bool FindClosest(
//             in Vector3 center,
//             in float radius,
//             in LayerMask layerMask,
//             out IEntity result
//         )
//         {
//             ArrayPool<Collider> pool = ArrayPool<Collider>.Shared;
//             Collider[] buffer = pool.Rent(32);
//
//             int count = Physics.OverlapSphereNonAlloc(center, radius, buffer, layerMask);
//             float minDistance = float.MaxValue;
//             result = null;
//
//             for (int i = 0; i < count; i++)
//             {
//                 Collider collider = buffer[i];
//                 if (!collider.TryGetEntity(out IEntity entity))
//                     continue;
//
//                 if (!entity.HasInteractibleTag())
//                     continue;
//
//                 if (!entity.TryGetTransform(out Transform transform))
//                     continue;
//
//                 Vector3 vector = center - transform.position;
//                 float distance = vector.sqrMagnitude;
//                 if (distance < minDistance)
//                 {
//                     result = entity;
//                     minDistance = distance;
//                 }
//             }
//
//             pool.Return(buffer);
//             return result != null;
//         }
//     }
// }