using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class BulletInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private float _moveSpeed = 3;

        [SerializeField]
        private int _damage;
        
        [SerializeField]
        private TriggerEventReceiver _trigger;

        [SerializeField]
        private float _lifetime;

        [Header("Visual")]
        [SerializeField]
        private MeshRenderer _meshRenderer;

        [SerializeField]
        private Material _blueColor;
        
        [SerializeField]
        private Material _redColor;

        [SerializeField]
        private Material _neutralColor;


        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddTransform(this.transform);
            entity.AddGameObject(this.gameObject);
            entity.AddDamage(new ReactiveInt(_damage));
            
            entity.AddOwner(new ReactiveVariable<IEntity>());
            entity.AddPlayerId(new ReactiveVariable<PlayerId>());
            
            entity.AddLifetime(new Cooldown(_lifetime, _lifetime));
            entity.AddDestroyAction(new BaseAction(() => SpawnBulletUseCase.UnspawnBullet(gameContext, entity)));
            
            entity.AddMoveSpeed(new ReactiveFloat(_moveSpeed));
            entity.AddMoveDirection(new ReactiveVariable<Vector3>());
            entity.AddTrigger(_trigger);
            
            entity.AddBehaviour<BulletLifetimeBehaviour>();
            entity.AddBehaviour<MoveTowardsBehaviour>();
            entity.AddBehaviour<BulletCollisionBehaviour>();
            entity.AddBehaviour(new PlayerColorBehaviour(_meshRenderer, _blueColor, _redColor, _neutralColor));
        }
    }
}