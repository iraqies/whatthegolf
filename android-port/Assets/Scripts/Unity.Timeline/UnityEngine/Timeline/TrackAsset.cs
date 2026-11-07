using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
	{
		private struct TransientBuildData
		{
			public List<TrackAsset> trackList;

			public List<TimelineClip> clipList;

			public List<IMarker> markerList;

			public static TransientBuildData Create()
			{
				return default;
			}

			public void Clear()
			{
			}
		}

		private const int k_LatestVersion = 3;

		[SerializeField]
		private int m_Version;

		[Obsolete]
		[SerializeField]
		internal AnimationClip m_AnimClip;

		private static TransientBuildData s_BuildData;

		internal const string kDefaultCurvesName = "Track Parameters";

		[CompilerGenerated]
		private static Action<TimelineClip, GameObject, Playable> m_OnClipPlayableCreate;

		[CompilerGenerated]
		private static Action<TrackAsset, GameObject, Playable> m_OnTrackAnimationPlayableCreate;

		[SerializeField]
		private bool m_Locked;

		[SerializeField]
		private bool m_Muted;

		[SerializeField]
		private string m_CustomPlayableFullTypename;

		[SerializeField]
		private AnimationClip m_Curves;

		[SerializeField]
		private PlayableAsset m_Parent;

		[SerializeField]
		private List<ScriptableObject> m_Children;

		[NonSerialized]
		private int m_ItemsHash;

		[NonSerialized]
		private TimelineClip[] m_ClipsCache;

		private DiscreteTime m_Start;

		private DiscreteTime m_End;

		private bool m_CacheSorted;

		private bool? m_SupportsNotifications;

		private static TrackAsset[] s_EmptyCache;

		private IEnumerable<TrackAsset> m_ChildTrackCache;

		private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;

		[SerializeField]
		protected internal List<TimelineClip> m_Clips;

		[SerializeField]
		private MarkerList m_Markers;

		public double start => 0.0;

		public double end => 0.0;

		public sealed override double duration => 0.0;

		public bool muted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool mutedInHierarchy => false;

		public TimelineAsset timelineAsset => null;

		public PlayableAsset parent
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal TimelineClip[] clips => null;

		public virtual bool isEmpty => false;

		public bool hasClips => false;

		public bool hasCurves => false;

		public bool isSubTrack => false;

		public override IEnumerable<PlayableBinding> outputs => null;

		internal string customPlayableTypename
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AnimationClip curves
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		string ICurvesOwner.defaultCurvesName => null;

		Object ICurvesOwner.asset => null;

		Object ICurvesOwner.assetOwner => null;

		TrackAsset ICurvesOwner.targetTrack => null;

		internal List<ScriptableObject> subTracksObjects => null;

		public bool locked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool lockedInHierarchy => false;

		public bool supportsNotifications => false;

		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void OnBeforeTrackSerialize()
		{
		}

		protected virtual void OnAfterTrackDeserialize()
		{
		}

		internal virtual void OnUpgradeFromVersion(int oldVersion)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void UpgradeToLatestVersion()
		{
		}

		public IEnumerable<TimelineClip> GetClips()
		{
			return null;
		}

		public IEnumerable<TrackAsset> GetChildTracks()
		{
			return null;
		}

		private void __internalAwake()
		{
		}

		public void CreateCurves(string curvesClipName)
		{
		}

		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default;
		}

		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default;
		}

		public TimelineClip CreateDefaultClip()
		{
			return null;
		}

		public TimelineClip CreateClip<T>() where T : ScriptableObject, IPlayableAsset
		{
			return null;
		}

		public bool DeleteClip(TimelineClip clip)
		{
			return false;
		}

		public IMarker CreateMarker(Type type, double time)
		{
			return null;
		}

		public T CreateMarker<T>(double time) where T : ScriptableObject, IMarker
		{
			return null;
		}

		public bool DeleteMarker(IMarker marker)
		{
			return false;
		}

		public IEnumerable<IMarker> GetMarkers()
		{
			return null;
		}

		public int GetMarkerCount()
		{
			return 0;
		}

		public IMarker GetMarker(int idx)
		{
			return null;
		}

		internal TimelineClip CreateClip(Type requestedType)
		{
			return null;
		}

		internal TimelineClip CreateAndAddNewClipOfType(Type requestedType)
		{
			return null;
		}

		internal TimelineClip CreateClipOfType(Type requestedType)
		{
			return null;
		}

		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset)
		{
			return null;
		}

		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset)
		{
			return null;
		}

		internal IEnumerable<ScriptableObject> GetMarkersRaw()
		{
			return null;
		}

		internal void ClearMarkers()
		{
		}

		internal void AddMarker(ScriptableObject e)
		{
		}

		internal bool DeleteMarkerRaw(ScriptableObject marker)
		{
			return false;
		}

		private int GetTimeRangeHash()
		{
			return 0;
		}

		internal void AddClip(TimelineClip newClip)
		{
		}

		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable)
		{
			return default;
		}

		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
		{
			return default;
		}

		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default;
		}

		private void GatherCompilableTracks(IList<TrackAsset> tracks)
		{
		}

		private void GatherNotificiations(List<IMarker> markers)
		{
		}

		internal virtual Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default;
		}

		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend)
		{
		}

		internal void SortClips()
		{
		}

		internal void ClearClipsInternal()
		{
		}

		internal void ClearSubTracksInternal()
		{
		}

		internal void OnClipMove()
		{
		}

		internal TimelineClip CreateNewClipContainerInternal()
		{
			return null;
		}

		internal void AddChild(TrackAsset child)
		{
		}

		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		internal bool RemoveSubTrack(TrackAsset child)
		{
			return false;
		}

		internal void RemoveClip(TimelineClip clip)
		{
		}

		internal virtual void GetEvaluationTime(out double outStart, out double outDuration)
		{
			outStart = default;
			outDuration = default;
		}

		internal virtual void GetSequenceTime(out double outStart, out double outDuration)
		{
			outStart = default;
			outDuration = default;
		}

		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		internal GameObject GetGameObjectBinding(PlayableDirector director)
		{
			return null;
		}

		internal bool ValidateClipType(Type clipType)
		{
			return false;
		}

		protected virtual void OnCreateClip(TimelineClip clip)
		{
		}

		private void UpdateDuration()
		{
		}

		protected internal virtual int CalculateItemsHash()
		{
			return 0;
		}

		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
		{
			return default;
		}

		internal void Invalidate()
		{
		}

		internal double GetNotificationDuration()
		{
			return 0.0;
		}

		internal virtual bool CanCompileClips()
		{
			return false;
		}

		internal bool IsCompilable()
		{
			return false;
		}

		private void UpdateChildTrackCache()
		{
		}

		internal virtual int Hash()
		{
			return 0;
		}

		private int GetClipsHash()
		{
			return 0;
		}

		protected static int GetAnimationClipHash(AnimationClip clip)
		{
			return 0;
		}

		private bool HasNotifications()
		{
			return false;
		}

		private bool CanCompileNotifications()
		{
			return false;
		}

		private bool CanCompileClipsRecursive()
		{
			return false;
		}
	}
}
