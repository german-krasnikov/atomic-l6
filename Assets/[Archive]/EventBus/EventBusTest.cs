using Atomic.Events;
using SampleGame;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game
{
    public sealed class EventBusTest : MonoBehaviour
    {
        [SerializeField]
        private SceneEventBus _eventBus;

        [Button]
        public void Hello()
        {
            _eventBus.InvokeHello();
        }

        [Button]
        public void Attack(GameObject target)
        {
            _eventBus.InvokeAttack(target);
        }

        [Button]
        public void Move(Vector3 position, Quaternion rotation)
        {
            _eventBus.InvokeMove(position, rotation);
        }

        private void OnEnable()
        {
            _eventBus.SubscribeHello(this.OnHello);
            _eventBus.SubscribeAttack(this.OnAttack);
            _eventBus.SubscribeMove(this.OnMove);
        }

        private void OnDisable()
        {
            _eventBus.UnsubscribeHello(this.OnHello);
            _eventBus.UnsubscribeAttack(this.OnAttack);
            _eventBus.UnsubscribeMove(this.OnMove);
        }

        private void OnMove(Vector3 arg1, Quaternion arg2)
        {
            Debug.Log($"ON MOVE {arg1} {arg2}");
        }

        private void OnAttack(GameObject target)
        {
            Debug.Log($"{target.name}");
        }

        private void OnHello()
        {
            Debug.Log("On Hello");
        }
    }
}