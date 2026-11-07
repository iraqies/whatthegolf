using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000645")]
public class BossStage : MonoBehaviour
{
	[Token(Token = "0x2000646")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40BA0", Offset = "0x40BA0")]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		[Token(Token = "0x4002085")]
		[FieldOffset(Offset = "0x10")]
		public bool isPlaying;

		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x1779AD0", Offset = "0x1779AD0", VA = "0x1779AD0")]
		public _003C_003Ec__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x1779AD8", Offset = "0x1779AD8", VA = "0x1779AD8")]
		internal void _003CPlay_003Eb__0(string g)
		{
		}
	}

	[Token(Token = "0x2000647")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40BB0", Offset = "0x40BB0")]
	private sealed class _003CPlay_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002086")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002087")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002088")]
		[FieldOffset(Offset = "0x20")]
		public BossStage _003C_003E4__this;

		[Token(Token = "0x4002089")]
		[FieldOffset(Offset = "0x28")]
		public BossStageSpawnPlayer eggSpawner;

		[Token(Token = "0x400208A")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

		[Token(Token = "0x17000329")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CB1")]
			[Address(RVA = "0x1779D08", Offset = "0x1779D08", VA = "0x1779D08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700032A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CB3")]
			[Address(RVA = "0x1779D50", Offset = "0x1779D50", VA = "0x1779D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x1779AE0", Offset = "0x1779AE0", VA = "0x1779AE0")]
		[DebuggerHidden]
		public _003CPlay_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x1779B0C", Offset = "0x1779B0C", VA = "0x1779B0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x1779B10", Offset = "0x1779B10", VA = "0x1779B10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x1779D08", Offset = "0x1779D08", VA = "0x1779D08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x1779D10", Offset = "0x1779D10", VA = "0x1779D10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x1779D50", Offset = "0x1779D50", VA = "0x1779D50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400206A")]
	[FieldOffset(Offset = "0x18")]
	public BossPlayerEgg Egg;

	[Token(Token = "0x400206B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CameraBehaviorPerspective cameraBehaviour;

	[Token(Token = "0x400206C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CameraBehaviorPerspective cameraBehaviourMobile;

	[Token(Token = "0x400206D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CinemachineVirtualCamera virtualCameraBehaviour;

	[Token(Token = "0x400206E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CinemachineVirtualCamera virtualCameraBehaviourMobile;

	[Token(Token = "0x400206F")]
	[FieldOffset(Offset = "0x40")]
	public float gravity;

	[Token(Token = "0x4002070")]
	[FieldOffset(Offset = "0x44")]
	public float wheelParticlesGravityMultiplier;

	[Token(Token = "0x4002071")]
	[FieldOffset(Offset = "0x48")]
	public bool MoveStageToBoss;

	[Token(Token = "0x4002072")]
	[FieldOffset(Offset = "0x50")]
	public List<BossIslandPart> StageIslands;

	[Token(Token = "0x4002073")]
	[FieldOffset(Offset = "0x58")]
	public int IslandsToPrepare;

	[Token(Token = "0x4002074")]
	[FieldOffset(Offset = "0x5C")]
	public float InitialDistanceBuffer;

	[Token(Token = "0x4002075")]
	[FieldOffset(Offset = "0x60")]
	public bool GoNearNextEndPointOnStart;

	[Token(Token = "0x4002076")]
	[FieldOffset(Offset = "0x61")]
	public bool InitCamera;

	[Token(Token = "0x4002077")]
	[FieldOffset(Offset = "0x64")]
	public float DelayCameraBehaviourBlendTime;

	[Token(Token = "0x4002078")]
	[FieldOffset(Offset = "0x68")]
	public float AimTimeScale;

	[Token(Token = "0x4002079")]
	[FieldOffset(Offset = "0x6C")]
	public float UpSpeed;

	[Token(Token = "0x400207A")]
	[FieldOffset(Offset = "0x70")]
	public float DownSpeed;

	[Token(Token = "0x400207B")]
	[FieldOffset(Offset = "0x74")]
	public bool ShowVisualEffect;

	[Token(Token = "0x400207C")]
	[FieldOffset(Offset = "0x78")]
	public BossStageMusic music;

	[Token(Token = "0x400207D")]
	[FieldOffset(Offset = "0x80")]
	public bool ScreenFaceForwardOnStageStart;

	[Token(Token = "0x400207E")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E46C", Offset = "0x4E46C")]
	private Action<IEnumerator> m_OnChallengeIntro;

	[Token(Token = "0x400207F")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E47C", Offset = "0x4E47C")]
	private Action m_OnChallengeBegin;

	[Token(Token = "0x4002080")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E48C", Offset = "0x4E48C")]
	private Action m_OnChallengeEnd;

	[Token(Token = "0x4002081")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E49C", Offset = "0x4E49C")]
	private Action m_OnChallengeUpdate;

	[Token(Token = "0x4002082")]
	[FieldOffset(Offset = "0xA8")]
	public bool OnlySpawnOneIsland;

	[Token(Token = "0x4002083")]
	[FieldOffset(Offset = "0xB0")]
	public string CameraTriggerName;

	[Token(Token = "0x4002084")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 goalPosition;

	[Token(Token = "0x14000028")]
	public event Action<IEnumerator> OnChallengeIntro
	{
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x170046C", Offset = "0x170046C", VA = "0x170046C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6415C", Offset = "0x6415C")]
		add
		{
		}
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x1700510", Offset = "0x1700510", VA = "0x1700510")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6416C", Offset = "0x6416C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000029")]
	public event Action OnChallengeBegin
	{
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x16FA5BC", Offset = "0x16FA5BC", VA = "0x16FA5BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6417C", Offset = "0x6417C")]
		add
		{
		}
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x17005B4", Offset = "0x17005B4", VA = "0x17005B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6418C", Offset = "0x6418C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002A")]
	public event Action OnChallengeEnd
	{
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x16FA660", Offset = "0x16FA660", VA = "0x16FA660")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6419C", Offset = "0x6419C")]
		add
		{
		}
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x1700658", Offset = "0x1700658", VA = "0x1700658")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641AC", Offset = "0x641AC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002B")]
	public event Action OnChallengeUpdate
	{
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x17006FC", Offset = "0x17006FC", VA = "0x17006FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641BC", Offset = "0x641BC")]
		add
		{
		}
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x17007A0", Offset = "0x17007A0", VA = "0x17007A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641CC", Offset = "0x641CC")]
		remove
		{
		}
	}

	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x1700844", Offset = "0x1700844", VA = "0x1700844")]
	public void SetupBeforePlay(Vector3 lastGoalPosition)
	{
	}

	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0x170087C", Offset = "0x170087C", VA = "0x170087C")]
	public IEnumerator Play(BossStageSpawnPlayer eggSpawner)
	{
		return null;
	}

	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0x17008F4", Offset = "0x17008F4", VA = "0x17008F4")]
	public Vector3 GetGoalPosition()
	{
		return default;
	}

	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0x1700900", Offset = "0x1700900", VA = "0x1700900")]
	public CameraBehaviorPerspective GetCameraBehaviour()
	{
		return null;
	}

	[Token(Token = "0x6001CAA")]
	[Address(RVA = "0x1700980", Offset = "0x1700980", VA = "0x1700980")]
	public CinemachineVirtualCamera GetVirtualCameraBehaviour()
	{
		return null;
	}

	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x1700A00", Offset = "0x1700A00", VA = "0x1700A00")]
	public BossStage()
	{
	}
}
