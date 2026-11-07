using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AD4")]
public class Transmogrif : MonoBehaviour
{
	[Token(Token = "0x2000AD5")]
	public enum BALLSHAPES
	{
		[Token(Token = "0x4003C6C")]
		ball = 0,
		[Token(Token = "0x4003C6D")]
		fish = 1,
		[Token(Token = "0x4003C6E")]
		bread = 2,
		[Token(Token = "0x4003C6F")]
		boat = 3,
		[Token(Token = "0x4003C70")]
		speedboat = 4,
		[Token(Token = "0x4003C71")]
		saw = 5,
		[Token(Token = "0x4003C72")]
		companioncube = 6,
		[Token(Token = "0x4003C73")]
		endball = 7,
		[Token(Token = "0x4003C74")]
		islandBall = 8,
		[Token(Token = "0x4003C75")]
		waterBall = 9,
		[Token(Token = "0x4003C76")]
		puckBall = 10,
		[Token(Token = "0x4003C77")]
		snowball = 11,
		[Token(Token = "0x4003C78")]
		pizza = 12,
		[Token(Token = "0x4003C79")]
		turkey = 13,
		[Token(Token = "0x4003C7A")]
		goo = 14
	}

	[Token(Token = "0x2000AD6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43338", Offset = "0x43338")]
	private sealed class _003CEndRumble_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003C7B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003C7C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000558")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60033CD")]
			[Address(RVA = "0x186BF18", Offset = "0x186BF18", VA = "0x186BF18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000559")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033CF")]
			[Address(RVA = "0x186BF60", Offset = "0x186BF60", VA = "0x186BF60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x186BE28", Offset = "0x186BE28", VA = "0x186BE28")]
		[DebuggerHidden]
		public _003CEndRumble_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x186BE54", Offset = "0x186BE54", VA = "0x186BE54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x186BE58", Offset = "0x186BE58", VA = "0x186BE58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60033CD")]
		[Address(RVA = "0x186BF18", Offset = "0x186BF18", VA = "0x186BF18", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033CE")]
		[Address(RVA = "0x186BF20", Offset = "0x186BF20", VA = "0x186BF20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x186BF60", Offset = "0x186BF60", VA = "0x186BF60", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003C58")]
	[FieldOffset(Offset = "0x18")]
	public BALLSHAPES targetShape;

	[Token(Token = "0x4003C59")]
	[FieldOffset(Offset = "0x1C")]
	public bool UseTargetPosition;

	[Token(Token = "0x4003C5A")]
	[FieldOffset(Offset = "0x20")]
	public Transform targetPosition;

	[Token(Token = "0x4003C5B")]
	[FieldOffset(Offset = "0x28")]
	public bool AddForceOnTransmogrif;

	[Token(Token = "0x4003C5C")]
	[FieldOffset(Offset = "0x2C")]
	public float outYVelocity;

	[Token(Token = "0x4003C5D")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 outVelocity;

	[Token(Token = "0x4003C5E")]
	[FieldOffset(Offset = "0x38")]
	public float outAngularVelocity;

	[Token(Token = "0x4003C5F")]
	[FieldOffset(Offset = "0x3C")]
	public float delay;

	[Token(Token = "0x4003C60")]
	[FieldOffset(Offset = "0x40")]
	public bool isAnimatedGrif;

	[Token(Token = "0x4003C61")]
	[FieldOffset(Offset = "0x41")]
	public bool useCameraBlender;

	[Token(Token = "0x4003C62")]
	[FieldOffset(Offset = "0x44")]
	public float TimeBeforeColliderReenable;

	[Token(Token = "0x4003C63")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer fromBright;

	[Token(Token = "0x4003C64")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer fromDark;

	[Token(Token = "0x4003C65")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer toBright;

	[Token(Token = "0x4003C66")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer toDark;

	[Token(Token = "0x4003C67")]
	[FieldOffset(Offset = "0x68")]
	public ClipSettingsCollection sfxOnEnter;

	[Token(Token = "0x4003C68")]
	[FieldOffset(Offset = "0x70")]
	public ClipSettingsCollection sfxOnExit;

	[Token(Token = "0x4003C69")]
	[FieldOffset(Offset = "0x78")]
	public Animator anim;

	[Token(Token = "0x4003C6A")]
	[FieldOffset(Offset = "0x80")]
	public string animationName;

	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x172C8E0", Offset = "0x172C8E0", VA = "0x172C8E0")]
	public void PlayAnimation(Transmogriffable.TransmogrifSprites start, Transmogriffable.TransmogrifSprites end)
	{
	}

	[Token(Token = "0x60033C8")]
	[Address(RVA = "0x172CB58", Offset = "0x172CB58", VA = "0x172CB58")]
	private IEnumerator EndRumble()
	{
		return null;
	}

	[Token(Token = "0x60033C9")]
	[Address(RVA = "0x172CBB4", Offset = "0x172CBB4", VA = "0x172CBB4")]
	public Transmogrif()
	{
	}
}
