using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200093A")]
public class BirdGrowOnScare : MonoBehaviour
{
	[Token(Token = "0x200093B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x420E8", Offset = "0x420E8")]
	private sealed class _003CGrowRoutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003263")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003264")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003265")]
		[FieldOffset(Offset = "0x20")]
		public BirdGrowOnScare _003C_003E4__this;

		[Token(Token = "0x4003266")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17000467")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002AD7")]
			[Address(RVA = "0x1773444", Offset = "0x1773444", VA = "0x1773444", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000468")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002AD9")]
			[Address(RVA = "0x177348C", Offset = "0x177348C", VA = "0x177348C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x1773304", Offset = "0x1773304", VA = "0x1773304")]
		[DebuggerHidden]
		public _003CGrowRoutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x1773330", Offset = "0x1773330", VA = "0x1773330", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x1773334", Offset = "0x1773334", VA = "0x1773334", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x1773444", Offset = "0x1773444", VA = "0x1773444", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x177344C", Offset = "0x177344C", VA = "0x177344C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x177348C", Offset = "0x177348C", VA = "0x177348C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400325E")]
	[FieldOffset(Offset = "0x18")]
	public float growSizeFactor;

	[Token(Token = "0x400325F")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve curve;

	[Token(Token = "0x4003260")]
	[FieldOffset(Offset = "0x28")]
	public float animationTime;

	[Token(Token = "0x4003261")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection growStartClip;

	[Token(Token = "0x4003262")]
	[FieldOffset(Offset = "0x38")]
	private BirdNPC bird;

	[Token(Token = "0x6002AD0")]
	[Address(RVA = "0x16119EC", Offset = "0x16119EC", VA = "0x16119EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002AD1")]
	[Address(RVA = "0x1611B34", Offset = "0x1611B34", VA = "0x1611B34")]
	private void Bird_OnScared(BirdNPC obj)
	{
	}

	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x1611BB0", Offset = "0x1611BB0", VA = "0x1611BB0")]
	private IEnumerator GrowRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x1611C24", Offset = "0x1611C24", VA = "0x1611C24")]
	public BirdGrowOnScare()
	{
	}
}
