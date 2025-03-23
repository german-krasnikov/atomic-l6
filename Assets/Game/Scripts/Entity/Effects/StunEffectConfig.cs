using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "StunEffect",
        menuName = "SampleGame/Effects/New StunEffect"
    )]
    public sealed class StunEffectConfig : TemporaryEffectConfig
    {
        public override bool CanApply(in IEntity target) => true;

        protected override EffectInstance Create(in IEntity target) => new StunEffectInstance(this, target);
    }
}