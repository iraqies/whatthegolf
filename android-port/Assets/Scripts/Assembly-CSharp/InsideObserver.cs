using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079A")]
public class InsideObserver : MonoBehaviour
{
	[Token(Token = "0x200079B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41520", Offset = "0x41520")]
	private sealed class _003CStartSequence_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400282A")]
		[FieldOffset(Offset = "0x20")]
		public InsideObserver _003C_003E4__this;

		[Token(Token = "0x170003D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60022E2")]
			[Address(RVA = "0x17C6944", Offset = "0x17C6944", VA = "0x17C6944", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60022E4")]
			[Address(RVA = "0x17C698C", Offset = "0x17C698C", VA = "0x17C698C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x17C6810", Offset = "0x17C6810", VA = "0x17C6810")]
		[DebuggerHidden]
		public _003CStartSequence_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x17C683C", Offset = "0x17C683C", VA = "0x17C683C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x17C6840", Offset = "0x17C6840", VA = "0x17C6840", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x17C6944", Offset = "0x17C6944", VA = "0x17C6944", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x17C694C", Offset = "0x17C694C", VA = "0x17C694C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x17C698C", Offset = "0x17C698C", VA = "0x17C698C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002819")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x400281A")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody MainRigid;

	[Token(Token = "0x400281B")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody Head;

	[Token(Token = "0x400281C")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 LookAtOffset;

	[Token(Token = "0x400281D")]
	[FieldOffset(Offset = "0x3C")]
	public float MoveForce;

	[Token(Token = "0x400281E")]
	[FieldOffset(Offset = "0x40")]
	public float MoveHeadForce;

	[Token(Token = "0x400281F")]
	[FieldOffset(Offset = "0x48")]
	public Light SearchLight;

	[Token(Token = "0x4002820")]
	[FieldOffset(Offset = "0x50")]
	public Color AlertedColor;

	[Token(Token = "0x4002821")]
	[FieldOffset(Offset = "0x60")]
	public Color NormalColor;

	[Token(Token = "0x4002822")]
	[FieldOffset(Offset = "0x70")]
	public Transform StopFollowPoint;

	[Token(Token = "0x4002823")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip ObserverEnabled;

	[Token(Token = "0x4002824")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip LightTurnOn;

	[Token(Token = "0x4002825")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 offset;

	[Token(Token = "0x4002826")]
	[FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4EA9C", Offset = "0x4EA9C")]
	private bool IsAlerted__BackingField;

	[Token(Token = "0x4002827")]
	[FieldOffset(Offset = "0x95")]
	private new bool enabled;

	[Token(Token = "0x170003CF")]
	public bool IsAlerted
	{
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x14F0538", Offset = "0x14F0538", VA = "0x14F0538")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65EE4", Offset = "0x65EE4")]
		get
		{
			return default;
		}
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x14F0540", Offset = "0x14F0540", VA = "0x14F0540")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65EF4", Offset = "0x65EF4")]
		private set
		{
		}
	}

	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x14F0548", Offset = "0x14F0548", VA = "0x14F0548")]
	private void Start()
	{
	}

	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x14F0560", Offset = "0x14F0560", VA = "0x14F0560")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x14F074C", Offset = "0x14F074C", VA = "0x14F074C")]
	public void SetAlertedState()
	{
	}

	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x14F078C", Offset = "0x14F078C", VA = "0x14F078C")]
	public void SetNormalState()
	{
	}

	[Token(Token = "0x60022DD")]
	[Address(RVA = "0x14F07C8", Offset = "0x14F07C8", VA = "0x14F07C8")]
	public IEnumerator StartSequence()
	{
		return null;
	}

	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x14F083C", Offset = "0x14F083C", VA = "0x14F083C")]
	public InsideObserver()
	{
	}
}
