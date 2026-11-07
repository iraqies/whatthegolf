using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000672")]
public class FinalBoss : MonoBehaviour
{
	[Token(Token = "0x2000673")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D80", Offset = "0x40D80")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0x10")]
		public BossStage lastStage;

		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0x18")]
		public FinalBoss _003C_003E4__this;

		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x20")]
		public Action<float> _003C_003E9__4;

		[Token(Token = "0x4002191")]
		[FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__6;

		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x17A3D14", Offset = "0x17A3D14", VA = "0x17A3D14")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x17A3D1C", Offset = "0x17A3D1C", VA = "0x17A3D1C")]
		internal void _003CPlayRoutine_003Eb__4(float g)
		{
		}

		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x17A3D48", Offset = "0x17A3D48", VA = "0x17A3D48")]
		internal void _003CPlayRoutine_003Eb__6()
		{
		}
	}

	[Token(Token = "0x2000674")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D90", Offset = "0x40D90")]
	private sealed class _003C_003Ec__DisplayClass29_1
	{
		[Token(Token = "0x4002192")]
		[FieldOffset(Offset = "0x10")]
		public BossStage stage;

		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x17A3D74", Offset = "0x17A3D74", VA = "0x17A3D74")]
		public _003C_003Ec__DisplayClass29_1()
		{
		}

		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x17A3D7C", Offset = "0x17A3D7C", VA = "0x17A3D7C")]
		internal void _003CPlayRoutine_003Eb__2(float t)
		{
		}

		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x17A3EBC", Offset = "0x17A3EBC", VA = "0x17A3EBC")]
		internal void _003CPlayRoutine_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000675")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40DA0", Offset = "0x40DA0")]
	private sealed class _003C_003Ec__DisplayClass29_2
	{
		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 startPos;

		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass29_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x17A3EF8", Offset = "0x17A3EF8", VA = "0x17A3EF8")]
		public _003C_003Ec__DisplayClass29_2()
		{
		}

		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x17A3F00", Offset = "0x17A3F00", VA = "0x17A3F00")]
		internal void _003CPlayRoutine_003Eb__7(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000676")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40DB0", Offset = "0x40DB0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x8")]
		public static Func<BossIslandPart, GameObject> _003C_003E9__29_0;

		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__29_1;

		[Token(Token = "0x4002199")]
		[FieldOffset(Offset = "0x18")]
		public static Action<float> _003C_003E9__29_5;

		[Token(Token = "0x400219A")]
		[FieldOffset(Offset = "0x20")]
		public static Func<GameObject, BossIslandPart> _003C_003E9__31_0;

		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x17A3C94", Offset = "0x17A3C94", VA = "0x17A3C94")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x17A3C9C", Offset = "0x17A3C9C", VA = "0x17A3C9C")]
		internal GameObject _003CPlayRoutine_003Eb__29_0(BossIslandPart i)
		{
			return null;
		}

		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x17A3CB8", Offset = "0x17A3CB8", VA = "0x17A3CB8")]
		internal void _003CPlayRoutine_003Eb__29_1(float t)
		{
		}

		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x17A3CBC", Offset = "0x17A3CBC", VA = "0x17A3CBC")]
		internal void _003CPlayRoutine_003Eb__29_5(float t)
		{
		}

		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x17A3CC0", Offset = "0x17A3CC0", VA = "0x17A3CC0")]
		internal BossIslandPart _003CGetAllActiveIslands_003Eb__31_0(GameObject g)
		{
			return null;
		}
	}

	[Token(Token = "0x2000677")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40DC0", Offset = "0x40DC0")]
	private sealed class _003CPlayRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x20")]
		public FinalBoss _003C_003E4__this;

		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		[Token(Token = "0x400219F")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass29_1 _003C_003E8__2;

		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator<BossStage> _003C_003E7__wrap1;

		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _003CendPos_003E5__3;

		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x4C")]
		private float _003Cspd_003E5__4;

		[Token(Token = "0x1700034D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D9B")]
			[Address(RVA = "0x17A6068", Offset = "0x17A6068", VA = "0x17A6068", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700034E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D9D")]
			[Address(RVA = "0x17A60B0", Offset = "0x17A60B0", VA = "0x17A60B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x17A4058", Offset = "0x17A4058", VA = "0x17A4058")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x17A4084", Offset = "0x17A4084", VA = "0x17A4084", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x17A4220", Offset = "0x17A4220", VA = "0x17A4220", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x17A415C", Offset = "0x17A415C", VA = "0x17A415C")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x17A6068", Offset = "0x17A6068", VA = "0x17A6068", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x17A6070", Offset = "0x17A6070", VA = "0x17A6070", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x17A60B0", Offset = "0x17A60B0", VA = "0x17A60B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000678")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40DD0", Offset = "0x40DD0")]
	private sealed class _003CWaitLockRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController controller;

		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x28")]
		public FinalBoss _003C_003E4__this;

		[Token(Token = "0x1700034F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DA1")]
			[Address(RVA = "0x17A6214", Offset = "0x17A6214", VA = "0x17A6214", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000350")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x17A625C", Offset = "0x17A625C", VA = "0x17A625C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x17A60B8", Offset = "0x17A60B8", VA = "0x17A60B8")]
		[DebuggerHidden]
		public _003CWaitLockRoutine_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x17A60E4", Offset = "0x17A60E4", VA = "0x17A60E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x17A60E8", Offset = "0x17A60E8", VA = "0x17A60E8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x17A6214", Offset = "0x17A6214", VA = "0x17A6214", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x17A621C", Offset = "0x17A621C", VA = "0x17A621C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x17A625C", Offset = "0x17A625C", VA = "0x17A625C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002173")]
	[FieldOffset(Offset = "0x18")]
	public FinalBossStages stages;

	[Token(Token = "0x4002174")]
	[FieldOffset(Offset = "0x20")]
	public FinalBossStages testStages;

	[Token(Token = "0x4002175")]
	[FieldOffset(Offset = "0x28")]
	public bool UseTestStages;

	[Token(Token = "0x4002176")]
	[FieldOffset(Offset = "0x30")]
	public CameraBehaviorPerspective introCamera;

	[Token(Token = "0x4002177")]
	[FieldOffset(Offset = "0x38")]
	public CBBlend cameraBlend;

	[Token(Token = "0x4002178")]
	[FieldOffset(Offset = "0x40")]
	public Gravity gravity;

	[Token(Token = "0x4002179")]
	[FieldOffset(Offset = "0x48")]
	public BossStageSpawnPlayer PlayerSpawner;

	[Token(Token = "0x400217A")]
	[FieldOffset(Offset = "0x50")]
	public Rigidbody BossRigid;

	[Token(Token = "0x400217B")]
	[FieldOffset(Offset = "0x58")]
	public Action<BossStage> OnStageInitiating;

	[Token(Token = "0x400217C")]
	[FieldOffset(Offset = "0x60")]
	public Action<BossStage> OnStageStarted;

	[Token(Token = "0x400217D")]
	[FieldOffset(Offset = "0x68")]
	public Action<BossStage> OnStageEnding;

	[Token(Token = "0x400217E")]
	[FieldOffset(Offset = "0x70")]
	public Animator BossCarAnimator;

	[Token(Token = "0x400217F")]
	[FieldOffset(Offset = "0x78")]
	public Animator BossCarBaseAnimator;

	[Token(Token = "0x4002180")]
	[FieldOffset(Offset = "0x80")]
	public Animator BossCarBreakingAnimator;

	[Token(Token = "0x4002181")]
	[FieldOffset(Offset = "0x88")]
	public BossSHMUP ShmupStage;

	[Token(Token = "0x4002182")]
	[FieldOffset(Offset = "0x90")]
	public BossFrogKingInside FrogInsides;

	[Token(Token = "0x4002183")]
	[FieldOffset(Offset = "0x98")]
	public FrogKingLastStage LastStage;

	[Token(Token = "0x4002184")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject FrogKingInside;

	[Token(Token = "0x4002185")]
	[FieldOffset(Offset = "0xA8")]
	public Animator CameraStageAnimator;

	[Token(Token = "0x4002186")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject CamerasMobile;

	[Token(Token = "0x4002187")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject CamerasStandalone;

	[Token(Token = "0x4002188")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 lastGoalPosition;

	[Token(Token = "0x4002189")]
	[FieldOffset(Offset = "0xD0")]
	private TimeControl timeControl;

	[Token(Token = "0x400218A")]
	[FieldOffset(Offset = "0xD8")]
	private BossIslands bossIslands;

	[Token(Token = "0x400218B")]
	[FieldOffset(Offset = "0xE0")]
	private bool waitLock;

	[Token(Token = "0x400218C")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<BossStage, ObjectPool<BossIslandPart>> islandPool;

	[Token(Token = "0x400218D")]
	[FieldOffset(Offset = "0xF0")]
	public ParticleSystem[] WheelSystems;

	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x1464064", Offset = "0x1464064", VA = "0x1464064")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x146447C", Offset = "0x146447C", VA = "0x146447C")]
	public bool GetIslandPoolForStage(BossStage stage, out ObjectPool<BossIslandPart> pool)
	{
		return default;
	}

	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x146452C", Offset = "0x146452C", VA = "0x146452C")]
	public IEnumerator PlayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x14645A0", Offset = "0x14645A0", VA = "0x14645A0")]
	private IEnumerator WaitLockRoutine(GolfBallController controller)
	{
		return null;
	}

	[Token(Token = "0x6001D87")]
	[Address(RVA = "0x1464618", Offset = "0x1464618", VA = "0x1464618")]
	public List<BossIslandPart> GetAllActiveIslands()
	{
		return null;
	}

	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x1464938", Offset = "0x1464938", VA = "0x1464938")]
	public FinalBoss()
	{
	}
}
