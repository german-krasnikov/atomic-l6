using Atomic.Contexts;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class CharacterJumpController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        private IPlayerContext _context;

        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
            _context = context;
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            if (InputUseCase.IsJump(_context)) 
                JumpUseCase.Jump(_character);
        }
    }
}