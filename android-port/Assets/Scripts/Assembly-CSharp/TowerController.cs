using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000273")]
public class TowerController : MonoBehaviour
{
	[Token(Token = "0x2000274")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E744", Offset = "0x3E744")]
	private sealed class _003CSetTower_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x20")]
		public TowerController _003C_003E4__this;

		[Token(Token = "0x17000156")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x18698E4", Offset = "0x18698E4", VA = "0x18698E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000157")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x186992C", Offset = "0x186992C", VA = "0x186992C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x1869478", Offset = "0x1869478", VA = "0x1869478")]
		[DebuggerHidden]
		public _003CSetTower_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x18694A4", Offset = "0x18694A4", VA = "0x18694A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x18694A8", Offset = "0x18694A8", VA = "0x18694A8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x18698E4", Offset = "0x18698E4", VA = "0x18698E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x18698EC", Offset = "0x18698EC", VA = "0x18698EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x186992C", Offset = "0x186992C", VA = "0x186992C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000275")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E754", Offset = "0x3E754")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x10")]
		public TowerController _003C_003E4__this;

		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x18")]
		public float startY;

		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x1C")]
		public float endY;

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x1869398", Offset = "0x1869398", VA = "0x1869398")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x18693A0", Offset = "0x18693A0", VA = "0x18693A0")]
		internal void _003COnHit_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x18")]
	public List<float> PowerGoals;

	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> Positions;

	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x28")]
	public Transform FlagPosition;

	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x30")]
	public Transform TowerRoot;

	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x38")]
	public TowerPowerGoal TowerPower;

	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0x40")]
	public Animator Animator;

	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x48")]
	public WhackHammerController Hammer;

	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0x50")]
	public float AcceptedErrorMargin;

	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection BellRingClip;

	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection HitPlatformClip;

	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x68")]
	public ClipSettingsCollection TowerMovingClip;

	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x70")]
	public ClipSettingsCollection HoleMovingClip;

	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x78")]
	public ClipSettingsCollection IncorrectHitClip;

	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x80")]
	private bool hasHitCorrectPower;

	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x84")]
	private int currentIndex;

	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x88")]
	private bool readyForHits;

	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0x89")]
	[SerializeField]
	private bool ShowFlag;

	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x8A")]
	[SerializeField]
	private bool HideOnDone;

	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x8B")]
	[SerializeField]
	private bool PlayHoleMoving;

	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private bool UseIncorrectAnimation;

	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject Sphere;

	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject RealSphere;

	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UnityEvent OnHitDone;

	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x171F2D8", Offset = "0x171F2D8", VA = "0x171F2D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x171F410", Offset = "0x171F410", VA = "0x171F410")]
	private IEnumerator SetTower()
	{
		return null;
	}

	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x171F484", Offset = "0x171F484", VA = "0x171F484")]
	private void OnHit(float power)
	{
	}

	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x171F744", Offset = "0x171F744", VA = "0x171F744")]
	public void RingBell()
	{
	}

	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x171F78C", Offset = "0x171F78C", VA = "0x171F78C")]
	public void HitPlatform()
	{
	}

	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x171F7D4", Offset = "0x171F7D4", VA = "0x171F7D4")]
	public void TowerMoving()
	{
	}

	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x171F81C", Offset = "0x171F81C", VA = "0x171F81C")]
	public void HoleMoving()
	{
	}

	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x171F87C", Offset = "0x171F87C", VA = "0x171F87C")]
	public TowerController()
	{
	}
}
