using Atomic.Elements;
using Atomic.Entities;
using Atomic.Extensions;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "JumpAspect",
        menuName = "SampleGame/Aspects/New JumpAspect"
    )]
    public sealed class JumpAspect : ScriptableEntityAspect
    {
        [SerializeField]
        private Const<float> _force = 5;
        
        public override void Apply(IEntity entity)
        {
            entity.AddJumpableTag();
            entity.AddJumpCondition(new BaseFunction<bool>(() => HealthUseCase.IsAlive(entity)));
            entity.AddJumpForce(_force);
            entity.AddJumpEvent(new BaseEvent());
            entity.AddBehaviour<JumpAnimBehaviour>();
        }

        public override void Discard(IEntity entity)
        {
            entity.DelJumpableTag();
            entity.DelJumpCondition();
            entity.DelJumpForce();
            entity.DelJumpEvent();
            entity.DelBehaviour<JumpAnimBehaviour>();
        }
    }
}