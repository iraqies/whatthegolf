using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200067A")]
public class FrogKingLastStage : MonoBehaviour
{
	[Token(Token = "0x200067B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40DE0", Offset = "0x40DE0")]
	private sealed class _003CPlayRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000351")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DB0")]
			[Address(RVA = "0x17AA5B4", Offset = "0x17AA5B4", VA = "0x17AA5B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000352")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DB2")]
			[Address(RVA = "0x17AA5FC", Offset = "0x17AA5FC", VA = "0x17AA5FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x17AA560", Offset = "0x17AA560", VA = "0x17AA560")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DAE")]
		[Address(RVA = "0x17AA58C", Offset = "0x17AA58C", VA = "0x17AA58C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DAF")]
		[Address(RVA = "0x17AA590", Offset = "0x17AA590", VA = "0x17AA590", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DB0")]
		[Address(RVA = "0x17AA5B4", Offset = "0x17AA5B4", VA = "0x17AA5B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DB1")]
		[Address(RVA = "0x17AA5BC", Offset = "0x17AA5BC", VA = "0x17AA5BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x17AA5FC", Offset = "0x17AA5FC", VA = "0x17AA5FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200067C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40DF0", Offset = "0x40DF0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__21_0;

		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__21_1;

		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__21_2;

		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x17AA1BC", Offset = "0x17AA1BC", VA = "0x17AA1BC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x17AA1C4", Offset = "0x17AA1C4", VA = "0x17AA1C4")]
		internal void _003CUnplugRoutine_003Eb__21_0(float f)
		{
		}

		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x17AA234", Offset = "0x17AA234", VA = "0x17AA234")]
		internal void _003CUnplugRoutine_003Eb__21_1(float f)
		{
		}

		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x17AA29C", Offset = "0x17AA29C", VA = "0x17AA29C")]
		internal void _003CUnplugRoutine_003Eb__21_2()
		{
		}
	}

	[Token(Token = "0x200067D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E00", Offset = "0x40E00")]
	private sealed class _003CUnplugRoutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x20")]
		public FrogKingLastStage _003C_003E4__this;

		[Token(Token = "0x17000353")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DBB")]
			[Address(RVA = "0x17AAFD0", Offset = "0x17AAFD0", VA = "0x17AAFD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000354")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x17AB018", Offset = "0x17AB018", VA = "0x17AB018", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x17AA604", Offset = "0x17AA604", VA = "0x17AA604")]
		[DebuggerHidden]
		public _003CUnplugRoutine_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x17AA630", Offset = "0x17AA630", VA = "0x17AA630", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x17AA634", Offset = "0x17AA634", VA = "0x17AA634", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x17AAFD0", Offset = "0x17AAFD0", VA = "0x17AAFD0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DBC")]
		[Address(RVA = "0x17AAFD8", Offset = "0x17AAFD8", VA = "0x17AAFD8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DBD")]
		[Address(RVA = "0x17AB018", Offset = "0x17AB018", VA = "0x17AB018", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200067E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E10", Offset = "0x40E10")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x40021C4")]
		[FieldOffset(Offset = "0x28")]
		public FrogKingLastStage _003C_003E4__this;

		[Token(Token = "0x6001DBE")]
		[Address(RVA = "0x17AA2CC", Offset = "0x17AA2CC", VA = "0x17AA2CC")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6001DBF")]
		[Address(RVA = "0x17AA2D4", Offset = "0x17AA2D4", VA = "0x17AA2D4")]
		internal void _003CMoveDown_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200067F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E20", Offset = "0x40E20")]
	private sealed class _003CMoveDown_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x20")]
		public Transform trans;

		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x28")]
		public FrogKingLastStage _003C_003E4__this;

		[Token(Token = "0x17000355")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DC3")]
			[Address(RVA = "0x17AA510", Offset = "0x17AA510", VA = "0x17AA510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000356")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DC5")]
			[Address(RVA = "0x17AA558", Offset = "0x17AA558", VA = "0x17AA558", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x17AA398", Offset = "0x17AA398", VA = "0x17AA398")]
		[DebuggerHidden]
		public _003CMoveDown_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DC1")]
		[Address(RVA = "0x17AA3C4", Offset = "0x17AA3C4", VA = "0x17AA3C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x17AA3C8", Offset = "0x17AA3C8", VA = "0x17AA3C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x17AA510", Offset = "0x17AA510", VA = "0x17AA510", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x17AA518", Offset = "0x17AA518", VA = "0x17AA518", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x17AA558", Offset = "0x17AA558", VA = "0x17AA558", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40021A7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CameraStandalone;

	[Token(Token = "0x40021A8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CameraMobile;

	[Token(Token = "0x40021A9")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 Gravity;

	[Token(Token = "0x40021AA")]
	[FieldOffset(Offset = "0x38")]
	public Animator PlugAnimation;

	[Token(Token = "0x40021AB")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem VortexParticles;

	[Token(Token = "0x40021AC")]
	[FieldOffset(Offset = "0x48")]
	public List<Transform> ObjectsToMoveDown;

	[Token(Token = "0x40021AD")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GoopSea;

	[Token(Token = "0x40021AE")]
	[FieldOffset(Offset = "0x58")]
	public float GoDownSpeed;

	[Token(Token = "0x40021AF")]
	[FieldOffset(Offset = "0x60")]
	public GolfBallController Player;

	[Token(Token = "0x40021B0")]
	[FieldOffset(Offset = "0x68")]
	public MeshRenderer GroundRenderer;

	[Token(Token = "0x40021B1")]
	[FieldOffset(Offset = "0x70")]
	public float SinkDepth;

	[Token(Token = "0x40021B2")]
	[FieldOffset(Offset = "0x78")]
	public ParticleSystem WinParticles;

	[Token(Token = "0x40021B3")]
	[FieldOffset(Offset = "0x80")]
	public AudioClipSettings endVortexSFX;

	[Token(Token = "0x40021B4")]
	[FieldOffset(Offset = "0x88")]
	public AudioSource birdsAudioSource;

	[Token(Token = "0x40021B5")]
	[FieldOffset(Offset = "0x90")]
	public AudioClipSettings confettiSFX;

	[Token(Token = "0x40021B6")]
	[FieldOffset(Offset = "0x98")]
	public uint triumpMusicState;

	[Token(Token = "0x40021B7")]
	[FieldOffset(Offset = "0xA0")]
	public OverworldMusicData triumphOverworldMusic;

	[Token(Token = "0x40021B8")]
	[FieldOffset(Offset = "0xA8")]
	private Coroutine outroRoutine;

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x14756C0", Offset = "0x14756C0", VA = "0x14756C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x14756D0", Offset = "0x14756D0", VA = "0x14756D0")]
	public IEnumerator PlayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x147572C", Offset = "0x147572C", VA = "0x147572C")]
	public void HitPlug()
	{
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x14757B8", Offset = "0x14757B8", VA = "0x14757B8")]
	private IEnumerator UnplugRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x147582C", Offset = "0x147582C", VA = "0x147582C")]
	private IEnumerator MoveDown(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x14758A4", Offset = "0x14758A4", VA = "0x14758A4")]
	public FrogKingLastStage()
	{
	}

	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x14758BC", Offset = "0x14758BC", VA = "0x14758BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648DC", Offset = "0x648DC")]
	private void _003CUnplugRoutine_003Eb__21_3(float s)
	{
	}

	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0x14758D8", Offset = "0x14758D8", VA = "0x14758D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648EC", Offset = "0x648EC")]
	private void _003CUnplugRoutine_003Eb__21_4(float t)
	{
	}
}
