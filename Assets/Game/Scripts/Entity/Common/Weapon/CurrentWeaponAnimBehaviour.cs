using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CurrentWeaponAnimBehaviour : IEntityInit, IEntityDispose
    {
        private Animator _animator;
        private readonly RuntimeAnimatorController _idle;
        private readonly RuntimeAnimatorController _weapon;
        
        private IReactiveValue<IEntity> _currentWeapon;

        public CurrentWeaponAnimBehaviour(RuntimeAnimatorController idle, RuntimeAnimatorController weapon)
        {
            _idle = idle;
            _weapon = weapon;
        }

        public void Init(in IEntity entity)
        {
            _animator = entity.GetAnimator();
            _currentWeapon = entity.GetCurrentWeapon();
            _currentWeapon.Observe(this.OnCurrentWeaponChanged);
        }

        public void Dispose(in IEntity entity)
        {
            _currentWeapon.Unsubscribe(this.OnCurrentWeaponChanged);
        }

        private void OnCurrentWeaponChanged(IEntity weapon)
        {
            _animator.runtimeAnimatorController = weapon != null ? _weapon : _idle;
        }
    }
}