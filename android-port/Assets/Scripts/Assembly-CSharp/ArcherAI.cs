using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C7")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E110", Offset = "0x3E110")]
public class ArcherAI : MonoBehaviour
{
	[Token(Token = "0x20001C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E178", Offset = "0x3E178")]
	private sealed class _003CStart_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x20")]
		public ArcherAI _003C_003E4__this;

		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x28")]
		private float _003ClastAngle_003E5__2;

		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CtargetAngle_003E5__3;

		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cm_003E5__4;

		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _003Cdir_003E5__5;

		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x40")]
		private float _003Ctimer_003E5__6;

		[Token(Token = "0x1700010B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x176E088", Offset = "0x176E088", VA = "0x176E088", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700010C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x176E0D0", Offset = "0x176E0D0", VA = "0x176E0D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x176DB54", Offset = "0x176DB54", VA = "0x176DB54")]
		[DebuggerHidden]
		public _003CStart_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x176DB80", Offset = "0x176DB80", VA = "0x176DB80", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x176DB84", Offset = "0x176DB84", VA = "0x176DB84", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x176E088", Offset = "0x176E088", VA = "0x176E088", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x176E090", Offset = "0x176E090", VA = "0x176E090", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x176E0D0", Offset = "0x176E0D0", VA = "0x176E0D0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ArrowShooter arrowShooter;

	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float waitBeforeShooting;

	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float waitAfterShooting;

	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4A22C", Offset = "0x4A22C")]
	private float minShootBoost;

	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4A26C", Offset = "0x4A26C")]
	private float maxShootBoost;

	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float minShootAngle;

	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float maxShootAngle;

	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float aimAnimSmoothTime;

	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x3C")]
	private float currSpeed;

	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int simulationSteps;

	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float simulationDeltaTime;

	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x48")]
	private Collider[] aimingTestResults;

	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x50")]
	private string goalTagName;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<float> fallbackShootAngles;

	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<float> fallbackShootBoosts;

	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float sphereCastRadius;

	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x70")]
	private List<int> shotIndeces;

	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x78")]
	private float currentAngle;

	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x7C")]
	private int shotCount;

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x141E9A8", Offset = "0x141E9A8", VA = "0x141E9A8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x141EA1C", Offset = "0x141EA1C", VA = "0x141EA1C")]
	private bool TestTrajectory(Vector3 boost, Color goodColor, float debugLifetime = 0f)
	{
		return default;
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x141EDD4", Offset = "0x141EDD4", VA = "0x141EDD4")]
	private bool DrawTrajectoryGizmos(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x141F10C", Offset = "0x141F10C", VA = "0x141F10C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x141F284", Offset = "0x141F284", VA = "0x141F284")]
	public ArcherAI()
	{
	}
}
