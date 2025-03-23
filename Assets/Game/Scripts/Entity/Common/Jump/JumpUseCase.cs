using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public static class JumpUseCase
    {
        public static bool Jump(in IEntity character)
        {
            if (!character.HasJumpableTag())
                return false;

            if (!character.GetJumpCondition().Invoke())
                return false;

            float force = character.GetJumpForce().Value;
            character.GetRigidbody().AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
            character.GetJumpEvent().Invoke();
            return true;
        }
    }
}