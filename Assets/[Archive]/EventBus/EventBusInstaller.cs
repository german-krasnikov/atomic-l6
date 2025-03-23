using Atomic.Events;
using SampleGame;

namespace Game
{
    public sealed class EventBusInstaller : SceneEventBusInstaller
    {
        public override void Install(IEventBus bus)
        {
            bus.DeclareHello();
            bus.DeclareAttack();
            bus.DeclareMove();
        }
    }
}