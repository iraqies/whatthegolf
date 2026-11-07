using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x20002DC")]
public class HotdogGolfer : UserControlThirdPerson
{
	[Token(Token = "0x20002DD")]
	private enum GolfingState
	{
		[Token(Token = "0x4000FC5")]
		RUNNING = 0,
		[Token(Token = "0x4000FC6")]
		HOLD = 1,
		[Token(Token = "0x4000FC7")]
		RUN_TOWARDS = 2,
		[Token(Token = "0x4000FC8")]
		READY_TO_SHOOT = 3,
		[Token(Token = "0x4000FC9")]
		SHOOTING = 4
	}

	[Token(Token = "0x20002DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ED0C", Offset = "0x3ED0C")]
	private sealed class _003CShootRoutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x20")]
		public HotdogGolfer _003C_003E4__this;

		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x17000190")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D32")]
			[Address(RVA = "0x17C01D8", Offset = "0x17C01D8", VA = "0x17C01D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000191")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x17C0220", Offset = "0x17C0220", VA = "0x17C0220", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x17BFE90", Offset = "0x17BFE90", VA = "0x17BFE90")]
		[DebuggerHidden]
		public _003CShootRoutine_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x17BFEBC", Offset = "0x17BFEBC", VA = "0x17BFEBC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x17BFEC0", Offset = "0x17BFEC0", VA = "0x17BFEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x17C01D8", Offset = "0x17C01D8", VA = "0x17C01D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x17C01E0", Offset = "0x17C01E0", VA = "0x17C01E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x17C0220", Offset = "0x17C0220", VA = "0x17C0220", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject HotdogGolfBall;

	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float golfSwingPrepareTime;

	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float golfSwingHitTime;

	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float golferAimSideOffset;

	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float propExtraPushForce;

	[Token(Token = "0x4000FAF")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform TargetPosition;

	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform SpawnPosition;

	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x78")]
	public float ShootForce;

	[Token(Token = "0x4000FB2")]
	[FieldOffset(Offset = "0x7C")]
	public float ShootUpForce;

	[Token(Token = "0x4000FB3")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GolfBallController Controller;

	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x88")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000FB5")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Transform ArrowPosition;

	[Token(Token = "0x4000FB6")]
	[FieldOffset(Offset = "0x98")]
	public float MaxDistanceWhenAiming;

	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x9C")]
	public float sphereCastDist;

	[Token(Token = "0x4000FB8")]
	[FieldOffset(Offset = "0xA0")]
	private float lastNotGolfSwingingTime;

	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0xA8")]
	public ClipSettingsCollection ShootClip;

	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 aimDir;

	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0xBC")]
	private float sphereCastRadius;

	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0xC0")]
	private string animParamIsGolfSwinging;

	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0xC8")]
	private string animParamIsGolfSwingBlend;

	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0xD0")]
	private string staticObstacleLayer;

	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private PuppetMaster puppetMaster;

	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0xE0")]
	private GolfingState golfingState;

	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject currentBall;

	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0xF0")]
	private bool Winstate;

	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0xF4")]
	public float distanceGoodEnough;

	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x14DB0C0", Offset = "0x14DB0C0", VA = "0x14DB0C0")]
	public void SetToFreeRunning()
	{
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x14DB198", Offset = "0x14DB198", VA = "0x14DB198", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x14DB124", Offset = "0x14DB124", VA = "0x14DB124")]
	private void StartRunning()
	{
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x14DB358", Offset = "0x14DB358", VA = "0x14DB358")]
	private void FreeRunning()
	{
	}

	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x14DB36C", Offset = "0x14DB36C", VA = "0x14DB36C")]
	public void GotToGreen()
	{
	}

	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x14DB478", Offset = "0x14DB478", VA = "0x14DB478")]
	private void RunTowards()
	{
	}

	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x14DB3DC", Offset = "0x14DB3DC", VA = "0x14DB3DC")]
	private void OnReadyToShoot()
	{
	}

	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x14DB70C", Offset = "0x14DB70C", VA = "0x14DB70C")]
	private void ReadyToShoot()
	{
	}

	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x14DBA64", Offset = "0x14DBA64", VA = "0x14DBA64")]
	public void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x14DBB24", Offset = "0x14DBB24", VA = "0x14DBB24")]
	private IEnumerator ShootRoutine(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x14DBBBC", Offset = "0x14DBBBC", VA = "0x14DBBBC")]
	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x14DBBF8", Offset = "0x14DBBF8", VA = "0x14DBBF8", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x14DB5EC", Offset = "0x14DB5EC", VA = "0x14DB5EC")]
	private void SpawnNewGolfableBall()
	{
	}

	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x14DBC58", Offset = "0x14DBC58", VA = "0x14DBC58")]
	private void SetBallActive(bool active)
	{
	}

	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x14DBD14", Offset = "0x14DBD14", VA = "0x14DBD14")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x14DBDF8", Offset = "0x14DBDF8", VA = "0x14DBDF8")]
	public HotdogGolfer()
	{
	}

	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x14DBED0", Offset = "0x14DBED0", VA = "0x14DBED0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x607AC", Offset = "0x607AC")]
	private void _003CShootRoutine_003Eb__37_0(float t)
	{
	}
}
