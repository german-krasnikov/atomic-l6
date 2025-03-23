/**
* Code generation. Don't modify! 
**/

using Atomic.Contexts;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Contexts;
using Atomic.Entities;
using Atomic.Elements;
using System.Collections.Generic;

namespace SampleGame
{
	public static class PlayerContextAPI
	{


		///Values
		public const int PlayerId = 2073149053; // IValue<PlayerId>
		public const int Character = 294335127; // IEntity
		public const int CameraOffset = -1286660539; // IValue<Vector3>
		public const int Camera = 1018227507; // Camera
		public const int InputMap = 43340267; // InputMap
		public const int MaxMana = 1394248230; // IValue<int>
		public const int CurrentMana = 49250327; // IReactiveVariable<int>
		public const int Abilities = 986255111; // IReactiveDictionary<string, Ability>


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<PlayerId> GetPlayerId(this IPlayerContext obj) => obj.GetValue<IValue<PlayerId>>(PlayerId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerId(this IPlayerContext obj, out IValue<PlayerId> value) => obj.TryGetValue(PlayerId, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerId(this IPlayerContext obj, IValue<PlayerId> value) => obj.AddValue(PlayerId, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerId(this IPlayerContext obj) => obj.HasValue(PlayerId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerId(this IPlayerContext obj) => obj.DelValue(PlayerId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerId(this IPlayerContext obj, IValue<PlayerId> value) => obj.SetValue(PlayerId, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEntity GetCharacter(this IPlayerContext obj) => obj.GetValue<IEntity>(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IPlayerContext obj, out IEntity value) => obj.TryGetValue(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCharacter(this IPlayerContext obj, IEntity value) => obj.AddValue(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IPlayerContext obj) => obj.HasValue(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IPlayerContext obj) => obj.DelValue(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IPlayerContext obj, IEntity value) => obj.SetValue(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<Vector3> GetCameraOffset(this IPlayerContext obj) => obj.GetValue<IValue<Vector3>>(CameraOffset);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCameraOffset(this IPlayerContext obj, out IValue<Vector3> value) => obj.TryGetValue(CameraOffset, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCameraOffset(this IPlayerContext obj, IValue<Vector3> value) => obj.AddValue(CameraOffset, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCameraOffset(this IPlayerContext obj) => obj.HasValue(CameraOffset);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCameraOffset(this IPlayerContext obj) => obj.DelValue(CameraOffset);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCameraOffset(this IPlayerContext obj, IValue<Vector3> value) => obj.SetValue(CameraOffset, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Camera GetCamera(this IPlayerContext obj) => obj.GetValue<Camera>(Camera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCamera(this IPlayerContext obj, out Camera value) => obj.TryGetValue(Camera, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCamera(this IPlayerContext obj, Camera value) => obj.AddValue(Camera, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCamera(this IPlayerContext obj) => obj.HasValue(Camera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCamera(this IPlayerContext obj) => obj.DelValue(Camera);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCamera(this IPlayerContext obj, Camera value) => obj.SetValue(Camera, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static InputMap GetInputMap(this IPlayerContext obj) => obj.GetValue<InputMap>(InputMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInputMap(this IPlayerContext obj, out InputMap value) => obj.TryGetValue(InputMap, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInputMap(this IPlayerContext obj, InputMap value) => obj.AddValue(InputMap, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInputMap(this IPlayerContext obj) => obj.HasValue(InputMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInputMap(this IPlayerContext obj) => obj.DelValue(InputMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInputMap(this IPlayerContext obj, InputMap value) => obj.SetValue(InputMap, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<int> GetMaxMana(this IPlayerContext obj) => obj.GetValue<IValue<int>>(MaxMana);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxMana(this IPlayerContext obj, out IValue<int> value) => obj.TryGetValue(MaxMana, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaxMana(this IPlayerContext obj, IValue<int> value) => obj.AddValue(MaxMana, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxMana(this IPlayerContext obj) => obj.HasValue(MaxMana);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxMana(this IPlayerContext obj) => obj.DelValue(MaxMana);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxMana(this IPlayerContext obj, IValue<int> value) => obj.SetValue(MaxMana, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetCurrentMana(this IPlayerContext obj) => obj.GetValue<IReactiveVariable<int>>(CurrentMana);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentMana(this IPlayerContext obj, out IReactiveVariable<int> value) => obj.TryGetValue(CurrentMana, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentMana(this IPlayerContext obj, IReactiveVariable<int> value) => obj.AddValue(CurrentMana, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentMana(this IPlayerContext obj) => obj.HasValue(CurrentMana);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentMana(this IPlayerContext obj) => obj.DelValue(CurrentMana);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentMana(this IPlayerContext obj, IReactiveVariable<int> value) => obj.SetValue(CurrentMana, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveDictionary<string, Ability> GetAbilities(this IPlayerContext obj) => obj.GetValue<IReactiveDictionary<string, Ability>>(Abilities);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAbilities(this IPlayerContext obj, out IReactiveDictionary<string, Ability> value) => obj.TryGetValue(Abilities, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAbilities(this IPlayerContext obj, IReactiveDictionary<string, Ability> value) => obj.AddValue(Abilities, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAbilities(this IPlayerContext obj) => obj.HasValue(Abilities);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAbilities(this IPlayerContext obj) => obj.DelValue(Abilities);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAbilities(this IPlayerContext obj, IReactiveDictionary<string, Ability> value) => obj.SetValue(Abilities, value);
    }
}
