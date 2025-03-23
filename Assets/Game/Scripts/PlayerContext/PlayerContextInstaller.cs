using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace SampleGame
{
    public sealed class PlayerContextInstaller : SceneContextInstaller<IPlayerContext>
    {
        [SerializeField]
        private CharacterSystemInstaller _characterInstaller;

        [SerializeField]
        private CameraSystemInstaller _cameraInstaller;

        [SerializeField]
        private CarSystemInstaller _carInstaller;

        [SerializeField]
        private ManaSystemInstaller _manaSystemInstaller;

        [SerializeField]
        private AbilitySystemInstaller _abilityInstaller;

        [SerializeField]
        private InputMap _inputMap;

        [SerializeField]
        private PlayerId _playerId;
        
        protected override void Install(IPlayerContext context)
        {
            context.AddInputMap(_inputMap);
            context.AddPlayerId(new Const<PlayerId>(_playerId));

            _characterInstaller.Install(context);
            _cameraInstaller.Install(context);
            _carInstaller.Install(context);
            _manaSystemInstaller.Install(context);
            _abilityInstaller.Install(context);

            if (IsPlayMode())
            {
                GameContext gameContext = GameContext.Instance;
                gameContext.GetPlayers().Add(_playerId, context);
            }
        }
    }
}