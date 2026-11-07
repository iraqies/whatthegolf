using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000C23")]
public class ResetOnOutOfBounds : MonoBehaviour
{
	[Token(Token = "0x2000C24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FD0", Offset = "0x43FD0")]
	private sealed class _003CPopInAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40042FC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40042FD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40042FE")]
		[FieldOffset(Offset = "0x20")]
		public ResetOnOutOfBounds _003C_003E4__this;

		[Token(Token = "0x40042FF")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ct_003E5__2;

		[Token(Token = "0x17000601")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003A14")]
			[Address(RVA = "0x1834250", Offset = "0x1834250", VA = "0x1834250", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000602")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003A16")]
			[Address(RVA = "0x1834298", Offset = "0x1834298", VA = "0x1834298", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x18340C0", Offset = "0x18340C0", VA = "0x18340C0")]
		[DebuggerHidden]
		public _003CPopInAnimation_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x18340EC", Offset = "0x18340EC", VA = "0x18340EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x18340F0", Offset = "0x18340F0", VA = "0x18340F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x1834250", Offset = "0x1834250", VA = "0x1834250", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003A15")]
		[Address(RVA = "0x1834258", Offset = "0x1834258", VA = "0x1834258", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x1834298", Offset = "0x1834298", VA = "0x1834298", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000C25")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FE0", Offset = "0x43FE0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004300")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004301")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__17_0;

		[Token(Token = "0x6003A18")]
		[Address(RVA = "0x18340B4", Offset = "0x18340B4", VA = "0x18340B4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003A19")]
		[Address(RVA = "0x18340BC", Offset = "0x18340BC", VA = "0x18340BC")]
		internal void _003COnTriggerEnter_003Eb__17_0(float t)
		{
		}
	}

	[Token(Token = "0x40042EE")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent AdditionalCalls;

	[Token(Token = "0x40042EF")]
	[FieldOffset(Offset = "0x20")]
	public bool UsePlayerOutOfBounds;

	[Token(Token = "0x40042F0")]
	[FieldOffset(Offset = "0x24")]
	public float Delay;

	[Token(Token = "0x40042F1")]
	[FieldOffset(Offset = "0x28")]
	public bool FailLevel;

	[Token(Token = "0x40042F2")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 RandomResetPositionOffsetMin;

	[Token(Token = "0x40042F3")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 RandomResetPositionOffsetMax;

	[Token(Token = "0x40042F4")]
	[FieldOffset(Offset = "0x44")]
	public bool doPopInAnimation;

	[Token(Token = "0x40042F5")]
	[FieldOffset(Offset = "0x48")]
	public Ease.Easing ease;

	[Token(Token = "0x40042F6")]
	[FieldOffset(Offset = "0x4C")]
	public float animationTime;

	[Token(Token = "0x40042F7")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x40042F8")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion startRot;

	[Token(Token = "0x40042F9")]
	[FieldOffset(Offset = "0x70")]
	private Rigidbody rigidbody;

	[Token(Token = "0x40042FA")]
	[FieldOffset(Offset = "0x78")]
	private bool resetting;

	[Token(Token = "0x40042FB")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 baseScale;

	[Token(Token = "0x6003A0C")]
	[Address(RVA = "0x164AF7C", Offset = "0x164AF7C", VA = "0x164AF7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A0D")]
	[Address(RVA = "0x164B0FC", Offset = "0x164B0FC", VA = "0x164B0FC")]
	private void OnReset()
	{
	}

	[Token(Token = "0x6003A0E")]
	[Address(RVA = "0x164B424", Offset = "0x164B424", VA = "0x164B424")]
	private IEnumerator PopInAnimation()
	{
		return null;
	}

	[Token(Token = "0x6003A0F")]
	[Address(RVA = "0x164B498", Offset = "0x164B498", VA = "0x164B498")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003A10")]
	[Address(RVA = "0x164B6F8", Offset = "0x164B6F8", VA = "0x164B6F8")]
	public ResetOnOutOfBounds()
	{
	}
}
