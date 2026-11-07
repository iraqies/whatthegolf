using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AB7")]
public class OverworldEndEyesEnabler : MonoBehaviour
{
	[Token(Token = "0x2000AB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42FF8", Offset = "0x42FF8")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4003BB9")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBumper localEye;

		[Token(Token = "0x4003BBA")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x4003BBB")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endScale;

		[Token(Token = "0x600334E")]
		[Address(RVA = "0x1810974", Offset = "0x1810974", VA = "0x1810974")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600334F")]
		[Address(RVA = "0x181097C", Offset = "0x181097C", VA = "0x181097C")]
		internal void _003CShowEyes_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000AB9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43008", Offset = "0x43008")]
	private sealed class _003CShowEyes_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003BBC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003BBD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003BBE")]
		[FieldOffset(Offset = "0x20")]
		public OverworldEndEyesEnabler _003C_003E4__this;

		[Token(Token = "0x4003BBF")]
		[FieldOffset(Offset = "0x28")]
		private int _003CcountPerFrame_003E5__2;

		[Token(Token = "0x4003BC0")]
		[FieldOffset(Offset = "0x30")]
		private OverworldBumper[] _003C_003E7__wrap2;

		[Token(Token = "0x4003BC1")]
		[FieldOffset(Offset = "0x38")]
		private int _003C_003E7__wrap3;

		[Token(Token = "0x4003BC2")]
		[FieldOffset(Offset = "0x40")]
		private OverworldBumper _003Ceye_003E5__5;

		[Token(Token = "0x1700054D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003353")]
			[Address(RVA = "0x1810D74", Offset = "0x1810D74", VA = "0x1810D74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700054E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003355")]
			[Address(RVA = "0x1810DBC", Offset = "0x1810DBC", VA = "0x1810DBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003350")]
		[Address(RVA = "0x1810A24", Offset = "0x1810A24", VA = "0x1810A24")]
		[DebuggerHidden]
		public _003CShowEyes_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003351")]
		[Address(RVA = "0x1810A50", Offset = "0x1810A50", VA = "0x1810A50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003352")]
		[Address(RVA = "0x1810A54", Offset = "0x1810A54", VA = "0x1810A54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003353")]
		[Address(RVA = "0x1810D74", Offset = "0x1810D74", VA = "0x1810D74", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003354")]
		[Address(RVA = "0x1810D7C", Offset = "0x1810D7C", VA = "0x1810D7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003355")]
		[Address(RVA = "0x1810DBC", Offset = "0x1810DBC", VA = "0x1810DBC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003BB1")]
	[FieldOffset(Offset = "0x18")]
	public InvisibleCullingObject culling;

	[Token(Token = "0x4003BB2")]
	[FieldOffset(Offset = "0x20")]
	public Transform eyes;

	[Token(Token = "0x4003BB3")]
	[FieldOffset(Offset = "0x28")]
	public OverworldBumper[] hitEyes;

	[Token(Token = "0x4003BB4")]
	[FieldOffset(Offset = "0x30")]
	public Collider2D col;

	[Token(Token = "0x4003BB5")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection FirstHitSFX;

	[Token(Token = "0x4003BB6")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection enableSFX;

	[Token(Token = "0x4003BB7")]
	[FieldOffset(Offset = "0x48")]
	public uint wwiseTrigger;

	[Token(Token = "0x4003BB8")]
	[FieldOffset(Offset = "0x50")]
	private OverworldBumper[] allEyes;

	[Token(Token = "0x6003347")]
	[Address(RVA = "0x15B4FF0", Offset = "0x15B4FF0", VA = "0x15B4FF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003348")]
	[Address(RVA = "0x15B54F8", Offset = "0x15B54F8", VA = "0x15B54F8")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003349")]
	[Address(RVA = "0x15B57E8", Offset = "0x15B57E8", VA = "0x15B57E8")]
	private IEnumerator ShowEyes()
	{
		return null;
	}

	[Token(Token = "0x600334A")]
	[Address(RVA = "0x15B51AC", Offset = "0x15B51AC", VA = "0x15B51AC")]
	public void Reset()
	{
	}

	[Token(Token = "0x600334B")]
	[Address(RVA = "0x15B585C", Offset = "0x15B585C", VA = "0x15B585C")]
	public OverworldEndEyesEnabler()
	{
	}

	[Token(Token = "0x600334C")]
	[Address(RVA = "0x15B5864", Offset = "0x15B5864", VA = "0x15B5864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A338", Offset = "0x6A338")]
	private void _003CStart_003Eb__8_1()
	{
	}

	[Token(Token = "0x600334D")]
	[Address(RVA = "0x15B5868", Offset = "0x15B5868", VA = "0x15B5868")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A348", Offset = "0x6A348")]
	private float _003CStart_003Eb__8_0(OverworldBumper e)
	{
		return default;
	}
}
