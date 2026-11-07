using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000888")]
public class TimeTravelController : MonoBehaviour
{
	[Token(Token = "0x2000889")]
	public enum StateEnum
	{
		[Token(Token = "0x4002EDB")]
		Countdown = 0,
		[Token(Token = "0x4002EDC")]
		Running = 1,
		[Token(Token = "0x4002EDD")]
		Rewining = 2,
		[Token(Token = "0x4002EDE")]
		Resetting = 3,
		[Token(Token = "0x4002EDF")]
		LevelEnded = 4
	}

	[Token(Token = "0x200088A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B40", Offset = "0x41B40")]
	private sealed class _003CEndCurrentTimeline_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x20")]
		public TimeTravelController _003C_003E4__this;

		[Token(Token = "0x1700042F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600276E")]
			[Address(RVA = "0x18677B8", Offset = "0x18677B8", VA = "0x18677B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000430")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002770")]
			[Address(RVA = "0x1867800", Offset = "0x1867800", VA = "0x1867800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600276B")]
		[Address(RVA = "0x18674F8", Offset = "0x18674F8", VA = "0x18674F8")]
		[DebuggerHidden]
		public _003CEndCurrentTimeline_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600276C")]
		[Address(RVA = "0x1867524", Offset = "0x1867524", VA = "0x1867524", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600276D")]
		[Address(RVA = "0x1867528", Offset = "0x1867528", VA = "0x1867528", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600276E")]
		[Address(RVA = "0x18677B8", Offset = "0x18677B8", VA = "0x18677B8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600276F")]
		[Address(RVA = "0x18677C0", Offset = "0x18677C0", VA = "0x18677C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002770")]
		[Address(RVA = "0x1867800", Offset = "0x1867800", VA = "0x1867800", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002EC4")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F47C", Offset = "0x4F47C")]
	private StateEnum GameState__BackingField;

	[Token(Token = "0x4002EC5")]
	[FieldOffset(Offset = "0x1C")]
	public float TimeLimitInSeconds;

	[Token(Token = "0x4002EC6")]
	[FieldOffset(Offset = "0x20")]
	public int TimeLinesLimit;

	[Token(Token = "0x4002EC7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ReplayPlayerPrefab;

	[Token(Token = "0x4002EC8")]
	[FieldOffset(Offset = "0x30")]
	public Recorder PlayerRecorder;

	[Token(Token = "0x4002EC9")]
	[FieldOffset(Offset = "0x0")]
	public static float CurrentTime;

	[Token(Token = "0x4002ECA")]
	[FieldOffset(Offset = "0x4")]
	public static float Interval;

	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> SpawnPoints;

	[Token(Token = "0x4002ECC")]
	[FieldOffset(Offset = "0x40")]
	public float RewindSpeed;

	[Token(Token = "0x4002ECD")]
	[FieldOffset(Offset = "0x44")]
	public bool IsRewining;

	[Token(Token = "0x4002ECE")]
	[FieldOffset(Offset = "0x48")]
	public float TimeLimitIncrement;

	[Token(Token = "0x4002ECF")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem SpawnParticles;

	[Token(Token = "0x4002ED0")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshPro InfoText;

	[Token(Token = "0x4002ED1")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallController golfController;

	[Token(Token = "0x4002ED2")]
	[FieldOffset(Offset = "0x68")]
	private int numberOfTimeLines;

	[Token(Token = "0x4002ED3")]
	[FieldOffset(Offset = "0x70")]
	private List<Replayer> spawnedReplayers;

	[Token(Token = "0x4002ED4")]
	[FieldOffset(Offset = "0x78")]
	private float longestTimeline;

	[Token(Token = "0x4002ED5")]
	[FieldOffset(Offset = "0x80")]
	private CameraFilterPack_TV_VHS_Rewind rewind;

	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x88")]
	private LevelGate[] gates;

	[Token(Token = "0x4002ED7")]
	[FieldOffset(Offset = "0x90")]
	private bool stopCountdown;

	[Token(Token = "0x4002ED8")]
	[FieldOffset(Offset = "0x98")]
	private Replayer playerReplayer;

	[Token(Token = "0x4002ED9")]
	[FieldOffset(Offset = "0xA0")]
	private TimeControl timeControl;

	[Token(Token = "0x1700042E")]
	public StateEnum GameState
	{
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x1716D00", Offset = "0x1716D00", VA = "0x1716D00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66EA0", Offset = "0x66EA0")]
		get
		{
			return default;
		}
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x1716D08", Offset = "0x1716D08", VA = "0x1716D08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66EB0", Offset = "0x66EB0")]
		private set
		{
		}
	}

	[Token(Token = "0x6002760")]
	[Address(RVA = "0x1716D10", Offset = "0x1716D10", VA = "0x1716D10")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x66EC0", Offset = "0x66EC0")]
	private static void Init()
	{
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0x1716D7C", Offset = "0x1716D7C", VA = "0x1716D7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002762")]
	[Address(RVA = "0x1717040", Offset = "0x1717040", VA = "0x1717040")]
	private void GolfGoalOnOnComplete(string message)
	{
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x171704C", Offset = "0x171704C", VA = "0x171704C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x17179C4", Offset = "0x17179C4", VA = "0x17179C4")]
	public void ResetCurrentTimeline()
	{
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0x171781C", Offset = "0x171781C", VA = "0x171781C")]
	private IEnumerator EndCurrentTimeline()
	{
		return null;
	}

	[Token(Token = "0x6002766")]
	[Address(RVA = "0x1717420", Offset = "0x1717420", VA = "0x1717420")]
	private void SpawnNewTimeline()
	{
	}

	[Token(Token = "0x6002767")]
	[Address(RVA = "0x1717890", Offset = "0x1717890", VA = "0x1717890")]
	private void SetInfoText()
	{
	}

	[Token(Token = "0x6002768")]
	[Address(RVA = "0x1717A68", Offset = "0x1717A68", VA = "0x1717A68")]
	public TimeTravelController()
	{
	}

	[Token(Token = "0x600276A")]
	[Address(RVA = "0x1717AE0", Offset = "0x1717AE0", VA = "0x1717AE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66ED4", Offset = "0x66ED4")]
	private void _003CAwake_003Eb__27_0(Vector3 v)
	{
	}
}
