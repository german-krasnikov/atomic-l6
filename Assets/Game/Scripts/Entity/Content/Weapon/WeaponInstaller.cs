using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class WeaponInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Transform _firePoint;

        [SerializeField]
        private Ammo _ammo;

        [SerializeField]
        private SceneEntity _pickUpPrefab;
        
        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddGameObject(this.gameObject);
            entity.AddTransform(this.transform);
            entity.AddPickUpPrefab(_pickUpPrefab);
            entity.AddPlayerId(new ReactiveVariable<PlayerId>());
            entity.AddOwner(new ReactiveVariable<IEntity>());

            this.InstallFire(entity, gameContext);
        }

        private void InstallFire(IEntity entity, GameContext gameContext)
        {
            entity.AddAmmo(_ammo);
            entity.AddFirePoint(_firePoint);
            entity.AddFireEvent(new BaseEvent());
            entity.AddFireCondition(new AndExpression(_ammo.Exists));
            entity.AddFireAction(new BaseAction(() =>
            {
                if (entity.GetFireCondition().Invoke())
                {
                    FireBulletUseCase.FireBullet(entity, gameContext);
                    _ammo.SpendOne();
                    entity.GetFireEvent().Invoke();
                }
            }));
        }
    }
}