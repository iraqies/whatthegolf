using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A42")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x42BA0", Offset = "0x42BA0")]
public class ShortcutTunnel : MonoBehaviour
{
	[Token(Token = "0x2000A43")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42BB4", Offset = "0x42BB4")]
	private sealed class _003CTraverseTunnelRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40038B1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40038B2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40038B3")]
		[FieldOffset(Offset = "0x20")]
		public ShortcutTunnelTraversable thing;

		[Token(Token = "0x40038B4")]
		[FieldOffset(Offset = "0x28")]
		public ShortcutTunnel _003C_003E4__this;

		[Token(Token = "0x40038B5")]
		[FieldOffset(Offset = "0x30")]
		public ShortcutTunnelEntry entry;

		[Token(Token = "0x40038B6")]
		[FieldOffset(Offset = "0x38")]
		private OverworldBall2D _003Cball_003E5__2;

		[Token(Token = "0x40038B7")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _003CstartPosition_003E5__3;

		[Token(Token = "0x40038B8")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _003ClastPosition_003E5__4;

		[Token(Token = "0x40038B9")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _003Cdir_003E5__5;

		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x64")]
		private float _003CtraverseSpeed_003E5__6;

		[Token(Token = "0x40038BB")]
		[FieldOffset(Offset = "0x68")]
		private float _003ClastSoundTime_003E5__7;

		[Token(Token = "0x40038BC")]
		[FieldOffset(Offset = "0x6C")]
		private float _003CtotalDistance_003E5__8;

		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0x70")]
		private float _003CdistanceCrossed_003E5__9;

		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0x74")]
		private float _003CejectTime_003E5__10;

		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x78")]
		private int _003Ci_003E5__11;

		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x7C")]
		private int _003Cc_003E5__12;

		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 _003CnewPosition_003E5__13;

		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0x8C")]
		private float _003Cend_003E5__14;

		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0x90")]
		private float _003CdurationInv_003E5__15;

		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0x94")]
		private float _003CstartMulDurationInv_003E5__16;

		[Token(Token = "0x40038C5")]
		[FieldOffset(Offset = "0x98")]
		private float _003CstartValue_003E5__17;

		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x9C")]
		private float _003CendValue_003E5__18;

		[Token(Token = "0x40038C7")]
		[FieldOffset(Offset = "0xA0")]
		private float _003Ct_003E5__19;

		[Token(Token = "0x1700050C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x184A6EC", Offset = "0x184A6EC", VA = "0x184A6EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700050D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030F2")]
			[Address(RVA = "0x184A734", Offset = "0x184A734", VA = "0x184A734", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60030ED")]
		[Address(RVA = "0x1849CAC", Offset = "0x1849CAC", VA = "0x1849CAC")]
		[DebuggerHidden]
		public _003CTraverseTunnelRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x1849CD8", Offset = "0x1849CD8", VA = "0x1849CD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x1849CDC", Offset = "0x1849CDC", VA = "0x1849CDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60030F0")]
		[Address(RVA = "0x184A6EC", Offset = "0x184A6EC", VA = "0x184A6EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x184A6F4", Offset = "0x184A6F4", VA = "0x184A6F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60030F2")]
		[Address(RVA = "0x184A734", Offset = "0x184A734", VA = "0x184A734", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40038A1")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503D4", Offset = "0x503D4")]
	private Action<ShortcutTunnel> m_OnBallEnterTunnel;

	[Token(Token = "0x40038A2")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E4", Offset = "0x503E4")]
	private Action<ShortcutTunnel> m_OnBallExitTunnel;

	[Token(Token = "0x40038A3")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F4", Offset = "0x503F4")]
	private Action<float> m_OnMovementUpdate;

	[Token(Token = "0x40038A4")]
	[FieldOffset(Offset = "0x30")]
	public Transform pathContainer;

	[Token(Token = "0x40038A5")]
	[FieldOffset(Offset = "0x38")]
	public bool useCameraBlend;

	[Token(Token = "0x40038A6")]
	[FieldOffset(Offset = "0x3C")]
	public float speed;

	[Token(Token = "0x40038A7")]
	[FieldOffset(Offset = "0x40")]
	public float shootoutSpeed;

	[Token(Token = "0x40038A8")]
	[FieldOffset(Offset = "0x44")]
	public float shootOutOffset;

	[Token(Token = "0x40038A9")]
	[FieldOffset(Offset = "0x48")]
	public RandomAudioClips clips;

	[Token(Token = "0x40038AA")]
	[FieldOffset(Offset = "0x50")]
	public RandomAudioClips tunnelHitClips;

	[Token(Token = "0x40038AB")]
	[FieldOffset(Offset = "0x58")]
	public RumbleEventAsset rumbleOnCorner;

	[Token(Token = "0x40038AC")]
	[FieldOffset(Offset = "0x60")]
	private ShortcutTunnelEntry[] entries;

	[Token(Token = "0x40038AD")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine movementRoutine;

	[Token(Token = "0x40038AE")]
	[FieldOffset(Offset = "0x70")]
	private bool isTraveling;

	[Token(Token = "0x40038AF")]
	[FieldOffset(Offset = "0x78")]
	private ShortcutTunnelTraversable lastThing;

	[Token(Token = "0x40038B0")]
	[FieldOffset(Offset = "0x80")]
	private bool isPaused;

	[Token(Token = "0x14000064")]
	public event Action<ShortcutTunnel> OnBallEnterTunnel
	{
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x16A4AFC", Offset = "0x16A4AFC", VA = "0x16A4AFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69624", Offset = "0x69624")]
		add
		{
		}
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x16A4BA0", Offset = "0x16A4BA0", VA = "0x16A4BA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69634", Offset = "0x69634")]
		remove
		{
		}
	}

	[Token(Token = "0x14000065")]
	public event Action<ShortcutTunnel> OnBallExitTunnel
	{
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x16A4C44", Offset = "0x16A4C44", VA = "0x16A4C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69644", Offset = "0x69644")]
		add
		{
		}
		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x16A4CE8", Offset = "0x16A4CE8", VA = "0x16A4CE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69654", Offset = "0x69654")]
		remove
		{
		}
	}

	[Token(Token = "0x14000066")]
	public event Action<float> OnMovementUpdate
	{
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x16A4D8C", Offset = "0x16A4D8C", VA = "0x16A4D8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69664", Offset = "0x69664")]
		add
		{
		}
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x16A4E30", Offset = "0x16A4E30", VA = "0x16A4E30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69674", Offset = "0x69674")]
		remove
		{
		}
	}

	[Token(Token = "0x60030E5")]
	[Address(RVA = "0x16A4ED4", Offset = "0x16A4ED4", VA = "0x16A4ED4")]
	public void Start()
	{
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0x16A5104", Offset = "0x16A5104", VA = "0x16A5104")]
	public void Pause()
	{
	}

	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x16A5110", Offset = "0x16A5110", VA = "0x16A5110")]
	public void Resume()
	{
	}

	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x16A5118", Offset = "0x16A5118", VA = "0x16A5118")]
	private void Entry_OnEntered(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
	}

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x16A523C", Offset = "0x16A523C", VA = "0x16A523C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x16A5258", Offset = "0x16A5258", VA = "0x16A5258")]
	public void KillTravel()
	{
	}

	[Token(Token = "0x60030EB")]
	[Address(RVA = "0x16A51B4", Offset = "0x16A51B4", VA = "0x16A51B4")]
	private IEnumerator TraverseTunnelRoutine(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		return null;
	}

	[Token(Token = "0x60030EC")]
	[Address(RVA = "0x16A5748", Offset = "0x16A5748", VA = "0x16A5748")]
	public ShortcutTunnel()
	{
	}
}
