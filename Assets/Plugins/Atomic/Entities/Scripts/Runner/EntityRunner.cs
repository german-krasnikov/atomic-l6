using System;
using System.Collections.Generic;
using UnityEngine;

namespace Atomic.Entities
{
    public sealed class EntityRunner
    {
        private readonly List<IEntity> _entities;
        private readonly List<IEntity> _cache = new();

        public bool IsInitialized => _initialized;
        public bool IsEnabled => _enabled;

        private bool _initialized;
        private bool _enabled;

        public EntityRunner()
        {
            _entities = new List<IEntity>();
        }

        public EntityRunner(IEnumerable<IEntity> entities)
        {
            _entities = new List<IEntity>(entities);
        }

        public void Init()
        {
            if (_initialized)
            {
                Debug.LogWarning("Entity Runner is already initialized!");
                return;
            }

            _initialized = true;
            
            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].Init();
        }

        public void Dispose()
        {
            if (_enabled)
                this.Disable();

            if (!_initialized)
            {
                Debug.LogWarning("Entity Runner is already disposed!");
                return;
            }

            _initialized = false;
            
            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].Dispose();
        }

        public void Enable()
        {
            if (!_initialized)
                this.Init();

            if (_enabled)
            {
                Debug.LogWarning("Entity Runner is already enabled!");
                return;
            }

            _enabled = true;
            
            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].Enable();
        }

        public void Disable()
        {
            if (!_enabled)
            {
                Debug.LogWarning("Entity Runner is already disabled!");
                return;
            }

            _enabled = false;
            
            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].Disable();
        }

        public void OnUpdate(in float deltaTime)
        {
            if (!_enabled)
            {
                Debug.LogWarning("Update failed! Entity Runner is not enabled!");
                return;
            }

            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].OnUpdate(deltaTime);
        }

        public void OnFixedUpdate(in float deltaTime)
        {
            if (!_enabled)
            {
                Debug.LogWarning("Fixed update failed! Entity Runner is not enabled!");
                return;
            }

            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].OnFixedUpdate(deltaTime);
        }

        public void LateUpdate(in float deltaTime)
        {
            if (!_enabled)
            {
                Debug.LogWarning("Late update failed! Entity Runner is not enabled!");
                return;
            }

            int count = _entities.Count;
            if (count == 0)
                return;

            _cache.Clear();
            _cache.AddRange(_entities);

            for (int i = 0; i < count; i++)
                _cache[i].OnLateUpdate(deltaTime);
        }

        public bool AddEntity(in IEntity entity)
        {
            if (entity == null)
                return false;

            if (_entities.Contains(entity))
                return false;

            _entities.Add(entity);

            if (_initialized) entity.Init();
            if (_enabled) entity.Enable();

            return true;
        }

        public bool DelEntity(in IEntity entity)
        {
            if (entity == null)
                return false;

            if (!_entities.Remove(entity))
                return false;

            if (_enabled) entity.Disable();
            if (_initialized) entity.Dispose();

            return true;
        }
    }
}