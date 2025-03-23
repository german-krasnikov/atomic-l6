using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CurrentWeaponVisualBehaviour : IEntityInit, IEntityDispose
    {
        private readonly GameObject _weaponVisual;
        private IReactiveValue<IEntity> _currentWeapon;

        public CurrentWeaponVisualBehaviour(GameObject weaponVisual)
        {
            _weaponVisual = weaponVisual;
        }

        public void Init(in IEntity entity)
        {
            _currentWeapon = entity.GetCurrentWeapon();
            _currentWeapon.Observe(this.OnCurrentWeaponChanged);
        }

        public void Dispose(in IEntity entity)
        {
            _currentWeapon.Unsubscribe(this.OnCurrentWeaponChanged);
        }

        private void OnCurrentWeaponChanged(IEntity weapon)
        {
            _weaponVisual.SetActive(weapon != null);
        }
    }
}