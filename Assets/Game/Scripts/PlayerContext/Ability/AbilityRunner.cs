using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

namespace SampleGame
{
    public sealed class AbilityRunner : 
        IContextInit<IPlayerContext>,
        IContextEnable,
        IContextDisable,
        IContextDispose,
        IContextUpdate,
        IContextFixedUpdate,
        IContextLateUpdate
    {
        private IReactiveDictionary<string, Ability> _abilityMap;

        private EntityRunner _entityRunner;

        public void Init(IPlayerContext context)
        {
            _abilityMap = context.GetAbilities();
            _entityRunner = new EntityRunner(_abilityMap.Values);
            _entityRunner.Init();

            _abilityMap.OnItemAdded += this.OnAbilityAdded;
            _abilityMap.OnItemRemoved += this.OnAbilityRemoved;
        }
        
        public void Dispose(IContext context)
        {
            _entityRunner.Dispose();
            
            _abilityMap.OnItemAdded -= this.OnAbilityAdded;
            _abilityMap.OnItemRemoved -= this.OnAbilityRemoved;
        }
        
        public void Enable(IContext context) => _entityRunner.Enable();
        public void OnUpdate(IContext context, float deltaTime) => _entityRunner.OnUpdate(deltaTime);

        public void OnFixedUpdate(IContext context, float deltaTime) => _entityRunner.OnFixedUpdate(deltaTime);
        public void OnLateUpdate(IContext context, float deltaTime) => _entityRunner.LateUpdate(deltaTime);
        public void Disable(IContext context) => _entityRunner.Disable();

        private void OnAbilityRemoved(string key, Ability ability) => _entityRunner.DelEntity(ability);
        private void OnAbilityAdded(string key, Ability ability) => _entityRunner.AddEntity(ability);
    }
}