using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class EffectVfxBehaviour : IEntityInit, IEntityDispose
    {
        private readonly Dictionary<string, ParticleSystem> _vfxs;
        private IReactiveDictionary<string, EffectInstance> _effects;

        public EffectVfxBehaviour(Dictionary<string, ParticleSystem> vfxs)
        {
            _vfxs = vfxs;
        }

        public void Init(in IEntity entity)
        {
            _effects = entity.GetEffects();
            _effects.OnItemAdded += this.OnEffectAdded;
            _effects.OnItemRemoved += this.OnEffectRemoved;
            _effects.OnCleared += this.StopVfx;

            this.StartVfx();
        }

        public void Dispose(in IEntity entity)
        {
            _effects.OnItemAdded -= this.OnEffectAdded;
            _effects.OnItemRemoved -= this.OnEffectRemoved;
            _effects.OnCleared -= this.StopVfx;
            
            this.StopVfx();
        }

        private void OnEffectAdded(string key, EffectInstance value) => _vfxs[key].Play();

        private void OnEffectRemoved(string key, EffectInstance value) => _vfxs[key].Stop();

        private void StartVfx()
        {
            foreach (var key in _effects.Keys)
                _vfxs[key].Play();
        }
        
        private void StopVfx()
        {
            foreach (ParticleSystem vfx in _vfxs.Values) 
                vfx.Stop();
        }
    }
}