using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class JumpEffectInstance : TemporaryEffectInstance
    {
        public JumpEffectInstance(JumpEffectConfig config, IEntity target) : base(config, target)
        {
            _target.AddJumpableTag();
            _target.AddJumpForce(config.Force);
            _target.AddJumpEvent(new BaseEvent());
            _target.AddJumpCondition(new BaseFunction<bool>(() => HealthUseCase.IsAlive(target)));
            _target.AddBehaviour<JumpAnimBehaviour>();
        }

        protected override void OnDispose()
        {
            _target.DelJumpableTag();
            _target.DelJumpForce();
            _target.DelJumpEvent();
            _target.DelJumpCondition();
            _target.DelBehaviour<JumpAnimBehaviour>();
        }
    }
}