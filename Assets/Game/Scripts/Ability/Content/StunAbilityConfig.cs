using Atomic.Elements;
using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "StunAbilityConfig",
        menuName = "SampleGame/Abilities/New StunAbilityConfig"
    )]
    public sealed class StunAbilityConfig : AbilityConfig
    {
        [SerializeField]
        private StunEffectConfig _effect;

        [SerializeField]
        private float _cooldown;

        [SerializeField]
        private int _initialCharges;

        [SerializeField]
        private KeyCode _keyCode;

        protected override void Install(Ability ability, IPlayerContext context)
        {
            ability.AddTargetTag();

            ability.AddTargetCondition(new BaseFunction<IEntity, bool>(target =>
                PlayersUseCase.IsEnemy(context, target) &&
                EffectUseCase.CanApply(target, _effect) &&
                ability.GetCooldown().IsExpired() &&
                ability.GetCharges().Value > 0
            ));

            ability.AddTargetAction(new BaseAction<IEntity>(target =>
            {
                EffectUseCase.Apply(target, _effect);
                ability.GetCooldown().Reset();
                ability.GetCharges().Value--;
            }));

            ability.AddTargetEvent(new BaseEvent<IEntity>());
            
            ability.AddCooldown(new Cooldown(_cooldown, 0));
            ability.AddCharges(new ReactiveInt(_initialCharges));
            
            ability.WhenFixedUpdate(ability.GetCooldown().Tick);
            ability.WhenUpdate(_ =>
            {
                if (Input.GetKey(_keyCode) && Input.GetMouseButtonDown(0) && 
                    RaycastUseCase.RaycastTarget(context, Input.mousePosition, out IEntity target))
                    AbilityUseCase.Use(ability, target);
            });
        }
    }
}