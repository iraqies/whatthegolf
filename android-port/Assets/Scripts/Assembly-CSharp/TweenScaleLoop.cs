using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200035C")]
public class TweenScaleLoop : MonoBehaviour
{
	[Token(Token = "0x200035D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F200", Offset = "0x3F200")]
	private sealed class _003CScaleDownCR_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x20")]
		public TweenScaleLoop _003C_003E4__this;

		[Token(Token = "0x170001D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F9A")]
			[Address(RVA = "0x1870BBC", Offset = "0x1870BBC", VA = "0x1870BBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F9C")]
			[Address(RVA = "0x1870C04", Offset = "0x1870C04", VA = "0x1870C04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x18709E4", Offset = "0x18709E4", VA = "0x18709E4")]
		[DebuggerHidden]
		public _003CScaleDownCR_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x1870A10", Offset = "0x1870A10", VA = "0x1870A10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x1870A14", Offset = "0x1870A14", VA = "0x1870A14", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x1870BBC", Offset = "0x1870BBC", VA = "0x1870BBC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x1870BC4", Offset = "0x1870BC4", VA = "0x1870BC4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x1870C04", Offset = "0x1870C04", VA = "0x1870C04", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200035E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F210", Offset = "0x3F210")]
	private sealed class _003CScaleUpCR_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x20")]
		public TweenScaleLoop _003C_003E4__this;

		[Token(Token = "0x170001D2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x1870DE4", Offset = "0x1870DE4", VA = "0x1870DE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001D3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FA2")]
			[Address(RVA = "0x1870E2C", Offset = "0x1870E2C", VA = "0x1870E2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x1870C0C", Offset = "0x1870C0C", VA = "0x1870C0C")]
		[DebuggerHidden]
		public _003CScaleUpCR_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x1870C38", Offset = "0x1870C38", VA = "0x1870C38", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x1870C3C", Offset = "0x1870C3C", VA = "0x1870C3C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x1870DE4", Offset = "0x1870DE4", VA = "0x1870DE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x1870DEC", Offset = "0x1870DEC", VA = "0x1870DEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x1870E2C", Offset = "0x1870E2C", VA = "0x1870E2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 start;

	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 end;

	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve animationCurve;

	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent OnScaleDown;

	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool StartsUp;

	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UnityEvent OnScaleUp;

	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x1734E00", Offset = "0x1734E00", VA = "0x1734E00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x1734F94", Offset = "0x1734F94", VA = "0x1734F94")]
	private IEnumerator ScaleDownCR()
	{
		return null;
	}

	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x1734F20", Offset = "0x1734F20", VA = "0x1734F20")]
	private IEnumerator ScaleUpCR()
	{
		return null;
	}

	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x1735008", Offset = "0x1735008", VA = "0x1735008")]
	public TweenScaleLoop()
	{
	}

	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x1735018", Offset = "0x1735018", VA = "0x1735018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121C", Offset = "0x6121C")]
	private void _003CScaleDownCR_003Eb__9_0(float t)
	{
	}

	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x17350B8", Offset = "0x17350B8", VA = "0x17350B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6122C", Offset = "0x6122C")]
	private void _003CScaleUpCR_003Eb__10_0(float t)
	{
	}
}
