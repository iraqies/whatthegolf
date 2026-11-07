using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D83")]
public class GoopCamera : MonoBehaviour
{
	[Token(Token = "0x2000D84")]
	private enum Area
	{
		[Token(Token = "0x4004987")]
		LIVING = 0,
		[Token(Token = "0x4004988")]
		SOCCER = 1,
		[Token(Token = "0x4004989")]
		SNEAK = 2,
		[Token(Token = "0x400498A")]
		OUTSIDE = 3
	}

	[Token(Token = "0x2000D85")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A98", Offset = "0x44A98")]
	private sealed class _003CGoopCR_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400498B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400498C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400498D")]
		[FieldOffset(Offset = "0x20")]
		public GoopCamera _003C_003E4__this;

		[Token(Token = "0x400498E")]
		[FieldOffset(Offset = "0x28")]
		private double _003Ct_003E5__2;

		[Token(Token = "0x17000679")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F8E")]
			[Address(RVA = "0x17B7318", Offset = "0x17B7318", VA = "0x17B7318", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700067A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F90")]
			[Address(RVA = "0x17B7360", Offset = "0x17B7360", VA = "0x17B7360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0x17B7088", Offset = "0x17B7088", VA = "0x17B7088")]
		[DebuggerHidden]
		public _003CGoopCR_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x17B70B4", Offset = "0x17B70B4", VA = "0x17B70B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x17B70B8", Offset = "0x17B70B8", VA = "0x17B70B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x17B7318", Offset = "0x17B7318", VA = "0x17B7318", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x17B7320", Offset = "0x17B7320", VA = "0x17B7320", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x17B7360", Offset = "0x17B7360", VA = "0x17B7360", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D86")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AA8", Offset = "0x44AA8")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x400498F")]
		[FieldOffset(Offset = "0x10")]
		public GoopCamera _003C_003E4__this;

		[Token(Token = "0x4004990")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x17B6D6C", Offset = "0x17B6D6C", VA = "0x17B6D6C")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x17B6D74", Offset = "0x17B6D74", VA = "0x17B6D74")]
		internal void _003CDoSomething_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000D87")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AB8", Offset = "0x44AB8")]
	private sealed class _003CDoSomething_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004991")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004992")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004993")]
		[FieldOffset(Offset = "0x20")]
		public GoopCamera _003C_003E4__this;

		[Token(Token = "0x1700067B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F96")]
			[Address(RVA = "0x17B7038", Offset = "0x17B7038", VA = "0x17B7038", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700067C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F98")]
			[Address(RVA = "0x17B7080", Offset = "0x17B7080", VA = "0x17B7080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x17B6E3C", Offset = "0x17B6E3C", VA = "0x17B6E3C")]
		[DebuggerHidden]
		public _003CDoSomething_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x17B6E68", Offset = "0x17B6E68", VA = "0x17B6E68", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x17B6E6C", Offset = "0x17B6E6C", VA = "0x17B6E6C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x17B7038", Offset = "0x17B7038", VA = "0x17B7038", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x17B7040", Offset = "0x17B7040", VA = "0x17B7040", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x17B7080", Offset = "0x17B7080", VA = "0x17B7080", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004977")]
	[FieldOffset(Offset = "0x18")]
	public OverworldCameraSettings cameraForOpeningChest;

	[Token(Token = "0x4004978")]
	[FieldOffset(Offset = "0x20")]
	private bool previousBallState;

	[Token(Token = "0x4004979")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _ballProxy;

	[Token(Token = "0x400497A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _goop;

	[Token(Token = "0x400497B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator _goopFlagAnimatior;

	[Token(Token = "0x400497C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Living;

	[Token(Token = "0x400497D")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int Soccer;

	[Token(Token = "0x400497E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int Sneak;

	[Token(Token = "0x400497F")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int Outside;

	[Token(Token = "0x4004980")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OpenBarricade _barricade;

	[Token(Token = "0x4004981")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _openIndicator;

	[Token(Token = "0x4004982")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ClipSettingsCollection _OnGoopMoveSFX;

	[Token(Token = "0x4004983")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ClipSettingsCollection _OnGoopMoveSFX2;

	[Token(Token = "0x4004984")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _animationDuration;

	[Token(Token = "0x4004985")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private Area _area;

	[Token(Token = "0x6003F82")]
	[Address(RVA = "0x14ADBC4", Offset = "0x14ADBC4", VA = "0x14ADBC4")]
	private int GetAnimation()
	{
		return default;
	}

	[Token(Token = "0x6003F83")]
	[Address(RVA = "0x14ADD30", Offset = "0x14ADD30", VA = "0x14ADD30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003F84")]
	[Address(RVA = "0x14ADE60", Offset = "0x14ADE60", VA = "0x14ADE60")]
	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	[Token(Token = "0x6003F85")]
	[Address(RVA = "0x14ADF3C", Offset = "0x14ADF3C", VA = "0x14ADF3C")]
	private IEnumerator GoopCR()
	{
		return null;
	}

	[Token(Token = "0x6003F86")]
	[Address(RVA = "0x14ADFB0", Offset = "0x14ADFB0", VA = "0x14ADFB0")]
	private IEnumerator DoSomething()
	{
		return null;
	}

	[Token(Token = "0x6003F87")]
	[Address(RVA = "0x14AE024", Offset = "0x14AE024", VA = "0x14AE024")]
	public void UnDoSomething()
	{
	}

	[Token(Token = "0x6003F88")]
	[Address(RVA = "0x14AE14C", Offset = "0x14AE14C", VA = "0x14AE14C")]
	public GoopCamera()
	{
	}

	[Token(Token = "0x6003F8A")]
	[Address(RVA = "0x14AE25C", Offset = "0x14AE25C", VA = "0x14AE25C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C8FC", Offset = "0x6C8FC")]
	private void _003CUnDoSomething_003Eb__21_0(float t)
	{
	}
}
