using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000038")]
	public class TimelinePlayable : PlayableBehaviour
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x10")]
		private IntervalTree<RuntimeElement> m_IntervalTree;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x18")]
		private List<RuntimeElement> m_ActiveClips;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		private List<RuntimeElement> m_CurrentListOfActiveClips;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x28")]
		private int m_ActiveBit;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x30")]
		private List<ITimelineEvaluateCallback> m_EvaluateCallbacks;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<TrackAsset, Playable> m_PlayableCache;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		internal static bool muteAudioScrubbing;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2AEE018", Offset = "0x2AEE018", VA = "0x2AEE018")]
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			return default;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2AF17DC", Offset = "0x2AF17DC", VA = "0x2AF17DC")]
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2AF1A58", Offset = "0x2AF1A58", VA = "0x2AF1A58")]
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2AF2850", Offset = "0x2AF2850", VA = "0x2AF2850")]
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2AF2F60", Offset = "0x2AF2F60", VA = "0x2AF2F60")]
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2AF3000", Offset = "0x2AF3000", VA = "0x2AF3000")]
		private static Playable CreatePlayableGraph(PlayableGraph graph, TrackAsset asset, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
		{
			return default;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2AF238C", Offset = "0x2AF238C", VA = "0x2AF238C")]
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
		{
			return default;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2AF33AC", Offset = "0x2AF33AC", VA = "0x2AF33AC", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2AF33DC", Offset = "0x2AF33DC", VA = "0x2AF33DC")]
		private void Evaluate(Playable playable, FrameData frameData)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2AF3330", Offset = "0x2AF3330", VA = "0x2AF3330")]
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2AF3A84", Offset = "0x2AF3A84", VA = "0x2AF3A84")]
		public TimelinePlayable()
		{
		}
	}
}
