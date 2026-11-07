using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using WwiseData;
using WwiseInteractiveMusicHierarchyData;

[Serializable]
[Token(Token = "0x2000D27")]
public class MusicPlaylist : MonoBehaviour
{
	[Token(Token = "0x2000D28")]
	public enum LoopTypes
	{
		[Token(Token = "0x400477F")]
		sequenceContinues = 0,
		[Token(Token = "0x4004780")]
		randomContinues = 1,
		[Token(Token = "0x4004781")]
		randomStep = 2
	}

	[Token(Token = "0x2000D29")]
	public enum PlaylistState
	{
		[Token(Token = "0x4004783")]
		playing = 0,
		[Token(Token = "0x4004784")]
		stopping = 1,
		[Token(Token = "0x4004785")]
		none = 2
	}

	[Serializable]
	[Token(Token = "0x2000D2A")]
	public class MusicSegmentBuffer
	{
		[Token(Token = "0x4004786")]
		[FieldOffset(Offset = "0x10")]
		public int nextIndex;

		[Token(Token = "0x4004787")]
		[FieldOffset(Offset = "0x18")]
		public List<MusicSegment> segments;

		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x180635C", Offset = "0x180635C", VA = "0x180635C")]
		public MusicSegment GetSegment(bool increment)
		{
			return null;
		}

		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x18060A0", Offset = "0x18060A0", VA = "0x18060A0")]
		public void Stop()
		{
		}

		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x1806410", Offset = "0x1806410", VA = "0x1806410")]
		public MusicSegmentBuffer()
		{
		}
	}

