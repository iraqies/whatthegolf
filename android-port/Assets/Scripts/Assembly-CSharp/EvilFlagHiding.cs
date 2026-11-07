using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000736")]
public class EvilFlagHiding : MonoBehaviour
{
	[Token(Token = "0x2000737")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x412D0", Offset = "0x412D0")]
	private sealed class _003CSwitchHole_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400262C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x20")]
		public EvilFlagHiding _003C_003E4__this;

		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _003Ctarget_003E5__2;

		[Token(Token = "0x170003BC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600214B")]
			[Address(RVA = "0x17A0BA0", Offset = "0x17A0BA0", VA = "0x17A0BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003BD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600214D")]
			[Address(RVA = "0x17A0BE8", Offset = "0x17A0BE8", VA = "0x17A0BE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002148")]
		[Address(RVA = "0x17A0670", Offset = "0x17A0670", VA = "0x17A0670")]
		[DebuggerHidden]
		public _003CSwitchHole_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002149")]
		[Address(RVA = "0x17A069C", Offset = "0x17A069C", VA = "0x17A069C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600214A")]
		[Address(RVA = "0x17A06A0", Offset = "0x17A06A0", VA = "0x17A06A0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600214B")]
		[Address(RVA = "0x17A0BA0", Offset = "0x17A0BA0", VA = "0x17A0BA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600214C")]
		[Address(RVA = "0x17A0BA8", Offset = "0x17A0BA8", VA = "0x17A0BA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600214D")]
		[Address(RVA = "0x17A0BE8", Offset = "0x17A0BE8", VA = "0x17A0BE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> sequence;

	[Token(Token = "0x4002625")]
	[FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x4002626")]
	[FieldOffset(Offset = "0x24")]
	public float hideYOffset;

	[Token(Token = "0x4002627")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ball;

	[Token(Token = "0x4002628")]
	[FieldOffset(Offset = "0x30")]
	public RandomAudioClips audioClip;

	[Token(Token = "0x4002629")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x400262A")]
	[FieldOffset(Offset = "0x40")]
	private int currentIndex;

	[Token(Token = "0x400262B")]
	[FieldOffset(Offset = "0x44")]
	private bool moving;

	[Token(Token = "0x6002144")]
	[Address(RVA = "0x144B7F0", Offset = "0x144B7F0", VA = "0x144B7F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002145")]
	[Address(RVA = "0x144B914", Offset = "0x144B914", VA = "0x144B914")]
	private void Ball_OnPreShoot(Vector3 aim)
	{
	}

	[Token(Token = "0x6002146")]
	[Address(RVA = "0x144B9AC", Offset = "0x144B9AC", VA = "0x144B9AC")]
	private IEnumerator SwitchHole()
	{
		return null;
	}

	[Token(Token = "0x6002147")]
	[Address(RVA = "0x144BA20", Offset = "0x144BA20", VA = "0x144BA20")]
	public EvilFlagHiding()
	{
	}
}
