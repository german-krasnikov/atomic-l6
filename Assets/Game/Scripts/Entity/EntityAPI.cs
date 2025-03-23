/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Entities;
using System;
using Atomic.Elements;
using Modules.Gameplay;
using Atomic.Extensions;

namespace SampleGame
{
	public static class EntityAPI
	{
		///Tags
		public const int Damageable = 563499515;
		public const int Moveable = 448011500;
		public const int Interactible = -2055148603;
		public const int Jumpable = 315505887;


		///Values
		public const int GameObject = 1482111001; // GameObject
		public const int Transform = -180157682; // Transform
		public const int Rigidbody = -2101481708; // Rigidbody
		public const int MoveSpeed = 526065662; // IReactiveVariable<float>
		public const int MoveCondition = 1466174948; // IExpression<bool>
		public const int MoveDirection = -721923052; // IReactiveVariable<Vector3>
		public const int ForwardDirection = -597461024; // IReactiveVariable<float>
		public const int AngularSpeed = -1089183267; // IValue<float>
		public const int AngularDirection = -1725439556; // IReactiveVariable<Vector3>
		public const int TurnDirection = 1232893390; // IReactiveVariable<float>
		public const int Health = -915003867; // IReactiveVariable<int>
		public const int Lifetime = -997109026; // Cooldown
		public const int DestroyAction = 85938956; // IAction
		public const int PlayerId = 2073149053; // IReactiveVariable<PlayerId>
		public const int CurrentWeapon = -205032771; // IReactiveVariable<IEntity>
		public const int Damage = 375673178; // IReactiveVariable<int>
		public const int ExtraDamage = -530877775; // IExpression<int>
		public const int Target = 1103309514; // IReactiveVariable<IEntity>
		public const int Ammo = 1337839892; // Ammo
		public const int PickUpPrefab = 1763436596; // SceneEntity
		public const int WeaponPrefab = 504707019; // SceneEntity
		public const int WeaponContainer = -1841125489; // Transform
		public const int FireCooldown = 695041130; // Cooldown
		public const int FirePoint = 397255013; // Transform
		public const int FireEvent = -1683597082; // IEvent
		public const int FireAction = 1186461126; // IAction
		public const int FireRequest = 1469079819; // IEvent
		public const int FireCondition = -280402907; // IExpression<bool>
		public const int JumpForce = 952989974; // IValue<float>
		public const int JumpCondition = -2140666110; // IFunction<bool>
		public const int JumpEvent = -1811156839; // IEvent
		public const int InteractAction = -1026843572; // IAction<IEntity>
		public const int TargetInteractible = 21081601; // IReactiveVariable<IEntity>
		public const int CarObject = 2019771698; // CarObject
		public const int ExitPoint = 862106911; // Transform
		public const int CurrentCar = -1813635903; // IReactiveVariable<IEntity>
		public const int Owner = 245483896; // IReactiveVariable<IEntity>
		public const int Effects = -2018114250; // IReactiveDictionary<string, EffectInstance>
		public const int Trigger = -707381567; // TriggerEventReceiver
		public const int Animator = -1714818978; // Animator


		///Tag Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamageableTag(this IEntity obj) => obj.HasTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamageableTag(this IEntity obj) => obj.AddTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamageableTag(this IEntity obj) => obj.DelTag(Damageable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveableTag(this IEntity obj) => obj.HasTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveableTag(this IEntity obj) => obj.AddTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveableTag(this IEntity obj) => obj.DelTag(Moveable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractibleTag(this IEntity obj) => obj.HasTag(Interactible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractibleTag(this IEntity obj) => obj.AddTag(Interactible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractibleTag(this IEntity obj) => obj.DelTag(Interactible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpableTag(this IEntity obj) => obj.HasTag(Jumpable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpableTag(this IEntity obj) => obj.AddTag(Jumpable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpableTag(this IEntity obj) => obj.DelTag(Jumpable);


