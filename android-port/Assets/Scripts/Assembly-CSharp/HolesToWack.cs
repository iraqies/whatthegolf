using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D7")]
public class HolesToWack : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002D8")]
	public struct Hole
	{
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x0")]
		public GameObject HoleTransform;

		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x8")]
		public Animator HoleAnimator;
	}

	[Serializable]
	[Token(Token = "0x20002D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ECDC", Offset = "0x3ECDC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Hole> _003C_003E9__17_0;

		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x10")]
		public static Action<Hole> _003C_003E9__17_1;

		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x18")]
		public static Action<Hole> _003C_003E9__17_2;

		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x17BF0B4", Offset = "0x17BF0B4", VA = "0x17BF0B4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x17BF0BC", Offset = "0x17BF0BC", VA = "0x17BF0BC")]
		internal void _003CAwake_003Eb__17_0(Hole h)
		{
		}

		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x17BF118", Offset = "0x17BF118", VA = "0x17BF118")]
		internal void _003CAwake_003Eb__17_1(Hole h)
		{
		}

		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x17BF138", Offset = "0x17BF138", VA = "0x17BF138")]
		internal void _003CAwake_003Eb__17_2(Hole h)
		{
		}
	}

	[Token(Token = "0x20002DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ECEC", Offset = "0x3ECEC")]
	private sealed class _003CSwap_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x20")]
		public HolesToWack _003C_003E4__this;

		[Token(Token = "0x1700018E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x17BF3F4", Offset = "0x17BF3F4", VA = "0x17BF3F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700018F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x17BF43C", Offset = "0x17BF43C", VA = "0x17BF43C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x17BF17C", Offset = "0x17BF17C", VA = "0x17BF17C")]
		[DebuggerHidden]
		public _003CSwap_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x17BF1A8", Offset = "0x17BF1A8", VA = "0x17BF1A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x17BF1AC", Offset = "0x17BF1AC", VA = "0x17BF1AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x17BF3F4", Offset = "0x17BF3F4", VA = "0x17BF3F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x17BF3FC", Offset = "0x17BF3FC", VA = "0x17BF3FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x17BF43C", Offset = "0x17BF43C", VA = "0x17BF43C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20002DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ECFC", Offset = "0x3ECFC")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x10")]
		public Light l;

		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x17BF158", Offset = "0x17BF158", VA = "0x17BF158")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x17BF160", Offset = "0x17BF160", VA = "0x17BF160")]
		internal void _003CTweenLight_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Hole> holes;

	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> thingsInHolePrefab;

	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem DizzySystem;

	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<float> thingsInHoleUpMod;

	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ActionAfterNumEvents ticker;

	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GolfGoal finalFlag;

	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float paritcleEmissionMod;

	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject finalHole;

	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<ActionAfterDelay> actions;

	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Vector2 StayUpDurationRange;

	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ParticleSystem HitParticles;

	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x70")]
	private float stayUpTimer;

	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x74")]
	private int currentIndex;

	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x78")]
	private int currentThingIndex;

	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x7C")]
	private bool final;

	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x80")]
	private GameObject currentThing;

	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine swap;

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x14D31D8", Offset = "0x14D31D8", VA = "0x14D31D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x14D3494", Offset = "0x14D3494", VA = "0x14D3494")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x14D3514", Offset = "0x14D3514", VA = "0x14D3514")]
	private void GoUp(Hole h)
	{
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x14D38EC", Offset = "0x14D38EC", VA = "0x14D38EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x14D39B0", Offset = "0x14D39B0", VA = "0x14D39B0")]
	private IEnumerator Swap()
	{
		return null;
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x14D3A24", Offset = "0x14D3A24", VA = "0x14D3A24")]
	public void ActivateFinalHole()
	{
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x14D3A30", Offset = "0x14D3A30", VA = "0x14D3A30")]
	public void HasBeenWhacked()
	{
	}

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x14D3D88", Offset = "0x14D3D88", VA = "0x14D3D88")]
	public void TweenLight()
	{
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x14D3ED8", Offset = "0x14D3ED8", VA = "0x14D3ED8")]
	public HolesToWack()
	{
	}
}
