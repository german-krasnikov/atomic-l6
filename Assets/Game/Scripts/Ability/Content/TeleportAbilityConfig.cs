using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "TeleportAbilityConfig",
        menuName = "SampleGame/Abilities/New TeleportAbilityConfig"
    )]
    public sealed class TeleportAbilityConfig : AbilityConfig
    {
        [SerializeField]
        private Const<float> _radius;

        [SerializeField]
        private Const<int> _manaCost;

        [SerializeField]
        private KeyCode _keyCode = KeyCode.T;

        protected override void Install(Ability ability, IPlayerContext context)
        {
            ability.AddPointTag();
            ability.AddPointCondition(new BaseFunction<Vector3, bool>(point =>
                ManaUseCase.Enough(context, _manaCost.Value) &&
                VectorUseCase.LessOrEqualsDistance(context.GetCharacter(), point, _radius.Value)));

            ability.AddPointAction(new BaseAction<Vector3>(point =>
            {
                ManaUseCase.Spend(context, _manaCost.Value);
                context.GetCharacter().GetTransform().position = point;
            }));

            ability.AddPointEvent(new BaseEvent<Vector3>());

            ability.AddRadius(_radius);
            ability.AddManaCost(_manaCost);

            ability.WhenUpdate(_ =>
            {
                if (Input.GetKey(_keyCode) && Input.GetMouseButtonDown(0) &&
                    RaycastUseCase.RaycastGround(context, Input.mousePosition, out Vector3 point))
                    AbilityUseCase.Use(ability, point);
            });
        }
    }
}