using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x2000010")]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000011")]
		private static class TimelineClipUpgrade
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2AF07EC", Offset = "0x2AF07EC", VA = "0x2AF07EC")]
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip)
			{
			}
		}

		[Token(Token = "0x2000012")]
		public enum ClipExtrapolation
		{
			[Token(Token = "0x400006A")]
			None = 0,
			[Token(Token = "0x400006B")]
			Hold = 1,
			[Token(Token = "0x400006C")]
			Loop = 2,
			[Token(Token = "0x400006D")]
			PingPong = 3,
			[Token(Token = "0x400006E")]
			Continue = 4
		}

		[Token(Token = "0x2000013")]
		public enum BlendCurveMode
		{
			[Token(Token = "0x4000070")]
			Auto = 0,
			[Token(Token = "0x4000071")]
			Manual = 1
		}

		[Token(Token = "0x400004A")]
		private const int k_LatestVersion = 1;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_Version;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ClipCaps kDefaultClipCaps;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x4")]
		public static readonly float kDefaultClipDurationInSeconds;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly double kTimeScaleMin;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly double kTimeScaleMax;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly string kDefaultCurvesName;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly double kMinDuration;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly double kMaxTimeValue;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double m_Start;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double m_ClipIn;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Object m_Asset;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BBF68", Offset = "0x1BBF68")]
		[SerializeField]
		private double m_Duration;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private double m_TimeScale;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TrackAsset m_ParentTrack;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private double m_EaseInDuration;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private double m_EaseOutDuration;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private double m_BlendInDuration;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private double m_BlendOutDuration;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve m_MixInCurve;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve m_MixOutCurve;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BlendCurveMode m_BlendInCurveMode;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private BlendCurveMode m_BlendOutCurveMode;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<string> m_ExposedParameterNames;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationClip m_AnimationCurves;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool m_Recordable;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private ClipExtrapolation m_PostExtrapolationMode;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ClipExtrapolation m_PreExtrapolationMode;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private double m_PostExtrapolationTime;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private double m_PreExtrapolationTime;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_DisplayName;

		[Token(Token = "0x17000030")]
		public double timeScale
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2AF09CC", Offset = "0x2AF09CC", VA = "0x2AF09CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000031")]
		public double start
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2AF0AD4", Offset = "0x2AF0AD4", VA = "0x2AF0AD4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2AE2C90", Offset = "0x2AE2C90", VA = "0x2AE2C90")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public double duration
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2AF0C68", Offset = "0x2AF0C68", VA = "0x2AF0C68", Slot = "10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2AE2DCC", Offset = "0x2AE2DCC", VA = "0x2AE2DCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public double end
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2AE7B98", Offset = "0x2AE7B98", VA = "0x2AE7B98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000034")]
		public double clipIn
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2AEA514", Offset = "0x2AEA514", VA = "0x2AEA514")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000035")]
		public string displayName
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2AF0C70", Offset = "0x2AF0C70", VA = "0x2AF0C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x2AF0C78", Offset = "0x2AF0C78", VA = "0x2AF0C78")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public AnimationClip curves
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2AF0C80", Offset = "0x2AF0C80", VA = "0x2AF0C80", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private string UnityEngine_002ETimeline_002EICurvesOwner_002EdefaultCurvesName
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x2AF0C88", Offset = "0x2AF0C88", VA = "0x2AF0C88", Slot = "4")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_defaultCurvesName();
			}
		}

		[Token(Token = "0x17000038")]
		public Object asset
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2AF0CEC", Offset = "0x2AF0CEC", VA = "0x2AF0CEC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2AF0CF4", Offset = "0x2AF0CF4", VA = "0x2AF0CF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		private Object UnityEngine_002ETimeline_002EICurvesOwner_002EassetOwner
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2AF0CFC", Offset = "0x2AF0CFC", VA = "0x2AF0CFC", Slot = "6")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_assetOwner();
			}
		}

		[Token(Token = "0x1700003A")]
		private TrackAsset UnityEngine_002ETimeline_002EICurvesOwner_002EtargetTrack
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2AF0D04", Offset = "0x2AF0D04", VA = "0x2AF0D04", Slot = "7")]
			get
			{
				return UnityEngine_002ETimeline_002EICurvesOwner_002Eget_targetTrack();
			}
		}

		[Token(Token = "0x1700003B")]
		public TrackAsset parentTrack
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2AF0D0C", Offset = "0x2AF0D0C", VA = "0x2AF0D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2AF0868", Offset = "0x2AF0868", VA = "0x2AF0868")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public double easeInDuration
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2AF0DAC", Offset = "0x2AF0DAC", VA = "0x2AF0DAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003D")]
		public double easeOutDuration
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2AF0E50", Offset = "0x2AF0E50", VA = "0x2AF0E50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public double blendInDuration
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2AF0EF4", Offset = "0x2AF0EF4", VA = "0x2AF0EF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003F")]
		public double blendOutDuration
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2AF0F20", Offset = "0x2AF0F20", VA = "0x2AF0F20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public bool hasBlendIn
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2AF0F4C", Offset = "0x2AF0F4C", VA = "0x2AF0F4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public bool hasBlendOut
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2AF0F84", Offset = "0x2AF0F84", VA = "0x2AF0F84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public AnimationCurve mixInCurve
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2AF0FBC", Offset = "0x2AF0FBC", VA = "0x2AF0FBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2AF1068", Offset = "0x2AF1068", VA = "0x2AF1068")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public double mixInDuration
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2AF1070", Offset = "0x2AF1070", VA = "0x2AF1070")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		public AnimationCurve mixOutCurve
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2AF10C4", Offset = "0x2AF10C4", VA = "0x2AF10C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2AF1170", Offset = "0x2AF1170", VA = "0x2AF1170")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public double mixOutTime
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2AF1178", Offset = "0x2AF1178", VA = "0x2AF1178")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000046")]
		public double mixOutDuration
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2AF11E0", Offset = "0x2AF11E0", VA = "0x2AF11E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000047")]
		public bool recordable
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2AF1234", Offset = "0x2AF1234", VA = "0x2AF1234")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2AF123C", Offset = "0x2AF123C", VA = "0x2AF123C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2AECB50", Offset = "0x2AECB50", VA = "0x2AECB50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000049")]
		public ClipExtrapolation postExtrapolationMode
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2AE7BA8", Offset = "0x2AE7BA8", VA = "0x2AE7BA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2AE3050", Offset = "0x2AE3050", VA = "0x2AE3050")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public ClipExtrapolation preExtrapolationMode
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2AF14A8", Offset = "0x2AF14A8", VA = "0x2AF14A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2AE3018", Offset = "0x2AE3018", VA = "0x2AE3018")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public double extrapolatedStart
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2AEA1D4", Offset = "0x2AEA1D4", VA = "0x2AEA1D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public double extrapolatedDuration
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2AEA204", Offset = "0x2AEA204", VA = "0x2AEA204")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2AF07A0", Offset = "0x2AF07A0", VA = "0x2AF07A0")]
		private void UpgradeToLatestVersion()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2AF0828", Offset = "0x2AF0828", VA = "0x2AF0828")]
		internal TimelineClip(TrackAsset parent)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2AF0C88", Offset = "0x2AF0C88", VA = "0x2AF0C88", Slot = "4")]
		private string UnityEngine_002ETimeline_002EICurvesOwner_002Eget_defaultCurvesName()
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2AF0CFC", Offset = "0x2AF0CFC", VA = "0x2AF0CFC", Slot = "6")]
		private Object UnityEngine_002ETimeline_002EICurvesOwner_002Eget_assetOwner()
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2AF0D04", Offset = "0x2AF0D04", VA = "0x2AF0D04", Slot = "7")]
		private TrackAsset UnityEngine_002ETimeline_002EICurvesOwner_002Eget_targetTrack()
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2AF1244", Offset = "0x2AF1244", VA = "0x2AF1244")]
		internal int Hash()
		{
			return default;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2AEAAD4", Offset = "0x2AEAAD4", VA = "0x2AEAAD4")]
		public float EvaluateMixOut(double time)
		{
			return default;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2AEA8C8", Offset = "0x2AEA8C8", VA = "0x2AEA8C8")]
		public float EvaluateMixIn(double time)
		{
			return default;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2AF1050", Offset = "0x2AF1050", VA = "0x2AF1050")]
		private static AnimationCurve GetDefaultMixInCurve()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2AF1158", Offset = "0x2AF1158", VA = "0x2AF1158")]
		private static AnimationCurve GetDefaultMixOutCurve()
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2AEACD0", Offset = "0x2AEACD0", VA = "0x2AEACD0")]
		public double ToLocalTime(double time)
		{
			return default;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2AF0AE0", Offset = "0x2AF0AE0", VA = "0x2AF0AE0")]
		private static double SanitizeTimeValue(double value, double defaultValue)
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2AF14D8", Offset = "0x2AF14D8", VA = "0x2AF14D8")]
		internal void SetPostExtrapolationTime(double time)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2AF14E0", Offset = "0x2AF14E0", VA = "0x2AF14E0")]
		internal void SetPreExtrapolationTime(double time)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2AEA86C", Offset = "0x2AEA86C", VA = "0x2AEA86C")]
		public bool IsPreExtrapolatedTime(double sequenceTime)
		{
			return default;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2AEAA70", Offset = "0x2AEAA70", VA = "0x2AEAA70")]
		public bool IsPostExtrapolatedTime(double sequenceTime)
		{
			return default;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2AF1340", Offset = "0x2AF1340", VA = "0x2AF1340")]
		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration)
		{
			return default;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2AF14E8", Offset = "0x2AF14E8", VA = "0x2AF14E8", Slot = "8")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2AF14F4", Offset = "0x2AF14F4", VA = "0x2AF14F4", Slot = "9")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2AF1540", Offset = "0x2AF1540", VA = "0x2AF1540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2AF0ADC", Offset = "0x2AF0ADC", VA = "0x2AF0ADC")]
		private void UpdateDirty(double oldValue, double newValue)
		{
		}
	}
}
