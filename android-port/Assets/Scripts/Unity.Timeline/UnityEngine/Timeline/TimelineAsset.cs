using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
	{
		public enum DurationMode
		{
			BasedOnClips = 0,
			FixedLength = 1
		}

		[Serializable]
		public class EditorSettings
		{
			internal static readonly float kMinFps;

			internal static readonly float kMaxFps;

			internal static readonly float kDefaultFps;

			[SerializeField]
			private float m_Framerate;

			[SerializeField]
			private bool m_ScenePreview;

			public float fps
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}
		}

		private const int k_LatestVersion = 0;

		[SerializeField]
		private int m_Version;

		[SerializeField]
		private List<ScriptableObject> m_Tracks;

		[SerializeField]
		private double m_FixedDuration;

		[NonSerialized]
		private TrackAsset[] m_CacheOutputTracks;

		[NonSerialized]
		private List<TrackAsset> m_CacheRootTracks;

		[NonSerialized]
		private List<TrackAsset> m_CacheFlattenedTracks;

		[SerializeField]
		private EditorSettings m_EditorSettings;

		[SerializeField]
		private DurationMode m_DurationMode;

		[SerializeField]
		private MarkerTrack m_MarkerTrack;

		public EditorSettings editorSettings => null;

		public override double duration => 0.0;

		public double fixedDuration
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public DurationMode durationMode
		{
			get
			{
				return DurationMode.BasedOnClips;
			}
			set
			{
			}
		}

		public override IEnumerable<PlayableBinding> outputs => null;

		public ClipCaps clipCaps => ClipCaps.None;

		public int outputTrackCount => 0;

		public int rootTrackCount => 0;

		internal IEnumerable<TrackAsset> flattenedTracks => null;

		public MarkerTrack markerTrack => null;

		internal List<ScriptableObject> trackObjects => null;

		private void UpgradeToLatestVersion()
		{
		}

		private void OnValidate()
		{
		}

		internal static float GetValidFramerate(float framerate)
		{
			return 0f;
		}

		public TrackAsset GetRootTrack(int index)
		{
			return null;
		}

		public IEnumerable<TrackAsset> GetRootTracks()
		{
			return null;
		}

		public TrackAsset GetOutputTrack(int index)
		{
			return null;
		}

		public IEnumerable<TrackAsset> GetOutputTracks()
		{
			return null;
		}

		private void UpdateRootTrackCache()
		{
		}

		private void UpdateOutputTrackCache()
		{
		}

		internal void AddTrackInternal(TrackAsset track)
		{
		}

		internal void RemoveTrack(TrackAsset track)
		{
		}

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void __internalAwake()
		{
		}

		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		public void CreateMarkerTrack()
		{
		}

		internal void Invalidate()
		{
		}

		internal void UpdateFixedDurationWithItemsDuration()
		{
		}

		private DiscreteTime CalculateItemsDuration()
		{
			return default;
		}

		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
		{
		}

		public TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
		{
			return null;
		}

		public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		public T CreateTrack<T>(string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		public T CreateTrack<T>() where T : TrackAsset, new()
		{
			return null;
		}

		public bool DeleteClip(TimelineClip clip)
		{
			return false;
		}

		public bool DeleteTrack(TrackAsset track)
		{
			return false;
		}

		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		internal TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
		{
			return null;
		}

		private void DeleteRecordedAnimation(TrackAsset track)
		{
		}

		private void DeleteRecordedAnimation(TimelineClip clip)
		{
		}
	}
}
