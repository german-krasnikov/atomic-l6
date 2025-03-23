using System;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace SampleGame
{
    [Serializable]
    public sealed class AbilitySystemInstaller : IContextInstaller<IPlayerContext>
    {
        // [SerializeField]
        // private DashAbilityConfig _dashAbilityConfig;
        //
        // [SerializeField]
        // private TeleportAbilityConfig _teleportAbilityConfig;
        //
        // [SerializeField]
        // private StunAbilityConfig _stunAbilityConfig; 

        [SerializeField]
        private AbilityConfig[] _abilities;


        public void Install(IPlayerContext context)
        {
            
            // context.AddDashAbility(_dashAbilityConfig.Create(context));
            // context.AddTeleportAbility(_teleportAbilityConfig.Create(context));
            // context.AddStunAbility(_stunAbilityConfig.Create(context));
            
            context.AddAbilities(this.CreateAbilities(context));
            context.AddController<AbilityRunner>();
        }

        private ReactiveDictionary<string, Ability> CreateAbilities(IPlayerContext context)
        {
            int length = _abilities.Length;
            var result = new ReactiveDictionary<string, Ability>(length);
            for (int i = 0; i < length; i++)
            {
                AbilityConfig config = _abilities[i];
                Ability ability = config.Create(context);
                result.Add(ability.Name, ability);
            }
            
            return result;
        }
    }
}


// [SerializeField]
// private KeyCode _keyCode = KeyCode.M;

// context.AddController(new UseDashAbilityController(_keyCode));
