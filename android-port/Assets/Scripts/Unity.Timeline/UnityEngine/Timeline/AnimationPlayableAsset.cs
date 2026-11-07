using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x2000004")]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000005")]
		public enum LoopMode
		{
			[Token(Token = "0x4000013")]
			UseSourceAsset = 0,
			[Token(Token = "0x4000014")]
			On = 1,
			[Token(Token = "0x4000015")]
			Off = 2
		}

		[Token(Token = "0x2000006")]
		private static class AnimationPlayableAssetUpgrade
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2AE1EAC", Offset = "0x2AE1EAC", VA = "0x2AE1EAC")]
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
			{
			}
		}

		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BB7A0", Offset = "0x1BB7A0")]
		private sealed class _003Cget_outputs_003Ed__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x18")]
			private PlayableBinding _003C_003E2__current;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x38")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x40")]
			public AnimationPlayableAsset _003C_003E4__this;

			[Token(Token = "0x1700000F")]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002ECurrent
			{
				[Token(Token = "0x600002D")]
				[Address(RVA = "0x2AF9BF8", Offset = "0x2AF9BF8", VA = "0x2AF9BF8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000010")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600002F")]
				[Address(RVA = "0x2AF9C48", Offset = "0x2AF9C48", VA = "0x2AF9C48", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2AE1500", Offset = "0x2AE1500", VA = "0x2AE1500")]
			[DebuggerHidden]
			public _003Cget_outputs_003Ed__45(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2AF9B60", Offset = "0x2AF9B60", VA = "0x2AF9B60", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2AF9B64", Offset = "0x2AF9B64", VA = "0x2AF9B64", Slot = "8")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2AF9BF8", Offset = "0x2AF9BF8", VA = "0x2AF9BF8", Slot = "6")]
			[DebuggerHidden]
			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2AF9C08", Offset = "0x2AF9C08", VA = "0x2AF9C08", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2AF9C48", Offset = "0x2AF9C48", VA = "0x2AF9C48", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2AF9CB4", Offset = "0x2AF9CB4", VA = "0x2AF9CB4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PlayableBinding> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2AF9D5C", Offset = "0x2AF9D5C", VA = "0x2AF9D5C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationClip m_Clip;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 m_EulerAngles;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_UseTrackMatchFields;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_RemoveStartOffset;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool m_ApplyFootIK;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private LoopMode m_Loop;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BBB70", Offset = "0x1BBB70")]
		private AppliedOffsetMode appliedOffsetMode__BackingField;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int k_LatestVersion;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int m_Version;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BBB90", Offset = "0x1BBB90")]
		[SerializeField]
		private Quaternion m_Rotation;

		[Token(Token = "0x17000001")]
		public Vector3 position
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2AE0EFC", Offset = "0x2AE0EFC", VA = "0x2AE0EFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2AE0F08", Offset = "0x2AE0F08", VA = "0x2AE0F08")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2AE0F14", Offset = "0x2AE0F14", VA = "0x2AE0F14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2AE0F24", Offset = "0x2AE0F24", VA = "0x2AE0F24")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2AE0F64", Offset = "0x2AE0F64", VA = "0x2AE0F64")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2AE0F70", Offset = "0x2AE0F70", VA = "0x2AE0F70")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool useTrackMatchFields
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2AE0F7C", Offset = "0x2AE0F7C", VA = "0x2AE0F7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2AE0F84", Offset = "0x2AE0F84", VA = "0x2AE0F84")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public MatchTargetFields matchTargetFields
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2AE0F8C", Offset = "0x2AE0F8C", VA = "0x2AE0F8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2AE0F94", Offset = "0x2AE0F94", VA = "0x2AE0F94")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool removeStartOffset
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2AE0F9C", Offset = "0x2AE0F9C", VA = "0x2AE0F9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2AE0FA4", Offset = "0x2AE0FA4", VA = "0x2AE0FA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool applyFootIK
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2AE0FAC", Offset = "0x2AE0FAC", VA = "0x2AE0FAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2AE0FB4", Offset = "0x2AE0FB4", VA = "0x2AE0FB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public LoopMode loop
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2AE0FBC", Offset = "0x2AE0FBC", VA = "0x2AE0FBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2AE0FC4", Offset = "0x2AE0FC4", VA = "0x2AE0FC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		internal bool hasRootTransforms
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2AE0FCC", Offset = "0x2AE0FCC", VA = "0x2AE0FCC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		internal AppliedOffsetMode appliedOffsetMode
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2AE1180", Offset = "0x2AE1180", VA = "0x2AE1180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC2A8", Offset = "0x1BC2A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2AE1188", Offset = "0x2AE1188", VA = "0x2AE1188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC2B8", Offset = "0x1BC2B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public AnimationClip clip
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2AE1190", Offset = "0x2AE1190", VA = "0x2AE1190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2AE1198", Offset = "0x2AE1198", VA = "0x2AE1198")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public override double duration
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2AE1260", Offset = "0x2AE1260", VA = "0x2AE1260", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000D")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2AE147C", Offset = "0x2AE147C", VA = "0x2AE147C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2AE1B40", Offset = "0x2AE1B40", VA = "0x2AE1B40", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2AE1538", Offset = "0x2AE1538", VA = "0x2AE1538", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2AE1648", Offset = "0x2AE1648", VA = "0x2AE1648")]
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop)
		{
			return default;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2AE1AB8", Offset = "0x2AE1AB8", VA = "0x2AE1AB8")]
		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
		{
			return default;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2AE1AA0", Offset = "0x2AE1AA0", VA = "0x2AE1AA0")]
		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
		{
			return default;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2AE1C50", Offset = "0x2AE1C50", VA = "0x2AE1C50")]
		public void ResetOffsets()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2AE1C8C", Offset = "0x2AE1C8C", VA = "0x2AE1C8C", Slot = "10")]
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2AE109C", Offset = "0x2AE109C", VA = "0x2AE109C")]
		internal static bool HasRootTransforms(AnimationClip clip)
		{
			return default;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2AE1D54", Offset = "0x2AE1D54", VA = "0x2AE1D54", Slot = "11")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2AE1DC8", Offset = "0x2AE1DC8", VA = "0x2AE1DC8", Slot = "12")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2AE1E6C", Offset = "0x2AE1E6C", VA = "0x2AE1E6C")]
		private void OnUpgradeFromVersion(int oldVersion)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2AE1EE4", Offset = "0x2AE1EE4", VA = "0x2AE1EE4")]
		public AnimationPlayableAsset()
		{
		}
	}
}
