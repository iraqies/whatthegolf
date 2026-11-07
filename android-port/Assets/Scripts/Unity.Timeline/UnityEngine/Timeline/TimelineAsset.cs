using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x2000014")]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
	{
		[Token(Token = "0x2000015")]
		public enum DurationMode
		{
			[Token(Token = "0x400007D")]
			BasedOnClips = 0,
			[Token(Token = "0x400007E")]
			FixedLength = 1
		}

		[Serializable]
		[Token(Token = "0x2000016")]
		public class EditorSettings
		{
			[Token(Token = "0x400007F")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly float kMinFps;

			[Token(Token = "0x4000080")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly float kMaxFps;

			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly float kDefaultFps;

			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float m_Framerate;

			[Token(Token = "0x4000083")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private bool m_ScenePreview;

			[Token(Token = "0x17000058")]
			public float fps
			{
				[Token(Token = "0x60000FB")]
				[Address(RVA = "0x2AFAAF4", Offset = "0x2AFAAF4", VA = "0x2AFAAF4")]
				get
				{
					return default;
				}
				[Token(Token = "0x60000FC")]
				[Address(RVA = "0x2AED5DC", Offset = "0x2AED5DC", VA = "0x2AED5DC")]
				set
				{
				}
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2AF070C", Offset = "0x2AF070C", VA = "0x2AF070C")]
			public EditorSettings()
			{
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BB880", Offset = "0x1BB880")]
		private sealed class _003Cget_outputs_003Ed__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x18")]
			private PlayableBinding _003C_003E2__current;

			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x38")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x40")]
			public TimelineAsset _003C_003E4__this;

			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x48")]
			private IEnumerator<TrackAsset> _003C_003E7__wrap1;

			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x50")]
			private IEnumerator<PlayableBinding> _003C_003E7__wrap2;

			[Token(Token = "0x17000059")]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002ECurrent
			{
				[Token(Token = "0x6000104")]
				[Address(RVA = "0x2AFA98C", Offset = "0x2AFA98C", VA = "0x2AFA98C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700005A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000106")]
				[Address(RVA = "0x2AFA9DC", Offset = "0x2AFA9DC", VA = "0x2AFA9DC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2AEC76C", Offset = "0x2AEC76C", VA = "0x2AEC76C")]
			[DebuggerHidden]
			public _003Cget_outputs_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2AFA080", Offset = "0x2AFA080", VA = "0x2AFA080", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2AFA3B0", Offset = "0x2AFA3B0", VA = "0x2AFA3B0", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2AFA2EC", Offset = "0x2AFA2EC", VA = "0x2AFA2EC")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2AFA228", Offset = "0x2AFA228", VA = "0x2AFA228")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2AFA98C", Offset = "0x2AFA98C", VA = "0x2AFA98C", Slot = "6")]
			[DebuggerHidden]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2AFA99C", Offset = "0x2AFA99C", VA = "0x2AFA99C", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2AFA9DC", Offset = "0x2AFA9DC", VA = "0x2AFA9DC", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2AFAA48", Offset = "0x2AFAA48", VA = "0x2AFAA48", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PlayableBinding> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2AFAAF0", Offset = "0x2AFAAF0", VA = "0x2AFAAF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000072")]
		private const int k_LatestVersion = 0;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Version;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ScriptableObject> m_Tracks;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private double m_FixedDuration;

		[NonSerialized]
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		private TrackAsset[] m_CacheOutputTracks;

		[NonSerialized]
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private List<TrackAsset> m_CacheRootTracks;

		[NonSerialized]
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x40")]
		private List<TrackAsset> m_CacheFlattenedTracks;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EditorSettings m_EditorSettings;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DurationMode m_DurationMode;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MarkerTrack m_MarkerTrack;

		[Token(Token = "0x1700004D")]
		public EditorSettings editorSettings
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2AEBE18", Offset = "0x2AEBE18", VA = "0x2AEBE18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public override double duration
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2AEBE20", Offset = "0x2AEBE20", VA = "0x2AEBE20", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004F")]
		public double fixedDuration
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2AEC4DC", Offset = "0x2AEC4DC", VA = "0x2AEC4DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2AEC654", Offset = "0x2AEC654", VA = "0x2AEC654")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public DurationMode durationMode
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x2AEC6D8", Offset = "0x2AEC6D8", VA = "0x2AEC6D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x2AEC6E0", Offset = "0x2AEC6E0", VA = "0x2AEC6E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2AEC6E8", Offset = "0x2AEC6E8", VA = "0x2AEC6E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2AEC7A4", Offset = "0x2AEC7A4", VA = "0x2AEC7A4", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000053")]
		public int outputTrackCount
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2AECC58", Offset = "0x2AECC58", VA = "0x2AECC58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000054")]
		public int rootTrackCount
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2AED120", Offset = "0x2AED120", VA = "0x2AED120")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000055")]
		internal IEnumerable<TrackAsset> flattenedTracks
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2AED760", Offset = "0x2AED760", VA = "0x2AED760")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public MarkerTrack markerTrack
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2AEDC14", Offset = "0x2AEDC14", VA = "0x2AEDC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		internal List<ScriptableObject> trackObjects
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2AEDC1C", Offset = "0x2AEDC1C", VA = "0x2AEDC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2AEBE14", Offset = "0x2AEBE14", VA = "0x2AEBE14")]
		private void UpgradeToLatestVersion()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2AED470", Offset = "0x2AED470", VA = "0x2AED470")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2AED55C", Offset = "0x2AED55C", VA = "0x2AED55C")]
		internal static float GetValidFramerate(float framerate)
		{
			return default;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2AED670", Offset = "0x2AED670", VA = "0x2AED670")]
		public TrackAsset GetRootTrack(int index)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2AECB2C", Offset = "0x2AECB2C", VA = "0x2AECB2C")]
		public IEnumerable<TrackAsset> GetRootTracks()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2AED6EC", Offset = "0x2AED6EC", VA = "0x2AED6EC")]
		public TrackAsset GetOutputTrack(int index)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2AED73C", Offset = "0x2AED73C", VA = "0x2AED73C")]
		public IEnumerable<TrackAsset> GetOutputTracks()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2AED174", Offset = "0x2AED174", VA = "0x2AED174")]
		private void UpdateRootTrackCache()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2AECC88", Offset = "0x2AECC88", VA = "0x2AECC88")]
		private void UpdateOutputTrackCache()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2AEDC24", Offset = "0x2AEDC24", VA = "0x2AEDC24")]
		internal void AddTrackInternal(TrackAsset track)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2AEDCA8", Offset = "0x2AEDCA8", VA = "0x2AEDCA8")]
		internal void RemoveTrack(TrackAsset track)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2AEDE78", Offset = "0x2AEDE78", VA = "0x2AEDE78", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2AEE240", Offset = "0x2AEE240", VA = "0x2AEE240", Slot = "9")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2AEE248", Offset = "0x2AEE248", VA = "0x2AEE248", Slot = "10")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2AEE254", Offset = "0x2AEE254", VA = "0x2AEE254")]
		private void __internalAwake()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2AEE3EC", Offset = "0x2AEE3EC", VA = "0x2AEE3EC", Slot = "12")]
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2AEE8E4", Offset = "0x2AEE8E4", VA = "0x2AEE8E4")]
		public void CreateMarkerTrack()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2AEDC9C", Offset = "0x2AEDC9C", VA = "0x2AEDC9C")]
		internal void Invalidate()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2AEE9C8", Offset = "0x2AEE9C8", VA = "0x2AEE9C8")]
		internal void UpdateFixedDurationWithItemsDuration()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2AEBF8C", Offset = "0x2AEBF8C", VA = "0x2AEBF8C")]
		private DiscreteTime CalculateItemsDuration()
		{
			return default;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2AED8A4", Offset = "0x2AED8A4", VA = "0x2AED8A4")]
		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2AEEB3C", Offset = "0x2AEEB3C", VA = "0x2AEEB3C")]
		public TrackAsset CreateTrack(Type type, TrackAsset parent, string name)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		public T CreateTrack<T>(TrackAsset parent, string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		public T CreateTrack<T>(string trackName) where T : TrackAsset, new()
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		public T CreateTrack<T>() where T : TrackAsset, new()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2AEF8B8", Offset = "0x2AEF8B8", VA = "0x2AEF8B8")]
		public bool DeleteClip(TimelineClip clip)
		{
			return default;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2AEFCC0", Offset = "0x2AEFCC0", VA = "0x2AEFCC0")]
		public bool DeleteTrack(TrackAsset track)
		{
			return default;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2AF0358", Offset = "0x2AF0358", VA = "0x2AF0358")]
		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2AEF604", Offset = "0x2AEF604", VA = "0x2AEF604")]
		internal TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2AF01FC", Offset = "0x2AF01FC", VA = "0x2AF01FC")]
		private void DeleteRecordedAnimation(TrackAsset track)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2AEFAE8", Offset = "0x2AEFAE8", VA = "0x2AEFAE8")]
		private void DeleteRecordedAnimation(TimelineClip clip)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2AF064C", Offset = "0x2AF064C", VA = "0x2AF064C")]
		public TimelineAsset()
		{
		}
	}
}
