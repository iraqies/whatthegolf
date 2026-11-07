using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class AnimationTrack : TrackAsset, ILayerable
	{
		private static class AnimationTrackUpgrade
		{
			public static void ConvertRotationsToEuler(AnimationTrack track)
			{
			}

			public static void ConvertRootMotion(AnimationTrack track)
			{
			}

			public static void ConvertInfiniteTrack(AnimationTrack track)
			{
			}
		}

		private const string k_DefaultInfiniteClipName = "Recorded";

		private const string k_DefaultRecordableClipName = "Recorded";

		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;

		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;

		[SerializeField]
		private Vector3 m_InfiniteClipOffsetPosition;

		[SerializeField]
		private Vector3 m_InfiniteClipOffsetEulerAngles;

		[SerializeField]
		private double m_InfiniteClipTimeOffset;

		[SerializeField]
		private bool m_InfiniteClipRemoveOffset;

		[SerializeField]
		private bool m_InfiniteClipApplyFootIK;

		[SerializeField]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop;

		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_EulerAngles;

		[SerializeField]
		private AvatarMask m_AvatarMask;

		[SerializeField]
		private bool m_ApplyAvatarMask;

		[SerializeField]
		private TrackOffset m_TrackOffset;

		[SerializeField]
		private AnimationClip m_InfiniteClip;

		private static readonly Queue<Transform> s_CachedQueue;

		[SerializeField]
		[Obsolete]
		private Quaternion m_OpenClipOffsetRotation;

		[SerializeField]
		[Obsolete]
		private Quaternion m_Rotation;

		[Obsolete]
		[SerializeField]
		private bool m_ApplyOffsets;

		public Vector3 position
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[Obsolete]
		public bool applyOffsets => false;

		public TrackOffset trackOffset
		{
			get
			{
				return TrackOffset.ApplyTransformOffsets;
			}
			set
			{
			}
		}

		public MatchTargetFields matchTargetFields
		{
			get
			{
				return (MatchTargetFields)0;
			}
			set
			{
			}
		}

		public AnimationClip infiniteClip
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal bool infiniteClipRemoveOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AvatarMask avatarMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool applyAvatarMask
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override IEnumerable<PlayableBinding> outputs => null;

		public bool inClipMode => false;

		public Vector3 infiniteClipOffsetPosition
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Quaternion infiniteClipOffsetRotation
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 infiniteClipOffsetEulerAngles
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		internal bool infiniteClipApplyFootIK
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal double infiniteClipTimeOffset
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
		{
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			set
			{
			}
		}

		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
		{
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			set
			{
			}
		}

		internal AnimationPlayableAsset.LoopMode infiniteClipLoop
		{
			get
			{
				return AnimationPlayableAsset.LoopMode.UseSourceAsset;
			}
			set
			{
			}
		}

		[EditorBrowsable]
		[Obsolete]
		public Vector3 openClipOffsetPosition
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[EditorBrowsable]
		[Obsolete]
		public Quaternion openClipOffsetRotation
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[EditorBrowsable]
		[Obsolete]
		public Vector3 openClipOffsetEulerAngles
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[EditorBrowsable]
		[Obsolete]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation
		{
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			set
			{
			}
		}

		[EditorBrowsable]
		[Obsolete]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation
		{
			get
			{
				return TimelineClip.ClipExtrapolation.None;
			}
			set
			{
			}
		}

		internal override bool CanCompileClips()
		{
			return false;
		}

		private void ResetOffsets()
		{
		}

		public TimelineClip CreateClip(AnimationClip clip)
		{
			return null;
		}

		public void CreateInfiniteClip(string infiniteClipName)
		{
		}

		public TimelineClip CreateRecordableClip(string animClipName)
		{
			return null;
		}

		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		protected internal override int CalculateItemsHash()
		{
			return 0;
		}

		internal void UpdateClipOffsets()
		{
		}

		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default;
		}

		Playable ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default;
		}

		internal override Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default;
		}

		private int GetDefaultBlendCount()
		{
			return 0;
		}

		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
		{
		}

		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
		{
			return default;
		}

		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
		{
			return false;
		}

		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
		{
			return false;
		}

		private bool HasController(GameObject gameObject)
		{
			return false;
		}

		internal Animator GetBinding(PlayableDirector director)
		{
			return null;
		}

		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default;
		}

		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default;
		}

		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
		{
			return default;
		}

		internal override void GetEvaluationTime(out double outStart, out double outDuration)
		{
			outStart = default;
			outDuration = default;
		}

		internal override void GetSequenceTime(out double outStart, out double outDuration)
		{
			outStart = default;
			outDuration = default;
		}

		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
		{
		}

		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		private void GetAnimationClips(List<AnimationClip> animClips)
		{
		}

		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
		{
			return AppliedOffsetMode.NoRootTransform;
		}

		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
		{
			return false;
		}

		private Transform GetGenericRootNode(GameObject gameObject)
		{
			return null;
		}

		internal bool AnimatesRootTransform()
		{
			return false;
		}

		private static Transform FindInHierarchyBreadthFirst(Transform t, string name)
		{
			return null;
		}

		internal override void OnUpgradeFromVersion(int oldVersion)
		{
		}
	}
}
