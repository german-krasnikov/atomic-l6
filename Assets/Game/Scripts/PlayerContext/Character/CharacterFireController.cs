using Atomic.Contexts;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class CharacterFireController : IContextInit<IPlayerContext>, IContextUpdate
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
            if (InputUseCase.IsFire(_context))
                _character.GetFireAction().Invoke();
        }
    }
}