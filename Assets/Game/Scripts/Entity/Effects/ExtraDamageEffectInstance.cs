using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class ExtraDamageEffectInstance : TemporaryEffectInstance
    {
        private readonly IValue<int> _damage;

        public ExtraDamageEffectInstance(ExtraDamageEffectConfig config, IEntity target) : base(config, target)
        {
            _damage = config.Damage;
            _target.GetExtraDamage().Append(_damage);
        }
        
        protected override void OnDispose()
        {
            _target.GetExtraDamage().Remove(_damage);
        }
    }
}