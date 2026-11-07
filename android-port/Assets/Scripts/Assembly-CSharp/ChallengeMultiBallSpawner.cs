using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000446")]
public class ChallengeMultiBallSpawner : MonoBehaviour
{
	[Token(Token = "0x2000447")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FABC", Offset = "0x3FABC")]
	private sealed class _003CWaitAndSpawn_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001751")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001752")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001753")]
		[FieldOffset(Offset = "0x20")]
		public ChallengeMultiBallSpawner _003C_003E4__this;

		[Token(Token = "0x1700023A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001414")]
			[Address(RVA = "0x17831E0", Offset = "0x17831E0", VA = "0x17831E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700023B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001416")]
			[Address(RVA = "0x1783228", Offset = "0x1783228", VA = "0x1783228", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001411")]
		[Address(RVA = "0x1783080", Offset = "0x1783080", VA = "0x1783080")]
		[DebuggerHidden]
		public _003CWaitAndSpawn_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001412")]
		[Address(RVA = "0x17830AC", Offset = "0x17830AC", VA = "0x17830AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001413")]
		[Address(RVA = "0x17830B0", Offset = "0x17830B0", VA = "0x17830B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0x17831E0", Offset = "0x17831E0", VA = "0x17831E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001415")]
		[Address(RVA = "0x17831E8", Offset = "0x17831E8", VA = "0x17831E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001416")]
		[Address(RVA = "0x1783228", Offset = "0x1783228", VA = "0x1783228", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController controller;

	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x20")]
	private GolfBallController _currentController;

	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x28")]
	public int maxSpawn;

	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x30")]
	private List<GolfBallController> _spawnedBalls;

	[Token(Token = "0x600140C")]
	[Address(RVA = "0x1894C50", Offset = "0x1894C50", VA = "0x1894C50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600140D")]
	[Address(RVA = "0x1894F50", Offset = "0x1894F50", VA = "0x1894F50")]
	private void ControllerOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600140E")]
	[Address(RVA = "0x18950B8", Offset = "0x18950B8", VA = "0x18950B8")]
	private IEnumerator WaitAndSpawn()
	{
		return null;
	}

	[Token(Token = "0x600140F")]
	[Address(RVA = "0x1894D2C", Offset = "0x1894D2C", VA = "0x1894D2C")]
	private GolfBallController InstantiateGolfBall()
	{
		return null;
	}

	[Token(Token = "0x6001410")]
	[Address(RVA = "0x189512C", Offset = "0x189512C", VA = "0x189512C")]
	public ChallengeMultiBallSpawner()
	{
	}
}
