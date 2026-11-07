using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
	{
		public enum LoopMode
		{
			UseSourceAsset = 0,
			On = 1,
			Off = 2
		}

		private static class AnimationPlayableAssetUpgrade
		{
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
			{
			}
		}

		[SerializeField]
		private AnimationClip m_Clip;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_EulerAngles;

		[SerializeField]
		private bool m_UseTrackMatchFields;

		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[SerializeField]
		private bool m_RemoveStartOffset;

		[SerializeField]
		private bool m_ApplyFootIK;

		[SerializeField]
		private LoopMode m_Loop;

		private static readonly int k_LatestVersion;

		[SerializeField]
		private int m_Version;

		[Obsolete]
		[SerializeField]
		private Quaternion m_Rotation;

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

		public bool useTrackMatchFields
		{
			get
			{
				return false;
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

		public bool removeStartOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool applyFootIK
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LoopMode loop
		{
			get
			{
				return LoopMode.UseSourceAsset;
			}
			set
			{
			}
		}

		internal bool hasRootTransforms => false;

		internal AppliedOffsetMode appliedOffsetMode { get; set; }

		public AnimationClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override double duration => 0.0;

		public override IEnumerable<PlayableBinding> outputs => null;

		public ClipCaps clipCaps => ClipCaps.None;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default;
		}

		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop)
		{
			return default;
		}

		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
		{
			return false;
		}

		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
		{
			return false;
		}

		public void ResetOffsets()
		{
		}

		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		internal static bool HasRootTransforms(AnimationClip clip)
		{
			return false;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void OnUpgradeFromVersion(int oldVersion)
		{
		}
	}
}
