/**
* Code generation. Don't modify! 
**/

using Atomic.Events;
using System.Runtime.CompilerServices;
using UnityEngine;
using Atomic.Events;
using System;

namespace SampleGame
{
	public static class EventAPI
	{
		///Events
		public const int Hello = -137262718;
		public const int Attack = 1080829965;
		public const int Move = 1326225478;


		///Event Extensions

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsHelloDeclared(this IEventBus bus) => bus.IsDefined(Hello);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool UndeclareHello(this IEventBus bus) => bus.Undef(Hello);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DeclareHello(this IEventBus bus) => bus.Def(Hello);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Action SubscribeHello(this IEventBus bus, Action action) => bus.Subscribe(Hello, action);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnsubscribeHello(this IEventBus bus, Action action) => bus.Unsubscribe(Hello, action);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InvokeHello(this IEventBus bus) => bus.Invoke(Hello);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsAttackDeclared(this IEventBus bus) => bus.IsDefined(Attack);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool UndeclareAttack(this IEventBus bus) => bus.Undef(Attack);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DeclareAttack(this IEventBus bus) => bus.Def<GameObject>(Attack);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Action<GameObject> SubscribeAttack(this IEventBus bus, Action<GameObject> action) => bus.Subscribe(Attack, action);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnsubscribeAttack(this IEventBus bus, Action<GameObject> action) => bus.Unsubscribe(Attack, action);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InvokeAttack(this IEventBus bus, GameObject target) => bus.Invoke(Attack, target);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsMoveDeclared(this IEventBus bus) => bus.IsDefined(Move);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool UndeclareMove(this IEventBus bus) => bus.Undef(Move);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DeclareMove(this IEventBus bus) => bus.Def<Vector3, Quaternion>(Move);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Action<Vector3, Quaternion> SubscribeMove(this IEventBus bus, Action<Vector3, Quaternion> action) => bus.Subscribe(Move, action);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnsubscribeMove(this IEventBus bus, Action<Vector3, Quaternion> action) => bus.Unsubscribe(Move, action);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InvokeMove(this IEventBus bus, Vector3 position, Quaternion rotation) => bus.Invoke(Move, position, rotation);
    }
}
