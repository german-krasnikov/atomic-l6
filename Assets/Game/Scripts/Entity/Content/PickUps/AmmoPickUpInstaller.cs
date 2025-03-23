using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class AmmoPickUpInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _clips = 10;

        public override void Install(IEntity entity)
        {
            GameContext gameContext = GameContext.Instance;

            entity.AddTransform(this.transform);
            
            entity.AddInteractibleTag();
            entity.AddInteractAction(new BaseAction<IEntity>(character =>
            {
                if (CurrentWeaponUseCase.AddClips(character, _clips))
                    gameContext.GetEntityPool().Return(entity);
            }));
        }
    }
}