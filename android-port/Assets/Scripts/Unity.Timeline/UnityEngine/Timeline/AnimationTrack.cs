using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1BB7D0", Offset = "0x1BB7D0")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x1BB7D0", Offset = "0x1BB7D0")]
	public class AnimationTrack : TrackAsset, ILayerable
	{
		[Token(Token = "0x200000D")]
		private static class AnimationTrackUpgrade
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2AE6A88", Offset = "0x2AE6A88", VA = "0x2AE6A88")]
			public static void ConvertRotationsToEuler(AnimationTrack track)
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2AE6AD4", Offset = "0x2AE6AD4", VA = "0x2AE6AD4")]
			public static void ConvertRootMotion(AnimationTrack track)
			{
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2AE6B28", Offset = "0x2AE6B28", VA = "0x2AE6B28")]
			public static void ConvertInfiniteTrack(AnimationTrack track)
			{
			}
		}

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BB870", Offset = "0x1BB870")]
		private sealed class _003Cget_outputs_003Ed__49 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x18")]
			private PlayableBinding _003C_003E2__current;

			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x38")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x40")]
			public AnimationTrack _003C_003E4__this;

			[Token(Token = "0x1700002A")]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002ECurrent
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x2AF9DF8", Offset = "0x2AF9DF8", VA = "0x2AF9DF8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0x2AF9E48", Offset = "0x2AF9E48", VA = "0x2AF9E48", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2AE229C", Offset = "0x2AE229C", VA = "0x2AE229C")]
			[DebuggerHidden]
			public _003Cget_outputs_003Ed__49(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2AF9D60", Offset = "0x2AF9D60", VA = "0x2AF9D60", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2AF9D64", Offset = "0x2AF9D64", VA = "0x2AF9D64", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2AF9DF8", Offset = "0x2AF9DF8", VA = "0x2AF9DF8", Slot = "6")]
			[DebuggerHidden]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2AF9E08", Offset = "0x2AF9E08", VA = "0x2AF9E08", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2AF9E48", Offset = "0x2AF9E48", VA = "0x2AF9E48", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2AF9EB4", Offset = "0x2AF9EB4", VA = "0x2AF9EB4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PlayableBinding> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2AF9F5C", Offset = "0x2AF9F5C", VA = "0x2AF9F5C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000031")]
		private const string k_DefaultInfiniteClipName = "Recorded";

		[Token(Token = "0x4000032")]
		private const string k_DefaultRecordableClipName = "Recorded";

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBBE0", Offset = "0x1BBBE0")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBC2C", Offset = "0x1BBC2C")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBC78", Offset = "0x1BBC78")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetPosition;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBCC4", Offset = "0x1BBCC4")]
		private Vector3 m_InfiniteClipOffsetEulerAngles;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBD10", Offset = "0x1BBD10")]
		[SerializeField]
		private double m_InfiniteClipTimeOffset;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBD5C", Offset = "0x1BBD5C")]
		[SerializeField]
		private bool m_InfiniteClipRemoveOffset;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_InfiniteClipApplyFootIK;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Vector3 m_EulerAngles;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AvatarMask m_AvatarMask;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_ApplyAvatarMask;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private TrackOffset m_TrackOffset;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private AnimationClip m_InfiniteClip;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Queue<Transform> s_CachedQueue;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BBE38", Offset = "0x1BBE38")]
		private Quaternion m_OpenClipOffsetRotation;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BBE88", Offset = "0x1BBE88")]
		private Quaternion m_Rotation;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BBED8", Offset = "0x1BBED8")]
		[SerializeField]
		private bool m_ApplyOffsets;

		[Token(Token = "0x17000011")]
		public Vector3 position
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2AE1FF0", Offset = "0x2AE1FF0", VA = "0x2AE1FF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2AE1FFC", Offset = "0x2AE1FFC", VA = "0x2AE1FFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2AE2008", Offset = "0x2AE2008", VA = "0x2AE2008")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2AE2018", Offset = "0x2AE2018", VA = "0x2AE2018")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2AE2058", Offset = "0x2AE2058", VA = "0x2AE2058")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2AE2064", Offset = "0x2AE2064", VA = "0x2AE2064")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC580", Offset = "0x1BC580")]
		public bool applyOffsets
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2AE2070", Offset = "0x2AE2070", VA = "0x2AE2070")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000015")]
		public TrackOffset trackOffset
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2AE2078", Offset = "0x2AE2078", VA = "0x2AE2078")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2AE2080", Offset = "0x2AE2080", VA = "0x2AE2080")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public MatchTargetFields matchTargetFields
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2AE2088", Offset = "0x2AE2088", VA = "0x2AE2088")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2AE2090", Offset = "0x2AE2090", VA = "0x2AE2090")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public AnimationClip infiniteClip
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2AE210C", Offset = "0x2AE210C", VA = "0x2AE210C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2AE2114", Offset = "0x2AE2114", VA = "0x2AE2114")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000018")]
		internal bool infiniteClipRemoveOffset
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2AE211C", Offset = "0x2AE211C", VA = "0x2AE211C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2AE2124", Offset = "0x2AE2124", VA = "0x2AE2124")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public AvatarMask avatarMask
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2AE212C", Offset = "0x2AE212C", VA = "0x2AE212C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2AE2134", Offset = "0x2AE2134", VA = "0x2AE2134")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool applyAvatarMask
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2AE213C", Offset = "0x2AE213C", VA = "0x2AE213C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2AE2144", Offset = "0x2AE2144", VA = "0x2AE2144")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2AE2218", Offset = "0x2AE2218", VA = "0x2AE2218", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public bool inClipMode
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2AE22D4", Offset = "0x2AE22D4", VA = "0x2AE22D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001D")]
		public Vector3 infiniteClipOffsetPosition
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2AE23DC", Offset = "0x2AE23DC", VA = "0x2AE23DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2AE23E8", Offset = "0x2AE23E8", VA = "0x2AE23E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Quaternion infiniteClipOffsetRotation
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2AE23F4", Offset = "0x2AE23F4", VA = "0x2AE23F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2AE2404", Offset = "0x2AE2404", VA = "0x2AE2404")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 infiniteClipOffsetEulerAngles
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2AE2444", Offset = "0x2AE2444", VA = "0x2AE2444")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2AE2450", Offset = "0x2AE2450", VA = "0x2AE2450")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		internal bool infiniteClipApplyFootIK
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2AE245C", Offset = "0x2AE245C", VA = "0x2AE245C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2AE2464", Offset = "0x2AE2464", VA = "0x2AE2464")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		internal double infiniteClipTimeOffset
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2AE246C", Offset = "0x2AE246C", VA = "0x2AE246C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2AE2474", Offset = "0x2AE2474", VA = "0x2AE2474")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2AE247C", Offset = "0x2AE247C", VA = "0x2AE247C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2AE2484", Offset = "0x2AE2484", VA = "0x2AE2484")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2AE248C", Offset = "0x2AE248C", VA = "0x2AE248C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2AE2494", Offset = "0x2AE2494", VA = "0x2AE2494")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		internal AnimationPlayableAsset.LoopMode infiniteClipLoop
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2AE249C", Offset = "0x2AE249C", VA = "0x2AE249C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2AE24A4", Offset = "0x2AE24A4", VA = "0x2AE24A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1BC5BC", Offset = "0x1BC5BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC5BC", Offset = "0x1BC5BC")]
		public Vector3 openClipOffsetPosition
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2AE6930", Offset = "0x2AE6930", VA = "0x2AE6930")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2AE693C", Offset = "0x2AE693C", VA = "0x2AE693C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1BC610", Offset = "0x1BC610")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC610", Offset = "0x1BC610")]
		public Quaternion openClipOffsetRotation
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2AE6948", Offset = "0x2AE6948", VA = "0x2AE6948")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2AE6958", Offset = "0x2AE6958", VA = "0x2AE6958")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1BC664", Offset = "0x1BC664")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC664", Offset = "0x1BC664")]
		public Vector3 openClipOffsetEulerAngles
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2AE6998", Offset = "0x2AE6998", VA = "0x2AE6998")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x2AE69A4", Offset = "0x2AE69A4", VA = "0x2AE69A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1BC6B8", Offset = "0x1BC6B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC6B8", Offset = "0x1BC6B8")]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x2AE69B0", Offset = "0x2AE69B0", VA = "0x2AE69B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2AE69B8", Offset = "0x2AE69B8", VA = "0x2AE69B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1BC70C", Offset = "0x1BC70C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BC70C", Offset = "0x1BC70C")]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2AE69C0", Offset = "0x2AE69C0", VA = "0x2AE69C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2AE69C8", Offset = "0x2AE69C8", VA = "0x2AE69C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2AE214C", Offset = "0x2AE214C", VA = "0x2AE214C", Slot = "32")]
		internal override bool CanCompileClips()
		{
			return default;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2AE24AC", Offset = "0x2AE24AC", VA = "0x2AE24AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1BC338", Offset = "0x1BC338")]
		private void ResetOffsets()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2AE24EC", Offset = "0x2AE24EC", VA = "0x2AE24EC")]
		public TimelineClip CreateClip(AnimationClip clip)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2AE2808", Offset = "0x2AE2808", VA = "0x2AE2808")]
		public void CreateInfiniteClip(string infiniteClipName)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2AE2B38", Offset = "0x2AE2B38", VA = "0x2AE2B38")]
		public TimelineClip CreateRecordableClip(string animClipName)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2AE2EA0", Offset = "0x2AE2EA0", VA = "0x2AE2EA0", Slot = "29")]
		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2AE3088", Offset = "0x2AE3088", VA = "0x2AE3088", Slot = "30")]
		protected internal override int CalculateItemsHash()
		{
			return default;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2AE24E8", Offset = "0x2AE24E8", VA = "0x2AE24E8")]
		internal void UpdateClipOffsets()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2AE32F8", Offset = "0x2AE32F8", VA = "0x2AE32F8")]
		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2AE3E08", Offset = "0x2AE3E08", VA = "0x2AE3E08", Slot = "34")]
		private Playable UnityEngine_002ETimeline_002EILayerable_002ECreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2AE3E64", Offset = "0x2AE3E64", VA = "0x2AE3E64", Slot = "25")]
		internal override Playable OnCreateClipPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2AE4E34", Offset = "0x2AE4E34", VA = "0x2AE4E34")]
		private int GetDefaultBlendCount()
		{
			return default;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2AE5408", Offset = "0x2AE5408", VA = "0x2AE5408")]
		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2AE541C", Offset = "0x2AE541C", VA = "0x2AE541C")]
		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
		{
			return default;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2AE52DC", Offset = "0x2AE52DC", VA = "0x2AE52DC")]
		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
		{
			return default;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2AE540C", Offset = "0x2AE540C", VA = "0x2AE540C")]
		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
		{
			return default;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2AE57E8", Offset = "0x2AE57E8", VA = "0x2AE57E8")]
		private bool HasController(GameObject gameObject)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2AE55C0", Offset = "0x2AE55C0", VA = "0x2AE55C0")]
		internal Animator GetBinding(PlayableDirector director)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2AE4E3C", Offset = "0x2AE4E3C", VA = "0x2AE4E3C")]
		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2AE4ED8", Offset = "0x2AE4ED8", VA = "0x2AE4ED8")]
		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2AE3C58", Offset = "0x2AE3C58", VA = "0x2AE3C58")]
		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
		{
			return default;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2AE5960", Offset = "0x2AE5960", VA = "0x2AE5960", Slot = "26")]
		internal override void GetEvaluationTime(out double outStart, out double outDuration)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2AE5C9C", Offset = "0x2AE5C9C", VA = "0x2AE5C9C", Slot = "27")]
		internal override void GetSequenceTime(out double outStart, out double outDuration)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2AE25A4", Offset = "0x2AE25A4", VA = "0x2AE25A4")]
		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2AE61F8", Offset = "0x2AE61F8", VA = "0x2AE61F8", Slot = "28")]
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2AE61FC", Offset = "0x2AE61FC", VA = "0x2AE61FC")]
		private void GetAnimationClips(List<AnimationClip> animClips)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2AE4DBC", Offset = "0x2AE4DBC", VA = "0x2AE4DBC")]
		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
		{
			return default;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2AE4B00", Offset = "0x2AE4B00", VA = "0x2AE4B00")]
		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
		{
			return default;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2AE490C", Offset = "0x2AE490C", VA = "0x2AE490C")]
		private Transform GetGenericRootNode(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2AE3814", Offset = "0x2AE3814", VA = "0x2AE3814")]
		internal bool AnimatesRootTransform()
		{
			return default;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2AE6730", Offset = "0x2AE6730", VA = "0x2AE6730")]
		private static Transform FindInHierarchyBreadthFirst(Transform t, string name)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2AE69D0", Offset = "0x2AE69D0", VA = "0x2AE69D0", Slot = "18")]
		internal override void OnUpgradeFromVersion(int oldVersion)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2AE6B48", Offset = "0x2AE6B48", VA = "0x2AE6B48")]
		public AnimationTrack()
		{
		}
	}
}
