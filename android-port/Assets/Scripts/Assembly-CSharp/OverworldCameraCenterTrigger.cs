using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009F3")]
public class OverworldCameraCenterTrigger : MonoBehaviour
{
	[Token(Token = "0x20009F4")]
	public enum BlendType
	{
		[Token(Token = "0x40036DC")]
		distanceFromCollider = 0,
		[Token(Token = "0x40036DD")]
		movementInCollider = 1,
		[Token(Token = "0x40036DE")]
		distanceFromPoint = 2
	}

	[Token(Token = "0x20009F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42888", Offset = "0x42888")]
	private sealed class _003CDelayedExitOut_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40036DF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40036E0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40036E1")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40036E2")]
		[FieldOffset(Offset = "0x28")]
		public OverworldCameraCenterTrigger _003C_003E4__this;

		[Token(Token = "0x170004D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F30")]
			[Address(RVA = "0x180EF0C", Offset = "0x180EF0C", VA = "0x180EF0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F32")]
			[Address(RVA = "0x180EF54", Offset = "0x180EF54", VA = "0x180EF54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x180EDF0", Offset = "0x180EDF0", VA = "0x180EDF0")]
		[DebuggerHidden]
		public _003CDelayedExitOut_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x180EE1C", Offset = "0x180EE1C", VA = "0x180EE1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x180EE20", Offset = "0x180EE20", VA = "0x180EE20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x180EF0C", Offset = "0x180EF0C", VA = "0x180EF0C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x180EF14", Offset = "0x180EF14", VA = "0x180EF14", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F32")]
		[Address(RVA = "0x180EF54", Offset = "0x180EF54", VA = "0x180EF54", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40036D0")]
	[FieldOffset(Offset = "0x18")]
	public OverworldCameraSettings inSettings;

	[Token(Token = "0x40036D1")]
	[FieldOffset(Offset = "0x20")]
	public BlendType blendType;

	[Token(Token = "0x40036D2")]
	[FieldOffset(Offset = "0x24")]
	public float blendDistance;

	[Token(Token = "0x40036D3")]
	[FieldOffset(Offset = "0x28")]
	public Transform blendPoint;

	[Token(Token = "0x40036D4")]
	[FieldOffset(Offset = "0x30")]
	public bool ignoreEndBall;

	[Token(Token = "0x40036D5")]
	[FieldOffset(Offset = "0x34")]
	public float delayedExitIfNotActive;

	[Token(Token = "0x40036D6")]
	[FieldOffset(Offset = "0x38")]
	private Collider2D col;

	[Token(Token = "0x40036D7")]
	[FieldOffset(Offset = "0x40")]
	private bool isInside;

	[Token(Token = "0x40036D8")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 lastPosition;

	[Token(Token = "0x40036D9")]
	[FieldOffset(Offset = "0x50")]
	private float moveDist;

	[Token(Token = "0x40036DA")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine delayedExitRoutine;

	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x15AFA4C", Offset = "0x15AFA4C", VA = "0x15AFA4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x15AFAA8", Offset = "0x15AFAA8", VA = "0x15AFAA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002F25")]
	[Address(RVA = "0x15AFBF4", Offset = "0x15AFBF4", VA = "0x15AFBF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002F26")]
	[Address(RVA = "0x15AFEA0", Offset = "0x15AFEA0", VA = "0x15AFEA0")]
	private void OnTriggerEnter2D(Collider2D collider)
	{
	}

	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x15B004C", Offset = "0x15B004C", VA = "0x15B004C")]
	private void OnTriggerExit2D(Collider2D collider)
	{
	}

	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x15B0238", Offset = "0x15B0238", VA = "0x15B0238")]
	private IEnumerator DelayedExitOut(float delay)
	{
		return null;
	}

	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x15AFE74", Offset = "0x15AFE74", VA = "0x15AFE74")]
	private bool IsEndBall()
	{
		return default;
	}

	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x15B02BC", Offset = "0x15B02BC", VA = "0x15B02BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x15AFAAC", Offset = "0x15AFAAC", VA = "0x15AFAAC")]
	private void CheckIfBallIsInside()
	{
	}

	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x15B02C0", Offset = "0x15B02C0", VA = "0x15B02C0")]
	public OverworldCameraCenterTrigger()
	{
	}
}
