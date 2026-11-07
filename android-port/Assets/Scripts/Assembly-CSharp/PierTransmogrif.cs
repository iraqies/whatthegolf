using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AC8")]
public class PierTransmogrif : MonoBehaviour
{
	[Token(Token = "0x2000AC9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x432D8", Offset = "0x432D8")]
	private sealed class _003CStart_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003C1B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003C1C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003C1D")]
		[FieldOffset(Offset = "0x20")]
		public PierTransmogrif _003C_003E4__this;

		[Token(Token = "0x17000552")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600339E")]
			[Address(RVA = "0x1825E38", Offset = "0x1825E38", VA = "0x1825E38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000553")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033A0")]
			[Address(RVA = "0x1825E80", Offset = "0x1825E80", VA = "0x1825E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600339B")]
		[Address(RVA = "0x1825B38", Offset = "0x1825B38", VA = "0x1825B38")]
		[DebuggerHidden]
		public _003CStart_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600339C")]
		[Address(RVA = "0x1825B64", Offset = "0x1825B64", VA = "0x1825B64", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600339D")]
		[Address(RVA = "0x1825B68", Offset = "0x1825B68", VA = "0x1825B68", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600339E")]
		[Address(RVA = "0x1825E38", Offset = "0x1825E38", VA = "0x1825E38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600339F")]
		[Address(RVA = "0x1825E40", Offset = "0x1825E40", VA = "0x1825E40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x1825E80", Offset = "0x1825E80", VA = "0x1825E80", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000ACA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x432E8", Offset = "0x432E8")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4003C1E")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBall2D player;

		[Token(Token = "0x4003C1F")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4003C20")]
		[FieldOffset(Offset = "0x28")]
		public PierTransmogrif _003C_003E4__this;

		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x18252AC", Offset = "0x18252AC", VA = "0x18252AC")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x18252B4", Offset = "0x18252B4", VA = "0x18252B4")]
		internal void _003CTransmogrifRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000ACB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x432F8", Offset = "0x432F8")]
	private sealed class _003CTransmogrifRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003C21")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003C22")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003C23")]
		[FieldOffset(Offset = "0x20")]
		public OverworldBall2D player;

		[Token(Token = "0x4003C24")]
		[FieldOffset(Offset = "0x28")]
		public PierTransmogrif _003C_003E4__this;

		[Token(Token = "0x4003C25")]
		[FieldOffset(Offset = "0x30")]
		public Transmogriffable transmogriffable;

		[Token(Token = "0x17000554")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60033A6")]
			[Address(RVA = "0x18261A8", Offset = "0x18261A8", VA = "0x18261A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000555")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033A8")]
			[Address(RVA = "0x18261F0", Offset = "0x18261F0", VA = "0x18261F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x1825E88", Offset = "0x1825E88", VA = "0x1825E88")]
		[DebuggerHidden]
		public _003CTransmogrifRoutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x1825EB4", Offset = "0x1825EB4", VA = "0x1825EB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x1825EB8", Offset = "0x1825EB8", VA = "0x1825EB8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60033A6")]
		[Address(RVA = "0x18261A8", Offset = "0x18261A8", VA = "0x18261A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x18261B0", Offset = "0x18261B0", VA = "0x18261B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x18261F0", Offset = "0x18261F0", VA = "0x18261F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000ACC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43308", Offset = "0x43308")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4003C26")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBall2D player;

		[Token(Token = "0x4003C27")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4003C28")]
		[FieldOffset(Offset = "0x28")]
		public PierTransmogrif _003C_003E4__this;

		[Token(Token = "0x4003C29")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion startRot;

		[Token(Token = "0x4003C2A")]
		[FieldOffset(Offset = "0x40")]
		public Transform playerSprite;

		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x1825388", Offset = "0x1825388", VA = "0x1825388")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x1825390", Offset = "0x1825390", VA = "0x1825390")]
		internal void _003CDockTransmogrifRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x1825514", Offset = "0x1825514", VA = "0x1825514")]
		internal void _003CDockTransmogrifRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000ACD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43318", Offset = "0x43318")]
	private sealed class _003CDockTransmogrifRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003C2B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003C2C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003C2D")]
		[FieldOffset(Offset = "0x20")]
		public OverworldBall2D player;

		[Token(Token = "0x4003C2E")]
		[FieldOffset(Offset = "0x28")]
		public PierTransmogrif _003C_003E4__this;

		[Token(Token = "0x4003C2F")]
		[FieldOffset(Offset = "0x30")]
		public Transmogriffable transmogriffable;

		[Token(Token = "0x4003C30")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		[Token(Token = "0x17000556")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60033AF")]
			[Address(RVA = "0x1825AE8", Offset = "0x1825AE8", VA = "0x1825AE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000557")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033B1")]
			[Address(RVA = "0x1825B30", Offset = "0x1825B30", VA = "0x1825B30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x18255CC", Offset = "0x18255CC", VA = "0x18255CC")]
		[DebuggerHidden]
		public _003CDockTransmogrifRoutine_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60033AD")]
		[Address(RVA = "0x18255F8", Offset = "0x18255F8", VA = "0x18255F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60033AE")]
		[Address(RVA = "0x18255FC", Offset = "0x18255FC", VA = "0x18255FC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x1825AE8", Offset = "0x1825AE8", VA = "0x1825AE8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x1825AF0", Offset = "0x1825AF0", VA = "0x1825AF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x1825B30", Offset = "0x1825B30", VA = "0x1825B30", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003C10")]
	[FieldOffset(Offset = "0x18")]
	public Transmogrif BoatTransmogrif;

	[Token(Token = "0x4003C11")]
	[FieldOffset(Offset = "0x20")]
	public Transmogrif BallTransmogrif;

	[Token(Token = "0x4003C12")]
	[FieldOffset(Offset = "0x28")]
	public FakeBoat FakeBoat;

	[Token(Token = "0x4003C13")]
	[FieldOffset(Offset = "0x30")]
	public FakeBoat FakeSpeedBoat;

	[Token(Token = "0x4003C14")]
	[FieldOffset(Offset = "0x38")]
	public Transform DockPlayerPosition;

	[Token(Token = "0x4003C15")]
	[FieldOffset(Offset = "0x40")]
	private bool waitForExit;

	[Token(Token = "0x4003C16")]
	[FieldOffset(Offset = "0x41")]
	private bool routineRunning;

	[Token(Token = "0x4003C17")]
	[FieldOffset(Offset = "0x48")]
	private OverworldBallFollower follower;

	[Token(Token = "0x4003C18")]
	[FieldOffset(Offset = "0x50")]
	private OverworldID id;

	[Token(Token = "0x4003C19")]
	[FieldOffset(Offset = "0x58")]
	private string shapeKey;

	[Token(Token = "0x4003C1A")]
	[FieldOffset(Offset = "0x60")]
	private string beenUsedKey;

	[Token(Token = "0x6003391")]
	[Address(RVA = "0x15E1B74", Offset = "0x15E1B74", VA = "0x15E1B74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003392")]
	[Address(RVA = "0x15E1CB4", Offset = "0x15E1CB4", VA = "0x15E1CB4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003393")]
	[Address(RVA = "0x15E1DB0", Offset = "0x15E1DB0", VA = "0x15E1DB0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003394")]
	[Address(RVA = "0x15E1E24", Offset = "0x15E1E24", VA = "0x15E1E24")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003395")]
	[Address(RVA = "0x15E2198", Offset = "0x15E2198", VA = "0x15E2198")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003396")]
	[Address(RVA = "0x15E2088", Offset = "0x15E2088", VA = "0x15E2088")]
	private IEnumerator TransmogrifRoutine(OverworldBall2D player, Transmogriffable transmogriffable)
	{
		return null;
	}

	[Token(Token = "0x6003397")]
	[Address(RVA = "0x15E2110", Offset = "0x15E2110", VA = "0x15E2110")]
	private IEnumerator DockTransmogrifRoutine(OverworldBall2D player, Transmogriffable transmogriffable)
	{
		return null;
	}

	[Token(Token = "0x6003398")]
	[Address(RVA = "0x15E2260", Offset = "0x15E2260", VA = "0x15E2260")]
	private FakeBoat GetFakeBoat()
	{
		return null;
	}

	[Token(Token = "0x6003399")]
	[Address(RVA = "0x15E2028", Offset = "0x15E2028", VA = "0x15E2028")]
	public bool IsPierOccupied()
	{
		return default;
	}

	[Token(Token = "0x600339A")]
	[Address(RVA = "0x15E22A8", Offset = "0x15E22A8", VA = "0x15E22A8")]
	public PierTransmogrif()
	{
	}
}
