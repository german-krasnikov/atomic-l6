using System;
using Atomic.Contexts;

namespace SampleGame
{
    [Serializable]
    public sealed class CarSystemInstaller : IContextInstaller<IPlayerContext>
    {
        public void Install(IPlayerContext context)
        {
            context.AddController<CarExitController>();
            context.AddController<CarMoveController>();
        }
    }
}