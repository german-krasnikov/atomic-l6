using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "DamageAspect",
        menuName = "SampleGame/Aspects/New DamageAspect"
    )]
    public sealed class ExtraDamageAspect : ScriptableEntityAspect
    {
        [SerializeField]
        private Const<int> _damage;

        public override void Apply(IEntity entity)
        {
            if (entity.TryGetExtraDamage(out IExpression<int> damage))
                damage.Append(_damage);
        }

        public override void Discard(IEntity entity)
        {
            if (entity.TryGetExtraDamage(out IExpression<int> damage))
                damage.Remove(_damage);
        }
    }
}