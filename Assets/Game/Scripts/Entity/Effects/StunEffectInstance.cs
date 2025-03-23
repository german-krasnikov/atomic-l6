using Atomic.Elements;
using Atomic.Entities;
// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace SampleGame
{
    public sealed class StunEffectInstance : TemporaryEffectInstance
    {
        public StunEffectInstance(StunEffectConfig config, IEntity target) : base(config, target)
        {
            _target.GetMoveCondition().Append(Consts.False);
            _target.GetFireCondition().Append(Consts.False);
        }

        protected override void OnDispose()
        {
            _target.GetMoveCondition().Remove(Consts.False);
            _target.GetFireCondition().Remove(Consts.False);
        }
    }
}