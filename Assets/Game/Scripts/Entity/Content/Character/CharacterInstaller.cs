using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private GameObject _gameObject;

        [SerializeField]
        private Transform _transform;

        [SerializeField]
        private Rigidbody _rigidbody;
        
        [SerializeField]
        private TriggerEventReceiver _triggerEventReceiver;
        
        [SerializeField]
        private float _moveSpeed = 3;

        [SerializeField]
        private float _angularSpeed = 15;

        [SerializeField]
        private int _health = 3;

        [SerializeField]
        private SceneEntity _initialWeapon;

        [SerializeField]
        private Transform _weaponContainer;

        [SerializeField]
        private PlayerId _playerId;
        
        [SerializeField]
        private InteractInstaller _interactInstaller;

        public override void Install(IEntity entity)
        {
            this.InstallMain(entity);
            this.InstallLife(entity);
            this.InstallCombat(entity);
            this.InstallMove(entity);
            this.InstallRotate(entity);
            this.InstallWeapon(entity);

            _interactInstaller.Install(entity);

            entity.AddEffects(new ReactiveDictionary<string, EffectInstance>());
            entity.AddCurrentCar(new ReactiveVariable<IEntity>());

            entity.WhenUpdate(_ =>
            {
                if (MoveUseCase.IsMoving(entity))
                    entity.GetAngularDirection().Value = entity.GetMoveDirection().Value;
            });
        }

        private void InstallWeapon(IEntity entity)
        {
            entity.AddCurrentWeapon(new ReactiveVariable<IEntity>(_initialWeapon));
            entity.AddWeaponContainer(_weaponContainer);
            entity.WhenInit(() =>
            {
                IEntity weapon = entity.GetCurrentWeapon().Value;
                if (weapon != null)
                {
                    weapon.GetPlayerId().Value = _playerId;
                    weapon.GetOwner().Value = entity;
                }
            });
        }

        private void InstallMain(IEntity entity)
        {
            entity.AddGameObject(_gameObject);
            entity.AddTransform(_transform);
            entity.AddRigidbody(_rigidbody);
            entity.AddTrigger(_triggerEventReceiver);
            entity.AddPlayerId(new ReactiveVariable<PlayerId>(_playerId));
        }

        private void InstallRotate(IEntity entity)
        {
            entity.AddAngularSpeed(new BaseFunction<float>(() => _angularSpeed));
            entity.AddAngularDirection(new ReactiveVector3());
            entity.AddBehaviour<RotateTowardsBehaviour>();
        }

        private void InstallLife(IEntity entity)
        {
            entity.AddDamageableTag();
            entity.AddHealth(new ReactiveVariable<int>(_health));
            entity.AddBehaviour<DeathBehaviour>();
        }

        private void InstallMove(IEntity entity)
        {
            entity.AddMoveableTag();
            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));

            // entity.AddMoveSpeed(new ReactiveVariable<float>(_moveSpeed));
            entity.AddMoveCondition(new AndExpression(() => HealthUseCase.IsAlive(entity)));
            entity.AddMoveDirection(new ReactiveVector3());
            entity.AddBehaviour<MoveTowardsBehaviour>();
        }

        private void InstallCombat(IEntity entity)
        {
            entity.AddExtraDamage(new IntSumExpression());
            entity.AddFireEvent(new BaseEvent());
            entity.AddFireCondition(new AndExpression(
                    () => HealthUseCase.IsAlive(entity),
                    () =>
                    {
                        IEntity weapon = entity.GetCurrentWeapon().Value;
                        return weapon != null && weapon.GetFireCondition().Invoke();
                    },
                    () => entity.GetCurrentCar().Value == null
            ));

            entity.AddFireAction(new BaseAction(() =>
            {
                if (entity.GetFireCondition().Invoke())
                {
                    entity.GetCurrentWeapon().Value?.GetFireAction().Invoke();
                    entity.GetFireEvent().Invoke();
                }
            }));
        }
    }
}