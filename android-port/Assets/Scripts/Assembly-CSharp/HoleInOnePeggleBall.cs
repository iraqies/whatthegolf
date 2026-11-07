using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200077D")]
public class HoleInOnePeggleBall : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200077E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x414B0", Offset = "0x414B0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400279B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PeggleBob, float> _003C_003E9__7_0;

		[Token(Token = "0x400279D")]
		[FieldOffset(Offset = "0x10")]
		public static Func<PeggleBob, bool> _003C_003E9__7_1;

		[Token(Token = "0x6002272")]
		[Address(RVA = "0x17BCDB4", Offset = "0x17BCDB4", VA = "0x17BCDB4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002273")]
		[Address(RVA = "0x17BCDBC", Offset = "0x17BCDBC", VA = "0x17BCDBC")]
		internal float _003CUpdateBobs_003Eb__7_0(PeggleBob b)
		{
			return default;
		}

		[Token(Token = "0x6002274")]
		[Address(RVA = "0x17BCDD4", Offset = "0x17BCDD4", VA = "0x17BCDD4")]
		internal bool _003CUpdateBobs_003Eb__7_1(PeggleBob b)
		{
			return default;
		}
	}

	[Token(Token = "0x200077F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x414C0", Offset = "0x414C0")]
	private sealed class _003CUpdateBobs_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400279E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40027A0")]
		[FieldOffset(Offset = "0x20")]
		public HoleInOnePeggleBall _003C_003E4__this;

		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0x28")]
		private Renderer[] _003Crenders_003E5__2;

		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0x30")]
		private TrailRenderer _003Ctrail_003E5__3;

		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody2D _003Crigid_003E5__4;

		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x40")]
		private float _003Cwait_003E5__5;

		[Token(Token = "0x40027A5")]
		[FieldOffset(Offset = "0x48")]
		private IEnumerator<PeggleBob> _003C_003E7__wrap5;

		[Token(Token = "0x170003CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x17BD998", Offset = "0x17BD998", VA = "0x17BD998", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x17BD9E0", Offset = "0x17BD9E0", VA = "0x17BD9E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002275")]
		[Address(RVA = "0x17BCDEC", Offset = "0x17BCDEC", VA = "0x17BCDEC")]
		[DebuggerHidden]
		public _003CUpdateBobs_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002276")]
		[Address(RVA = "0x17BCE18", Offset = "0x17BCE18", VA = "0x17BCE18", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002277")]
		[Address(RVA = "0x17BCFB8", Offset = "0x17BCFB8", VA = "0x17BCFB8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002278")]
		[Address(RVA = "0x17BCEF4", Offset = "0x17BCEF4", VA = "0x17BCEF4")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002279")]
		[Address(RVA = "0x17BD998", Offset = "0x17BD998", VA = "0x17BD998", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600227A")]
		[Address(RVA = "0x17BD9A0", Offset = "0x17BD9A0", VA = "0x17BD9A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600227B")]
		[Address(RVA = "0x17BD9E0", Offset = "0x17BD9E0", VA = "0x17BD9E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002798")]
	[FieldOffset(Offset = "0x18")]
	public Action OnReset;

	[Token(Token = "0x4002799")]
	[FieldOffset(Offset = "0x20")]
	public Transform resetToPosition;

	[Token(Token = "0x400279A")]
	[FieldOffset(Offset = "0x28")]
	private List<PeggleBob> bobs;

	[Token(Token = "0x600226B")]
	[Address(RVA = "0x14CEBD0", Offset = "0x14CEBD0", VA = "0x14CEBD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600226C")]
	[Address(RVA = "0x14CEC70", Offset = "0x14CEC70", VA = "0x14CEC70")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600226D")]
	[Address(RVA = "0x14CEE6C", Offset = "0x14CEE6C", VA = "0x14CEE6C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x600226E")]
	[Address(RVA = "0x14CEDF0", Offset = "0x14CEDF0", VA = "0x14CEDF0")]
	private void Reset()
	{
	}

	[Token(Token = "0x600226F")]
	[Address(RVA = "0x14CEF98", Offset = "0x14CEF98", VA = "0x14CEF98")]
	private IEnumerator UpdateBobs()
	{
		return null;
	}

	[Token(Token = "0x6002270")]
	[Address(RVA = "0x14CF00C", Offset = "0x14CF00C", VA = "0x14CF00C")]
	public HoleInOnePeggleBall()
	{
	}
}
