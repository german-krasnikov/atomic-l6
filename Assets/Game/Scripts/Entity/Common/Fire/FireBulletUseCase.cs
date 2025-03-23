using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class FireBulletUseCase
    {
        public static IEntity FireBullet(in IEntity weapon, in IGameContext context)
        {
            Transform firePoint = weapon.GetFirePoint();
            PlayerId playerId = weapon.GetPlayerId().Value;
            IEntity owner = weapon.GetOwner().Value;
            return SpawnBulletUseCase.SpawnBullet(context, firePoint.position, firePoint.rotation, owner, playerId);
        }
    }
}