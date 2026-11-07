using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009C1")]
public class IntroAnimation : MonoBehaviour
{
	[Token(Token = "0x20009C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42690", Offset = "0x42690")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x10")]
		public IntroAnimation _003C_003E4__this;

		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x18")]
		public bool isWaitingForDoor;

		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x17C6E9C", Offset = "0x17C6E9C", VA = "0x17C6E9C")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x17C6EA4", Offset = "0x17C6EA4", VA = "0x17C6EA4")]
		internal void _003CIntroRoutine_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x17C6F24", Offset = "0x17C6F24", VA = "0x17C6F24")]
		internal void _003CIntroRoutine_003Eb__2(float v)
		{
		}

		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x17C6FAC", Offset = "0x17C6FAC", VA = "0x17C6FAC")]
		internal void _003CIntroRoutine_003Eb__3(float t)
		{
		}

		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x17C702C", Offset = "0x17C702C", VA = "0x17C702C")]
		internal void _003CIntroRoutine_003Eb__4(float t)
		{
		}

		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x17C70AC", Offset = "0x17C70AC", VA = "0x17C70AC")]
		internal void _003CIntroRoutine_003Eb__5(float t)
		{
		}

		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x17C712C", Offset = "0x17C712C", VA = "0x17C712C")]
		internal void _003CIntroRoutine_003Eb__6(float t)
		{
		}

		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x17C71AC", Offset = "0x17C71AC", VA = "0x17C71AC")]
		internal void _003CIntroRoutine_003Eb__7(float t)
		{
		}

		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x17C722C", Offset = "0x17C722C", VA = "0x17C722C")]
		internal void _003CIntroRoutine_003Eb__8(float t)
		{
		}

		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x17C72AC", Offset = "0x17C72AC", VA = "0x17C72AC")]
		internal void _003CIntroRoutine_003Eb__9(float t)
		{
		}

		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x17C732C", Offset = "0x17C732C", VA = "0x17C732C")]
		internal void _003CIntroRoutine_003Eb__10(float t)
		{
		}

		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x17C73AC", Offset = "0x17C73AC", VA = "0x17C73AC")]
		internal void _003CIntroRoutine_003Eb__11(float t)
		{
		}

		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x17C742C", Offset = "0x17C742C", VA = "0x17C742C")]
		internal void _003CIntroRoutine_003Eb__19(float v)
		{
		}

		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x17C74B4", Offset = "0x17C74B4", VA = "0x17C74B4")]
		internal void _003CIntroRoutine_003Eb__20()
		{
		}
	}

	[Token(Token = "0x20009C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x426A0", Offset = "0x426A0")]
	private sealed class _003C_003Ec__DisplayClass28_1
	{
		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x10")]
		public bool atEndOfTunnel;

		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x11")]
		public bool didInterrupt;

		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x12")]
		public bool isWaitingForSpeech;

		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x14")]
		public float maxWait;

		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x18")]
		public bool isWaitingForInterrupt;

		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x17C74BC", Offset = "0x17C74BC", VA = "0x17C74BC")]
		public _003C_003Ec__DisplayClass28_1()
		{
		}

		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x17C74C4", Offset = "0x17C74C4", VA = "0x17C74C4")]
		internal void _003CIntroRoutine_003Eb__0()
		{
		}

		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x17C74D0", Offset = "0x17C74D0", VA = "0x17C74D0")]
		internal void _003CIntroRoutine_003Eb__12()
		{
		}

		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x17C74DC", Offset = "0x17C74DC", VA = "0x17C74DC")]
		internal void _003CIntroRoutine_003Eb__13()
		{
		}

		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0x17C74E4", Offset = "0x17C74E4", VA = "0x17C74E4")]
		internal bool _003CIntroRoutine_003Eb__14()
		{
			return default;
		}

		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x17C74F4", Offset = "0x17C74F4", VA = "0x17C74F4")]
		internal bool _003CIntroRoutine_003Eb__15()
		{
			return default;
		}

		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x17C7530", Offset = "0x17C7530", VA = "0x17C7530")]
		internal void _003CIntroRoutine_003Eb__16()
		{
		}

		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x17C7538", Offset = "0x17C7538", VA = "0x17C7538")]
		internal void _003CIntroRoutine_003Eb__17()
		{
		}

		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x17C7540", Offset = "0x17C7540", VA = "0x17C7540")]
		internal bool _003CIntroRoutine_003Eb__18()
		{
			return default;
		}

		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x17C7550", Offset = "0x17C7550", VA = "0x17C7550")]
		internal bool _003CIntroRoutine_003Eb__21()
		{
			return default;
		}
	}

	[Token(Token = "0x20009C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x426B0", Offset = "0x426B0")]
	private sealed class _003CIntroRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x20")]
		public IntroAnimation _003C_003E4__this;

		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass28_1 _003C_003E8__2;

		[Token(Token = "0x170004BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DE8")]
			[Address(RVA = "0x17C88F4", Offset = "0x17C88F4", VA = "0x17C88F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DEA")]
			[Address(RVA = "0x17C893C", Offset = "0x17C893C", VA = "0x17C893C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x17C7560", Offset = "0x17C7560", VA = "0x17C7560")]
		[DebuggerHidden]
		public _003CIntroRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x17C758C", Offset = "0x17C758C", VA = "0x17C758C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x17C7590", Offset = "0x17C7590", VA = "0x17C7590", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x17C88F4", Offset = "0x17C88F4", VA = "0x17C88F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DE9")]
		[Address(RVA = "0x17C88FC", Offset = "0x17C88FC", VA = "0x17C88FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002DEA")]
		[Address(RVA = "0x17C893C", Offset = "0x17C893C", VA = "0x17C893C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400357F")]
	[FieldOffset(Offset = "0x18")]
	public IntroTunnelInOverworld tunnel;

	[Token(Token = "0x4003580")]
	[FieldOffset(Offset = "0x20")]
	public List<SpriteRenderer> backgrounds;

	[Token(Token = "0x4003581")]
	[FieldOffset(Offset = "0x28")]
	public List<SpriteRenderer> darkOverlays;

	[Token(Token = "0x4003582")]
	[FieldOffset(Offset = "0x30")]
	public Color bgnormalColor;

	[Token(Token = "0x4003583")]
	[FieldOffset(Offset = "0x40")]
	public Color bgdarkColor;

	[Token(Token = "0x4003584")]
	[FieldOffset(Offset = "0x50")]
	public SaveSpot save;

	[Token(Token = "0x4003585")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer hallwayOverlay;

	[Token(Token = "0x4003586")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer button;

	[Token(Token = "0x4003587")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer buttonBase;

	[Token(Token = "0x4003588")]
	[FieldOffset(Offset = "0x70")]
	public Color buttonOffColor;

	[Token(Token = "0x4003589")]
	[FieldOffset(Offset = "0x80")]
	public Color buttonBaseOffColor;

	[Token(Token = "0x400358A")]
	[FieldOffset(Offset = "0x90")]
	public SpriteRenderer darkScreen;

	[Token(Token = "0x400358B")]
	[FieldOffset(Offset = "0x98")]
	public ShowSpeechbubbleOnHit speechbubble;

	[Token(Token = "0x400358C")]
	[FieldOffset(Offset = "0xA0")]
	public Animator face;

	[Token(Token = "0x400358D")]
	[FieldOffset(Offset = "0xA8")]
	public OverworldButton2D door;

	[Token(Token = "0x400358E")]
	[FieldOffset(Offset = "0xB0")]
	public ParticleSystem buttonParticles;

	[Token(Token = "0x400358F")]
	[FieldOffset(Offset = "0xB8")]
	public ParticleSystem topRightParticles;

	[Token(Token = "0x4003590")]
	[FieldOffset(Offset = "0xC0")]
	public ParticleSystem topLeftParticles;

	[Token(Token = "0x4003591")]
	[FieldOffset(Offset = "0xC8")]
	public Color DarknessDark;

	[Token(Token = "0x4003592")]
	[FieldOffset(Offset = "0xD8")]
	public Color DarknessLight;

	[Token(Token = "0x4003593")]
	[FieldOffset(Offset = "0xE8")]
	public SpriteRenderer DarknessRenderer;

	[Token(Token = "0x4003594")]
	[FieldOffset(Offset = "0xF0")]
	public IntroComputer introComputer;

	[Token(Token = "0x4003595")]
	[FieldOffset(Offset = "0xF8")]
	public AudioClipSettings TurnOnLightClip;

	[Token(Token = "0x4003596")]
	[FieldOffset(Offset = "0x100")]
	public AudioClipSettings StaticNoiseClip;

	[Token(Token = "0x4003597")]
	[FieldOffset(Offset = "0x108")]
	public float ComputerOnVolume;

	[Token(Token = "0x4003598")]
	[FieldOffset(Offset = "0x110")]
	public AudioSource ComputerOnSource;

	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0x14F17B0", Offset = "0x14F17B0", VA = "0x14F17B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x14F19F4", Offset = "0x14F19F4", VA = "0x14F19F4")]
	private void Tunnel_OnAtLogo()
	{
	}

	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x14F1A70", Offset = "0x14F1A70", VA = "0x14F1A70")]
	private IEnumerator IntroRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x14F1AE4", Offset = "0x14F1AE4", VA = "0x14F1AE4")]
	public IntroAnimation()
	{
	}
}
