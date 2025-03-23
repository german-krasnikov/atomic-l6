using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class RaycastUseCase
    {
        public static bool RaycastGround(in IPlayerContext context, Vector2 screenPosition, out Vector3 point)
        {
            Ray ray = context.GetCamera().ScreenPointToRay(screenPosition);
            if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform.CompareTag("Ground"))
            {
                point = hit.point; 
                return true;
            }

            point = default;
            return false;
        }
        
        public static bool RaycastTarget(in IPlayerContext context, Vector2 screenPosition, out IEntity target)
        {
            Ray ray = context.GetCamera().ScreenPointToRay(screenPosition);
            if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform.TryGetComponent(out target))
                return true;

            target = default;
            return false;
        }
    }
}