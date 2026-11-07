using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EA")]
public class ShootVillainToHole : MonoBehaviour
{
	[Token(Token = "0x20002EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED5C", Offset = "0x3ED5C")]
	private sealed class _003CMakeCartStatic_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x20")]
		public ShootVillainToHole _003C_003E4__this;

		[Token(Token = "0x1700019A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x1849C5C", Offset = "0x1849C5C", VA = "0x1849C5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700019B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x1849CA4", Offset = "0x1849CA4", VA = "0x1849CA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x1849B5C", Offset = "0x1849B5C", VA = "0x1849B5C")]
		[DebuggerHidden]
		public _003CMakeCartStatic_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x1849B88", Offset = "0x1849B88", VA = "0x1849B88", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x1849B8C", Offset = "0x1849B8C", VA = "0x1849B8C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x1849C5C", Offset = "0x1849C5C", VA = "0x1849C5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x1849C64", Offset = "0x1849C64", VA = "0x1849C64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x1849CA4", Offset = "0x1849CA4", VA = "0x1849CA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform TargetPosition;

	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody Cart;

	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject AttachedRigid;

	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float Force;

	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject Villain;

	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool debug;

	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Rigidbody CartWinner;

	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform TargetPositionWin;

	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float ForceWin;

	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float cartFlyTime;

	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private HotdogGolfer hotdogGolfer;

	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private CinemachineVirtualCamera cam;

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x16A275C", Offset = "0x16A275C", VA = "0x16A275C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x16A28B8", Offset = "0x16A28B8", VA = "0x16A28B8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x16A2944", Offset = "0x16A2944", VA = "0x16A2944")]
	public void SwapCarts()
	{
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x16A2770", Offset = "0x16A2770", VA = "0x16A2770")]
	private void ShootIntoHole()
	{
	}

	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x16A2B2C", Offset = "0x16A2B2C", VA = "0x16A2B2C")]
	private IEnumerator MakeCartStatic()
	{
		return null;
	}

	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x16A2BA0", Offset = "0x16A2BA0", VA = "0x16A2BA0")]
	public ShootVillainToHole()
	{
	}
}
