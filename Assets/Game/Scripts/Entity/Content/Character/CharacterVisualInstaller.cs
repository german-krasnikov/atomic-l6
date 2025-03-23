using System;
using System.Collections.Generic;
using System.Linq;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterVisualInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private string _isMovingKey = "IsMoving";

        [SerializeField]
        private GameObject _weaponVisual;

        [SerializeField]
        private RuntimeAnimatorController _baseAnimController;

        [SerializeField]
        private RuntimeAnimatorController _weaponAnimController;

        [SerializeField]
        private EffectInfo[] _effects;
        
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            entity.AddBehaviour(new MoveAnimBehaviour(_isMovingKey));
            entity.AddBehaviour<FireAnimBehaviour>();
            entity.AddBehaviour(new CurrentWeaponVisualBehaviour(_weaponVisual));
            entity.AddBehaviour(new CurrentWeaponAnimBehaviour(_baseAnimController, _weaponAnimController));
            entity.AddBehaviour(new EffectVfxBehaviour(_effects.ToDictionary(it => it.config.Name, it => it.vfx)));
        }
        
        [Serializable]
        private struct EffectInfo
        {
            public EffectConfig config;
            public ParticleSystem vfx;
        }
    }
}