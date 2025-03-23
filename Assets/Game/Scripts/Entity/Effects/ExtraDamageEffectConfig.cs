using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "ExtraDamageEffect",
        menuName = "SampleGame/Effects/New ExtraDamageEffect"
    )]
    public sealed class ExtraDamageEffectConfig : TemporaryEffectConfig
    {
        [field: SerializeField]
        public Const<int> Damage { get; private set; }
        
        public override bool CanApply(in IEntity target) => target.HasExtraDamage();
        
        protected override EffectInstance Create(in IEntity target) => new ExtraDamageEffectInstance(this, target);
    }
}