	[Token(Token = "0x2000D2B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44760", Offset = "0x44760")]
	private sealed class _003CStopFast_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004788")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004789")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400478A")]
		[FieldOffset(Offset = "0x20")]
		public MusicPlaylist _003C_003E4__this;

		[Token(Token = "0x400478B")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x1700065B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003E2C")]
			[Address(RVA = "0x180630C", Offset = "0x180630C", VA = "0x180630C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700065C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003E2E")]
			[Address(RVA = "0x1806354", Offset = "0x1806354", VA = "0x1806354", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x180619C", Offset = "0x180619C", VA = "0x180619C")]
		[DebuggerHidden]
		public _003CStopFast_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x18061C8", Offset = "0x18061C8", VA = "0x18061C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x18061CC", Offset = "0x18061CC", VA = "0x18061CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x180630C", Offset = "0x180630C", VA = "0x180630C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x1806314", Offset = "0x1806314", VA = "0x1806314", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x1806354", Offset = "0x1806354", VA = "0x1806354", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44770", Offset = "0x44770")]
	private sealed class _003CStop_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400478C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400478D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400478E")]
		[FieldOffset(Offset = "0x20")]
		public MusicPlaylist _003C_003E4__this;

		[Token(Token = "0x400478F")]
		[FieldOffset(Offset = "0x28")]
		public double endtime;

		[Token(Token = "0x4004790")]
		[FieldOffset(Offset = "0x30")]
		public double fadeOutTime;

		[Token(Token = "0x4004791")]
		[FieldOffset(Offset = "0x38")]
		private float _003Cv_003E5__2;

		[Token(Token = "0x1700065D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003E32")]
			[Address(RVA = "0x180614C", Offset = "0x180614C", VA = "0x180614C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700065E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003E34")]
			[Address(RVA = "0x1806194", Offset = "0x1806194", VA = "0x1806194", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x1805938", Offset = "0x1805938", VA = "0x1805938")]
		[DebuggerHidden]
		public _003CStop_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x1805964", Offset = "0x1805964", VA = "0x1805964", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x1805968", Offset = "0x1805968", VA = "0x1805968", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x180614C", Offset = "0x180614C", VA = "0x180614C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x1806154", Offset = "0x1806154", VA = "0x1806154", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x1806194", Offset = "0x1806194", VA = "0x1806194", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D2D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44780", Offset = "0x44780")]
	private sealed class _003CFadeIn_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004792")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004793")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004794")]
		[FieldOffset(Offset = "0x20")]
		public double entryCueDSPtime;

		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0x28")]
		public MusicTransition.FadeInfo info;

		[Token(Token = "0x4004796")]
		[FieldOffset(Offset = "0x30")]
		public MusicPlaylist _003C_003E4__this;

		[Token(Token = "0x1700065F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003E38")]
			[Address(RVA = "0x18054AC", Offset = "0x18054AC", VA = "0x18054AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000660")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003E3A")]
			[Address(RVA = "0x18054F4", Offset = "0x18054F4", VA = "0x18054F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x18053BC", Offset = "0x18053BC", VA = "0x18053BC")]
		[DebuggerHidden]
		public _003CFadeIn_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x18053E8", Offset = "0x18053E8", VA = "0x18053E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003E37")]
		[Address(RVA = "0x18053EC", Offset = "0x18053EC", VA = "0x18053EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x18054AC", Offset = "0x18054AC", VA = "0x18054AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003E39")]
		[Address(RVA = "0x18054B4", Offset = "0x18054B4", VA = "0x18054B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003E3A")]
		[Address(RVA = "0x18054F4", Offset = "0x18054F4", VA = "0x18054F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D2E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44790", Offset = "0x44790")]
	private sealed class _003CPlay_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004797")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004798")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004799")]
		[FieldOffset(Offset = "0x20")]
		public MusicPlaylist _003C_003E4__this;

		[Token(Token = "0x400479A")]
		[FieldOffset(Offset = "0x28")]
		public double entryCue;

		[Token(Token = "0x400479B")]
		[FieldOffset(Offset = "0x30")]
		public bool playPreEntry;

		[Token(Token = "0x400479C")]
		[FieldOffset(Offset = "0x38")]
		public MusicTransition.FadeInfo fade;

		[Token(Token = "0x400479D")]
		[FieldOffset(Offset = "0x40")]
		public MusicTransition.DestinationSyncTo destinationJumpPositionPreset;

		[Token(Token = "0x400479E")]
		[FieldOffset(Offset = "0x48")]
		public double lastEntryCueFromParent;

		[Token(Token = "0x400479F")]
		[FieldOffset(Offset = "0x50")]
		private double _003CnextPlay_003E5__2;

		[Token(Token = "0x40047A0")]
		[FieldOffset(Offset = "0x58")]
		private MusicSegment _003CnextSegment_003E5__3;

		[Token(Token = "0x40047A1")]
		[FieldOffset(Offset = "0x60")]
		private double _003CpreStartScheduleBuffer_003E5__4;

		[Token(Token = "0x40047A2")]
		[FieldOffset(Offset = "0x68")]
		private bool _003CnextPlayPreEntry_003E5__5;

		[Token(Token = "0x40047A3")]
		[FieldOffset(Offset = "0x69")]
		private bool _003CisLoop_003E5__6;

		[Token(Token = "0x17000661")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003E3E")]
			[Address(RVA = "0x18058E8", Offset = "0x18058E8", VA = "0x18058E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000662")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003E40")]
			[Address(RVA = "0x1805930", Offset = "0x1805930", VA = "0x1805930", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003E3B")]
		[Address(RVA = "0x18054FC", Offset = "0x18054FC", VA = "0x18054FC")]
		[DebuggerHidden]
		public _003CPlay_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003E3C")]
		[Address(RVA = "0x1805528", Offset = "0x1805528", VA = "0x1805528", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003E3D")]
		[Address(RVA = "0x180552C", Offset = "0x180552C", VA = "0x180552C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x18058E8", Offset = "0x18058E8", VA = "0x18058E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003E3F")]
		[Address(RVA = "0x18058F0", Offset = "0x18058F0", VA = "0x18058F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003E40")]
		[Address(RVA = "0x1805930", Offset = "0x1805930", VA = "0x1805930", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[NonSerialized]
	[Token(Token = "0x400476B")]
	[FieldOffset(Offset = "0x18")]
	public MusicPlaylistContainer data;

	[NonSerialized]
	[Token(Token = "0x400476C")]
	[FieldOffset(Offset = "0x20")]
	public WwiseDocumentInteractiveMusicWorkUnitChildrenListMusicSwitchContainerChildrenListMusicPlaylistContainer updateData;

	[Token(Token = "0x400476D")]
	[FieldOffset(Offset = "0x28")]
	public List<MusicSegment> segments;

	[Token(Token = "0x400476E")]
	[FieldOffset(Offset = "0x30")]
	public float volume;

	[Token(Token = "0x400476F")]
	[FieldOffset(Offset = "0x34")]
	public float fadeVolume;

	[Token(Token = "0x4004770")]
	[FieldOffset(Offset = "0x38")]
	public string id;

	[Token(Token = "0x4004771")]
	[FieldOffset(Offset = "0x40")]
	public long shortID;

	[Token(Token = "0x4004772")]
	[FieldOffset(Offset = "0x48")]
	public bool overrideTempo;

	[Token(Token = "0x4004773")]
	[FieldOffset(Offset = "0x50")]
	public double tempo;

	[Token(Token = "0x4004774")]
	[FieldOffset(Offset = "0x58")]
	public LoopTypes loopType;

	[Token(Token = "0x4004775")]
	[FieldOffset(Offset = "0x5C")]
	public int loopCount;

	[Token(Token = "0x4004776")]
	[FieldOffset(Offset = "0x60")]
	public PlaylistState state;

	[Token(Token = "0x4004777")]
	[FieldOffset(Offset = "0x68")]
	private double nextExitCue;

	[Token(Token = "0x4004778")]
	[FieldOffset(Offset = "0x70")]
	private double lastEntryCue;

	[Token(Token = "0x4004779")]
	[FieldOffset(Offset = "0x78")]
	public List<MusicSegmentBuffer> segmentContainers;

	[Token(Token = "0x400477A")]
	[FieldOffset(Offset = "0x80")]
	private int segmentIndex;

	[Token(Token = "0x400477B")]
	[FieldOffset(Offset = "0x84")]
	public float lastStart;

	[Token(Token = "0x400477C")]
	[FieldOffset(Offset = "0x88")]
	public bool debug;

	[Token(Token = "0x400477D")]
	[FieldOffset(Offset = "0x90")]
	private Coroutine fadeInRoutine;

	[Token(Token = "0x6003E18")]
	[Address(RVA = "0x1587DE0", Offset = "0x1587DE0", VA = "0x1587DE0")]
	public double GetNextEntryCue()
	{
		return default;
	}

	[Token(Token = "0x6003E19")]
	[Address(RVA = "0x1588018", Offset = "0x1588018", VA = "0x1588018")]
	public double GetLastEntryCue()
	{
		return default;
	}

	[Token(Token = "0x6003E1A")]
	[Address(RVA = "0x1588020", Offset = "0x1588020", VA = "0x1588020")]
	public void StopInstant()
	{
	}

	[Token(Token = "0x6003E1B")]
	[Address(RVA = "0x1588444", Offset = "0x1588444", VA = "0x1588444")]
	public IEnumerator StopFast(float time)
	{
		return null;
	}

	[Token(Token = "0x6003E1C")]
	[Address(RVA = "0x15884C8", Offset = "0x15884C8", VA = "0x15884C8")]
	public IEnumerator Stop(double endtime, double fadeOutTime)
	{
		return null;
	}

	[Token(Token = "0x6003E1D")]
	[Address(RVA = "0x1588550", Offset = "0x1588550", VA = "0x1588550")]
	private IEnumerator FadeIn(MusicTransition.FadeInfo info, double entryCueDSPtime)
	{
		return null;
	}

	[Token(Token = "0x6003E1E")]
	[Address(RVA = "0x15885D8", Offset = "0x15885D8", VA = "0x15885D8")]
	public IEnumerator Play(double entryCue, bool playPreEntry, MusicTransition.DestinationSyncTo destinationJumpPositionPreset, double lastEntryCueFromParent, MusicTransition.FadeInfo fade)
	{
		return null;
	}

	[Token(Token = "0x6003E1F")]
	[Address(RVA = "0x1587E88", Offset = "0x1587E88", VA = "0x1587E88")]
	private MusicSegment GetNextSegment(bool increment)
	{
		return null;
	}

	[Token(Token = "0x6003E20")]
	[Address(RVA = "0x1588684", Offset = "0x1588684", VA = "0x1588684")]
	public double GetNextBeat(double min)
	{
		return default;
	}

	[Token(Token = "0x6003E21")]
	[Address(RVA = "0x15886CC", Offset = "0x15886CC", VA = "0x15886CC")]
	public double GetNextExitCueInDSP(double min)
	{
		return default;
	}

	[Token(Token = "0x6003E22")]
	[Address(RVA = "0x15887DC", Offset = "0x15887DC", VA = "0x15887DC")]
	public double GetNextBar(double min)
	{
		return default;
	}

	[Token(Token = "0x6003E23")]
	[Address(RVA = "0x15881A4", Offset = "0x15881A4", VA = "0x15881A4")]
	public void UpdatePlaying()
	{
	}

	[Token(Token = "0x6003E24")]
	[Address(RVA = "0x1588A24", Offset = "0x1588A24", VA = "0x1588A24")]
	public MusicPlaylist()
	{
	}

	[Token(Token = "0x6003E25")]
	[Address(RVA = "0x1588A34", Offset = "0x1588A34", VA = "0x1588A34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C388", Offset = "0x6C388")]
	private void _003CStopFast_003Eb__23_0(float t)
	{
	}
}
