using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public static class CurrentWeaponUseCase
    {
        public static bool AddClips(in IEntity character, in int clips)
        {
            IEntity weapon = character.GetCurrentWeapon().Value;
            if (weapon == null)
                return false;

            if (!weapon.TryGetAmmo(out Ammo ammo))
                return false;

            return ammo.Add(clips);
        }

        public static bool DropWeapon(in IEntity character, in IGameContext context)
        {
            IReactiveVariable<IEntity> weaponVariable = character.GetCurrentWeapon();
            IEntity weapon = weaponVariable.Value;

            if (weapon == null)
                return false;

            SceneEntity pickUpPrefab = weapon.GetPickUpPrefab();
            Transform characterTransform = character.GetTransform();

            Transform worldTransform = context.GetWorldTransform();
            Vector3 spawnPosition = characterTransform.position;
            Quaternion spawnRotation = characterTransform.rotation;

            PrefabEntityPool entityPool = context.GetEntityPool();
            SceneEntity pickUpWeapon = entityPool.Rent(pickUpPrefab, spawnPosition, spawnRotation, worldTransform);
            pickUpWeapon.GetAmmo().Setup(weapon.GetAmmo());

            weaponVariable.Value = null;
            
            weapon.GetPlayerId().Value = PlayerId.NEUTRAL;
            weapon.GetOwner().Value = null;

            entityPool.Return(weapon);
            return true;
        }

        public static bool PickUpWeapon(in IEntity character, in IEntity pickUpWeapon, in IGameContext gameContext)
        {
            IReactiveVariable<IEntity> weaponVariable = character.GetCurrentWeapon();

            if (weaponVariable.Value != null)
                return false;

            SceneEntity weaponPrefab = pickUpWeapon.GetWeaponPrefab();
            Transform weaponContainer = character.GetWeaponContainer();
            PrefabEntityPool entityPool = gameContext.GetEntityPool();

            SceneEntity weapon = entityPool.Rent(
                weaponPrefab,
                weaponContainer.position,
                weaponContainer.rotation,
                weaponContainer
            );
            
            weapon.GetAmmo().Setup(pickUpWeapon.GetAmmo());
            weapon.GetPlayerId().Value = character.GetPlayerId().Value;
            weapon.GetOwner().Value = character;
            weaponVariable.Value = weapon;
            
            entityPool.Return(pickUpWeapon);
            return true;
        }
    }
}