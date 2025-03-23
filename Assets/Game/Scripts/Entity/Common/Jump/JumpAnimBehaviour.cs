using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class JumpAnimBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int Jump = Animator.StringToHash("Jump");

        private Animator _animator;
        private IReactive _jumpEvent;

        public void Init(in IEntity entity)
        {
            _animator = entity.GetAnimator();
            _jumpEvent = entity.GetJumpEvent();
            _jumpEvent.Subscribe(this.OnJump);
        }

        public void Dispose(in IEntity entity)
        {
            _jumpEvent.Unsubscribe(this.OnJump);
        }

        private void OnJump()
        {
            _animator.SetTrigger(Jump);
        }
    }
}