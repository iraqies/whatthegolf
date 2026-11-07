using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007FB")]
public class PongAI : MonoBehaviour
{
	[Token(Token = "0x20007FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41720", Offset = "0x41720")]
	private sealed class _003CUpdatePredictionBallCo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002AD1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002AD2")]
		[FieldOffset(Offset = "0x20")]
		public PongAI _003C_003E4__this;

		[Token(Token = "0x170003FE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60024A9")]
			[Address(RVA = "0x182A1A8", Offset = "0x182A1A8", VA = "0x182A1A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003FF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60024AB")]
			[Address(RVA = "0x182A1F0", Offset = "0x182A1F0", VA = "0x182A1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x1829FC4", Offset = "0x1829FC4", VA = "0x1829FC4")]
		[DebuggerHidden]
		public _003CUpdatePredictionBallCo_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x1829FF0", Offset = "0x1829FF0", VA = "0x1829FF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x1829FF4", Offset = "0x1829FF4", VA = "0x1829FF4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x182A1A8", Offset = "0x182A1A8", VA = "0x182A1A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x182A1B0", Offset = "0x182A1B0", VA = "0x182A1B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x182A1F0", Offset = "0x182A1F0", VA = "0x182A1F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002AC4")]
	[FieldOffset(Offset = "0x18")]
	public BreakoutBall ball;

	[Token(Token = "0x4002AC5")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D ballRb;

	[Token(Token = "0x4002AC6")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D predictionBall;

	[Token(Token = "0x4002AC7")]
	[FieldOffset(Offset = "0x30")]
	public float predictionBallSpeedScale;

	[Token(Token = "0x4002AC8")]
	[FieldOffset(Offset = "0x34")]
	public float minDistBeforeMove;

	[Token(Token = "0x4002AC9")]
	[FieldOffset(Offset = "0x38")]
	public float maxVel;

	[Token(Token = "0x4002ACA")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4002ACB")]
	[FieldOffset(Offset = "0x48")]
	public float yMin;

	[Token(Token = "0x4002ACC")]
	[FieldOffset(Offset = "0x4C")]
	public float yMax;

	[Token(Token = "0x4002ACD")]
	[FieldOffset(Offset = "0x50")]
	public float delayBeforePredictionUpdate;

	[Token(Token = "0x4002ACE")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine updatePredictionBall;

	[Token(Token = "0x4002ACF")]
	[FieldOffset(Offset = "0x60")]
	private bool stopped;

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x161981C", Offset = "0x161981C", VA = "0x161981C")]
	private void Start()
	{
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x161993C", Offset = "0x161993C", VA = "0x161993C")]
	private void UpdatePredictionBall()
	{
	}

	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x16199D4", Offset = "0x16199D4", VA = "0x16199D4")]
	private IEnumerator UpdatePredictionBallCo()
	{
		return null;
	}

	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x1619A48", Offset = "0x1619A48", VA = "0x1619A48")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x1619BE4", Offset = "0x1619BE4", VA = "0x1619BE4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x1619E18", Offset = "0x1619E18", VA = "0x1619E18")]
	public PongAI()
	{
	}
}
