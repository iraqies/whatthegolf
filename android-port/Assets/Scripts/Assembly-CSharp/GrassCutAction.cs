using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200023F")]
public class GrassCutAction : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000240")]
	public class SoccerPlayerOnGrass
	{
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x10")]
		public Transform TargetPosition;

		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x18")]
		public SoccerPlayer SoccerPlayer;

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x17B90C8", Offset = "0x17B90C8", VA = "0x17B90C8")]
		public SoccerPlayerOnGrass()
		{
		}
	}

	[Token(Token = "0x2000241")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E664", Offset = "0x3E664")]
	private sealed class _003CStartEndRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B90")]
		[FieldOffset(Offset = "0x20")]
		public GrassCutAction _003C_003E4__this;

		[Token(Token = "0x1700013D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x17B9078", Offset = "0x17B9078", VA = "0x17B9078", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700013E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x17B90C0", Offset = "0x17B90C0", VA = "0x17B90C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x17B8BC0", Offset = "0x17B8BC0", VA = "0x17B8BC0")]
		[DebuggerHidden]
		public _003CStartEndRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x17B8BEC", Offset = "0x17B8BEC", VA = "0x17B8BEC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x17B8BF0", Offset = "0x17B8BF0", VA = "0x17B8BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x17B9078", Offset = "0x17B9078", VA = "0x17B9078", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x17B9080", Offset = "0x17B9080", VA = "0x17B9080", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x17B90C0", Offset = "0x17B90C0", VA = "0x17B90C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000242")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E674", Offset = "0x3E674")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4000B91")]
		[FieldOffset(Offset = "0x10")]
		public SoccerPlayerOnGrass player;

		[Token(Token = "0x4000B92")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x17B8660", Offset = "0x17B8660", VA = "0x17B8660")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x17B8668", Offset = "0x17B8668", VA = "0x17B8668")]
		internal void _003CMovePlayer_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000243")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E684", Offset = "0x3E684")]
	private sealed class _003CMovePlayer_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B93")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B94")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B95")]
		[FieldOffset(Offset = "0x20")]
		public SoccerPlayerOnGrass player;

		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x28")]
		public GrassCutAction _003C_003E4__this;

		[Token(Token = "0x1700013F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x17B898C", Offset = "0x17B898C", VA = "0x17B898C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000140")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x17B89D4", Offset = "0x17B89D4", VA = "0x17B89D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x17B87C4", Offset = "0x17B87C4", VA = "0x17B87C4")]
		[DebuggerHidden]
		public _003CMovePlayer_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x17B87F0", Offset = "0x17B87F0", VA = "0x17B87F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x17B87F4", Offset = "0x17B87F4", VA = "0x17B87F4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x17B898C", Offset = "0x17B898C", VA = "0x17B898C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x17B8994", Offset = "0x17B8994", VA = "0x17B8994", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x17B89D4", Offset = "0x17B89D4", VA = "0x17B89D4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000244")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E694", Offset = "0x3E694")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x10")]
		public GrassCutAction _003C_003E4__this;

		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x18")]
		public float amplitudeGain;

		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x1C")]
		public float frequencyGain;

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x17B8740", Offset = "0x17B8740", VA = "0x17B8740")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x17B8748", Offset = "0x17B8748", VA = "0x17B8748")]
		internal void _003CShake_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000245")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E6A4", Offset = "0x3E6A4")]
	private sealed class _003CShake_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x20")]
		public GrassCutAction _003C_003E4__this;

		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x28")]
		public float amplitudeGain;

		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x2C")]
		public float frequencyGain;

		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x17000141")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x17B8B70", Offset = "0x17B8B70", VA = "0x17B8B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000142")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x17B8BB8", Offset = "0x17B8BB8", VA = "0x17B8BB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x17B89DC", Offset = "0x17B89DC", VA = "0x17B89DC")]
		[DebuggerHidden]
		public _003CShake_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x17B8A08", Offset = "0x17B8A08", VA = "0x17B8A08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x17B8A0C", Offset = "0x17B8A0C", VA = "0x17B8A0C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x17B8B70", Offset = "0x17B8B70", VA = "0x17B8B70", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x17B8B78", Offset = "0x17B8B78", VA = "0x17B8B78", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x17B8BB8", Offset = "0x17B8BB8", VA = "0x17B8BB8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x18")]
	public TerrainData GrassTerrain;

	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x20")]
	public float CheckInterval;

	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x24")]
	public int CheckRadius;

	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x28")]
	public List<SoccerPlayerOnGrass> Players;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Football;

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x38")]
	public Animator FlagAnimator;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x40")]
	public Animator CameraAnimator;

	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x48")]
	public CinemachineVirtualCamera Camera;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x50")]
	public ClipSettingsCollection MatchStartClip;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection TribuneMoveClip;

	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection PlayerActivatedClips;

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x68")]
	public ClipSettingsCollection AudienceCheer;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x70")]
	private float checkTimer;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x78")]
	private List<SoccerPlayerOnGrass> toBeRemoved;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x80")]
	private List<SoccerPlayerOnGrass> playersLeft;

	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x88")]
	private bool routineRunning;

	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x90")]
	private CinemachineBasicMultiChannelPerlin noise;

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x14B7048", Offset = "0x14B7048", VA = "0x14B7048")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x14B70FC", Offset = "0x14B70FC", VA = "0x14B70FC")]
	private IEnumerator StartEndRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x14B7170", Offset = "0x14B7170", VA = "0x14B7170")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x14B7850", Offset = "0x14B7850", VA = "0x14B7850")]
	private IEnumerator MovePlayer(SoccerPlayerOnGrass player)
	{
		return null;
	}

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x14B7754", Offset = "0x14B7754", VA = "0x14B7754")]
	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		return default;
	}

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x14B78C8", Offset = "0x14B78C8", VA = "0x14B78C8")]
	private IEnumerator Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x14B7960", Offset = "0x14B7960", VA = "0x14B7960")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x14B7C14", Offset = "0x14B7C14", VA = "0x14B7C14")]
	public GrassCutAction()
	{
	}
}
