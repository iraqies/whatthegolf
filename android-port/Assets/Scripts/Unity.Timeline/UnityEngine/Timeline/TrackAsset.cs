using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
	{
		[Token(Token = "0x2000019")]
		private struct TransientBuildData
		{
			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x0")]
			public List<TrackAsset> trackList;

			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x8")]
			public List<TimelineClip> clipList;

			[Token(Token = "0x40000A4")]
			[FieldOffset(Offset = "0x10")]
			public List<IMarker> markerList;

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2AF9980", Offset = "0x2AF9980", VA = "0x2AF9980")]
			public static TransientBuildData Create()
			{
				return default;
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2AF7584", Offset = "0x2AF7584", VA = "0x2AF7584")]
			public void Clear()
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BB890", Offset = "0x1BB890")]
		private sealed class _003Cget_outputs_003Ed__65 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000A6")]
			[FieldOffset(Offset = "0x18")]
			private PlayableBinding _003C_003E2__current;

			[Token(Token = "0x40000A7")]
			[FieldOffset(Offset = "0x38")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40000A8")]
			[FieldOffset(Offset = "0x40")]
			public TrackAsset _003C_003E4__this;

			[Token(Token = "0x17000072")]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002ECurrent
			{
				[Token(Token = "0x6000174")]
				[Address(RVA = "0x2AFAF28", Offset = "0x2AFAF28", VA = "0x2AFAF28", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000073")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x2AFAF78", Offset = "0x2AFAF78", VA = "0x2AFAF78", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2AF4B28", Offset = "0x2AF4B28", VA = "0x2AF4B28")]
			[DebuggerHidden]
			public _003Cget_outputs_003Ed__65(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2AFACB0", Offset = "0x2AFACB0", VA = "0x2AFACB0", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2AFACB4", Offset = "0x2AFACB4", VA = "0x2AFACB4", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2AFAF28", Offset = "0x2AFAF28", VA = "0x2AFAF28", Slot = "6")]
			[DebuggerHidden]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2AFAF38", Offset = "0x2AFAF38", VA = "0x2AFAF38", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2AFAF78", Offset = "0x2AFAF78", VA = "0x2AFAF78", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2AFAFE4", Offset = "0x2AFAFE4", VA = "0x2AFAFE4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PlayableBinding> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2AFB08C", Offset = "0x2AFB08C", VA = "0x2AFB08C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BB8A0", Offset = "0x1BB8A0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<TimelineClip> _003C_003E9__121_0;

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2AFAC68", Offset = "0x2AFAC68", VA = "0x2AFAC68")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2AFAC70", Offset = "0x2AFAC70", VA = "0x2AFAC70")]
			internal int _003CSortClips_003Eb__121_0(TimelineClip clip1, TimelineClip clip2)
			{
				return default;
			}
		}

		[Token(Token = "0x400008A")]
		private const int k_LatestVersion = 3;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Version;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC164", Offset = "0x1BC164")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BC164", Offset = "0x1BC164")]
		internal AnimationClip m_AnimClip;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x0")]
		private static TransientBuildData s_BuildData;

		[Token(Token = "0x400008E")]
		internal const string kDefaultCurvesName = "Track Parameters";

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC1D8", Offset = "0x1BC1D8")]
		private static Action<TimelineClip, GameObject, Playable> m_OnClipPlayableCreate;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC1E8", Offset = "0x1BC1E8")]
		private static Action<TrackAsset, GameObject, Playable> m_OnTrackAnimationPlayableCreate;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_Locked;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_Muted;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_CustomPlayableFullTypename;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationClip m_Curves;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayableAsset m_Parent;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<ScriptableObject> m_Children;

		[NonSerialized]
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x50")]
		private int m_ItemsHash;

		[NonSerialized]
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x58")]
		private TimelineClip[] m_ClipsCache;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x60")]
		private DiscreteTime m_Start;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x68")]
		private DiscreteTime m_End;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x70")]
		private bool m_CacheSorted;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x71")]
		private bool? m_SupportsNotifications;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x28")]
		private static TrackAsset[] s_EmptyCache;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x78")]
		private IEnumerable<TrackAsset> m_ChildTrackCache;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected internal List<TimelineClip> m_Clips;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MarkerList m_Markers;

		[Token(Token = "0x1700005B")]
		public double start
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2AF4684", Offset = "0x2AF4684", VA = "0x2AF4684")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public double end
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2AEEA84", Offset = "0x2AEEA84", VA = "0x2AEEA84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005D")]
		public sealed override double duration
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2AF4864", Offset = "0x2AF4864", VA = "0x2AF4864", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool muted
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2AF4920", Offset = "0x2AF4920", VA = "0x2AF4920")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2AF4928", Offset = "0x2AF4928", VA = "0x2AF4928")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool mutedInHierarchy
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2AEE728", Offset = "0x2AEE728", VA = "0x2AEE728")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000060")]
		public TimelineAsset timelineAsset
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x2AE86F0", Offset = "0x2AE86F0", VA = "0x2AE86F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public PlayableAsset parent
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2AF4930", Offset = "0x2AF4930", VA = "0x2AF4930")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2AF4938", Offset = "0x2AF4938", VA = "0x2AF4938")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000062")]
		internal TimelineClip[] clips
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2AE2314", Offset = "0x2AE2314", VA = "0x2AE2314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public virtual bool isEmpty
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2AF4940", Offset = "0x2AF4940", VA = "0x2AF4940", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000064")]
		public bool hasClips
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2AF49E0", Offset = "0x2AF49E0", VA = "0x2AF49E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000065")]
		public bool hasCurves
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2AF4A38", Offset = "0x2AF4A38", VA = "0x2AF4A38", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000066")]
		public bool isSubTrack
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2AE2EEC", Offset = "0x2AE2EEC", VA = "0x2AE2EEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000067")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2AE9260", Offset = "0x2AE9260", VA = "0x2AE9260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		internal string customPlayableTypename
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2AF4D4C", Offset = "0x2AF4D4C", VA = "0x2AF4D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2AF4D54", Offset = "0x2AF4D54", VA = "0x2AF4D54")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public AnimationClip curves
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2AF4D5C", Offset = "0x2AF4D5C", VA = "0x2AF4D5C", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2AF4D64", Offset = "0x2AF4D64", VA = "0x2AF4D64")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		private string UnityEngine_002ETimeline_002EICurvesOwner_002EdefaultCurvesName
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2AF4D6C", Offset = "0x2AF4D6C", VA = "0x2AF4D6C", Slot = "12")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_defaultCurvesName();
			}
		}

		[Token(Token = "0x1700006B")]
		private Object UnityEngine_002ETimeline_002EICurvesOwner_002Easset
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2AF4DB0", Offset = "0x2AF4DB0", VA = "0x2AF4DB0", Slot = "13")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_asset();
			}
		}

		[Token(Token = "0x1700006C")]
		private Object UnityEngine_002ETimeline_002EICurvesOwner_002EassetOwner
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2AF4DB4", Offset = "0x2AF4DB4", VA = "0x2AF4DB4", Slot = "14")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_assetOwner();
			}
		}

		[Token(Token = "0x1700006D")]
		private TrackAsset UnityEngine_002ETimeline_002EICurvesOwner_002EtargetTrack
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2AF4DB8", Offset = "0x2AF4DB8", VA = "0x2AF4DB8", Slot = "15")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_targetTrack();
			}
		}

		[Token(Token = "0x1700006E")]
		internal List<ScriptableObject> subTracksObjects
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2AF4DBC", Offset = "0x2AF4DBC", VA = "0x2AF4DBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public bool locked
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x2AF4DC4", Offset = "0x2AF4DC4", VA = "0x2AF4DC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x2AF4DCC", Offset = "0x2AF4DCC", VA = "0x2AF4DCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public bool lockedInHierarchy
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x2AF4DD4", Offset = "0x2AF4DD4", VA = "0x2AF4DD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000071")]
		public bool supportsNotifications
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2AE8E90", Offset = "0x2AE8E90", VA = "0x2AE8E90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000001")]
		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2AF4254", Offset = "0x2AF4254", VA = "0x2AF4254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC450", Offset = "0x1BC450")]
			add
			{
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2AF4360", Offset = "0x2AF4360", VA = "0x2AF4360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC460", Offset = "0x1BC460")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2AF446C", Offset = "0x2AF446C", VA = "0x2AF446C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC470", Offset = "0x1BC470")]
			add
			{
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2AF4578", Offset = "0x2AF4578", VA = "0x2AF4578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC480", Offset = "0x1BC480")]
			remove
			{
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2AF3C2C", Offset = "0x2AF3C2C", VA = "0x2AF3C2C", Slot = "16")]
		protected virtual void OnBeforeTrackSerialize()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2AF3C30", Offset = "0x2AF3C30", VA = "0x2AF3C30", Slot = "17")]
		protected virtual void OnAfterTrackDeserialize()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2AF3C34", Offset = "0x2AF3C34", VA = "0x2AF3C34", Slot = "18")]
		internal virtual void OnUpgradeFromVersion(int oldVersion)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2AF3C38", Offset = "0x2AF3C38", VA = "0x2AF3C38", Slot = "9")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2AF3DC8", Offset = "0x2AF3DC8", VA = "0x2AF3DC8", Slot = "10")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2AF4228", Offset = "0x2AF4228", VA = "0x2AF4228")]
		private void UpgradeToLatestVersion()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2AE692C", Offset = "0x2AE692C", VA = "0x2AE692C")]
		public IEnumerable<TimelineClip> GetClips()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2AE4D98", Offset = "0x2AE4D98", VA = "0x2AE4D98")]
		public IEnumerable<TrackAsset> GetChildTracks()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2AF4D6C", Offset = "0x2AF4D6C", VA = "0x2AF4D6C", Slot = "12")]
		private string UnityEngine_002ETimeline_002EICurvesOwner_002Eget_defaultCurvesName()
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2AF4DB0", Offset = "0x2AF4DB0", VA = "0x2AF4DB0", Slot = "13")]
		private Object UnityEngine_002ETimeline_002EICurvesOwner_002Eget_asset()
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2AF4DB4", Offset = "0x2AF4DB4", VA = "0x2AF4DB4", Slot = "14")]
		private Object UnityEngine_002ETimeline_002EICurvesOwner_002Eget_assetOwner()
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2AF4DB8", Offset = "0x2AF4DB8", VA = "0x2AF4DB8", Slot = "15")]
		private TrackAsset UnityEngine_002ETimeline_002EICurvesOwner_002Eget_targetTrack()
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2AF4F90", Offset = "0x2AF4F90", VA = "0x2AF4F90")]
		private void __internalAwake()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2AF5054", Offset = "0x2AF5054", VA = "0x2AF5054", Slot = "22")]
		public void CreateCurves(string curvesClipName)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2AF5120", Offset = "0x2AF5120", VA = "0x2AF5120", Slot = "23")]
		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2AF51A4", Offset = "0x2AF51A4", VA = "0x2AF51A4", Slot = "6")]
		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2AF5200", Offset = "0x2AF5200", VA = "0x2AF5200")]
		public TimelineClip CreateDefaultClip()
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		public TimelineClip CreateClip<T>() where T : ScriptableObject, IPlayableAsset
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2AF5558", Offset = "0x2AF5558", VA = "0x2AF5558")]
		public bool DeleteClip(TimelineClip clip)
		{
			return default;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2AF567C", Offset = "0x2AF567C", VA = "0x2AF567C")]
		public IMarker CreateMarker(Type type, double time)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		public T CreateMarker<T>(double time) where T : ScriptableObject, IMarker
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2AF5688", Offset = "0x2AF5688", VA = "0x2AF5688")]
		public bool DeleteMarker(IMarker marker)
		{
			return default;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2AF422C", Offset = "0x2AF422C", VA = "0x2AF422C")]
		public IEnumerable<IMarker> GetMarkers()
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2AF4AD4", Offset = "0x2AF4AD4", VA = "0x2AF4AD4")]
		public int GetMarkerCount()
		{
			return default;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2AF5690", Offset = "0x2AF5690", VA = "0x2AF5690")]
		public IMarker GetMarker(int idx)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2AF570C", Offset = "0x2AF570C", VA = "0x2AF570C")]
		internal TimelineClip CreateClip(Type requestedType)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2AF5524", Offset = "0x2AF5524", VA = "0x2AF5524")]
		internal TimelineClip CreateAndAddNewClipOfType(Type requestedType)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2AF5B68", Offset = "0x2AF5B68", VA = "0x2AF5B68")]
		internal TimelineClip CreateClipOfType(Type requestedType)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2AF60A0", Offset = "0x2AF60A0", VA = "0x2AF60A0")]
		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2AF5DC8", Offset = "0x2AF5DC8", VA = "0x2AF5DC8")]
		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2AF6618", Offset = "0x2AF6618", VA = "0x2AF6618")]
		internal IEnumerable<ScriptableObject> GetMarkersRaw()
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2AF6620", Offset = "0x2AF6620", VA = "0x2AF6620")]
		internal void ClearMarkers()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2AF6680", Offset = "0x2AF6680", VA = "0x2AF6680")]
		internal void AddMarker(ScriptableObject e)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2AF6688", Offset = "0x2AF6688", VA = "0x2AF6688")]
		internal bool DeleteMarkerRaw(ScriptableObject marker)
		{
			return default;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2AF66BC", Offset = "0x2AF66BC", VA = "0x2AF66BC")]
		private int GetTimeRangeHash()
		{
			return default;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2AF0D14", Offset = "0x2AF0D14", VA = "0x2AF0D14")]
		internal void AddClip(TimelineClip newClip)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2AF6C0C", Offset = "0x2AF6C0C", VA = "0x2AF6C0C")]
		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable)
		{
			return default;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2AF3024", Offset = "0x2AF3024", VA = "0x2AF3024")]
		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable)
		{
			return default;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2AF7620", Offset = "0x2AF7620", VA = "0x2AF7620", Slot = "24")]
		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2AF7C38", Offset = "0x2AF7C38", VA = "0x2AF7C38")]
		private void GatherCompilableTracks(IList<TrackAsset> tracks)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2AF6E58", Offset = "0x2AF6E58", VA = "0x2AF6E58")]
		private void GatherNotificiations(List<IMarker> markers)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2AF807C", Offset = "0x2AF807C", VA = "0x2AF807C", Slot = "25")]
		internal virtual Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2AF7AC0", Offset = "0x2AF7AC0", VA = "0x2AF7AC0")]
		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2AF2224", Offset = "0x2AF2224", VA = "0x2AF2224")]
		internal void SortClips()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2AF870C", Offset = "0x2AF870C", VA = "0x2AF870C")]
		internal void ClearClipsInternal()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2AF8788", Offset = "0x2AF8788", VA = "0x2AF8788")]
		internal void ClearSubTracksInternal()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2AF0C60", Offset = "0x2AF0C60", VA = "0x2AF0C60")]
		internal void OnClipMove()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2AF6394", Offset = "0x2AF6394", VA = "0x2AF6394")]
		internal TimelineClip CreateNewClipContainerInternal()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2AF0588", Offset = "0x2AF0588", VA = "0x2AF0588")]
		internal void AddChild(TrackAsset child)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2AF8804", Offset = "0x2AF8804", VA = "0x2AF8804")]
		internal void MoveLastTrackBefore(TrackAsset asset)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2AEDDF4", Offset = "0x2AEDDF4", VA = "0x2AEDDF4")]
		internal bool RemoveSubTrack(TrackAsset child)
		{
			return default;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2AEFC54", Offset = "0x2AEFC54", VA = "0x2AEFC54")]
		internal void RemoveClip(TimelineClip clip)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2AE5A20", Offset = "0x2AE5A20", VA = "0x2AE5A20", Slot = "26")]
		internal virtual void GetEvaluationTime(out double outStart, out double outDuration)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2AE5DD4", Offset = "0x2AE5DD4", VA = "0x2AE5DD4", Slot = "27")]
		internal virtual void GetSequenceTime(out double outStart, out double outDuration)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2AF8A70", Offset = "0x2AF8A70", VA = "0x2AF8A70", Slot = "28")]
		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2AF91E4", Offset = "0x2AF91E4", VA = "0x2AF91E4")]
		internal GameObject GetGameObjectBinding(PlayableDirector director)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2AF58A0", Offset = "0x2AF58A0", VA = "0x2AF58A0")]
		internal bool ValidateClipType(Type clipType)
		{
			return default;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2AF9378", Offset = "0x2AF9378", VA = "0x2AF9378", Slot = "29")]
		protected virtual void OnCreateClip(TimelineClip clip)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2AF473C", Offset = "0x2AF473C", VA = "0x2AF473C")]
		private void UpdateDuration()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2AE3220", Offset = "0x2AE3220", VA = "0x2AE3220", Slot = "30")]
		protected internal virtual int CalculateItemsHash()
		{
			return default;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2AF94F4", Offset = "0x2AF94F4", VA = "0x2AF94F4", Slot = "31")]
		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
		{
			return default;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2AF418C", Offset = "0x2AF418C", VA = "0x2AF418C")]
		internal void Invalidate()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2AE5DE4", Offset = "0x2AE5DE4", VA = "0x2AE5DE4")]
		internal double GetNotificationDuration()
		{
			return default;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2AF97C0", Offset = "0x2AF97C0", VA = "0x2AF97C0", Slot = "32")]
		internal virtual bool CanCompileClips()
		{
			return default;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2AF1DFC", Offset = "0x2AF1DFC", VA = "0x2AF1DFC")]
		internal bool IsCompilable()
		{
			return default;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2AF4B60", Offset = "0x2AF4B60", VA = "0x2AF4B60")]
		private void UpdateChildTrackCache()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2AF9824", Offset = "0x2AF9824", VA = "0x2AF9824", Slot = "33")]
		internal virtual int Hash()
		{
			return default;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2AF937C", Offset = "0x2AF937C", VA = "0x2AF937C")]
		private int GetClipsHash()
		{
			return default;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2AE3124", Offset = "0x2AE3124", VA = "0x2AE3124")]
		protected static int GetAnimationClipHash(AnimationClip clip)
		{
			return default;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2AF8A48", Offset = "0x2AF8A48", VA = "0x2AF8A48")]
		private bool HasNotifications()
		{
			return default;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2AF8040", Offset = "0x2AF8040", VA = "0x2AF8040")]
		private bool CanCompileNotifications()
		{
			return default;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2AF7210", Offset = "0x2AF7210", VA = "0x2AF7210")]
		private bool CanCompileClipsRecursive()
		{
			return default;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2AE6C68", Offset = "0x2AE6C68", VA = "0x2AE6C68")]
		protected TrackAsset()
		{
		}
	}
}
