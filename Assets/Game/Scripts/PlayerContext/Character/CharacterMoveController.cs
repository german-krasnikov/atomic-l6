using Atomic.Contexts;
using Atomic.Entities;

namespace SampleGame
{
    public class CharacterMoveController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        private IPlayerContext _context;

        public void Init(IPlayerContext context)
        {
            _context = context;
            _character = context.GetCharacter();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            _character.GetMoveDirection().Value = InputUseCase.GetMoveDirection(_context);
        }
    }
}