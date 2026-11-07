using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AB3")]
public class OverworldBumper : MonoBehaviour
{
	[Token(Token = "0x2000AB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F70", Offset = "0x42F70")]
	private sealed class _003CBlinkRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B9E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B9F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003BA0")]
		[FieldOffset(Offset = "0x20")]
		public OverworldBumper _003C_003E4__this;

		[Token(Token = "0x1700054B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600333A")]
			[Address(RVA = "0x180D4C0", Offset = "0x180D4C0", VA = "0x180D4C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700054C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600333C")]
			[Address(RVA = "0x180D508", Offset = "0x180D508", VA = "0x180D508", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003337")]
		[Address(RVA = "0x180CE7C", Offset = "0x180CE7C", VA = "0x180CE7C")]
		[DebuggerHidden]
		public _003CBlinkRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003338")]
		[Address(RVA = "0x180CEA8", Offset = "0x180CEA8", VA = "0x180CEA8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003339")]
		[Address(RVA = "0x180CEAC", Offset = "0x180CEAC", VA = "0x180CEAC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600333A")]
		[Address(RVA = "0x180D4C0", Offset = "0x180D4C0", VA = "0x180D4C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600333B")]
		[Address(RVA = "0x180D4C8", Offset = "0x180D4C8", VA = "0x180D4C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600333C")]
		[Address(RVA = "0x180D508", Offset = "0x180D508", VA = "0x180D508", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003B8A")]
	[FieldOffset(Offset = "0x18")]
	public Transform scaleTransform;

	[Token(Token = "0x4003B8B")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer sprite;

	[Token(Token = "0x4003B8C")]
	[FieldOffset(Offset = "0x28")]
	public Transform pupil;

	[Token(Token = "0x4003B8D")]
	[FieldOffset(Offset = "0x30")]
	public float pupilMoveDist;

	[Token(Token = "0x4003B8E")]
	[FieldOffset(Offset = "0x34")]
	public Color hitColor;

	[Token(Token = "0x4003B8F")]
	[FieldOffset(Offset = "0x44")]
	public Color baseColor;

	[Token(Token = "0x4003B90")]
	[FieldOffset(Offset = "0x54")]
	public float pushForce;

	[Token(Token = "0x4003B91")]
	[FieldOffset(Offset = "0x58")]
	public float scaleOnHit;

	[Token(Token = "0x4003B92")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection bumperSFX;

	[Token(Token = "0x4003B93")]
	[FieldOffset(Offset = "0x68")]
	private float nextPush;

	[Token(Token = "0x4003B94")]
	[FieldOffset(Offset = "0x6C")]
	private float pushCooldown;

	[Token(Token = "0x4003B95")]
	[FieldOffset(Offset = "0x70")]
	public float BlinkCooldownMin;

	[Token(Token = "0x4003B96")]
	[FieldOffset(Offset = "0x74")]
	public float BlinkCooldownMax;

	[Token(Token = "0x4003B97")]
	[FieldOffset(Offset = "0x78")]
	private float currentPupilDist;

	[Token(Token = "0x4003B98")]
	[FieldOffset(Offset = "0x7C")]
	private float yScale;

	[Token(Token = "0x4003B99")]
	[FieldOffset(Offset = "0x80")]
	private bool hasBlinked;

	[Token(Token = "0x4003B9A")]
	[FieldOffset(Offset = "0x81")]
	private bool DontBlink;

	[Token(Token = "0x4003B9B")]
	[FieldOffset(Offset = "0x82")]
	private bool isBlinking;

	[Token(Token = "0x4003B9C")]
	[FieldOffset(Offset = "0x83")]
	private bool isAwake;

	[Token(Token = "0x4003B9D")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 baseScale;

	[Token(Token = "0x6003326")]
	[Address(RVA = "0x15A76B8", Offset = "0x15A76B8", VA = "0x15A76B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003327")]
	[Address(RVA = "0x15A7748", Offset = "0x15A7748", VA = "0x15A7748")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003328")]
	[Address(RVA = "0x15A77E4", Offset = "0x15A77E4", VA = "0x15A77E4")]
	public void EnableEye()
	{
	}

	[Token(Token = "0x6003329")]
	[Address(RVA = "0x15A78E8", Offset = "0x15A78E8", VA = "0x15A78E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600332A")]
	[Address(RVA = "0x15A7874", Offset = "0x15A7874", VA = "0x15A7874")]
	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	[Token(Token = "0x600332B")]
	[Address(RVA = "0x15A7978", Offset = "0x15A7978", VA = "0x15A7978")]
	private void Update()
	{
	}

	[Token(Token = "0x600332C")]
	[Address(RVA = "0x15A7A84", Offset = "0x15A7A84", VA = "0x15A7A84")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600332D")]
	[Address(RVA = "0x15A7C48", Offset = "0x15A7C48", VA = "0x15A7C48")]
	public void Bump()
	{
	}

	[Token(Token = "0x600332E")]
	[Address(RVA = "0x15A7D90", Offset = "0x15A7D90", VA = "0x15A7D90")]
	public OverworldBumper()
	{
	}

	[Token(Token = "0x600332F")]
	[Address(RVA = "0x15A7DB8", Offset = "0x15A7DB8", VA = "0x15A7DB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A258", Offset = "0x6A258")]
	private void _003CBlinkRoutine_003Eb__24_0(float t)
	{
	}

	[Token(Token = "0x6003330")]
	[Address(RVA = "0x15A7EA4", Offset = "0x15A7EA4", VA = "0x15A7EA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A268", Offset = "0x6A268")]
	private void _003CBlinkRoutine_003Eb__24_1(float t)
	{
	}

	[Token(Token = "0x6003331")]
	[Address(RVA = "0x15A7F98", Offset = "0x15A7F98", VA = "0x15A7F98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A278", Offset = "0x6A278")]
	private void _003CBlinkRoutine_003Eb__24_2(float t)
	{
	}

	[Token(Token = "0x6003332")]
	[Address(RVA = "0x15A8084", Offset = "0x15A8084", VA = "0x15A8084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A288", Offset = "0x6A288")]
	private void _003CBlinkRoutine_003Eb__24_3(float t)
	{
	}

	[Token(Token = "0x6003333")]
	[Address(RVA = "0x15A8178", Offset = "0x15A8178", VA = "0x15A8178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A298", Offset = "0x6A298")]
	private void _003CBlinkRoutine_003Eb__24_4(float t)
	{
	}

	[Token(Token = "0x6003334")]
	[Address(RVA = "0x15A8264", Offset = "0x15A8264", VA = "0x15A8264")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A2A8", Offset = "0x6A2A8")]
	private void _003CBlinkRoutine_003Eb__24_5(float t)
	{
	}

	[Token(Token = "0x6003335")]
	[Address(RVA = "0x15A8358", Offset = "0x15A8358", VA = "0x15A8358")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A2B8", Offset = "0x6A2B8")]
	private void _003CBump_003Eb__27_0(float t)
	{
	}

	[Token(Token = "0x6003336")]
	[Address(RVA = "0x15A83E8", Offset = "0x15A83E8", VA = "0x15A83E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A2C8", Offset = "0x6A2C8")]
	private void _003CBump_003Eb__27_1(float t)
	{
	}
}
