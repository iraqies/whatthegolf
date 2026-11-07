using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200064B")]
public class BossStageSpawnPlayer : MonoBehaviour
{
	[Token(Token = "0x200064C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40BD0", Offset = "0x40BD0")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x40020A9")]
		[FieldOffset(Offset = "0x10")]
		public BossStageSpawnPlayer _003C_003E4__this;

		[Token(Token = "0x40020AA")]
		[FieldOffset(Offset = "0x18")]
		public BossPlayerEgg egg;

		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x177A6A8", Offset = "0x177A6A8", VA = "0x177A6A8")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0x177A6B0", Offset = "0x177A6B0", VA = "0x177A6B0")]
		internal void _003CSpawnPlayer_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x177A7C0", Offset = "0x177A7C0", VA = "0x177A7C0")]
		internal void _003CSpawnPlayer_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x200064D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40BE0", Offset = "0x40BE0")]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		[Token(Token = "0x40020AB")]
		[FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x177A87C", Offset = "0x177A87C", VA = "0x177A87C")]
		public _003C_003Ec__DisplayClass16_1()
		{
		}

		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x177A884", Offset = "0x177A884", VA = "0x177A884")]
		internal void _003CSpawnPlayer_003Eb__2(AudioSource m)
		{
		}
	}

	[Token(Token = "0x200064E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40BF0", Offset = "0x40BF0")]
	private sealed class _003CSpawnPlayer_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020AC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020AD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40020AE")]
		[FieldOffset(Offset = "0x20")]
		public BossStageSpawnPlayer _003C_003E4__this;

		[Token(Token = "0x40020AF")]
		[FieldOffset(Offset = "0x28")]
		public BossPlayerEgg egg;

		[Token(Token = "0x40020B0")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		[Token(Token = "0x40020B1")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass16_1 _003C_003E8__2;

		[Token(Token = "0x40020B2")]
		[FieldOffset(Offset = "0x40")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x40020B3")]
		[FieldOffset(Offset = "0x48")]
		private MeshRenderer _003CmeshRenderer_003E5__3;

		[Token(Token = "0x1700032D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x177B038", Offset = "0x177B038", VA = "0x177B038", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700032E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x177B080", Offset = "0x177B080", VA = "0x177B080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x177A8D8", Offset = "0x177A8D8", VA = "0x177A8D8")]
		[DebuggerHidden]
		public _003CSpawnPlayer_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x177A904", Offset = "0x177A904", VA = "0x177A904", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x177A908", Offset = "0x177A908", VA = "0x177A908", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x177B038", Offset = "0x177B038", VA = "0x177B038", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x177B040", Offset = "0x177B040", VA = "0x177B040", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x177B080", Offset = "0x177B080", VA = "0x177B080", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400209A")]
	[FieldOffset(Offset = "0x18")]
	public Transform SpawnPoint;

	[Token(Token = "0x400209B")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody PipeRigid;

	[Token(Token = "0x400209C")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem MachineParticles;

	[Token(Token = "0x400209D")]
	[FieldOffset(Offset = "0x30")]
	public List<MeshRenderer> Lights;

	[Token(Token = "0x400209E")]
	[FieldOffset(Offset = "0x38")]
	public Material OnMaterial;

	[Token(Token = "0x400209F")]
	[FieldOffset(Offset = "0x40")]
	public Material OffMaterial;

	[Token(Token = "0x40020A0")]
	[FieldOffset(Offset = "0x48")]
	public Transform HiddenControllerStartPosition;

	[Token(Token = "0x40020A1")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource PipeMove;

	[Token(Token = "0x40020A2")]
	[FieldOffset(Offset = "0x58")]
	public AudioClipSettings SteamSound;

	[Token(Token = "0x40020A3")]
	[FieldOffset(Offset = "0x60")]
	public AudioClipSettings EggSpawn;

	[Token(Token = "0x40020A4")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip LightsSound;

	[Token(Token = "0x40020A5")]
	[FieldOffset(Offset = "0x70")]
	private bool firstSpawn;

	[Token(Token = "0x40020A6")]
	[FieldOffset(Offset = "0x78")]
	public ParticleSystem BirthSystem;

	[Token(Token = "0x40020A7")]
	[FieldOffset(Offset = "0x80")]
	public Animator RobotFaceAnimator;

	[Token(Token = "0x40020A8")]
	[FieldOffset(Offset = "0x88")]
	public List<ParticleSystem> WheelTrails;

	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x1700E98", Offset = "0x1700E98", VA = "0x1700E98")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x1700EE0", Offset = "0x1700EE0", VA = "0x1700EE0")]
	public IEnumerator SpawnPlayer(BossPlayerEgg egg)
	{
		return null;
	}

	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x1700F58", Offset = "0x1700F58", VA = "0x1700F58")]
	public BossStageSpawnPlayer()
	{
	}
}
