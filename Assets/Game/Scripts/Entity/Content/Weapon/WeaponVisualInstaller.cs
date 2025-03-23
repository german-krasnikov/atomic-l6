using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class WeaponVisualInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private ParticleSystem _fireVfx;

        [SerializeField]
        private AudioSource _audioSource;
        
        public override void Install(IEntity entity)
        {
            entity.GetFireEvent().Subscribe(() =>
            {
                _fireVfx.Play();
                _audioSource.Play();
            });
        }
    }
}