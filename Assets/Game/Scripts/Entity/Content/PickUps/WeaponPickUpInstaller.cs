using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class WeaponPickUpInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Ammo _ammo;

        [SerializeField]
        private SceneEntity _weaponPrefab;
        
        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddTransform(this.transform);
            entity.AddAmmo(_ammo);

            entity.AddInteractibleTag();
            entity.AddInteractAction(new BaseAction<IEntity>(character => 
                CurrentWeaponUseCase.PickUpWeapon(character, entity, gameContext)));

            entity.AddWeaponPrefab(_weaponPrefab);
        }
    }
}