		///Value Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject GetGameObject(this IEntity obj) => obj.GetValue<GameObject>(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetGameObject(this IEntity obj, out GameObject value) => obj.TryGetValue(GameObject, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddGameObject(this IEntity obj, GameObject value) => obj.AddValue(GameObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasGameObject(this IEntity obj) => obj.HasValue(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelGameObject(this IEntity obj) => obj.DelValue(GameObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetGameObject(this IEntity obj, GameObject value) => obj.SetValue(GameObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetTransform(this IEntity obj) => obj.GetValue<Transform>(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTransform(this IEntity obj, out Transform value) => obj.TryGetValue(Transform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTransform(this IEntity obj, Transform value) => obj.AddValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTransform(this IEntity obj) => obj.HasValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTransform(this IEntity obj) => obj.DelValue(Transform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTransform(this IEntity obj, Transform value) => obj.SetValue(Transform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rigidbody GetRigidbody(this IEntity obj) => obj.GetValue<Rigidbody>(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetRigidbody(this IEntity obj, out Rigidbody value) => obj.TryGetValue(Rigidbody, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddRigidbody(this IEntity obj, Rigidbody value) => obj.AddValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasRigidbody(this IEntity obj) => obj.HasValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelRigidbody(this IEntity obj) => obj.DelValue(Rigidbody);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetRigidbody(this IEntity obj, Rigidbody value) => obj.SetValue(Rigidbody, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetMoveSpeed(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveSpeed(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetMoveCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(MoveCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveCondition(this IEntity obj) => obj.HasValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveCondition(this IEntity obj) => obj.DelValue(MoveCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(MoveCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Vector3> GetMoveDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<Vector3>>(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveDirection(this IEntity obj, out IReactiveVariable<Vector3> value) => obj.TryGetValue(MoveDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMoveDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.AddValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.SetValue(MoveDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetForwardDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(ForwardDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetForwardDirection(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(ForwardDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddForwardDirection(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(ForwardDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasForwardDirection(this IEntity obj) => obj.HasValue(ForwardDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelForwardDirection(this IEntity obj) => obj.DelValue(ForwardDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetForwardDirection(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(ForwardDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetAngularSpeed(this IEntity obj) => obj.GetValue<IValue<float>>(AngularSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAngularSpeed(this IEntity obj, out IValue<float> value) => obj.TryGetValue(AngularSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAngularSpeed(this IEntity obj, IValue<float> value) => obj.AddValue(AngularSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAngularSpeed(this IEntity obj) => obj.HasValue(AngularSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAngularSpeed(this IEntity obj) => obj.DelValue(AngularSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAngularSpeed(this IEntity obj, IValue<float> value) => obj.SetValue(AngularSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<Vector3> GetAngularDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<Vector3>>(AngularDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAngularDirection(this IEntity obj, out IReactiveVariable<Vector3> value) => obj.TryGetValue(AngularDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAngularDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.AddValue(AngularDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAngularDirection(this IEntity obj) => obj.HasValue(AngularDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAngularDirection(this IEntity obj) => obj.DelValue(AngularDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAngularDirection(this IEntity obj, IReactiveVariable<Vector3> value) => obj.SetValue(AngularDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<float> GetTurnDirection(this IEntity obj) => obj.GetValue<IReactiveVariable<float>>(TurnDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTurnDirection(this IEntity obj, out IReactiveVariable<float> value) => obj.TryGetValue(TurnDirection, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTurnDirection(this IEntity obj, IReactiveVariable<float> value) => obj.AddValue(TurnDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTurnDirection(this IEntity obj) => obj.HasValue(TurnDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTurnDirection(this IEntity obj) => obj.DelValue(TurnDirection);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTurnDirection(this IEntity obj, IReactiveVariable<float> value) => obj.SetValue(TurnDirection, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetHealth(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHealth(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(Health, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddHealth(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(Health, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHealth(this IEntity obj) => obj.HasValue(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHealth(this IEntity obj) => obj.DelValue(Health);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHealth(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(Health, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Cooldown GetLifetime(this IEntity obj) => obj.GetValue<Cooldown>(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetLifetime(this IEntity obj, out Cooldown value) => obj.TryGetValue(Lifetime, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddLifetime(this IEntity obj, Cooldown value) => obj.AddValue(Lifetime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasLifetime(this IEntity obj) => obj.HasValue(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelLifetime(this IEntity obj) => obj.DelValue(Lifetime);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLifetime(this IEntity obj, Cooldown value) => obj.SetValue(Lifetime, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetDestroyAction(this IEntity obj) => obj.GetValue<IAction>(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDestroyAction(this IEntity obj, out IAction value) => obj.TryGetValue(DestroyAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDestroyAction(this IEntity obj, IAction value) => obj.AddValue(DestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDestroyAction(this IEntity obj) => obj.HasValue(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDestroyAction(this IEntity obj) => obj.DelValue(DestroyAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDestroyAction(this IEntity obj, IAction value) => obj.SetValue(DestroyAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<PlayerId> GetPlayerId(this IEntity obj) => obj.GetValue<IReactiveVariable<PlayerId>>(PlayerId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerId(this IEntity obj, out IReactiveVariable<PlayerId> value) => obj.TryGetValue(PlayerId, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerId(this IEntity obj, IReactiveVariable<PlayerId> value) => obj.AddValue(PlayerId, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerId(this IEntity obj) => obj.HasValue(PlayerId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerId(this IEntity obj) => obj.DelValue(PlayerId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerId(this IEntity obj, IReactiveVariable<PlayerId> value) => obj.SetValue(PlayerId, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetCurrentWeapon(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(CurrentWeapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentWeapon(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(CurrentWeapon, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentWeapon(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(CurrentWeapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentWeapon(this IEntity obj) => obj.HasValue(CurrentWeapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentWeapon(this IEntity obj) => obj.DelValue(CurrentWeapon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentWeapon(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(CurrentWeapon, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<int> GetDamage(this IEntity obj) => obj.GetValue<IReactiveVariable<int>>(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetDamage(this IEntity obj, out IReactiveVariable<int> value) => obj.TryGetValue(Damage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddDamage(this IEntity obj, IReactiveVariable<int> value) => obj.AddValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetDamage(this IEntity obj, IReactiveVariable<int> value) => obj.SetValue(Damage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<int> GetExtraDamage(this IEntity obj) => obj.GetValue<IExpression<int>>(ExtraDamage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetExtraDamage(this IEntity obj, out IExpression<int> value) => obj.TryGetValue(ExtraDamage, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddExtraDamage(this IEntity obj, IExpression<int> value) => obj.AddValue(ExtraDamage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasExtraDamage(this IEntity obj) => obj.HasValue(ExtraDamage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelExtraDamage(this IEntity obj) => obj.DelValue(ExtraDamage);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetExtraDamage(this IEntity obj, IExpression<int> value) => obj.SetValue(ExtraDamage, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetTarget(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTarget(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(Target, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTarget(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTarget(this IEntity obj) => obj.HasValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTarget(this IEntity obj) => obj.DelValue(Target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTarget(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(Target, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Ammo GetAmmo(this IEntity obj) => obj.GetValue<Ammo>(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAmmo(this IEntity obj, out Ammo value) => obj.TryGetValue(Ammo, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAmmo(this IEntity obj, Ammo value) => obj.AddValue(Ammo, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAmmo(this IEntity obj) => obj.HasValue(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAmmo(this IEntity obj) => obj.DelValue(Ammo);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAmmo(this IEntity obj, Ammo value) => obj.SetValue(Ammo, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SceneEntity GetPickUpPrefab(this IEntity obj) => obj.GetValue<SceneEntity>(PickUpPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickUpPrefab(this IEntity obj, out SceneEntity value) => obj.TryGetValue(PickUpPrefab, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPickUpPrefab(this IEntity obj, SceneEntity value) => obj.AddValue(PickUpPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickUpPrefab(this IEntity obj) => obj.HasValue(PickUpPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickUpPrefab(this IEntity obj) => obj.DelValue(PickUpPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickUpPrefab(this IEntity obj, SceneEntity value) => obj.SetValue(PickUpPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SceneEntity GetWeaponPrefab(this IEntity obj) => obj.GetValue<SceneEntity>(WeaponPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponPrefab(this IEntity obj, out SceneEntity value) => obj.TryGetValue(WeaponPrefab, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponPrefab(this IEntity obj, SceneEntity value) => obj.AddValue(WeaponPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponPrefab(this IEntity obj) => obj.HasValue(WeaponPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponPrefab(this IEntity obj) => obj.DelValue(WeaponPrefab);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponPrefab(this IEntity obj, SceneEntity value) => obj.SetValue(WeaponPrefab, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetWeaponContainer(this IEntity obj) => obj.GetValue<Transform>(WeaponContainer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWeaponContainer(this IEntity obj, out Transform value) => obj.TryGetValue(WeaponContainer, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWeaponContainer(this IEntity obj, Transform value) => obj.AddValue(WeaponContainer, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWeaponContainer(this IEntity obj) => obj.HasValue(WeaponContainer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWeaponContainer(this IEntity obj) => obj.DelValue(WeaponContainer);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWeaponContainer(this IEntity obj, Transform value) => obj.SetValue(WeaponContainer, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Cooldown GetFireCooldown(this IEntity obj) => obj.GetValue<Cooldown>(FireCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireCooldown(this IEntity obj, out Cooldown value) => obj.TryGetValue(FireCooldown, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireCooldown(this IEntity obj, Cooldown value) => obj.AddValue(FireCooldown, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireCooldown(this IEntity obj) => obj.HasValue(FireCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireCooldown(this IEntity obj) => obj.DelValue(FireCooldown);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireCooldown(this IEntity obj, Cooldown value) => obj.SetValue(FireCooldown, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetFirePoint(this IEntity obj) => obj.GetValue<Transform>(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFirePoint(this IEntity obj, out Transform value) => obj.TryGetValue(FirePoint, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFirePoint(this IEntity obj, Transform value) => obj.AddValue(FirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFirePoint(this IEntity obj) => obj.HasValue(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFirePoint(this IEntity obj) => obj.DelValue(FirePoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFirePoint(this IEntity obj, Transform value) => obj.SetValue(FirePoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetFireEvent(this IEntity obj) => obj.GetValue<IEvent>(FireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(FireEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireEvent(this IEntity obj, IEvent value) => obj.AddValue(FireEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireEvent(this IEntity obj) => obj.HasValue(FireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireEvent(this IEntity obj) => obj.DelValue(FireEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireEvent(this IEntity obj, IEvent value) => obj.SetValue(FireEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction GetFireAction(this IEntity obj) => obj.GetValue<IAction>(FireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireAction(this IEntity obj, out IAction value) => obj.TryGetValue(FireAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireAction(this IEntity obj, IAction value) => obj.AddValue(FireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireAction(this IEntity obj) => obj.HasValue(FireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireAction(this IEntity obj) => obj.DelValue(FireAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireAction(this IEntity obj, IAction value) => obj.SetValue(FireAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetFireRequest(this IEntity obj) => obj.GetValue<IEvent>(FireRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(FireRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireRequest(this IEntity obj, IEvent value) => obj.AddValue(FireRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireRequest(this IEntity obj) => obj.HasValue(FireRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireRequest(this IEntity obj) => obj.DelValue(FireRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireRequest(this IEntity obj, IEvent value) => obj.SetValue(FireRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IExpression<bool> GetFireCondition(this IEntity obj) => obj.GetValue<IExpression<bool>>(FireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFireCondition(this IEntity obj, out IExpression<bool> value) => obj.TryGetValue(FireCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddFireCondition(this IEntity obj, IExpression<bool> value) => obj.AddValue(FireCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFireCondition(this IEntity obj) => obj.HasValue(FireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFireCondition(this IEntity obj) => obj.DelValue(FireCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFireCondition(this IEntity obj, IExpression<bool> value) => obj.SetValue(FireCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetJumpForce(this IEntity obj) => obj.GetValue<IValue<float>>(JumpForce);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetJumpForce(this IEntity obj, out IValue<float> value) => obj.TryGetValue(JumpForce, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpForce(this IEntity obj, IValue<float> value) => obj.AddValue(JumpForce, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpForce(this IEntity obj) => obj.HasValue(JumpForce);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpForce(this IEntity obj) => obj.DelValue(JumpForce);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetJumpForce(this IEntity obj, IValue<float> value) => obj.SetValue(JumpForce, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IFunction<bool> GetJumpCondition(this IEntity obj) => obj.GetValue<IFunction<bool>>(JumpCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetJumpCondition(this IEntity obj, out IFunction<bool> value) => obj.TryGetValue(JumpCondition, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpCondition(this IEntity obj, IFunction<bool> value) => obj.AddValue(JumpCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpCondition(this IEntity obj) => obj.HasValue(JumpCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpCondition(this IEntity obj) => obj.DelValue(JumpCondition);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetJumpCondition(this IEntity obj, IFunction<bool> value) => obj.SetValue(JumpCondition, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEvent GetJumpEvent(this IEntity obj) => obj.GetValue<IEvent>(JumpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetJumpEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(JumpEvent, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddJumpEvent(this IEntity obj, IEvent value) => obj.AddValue(JumpEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasJumpEvent(this IEntity obj) => obj.HasValue(JumpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelJumpEvent(this IEntity obj) => obj.DelValue(JumpEvent);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetJumpEvent(this IEntity obj, IEvent value) => obj.SetValue(JumpEvent, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IAction<IEntity> GetInteractAction(this IEntity obj) => obj.GetValue<IAction<IEntity>>(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetInteractAction(this IEntity obj, out IAction<IEntity> value) => obj.TryGetValue(InteractAction, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddInteractAction(this IEntity obj, IAction<IEntity> value) => obj.AddValue(InteractAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasInteractAction(this IEntity obj) => obj.HasValue(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelInteractAction(this IEntity obj) => obj.DelValue(InteractAction);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetInteractAction(this IEntity obj, IAction<IEntity> value) => obj.SetValue(InteractAction, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetTargetInteractible(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(TargetInteractible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTargetInteractible(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(TargetInteractible, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTargetInteractible(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(TargetInteractible, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTargetInteractible(this IEntity obj) => obj.HasValue(TargetInteractible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTargetInteractible(this IEntity obj) => obj.DelValue(TargetInteractible);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTargetInteractible(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(TargetInteractible, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static CarObject GetCarObject(this IEntity obj) => obj.GetValue<CarObject>(CarObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCarObject(this IEntity obj, out CarObject value) => obj.TryGetValue(CarObject, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCarObject(this IEntity obj, CarObject value) => obj.AddValue(CarObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCarObject(this IEntity obj) => obj.HasValue(CarObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCarObject(this IEntity obj) => obj.DelValue(CarObject);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCarObject(this IEntity obj, CarObject value) => obj.SetValue(CarObject, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetExitPoint(this IEntity obj) => obj.GetValue<Transform>(ExitPoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetExitPoint(this IEntity obj, out Transform value) => obj.TryGetValue(ExitPoint, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddExitPoint(this IEntity obj, Transform value) => obj.AddValue(ExitPoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasExitPoint(this IEntity obj) => obj.HasValue(ExitPoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelExitPoint(this IEntity obj) => obj.DelValue(ExitPoint);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetExitPoint(this IEntity obj, Transform value) => obj.SetValue(ExitPoint, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetCurrentCar(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(CurrentCar);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentCar(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(CurrentCar, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentCar(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(CurrentCar, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentCar(this IEntity obj) => obj.HasValue(CurrentCar);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentCar(this IEntity obj) => obj.DelValue(CurrentCar);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentCar(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(CurrentCar, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveVariable<IEntity> GetOwner(this IEntity obj) => obj.GetValue<IReactiveVariable<IEntity>>(Owner);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetOwner(this IEntity obj, out IReactiveVariable<IEntity> value) => obj.TryGetValue(Owner, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddOwner(this IEntity obj, IReactiveVariable<IEntity> value) => obj.AddValue(Owner, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasOwner(this IEntity obj) => obj.HasValue(Owner);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelOwner(this IEntity obj) => obj.DelValue(Owner);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetOwner(this IEntity obj, IReactiveVariable<IEntity> value) => obj.SetValue(Owner, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IReactiveDictionary<string, EffectInstance> GetEffects(this IEntity obj) => obj.GetValue<IReactiveDictionary<string, EffectInstance>>(Effects);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEffects(this IEntity obj, out IReactiveDictionary<string, EffectInstance> value) => obj.TryGetValue(Effects, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEffects(this IEntity obj, IReactiveDictionary<string, EffectInstance> value) => obj.AddValue(Effects, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEffects(this IEntity obj) => obj.HasValue(Effects);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEffects(this IEntity obj) => obj.DelValue(Effects);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEffects(this IEntity obj, IReactiveDictionary<string, EffectInstance> value) => obj.SetValue(Effects, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TriggerEventReceiver GetTrigger(this IEntity obj) => obj.GetValue<TriggerEventReceiver>(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTrigger(this IEntity obj, out TriggerEventReceiver value) => obj.TryGetValue(Trigger, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddTrigger(this IEntity obj, TriggerEventReceiver value) => obj.AddValue(Trigger, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTrigger(this IEntity obj) => obj.HasValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTrigger(this IEntity obj) => obj.DelValue(Trigger);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTrigger(this IEntity obj, TriggerEventReceiver value) => obj.SetValue(Trigger, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Animator GetAnimator(this IEntity obj) => obj.GetValue<Animator>(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetAnimator(this IEntity obj, out Animator value) => obj.TryGetValue(Animator, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddAnimator(this IEntity obj, Animator value) => obj.AddValue(Animator, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAnimator(this IEntity obj) => obj.HasValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelAnimator(this IEntity obj) => obj.DelValue(Animator);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAnimator(this IEntity obj, Animator value) => obj.SetValue(Animator, value);
    }
}
