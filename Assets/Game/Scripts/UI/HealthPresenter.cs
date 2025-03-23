using Atomic.Elements;
using Atomic.Entities;
using Atomic.Presenters;
using SampleGame;
using UnityEngine;

namespace Game.UI
{
    public sealed class HealthPresenter : Presenter
    {
        [SerializeField]
        private HealthView _view;

        [SerializeField]
        private PlayerId _playerId;
        
        private IEntity _character;

        protected override void OnInit()
        {
            GameContext gameContext = GameContext.Instance;
            _character = PlayersUseCase.GetCharacter(gameContext, _playerId);
        }

        protected override void OnShow()
        {
            _character.GetHealth().Observe(this.OnHealthChanged);
        }

        protected override void OnHide()
        {
            _character.GetHealth().Unsubscribe(this.OnHealthChanged);
        }

        private void OnHealthChanged(int health)
        {
            _view.SetValue($"Health: {health}");
        }
    }
}