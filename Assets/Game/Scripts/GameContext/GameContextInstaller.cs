using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class GameContextInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField]
        private BulletSystemInstaller _bulletInstaller;

        [SerializeField]
        private Transform _worldTransform;

        [SerializeField]
        private Transform _poolTransform;

        protected override void Install(IGameContext context)
        {
            context.AddPlayers(new Dictionary<PlayerId, IPlayerContext>());
            context.AddWorldTransform(_worldTransform);
            context.AddEntityPool(new PrefabEntityPool(_poolTransform));
            
            _bulletInstaller.Install(context);
        }
    }
}