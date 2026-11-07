using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D06")]
public class ObjectHiddenInSnow : MonoBehaviour
{
	[Token(Token = "0x2000D07")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44668", Offset = "0x44668")]
	private sealed class _003CRevealAndStayForAwhile_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40046C9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40046CA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40046CB")]
		[FieldOffset(Offset = "0x20")]
		public ObjectHiddenInSnow _003C_003E4__this;

		[Token(Token = "0x1700064B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003D90")]
			[Address(RVA = "0x180A10C", Offset = "0x180A10C", VA = "0x180A10C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700064C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003D92")]
			[Address(RVA = "0x180A154", Offset = "0x180A154", VA = "0x180A154", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x180A000", Offset = "0x180A000", VA = "0x180A000")]
		[DebuggerHidden]
		public _003CRevealAndStayForAwhile_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x180A02C", Offset = "0x180A02C", VA = "0x180A02C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x180A030", Offset = "0x180A030", VA = "0x180A030", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x180A10C", Offset = "0x180A10C", VA = "0x180A10C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003D91")]
		[Address(RVA = "0x180A114", Offset = "0x180A114", VA = "0x180A114", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003D92")]
		[Address(RVA = "0x180A154", Offset = "0x180A154", VA = "0x180A154", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40046BF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator m_animator;

	[Token(Token = "0x40046C0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_stay;

	[Token(Token = "0x40046C1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_timeBeforeDisappearing;

	[Token(Token = "0x40046C2")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x51744", Offset = "0x51744")]
	[SerializeField]
	private float m_ballSpeedAfterColliding;

	[Token(Token = "0x40046C3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem m_fallingSnowFX;

	[Token(Token = "0x40046C4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform m_maskingPatchContainer;

	[Token(Token = "0x40046C5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioEventAsset m_SfxOnAppear;

	[Token(Token = "0x40046C6")]
	[FieldOffset(Offset = "0x48")]
	private GameObject[] m_maskingSnowPatches;

	[Token(Token = "0x40046C7")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine m_revealCoroutine;

	[Token(Token = "0x40046C8")]
	[FieldOffset(Offset = "0x58")]
	public bool m_isVisible;

	[Token(Token = "0x6003D87")]
	[Address(RVA = "0x1591E80", Offset = "0x1591E80", VA = "0x1591E80")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D88")]
	[Address(RVA = "0x159221C", Offset = "0x159221C", VA = "0x159221C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003D89")]
	[Address(RVA = "0x1592594", Offset = "0x1592594", VA = "0x1592594")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003D8A")]
	[Address(RVA = "0x1592384", Offset = "0x1592384", VA = "0x1592384")]
	private void RevealItself()
	{
	}

	[Token(Token = "0x6003D8B")]
	[Address(RVA = "0x1592520", Offset = "0x1592520", VA = "0x1592520")]
	private IEnumerator RevealAndStayForAwhile()
	{
		return null;
	}

	[Token(Token = "0x6003D8C")]
	[Address(RVA = "0x1592604", Offset = "0x1592604", VA = "0x1592604")]
	public ObjectHiddenInSnow()
	{
	}
}
