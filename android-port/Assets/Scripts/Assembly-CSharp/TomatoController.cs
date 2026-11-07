using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000325")]
public class TomatoController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000326")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EFD0", Offset = "0x3EFD0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x8")]
		public static Action<MeshRenderer> _003C_003E9__8_0;

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x18690E0", Offset = "0x18690E0", VA = "0x18690E0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x18690E8", Offset = "0x18690E8", VA = "0x18690E8")]
		internal void _003CSplat_003Eb__8_0(MeshRenderer r)
		{
		}
	}

	[Token(Token = "0x2000327")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EFE0", Offset = "0x3EFE0")]
	private sealed class _003CDie_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x20")]
		public TomatoController _003C_003E4__this;

		[Token(Token = "0x170001B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x1869218", Offset = "0x1869218", VA = "0x1869218", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x1869260", Offset = "0x1869260", VA = "0x1869260", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x1869108", Offset = "0x1869108", VA = "0x1869108")]
		[DebuggerHidden]
		public _003CDie_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x1869134", Offset = "0x1869134", VA = "0x1869134", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x1869138", Offset = "0x1869138", VA = "0x1869138", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x1869218", Offset = "0x1869218", VA = "0x1869218", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x1869220", Offset = "0x1869220", VA = "0x1869220", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x1869260", Offset = "0x1869260", VA = "0x1869260", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400117A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem SplatSystem;

	[Token(Token = "0x400117B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection SplatClip;

	[Token(Token = "0x400117C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<MeshRenderer> renders;

	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool CanFail;

	[Token(Token = "0x400117E")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool CanWin;

	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x171D1AC", Offset = "0x171D1AC", VA = "0x171D1AC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x171D354", Offset = "0x171D354", VA = "0x171D354")]
	private void Win()
	{
	}

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x171D2D0", Offset = "0x171D2D0", VA = "0x171D2D0")]
	private void Fail()
	{
	}

	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x171D358", Offset = "0x171D358", VA = "0x171D358")]
	private void Splat()
	{
	}

	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x171D65C", Offset = "0x171D65C", VA = "0x171D65C")]
	private IEnumerator Die()
	{
		return null;
	}

	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x171D6D0", Offset = "0x171D6D0", VA = "0x171D6D0")]
	public TomatoController()
	{
	}
}
