using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006BE")]
public class ChessPiece : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20006BF")]
	public class MovementType
	{
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Movement;

		[Token(Token = "0x4002356")]
		[FieldOffset(Offset = "0x18")]
		public int Steps;

		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x17854B4", Offset = "0x17854B4", VA = "0x17854B4")]
		public MovementType()
		{
		}
	}

	[Token(Token = "0x20006C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41090", Offset = "0x41090")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x10")]
		public ChessPiece _003C_003E4__this;

		[Token(Token = "0x4002358")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x4002359")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 ctrl;

		[Token(Token = "0x400235A")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 end;

		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x1784940", Offset = "0x1784940", VA = "0x1784940")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x1784948", Offset = "0x1784948", VA = "0x1784948")]
		internal void _003CDoMove_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20006C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x410A0", Offset = "0x410A0")]
	private sealed class _003CDoMove_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x20")]
		public ChessPiece _003C_003E4__this;

		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 dest;

		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x17000393")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F27")]
			[Address(RVA = "0x1785298", Offset = "0x1785298", VA = "0x1785298", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000394")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x17852E0", Offset = "0x17852E0", VA = "0x17852E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x1784EF0", Offset = "0x1784EF0", VA = "0x1784EF0")]
		[DebuggerHidden]
		public _003CDoMove_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x1784F1C", Offset = "0x1784F1C", VA = "0x1784F1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x1784F20", Offset = "0x1784F20", VA = "0x1784F20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x1785298", Offset = "0x1785298", VA = "0x1785298", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x17852A0", Offset = "0x17852A0", VA = "0x17852A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x17852E0", Offset = "0x17852E0", VA = "0x17852E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x410B0", Offset = "0x410B0")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0x10")]
		public ChessPiece _003C_003E4__this;

		[Token(Token = "0x4002361")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 ctrl;

		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 end;

		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x1784A0C", Offset = "0x1784A0C", VA = "0x1784A0C")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x1784A14", Offset = "0x1784A14", VA = "0x1784A14")]
		internal void _003CDiscardPiece_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20006C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x410C0", Offset = "0x410C0")]
	private sealed class _003CDiscardPiece_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0x20")]
		public ChessPiece _003C_003E4__this;

		[Token(Token = "0x17000395")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F2F")]
			[Address(RVA = "0x1784EA0", Offset = "0x1784EA0", VA = "0x1784EA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000396")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F31")]
			[Address(RVA = "0x1784EE8", Offset = "0x1784EE8", VA = "0x1784EE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x1784AD8", Offset = "0x1784AD8", VA = "0x1784AD8")]
		[DebuggerHidden]
		public _003CDiscardPiece_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x1784B04", Offset = "0x1784B04", VA = "0x1784B04", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x1784B08", Offset = "0x1784B08", VA = "0x1784B08", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x1784EA0", Offset = "0x1784EA0", VA = "0x1784EA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x1784EA8", Offset = "0x1784EA8", VA = "0x1784EA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x1784EE8", Offset = "0x1784EE8", VA = "0x1784EE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x410D0", Offset = "0x410D0")]
	private sealed class _003CTryDiscardPiece_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x20")]
		public ChessPiece _003C_003E4__this;

		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 coord;

		[Token(Token = "0x17000397")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F35")]
			[Address(RVA = "0x1785464", Offset = "0x1785464", VA = "0x1785464", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000398")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0x17854AC", Offset = "0x17854AC", VA = "0x17854AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x17852E8", Offset = "0x17852E8", VA = "0x17852E8")]
		[DebuggerHidden]
		public _003CTryDiscardPiece_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x1785314", Offset = "0x1785314", VA = "0x1785314", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x1785318", Offset = "0x1785318", VA = "0x1785318", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x1785464", Offset = "0x1785464", VA = "0x1785464", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x178546C", Offset = "0x178546C", VA = "0x178546C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x17854AC", Offset = "0x17854AC", VA = "0x17854AC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x18")]
	public List<MovementType> Movement;

	[Token(Token = "0x400234D")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 CurrentCell;

	[Token(Token = "0x400234E")]
	[FieldOffset(Offset = "0x28")]
	public Transform OwnerHand;

	[Token(Token = "0x400234F")]
	[FieldOffset(Offset = "0x30")]
	public ChessBoard ChessBoard;

	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x38")]
	public bool Test;

	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem SmashParticles;

	[Token(Token = "0x4002352")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigid;

	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0x50")]
	private Collider collider;

	[Token(Token = "0x4002354")]
	[FieldOffset(Offset = "0x58")]
	private PerlinShake shake;

	[Token(Token = "0x6001F19")]
	[Address(RVA = "0x189A1DC", Offset = "0x189A1DC", VA = "0x189A1DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x189A2A8", Offset = "0x189A2A8", VA = "0x189A2A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x189A2F8", Offset = "0x189A2F8", VA = "0x189A2F8")]
	public Vector2 GetRandomMove()
	{
		return default;
	}

	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x189A3F4", Offset = "0x189A3F4", VA = "0x189A3F4", Slot = "4")]
	public virtual List<Vector2> GetValidMoves()
	{
		return null;
	}

	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x189A644", Offset = "0x189A644", VA = "0x189A644", Slot = "5")]
	public virtual IEnumerator DoMove(Vector2 dest)
	{
		return null;
	}

	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x189A6CC", Offset = "0x189A6CC", VA = "0x189A6CC")]
	public IEnumerator DiscardPiece()
	{
		return null;
	}

	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x189A740", Offset = "0x189A740", VA = "0x189A740")]
	private IEnumerator TryDiscardPiece(Vector2 coord)
	{
		return null;
	}

	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x189A7C8", Offset = "0x189A7C8", VA = "0x189A7C8")]
	public ChessPiece()
	{
	}
}
