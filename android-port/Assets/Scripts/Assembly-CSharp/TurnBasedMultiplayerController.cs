using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000150")]
public class TurnBasedMultiplayerController : MonoBehaviour
{
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC60", Offset = "0x3DC60")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController player;

		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x18")]
		public TurnBasedMultiplayerController _003C_003E4__this;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x186FDD8", Offset = "0x186FDD8", VA = "0x186FDD8")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x186FDE0", Offset = "0x186FDE0", VA = "0x186FDE0")]
		internal void _003COnMultiplayerSetup_003Eb__0(Vector3 b)
		{
		}
	}

	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC70", Offset = "0x3DC70")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x10")]
		public TurnBasedMultiplayerController _003C_003E4__this;

		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x18")]
		public int activePlayer;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x186FE04", Offset = "0x186FE04", VA = "0x186FE04")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x186FE0C", Offset = "0x186FE0C", VA = "0x186FE0C")]
		internal void _003CSetPlayer_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC80", Offset = "0x3DC80")]
	private sealed class _003CSetPlayer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x20")]
		public TurnBasedMultiplayerController _003C_003E4__this;

		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x28")]
		public int activePlayer;

		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x170000B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1870620", Offset = "0x1870620", VA = "0x1870620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1870668", Offset = "0x1870668", VA = "0x1870668", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x186FF90", Offset = "0x186FF90", VA = "0x186FF90")]
		[DebuggerHidden]
		public _003CSetPlayer_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x186FFBC", Offset = "0x186FFBC", VA = "0x186FFBC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x186FFC0", Offset = "0x186FFC0", VA = "0x186FFC0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1870620", Offset = "0x1870620", VA = "0x1870620", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1870628", Offset = "0x1870628", VA = "0x1870628", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1870668", Offset = "0x1870668", VA = "0x1870668", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC90", Offset = "0x3DC90")]
	private sealed class _003C_003COnDeath_003Eg__DeathRoutine_007C19_0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x20")]
		public TurnBasedMultiplayerController _003C_003E4__this;

		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x28")]
		public SuperGolfShooter shooter;

		[Token(Token = "0x170000BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x186FD88", Offset = "0x186FD88", VA = "0x186FD88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x186FDD0", Offset = "0x186FDD0", VA = "0x186FDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x186FC40", Offset = "0x186FC40", VA = "0x186FC40")]
		[DebuggerHidden]
		public _003C_003COnDeath_003Eg__DeathRoutine_007C19_0_003Ed(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x186FC6C", Offset = "0x186FC6C", VA = "0x186FC6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x186FC70", Offset = "0x186FC70", VA = "0x186FC70", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x186FD88", Offset = "0x186FD88", VA = "0x186FD88", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x186FD90", Offset = "0x186FD90", VA = "0x186FD90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x186FDD0", Offset = "0x186FDD0", VA = "0x186FDD0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x18")]
	public float SwitchPlayersThreshold;

	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x1C")]
	public float CameraSpeed;

	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x20")]
	public HorseJudge HorseJudge;

	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection ExplosionClip;

	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem ExplosionParticles;

	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x38")]
	public FinalLevel FinalLevel;

	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x40")]
	private int currentPlayerIndex;

	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x44")]
	private bool waitForPlayer;

	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x48")]
	private List<GolfBallController> players;

	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x50")]
	private List<SuperGolfShooter> shooters;

	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x58")]
	private List<Rigidbody> shooterRigidbodies;

	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x60")]
	private List<int> skipPlayers;

	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x68")]
	private float timer;

	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x70")]
	private GameObject cameraFollow;

	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x78")]
	private CBFollow followCam;

	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x80")]
	private bool somebodyDied;

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x1730B40", Offset = "0x1730B40", VA = "0x1730B40")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x1730BF8", Offset = "0x1730BF8", VA = "0x1730BF8")]
	private void OnMultiplayerSetup(MultiplayerLevelInfo info)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x17311F4", Offset = "0x17311F4", VA = "0x17311F4")]
	private void OnPlayerHit(SuperGolfShooter player)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x173121C", Offset = "0x173121C", VA = "0x173121C")]
	private void OnDeath(SuperGolfShooter obj)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x1731668", Offset = "0x1731668", VA = "0x1731668")]
	private void Controller_OnShoot(GolfBallController controller, Vector3 boost)
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x173166C", Offset = "0x173166C", VA = "0x173166C")]
	private IEnumerator SetPlayer(int activePlayer)
	{
		return null;
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x17316E8", Offset = "0x17316E8", VA = "0x17316E8")]
	private bool SetCameraTarget(Transform follow)
	{
		return default;
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x1731790", Offset = "0x1731790", VA = "0x1731790")]
	public TurnBasedMultiplayerController()
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x17315F0", Offset = "0x17315F0", VA = "0x17315F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E7E8", Offset = "0x5E7E8")]
	private IEnumerator _003COnDeath_003Eg__DeathRoutine_007C19_0(SuperGolfShooter shooter)
	{
		return null;
	}
}
