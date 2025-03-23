using UnityEngine;

namespace SampleGame
{
    [CreateAssetMenu(
        fileName = "InputMap",
        menuName = "SampleGame/New InputMap"
    )]
    public sealed class InputMap : ScriptableObject
    {
        [field: SerializeField]
        public KeyCode MoveLeft { get; private set; } = KeyCode.LeftArrow;

        [field: SerializeField]
        public KeyCode MoveRight { get; private set; } = KeyCode.RightArrow;

        [field: SerializeField]
        public KeyCode MoveForward { get; private set; } = KeyCode.UpArrow;

        [field: SerializeField]
        public KeyCode MoveBack { get; private set; } = KeyCode.DownArrow;

        [field: SerializeField]
        public KeyCode Fire { get; private set; } = KeyCode.Space;

        [field: SerializeField]
        public KeyCode Jump { get; private set; } = KeyCode.J;
        
        [field: SerializeField]
        public KeyCode Interact { get; private set; } = KeyCode.E;

        [field: SerializeField]
        public KeyCode Drop { get; private set; } = KeyCode.Q;
        
        [field: SerializeField]
        public KeyCode ExitCar { get; private set; } = KeyCode.Q;
    }
}