using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000816")]
public class RouletteLevel : MonoBehaviour
{
	[Token(Token = "0x2000817")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x417A0", Offset = "0x417A0")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x10")]
		public bool didShoot;

		[Token(Token = "0x6002529")]
		[Address(RVA = "0x183640C", Offset = "0x183640C", VA = "0x183640C")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600252A")]
		[Address(RVA = "0x1836414", Offset = "0x1836414", VA = "0x1836414")]
		internal void _003CStart_003Eb__0(Vector3 boost)
		{
		}
	}

	[Token(Token = "0x2000818")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x417B0", Offset = "0x417B0")]
	private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x20")]
		public RouletteLevel _003C_003E4__this;

		[Token(Token = "0x4002B8C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x17000408")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x18366FC", Offset = "0x18366FC", VA = "0x18366FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000409")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002530")]
			[Address(RVA = "0x1836744", Offset = "0x1836744", VA = "0x1836744", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600252B")]
		[Address(RVA = "0x1836420", Offset = "0x1836420", VA = "0x1836420")]
		[DebuggerHidden]
		public _003CStart_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600252C")]
		[Address(RVA = "0x183644C", Offset = "0x183644C", VA = "0x183644C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600252D")]
		[Address(RVA = "0x1836450", Offset = "0x1836450", VA = "0x1836450", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600252E")]
		[Address(RVA = "0x18366FC", Offset = "0x18366FC", VA = "0x18366FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600252F")]
		[Address(RVA = "0x1836704", Offset = "0x1836704", VA = "0x1836704", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002530")]
		[Address(RVA = "0x1836744", Offset = "0x1836744", VA = "0x1836744", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002B84")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController golfBallController;

	[Token(Token = "0x4002B85")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallShooterBase golfBallShooter;

	[Token(Token = "0x4002B86")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody golfBallPrefab;

	[Token(Token = "0x4002B87")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform golfBallSpawnPosition;

	[Token(Token = "0x6002527")]
	[Address(RVA = "0x1661A2C", Offset = "0x1661A2C", VA = "0x1661A2C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0x1661AA0", Offset = "0x1661AA0", VA = "0x1661AA0")]
	public RouletteLevel()
	{
	}
}
