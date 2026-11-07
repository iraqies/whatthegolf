using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005D8")]
public class Bubble : MonoBehaviour
{
	[Token(Token = "0x20005D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x408D0", Offset = "0x408D0")]
	private sealed class _003CBursting_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x20")]
		public Bubble _003C_003E4__this;

		[Token(Token = "0x170002EC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x177C0AC", Offset = "0x177C0AC", VA = "0x177C0AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002ED")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x177C0F4", Offset = "0x177C0F4", VA = "0x177C0F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x177BC3C", Offset = "0x177BC3C", VA = "0x177BC3C")]
		[DebuggerHidden]
		public _003CBursting_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x177BC68", Offset = "0x177BC68", VA = "0x177BC68", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x177BC6C", Offset = "0x177BC6C", VA = "0x177BC6C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x177C0AC", Offset = "0x177C0AC", VA = "0x177C0AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x177C0B4", Offset = "0x177C0B4", VA = "0x177C0B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x177C0F4", Offset = "0x177C0F4", VA = "0x177C0F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001DBA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfGoal goal;

	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform animationRoot;

	[Token(Token = "0x4001DBC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform scaleRoot;

	[Token(Token = "0x4001DBD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClipSettings pickupClip;

	[Token(Token = "0x4001DBE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private OnCollisionAudioBase collisionSFX_WithoutCharacter;

	[Token(Token = "0x4001DBF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OnCollisionAudioBase collisionSFX_WithCharacter;

	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip respawnSound;

	[Token(Token = "0x4001DC1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioClip burstSound;

	[Token(Token = "0x4001DC2")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ShadowProjector2D bubbleShadowProjector;

	[Token(Token = "0x4001DC3")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallController golfBallController;

	[Token(Token = "0x4001DC4")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4001DC5")]
	[FieldOffset(Offset = "0x70")]
	private float respawnDelay;

	[Token(Token = "0x4001DC6")]
	[FieldOffset(Offset = "0x74")]
	private float respawnScaleUpDuration;

	[Token(Token = "0x4001DC7")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 initialPosition;

	[Token(Token = "0x4001DC8")]
	[FieldOffset(Offset = "0x84")]
	private bool isBursting;

	[Token(Token = "0x4001DC9")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ParticleSystem burstParticleSystem;

	[Token(Token = "0x4001DCA")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private int burstParticleAmount;

	[Token(Token = "0x4001DCB")]
	[FieldOffset(Offset = "0x98")]
	private BubbleCharacter pickedUpCharacter;

	[Token(Token = "0x4001DCC")]
	[FieldOffset(Offset = "0xA0")]
	public SpriteRenderer CharacterInBubbleRenderer;

	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x1709F00", Offset = "0x1709F00", VA = "0x1709F00")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x1709FE4", Offset = "0x1709FE4", VA = "0x1709FE4")]
	public void Burst()
	{
	}

	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x170A078", Offset = "0x170A078", VA = "0x170A078")]
	private IEnumerator Bursting()
	{
		return null;
	}

	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x170A0EC", Offset = "0x170A0EC", VA = "0x170A0EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x170A130", Offset = "0x170A130", VA = "0x170A130")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x170A504", Offset = "0x170A504", VA = "0x170A504")]
	public Bubble()
	{
	}

	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x170A520", Offset = "0x170A520", VA = "0x170A520")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x638EC", Offset = "0x638EC")]
	private void _003CBursting_003Eb__21_0(float t)
	{
	}
}
