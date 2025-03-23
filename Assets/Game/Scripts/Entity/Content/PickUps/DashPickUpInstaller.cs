using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class DashPickUpInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _charges;
        
        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddTransform(this.transform);
            entity.AddGameObject(this.gameObject);
            
            entity.AddInteractibleTag();
            entity.AddInteractAction(new BaseAction<IEntity>(character =>
            {
                IPlayerContext context = PlayersUseCase.GetPlayerContext(gameContext, character);
                // context.GetDashAbility().GetCharges().Value += _charges;
                gameContext.GetEntityPool().Return(entity);
            }));
        }
    }
}
