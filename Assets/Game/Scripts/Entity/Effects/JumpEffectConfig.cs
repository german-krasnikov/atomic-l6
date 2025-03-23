using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "JumpEffectConfig",
        menuName = "SampleGame/Effects/New JumpEffectConfig"
    )]
    
    
    
    public sealed class JumpEffectConfig : TemporaryEffectConfig
    {
        [field: SerializeField]
        public Const<float> Force { get; private set; }
        
        public override bool CanApply(in IEntity target) =>
            !target.HasJumpableTag();

        protected override EffectInstance Create(in IEntity target) => 
            new JumpEffectInstance(this, target);
    }
}