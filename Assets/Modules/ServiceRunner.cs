using Atomic.Contexts;
using SampleGame;

namespace Modules
{
    public sealed class ServiceRunner : IContextInit<IGameContext>, IContextUpdate
    {
        private Service _service;
        private float _acc;
        
        public void Init(IGameContext context)
        {
            _service = context.GetValue<Service>("Service");
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            _acc += deltaTime;
            if (_acc >= 1)
            {
                _service.Update(deltaTime);
                _acc -= 1;
            }
        }
    }
}