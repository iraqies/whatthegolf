using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Token(Token = "0x20001EB")]
	public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal
	{
		[Serializable]
		[Token(Token = "0x20001EC")]
		public abstract class Platform : IDeepCloneable
		{
			[Token(Token = "0x20001ED")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19170C", Offset = "0x19170C")]
			private sealed class EcgBWnfZFHPsRZygoHyybPTVsxwh : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform>, IEnumerator<Platform>
			{
				[Token(Token = "0x4000B16")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000B17")]
				[FieldOffset(Offset = "0x18")]
				private Platform VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000B18")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000B19")]
				[FieldOffset(Offset = "0x28")]
				public Platform TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000B1A")]
				[FieldOffset(Offset = "0x30")]
				private IList<Platform> YLOKmkmicWhMOGxFAFRAXBBfdAWx;

				[Token(Token = "0x4000B1B")]
				[FieldOffset(Offset = "0x38")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x170003E8")]
				private Platform System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_003E_002ECurrent
				{
					[Token(Token = "0x6000E77")]
					[Address(RVA = "0x23A512C", Offset = "0x23A512C", VA = "0x23A512C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170003E9")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000E79")]
					[Address(RVA = "0x23A5174", Offset = "0x23A5174", VA = "0x23A5174", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000E74")]
				[Address(RVA = "0x23A4E90", Offset = "0x23A4E90", VA = "0x23A4E90")]
				[DebuggerHidden]
				public EcgBWnfZFHPsRZygoHyybPTVsxwh(int P_0)
				{
				}

				[Token(Token = "0x6000E75")]
				[Address(RVA = "0x23A4ED8", Offset = "0x23A4ED8", VA = "0x23A4ED8", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000E76")]
				[Address(RVA = "0x23A4EDC", Offset = "0x23A4EDC", VA = "0x23A4EDC", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000E77")]
				[Address(RVA = "0x23A512C", Offset = "0x23A512C", VA = "0x23A512C", Slot = "10")]
				[DebuggerHidden]
				private Platform System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000E78")]
				[Address(RVA = "0x23A5134", Offset = "0x23A5134", VA = "0x23A5134", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000E79")]
				[Address(RVA = "0x23A5174", Offset = "0x23A5174", VA = "0x23A5174", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000E7A")]
				[Address(RVA = "0x23A517C", Offset = "0x23A517C", VA = "0x23A517C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000E7B")]
				[Address(RVA = "0x23A523C", Offset = "0x23A523C", VA = "0x23A523C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000B15")]
			[FieldOffset(Offset = "0x10")]
			public string description;

			[Token(Token = "0x170003DA")]
			internal abstract InputPlatform platform
			{
				[Token(Token = "0x6000E58")]
				get;
			}

			[Token(Token = "0x170003DB")]
			public abstract int assignedButtonCount
			{
				[Token(Token = "0x6000E59")]
				get;
			}

			[Token(Token = "0x170003DC")]
			public abstract int assignedAxisCount
			{
				[Token(Token = "0x6000E5A")]
				get;
			}

			[Token(Token = "0x170003DD")]
			public virtual string controllerNameOverride
			{
				[Token(Token = "0x6000E5B")]
				[Address(RVA = "0x2466D30", Offset = "0x2466D30", VA = "0x2466D30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003DE")]
			internal virtual bool isAllowed
			{
				[Token(Token = "0x6000E5C")]
				[Address(RVA = "0x2466D38", Offset = "0x2466D38", VA = "0x2466D38", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003DF")]
			internal abstract bool hasData
			{
				[Token(Token = "0x6000E60")]
				get;
			}

			[Token(Token = "0x170003E0")]
			internal abstract bool disabled
			{
				[Token(Token = "0x6000E61")]
				get;
			}

			[Token(Token = "0x170003E1")]
			internal abstract IList<Platform> variants_base
			{
				[Token(Token = "0x6000E62")]
				get;
			}

			[Token(Token = "0x170003E2")]
			internal IEnumerable<Platform> Variants
			{
				[Token(Token = "0x6000E63")]
				[Address(RVA = "0x2466DA8", Offset = "0x2466DA8", VA = "0x2466DA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003E3")]
			internal bool hasVariants
			{
				[Token(Token = "0x6000E64")]
				[Address(RVA = "0x2466E1C", Offset = "0x2466E1C", VA = "0x2466E1C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003E4")]
			internal int variantCount
			{
				[Token(Token = "0x6000E65")]
				[Address(RVA = "0x2466E38", Offset = "0x2466E38", VA = "0x2466E38")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003E5")]
			internal bool selfOrVariantHasData
			{
				[Token(Token = "0x6000E66")]
				[Address(RVA = "0x2466F20", Offset = "0x2466F20", VA = "0x2466F20")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003E6")]
			internal bool selfOrVariantIsValid
			{
				[Token(Token = "0x6000E67")]
				[Address(RVA = "0x24672D8", Offset = "0x24672D8", VA = "0x24672D8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003E7")]
			internal bool selfOrVariantIsAllowed
			{
				[Token(Token = "0x6000E68")]
				[Address(RVA = "0x24676D0", Offset = "0x24676D0", VA = "0x24676D0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000E5D")]
			internal abstract bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap);

			[Token(Token = "0x6000E5E")]
			internal abstract void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes);

			[Token(Token = "0x6000E5F")]
			internal abstract bool IsElementIdentifierMapped(int elementIdentifierId);

			[Token(Token = "0x6000E69")]
			[Address(RVA = "0x2467A80", Offset = "0x2467A80", VA = "0x2467A80")]
			internal Platform GetFirstValidPlatformMap(out int variantIndex)
			{
				return null;
			}

			[Token(Token = "0x6000E6A")]
			internal abstract AxisCalibrationData[] GetAxisCalibrationData();

			[Token(Token = "0x6000E6B")]
			internal abstract void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos);

			[Token(Token = "0x6000E6C")]
			internal abstract void GetButtonData(out HardwareButtonInfo[] buttonInfos);

			[Token(Token = "0x6000E6D")]
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);

			[Token(Token = "0x6000E6E")]
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);

			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x2467C78", Offset = "0x2467C78", VA = "0x2467C78")]
			internal Platform GetPlatformMap(int variantIndex)
			{
				return null;
			}

			[Token(Token = "0x6000E70")]
			[Address(RVA = "0x2467D8C", Offset = "0x2467D8C", VA = "0x2467D8C")]
			internal HardwareJoystickMap_InputManager ToHardwareJoystickMap_InputManager(HardwareJoystickMap hardwareJoystickMap, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex)
			{
				return null;
			}

			[Token(Token = "0x6000E71")]
			public abstract object DeepClone();

			[Token(Token = "0x6000E72")]
			internal abstract void CopyVars(Platform destination);

			[Token(Token = "0x6000E73")]
			[Address(RVA = "0x2469878", Offset = "0x2469878", VA = "0x2469878")]
			protected Platform()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001EE")]
		public abstract class Elements_Base : IDeepCloneable
		{
			[Token(Token = "0x170003EA")]
			public abstract int buttonCount
			{
				[Token(Token = "0x6000E7D")]
				get;
			}

			[Token(Token = "0x170003EB")]
			public abstract int axisCount
			{
				[Token(Token = "0x6000E7E")]
				get;
			}

			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x2466A4C", Offset = "0x2466A4C", VA = "0x2466A4C", Slot = "5")]
			internal virtual void CopyVars(Elements_Base destination)
			{
			}

			[Token(Token = "0x6000E7F")]
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);

			[Token(Token = "0x6000E80")]
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);

			[Token(Token = "0x6000E81")]
			public abstract object DeepClone();

			[Token(Token = "0x6000E82")]
			[Address(RVA = "0x2466A50", Offset = "0x2466A50", VA = "0x2466A50")]
			protected Elements_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001EF")]
		public abstract class MatchingCriteria_Base : IDeepCloneable
		{
			[Serializable]
			[Token(Token = "0x20001F0")]
			public class ElementCount_Base : IDeepCloneable
			{
				[Token(Token = "0x4000B20")]
				[FieldOffset(Offset = "0x10")]
				public int axisCount;

				[Token(Token = "0x4000B21")]
				[FieldOffset(Offset = "0x14")]
				public int buttonCount;

				[Token(Token = "0x6000E8D")]
				[Address(RVA = "0x23A4DC0", Offset = "0x23A4DC0", VA = "0x23A4DC0")]
				public ElementCount_Base()
				{
				}

				[Token(Token = "0x6000E8E")]
				[Address(RVA = "0x23A4DC8", Offset = "0x23A4DC8", VA = "0x23A4DC8", Slot = "5")]
				public virtual object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000E8F")]
				[Address(RVA = "0x23A4E40", Offset = "0x23A4E40", VA = "0x23A4E40", Slot = "6")]
				internal virtual void KGvHNOSFSLcIoKIKCrVnqZaTvqVy(ElementCount_Base P_0)
				{
				}

				[Token(Token = "0x6000E90")]
				[Address(RVA = "0x23A4E50", Offset = "0x23A4E50", VA = "0x23A4E50", Slot = "7")]
				internal virtual bool dRTWaRkWIkEMLraxMRHrbdGkCqGCA(BridgedControllerHWInfo P_0)
				{
					return default;
				}
			}

			[Token(Token = "0x4000B1C")]
			[FieldOffset(Offset = "0x10")]
			public int axisCount;

			[Token(Token = "0x4000B1D")]
			[FieldOffset(Offset = "0x14")]
			public int buttonCount;

			[Token(Token = "0x4000B1E")]
			[FieldOffset(Offset = "0x18")]
			public bool disabled;

			[Token(Token = "0x4000B1F")]
			[FieldOffset(Offset = "0x20")]
			public string tag;

			[Token(Token = "0x170003EC")]
			internal abstract bool hasData
			{
				[Token(Token = "0x6000E83")]
				get;
			}

			[Token(Token = "0x170003ED")]
			internal virtual bool isAllowed
			{
				[Token(Token = "0x6000E84")]
				[Address(RVA = "0x2466A58", Offset = "0x2466A58", VA = "0x2466A58", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003EE")]
			internal abstract int alternateElementCount
			{
				[Token(Token = "0x6000E86")]
				get;
			}

			[Token(Token = "0x6000E85")]
			[Address(RVA = "0x2466A68", Offset = "0x2466A68", VA = "0x2466A68", Slot = "7")]
			internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch)
			{
				return default;
			}

			[Token(Token = "0x6000E87")]
			internal abstract ElementCount_Base GetAlternateElementCount(int index);

			[Token(Token = "0x6000E88")]
			[Address(RVA = "0x2466B08", Offset = "0x2466B08", VA = "0x2466B08", Slot = "10")]
			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
			{
				return default;
			}

			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x2466BE8", Offset = "0x2466BE8", VA = "0x2466BE8", Slot = "11")]
			internal virtual void CopyVars(MatchingCriteria_Base destination)
			{
			}

			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x2466C14", Offset = "0x2466C14", VA = "0x2466C14")]
			internal static bool StringMatches(string searchIn, string searchFor, bool useRegex)
			{
				return default;
			}

			[Token(Token = "0x6000E8B")]
			public abstract object DeepClone();

			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x2466D28", Offset = "0x2466D28", VA = "0x2466D28")]
			protected MatchingCriteria_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F1")]
		public class CompoundElement : IDeepCloneable
		{
			[Token(Token = "0x4000B22")]
			[FieldOffset(Offset = "0x10")]
			public CompoundControllerElementType type;

			[Token(Token = "0x4000B23")]
			[FieldOffset(Offset = "0x14")]
			public int elementIdentifier;

			[Token(Token = "0x4000B24")]
			[FieldOffset(Offset = "0x18")]
			public int[] componentElementIdentifiers;

			[Token(Token = "0x170003EF")]
			public int elementCount
			{
				[Token(Token = "0x6000E91")]
				[Address(RVA = "0x246664C", Offset = "0x246664C", VA = "0x246664C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x2466664", Offset = "0x2466664", VA = "0x2466664")]
			public CompoundElement()
			{
			}

			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x24666EC", Offset = "0x24666EC", VA = "0x24666EC")]
			public CompoundElement(CompoundElement P_0)
			{
			}

			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x2466770", Offset = "0x2466770", VA = "0x2466770")]
			public int GetComponentElementIdentifierId(int index)
			{
				return default;
			}

			[Token(Token = "0x6000E95")]
			[Address(RVA = "0x24667D8", Offset = "0x24667D8", VA = "0x24667D8", Slot = "5")]
			public virtual object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000E96")]
			[Address(RVA = "0x2466894", Offset = "0x2466894", VA = "0x2466894", Slot = "6")]
			protected virtual void ImportVars(CompoundElement source)
			{
			}

			[Token(Token = "0x6000E97")]
			[Address(RVA = "0x2466904", Offset = "0x2466904", VA = "0x2466904")]
			internal static void SortHatElementsClockwise(CompoundElement element)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F2")]
		public class VidPid
		{
			[Token(Token = "0x4000B25")]
			[FieldOffset(Offset = "0x10")]
			public int vendorId;

			[Token(Token = "0x4000B26")]
			[FieldOffset(Offset = "0x14")]
			public int productId;

			[Token(Token = "0x6000E98")]
			[Address(RVA = "0x2488438", Offset = "0x2488438", VA = "0x2488438")]
			public VidPid()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F3")]
		public class AxisCalibrationInfoEntry : IDeepCloneable
		{
			[Token(Token = "0x4000B27")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal AlternateAxisCalibrationType key;

			[Token(Token = "0x4000B28")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			internal AxisCalibrationInfo calibration;

			[Token(Token = "0x6000E99")]
			[Address(RVA = "0x2465E30", Offset = "0x2465E30", VA = "0x2465E30")]
			public AxisCalibrationInfoEntry(AxisCalibrationInfoEntry P_0)
			{
			}

			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x2465E68", Offset = "0x2465E68", VA = "0x2465E68", Slot = "5")]
			public virtual object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x2465EE0", Offset = "0x2465EE0", VA = "0x2465EE0", Slot = "6")]
			protected virtual void ImportVars(AxisCalibrationInfoEntry source)
			{
			}

			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x2465F88", Offset = "0x2465F88", VA = "0x2465F88")]
			public static Dictionary<int, AxisCalibrationInfo> ToDictionary(AxisCalibrationInfoEntry[] calibrations, bool deepClone)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001F4")]
		public abstract class Platform_RawOrDirectInput : Platform
		{
			[Serializable]
			[Token(Token = "0x20001F5")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Serializable]
				[Token(Token = "0x20001F6")]
				public sealed class ElementCount : ElementCount_Base
				{
					[Token(Token = "0x4000B31")]
					[FieldOffset(Offset = "0x18")]
					public int hatCount;

					[Token(Token = "0x6000EAF")]
					[Address(RVA = "0x23C2D54", Offset = "0x23C2D54", VA = "0x23C2D54")]
					public ElementCount()
					{
					}

					[Token(Token = "0x6000EB0")]
					[Address(RVA = "0x23C2D5C", Offset = "0x23C2D5C", VA = "0x23C2D5C", Slot = "5")]
					public override object DeepClone()
					{
						return null;
					}

					[Token(Token = "0x6000EB1")]
					[Address(RVA = "0x23C2DD4", Offset = "0x23C2DD4", VA = "0x23C2DD4", Slot = "6")]
					internal override void KGvHNOSFSLcIoKIKCrVnqZaTvqVy(ElementCount_Base P_0)
					{
					}

					[Token(Token = "0x6000EB2")]
					[Address(RVA = "0x23C2E60", Offset = "0x23C2E60", VA = "0x23C2E60", Slot = "7")]
					internal override bool dRTWaRkWIkEMLraxMRHrbdGkCqGCA(BridgedControllerHWInfo P_0)
					{
						return default;
					}
				}

				[Token(Token = "0x4000B2A")]
				[FieldOffset(Offset = "0x28")]
				public int hatCount;

				[Token(Token = "0x4000B2B")]
				[FieldOffset(Offset = "0x30")]
				public ElementCount[] alternateElementCounts;

				[Token(Token = "0x4000B2C")]
				[FieldOffset(Offset = "0x38")]
				public bool productName_useRegex;

				[Token(Token = "0x4000B2D")]
				[FieldOffset(Offset = "0x40")]
				public string[] productName;

				[Token(Token = "0x4000B2E")]
				[FieldOffset(Offset = "0x48")]
				public string[] productGUID;

				[Token(Token = "0x4000B2F")]
				[FieldOffset(Offset = "0x50")]
				public int[] productId;

				[Token(Token = "0x4000B30")]
				[FieldOffset(Offset = "0x58")]
				public DeviceType deviceType;

				[Token(Token = "0x170003F3")]
				internal override bool hasData
				{
					[Token(Token = "0x6000EA4")]
					[Address(RVA = "0x23AFAE0", Offset = "0x23AFAE0", VA = "0x23AFAE0", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170003F4")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6000EA5")]
					[Address(RVA = "0x23AFB20", Offset = "0x23AFB20", VA = "0x23AFB20", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170003F5")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6000EA7")]
					[Address(RVA = "0x23AFD10", Offset = "0x23AFD10", VA = "0x23AFD10", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000EA6")]
				[Address(RVA = "0x23AFB28", Offset = "0x23AFB28", VA = "0x23AFB28", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6000EA8")]
				[Address(RVA = "0x23AFD28", Offset = "0x23AFD28", VA = "0x23AFD28", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6000EA9")]
				[Address(RVA = "0x23AFD74", Offset = "0x23AFD74", VA = "0x23AFD74", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6000EAA")]
				[Address(RVA = "0x23AFC90", Offset = "0x23AFC90", VA = "0x23AFC90")]
				private bool ProductNameMatches(BridgedControllerHWInfo controller)
				{
					return default;
				}

				[Token(Token = "0x6000EAB")]
				[Address(RVA = "0x23AFDD8", Offset = "0x23AFDD8", VA = "0x23AFDD8")]
				private bool ProductNameMatches(string name)
				{
					return default;
				}

				[Token(Token = "0x6000EAC")]
				[Address(RVA = "0x23AFEFC", Offset = "0x23AFEFC", VA = "0x23AFEFC", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000EAD")]
				[Address(RVA = "0x23AFF7C", Offset = "0x23AFF7C", VA = "0x23AFF7C", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6000EAE")]
				[Address(RVA = "0x23AFF74", Offset = "0x23AFF74", VA = "0x23AFF74")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001F7")]
			public abstract class Elements_Platform_Base : Elements_Base
			{
				[Token(Token = "0x6000EB3")]
				[Address(RVA = "0x23A6F60", Offset = "0x23A6F60", VA = "0x23A6F60")]
				protected Elements_Platform_Base()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001F8")]
			public class CustomCalculationSourceData : IDeepCloneable
			{
				[Token(Token = "0x4000B32")]
				[FieldOffset(Offset = "0x10")]
				public int sourceType;

				[Token(Token = "0x4000B33")]
				[FieldOffset(Offset = "0x14")]
				public int sourceAxis;

				[Token(Token = "0x4000B34")]
				[FieldOffset(Offset = "0x18")]
				public int sourceButton;

				[Token(Token = "0x4000B35")]
				[FieldOffset(Offset = "0x1C")]
				public int sourceOtherAxis;

				[Token(Token = "0x4000B36")]
				[FieldOffset(Offset = "0x20")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000B37")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000B38")]
				[FieldOffset(Offset = "0x28")]
				public bool invert;

				[Token(Token = "0x4000B39")]
				[FieldOffset(Offset = "0x2C")]
				public AxisCalibrationType axisCalibrationType;

				[Token(Token = "0x4000B3A")]
				[FieldOffset(Offset = "0x30")]
				public float axisZero;

				[Token(Token = "0x4000B3B")]
				[FieldOffset(Offset = "0x34")]
				public float axisMin;

				[Token(Token = "0x4000B3C")]
				[FieldOffset(Offset = "0x38")]
				public float axisMax;

				[Token(Token = "0x6000EB4")]
				[Address(RVA = "0x23AFA2C", Offset = "0x23AFA2C", VA = "0x23AFA2C", Slot = "4")]
				public object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000EB5")]
				[Address(RVA = "0x23AFAD8", Offset = "0x23AFAD8", VA = "0x23AFAD8")]
				public CustomCalculationSourceData()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001F9")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x4000B3D")]
				[FieldOffset(Offset = "0x10")]
				public CustomCalculation customCalculation;

				[Token(Token = "0x4000B3E")]
				[FieldOffset(Offset = "0x18")]
				public CustomCalculationSourceData[] customCalculationSourceData;

				[Token(Token = "0x6000EB6")]
				public abstract object DeepClone();

				[Token(Token = "0x6000EB7")]
				[Address(RVA = "0x23AF9C0", Offset = "0x23AF9C0", VA = "0x23AF9C0")]
				protected void ImportVars(Element source)
				{
				}

				[Token(Token = "0x6000EB8")]
				[Address(RVA = "0x23AF9B8", Offset = "0x23AF9B8", VA = "0x23AF9B8")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001FA")]
			public abstract class Button_Base : Element
			{
				[Token(Token = "0x4000B3F")]
				[FieldOffset(Offset = "0x20")]
				public int elementIdentifier;

				[Token(Token = "0x4000B40")]
				[FieldOffset(Offset = "0x24")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000B41")]
				[FieldOffset(Offset = "0x28")]
				public int sourceButton;

				[Token(Token = "0x4000B42")]
				[FieldOffset(Offset = "0x2C")]
				public int sourceAxis;

				[Token(Token = "0x4000B43")]
				[FieldOffset(Offset = "0x30")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000B44")]
				[FieldOffset(Offset = "0x34")]
				public float axisDeadZone;

				[Token(Token = "0x4000B45")]
				[FieldOffset(Offset = "0x38")]
				public int sourceHat;

				[Token(Token = "0x4000B46")]
				[FieldOffset(Offset = "0x3C")]
				public HatType sourceHatType;

				[Token(Token = "0x4000B47")]
				[FieldOffset(Offset = "0x40")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000B48")]
				[FieldOffset(Offset = "0x44")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000B49")]
				[FieldOffset(Offset = "0x48")]
				public int[] requiredButtons;

				[Token(Token = "0x4000B4A")]
				[FieldOffset(Offset = "0x50")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000B4B")]
				[FieldOffset(Offset = "0x58")]
				public int[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000B4C")]
				[FieldOffset(Offset = "0x60")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x6000EB9")]
				[Address(RVA = "0x23A697C", Offset = "0x23A697C", VA = "0x23A697C")]
				public Button_Base()
				{
				}

				[Token(Token = "0x6000EBA")]
				[Address(RVA = "0x23A6A24", Offset = "0x23A6A24", VA = "0x23A6A24")]
				protected void ImportVars(Button_Base source)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001FB")]
			public abstract class Axis_Base : Element
			{
				[Token(Token = "0x4000B4D")]
				[FieldOffset(Offset = "0x20")]
				public int elementIdentifier;

				[Token(Token = "0x4000B4E")]
				[FieldOffset(Offset = "0x24")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000B4F")]
				[FieldOffset(Offset = "0x28")]
				public int sourceAxis;

				[Token(Token = "0x4000B50")]
				[FieldOffset(Offset = "0x2C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000B51")]
				[FieldOffset(Offset = "0x30")]
				public bool invert;

				[Token(Token = "0x4000B52")]
				[FieldOffset(Offset = "0x34")]
				public float axisDeadZone;

				[Token(Token = "0x4000B53")]
				[FieldOffset(Offset = "0x38")]
				public bool calibrateAxis;

				[Token(Token = "0x4000B54")]
				[FieldOffset(Offset = "0x3C")]
				public float axisZero;

				[Token(Token = "0x4000B55")]
				[FieldOffset(Offset = "0x40")]
				public float axisMin;

				[Token(Token = "0x4000B56")]
				[FieldOffset(Offset = "0x44")]
				public float axisMax;

				[Token(Token = "0x4000B57")]
				[FieldOffset(Offset = "0x48")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x4000B58")]
				[FieldOffset(Offset = "0x50")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000B59")]
				[FieldOffset(Offset = "0x58")]
				public int sourceButton;

				[Token(Token = "0x4000B5A")]
				[FieldOffset(Offset = "0x5C")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000B5B")]
				[FieldOffset(Offset = "0x60")]
				public int sourceHat;

				[Token(Token = "0x4000B5C")]
				[FieldOffset(Offset = "0x64")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000B5D")]
				[FieldOffset(Offset = "0x68")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x6000EBB")]
				[Address(RVA = "0x23A6744", Offset = "0x23A6744", VA = "0x23A6744")]
				public Axis_Base()
				{
				}

				[Token(Token = "0x6000EBC")]
				[Address(RVA = "0x23A67F4", Offset = "0x23A67F4", VA = "0x23A67F4")]
				protected void ImportVars(Axis_Base source)
				{
				}
			}

			[Token(Token = "0x20001FC")]
			public enum DeviceType
			{
				[Token(Token = "0x4000B5F")]
				Any = 0,
				[Token(Token = "0x4000B60")]
				Device = 17,
				[Token(Token = "0x4000B61")]
				Mouse = 18,
				[Token(Token = "0x4000B62")]
				Keyboard = 19,
				[Token(Token = "0x4000B63")]
				Joystick = 20,
				[Token(Token = "0x4000B64")]
				Gamepad = 21,
				[Token(Token = "0x4000B65")]
				Driving = 22,
				[Token(Token = "0x4000B66")]
				Flight = 23,
				[Token(Token = "0x4000B67")]
				FirstPerson = 24,
				[Token(Token = "0x4000B68")]
				ControlDevice = 25,
				[Token(Token = "0x4000B69")]
				ScreenPointer = 26,
				[Token(Token = "0x4000B6A")]
				Remote = 27,
				[Token(Token = "0x4000B6B")]
				Supplemental = 28
			}

			[Token(Token = "0x4000B29")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x170003F0")]
			internal override bool hasData
			{
				[Token(Token = "0x6000E9D")]
				[Address(RVA = "0x247D708", Offset = "0x247D708", VA = "0x247D708", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003F1")]
			internal override bool disabled
			{
				[Token(Token = "0x6000E9E")]
				[Address(RVA = "0x247D768", Offset = "0x247D768", VA = "0x247D768", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003F2")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6000E9F")]
				[Address(RVA = "0x247D77C", Offset = "0x247D77C", VA = "0x247D77C", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000EA0")]
			internal abstract IEnumerable<Axis_Base> IterateAxes();

			[Token(Token = "0x6000EA1")]
			internal abstract IEnumerable<Button_Base> IterateButtons();

			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0x246D0A8", Offset = "0x246D0A8", VA = "0x246D0A8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000EA3")]
			[Address(RVA = "0x246D194", Offset = "0x246D194", VA = "0x246D194")]
			protected Platform_RawOrDirectInput()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001FD")]
		public class Platform_DirectInput_Base : Platform_RawOrDirectInput
		{
			[Serializable]
			[Token(Token = "0x20001FE")]
			public sealed class Elements : Elements_Platform_Base
			{
				[Token(Token = "0x4000B6D")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000B6E")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x170003FC")]
				public override int buttonCount
				{
					[Token(Token = "0x6000ED0")]
					[Address(RVA = "0x23A6B7C", Offset = "0x23A6B7C", VA = "0x23A6B7C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170003FD")]
				public override int axisCount
				{
					[Token(Token = "0x6000ED1")]
					[Address(RVA = "0x23A6B94", Offset = "0x23A6B94", VA = "0x23A6B94", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000ED2")]
				[Address(RVA = "0x23A6BAC", Offset = "0x23A6BAC", VA = "0x23A6BAC", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6000ED3")]
				[Address(RVA = "0x23A6CD0", Offset = "0x23A6CD0", VA = "0x23A6CD0", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6000ED4")]
				[Address(RVA = "0x23A6E20", Offset = "0x23A6E20", VA = "0x23A6E20", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000ED5")]
				[Address(RVA = "0x23A6EA0", Offset = "0x23A6EA0", VA = "0x23A6EA0", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6000ED6")]
				[Address(RVA = "0x23A6E98", Offset = "0x23A6E98", VA = "0x23A6E98")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x20001FF")]
			public sealed class Button : Button_Base
			{
				[Token(Token = "0x6000ED7")]
				[Address(RVA = "0x23A6954", Offset = "0x23A6954", VA = "0x23A6954")]
				public Button()
				{
				}

				[Token(Token = "0x6000ED8")]
				[Address(RVA = "0x23A69A4", Offset = "0x23A69A4", VA = "0x23A69A4", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000ED9")]
				[Address(RVA = "0x23A6A20", Offset = "0x23A6A20", VA = "0x23A6A20")]
				private void ImportVars(Button source)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000200")]
			public sealed class Axis : Axis_Base
			{
				[Token(Token = "0x6000EDA")]
				[Address(RVA = "0x23A6718", Offset = "0x23A6718", VA = "0x23A6718")]
				public Axis()
				{
				}

				[Token(Token = "0x6000EDB")]
				[Address(RVA = "0x23A6770", Offset = "0x23A6770", VA = "0x23A6770", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000EDC")]
				[Address(RVA = "0x23A67F0", Offset = "0x23A67F0", VA = "0x23A67F0")]
				private void ImportVars(Axis source)
				{
				}
			}

			[Token(Token = "0x2000201")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19171C", Offset = "0x19171C")]
			private sealed class OtkgYdnevOIyjSvXCFVneVmFQTeG : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis_Base>, IEnumerator<Axis_Base>
			{
				[Token(Token = "0x4000B6F")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000B70")]
				[FieldOffset(Offset = "0x18")]
				private Axis_Base VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000B71")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000B72")]
				[FieldOffset(Offset = "0x28")]
				public Platform_DirectInput_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000B73")]
				[FieldOffset(Offset = "0x30")]
				private int yGVazBNUxMSdXREcmvzWGmvkBjWk;

				[Token(Token = "0x4000B74")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x170003FE")]
				private Axis_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002ECurrent
				{
					[Token(Token = "0x6000EE0")]
					[Address(RVA = "0x23A7078", Offset = "0x23A7078", VA = "0x23A7078", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170003FF")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000EE2")]
					[Address(RVA = "0x23A70C0", Offset = "0x23A70C0", VA = "0x23A70C0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000EDD")]
				[Address(RVA = "0x23A6F68", Offset = "0x23A6F68", VA = "0x23A6F68")]
				[DebuggerHidden]
				public OtkgYdnevOIyjSvXCFVneVmFQTeG(int P_0)
				{
				}

				[Token(Token = "0x6000EDE")]
				[Address(RVA = "0x23A6FB0", Offset = "0x23A6FB0", VA = "0x23A6FB0", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000EDF")]
				[Address(RVA = "0x23A6FB4", Offset = "0x23A6FB4", VA = "0x23A6FB4", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000EE0")]
				[Address(RVA = "0x23A7078", Offset = "0x23A7078", VA = "0x23A7078", Slot = "10")]
				[DebuggerHidden]
				private Axis_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000EE1")]
				[Address(RVA = "0x23A7080", Offset = "0x23A7080", VA = "0x23A7080", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000EE2")]
				[Address(RVA = "0x23A70C0", Offset = "0x23A70C0", VA = "0x23A70C0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000EE3")]
				[Address(RVA = "0x23A70C8", Offset = "0x23A70C8", VA = "0x23A70C8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis_Base> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000EE4")]
				[Address(RVA = "0x23A7188", Offset = "0x23A7188", VA = "0x23A7188", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000202")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19172C", Offset = "0x19172C")]
			private sealed class gwcteUxDgiwHjqftdavcAdzhOPQC : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button_Base>, IEnumerator<Button_Base>
			{
				[Token(Token = "0x4000B75")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000B76")]
				[FieldOffset(Offset = "0x18")]
				private Button_Base VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000B77")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000B78")]
				[FieldOffset(Offset = "0x28")]
				public Platform_DirectInput_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000B79")]
				[FieldOffset(Offset = "0x30")]
				private int pMgPWWjomCBqioCeCujXqJRwsmRk;

				[Token(Token = "0x4000B7A")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000400")]
				private Button_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002ECurrent
				{
					[Token(Token = "0x6000EE8")]
					[Address(RVA = "0x23A729C", Offset = "0x23A729C", VA = "0x23A729C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000401")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000EEA")]
					[Address(RVA = "0x23A72E4", Offset = "0x23A72E4", VA = "0x23A72E4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000EE5")]
				[Address(RVA = "0x23A718C", Offset = "0x23A718C", VA = "0x23A718C")]
				[DebuggerHidden]
				public gwcteUxDgiwHjqftdavcAdzhOPQC(int P_0)
				{
				}

				[Token(Token = "0x6000EE6")]
				[Address(RVA = "0x23A71D4", Offset = "0x23A71D4", VA = "0x23A71D4", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000EE7")]
				[Address(RVA = "0x23A71D8", Offset = "0x23A71D8", VA = "0x23A71D8", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000EE8")]
				[Address(RVA = "0x23A729C", Offset = "0x23A729C", VA = "0x23A729C", Slot = "10")]
				[DebuggerHidden]
				private Button_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000EE9")]
				[Address(RVA = "0x23A72A4", Offset = "0x23A72A4", VA = "0x23A72A4", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000EEA")]
				[Address(RVA = "0x23A72E4", Offset = "0x23A72E4", VA = "0x23A72E4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000EEB")]
				[Address(RVA = "0x23A72EC", Offset = "0x23A72EC", VA = "0x23A72EC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button_Base> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000EEC")]
				[Address(RVA = "0x23A73AC", Offset = "0x23A73AC", VA = "0x23A73AC", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000B6C")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x170003F6")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6000EBD")]
				[Address(RVA = "0x246B9C8", Offset = "0x246B9C8", VA = "0x246B9C8", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003F7")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6000EBE")]
				[Address(RVA = "0x246B9D0", Offset = "0x246B9D0", VA = "0x246B9D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003F8")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6000EBF")]
				[Address(RVA = "0x246B9E8", Offset = "0x246B9E8", VA = "0x246B9E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003F9")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000EC0")]
				[Address(RVA = "0x246BA00", Offset = "0x246BA00", VA = "0x246BA00", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003FA")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6000EC1")]
				[Address(RVA = "0x246BA08", Offset = "0x246BA08", VA = "0x246BA08", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170003FB")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6000EC2")]
				[Address(RVA = "0x246BA20", Offset = "0x246BA20", VA = "0x246BA20", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000EC3")]
			[Address(RVA = "0x246B728", Offset = "0x246B728", VA = "0x246B728", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000EC4")]
			[Address(RVA = "0x246BA38", Offset = "0x246BA38", VA = "0x246BA38", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x246C0BC", Offset = "0x246C0BC", VA = "0x246C0BC", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6000EC6")]
			[Address(RVA = "0x246C7C8", Offset = "0x246C7C8", VA = "0x246C7C8", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x246CA28", Offset = "0x246CA28", VA = "0x246CA28", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x246CD78", Offset = "0x246CD78", VA = "0x246CD78", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x246CF10", Offset = "0x246CF10", VA = "0x246CF10", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x246CF28", Offset = "0x246CF28", VA = "0x246CF28", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0x246CF44", Offset = "0x246CF44", VA = "0x246CF44", Slot = "23")]
			internal override IEnumerable<Axis_Base> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0x246CFB8", Offset = "0x246CFB8", VA = "0x246CFB8", Slot = "24")]
			internal override IEnumerable<Button_Base> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x246D02C", Offset = "0x246D02C", VA = "0x246D02C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x246B8C8", Offset = "0x246B8C8", VA = "0x246B8C8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000ECF")]
			[Address(RVA = "0x246B9C0", Offset = "0x246B9C0", VA = "0x246B9C0")]
			public Platform_DirectInput_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000203")]
		public sealed class Platform_DirectInput : Platform_DirectInput_Base
		{
			[Token(Token = "0x4000B7B")]
			[FieldOffset(Offset = "0x28")]
			public Platform_DirectInput_Base[] variants;

			[Token(Token = "0x17000402")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000EED")]
				[Address(RVA = "0x246B614", Offset = "0x246B614", VA = "0x246B614", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0x246B61C", Offset = "0x246B61C", VA = "0x246B61C", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x246B774", Offset = "0x246B774", VA = "0x246B774", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000EF0")]
			[Address(RVA = "0x246B7F8", Offset = "0x246B7F8", VA = "0x246B7F8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000EF1")]
			[Address(RVA = "0x246B7F0", Offset = "0x246B7F0", VA = "0x246B7F0")]
			public Platform_DirectInput()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000204")]
		public class Platform_RawInput_Base : Platform_RawOrDirectInput
		{
			[Serializable]
			[Token(Token = "0x2000205")]
			public sealed class Elements : Elements_Platform_Base
			{
				[Token(Token = "0x4000B7D")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000B7E")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000409")]
				public override int buttonCount
				{
					[Token(Token = "0x6000F05")]
					[Address(RVA = "0x23AF180", Offset = "0x23AF180", VA = "0x23AF180", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700040A")]
				public override int axisCount
				{
					[Token(Token = "0x6000F06")]
					[Address(RVA = "0x23AF198", Offset = "0x23AF198", VA = "0x23AF198", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000F07")]
				[Address(RVA = "0x23AF1B0", Offset = "0x23AF1B0", VA = "0x23AF1B0", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6000F08")]
				[Address(RVA = "0x23AF2D4", Offset = "0x23AF2D4", VA = "0x23AF2D4", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6000F09")]
				[Address(RVA = "0x23AF430", Offset = "0x23AF430", VA = "0x23AF430", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F0A")]
				[Address(RVA = "0x23AF4B0", Offset = "0x23AF4B0", VA = "0x23AF4B0", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6000F0B")]
				[Address(RVA = "0x23AF4A8", Offset = "0x23AF4A8", VA = "0x23AF4A8")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000206")]
			public sealed class Button : Button_Base
			{
				[Token(Token = "0x4000B7F")]
				[FieldOffset(Offset = "0x68")]
				public int sourceOtherAxis;

				[Token(Token = "0x6000F0C")]
				[Address(RVA = "0x23AF09C", Offset = "0x23AF09C", VA = "0x23AF09C")]
				public Button()
				{
				}

				[Token(Token = "0x6000F0D")]
				[Address(RVA = "0x23AF0C4", Offset = "0x23AF0C4", VA = "0x23AF0C4", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F0E")]
				[Address(RVA = "0x23AF14C", Offset = "0x23AF14C", VA = "0x23AF14C")]
				private void ImportVars(Button source)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000207")]
			public sealed class Axis : Axis_Base
			{
				[Token(Token = "0x4000B80")]
				[FieldOffset(Offset = "0x6C")]
				public int sourceOtherAxis;

				[Token(Token = "0x6000F0F")]
				[Address(RVA = "0x23AEFB0", Offset = "0x23AEFB0", VA = "0x23AEFB0")]
				public Axis()
				{
				}

				[Token(Token = "0x6000F10")]
				[Address(RVA = "0x23AEFDC", Offset = "0x23AEFDC", VA = "0x23AEFDC", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F11")]
				[Address(RVA = "0x23AF068", Offset = "0x23AF068", VA = "0x23AF068")]
				private void ImportVars(Axis source)
				{
				}
			}

			[Token(Token = "0x2000208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19173C", Offset = "0x19173C")]
			private sealed class dgfJMcInDRSrAMCeSEcjccbZQTrqA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis_Base>, IEnumerator<Axis_Base>
			{
				[Token(Token = "0x4000B81")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000B82")]
				[FieldOffset(Offset = "0x18")]
				private Axis_Base VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000B83")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000B84")]
				[FieldOffset(Offset = "0x28")]
				public Platform_RawInput_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000B85")]
				[FieldOffset(Offset = "0x30")]
				private int yGVazBNUxMSdXREcmvzWGmvkBjWk;

				[Token(Token = "0x4000B86")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x1700040B")]
				private Axis_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002ECurrent
				{
					[Token(Token = "0x6000F15")]
					[Address(RVA = "0x23AF8A4", Offset = "0x23AF8A4", VA = "0x23AF8A4", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700040C")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000F17")]
					[Address(RVA = "0x23AF8EC", Offset = "0x23AF8EC", VA = "0x23AF8EC", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000F12")]
				[Address(RVA = "0x23AF794", Offset = "0x23AF794", VA = "0x23AF794")]
				[DebuggerHidden]
				public dgfJMcInDRSrAMCeSEcjccbZQTrqA(int P_0)
				{
				}

				[Token(Token = "0x6000F13")]
				[Address(RVA = "0x23AF7DC", Offset = "0x23AF7DC", VA = "0x23AF7DC", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000F14")]
				[Address(RVA = "0x23AF7E0", Offset = "0x23AF7E0", VA = "0x23AF7E0", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000F15")]
				[Address(RVA = "0x23AF8A4", Offset = "0x23AF8A4", VA = "0x23AF8A4", Slot = "10")]
				[DebuggerHidden]
				private Axis_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F16")]
				[Address(RVA = "0x23AF8AC", Offset = "0x23AF8AC", VA = "0x23AF8AC", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000F17")]
				[Address(RVA = "0x23AF8EC", Offset = "0x23AF8EC", VA = "0x23AF8EC", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F18")]
				[Address(RVA = "0x23AF8F4", Offset = "0x23AF8F4", VA = "0x23AF8F4", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis_Base> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EAxis_Base_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000F19")]
				[Address(RVA = "0x23AF9B4", Offset = "0x23AF9B4", VA = "0x23AF9B4", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000209")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19174C", Offset = "0x19174C")]
			private sealed class FfBwllDobVKzCdYSCnyYokRRlkNx : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button_Base>, IEnumerator<Button_Base>
			{
				[Token(Token = "0x4000B87")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000B88")]
				[FieldOffset(Offset = "0x18")]
				private Button_Base VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000B89")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000B8A")]
				[FieldOffset(Offset = "0x28")]
				public Platform_RawInput_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000B8B")]
				[FieldOffset(Offset = "0x30")]
				private int pMgPWWjomCBqioCeCujXqJRwsmRk;

				[Token(Token = "0x4000B8C")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x1700040D")]
				private Button_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002ECurrent
				{
					[Token(Token = "0x6000F1D")]
					[Address(RVA = "0x23AF680", Offset = "0x23AF680", VA = "0x23AF680", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700040E")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000F1F")]
					[Address(RVA = "0x23AF6C8", Offset = "0x23AF6C8", VA = "0x23AF6C8", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000F1A")]
				[Address(RVA = "0x23AF570", Offset = "0x23AF570", VA = "0x23AF570")]
				[DebuggerHidden]
				public FfBwllDobVKzCdYSCnyYokRRlkNx(int P_0)
				{
				}

				[Token(Token = "0x6000F1B")]
				[Address(RVA = "0x23AF5B8", Offset = "0x23AF5B8", VA = "0x23AF5B8", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000F1C")]
				[Address(RVA = "0x23AF5BC", Offset = "0x23AF5BC", VA = "0x23AF5BC", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000F1D")]
				[Address(RVA = "0x23AF680", Offset = "0x23AF680", VA = "0x23AF680", Slot = "10")]
				[DebuggerHidden]
				private Button_Base System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F1E")]
				[Address(RVA = "0x23AF688", Offset = "0x23AF688", VA = "0x23AF688", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000F1F")]
				[Address(RVA = "0x23AF6C8", Offset = "0x23AF6C8", VA = "0x23AF6C8", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F20")]
				[Address(RVA = "0x23AF6D0", Offset = "0x23AF6D0", VA = "0x23AF6D0", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button_Base> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_RawOrDirectInput_002EButton_Base_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000F21")]
				[Address(RVA = "0x23AF790", Offset = "0x23AF790", VA = "0x23AF790", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000B7C")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x17000403")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6000EF2")]
				[Address(RVA = "0x247C028", Offset = "0x247C028", VA = "0x247C028", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000404")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6000EF3")]
				[Address(RVA = "0x247C030", Offset = "0x247C030", VA = "0x247C030")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000405")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6000EF4")]
				[Address(RVA = "0x247C048", Offset = "0x247C048", VA = "0x247C048")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000406")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000EF5")]
				[Address(RVA = "0x247C060", Offset = "0x247C060", VA = "0x247C060", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000407")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6000EF6")]
				[Address(RVA = "0x247C068", Offset = "0x247C068", VA = "0x247C068", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000408")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6000EF7")]
				[Address(RVA = "0x247C080", Offset = "0x247C080", VA = "0x247C080", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x247BD88", Offset = "0x247BD88", VA = "0x247BD88", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x247C098", Offset = "0x247C098", VA = "0x247C098", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x247C71C", Offset = "0x247C71C", VA = "0x247C71C", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x247CE28", Offset = "0x247CE28", VA = "0x247CE28", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x247D088", Offset = "0x247D088", VA = "0x247D088", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0x247D3D8", Offset = "0x247D3D8", VA = "0x247D3D8", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6000EFE")]
			[Address(RVA = "0x247D570", Offset = "0x247D570", VA = "0x247D570", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6000EFF")]
			[Address(RVA = "0x247D588", Offset = "0x247D588", VA = "0x247D588", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x247D5A4", Offset = "0x247D5A4", VA = "0x247D5A4", Slot = "23")]
			internal override IEnumerable<Axis_Base> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6000F01")]
			[Address(RVA = "0x247D618", Offset = "0x247D618", VA = "0x247D618", Slot = "24")]
			internal override IEnumerable<Button_Base> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6000F02")]
			[Address(RVA = "0x247D68C", Offset = "0x247D68C", VA = "0x247D68C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000F03")]
			[Address(RVA = "0x247BF28", Offset = "0x247BF28", VA = "0x247BF28", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000F04")]
			[Address(RVA = "0x247C020", Offset = "0x247C020", VA = "0x247C020")]
			public Platform_RawInput_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200020A")]
		public sealed class Platform_RawInput : Platform_RawInput_Base
		{
			[Token(Token = "0x4000B8D")]
			[FieldOffset(Offset = "0x28")]
			public Platform_RawInput_Base[] variants;

			[Token(Token = "0x1700040F")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000F22")]
				[Address(RVA = "0x247BC74", Offset = "0x247BC74", VA = "0x247BC74", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x247BC7C", Offset = "0x247BC7C", VA = "0x247BC7C", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x247BDD4", Offset = "0x247BDD4", VA = "0x247BDD4", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x247BE58", Offset = "0x247BE58", VA = "0x247BE58", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000F26")]
			[Address(RVA = "0x247BE50", Offset = "0x247BE50", VA = "0x247BE50")]
			public Platform_RawInput()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200020B")]
		public class Platform_XInput_Base : Platform
		{
			[Serializable]
			[Token(Token = "0x200020C")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Token(Token = "0x4000B90")]
				[FieldOffset(Offset = "0x28")]
				public XInputDeviceSubType[] subType;

				[Token(Token = "0x17000419")]
				internal override bool hasData
				{
					[Token(Token = "0x6000F3D")]
					[Address(RVA = "0x23B4D90", Offset = "0x23B4D90", VA = "0x23B4D90", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700041A")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6000F3E")]
					[Address(RVA = "0x23B4DC4", Offset = "0x23B4DC4", VA = "0x23B4DC4", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700041B")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6000F40")]
					[Address(RVA = "0x23B4EA4", Offset = "0x23B4EA4", VA = "0x23B4EA4", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000F3F")]
				[Address(RVA = "0x23B4DCC", Offset = "0x23B4DCC", VA = "0x23B4DCC", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6000F41")]
				[Address(RVA = "0x23B4EAC", Offset = "0x23B4EAC", VA = "0x23B4EAC", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6000F42")]
				[Address(RVA = "0x23B4EB4", Offset = "0x23B4EB4", VA = "0x23B4EB4", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6000F43")]
				[Address(RVA = "0x23B4EBC", Offset = "0x23B4EBC", VA = "0x23B4EBC", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F44")]
				[Address(RVA = "0x23B4F3C", Offset = "0x23B4F3C", VA = "0x23B4F3C", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6000F45")]
				[Address(RVA = "0x23B4F34", Offset = "0x23B4F34", VA = "0x23B4F34")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200020D")]
			public sealed class Elements : Elements_Base
			{
				[Token(Token = "0x4000B91")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000B92")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x1700041C")]
				public override int buttonCount
				{
					[Token(Token = "0x6000F46")]
					[Address(RVA = "0x23B49C8", Offset = "0x23B49C8", VA = "0x23B49C8", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700041D")]
				public override int axisCount
				{
					[Token(Token = "0x6000F47")]
					[Address(RVA = "0x23B49E0", Offset = "0x23B49E0", VA = "0x23B49E0", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000F48")]
				[Address(RVA = "0x23B49F8", Offset = "0x23B49F8", VA = "0x23B49F8", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F49")]
				[Address(RVA = "0x23B4A78", Offset = "0x23B4A78", VA = "0x23B4A78", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6000F4A")]
				[Address(RVA = "0x23B4B38", Offset = "0x23B4B38", VA = "0x23B4B38", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6000F4B")]
				[Address(RVA = "0x23B4C5C", Offset = "0x23B4C5C", VA = "0x23B4C5C", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6000F4C")]
				[Address(RVA = "0x23B4A70", Offset = "0x23B4A70", VA = "0x23B4A70")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200020E")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x4000B93")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000B94")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceType sourceType;

				[Token(Token = "0x4000B95")]
				[FieldOffset(Offset = "0x18")]
				public XInputButton sourceButton;

				[Token(Token = "0x4000B96")]
				[FieldOffset(Offset = "0x1C")]
				public XInputAxis sourceAxis;

				[Token(Token = "0x4000B97")]
				[FieldOffset(Offset = "0x20")]
				public float axisDeadZone;

				[Token(Token = "0x6000F4D")]
				public abstract object DeepClone();

				[Token(Token = "0x6000F4E")]
				[Address(RVA = "0x23B4824", Offset = "0x23B4824", VA = "0x23B4824", Slot = "6")]
				internal virtual void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6000F4F")]
				[Address(RVA = "0x23B467C", Offset = "0x23B467C", VA = "0x23B467C")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200020F")]
			public sealed class Button : Element
			{
				[Token(Token = "0x4000B98")]
				[FieldOffset(Offset = "0x24")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000B99")]
				[FieldOffset(Offset = "0x28")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x6000F50")]
				[Address(RVA = "0x23B4848", Offset = "0x23B4848", VA = "0x23B4848")]
				public Button()
				{
				}

				[Token(Token = "0x6000F51")]
				[Address(RVA = "0x23B4870", Offset = "0x23B4870", VA = "0x23B4870", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F52")]
				[Address(RVA = "0x23B48EC", Offset = "0x23B48EC", VA = "0x23B48EC", Slot = "6")]
				internal override void CopyVars(Element destination)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000210")]
			public sealed class Axis : Element
			{
				[Token(Token = "0x4000B9A")]
				[FieldOffset(Offset = "0x24")]
				public bool invert;

				[Token(Token = "0x4000B9B")]
				[FieldOffset(Offset = "0x28")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000B9C")]
				[FieldOffset(Offset = "0x2C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000B9D")]
				[FieldOffset(Offset = "0x30")]
				public bool calibrateAxis;

				[Token(Token = "0x4000B9E")]
				[FieldOffset(Offset = "0x34")]
				public float axisZero;

				[Token(Token = "0x4000B9F")]
				[FieldOffset(Offset = "0x38")]
				public float axisMin;

				[Token(Token = "0x4000BA0")]
				[FieldOffset(Offset = "0x3C")]
				public float axisMax;

				[Token(Token = "0x4000BA1")]
				[FieldOffset(Offset = "0x40")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000BA2")]
				[FieldOffset(Offset = "0x48")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x6000F53")]
				[Address(RVA = "0x23B4650", Offset = "0x23B4650", VA = "0x23B4650")]
				public Axis()
				{
				}

				[Token(Token = "0x6000F54")]
				[Address(RVA = "0x23B4684", Offset = "0x23B4684", VA = "0x23B4684", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F55")]
				[Address(RVA = "0x23B4704", Offset = "0x23B4704", VA = "0x23B4704", Slot = "6")]
				internal override void CopyVars(Element destination)
				{
				}
			}

			[Token(Token = "0x2000211")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19175C", Offset = "0x19175C")]
			private sealed class qezuWMqAIzeIzJPPDuucliRPnSGBA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				[Token(Token = "0x4000BA3")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000BA4")]
				[FieldOffset(Offset = "0x18")]
				private Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000BA5")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000BA6")]
				[FieldOffset(Offset = "0x28")]
				public Platform_XInput_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000BA7")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x1700041E")]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6000F59")]
					[Address(RVA = "0x23B50E0", Offset = "0x23B50E0", VA = "0x23B50E0", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700041F")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000F5B")]
					[Address(RVA = "0x23B5128", Offset = "0x23B5128", VA = "0x23B5128", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000F56")]
				[Address(RVA = "0x23B4FD8", Offset = "0x23B4FD8", VA = "0x23B4FD8")]
				[DebuggerHidden]
				public qezuWMqAIzeIzJPPDuucliRPnSGBA(int P_0)
				{
				}

				[Token(Token = "0x6000F57")]
				[Address(RVA = "0x23B5020", Offset = "0x23B5020", VA = "0x23B5020", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000F58")]
				[Address(RVA = "0x23B5024", Offset = "0x23B5024", VA = "0x23B5024", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000F59")]
				[Address(RVA = "0x23B50E0", Offset = "0x23B50E0", VA = "0x23B50E0", Slot = "10")]
				[DebuggerHidden]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F5A")]
				[Address(RVA = "0x23B50E8", Offset = "0x23B50E8", VA = "0x23B50E8", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000F5B")]
				[Address(RVA = "0x23B5128", Offset = "0x23B5128", VA = "0x23B5128", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F5C")]
				[Address(RVA = "0x23B5130", Offset = "0x23B5130", VA = "0x23B5130", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000F5D")]
				[Address(RVA = "0x23B51F0", Offset = "0x23B51F0", VA = "0x23B51F0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000212")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19176C", Offset = "0x19176C")]
			private sealed class yiCyuHTCWeZPGGfqwSpWfmmToKT : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				[Token(Token = "0x4000BA8")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000BA9")]
				[FieldOffset(Offset = "0x18")]
				private Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000BAA")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000BAB")]
				[FieldOffset(Offset = "0x28")]
				public Platform_XInput_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000BAC")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000420")]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6000F61")]
					[Address(RVA = "0x23B52FC", Offset = "0x23B52FC", VA = "0x23B52FC", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000421")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000F63")]
					[Address(RVA = "0x23B5344", Offset = "0x23B5344", VA = "0x23B5344", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000F5E")]
				[Address(RVA = "0x23B51F4", Offset = "0x23B51F4", VA = "0x23B51F4")]
				[DebuggerHidden]
				public yiCyuHTCWeZPGGfqwSpWfmmToKT(int P_0)
				{
				}

				[Token(Token = "0x6000F5F")]
				[Address(RVA = "0x23B523C", Offset = "0x23B523C", VA = "0x23B523C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000F60")]
				[Address(RVA = "0x23B5240", Offset = "0x23B5240", VA = "0x23B5240", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000F61")]
				[Address(RVA = "0x23B52FC", Offset = "0x23B52FC", VA = "0x23B52FC", Slot = "10")]
				[DebuggerHidden]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F62")]
				[Address(RVA = "0x23B5304", Offset = "0x23B5304", VA = "0x23B5304", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000F63")]
				[Address(RVA = "0x23B5344", Offset = "0x23B5344", VA = "0x23B5344", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000F64")]
				[Address(RVA = "0x23B534C", Offset = "0x23B534C", VA = "0x23B534C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_XInput_Base_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000F65")]
				[Address(RVA = "0x23B540C", Offset = "0x23B540C", VA = "0x23B540C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000B8E")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000B8F")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x17000410")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6000F27")]
				[Address(RVA = "0x2484CF0", Offset = "0x2484CF0", VA = "0x2484CF0", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000411")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6000F28")]
				[Address(RVA = "0x2484D08", Offset = "0x2484D08", VA = "0x2484D08", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000412")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6000F29")]
				[Address(RVA = "0x2484D20", Offset = "0x2484D20", VA = "0x2484D20", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000413")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6000F2A")]
				[Address(RVA = "0x2484D28", Offset = "0x2484D28", VA = "0x2484D28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000414")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6000F2B")]
				[Address(RVA = "0x2484D40", Offset = "0x2484D40", VA = "0x2484D40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000415")]
			internal override bool hasData
			{
				[Token(Token = "0x6000F2C")]
				[Address(RVA = "0x2484D58", Offset = "0x2484D58", VA = "0x2484D58", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000416")]
			internal override bool disabled
			{
				[Token(Token = "0x6000F2D")]
				[Address(RVA = "0x2484DB8", Offset = "0x2484DB8", VA = "0x2484DB8", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000417")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6000F2E")]
				[Address(RVA = "0x2484DCC", Offset = "0x2484DCC", VA = "0x2484DCC", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000418")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000F2F")]
				[Address(RVA = "0x2484E14", Offset = "0x2484E14", VA = "0x2484E14", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x2484A30", Offset = "0x2484A30", VA = "0x2484A30", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x2484E1C", Offset = "0x2484E1C", VA = "0x2484E1C")]
			internal IEnumerable<Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6000F32")]
			[Address(RVA = "0x2484E90", Offset = "0x2484E90", VA = "0x2484E90")]
			internal IEnumerable<Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x2484F04", Offset = "0x2484F04", VA = "0x2484F04", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x2485588", Offset = "0x2485588", VA = "0x2485588", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x2485C64", Offset = "0x2485C64", VA = "0x2485C64", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6000F36")]
			[Address(RVA = "0x2485EB0", Offset = "0x2485EB0", VA = "0x2485EB0", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x24861C4", Offset = "0x24861C4", VA = "0x24861C4", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x248635C", Offset = "0x248635C", VA = "0x248635C", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x2486374", Offset = "0x2486374", VA = "0x2486374", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6000F3A")]
			[Address(RVA = "0x2486390", Offset = "0x2486390", VA = "0x2486390", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x2484BD0", Offset = "0x2484BD0", VA = "0x2484BD0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x2484CE8", Offset = "0x2484CE8", VA = "0x2484CE8")]
			public Platform_XInput_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000213")]
		public sealed class Platform_XInput : Platform_XInput_Base
		{
			[Token(Token = "0x4000BAD")]
			[FieldOffset(Offset = "0x28")]
			public Platform_XInput_Base[] variants;

			[Token(Token = "0x17000422")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000F66")]
				[Address(RVA = "0x248491C", Offset = "0x248491C", VA = "0x248491C", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x2484924", Offset = "0x2484924", VA = "0x2484924", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x2484A7C", Offset = "0x2484A7C", VA = "0x2484A7C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x2484B00", Offset = "0x2484B00", VA = "0x2484B00", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000F6A")]
			[Address(RVA = "0x2484AF8", Offset = "0x2484AF8", VA = "0x2484AF8")]
			public Platform_XInput()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000214")]
		public class Platform_OSX_Base : Platform
		{
			[Serializable]
			[Token(Token = "0x2000215")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Serializable]
				[Token(Token = "0x2000216")]
				public sealed class ElementCount : ElementCount_Base
				{
					[Token(Token = "0x4000BB7")]
					[FieldOffset(Offset = "0x18")]
					public int hatCount;

					[Token(Token = "0x6000F8B")]
					[Address(RVA = "0x23C2BF8", Offset = "0x23C2BF8", VA = "0x23C2BF8")]
					public ElementCount()
					{
					}

					[Token(Token = "0x6000F8C")]
					[Address(RVA = "0x23C2C00", Offset = "0x23C2C00", VA = "0x23C2C00", Slot = "5")]
					public override object DeepClone()
					{
						return null;
					}

					[Token(Token = "0x6000F8D")]
					[Address(RVA = "0x23C2C78", Offset = "0x23C2C78", VA = "0x23C2C78", Slot = "6")]
					internal override void KGvHNOSFSLcIoKIKCrVnqZaTvqVy(ElementCount_Base P_0)
					{
					}

					[Token(Token = "0x6000F8E")]
					[Address(RVA = "0x23C2D04", Offset = "0x23C2D04", VA = "0x23C2D04", Slot = "7")]
					internal override bool dRTWaRkWIkEMLraxMRHrbdGkCqGCA(BridgedControllerHWInfo P_0)
					{
						return default;
					}
				}

				[Token(Token = "0x4000BB0")]
				[FieldOffset(Offset = "0x28")]
				public int hatCount;

				[Token(Token = "0x4000BB1")]
				[FieldOffset(Offset = "0x30")]
				public ElementCount[] alternateElementCounts;

				[Token(Token = "0x4000BB2")]
				[FieldOffset(Offset = "0x38")]
				public bool productName_useRegex;

				[Token(Token = "0x4000BB3")]
				[FieldOffset(Offset = "0x40")]
				public string[] productName;

				[Token(Token = "0x4000BB4")]
				[FieldOffset(Offset = "0x48")]
				public string[] manufacturer;

				[Token(Token = "0x4000BB5")]
				[FieldOffset(Offset = "0x50")]
				public int[] productId;

				[Token(Token = "0x4000BB6")]
				[FieldOffset(Offset = "0x58")]
				public int[] vendorId;

				[Token(Token = "0x1700042C")]
				internal override bool hasData
				{
					[Token(Token = "0x6000F81")]
					[Address(RVA = "0x23ACDDC", Offset = "0x23ACDDC", VA = "0x23ACDDC", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700042D")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6000F82")]
					[Address(RVA = "0x23ACE2C", Offset = "0x23ACE2C", VA = "0x23ACE2C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700042E")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6000F84")]
					[Address(RVA = "0x23AD11C", Offset = "0x23AD11C", VA = "0x23AD11C", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000F83")]
				[Address(RVA = "0x23ACE34", Offset = "0x23ACE34", VA = "0x23ACE34", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6000F85")]
				[Address(RVA = "0x23AD134", Offset = "0x23AD134", VA = "0x23AD134", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6000F86")]
				[Address(RVA = "0x23AD180", Offset = "0x23AD180", VA = "0x23AD180", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6000F87")]
				[Address(RVA = "0x23AD040", Offset = "0x23AD040", VA = "0x23AD040")]
				private bool ProductNameMatches(string name)
				{
					return default;
				}

				[Token(Token = "0x6000F88")]
				[Address(RVA = "0x23AD1E4", Offset = "0x23AD1E4", VA = "0x23AD1E4", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F89")]
				[Address(RVA = "0x23AD264", Offset = "0x23AD264", VA = "0x23AD264", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6000F8A")]
				[Address(RVA = "0x23AD25C", Offset = "0x23AD25C", VA = "0x23AD25C")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000217")]
			public sealed class Elements : Elements_Base
			{
				[Token(Token = "0x4000BB8")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000BB9")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x1700042F")]
				public override int buttonCount
				{
					[Token(Token = "0x6000F8F")]
					[Address(RVA = "0x23AC7D0", Offset = "0x23AC7D0", VA = "0x23AC7D0", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000430")]
				public override int axisCount
				{
					[Token(Token = "0x6000F90")]
					[Address(RVA = "0x23AC7E8", Offset = "0x23AC7E8", VA = "0x23AC7E8", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000F91")]
				[Address(RVA = "0x23AC800", Offset = "0x23AC800", VA = "0x23AC800", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000F92")]
				[Address(RVA = "0x23AC880", Offset = "0x23AC880", VA = "0x23AC880", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6000F93")]
				[Address(RVA = "0x23AC940", Offset = "0x23AC940", VA = "0x23AC940", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6000F94")]
				[Address(RVA = "0x23ACA64", Offset = "0x23ACA64", VA = "0x23ACA64", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6000F95")]
				[Address(RVA = "0x23AC878", Offset = "0x23AC878", VA = "0x23AC878")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000218")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x6000F96")]
				public abstract object DeepClone();

				[Token(Token = "0x6000F97")]
				[Address(RVA = "0x23AC4EC", Offset = "0x23AC4EC", VA = "0x23AC4EC")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000219")]
			public sealed class Button : Element
			{
				[Token(Token = "0x4000BBA")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000BBB")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000BBC")]
				[FieldOffset(Offset = "0x18")]
				public int sourceButton;

				[Token(Token = "0x4000BBD")]
				[FieldOffset(Offset = "0x1C")]
				public int sourceStick;

				[Token(Token = "0x4000BBE")]
				[FieldOffset(Offset = "0x20")]
				public OSXAxis sourceAxis;

				[Token(Token = "0x4000BBF")]
				[FieldOffset(Offset = "0x24")]
				public int sourceOtherAxis;

				[Token(Token = "0x4000BC0")]
				[FieldOffset(Offset = "0x28")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000BC1")]
				[FieldOffset(Offset = "0x2C")]
				public float axisDeadZone;

				[Token(Token = "0x4000BC2")]
				[FieldOffset(Offset = "0x30")]
				public int sourceHat;

				[Token(Token = "0x4000BC3")]
				[FieldOffset(Offset = "0x34")]
				public HatType sourceHatType;

				[Token(Token = "0x4000BC4")]
				[FieldOffset(Offset = "0x38")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000BC5")]
				[FieldOffset(Offset = "0x3C")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000BC6")]
				[FieldOffset(Offset = "0x40")]
				public int[] requiredButtons;

				[Token(Token = "0x4000BC7")]
				[FieldOffset(Offset = "0x48")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000BC8")]
				[FieldOffset(Offset = "0x50")]
				public int[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000BC9")]
				[FieldOffset(Offset = "0x58")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x6000F98")]
				[Address(RVA = "0x23AC660", Offset = "0x23AC660", VA = "0x23AC660")]
				public Button()
				{
				}

				[Token(Token = "0x6000F99")]
				[Address(RVA = "0x23AC688", Offset = "0x23AC688", VA = "0x23AC688", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}
			}

			[Serializable]
			[Token(Token = "0x200021A")]
			public sealed class Axis : Element
			{
				[Token(Token = "0x4000BCA")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000BCB")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000BCC")]
				[FieldOffset(Offset = "0x18")]
				public int sourceStick;

				[Token(Token = "0x4000BCD")]
				[FieldOffset(Offset = "0x1C")]
				public OSXAxis sourceAxis;

				[Token(Token = "0x4000BCE")]
				[FieldOffset(Offset = "0x20")]
				public int sourceOtherAxis;

				[Token(Token = "0x4000BCF")]
				[FieldOffset(Offset = "0x24")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000BD0")]
				[FieldOffset(Offset = "0x28")]
				public bool invert;

				[Token(Token = "0x4000BD1")]
				[FieldOffset(Offset = "0x2C")]
				public float axisDeadZone;

				[Token(Token = "0x4000BD2")]
				[FieldOffset(Offset = "0x30")]
				public bool calibrateAxis;

				[Token(Token = "0x4000BD3")]
				[FieldOffset(Offset = "0x34")]
				public float axisZero;

				[Token(Token = "0x4000BD4")]
				[FieldOffset(Offset = "0x38")]
				public float axisMin;

				[Token(Token = "0x4000BD5")]
				[FieldOffset(Offset = "0x3C")]
				public float axisMax;

				[Token(Token = "0x4000BD6")]
				[FieldOffset(Offset = "0x40")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000BD7")]
				[FieldOffset(Offset = "0x48")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x4000BD8")]
				[FieldOffset(Offset = "0x50")]
				public int sourceButton;

				[Token(Token = "0x4000BD9")]
				[FieldOffset(Offset = "0x54")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000BDA")]
				[FieldOffset(Offset = "0x58")]
				public int sourceHat;

				[Token(Token = "0x4000BDB")]
				[FieldOffset(Offset = "0x5C")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000BDC")]
				[FieldOffset(Offset = "0x60")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x6000F9A")]
				[Address(RVA = "0x23AC4B0", Offset = "0x23AC4B0", VA = "0x23AC4B0")]
				public Axis()
				{
				}

				[Token(Token = "0x6000F9B")]
				[Address(RVA = "0x23AC4F4", Offset = "0x23AC4F4", VA = "0x23AC4F4", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}
			}

			[Token(Token = "0x200021B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19177C", Offset = "0x19177C")]
			private sealed class GzjwESQBgttRqVAwoebtDSmcdciU : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				[Token(Token = "0x4000BDD")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000BDE")]
				[FieldOffset(Offset = "0x18")]
				private Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000BDF")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000BE0")]
				[FieldOffset(Offset = "0x28")]
				public Platform_OSX_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000BE1")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000431")]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6000F9F")]
					[Address(RVA = "0x23ACCC8", Offset = "0x23ACCC8", VA = "0x23ACCC8", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000432")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000FA1")]
					[Address(RVA = "0x23ACD10", Offset = "0x23ACD10", VA = "0x23ACD10", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000F9C")]
				[Address(RVA = "0x23ACBC0", Offset = "0x23ACBC0", VA = "0x23ACBC0")]
				[DebuggerHidden]
				public GzjwESQBgttRqVAwoebtDSmcdciU(int P_0)
				{
				}

				[Token(Token = "0x6000F9D")]
				[Address(RVA = "0x23ACC08", Offset = "0x23ACC08", VA = "0x23ACC08", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000F9E")]
				[Address(RVA = "0x23ACC0C", Offset = "0x23ACC0C", VA = "0x23ACC0C", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000F9F")]
				[Address(RVA = "0x23ACCC8", Offset = "0x23ACCC8", VA = "0x23ACCC8", Slot = "10")]
				[DebuggerHidden]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FA0")]
				[Address(RVA = "0x23ACCD0", Offset = "0x23ACCD0", VA = "0x23ACCD0", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000FA1")]
				[Address(RVA = "0x23ACD10", Offset = "0x23ACD10", VA = "0x23ACD10", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FA2")]
				[Address(RVA = "0x23ACD18", Offset = "0x23ACD18", VA = "0x23ACD18", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000FA3")]
				[Address(RVA = "0x23ACDD8", Offset = "0x23ACDD8", VA = "0x23ACDD8", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x200021C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19178C", Offset = "0x19178C")]
			private sealed class phiiGzqjETtEpCCgrmZxiMeTwHDl : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				[Token(Token = "0x4000BE2")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000BE3")]
				[FieldOffset(Offset = "0x18")]
				private Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000BE4")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000BE5")]
				[FieldOffset(Offset = "0x28")]
				public Platform_OSX_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000BE6")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000433")]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6000FA7")]
					[Address(RVA = "0x23AD45C", Offset = "0x23AD45C", VA = "0x23AD45C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000434")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000FA9")]
					[Address(RVA = "0x23AD4A4", Offset = "0x23AD4A4", VA = "0x23AD4A4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000FA4")]
				[Address(RVA = "0x23AD354", Offset = "0x23AD354", VA = "0x23AD354")]
				[DebuggerHidden]
				public phiiGzqjETtEpCCgrmZxiMeTwHDl(int P_0)
				{
				}

				[Token(Token = "0x6000FA5")]
				[Address(RVA = "0x23AD39C", Offset = "0x23AD39C", VA = "0x23AD39C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000FA6")]
				[Address(RVA = "0x23AD3A0", Offset = "0x23AD3A0", VA = "0x23AD3A0", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000FA7")]
				[Address(RVA = "0x23AD45C", Offset = "0x23AD45C", VA = "0x23AD45C", Slot = "10")]
				[DebuggerHidden]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FA8")]
				[Address(RVA = "0x23AD464", Offset = "0x23AD464", VA = "0x23AD464", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000FA9")]
				[Address(RVA = "0x23AD4A4", Offset = "0x23AD4A4", VA = "0x23AD4A4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FAA")]
				[Address(RVA = "0x23AD4AC", Offset = "0x23AD4AC", VA = "0x23AD4AC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_OSX_Base_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000FAB")]
				[Address(RVA = "0x23AD56C", Offset = "0x23AD56C", VA = "0x23AD56C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000BAE")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000BAF")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x17000423")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6000F6B")]
				[Address(RVA = "0x24769CC", Offset = "0x24769CC", VA = "0x24769CC", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000424")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6000F6C")]
				[Address(RVA = "0x24769E4", Offset = "0x24769E4", VA = "0x24769E4", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000425")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6000F6D")]
				[Address(RVA = "0x24769FC", Offset = "0x24769FC", VA = "0x24769FC", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000426")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6000F6E")]
				[Address(RVA = "0x2476A04", Offset = "0x2476A04", VA = "0x2476A04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000427")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6000F6F")]
				[Address(RVA = "0x2476A1C", Offset = "0x2476A1C", VA = "0x2476A1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000428")]
			internal override bool hasData
			{
				[Token(Token = "0x6000F70")]
				[Address(RVA = "0x2476A34", Offset = "0x2476A34", VA = "0x2476A34", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000429")]
			internal override bool disabled
			{
				[Token(Token = "0x6000F71")]
				[Address(RVA = "0x2476A94", Offset = "0x2476A94", VA = "0x2476A94", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700042A")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6000F72")]
				[Address(RVA = "0x2476AA8", Offset = "0x2476AA8", VA = "0x2476AA8", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700042B")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000F73")]
				[Address(RVA = "0x2476B28", Offset = "0x2476B28", VA = "0x2476B28", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F74")]
			[Address(RVA = "0x247670C", Offset = "0x247670C", VA = "0x247670C", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000F75")]
			[Address(RVA = "0x2476B30", Offset = "0x2476B30", VA = "0x2476B30")]
			internal IEnumerable<Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6000F76")]
			[Address(RVA = "0x2476BA4", Offset = "0x2476BA4", VA = "0x2476BA4")]
			internal IEnumerable<Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6000F77")]
			[Address(RVA = "0x2476C18", Offset = "0x2476C18", VA = "0x2476C18", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6000F78")]
			[Address(RVA = "0x247729C", Offset = "0x247729C", VA = "0x247729C", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x2477978", Offset = "0x2477978", VA = "0x2477978", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x2477BD8", Offset = "0x2477BD8", VA = "0x2477BD8", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6000F7B")]
			[Address(RVA = "0x2477F28", Offset = "0x2477F28", VA = "0x2477F28", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x24780C0", Offset = "0x24780C0", VA = "0x24780C0", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6000F7D")]
			[Address(RVA = "0x24780D8", Offset = "0x24780D8", VA = "0x24780D8", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6000F7E")]
			[Address(RVA = "0x24780F4", Offset = "0x24780F4", VA = "0x24780F4", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x24768AC", Offset = "0x24768AC", VA = "0x24768AC", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000F80")]
			[Address(RVA = "0x24769C4", Offset = "0x24769C4", VA = "0x24769C4")]
			public Platform_OSX_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200021D")]
		public sealed class Platform_OSX : Platform_OSX_Base
		{
			[Token(Token = "0x4000BE7")]
			[FieldOffset(Offset = "0x28")]
			public Platform_OSX_Base[] variants;

			[Token(Token = "0x17000435")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000FAC")]
				[Address(RVA = "0x24765F8", Offset = "0x24765F8", VA = "0x24765F8", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x2476600", Offset = "0x2476600", VA = "0x2476600", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x2476758", Offset = "0x2476758", VA = "0x2476758", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000FAF")]
			[Address(RVA = "0x24767DC", Offset = "0x24767DC", VA = "0x24767DC", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x24767D4", Offset = "0x24767D4", VA = "0x24767D4")]
			public Platform_OSX()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200021E")]
		public class Platform_Linux_Base : Platform
		{
			[Serializable]
			[Token(Token = "0x200021F")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Serializable]
				[Token(Token = "0x2000220")]
				public sealed class ElementCount : ElementCount_Base
				{
					[Token(Token = "0x4000BF3")]
					[FieldOffset(Offset = "0x18")]
					public int hatCount;

					[Token(Token = "0x6000FD2")]
					[Address(RVA = "0x23C2A9C", Offset = "0x23C2A9C", VA = "0x23C2A9C")]
					public ElementCount()
					{
					}

					[Token(Token = "0x6000FD3")]
					[Address(RVA = "0x23C2AA4", Offset = "0x23C2AA4", VA = "0x23C2AA4", Slot = "5")]
					public override object DeepClone()
					{
						return null;
					}

					[Token(Token = "0x6000FD4")]
					[Address(RVA = "0x23C2B1C", Offset = "0x23C2B1C", VA = "0x23C2B1C", Slot = "6")]
					internal override void KGvHNOSFSLcIoKIKCrVnqZaTvqVy(ElementCount_Base P_0)
					{
					}

					[Token(Token = "0x6000FD5")]
					[Address(RVA = "0x23C2BA8", Offset = "0x23C2BA8", VA = "0x23C2BA8", Slot = "7")]
					internal override bool dRTWaRkWIkEMLraxMRHrbdGkCqGCA(BridgedControllerHWInfo P_0)
					{
						return default;
					}
				}

				[Token(Token = "0x4000BEA")]
				[FieldOffset(Offset = "0x28")]
				public int hatCount;

				[Token(Token = "0x4000BEB")]
				[FieldOffset(Offset = "0x30")]
				public ElementCount[] alternateElementCounts;

				[Token(Token = "0x4000BEC")]
				[FieldOffset(Offset = "0x38")]
				public bool manufacturer_useRegex;

				[Token(Token = "0x4000BED")]
				[FieldOffset(Offset = "0x39")]
				public bool productName_useRegex;

				[Token(Token = "0x4000BEE")]
				[FieldOffset(Offset = "0x3A")]
				public bool systemName_useRegex;

				[Token(Token = "0x4000BEF")]
				[FieldOffset(Offset = "0x40")]
				public string[] manufacturer;

				[Token(Token = "0x4000BF0")]
				[FieldOffset(Offset = "0x48")]
				public string[] productName;

				[Token(Token = "0x4000BF1")]
				[FieldOffset(Offset = "0x50")]
				public string[] systemName;

				[Token(Token = "0x4000BF2")]
				[FieldOffset(Offset = "0x58")]
				public string[] productGUID;

				[Token(Token = "0x1700043F")]
				internal override bool hasData
				{
					[Token(Token = "0x6000FC7")]
					[Address(RVA = "0x23AB06C", Offset = "0x23AB06C", VA = "0x23AB06C", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000440")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6000FC8")]
					[Address(RVA = "0x23AB0AC", Offset = "0x23AB0AC", VA = "0x23AB0AC", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000441")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6000FCA")]
					[Address(RVA = "0x23AB258", Offset = "0x23AB258", VA = "0x23AB258", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000FC9")]
				[Address(RVA = "0x23AB0B4", Offset = "0x23AB0B4", VA = "0x23AB0B4", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6000FCB")]
				[Address(RVA = "0x23AB270", Offset = "0x23AB270", VA = "0x23AB270", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6000FCC")]
				[Address(RVA = "0x23AB2BC", Offset = "0x23AB2BC", VA = "0x23AB2BC", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6000FCD")]
				[Address(RVA = "0x23AB200", Offset = "0x23AB200", VA = "0x23AB200")]
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo)
				{
					return default;
				}

				[Token(Token = "0x6000FCE")]
				[Address(RVA = "0x23AB320", Offset = "0x23AB320", VA = "0x23AB320")]
				private bool NameMatches(string name, string[] names, bool useRegex)
				{
					return default;
				}

				[Token(Token = "0x6000FCF")]
				[Address(RVA = "0x23AB408", Offset = "0x23AB408", VA = "0x23AB408", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000FD0")]
				[Address(RVA = "0x23AB488", Offset = "0x23AB488", VA = "0x23AB488", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6000FD1")]
				[Address(RVA = "0x23AB480", Offset = "0x23AB480", VA = "0x23AB480")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000221")]
			public sealed class Elements : Elements_Base
			{
				[Token(Token = "0x4000BF4")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000BF5")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000442")]
				public override int buttonCount
				{
					[Token(Token = "0x6000FD6")]
					[Address(RVA = "0x23AAC7C", Offset = "0x23AAC7C", VA = "0x23AAC7C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000443")]
				public override int axisCount
				{
					[Token(Token = "0x6000FD7")]
					[Address(RVA = "0x23AAC94", Offset = "0x23AAC94", VA = "0x23AAC94", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000FD8")]
				[Address(RVA = "0x23AACAC", Offset = "0x23AACAC", VA = "0x23AACAC", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6000FD9")]
				[Address(RVA = "0x23AADD0", Offset = "0x23AADD0", VA = "0x23AADD0", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6000FDA")]
				[Address(RVA = "0x23AAF2C", Offset = "0x23AAF2C", VA = "0x23AAF2C", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000FDB")]
				[Address(RVA = "0x23AAFAC", Offset = "0x23AAFAC", VA = "0x23AAFAC", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6000FDC")]
				[Address(RVA = "0x23AAFA4", Offset = "0x23AAFA4", VA = "0x23AAFA4")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000222")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x6000FDD")]
				public abstract object DeepClone();

				[Token(Token = "0x6000FDE")]
				[Address(RVA = "0x23AA840", Offset = "0x23AA840", VA = "0x23AA840", Slot = "6")]
				protected virtual void ImportVars(Element source)
				{
				}

				[Token(Token = "0x6000FDF")]
				[Address(RVA = "0x23AA650", Offset = "0x23AA650", VA = "0x23AA650")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000223")]
			public class Button : Element
			{
				[Token(Token = "0x4000BF6")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000BF7")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000BF8")]
				[FieldOffset(Offset = "0x18")]
				public int sourceButton;

				[Token(Token = "0x4000BF9")]
				[FieldOffset(Offset = "0x1C")]
				public int sourceAxis;

				[Token(Token = "0x4000BFA")]
				[FieldOffset(Offset = "0x20")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000BFB")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000BFC")]
				[FieldOffset(Offset = "0x28")]
				public int sourceHat;

				[Token(Token = "0x4000BFD")]
				[FieldOffset(Offset = "0x2C")]
				public HatType sourceHatType;

				[Token(Token = "0x4000BFE")]
				[FieldOffset(Offset = "0x30")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000BFF")]
				[FieldOffset(Offset = "0x34")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000C00")]
				[FieldOffset(Offset = "0x38")]
				public int[] requiredButtons;

				[Token(Token = "0x4000C01")]
				[FieldOffset(Offset = "0x40")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000C02")]
				[FieldOffset(Offset = "0x48")]
				public int[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000C03")]
				[FieldOffset(Offset = "0x50")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x6000FE0")]
				[Address(RVA = "0x23AA844", Offset = "0x23AA844", VA = "0x23AA844")]
				public Button()
				{
				}

				[Token(Token = "0x6000FE1")]
				[Address(RVA = "0x23AA86C", Offset = "0x23AA86C", VA = "0x23AA86C", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000FE2")]
				[Address(RVA = "0x23AA8F0", Offset = "0x23AA8F0", VA = "0x23AA8F0", Slot = "6")]
				protected override void ImportVars(Element source)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000224")]
			public class Axis : Element
			{
				[Token(Token = "0x4000C04")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000C05")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000C06")]
				[FieldOffset(Offset = "0x18")]
				public int sourceAxis;

				[Token(Token = "0x4000C07")]
				[FieldOffset(Offset = "0x1C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000C08")]
				[FieldOffset(Offset = "0x20")]
				public bool invert;

				[Token(Token = "0x4000C09")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000C0A")]
				[FieldOffset(Offset = "0x28")]
				public bool calibrateAxis;

				[Token(Token = "0x4000C0B")]
				[FieldOffset(Offset = "0x2C")]
				public float axisZero;

				[Token(Token = "0x4000C0C")]
				[FieldOffset(Offset = "0x30")]
				public float axisMin;

				[Token(Token = "0x4000C0D")]
				[FieldOffset(Offset = "0x34")]
				public float axisMax;

				[Token(Token = "0x4000C0E")]
				[FieldOffset(Offset = "0x38")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000C0F")]
				[FieldOffset(Offset = "0x40")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x4000C10")]
				[FieldOffset(Offset = "0x48")]
				public int sourceButton;

				[Token(Token = "0x4000C11")]
				[FieldOffset(Offset = "0x4C")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000C12")]
				[FieldOffset(Offset = "0x50")]
				public int sourceHat;

				[Token(Token = "0x4000C13")]
				[FieldOffset(Offset = "0x54")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000C14")]
				[FieldOffset(Offset = "0x58")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x6000FE3")]
				[Address(RVA = "0x23AA624", Offset = "0x23AA624", VA = "0x23AA624")]
				public Axis()
				{
				}

				[Token(Token = "0x6000FE4")]
				[Address(RVA = "0x23AA658", Offset = "0x23AA658", VA = "0x23AA658", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6000FE5")]
				[Address(RVA = "0x23AA6E0", Offset = "0x23AA6E0", VA = "0x23AA6E0", Slot = "6")]
				protected override void ImportVars(Element source)
				{
				}
			}

			[Token(Token = "0x2000225")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19179C", Offset = "0x19179C")]
			private sealed class EhHNBRwPCRSHhwqAcnjGFZFKmIrT : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				[Token(Token = "0x4000C15")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000C16")]
				[FieldOffset(Offset = "0x18")]
				private Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000C17")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000C18")]
				[FieldOffset(Offset = "0x28")]
				public Platform_Linux_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000C19")]
				[FieldOffset(Offset = "0x30")]
				private int yGVazBNUxMSdXREcmvzWGmvkBjWk;

				[Token(Token = "0x4000C1A")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000444")]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6000FE9")]
					[Address(RVA = "0x23AAB68", Offset = "0x23AAB68", VA = "0x23AAB68", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000445")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000FEB")]
					[Address(RVA = "0x23AABB0", Offset = "0x23AABB0", VA = "0x23AABB0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000FE6")]
				[Address(RVA = "0x23AAA58", Offset = "0x23AAA58", VA = "0x23AAA58")]
				[DebuggerHidden]
				public EhHNBRwPCRSHhwqAcnjGFZFKmIrT(int P_0)
				{
				}

				[Token(Token = "0x6000FE7")]
				[Address(RVA = "0x23AAAA0", Offset = "0x23AAAA0", VA = "0x23AAAA0", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000FE8")]
				[Address(RVA = "0x23AAAA4", Offset = "0x23AAAA4", VA = "0x23AAAA4", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000FE9")]
				[Address(RVA = "0x23AAB68", Offset = "0x23AAB68", VA = "0x23AAB68", Slot = "10")]
				[DebuggerHidden]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FEA")]
				[Address(RVA = "0x23AAB70", Offset = "0x23AAB70", VA = "0x23AAB70", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000FEB")]
				[Address(RVA = "0x23AABB0", Offset = "0x23AABB0", VA = "0x23AABB0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FEC")]
				[Address(RVA = "0x23AABB8", Offset = "0x23AABB8", VA = "0x23AABB8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000FED")]
				[Address(RVA = "0x23AAC78", Offset = "0x23AAC78", VA = "0x23AAC78", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000226")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1917AC", Offset = "0x1917AC")]
			private sealed class yuLRLMpIirktlqncAASaCZOMzWty : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				[Token(Token = "0x4000C1B")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000C1C")]
				[FieldOffset(Offset = "0x18")]
				private Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000C1D")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000C1E")]
				[FieldOffset(Offset = "0x28")]
				public Platform_Linux_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000C1F")]
				[FieldOffset(Offset = "0x30")]
				private int pMgPWWjomCBqioCeCujXqJRwsmRk;

				[Token(Token = "0x4000C20")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000446")]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6000FF1")]
					[Address(RVA = "0x23AB67C", Offset = "0x23AB67C", VA = "0x23AB67C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000447")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6000FF3")]
					[Address(RVA = "0x23AB6C4", Offset = "0x23AB6C4", VA = "0x23AB6C4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000FEE")]
				[Address(RVA = "0x23AB56C", Offset = "0x23AB56C", VA = "0x23AB56C")]
				[DebuggerHidden]
				public yuLRLMpIirktlqncAASaCZOMzWty(int P_0)
				{
				}

				[Token(Token = "0x6000FEF")]
				[Address(RVA = "0x23AB5B4", Offset = "0x23AB5B4", VA = "0x23AB5B4", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000FF0")]
				[Address(RVA = "0x23AB5B8", Offset = "0x23AB5B8", VA = "0x23AB5B8", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000FF1")]
				[Address(RVA = "0x23AB67C", Offset = "0x23AB67C", VA = "0x23AB67C", Slot = "10")]
				[DebuggerHidden]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FF2")]
				[Address(RVA = "0x23AB684", Offset = "0x23AB684", VA = "0x23AB684", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6000FF3")]
				[Address(RVA = "0x23AB6C4", Offset = "0x23AB6C4", VA = "0x23AB6C4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000FF4")]
				[Address(RVA = "0x23AB6CC", Offset = "0x23AB6CC", VA = "0x23AB6CC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Linux_Base_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000FF5")]
				[Address(RVA = "0x23AB78C", Offset = "0x23AB78C", VA = "0x23AB78C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000BE8")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000BE9")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x17000436")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6000FB1")]
				[Address(RVA = "0x24730D8", Offset = "0x24730D8", VA = "0x24730D8", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000437")]
			internal override bool hasData
			{
				[Token(Token = "0x6000FB2")]
				[Address(RVA = "0x24730E0", Offset = "0x24730E0", VA = "0x24730E0", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000438")]
			internal override bool disabled
			{
				[Token(Token = "0x6000FB3")]
				[Address(RVA = "0x2473140", Offset = "0x2473140", VA = "0x2473140", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000439")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6000FB4")]
				[Address(RVA = "0x2473154", Offset = "0x2473154", VA = "0x2473154", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700043A")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6000FB5")]
				[Address(RVA = "0x24731D4", Offset = "0x24731D4", VA = "0x24731D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700043B")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6000FB6")]
				[Address(RVA = "0x24731EC", Offset = "0x24731EC", VA = "0x24731EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700043C")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000FB7")]
				[Address(RVA = "0x2473204", Offset = "0x2473204", VA = "0x2473204", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700043D")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6000FB9")]
				[Address(RVA = "0x247320C", Offset = "0x247320C", VA = "0x247320C", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700043E")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6000FBA")]
				[Address(RVA = "0x2473224", Offset = "0x2473224", VA = "0x2473224", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x2472E44", Offset = "0x2472E44", VA = "0x2472E44", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x247323C", Offset = "0x247323C", VA = "0x247323C", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x24739A8", Offset = "0x24739A8", VA = "0x24739A8", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x2474084", Offset = "0x2474084", VA = "0x2474084", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0x24742E4", Offset = "0x24742E4", VA = "0x24742E4", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6000FBF")]
			[Address(RVA = "0x2474634", Offset = "0x2474634", VA = "0x2474634", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x24747CC", Offset = "0x24747CC", VA = "0x24747CC", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0x24747E4", Offset = "0x24747E4", VA = "0x24747E4", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6000FC2")]
			[Address(RVA = "0x24738C0", Offset = "0x24738C0", VA = "0x24738C0")]
			internal IEnumerable<Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6000FC3")]
			[Address(RVA = "0x2473934", Offset = "0x2473934", VA = "0x2473934")]
			internal IEnumerable<Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6000FC4")]
			[Address(RVA = "0x2474800", Offset = "0x2474800", VA = "0x2474800", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000FC5")]
			[Address(RVA = "0x2472FE4", Offset = "0x2472FE4", VA = "0x2472FE4", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000FC6")]
			[Address(RVA = "0x24730D0", Offset = "0x24730D0", VA = "0x24730D0")]
			public Platform_Linux_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000227")]
		public sealed class Platform_Linux : Platform_Linux_Base
		{
			[Token(Token = "0x4000C21")]
			[FieldOffset(Offset = "0x28")]
			public Platform_Linux_Base[] variants;

			[Token(Token = "0x17000448")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6000FF6")]
				[Address(RVA = "0x2472D30", Offset = "0x2472D30", VA = "0x2472D30", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000FF7")]
			[Address(RVA = "0x2472D38", Offset = "0x2472D38", VA = "0x2472D38", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6000FF8")]
			[Address(RVA = "0x2472E90", Offset = "0x2472E90", VA = "0x2472E90", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6000FF9")]
			[Address(RVA = "0x2472F14", Offset = "0x2472F14", VA = "0x2472F14", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6000FFA")]
			[Address(RVA = "0x2472F0C", Offset = "0x2472F0C", VA = "0x2472F0C")]
			public Platform_Linux()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000228")]
		public class Platform_WindowsUWP_Base : Platform
		{
			[Serializable]
			[Token(Token = "0x2000229")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Serializable]
				[Token(Token = "0x200022A")]
				public sealed class ElementCount : ElementCount_Base
				{
					[Token(Token = "0x4000C2B")]
					[FieldOffset(Offset = "0x18")]
					public int hatCount;

					[Token(Token = "0x600101C")]
					[Address(RVA = "0x23C2F44", Offset = "0x23C2F44", VA = "0x23C2F44")]
					public ElementCount()
					{
					}

					[Token(Token = "0x600101D")]
					[Address(RVA = "0x23C2F4C", Offset = "0x23C2F4C", VA = "0x23C2F4C", Slot = "5")]
					public override object DeepClone()
					{
						return null;
					}

					[Token(Token = "0x600101E")]
					[Address(RVA = "0x23C2FC4", Offset = "0x23C2FC4", VA = "0x23C2FC4", Slot = "6")]
					internal override void KGvHNOSFSLcIoKIKCrVnqZaTvqVy(ElementCount_Base P_0)
					{
					}

					[Token(Token = "0x600101F")]
					[Address(RVA = "0x23C3050", Offset = "0x23C3050", VA = "0x23C3050", Slot = "7")]
					internal override bool dRTWaRkWIkEMLraxMRHrbdGkCqGCA(BridgedControllerHWInfo P_0)
					{
						return default;
					}
				}

				[Token(Token = "0x4000C24")]
				[FieldOffset(Offset = "0x28")]
				public int hatCount;

				[Token(Token = "0x4000C25")]
				[FieldOffset(Offset = "0x30")]
				public ElementCount[] alternateElementCounts;

				[Token(Token = "0x4000C26")]
				[FieldOffset(Offset = "0x38")]
				public bool manufacturer_useRegex;

				[Token(Token = "0x4000C27")]
				[FieldOffset(Offset = "0x39")]
				public bool productName_useRegex;

				[Token(Token = "0x4000C28")]
				[FieldOffset(Offset = "0x40")]
				public string[] manufacturer;

				[Token(Token = "0x4000C29")]
				[FieldOffset(Offset = "0x48")]
				public string[] productName;

				[Token(Token = "0x4000C2A")]
				[FieldOffset(Offset = "0x50")]
				public string[] productGUID;

				[Token(Token = "0x17000452")]
				internal override bool hasData
				{
					[Token(Token = "0x6001011")]
					[Address(RVA = "0x23B3D6C", Offset = "0x23B3D6C", VA = "0x23B3D6C", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000453")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6001012")]
					[Address(RVA = "0x23B3DAC", Offset = "0x23B3DAC", VA = "0x23B3DAC", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000454")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6001014")]
					[Address(RVA = "0x23B3F0C", Offset = "0x23B3F0C", VA = "0x23B3F0C", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001013")]
				[Address(RVA = "0x23B3DB4", Offset = "0x23B3DB4", VA = "0x23B3DB4", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6001015")]
				[Address(RVA = "0x23B3F24", Offset = "0x23B3F24", VA = "0x23B3F24", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6001016")]
				[Address(RVA = "0x23B3F70", Offset = "0x23B3F70", VA = "0x23B3F70", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6001017")]
				[Address(RVA = "0x23B3EEC", Offset = "0x23B3EEC", VA = "0x23B3EEC")]
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo)
				{
					return default;
				}

				[Token(Token = "0x6001018")]
				[Address(RVA = "0x23B3FD4", Offset = "0x23B3FD4", VA = "0x23B3FD4")]
				private bool NameMatches(string name, string[] names, bool useRegex)
				{
					return default;
				}

				[Token(Token = "0x6001019")]
				[Address(RVA = "0x23B40BC", Offset = "0x23B40BC", VA = "0x23B40BC", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600101A")]
				[Address(RVA = "0x23B413C", Offset = "0x23B413C", VA = "0x23B413C", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x600101B")]
				[Address(RVA = "0x23B4134", Offset = "0x23B4134", VA = "0x23B4134")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200022B")]
			public sealed class Elements : Elements_Base
			{
				[Token(Token = "0x4000C2C")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000C2D")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000455")]
				public override int buttonCount
				{
					[Token(Token = "0x6001020")]
					[Address(RVA = "0x23B397C", Offset = "0x23B397C", VA = "0x23B397C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000456")]
				public override int axisCount
				{
					[Token(Token = "0x6001021")]
					[Address(RVA = "0x23B3994", Offset = "0x23B3994", VA = "0x23B3994", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001022")]
				[Address(RVA = "0x23B39AC", Offset = "0x23B39AC", VA = "0x23B39AC", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6001023")]
				[Address(RVA = "0x23B3AD0", Offset = "0x23B3AD0", VA = "0x23B3AD0", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6001024")]
				[Address(RVA = "0x23B3C2C", Offset = "0x23B3C2C", VA = "0x23B3C2C", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001025")]
				[Address(RVA = "0x23B3CAC", Offset = "0x23B3CAC", VA = "0x23B3CAC", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6001026")]
				[Address(RVA = "0x23B3CA4", Offset = "0x23B3CA4", VA = "0x23B3CA4")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200022C")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x6001027")]
				public abstract object DeepClone();

				[Token(Token = "0x6001028")]
				[Address(RVA = "0x23B3764", Offset = "0x23B3764", VA = "0x23B3764", Slot = "6")]
				protected virtual void ImportVars(Element source)
				{
				}

				[Token(Token = "0x6001029")]
				[Address(RVA = "0x23B3574", Offset = "0x23B3574", VA = "0x23B3574")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200022D")]
			public class Button : Element
			{
				[Token(Token = "0x4000C2E")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000C2F")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000C30")]
				[FieldOffset(Offset = "0x18")]
				public int sourceButton;

				[Token(Token = "0x4000C31")]
				[FieldOffset(Offset = "0x1C")]
				public int sourceAxis;

				[Token(Token = "0x4000C32")]
				[FieldOffset(Offset = "0x20")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000C33")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000C34")]
				[FieldOffset(Offset = "0x28")]
				public int sourceHat;

				[Token(Token = "0x4000C35")]
				[FieldOffset(Offset = "0x2C")]
				public HatType sourceHatType;

				[Token(Token = "0x4000C36")]
				[FieldOffset(Offset = "0x30")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000C37")]
				[FieldOffset(Offset = "0x34")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000C38")]
				[FieldOffset(Offset = "0x38")]
				public int[] requiredButtons;

				[Token(Token = "0x4000C39")]
				[FieldOffset(Offset = "0x40")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000C3A")]
				[FieldOffset(Offset = "0x48")]
				public int[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000C3B")]
				[FieldOffset(Offset = "0x50")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x600102A")]
				[Address(RVA = "0x23B3768", Offset = "0x23B3768", VA = "0x23B3768")]
				public Button()
				{
				}

				[Token(Token = "0x600102B")]
				[Address(RVA = "0x23B3790", Offset = "0x23B3790", VA = "0x23B3790", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600102C")]
				[Address(RVA = "0x23B3814", Offset = "0x23B3814", VA = "0x23B3814", Slot = "6")]
				protected override void ImportVars(Element source)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200022E")]
			public class Axis : Element
			{
				[Token(Token = "0x4000C3C")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000C3D")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000C3E")]
				[FieldOffset(Offset = "0x18")]
				public int sourceAxis;

				[Token(Token = "0x4000C3F")]
				[FieldOffset(Offset = "0x1C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000C40")]
				[FieldOffset(Offset = "0x20")]
				public bool invert;

				[Token(Token = "0x4000C41")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000C42")]
				[FieldOffset(Offset = "0x28")]
				public bool calibrateAxis;

				[Token(Token = "0x4000C43")]
				[FieldOffset(Offset = "0x2C")]
				public float axisZero;

				[Token(Token = "0x4000C44")]
				[FieldOffset(Offset = "0x30")]
				public float axisMin;

				[Token(Token = "0x4000C45")]
				[FieldOffset(Offset = "0x34")]
				public float axisMax;

				[Token(Token = "0x4000C46")]
				[FieldOffset(Offset = "0x38")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000C47")]
				[FieldOffset(Offset = "0x40")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x4000C48")]
				[FieldOffset(Offset = "0x48")]
				public int sourceButton;

				[Token(Token = "0x4000C49")]
				[FieldOffset(Offset = "0x4C")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000C4A")]
				[FieldOffset(Offset = "0x50")]
				public int sourceHat;

				[Token(Token = "0x4000C4B")]
				[FieldOffset(Offset = "0x54")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000C4C")]
				[FieldOffset(Offset = "0x58")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x600102D")]
				[Address(RVA = "0x23B3548", Offset = "0x23B3548", VA = "0x23B3548")]
				public Axis()
				{
				}

				[Token(Token = "0x600102E")]
				[Address(RVA = "0x23B357C", Offset = "0x23B357C", VA = "0x23B357C", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600102F")]
				[Address(RVA = "0x23B3604", Offset = "0x23B3604", VA = "0x23B3604", Slot = "6")]
				protected override void ImportVars(Element source)
				{
				}
			}

			[Token(Token = "0x200022F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1917BC", Offset = "0x1917BC")]
			private sealed class pFXyDbPHKgnwqgDRDuqnaHlBDvfF : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				[Token(Token = "0x4000C4D")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000C4E")]
				[FieldOffset(Offset = "0x18")]
				private Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000C4F")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000C50")]
				[FieldOffset(Offset = "0x28")]
				public Platform_WindowsUWP_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000C51")]
				[FieldOffset(Offset = "0x30")]
				private int yGVazBNUxMSdXREcmvzWGmvkBjWk;

				[Token(Token = "0x4000C52")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000457")]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6001033")]
					[Address(RVA = "0x23B453C", Offset = "0x23B453C", VA = "0x23B453C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000458")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001035")]
					[Address(RVA = "0x23B4584", Offset = "0x23B4584", VA = "0x23B4584", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001030")]
				[Address(RVA = "0x23B442C", Offset = "0x23B442C", VA = "0x23B442C")]
				[DebuggerHidden]
				public pFXyDbPHKgnwqgDRDuqnaHlBDvfF(int P_0)
				{
				}

				[Token(Token = "0x6001031")]
				[Address(RVA = "0x23B4474", Offset = "0x23B4474", VA = "0x23B4474", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001032")]
				[Address(RVA = "0x23B4478", Offset = "0x23B4478", VA = "0x23B4478", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001033")]
				[Address(RVA = "0x23B453C", Offset = "0x23B453C", VA = "0x23B453C", Slot = "10")]
				[DebuggerHidden]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001034")]
				[Address(RVA = "0x23B4544", Offset = "0x23B4544", VA = "0x23B4544", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001035")]
				[Address(RVA = "0x23B4584", Offset = "0x23B4584", VA = "0x23B4584", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001036")]
				[Address(RVA = "0x23B458C", Offset = "0x23B458C", VA = "0x23B458C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001037")]
				[Address(RVA = "0x23B464C", Offset = "0x23B464C", VA = "0x23B464C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1917CC", Offset = "0x1917CC")]
			private sealed class NfutHdNubNjKtNVHjWnkvtayTgtP : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				[Token(Token = "0x4000C53")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000C54")]
				[FieldOffset(Offset = "0x18")]
				private Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000C55")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000C56")]
				[FieldOffset(Offset = "0x28")]
				public Platform_WindowsUWP_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000C57")]
				[FieldOffset(Offset = "0x30")]
				private int pMgPWWjomCBqioCeCujXqJRwsmRk;

				[Token(Token = "0x4000C58")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000459")]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x600103B")]
					[Address(RVA = "0x23B4318", Offset = "0x23B4318", VA = "0x23B4318", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700045A")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600103D")]
					[Address(RVA = "0x23B4360", Offset = "0x23B4360", VA = "0x23B4360", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001038")]
				[Address(RVA = "0x23B4208", Offset = "0x23B4208", VA = "0x23B4208")]
				[DebuggerHidden]
				public NfutHdNubNjKtNVHjWnkvtayTgtP(int P_0)
				{
				}

				[Token(Token = "0x6001039")]
				[Address(RVA = "0x23B4250", Offset = "0x23B4250", VA = "0x23B4250", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x600103A")]
				[Address(RVA = "0x23B4254", Offset = "0x23B4254", VA = "0x23B4254", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600103B")]
				[Address(RVA = "0x23B4318", Offset = "0x23B4318", VA = "0x23B4318", Slot = "10")]
				[DebuggerHidden]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600103C")]
				[Address(RVA = "0x23B4320", Offset = "0x23B4320", VA = "0x23B4320", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600103D")]
				[Address(RVA = "0x23B4360", Offset = "0x23B4360", VA = "0x23B4360", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600103E")]
				[Address(RVA = "0x23B4368", Offset = "0x23B4368", VA = "0x23B4368", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_WindowsUWP_Base_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600103F")]
				[Address(RVA = "0x23B4428", Offset = "0x23B4428", VA = "0x23B4428", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000C22")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000C23")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x17000449")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6000FFB")]
				[Address(RVA = "0x24831AC", Offset = "0x24831AC", VA = "0x24831AC", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700044A")]
			internal override bool hasData
			{
				[Token(Token = "0x6000FFC")]
				[Address(RVA = "0x24831B4", Offset = "0x24831B4", VA = "0x24831B4", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700044B")]
			internal override bool disabled
			{
				[Token(Token = "0x6000FFD")]
				[Address(RVA = "0x2483214", Offset = "0x2483214", VA = "0x2483214", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700044C")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6000FFE")]
				[Address(RVA = "0x2483228", Offset = "0x2483228", VA = "0x2483228", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700044D")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6000FFF")]
				[Address(RVA = "0x2483270", Offset = "0x2483270", VA = "0x2483270")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700044E")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6001000")]
				[Address(RVA = "0x2483288", Offset = "0x2483288", VA = "0x2483288")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700044F")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001001")]
				[Address(RVA = "0x24832A0", Offset = "0x24832A0", VA = "0x24832A0", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000450")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6001003")]
				[Address(RVA = "0x24832A8", Offset = "0x24832A8", VA = "0x24832A8", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000451")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6001004")]
				[Address(RVA = "0x24832C0", Offset = "0x24832C0", VA = "0x24832C0", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6001002")]
			[Address(RVA = "0x2482F18", Offset = "0x2482F18", VA = "0x2482F18", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001005")]
			[Address(RVA = "0x24832D8", Offset = "0x24832D8", VA = "0x24832D8", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001006")]
			[Address(RVA = "0x2483A44", Offset = "0x2483A44", VA = "0x2483A44", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6001007")]
			[Address(RVA = "0x2484120", Offset = "0x2484120", VA = "0x2484120", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6001008")]
			[Address(RVA = "0x2484384", Offset = "0x2484384", VA = "0x2484384", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6001009")]
			[Address(RVA = "0x24846D4", Offset = "0x24846D4", VA = "0x24846D4", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x600100A")]
			[Address(RVA = "0x248486C", Offset = "0x248486C", VA = "0x248486C", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x600100B")]
			[Address(RVA = "0x2484884", Offset = "0x2484884", VA = "0x2484884", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x600100C")]
			[Address(RVA = "0x248395C", Offset = "0x248395C", VA = "0x248395C")]
			internal IEnumerable<Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x600100D")]
			[Address(RVA = "0x24839D0", Offset = "0x24839D0", VA = "0x24839D0")]
			internal IEnumerable<Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x600100E")]
			[Address(RVA = "0x24848A0", Offset = "0x24848A0", VA = "0x24848A0", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x600100F")]
			[Address(RVA = "0x24830B8", Offset = "0x24830B8", VA = "0x24830B8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001010")]
			[Address(RVA = "0x24831A4", Offset = "0x24831A4", VA = "0x24831A4")]
			public Platform_WindowsUWP_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000231")]
		public sealed class Platform_WindowsUWP : Platform_WindowsUWP_Base
		{
			[Token(Token = "0x4000C59")]
			[FieldOffset(Offset = "0x28")]
			public Platform_WindowsUWP_Base[] variants;

			[Token(Token = "0x1700045B")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001040")]
				[Address(RVA = "0x2482E04", Offset = "0x2482E04", VA = "0x2482E04", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001041")]
			[Address(RVA = "0x2482E0C", Offset = "0x2482E0C", VA = "0x2482E0C", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001042")]
			[Address(RVA = "0x2482F64", Offset = "0x2482F64", VA = "0x2482F64", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001043")]
			[Address(RVA = "0x2482FE8", Offset = "0x2482FE8", VA = "0x2482FE8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001044")]
			[Address(RVA = "0x2482FE0", Offset = "0x2482FE0", VA = "0x2482FE0")]
			public Platform_WindowsUWP()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000232")]
		public class Platform_Fallback_Base : Platform
		{
			[Serializable]
			[Token(Token = "0x2000233")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Token(Token = "0x4000C5C")]
				[FieldOffset(Offset = "0x28")]
				public bool alwaysMatch;

				[Token(Token = "0x4000C5D")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000C5E")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x4000C5F")]
				[FieldOffset(Offset = "0x38")]
				public bool matchUnityVersion;

				[Token(Token = "0x4000C60")]
				[FieldOffset(Offset = "0x40")]
				public string matchUnityVersion_min;

				[Token(Token = "0x4000C61")]
				[FieldOffset(Offset = "0x48")]
				public string matchUnityVersion_max;

				[Token(Token = "0x4000C62")]
				[FieldOffset(Offset = "0x50")]
				public bool matchSysVersion;

				[Token(Token = "0x4000C63")]
				[FieldOffset(Offset = "0x58")]
				public string matchSysVersion_min;

				[Token(Token = "0x4000C64")]
				[FieldOffset(Offset = "0x60")]
				public string matchSysVersion_max;

				[Token(Token = "0x17000465")]
				internal override bool hasData
				{
					[Token(Token = "0x600105B")]
					[Address(RVA = "0x23A7CBC", Offset = "0x23A7CBC", VA = "0x23A7CBC", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000466")]
				internal override bool isAllowed
				{
					[Token(Token = "0x600105C")]
					[Address(RVA = "0x23A7CF4", Offset = "0x23A7CF4", VA = "0x23A7CF4", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000467")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x600105E")]
					[Address(RVA = "0x23A7F08", Offset = "0x23A7F08", VA = "0x23A7F08", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600105D")]
				[Address(RVA = "0x23A7DB8", Offset = "0x23A7DB8", VA = "0x23A7DB8", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x600105F")]
				[Address(RVA = "0x23A7F10", Offset = "0x23A7F10", VA = "0x23A7F10", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6001060")]
				[Address(RVA = "0x23A7F18", Offset = "0x23A7F18", VA = "0x23A7F18", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6001061")]
				[Address(RVA = "0x23A7F20", Offset = "0x23A7F20", VA = "0x23A7F20", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001062")]
				[Address(RVA = "0x23A7FA0", Offset = "0x23A7FA0", VA = "0x23A7FA0", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001063")]
				[Address(RVA = "0x23A7F98", Offset = "0x23A7F98", VA = "0x23A7F98")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000234")]
			public sealed class Elements : Elements_Base
			{
				[Token(Token = "0x4000C65")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000C66")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000468")]
				public override int buttonCount
				{
					[Token(Token = "0x6001064")]
					[Address(RVA = "0x23A78F4", Offset = "0x23A78F4", VA = "0x23A78F4", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000469")]
				public override int axisCount
				{
					[Token(Token = "0x6001065")]
					[Address(RVA = "0x23A790C", Offset = "0x23A790C", VA = "0x23A790C", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001066")]
				[Address(RVA = "0x23A7924", Offset = "0x23A7924", VA = "0x23A7924", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6001067")]
				[Address(RVA = "0x23A7A48", Offset = "0x23A7A48", VA = "0x23A7A48", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6001068")]
				[Address(RVA = "0x23A7B7C", Offset = "0x23A7B7C", VA = "0x23A7B7C", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001069")]
				[Address(RVA = "0x23A7BFC", Offset = "0x23A7BFC", VA = "0x23A7BFC", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x600106A")]
				[Address(RVA = "0x23A7BF4", Offset = "0x23A7BF4", VA = "0x23A7BF4")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000235")]
			public class CustomCalculationSourceData : IDeepCloneable
			{
				[Token(Token = "0x4000C67")]
				[FieldOffset(Offset = "0x10")]
				public int sourceType;

				[Token(Token = "0x4000C68")]
				[FieldOffset(Offset = "0x14")]
				public int sourceElement;

				[Token(Token = "0x4000C69")]
				[FieldOffset(Offset = "0x18")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000C6A")]
				[FieldOffset(Offset = "0x1C")]
				public float deadzone;

				[Token(Token = "0x4000C6B")]
				[FieldOffset(Offset = "0x20")]
				public bool invert;

				[Token(Token = "0x600106B")]
				[Address(RVA = "0x23A7860", Offset = "0x23A7860", VA = "0x23A7860", Slot = "4")]
				public object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600106C")]
				[Address(RVA = "0x23A78EC", Offset = "0x23A78EC", VA = "0x23A78EC")]
				public CustomCalculationSourceData()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000236")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x4000C6C")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000C6D")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000C6E")]
				[FieldOffset(Offset = "0x18")]
				public UnityAxis sourceAxis;

				[Token(Token = "0x4000C6F")]
				[FieldOffset(Offset = "0x1C")]
				public float axisDeadZone;

				[Token(Token = "0x4000C70")]
				[FieldOffset(Offset = "0x20")]
				public UnityButton sourceButton;

				[Token(Token = "0x4000C71")]
				[FieldOffset(Offset = "0x24")]
				public KeyCode sourceKeyCode;

				[Token(Token = "0x4000C72")]
				[FieldOffset(Offset = "0x28")]
				public CustomCalculation customCalculation;

				[Token(Token = "0x4000C73")]
				[FieldOffset(Offset = "0x30")]
				public CustomCalculationSourceData[] customCalculationSourceData;

				[Token(Token = "0x600106D")]
				public abstract object DeepClone();

				[Token(Token = "0x600106E")]
				[Address(RVA = "0x23A75A4", Offset = "0x23A75A4", VA = "0x23A75A4", Slot = "6")]
				protected virtual void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600106F")]
				[Address(RVA = "0x23A762C", Offset = "0x23A762C", VA = "0x23A762C")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000237")]
			public sealed class Button : Element
			{
				[Token(Token = "0x4000C74")]
				[FieldOffset(Offset = "0x38")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000C75")]
				[FieldOffset(Offset = "0x3C")]
				public UnityAxis unityHat_sourceAxis1;

				[Token(Token = "0x4000C76")]
				[FieldOffset(Offset = "0x40")]
				public UnityAxis unityHat_sourceAxis2;

				[Token(Token = "0x4000C77")]
				[FieldOffset(Offset = "0x44")]
				public Vector2 unityHat_isActiveAxisValues1;

				[Token(Token = "0x4000C78")]
				[FieldOffset(Offset = "0x4C")]
				public Vector2 unityHat_isActiveAxisValues2;

				[Token(Token = "0x4000C79")]
				[FieldOffset(Offset = "0x54")]
				public Vector2 unityHat_isActiveAxisValues3;

				[Token(Token = "0x4000C7A")]
				[FieldOffset(Offset = "0x5C")]
				public Vector2 unityHat_zeroValues;

				[Token(Token = "0x4000C7B")]
				[FieldOffset(Offset = "0x64")]
				public bool unityHat_checkNeverPressed;

				[Token(Token = "0x4000C7C")]
				[FieldOffset(Offset = "0x68")]
				public Vector2 unityHat_neverPressedZeroValues;

				[Token(Token = "0x4000C7D")]
				[FieldOffset(Offset = "0x70")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000C7E")]
				[FieldOffset(Offset = "0x78")]
				public UnityButton[] requiredButtons;

				[Token(Token = "0x4000C7F")]
				[FieldOffset(Offset = "0x80")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000C80")]
				[FieldOffset(Offset = "0x88")]
				public UnityButton[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000C81")]
				[FieldOffset(Offset = "0x90")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x6001070")]
				[Address(RVA = "0x23A7634", Offset = "0x23A7634", VA = "0x23A7634", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001071")]
				[Address(RVA = "0x23A76B4", Offset = "0x23A76B4", VA = "0x23A76B4", Slot = "6")]
				protected override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001072")]
				[Address(RVA = "0x23A76AC", Offset = "0x23A76AC", VA = "0x23A76AC")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000238")]
			public sealed class Axis : Element
			{
				[Token(Token = "0x4000C82")]
				[FieldOffset(Offset = "0x38")]
				public bool invert;

				[Token(Token = "0x4000C83")]
				[FieldOffset(Offset = "0x3C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000C84")]
				[FieldOffset(Offset = "0x40")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000C85")]
				[FieldOffset(Offset = "0x44")]
				public bool calibrateAxis;

				[Token(Token = "0x4000C86")]
				[FieldOffset(Offset = "0x48")]
				public float axisZero;

				[Token(Token = "0x4000C87")]
				[FieldOffset(Offset = "0x4C")]
				public float axisMin;

				[Token(Token = "0x4000C88")]
				[FieldOffset(Offset = "0x50")]
				public float axisMax;

				[Token(Token = "0x4000C89")]
				[FieldOffset(Offset = "0x58")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000C8A")]
				[FieldOffset(Offset = "0x60")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x6001073")]
				[Address(RVA = "0x23A73B0", Offset = "0x23A73B0", VA = "0x23A73B0", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001074")]
				[Address(RVA = "0x23A7430", Offset = "0x23A7430", VA = "0x23A7430", Slot = "6")]
				protected override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001075")]
				[Address(RVA = "0x23A7428", Offset = "0x23A7428", VA = "0x23A7428")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000239")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1917DC", Offset = "0x1917DC")]
			private sealed class yMbFWPHYFRicNRNMTJaxCtfUziomA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				[Token(Token = "0x4000C8B")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000C8C")]
				[FieldOffset(Offset = "0x18")]
				private Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000C8D")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000C8E")]
				[FieldOffset(Offset = "0x28")]
				public Platform_Fallback_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000C8F")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x1700046A")]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6001079")]
					[Address(RVA = "0x23A8388", Offset = "0x23A8388", VA = "0x23A8388", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700046B")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600107B")]
					[Address(RVA = "0x23A83D0", Offset = "0x23A83D0", VA = "0x23A83D0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001076")]
				[Address(RVA = "0x23A8280", Offset = "0x23A8280", VA = "0x23A8280")]
				[DebuggerHidden]
				public yMbFWPHYFRicNRNMTJaxCtfUziomA(int P_0)
				{
				}

				[Token(Token = "0x6001077")]
				[Address(RVA = "0x23A82C8", Offset = "0x23A82C8", VA = "0x23A82C8", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001078")]
				[Address(RVA = "0x23A82CC", Offset = "0x23A82CC", VA = "0x23A82CC", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001079")]
				[Address(RVA = "0x23A8388", Offset = "0x23A8388", VA = "0x23A8388", Slot = "10")]
				[DebuggerHidden]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600107A")]
				[Address(RVA = "0x23A8390", Offset = "0x23A8390", VA = "0x23A8390", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600107B")]
				[Address(RVA = "0x23A83D0", Offset = "0x23A83D0", VA = "0x23A83D0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600107C")]
				[Address(RVA = "0x23A83D8", Offset = "0x23A83D8", VA = "0x23A83D8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600107D")]
				[Address(RVA = "0x23A8498", Offset = "0x23A8498", VA = "0x23A8498", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x200023A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1917EC", Offset = "0x1917EC")]
			private sealed class bDsllBXhNaVNHdDCrTvKhdMPmvJU : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				[Token(Token = "0x4000C90")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000C91")]
				[FieldOffset(Offset = "0x18")]
				private Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000C92")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000C93")]
				[FieldOffset(Offset = "0x28")]
				public Platform_Fallback_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000C94")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x1700046C")]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6001081")]
					[Address(RVA = "0x23A816C", Offset = "0x23A816C", VA = "0x23A816C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700046D")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001083")]
					[Address(RVA = "0x23A81B4", Offset = "0x23A81B4", VA = "0x23A81B4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600107E")]
				[Address(RVA = "0x23A8064", Offset = "0x23A8064", VA = "0x23A8064")]
				[DebuggerHidden]
				public bDsllBXhNaVNHdDCrTvKhdMPmvJU(int P_0)
				{
				}

				[Token(Token = "0x600107F")]
				[Address(RVA = "0x23A80AC", Offset = "0x23A80AC", VA = "0x23A80AC", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001080")]
				[Address(RVA = "0x23A80B0", Offset = "0x23A80B0", VA = "0x23A80B0", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001081")]
				[Address(RVA = "0x23A816C", Offset = "0x23A816C", VA = "0x23A816C", Slot = "10")]
				[DebuggerHidden]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001082")]
				[Address(RVA = "0x23A8174", Offset = "0x23A8174", VA = "0x23A8174", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001083")]
				[Address(RVA = "0x23A81B4", Offset = "0x23A81B4", VA = "0x23A81B4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001084")]
				[Address(RVA = "0x23A81BC", Offset = "0x23A81BC", VA = "0x23A81BC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Fallback_Base_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001085")]
				[Address(RVA = "0x23A827C", Offset = "0x23A827C", VA = "0x23A827C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000C5A")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000C5B")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x1700045C")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6001045")]
				[Address(RVA = "0x246D570", Offset = "0x246D570", VA = "0x246D570", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700045D")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6001046")]
				[Address(RVA = "0x246D588", Offset = "0x246D588", VA = "0x246D588", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700045E")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6001047")]
				[Address(RVA = "0x246D5A0", Offset = "0x246D5A0", VA = "0x246D5A0", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700045F")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6001048")]
				[Address(RVA = "0x246D5A8", Offset = "0x246D5A8", VA = "0x246D5A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000460")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6001049")]
				[Address(RVA = "0x246D5C0", Offset = "0x246D5C0", VA = "0x246D5C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000461")]
			internal override bool hasData
			{
				[Token(Token = "0x600104A")]
				[Address(RVA = "0x246D5D8", Offset = "0x246D5D8", VA = "0x246D5D8", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000462")]
			internal override bool disabled
			{
				[Token(Token = "0x600104B")]
				[Address(RVA = "0x246D638", Offset = "0x246D638", VA = "0x246D638", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000463")]
			internal override bool isAllowed
			{
				[Token(Token = "0x600104C")]
				[Address(RVA = "0x246D64C", Offset = "0x246D64C", VA = "0x246D64C", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000464")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x600104D")]
				[Address(RVA = "0x246D6CC", Offset = "0x246D6CC", VA = "0x246D6CC", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600104E")]
			[Address(RVA = "0x246D2B0", Offset = "0x246D2B0", VA = "0x246D2B0", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x600104F")]
			[Address(RVA = "0x246D6D4", Offset = "0x246D6D4", VA = "0x246D6D4")]
			internal IEnumerable<Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6001050")]
			[Address(RVA = "0x246D748", Offset = "0x246D748", VA = "0x246D748")]
			internal IEnumerable<Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6001051")]
			[Address(RVA = "0x246D7BC", Offset = "0x246D7BC", VA = "0x246D7BC", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001052")]
			[Address(RVA = "0x246DE40", Offset = "0x246DE40", VA = "0x246DE40", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6001053")]
			[Address(RVA = "0x246E51C", Offset = "0x246E51C", VA = "0x246E51C", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6001054")]
			[Address(RVA = "0x246E77C", Offset = "0x246E77C", VA = "0x246E77C", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6001055")]
			[Address(RVA = "0x246EACC", Offset = "0x246EACC", VA = "0x246EACC", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6001056")]
			[Address(RVA = "0x246EC64", Offset = "0x246EC64", VA = "0x246EC64", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6001057")]
			[Address(RVA = "0x246EC7C", Offset = "0x246EC7C", VA = "0x246EC7C", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6001058")]
			[Address(RVA = "0x246EC98", Offset = "0x246EC98", VA = "0x246EC98", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001059")]
			[Address(RVA = "0x246D450", Offset = "0x246D450", VA = "0x246D450", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600105A")]
			[Address(RVA = "0x246D568", Offset = "0x246D568", VA = "0x246D568")]
			public Platform_Fallback_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200023B")]
		public sealed class Platform_Fallback : Platform_Fallback_Base
		{
			[Token(Token = "0x4000C95")]
			[FieldOffset(Offset = "0x28")]
			public Platform_Fallback_Base[] variants;

			[Token(Token = "0x1700046E")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001086")]
				[Address(RVA = "0x246D19C", Offset = "0x246D19C", VA = "0x246D19C", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001087")]
			[Address(RVA = "0x246D1A4", Offset = "0x246D1A4", VA = "0x246D1A4", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001088")]
			[Address(RVA = "0x246D2FC", Offset = "0x246D2FC", VA = "0x246D2FC", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001089")]
			[Address(RVA = "0x246D380", Offset = "0x246D380", VA = "0x246D380", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600108A")]
			[Address(RVA = "0x246D378", Offset = "0x246D378", VA = "0x246D378")]
			public Platform_Fallback()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200023C")]
		public abstract class Platform_Custom : Platform
		{
			[Serializable]
			[Token(Token = "0x200023D")]
			public abstract class MatchingCriteria : MatchingCriteria_Base
			{
				[Token(Token = "0x4000C96")]
				[FieldOffset(Offset = "0x28")]
				public bool alwaysMatch;

				[Token(Token = "0x17000471")]
				internal override bool hasData
				{
					[Token(Token = "0x6001091")]
					[Address(RVA = "0x23A65A8", Offset = "0x23A65A8", VA = "0x23A65A8", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000472")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6001092")]
					[Address(RVA = "0x23A65C4", Offset = "0x23A65C4", VA = "0x23A65C4", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000473")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6001094")]
					[Address(RVA = "0x23A6650", Offset = "0x23A6650", VA = "0x23A6650", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001093")]
				[Address(RVA = "0x23A65CC", Offset = "0x23A65CC", VA = "0x23A65CC", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6001095")]
				[Address(RVA = "0x23A6658", Offset = "0x23A6658", VA = "0x23A6658", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6001096")]
				[Address(RVA = "0x23A6660", Offset = "0x23A6660", VA = "0x23A6660", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6001097")]
				[Address(RVA = "0x23A6668", Offset = "0x23A6668", VA = "0x23A6668", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001098")]
				[Address(RVA = "0x23A6710", Offset = "0x23A6710", VA = "0x23A6710")]
				protected MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200023E")]
			public abstract class Elements : Elements_Base
			{
				[Token(Token = "0x6001099")]
				[Address(RVA = "0x23A65A0", Offset = "0x23A65A0", VA = "0x23A65A0")]
				protected Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200023F")]
			public class CustomCalculationSourceData : IDeepCloneable
			{
				[Token(Token = "0x4000C97")]
				[FieldOffset(Offset = "0x10")]
				public int sourceType;

				[Token(Token = "0x4000C98")]
				[FieldOffset(Offset = "0x14")]
				public int sourceAxis;

				[Token(Token = "0x4000C99")]
				[FieldOffset(Offset = "0x18")]
				public int sourceButton;

				[Token(Token = "0x4000C9A")]
				[FieldOffset(Offset = "0x1C")]
				public int sourceOtherAxis;

				[Token(Token = "0x4000C9B")]
				[FieldOffset(Offset = "0x20")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000C9C")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000C9D")]
				[FieldOffset(Offset = "0x28")]
				public bool invert;

				[Token(Token = "0x4000C9E")]
				[FieldOffset(Offset = "0x2C")]
				public AxisCalibrationType axisCalibrationType;

				[Token(Token = "0x4000C9F")]
				[FieldOffset(Offset = "0x30")]
				public float axisZero;

				[Token(Token = "0x4000CA0")]
				[FieldOffset(Offset = "0x34")]
				public float axisMin;

				[Token(Token = "0x4000CA1")]
				[FieldOffset(Offset = "0x38")]
				public float axisMax;

				[Token(Token = "0x600109A")]
				[Address(RVA = "0x23A6458", Offset = "0x23A6458", VA = "0x23A6458", Slot = "5")]
				public virtual object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600109B")]
				[Address(RVA = "0x23A6504", Offset = "0x23A6504", VA = "0x23A6504")]
				public CustomCalculationSourceData()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000240")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x4000CA2")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000CA3")]
				[FieldOffset(Offset = "0x14")]
				public int sourceType;

				[Token(Token = "0x4000CA4")]
				[FieldOffset(Offset = "0x18")]
				public int sourceAxis;

				[Token(Token = "0x4000CA5")]
				[FieldOffset(Offset = "0x1C")]
				public float axisDeadZone;

				[Token(Token = "0x4000CA6")]
				[FieldOffset(Offset = "0x20")]
				public int sourceButton;

				[Token(Token = "0x4000CA7")]
				[FieldOffset(Offset = "0x28")]
				public CustomCalculation customCalculation;

				[Token(Token = "0x4000CA8")]
				[FieldOffset(Offset = "0x30")]
				public CustomCalculationSourceData[] customCalculationSourceData;

				[Token(Token = "0x600109C")]
				[Address(RVA = "0x23A650C", Offset = "0x23A650C", VA = "0x23A650C", Slot = "5")]
				internal virtual void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600109D")]
				public abstract object DeepClone();

				[Token(Token = "0x600109E")]
				[Address(RVA = "0x23A6598", Offset = "0x23A6598", VA = "0x23A6598")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000241")]
			public abstract class Button : Element
			{
				[Token(Token = "0x4000CA9")]
				[FieldOffset(Offset = "0x38")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000CAA")]
				[FieldOffset(Offset = "0x3C")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000CAB")]
				[FieldOffset(Offset = "0x40")]
				public int[] requiredButtons;

				[Token(Token = "0x4000CAC")]
				[FieldOffset(Offset = "0x48")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000CAD")]
				[FieldOffset(Offset = "0x50")]
				public int[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000CAE")]
				[FieldOffset(Offset = "0x58")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x600109F")]
				[Address(RVA = "0x23A55A8", Offset = "0x23A55A8", VA = "0x23A55A8", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60010A0")]
				[Address(RVA = "0x23A56F8", Offset = "0x23A56F8", VA = "0x23A56F8")]
				protected Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000242")]
			public abstract class Axis : Element
			{
				[Token(Token = "0x4000CAF")]
				[FieldOffset(Offset = "0x38")]
				public bool invert;

				[Token(Token = "0x4000CB0")]
				[FieldOffset(Offset = "0x3C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000CB1")]
				[FieldOffset(Offset = "0x40")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000CB2")]
				[FieldOffset(Offset = "0x44")]
				public bool calibrateAxis;

				[Token(Token = "0x4000CB3")]
				[FieldOffset(Offset = "0x48")]
				public float axisZero;

				[Token(Token = "0x4000CB4")]
				[FieldOffset(Offset = "0x4C")]
				public float axisMin;

				[Token(Token = "0x4000CB5")]
				[FieldOffset(Offset = "0x50")]
				public float axisMax;

				[Token(Token = "0x4000CB6")]
				[FieldOffset(Offset = "0x58")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000CB7")]
				[FieldOffset(Offset = "0x60")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x60010A1")]
				[Address(RVA = "0x23A5348", Offset = "0x23A5348", VA = "0x23A5348", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60010A2")]
				[Address(RVA = "0x23A5498", Offset = "0x23A5498", VA = "0x23A5498")]
				protected Axis()
				{
				}
			}

			[Token(Token = "0x1700046F")]
			internal abstract Axis[] Axes
			{
				[Token(Token = "0x600108B")]
				get;
			}

			[Token(Token = "0x17000470")]
			internal abstract Button[] Buttons
			{
				[Token(Token = "0x600108C")]
				get;
			}

			[Token(Token = "0x600108D")]
			internal abstract IEnumerable<Axis> IterateAxes();

			[Token(Token = "0x600108E")]
			internal abstract IEnumerable<Button> IterateButtons();

			[Token(Token = "0x600108F")]
			[Address(RVA = "0x246B608", Offset = "0x246B608", VA = "0x246B608", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001090")]
			[Address(RVA = "0x246B60C", Offset = "0x246B60C", VA = "0x246B60C")]
			protected Platform_Custom()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000243")]
		public class Platform_XboxOne_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x2000244")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000CBC")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000CBD")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x1700047F")]
				internal override bool hasData
				{
					[Token(Token = "0x60010BB")]
					[Address(RVA = "0x23B5988", Offset = "0x23B5988", VA = "0x23B5988", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000480")]
				internal override bool isAllowed
				{
					[Token(Token = "0x60010BC")]
					[Address(RVA = "0x23B59B8", Offset = "0x23B59B8", VA = "0x23B59B8", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60010BD")]
				[Address(RVA = "0x23B59F4", Offset = "0x23B59F4", VA = "0x23B59F4", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x60010BE")]
				[Address(RVA = "0x23B5B64", Offset = "0x23B5B64", VA = "0x23B5B64", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60010BF")]
				[Address(RVA = "0x23B5BE4", Offset = "0x23B5BE4", VA = "0x23B5BE4", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x60010C0")]
				[Address(RVA = "0x23B5BDC", Offset = "0x23B5BDC", VA = "0x23B5BDC")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000245")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000CBE")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000CBF")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000481")]
				public override int buttonCount
				{
					[Token(Token = "0x60010C1")]
					[Address(RVA = "0x23B55C0", Offset = "0x23B55C0", VA = "0x23B55C0", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000482")]
				public override int axisCount
				{
					[Token(Token = "0x60010C2")]
					[Address(RVA = "0x23B55D8", Offset = "0x23B55D8", VA = "0x23B55D8", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60010C3")]
				[Address(RVA = "0x23B55F0", Offset = "0x23B55F0", VA = "0x23B55F0", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x60010C4")]
				[Address(RVA = "0x23B5714", Offset = "0x23B5714", VA = "0x23B5714", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x60010C5")]
				[Address(RVA = "0x23B5848", Offset = "0x23B5848", VA = "0x23B5848", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60010C6")]
				[Address(RVA = "0x23B58C8", Offset = "0x23B58C8", VA = "0x23B58C8", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x60010C7")]
				[Address(RVA = "0x23B58C0", Offset = "0x23B58C0", VA = "0x23B58C0")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000246")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x60010C8")]
				[Address(RVA = "0x23B54E8", Offset = "0x23B54E8", VA = "0x23B54E8", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60010C9")]
				[Address(RVA = "0x23B5568", Offset = "0x23B5568", VA = "0x23B5568", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60010CA")]
				[Address(RVA = "0x23B5560", Offset = "0x23B5560", VA = "0x23B5560")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000247")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x60010CB")]
				[Address(RVA = "0x23B5410", Offset = "0x23B5410", VA = "0x23B5410", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60010CC")]
				[Address(RVA = "0x23B5490", Offset = "0x23B5490", VA = "0x23B5490", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60010CD")]
				[Address(RVA = "0x23B5488", Offset = "0x23B5488", VA = "0x23B5488")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1917FC", Offset = "0x1917FC")]
			private sealed class nswJTcZxyEtFZWjiBxgkqastaQns : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000CC0")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CC1")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CC2")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CC3")]
				[FieldOffset(Offset = "0x28")]
				public Platform_XboxOne_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CC4")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000483")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x60010D1")]
					[Address(RVA = "0x23B5E00", Offset = "0x23B5E00", VA = "0x23B5E00", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000484")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60010D3")]
					[Address(RVA = "0x23B5E48", Offset = "0x23B5E48", VA = "0x23B5E48", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60010CE")]
				[Address(RVA = "0x23B5CF8", Offset = "0x23B5CF8", VA = "0x23B5CF8")]
				[DebuggerHidden]
				public nswJTcZxyEtFZWjiBxgkqastaQns(int P_0)
				{
				}

				[Token(Token = "0x60010CF")]
				[Address(RVA = "0x23B5D40", Offset = "0x23B5D40", VA = "0x23B5D40", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60010D0")]
				[Address(RVA = "0x23B5D44", Offset = "0x23B5D44", VA = "0x23B5D44", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60010D1")]
				[Address(RVA = "0x23B5E00", Offset = "0x23B5E00", VA = "0x23B5E00", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60010D2")]
				[Address(RVA = "0x23B5E08", Offset = "0x23B5E08", VA = "0x23B5E08", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60010D3")]
				[Address(RVA = "0x23B5E48", Offset = "0x23B5E48", VA = "0x23B5E48", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60010D4")]
				[Address(RVA = "0x23B5E50", Offset = "0x23B5E50", VA = "0x23B5E50", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60010D5")]
				[Address(RVA = "0x23B5F10", Offset = "0x23B5F10", VA = "0x23B5F10", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000249")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19180C", Offset = "0x19180C")]
			private sealed class uqwHSeqfLlexLUFLnMXUlAEtjIzk : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000CC5")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CC6")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CC7")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CC8")]
				[FieldOffset(Offset = "0x28")]
				public Platform_XboxOne_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CC9")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000485")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x60010D9")]
					[Address(RVA = "0x23B601C", Offset = "0x23B601C", VA = "0x23B601C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000486")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60010DB")]
					[Address(RVA = "0x23B6064", Offset = "0x23B6064", VA = "0x23B6064", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60010D6")]
				[Address(RVA = "0x23B5F14", Offset = "0x23B5F14", VA = "0x23B5F14")]
				[DebuggerHidden]
				public uqwHSeqfLlexLUFLnMXUlAEtjIzk(int P_0)
				{
				}

				[Token(Token = "0x60010D7")]
				[Address(RVA = "0x23B5F5C", Offset = "0x23B5F5C", VA = "0x23B5F5C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60010D8")]
				[Address(RVA = "0x23B5F60", Offset = "0x23B5F60", VA = "0x23B5F60", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60010D9")]
				[Address(RVA = "0x23B601C", Offset = "0x23B601C", VA = "0x23B601C", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60010DA")]
				[Address(RVA = "0x23B6024", Offset = "0x23B6024", VA = "0x23B6024", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60010DB")]
				[Address(RVA = "0x23B6064", Offset = "0x23B6064", VA = "0x23B6064", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60010DC")]
				[Address(RVA = "0x23B606C", Offset = "0x23B606C", VA = "0x23B606C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60010DD")]
				[Address(RVA = "0x23B612C", Offset = "0x23B612C", VA = "0x23B612C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000CB8")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000CB9")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000CBA")]
			[FieldOffset(Offset = "0x28")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000CBB")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x17000474")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x60010A3")]
				[Address(RVA = "0x24867F0", Offset = "0x24867F0", VA = "0x24867F0", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000475")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x60010A4")]
				[Address(RVA = "0x2486808", Offset = "0x2486808", VA = "0x2486808", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000476")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x60010A5")]
				[Address(RVA = "0x2486820", Offset = "0x2486820", VA = "0x2486820", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000477")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x60010A6")]
				[Address(RVA = "0x2486828", Offset = "0x2486828", VA = "0x2486828", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000478")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x60010A7")]
				[Address(RVA = "0x2486954", Offset = "0x2486954", VA = "0x2486954", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000479")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x60010A8")]
				[Address(RVA = "0x248693C", Offset = "0x248693C", VA = "0x248693C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700047A")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x60010A9")]
				[Address(RVA = "0x2486A68", Offset = "0x2486A68", VA = "0x2486A68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700047B")]
			internal override bool hasData
			{
				[Token(Token = "0x60010AA")]
				[Address(RVA = "0x2486A80", Offset = "0x2486A80", VA = "0x2486A80", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700047C")]
			internal override bool disabled
			{
				[Token(Token = "0x60010AB")]
				[Address(RVA = "0x2486AE0", Offset = "0x2486AE0", VA = "0x2486AE0", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700047D")]
			internal override bool isAllowed
			{
				[Token(Token = "0x60010AC")]
				[Address(RVA = "0x2486AF4", Offset = "0x2486AF4", VA = "0x2486AF4", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700047E")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60010AD")]
				[Address(RVA = "0x2486B3C", Offset = "0x2486B3C", VA = "0x2486B3C", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x2486520", Offset = "0x2486520", VA = "0x2486520", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x2486B44", Offset = "0x2486B44", VA = "0x2486B44", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x2486BB8", Offset = "0x2486BB8", VA = "0x2486BB8", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x60010B1")]
			[Address(RVA = "0x2486C2C", Offset = "0x2486C2C", VA = "0x2486C2C", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x60010B2")]
			[Address(RVA = "0x24872B0", Offset = "0x24872B0", VA = "0x24872B0", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x24879BC", Offset = "0x24879BC", VA = "0x24879BC", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x2487C08", Offset = "0x2487C08", VA = "0x2487C08", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x2487F1C", Offset = "0x2487F1C", VA = "0x2487F1C", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x60010B6")]
			[Address(RVA = "0x24880B4", Offset = "0x24880B4", VA = "0x24880B4", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x60010B7")]
			[Address(RVA = "0x24880CC", Offset = "0x24880CC", VA = "0x24880CC", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x24880E8", Offset = "0x24880E8", VA = "0x24880E8", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60010B9")]
			[Address(RVA = "0x24866C0", Offset = "0x24866C0", VA = "0x24866C0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x24867E8", Offset = "0x24867E8", VA = "0x24867E8")]
			public Platform_XboxOne_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200024A")]
		public sealed class Platform_XboxOne : Platform_XboxOne_Base
		{
			[Token(Token = "0x4000CCA")]
			[FieldOffset(Offset = "0x38")]
			public Platform_XboxOne_Base[] variants;

			[Token(Token = "0x17000487")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60010DE")]
				[Address(RVA = "0x248640C", Offset = "0x248640C", VA = "0x248640C", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60010DF")]
			[Address(RVA = "0x2486414", Offset = "0x2486414", VA = "0x2486414", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60010E0")]
			[Address(RVA = "0x248656C", Offset = "0x248656C", VA = "0x248656C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x24865F0", Offset = "0x24865F0", VA = "0x24865F0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x24865E8", Offset = "0x24865E8", VA = "0x24865E8")]
			public Platform_XboxOne()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200024B")]
		public class Platform_PS4_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x200024C")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000CCF")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000CD0")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x17000493")]
				internal override bool hasData
				{
					[Token(Token = "0x60010FB")]
					[Address(RVA = "0x23ADD04", Offset = "0x23ADD04", VA = "0x23ADD04", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000494")]
				internal override bool isAllowed
				{
					[Token(Token = "0x60010FC")]
					[Address(RVA = "0x23ADD34", Offset = "0x23ADD34", VA = "0x23ADD34", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60010FD")]
				[Address(RVA = "0x23ADD70", Offset = "0x23ADD70", VA = "0x23ADD70", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x60010FE")]
				[Address(RVA = "0x23ADEE0", Offset = "0x23ADEE0", VA = "0x23ADEE0", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60010FF")]
				[Address(RVA = "0x23ADF60", Offset = "0x23ADF60", VA = "0x23ADF60", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001100")]
				[Address(RVA = "0x23ADF58", Offset = "0x23ADF58", VA = "0x23ADF58")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200024D")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000CD1")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000CD2")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000495")]
				public override int buttonCount
				{
					[Token(Token = "0x6001101")]
					[Address(RVA = "0x23AD93C", Offset = "0x23AD93C", VA = "0x23AD93C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000496")]
				public override int axisCount
				{
					[Token(Token = "0x6001102")]
					[Address(RVA = "0x23AD954", Offset = "0x23AD954", VA = "0x23AD954", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001103")]
				[Address(RVA = "0x23AD96C", Offset = "0x23AD96C", VA = "0x23AD96C", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6001104")]
				[Address(RVA = "0x23ADA90", Offset = "0x23ADA90", VA = "0x23ADA90", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6001105")]
				[Address(RVA = "0x23ADBC4", Offset = "0x23ADBC4", VA = "0x23ADBC4", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001106")]
				[Address(RVA = "0x23ADC44", Offset = "0x23ADC44", VA = "0x23ADC44", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6001107")]
				[Address(RVA = "0x23ADC3C", Offset = "0x23ADC3C", VA = "0x23ADC3C")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200024E")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x6001108")]
				[Address(RVA = "0x23AD864", Offset = "0x23AD864", VA = "0x23AD864", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001109")]
				[Address(RVA = "0x23AD8E4", Offset = "0x23AD8E4", VA = "0x23AD8E4", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600110A")]
				[Address(RVA = "0x23AD8DC", Offset = "0x23AD8DC", VA = "0x23AD8DC")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200024F")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x600110B")]
				[Address(RVA = "0x23AD78C", Offset = "0x23AD78C", VA = "0x23AD78C", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600110C")]
				[Address(RVA = "0x23AD80C", Offset = "0x23AD80C", VA = "0x23AD80C", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600110D")]
				[Address(RVA = "0x23AD804", Offset = "0x23AD804", VA = "0x23AD804")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19181C", Offset = "0x19181C")]
			private sealed class PwiAPBBqUhgCOgcWseteZLtJqlCkA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000CD3")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CD4")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CD5")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CD6")]
				[FieldOffset(Offset = "0x28")]
				public Platform_PS4_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CD7")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000497")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6001111")]
					[Address(RVA = "0x23AE17C", Offset = "0x23AE17C", VA = "0x23AE17C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000498")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001113")]
					[Address(RVA = "0x23AE1C4", Offset = "0x23AE1C4", VA = "0x23AE1C4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600110E")]
				[Address(RVA = "0x23AE074", Offset = "0x23AE074", VA = "0x23AE074")]
				[DebuggerHidden]
				public PwiAPBBqUhgCOgcWseteZLtJqlCkA(int P_0)
				{
				}

				[Token(Token = "0x600110F")]
				[Address(RVA = "0x23AE0BC", Offset = "0x23AE0BC", VA = "0x23AE0BC", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001110")]
				[Address(RVA = "0x23AE0C0", Offset = "0x23AE0C0", VA = "0x23AE0C0", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001111")]
				[Address(RVA = "0x23AE17C", Offset = "0x23AE17C", VA = "0x23AE17C", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001112")]
				[Address(RVA = "0x23AE184", Offset = "0x23AE184", VA = "0x23AE184", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001113")]
				[Address(RVA = "0x23AE1C4", Offset = "0x23AE1C4", VA = "0x23AE1C4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001114")]
				[Address(RVA = "0x23AE1CC", Offset = "0x23AE1CC", VA = "0x23AE1CC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001115")]
				[Address(RVA = "0x23AE28C", Offset = "0x23AE28C", VA = "0x23AE28C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000251")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19182C", Offset = "0x19182C")]
			private sealed class AtmSCDyHjwSyzcWcPKehEtnzGcaN : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000CD8")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CD9")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CDA")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CDB")]
				[FieldOffset(Offset = "0x28")]
				public Platform_PS4_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CDC")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000499")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6001119")]
					[Address(RVA = "0x23AD678", Offset = "0x23AD678", VA = "0x23AD678", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700049A")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600111B")]
					[Address(RVA = "0x23AD6C0", Offset = "0x23AD6C0", VA = "0x23AD6C0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001116")]
				[Address(RVA = "0x23AD570", Offset = "0x23AD570", VA = "0x23AD570")]
				[DebuggerHidden]
				public AtmSCDyHjwSyzcWcPKehEtnzGcaN(int P_0)
				{
				}

				[Token(Token = "0x6001117")]
				[Address(RVA = "0x23AD5B8", Offset = "0x23AD5B8", VA = "0x23AD5B8", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001118")]
				[Address(RVA = "0x23AD5BC", Offset = "0x23AD5BC", VA = "0x23AD5BC", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001119")]
				[Address(RVA = "0x23AD678", Offset = "0x23AD678", VA = "0x23AD678", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600111A")]
				[Address(RVA = "0x23AD680", Offset = "0x23AD680", VA = "0x23AD680", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600111B")]
				[Address(RVA = "0x23AD6C0", Offset = "0x23AD6C0", VA = "0x23AD6C0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600111C")]
				[Address(RVA = "0x23AD6C8", Offset = "0x23AD6C8", VA = "0x23AD6C8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600111D")]
				[Address(RVA = "0x23AD788", Offset = "0x23AD788", VA = "0x23AD788", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000CCB")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000CCC")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000CCD")]
			[FieldOffset(Offset = "0x28")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000CCE")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x17000488")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x60010E3")]
				[Address(RVA = "0x2478544", Offset = "0x2478544", VA = "0x2478544", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000489")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x60010E4")]
				[Address(RVA = "0x247855C", Offset = "0x247855C", VA = "0x247855C", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700048A")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x60010E5")]
				[Address(RVA = "0x2478574", Offset = "0x2478574", VA = "0x2478574", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700048B")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x60010E6")]
				[Address(RVA = "0x247857C", Offset = "0x247857C", VA = "0x247857C", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048C")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x60010E7")]
				[Address(RVA = "0x24786A8", Offset = "0x24786A8", VA = "0x24786A8", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048D")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x60010E8")]
				[Address(RVA = "0x2478690", Offset = "0x2478690", VA = "0x2478690")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048E")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x60010E9")]
				[Address(RVA = "0x24787BC", Offset = "0x24787BC", VA = "0x24787BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700048F")]
			internal override bool hasData
			{
				[Token(Token = "0x60010EA")]
				[Address(RVA = "0x24787D4", Offset = "0x24787D4", VA = "0x24787D4", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000490")]
			internal override bool disabled
			{
				[Token(Token = "0x60010EB")]
				[Address(RVA = "0x2478834", Offset = "0x2478834", VA = "0x2478834", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000491")]
			internal override bool isAllowed
			{
				[Token(Token = "0x60010EC")]
				[Address(RVA = "0x2478848", Offset = "0x2478848", VA = "0x2478848", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000492")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60010ED")]
				[Address(RVA = "0x24788C8", Offset = "0x24788C8", VA = "0x24788C8", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60010EE")]
			[Address(RVA = "0x2478284", Offset = "0x2478284", VA = "0x2478284", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x24788D0", Offset = "0x24788D0", VA = "0x24788D0", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x60010F0")]
			[Address(RVA = "0x2478944", Offset = "0x2478944", VA = "0x2478944", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x60010F1")]
			[Address(RVA = "0x24789B8", Offset = "0x24789B8", VA = "0x24789B8", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x60010F2")]
			[Address(RVA = "0x247903C", Offset = "0x247903C", VA = "0x247903C", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x60010F3")]
			[Address(RVA = "0x2479748", Offset = "0x2479748", VA = "0x2479748", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x60010F4")]
			[Address(RVA = "0x2479990", Offset = "0x2479990", VA = "0x2479990", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x60010F5")]
			[Address(RVA = "0x2479CA4", Offset = "0x2479CA4", VA = "0x2479CA4", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x2479E3C", Offset = "0x2479E3C", VA = "0x2479E3C", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x60010F7")]
			[Address(RVA = "0x2479E54", Offset = "0x2479E54", VA = "0x2479E54", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x60010F8")]
			[Address(RVA = "0x2479E70", Offset = "0x2479E70", VA = "0x2479E70", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60010F9")]
			[Address(RVA = "0x2478424", Offset = "0x2478424", VA = "0x2478424", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x247853C", Offset = "0x247853C", VA = "0x247853C")]
			public Platform_PS4_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000252")]
		public sealed class Platform_PS4 : Platform_PS4_Base
		{
			[Token(Token = "0x4000CDD")]
			[FieldOffset(Offset = "0x38")]
			public Platform_PS4_Base[] variants;

			[Token(Token = "0x1700049B")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x600111E")]
				[Address(RVA = "0x2478170", Offset = "0x2478170", VA = "0x2478170", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600111F")]
			[Address(RVA = "0x2478178", Offset = "0x2478178", VA = "0x2478178", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001120")]
			[Address(RVA = "0x24782D0", Offset = "0x24782D0", VA = "0x24782D0", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001121")]
			[Address(RVA = "0x2478354", Offset = "0x2478354", VA = "0x2478354", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001122")]
			[Address(RVA = "0x247834C", Offset = "0x247834C", VA = "0x247834C")]
			public Platform_PS4()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000253")]
		public class Platform_NintendoSwitch_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x2000254")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000CE2")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000CE3")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x170004A7")]
				internal override bool hasData
				{
					[Token(Token = "0x600113B")]
					[Address(RVA = "0x23ABD08", Offset = "0x23ABD08", VA = "0x23ABD08", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004A8")]
				internal override bool isAllowed
				{
					[Token(Token = "0x600113C")]
					[Address(RVA = "0x23ABD38", Offset = "0x23ABD38", VA = "0x23ABD38", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600113D")]
				[Address(RVA = "0x23ABD74", Offset = "0x23ABD74", VA = "0x23ABD74", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x600113E")]
				[Address(RVA = "0x23ABEE4", Offset = "0x23ABEE4", VA = "0x23ABEE4", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600113F")]
				[Address(RVA = "0x23ABF64", Offset = "0x23ABF64", VA = "0x23ABF64", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001140")]
				[Address(RVA = "0x23ABF5C", Offset = "0x23ABF5C", VA = "0x23ABF5C")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000255")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000CE4")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000CE5")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x170004A9")]
				public override int buttonCount
				{
					[Token(Token = "0x6001141")]
					[Address(RVA = "0x23AB940", Offset = "0x23AB940", VA = "0x23AB940", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004AA")]
				public override int axisCount
				{
					[Token(Token = "0x6001142")]
					[Address(RVA = "0x23AB958", Offset = "0x23AB958", VA = "0x23AB958", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001143")]
				[Address(RVA = "0x23AB970", Offset = "0x23AB970", VA = "0x23AB970", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6001144")]
				[Address(RVA = "0x23ABA94", Offset = "0x23ABA94", VA = "0x23ABA94", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6001145")]
				[Address(RVA = "0x23ABBC8", Offset = "0x23ABBC8", VA = "0x23ABBC8", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001146")]
				[Address(RVA = "0x23ABC48", Offset = "0x23ABC48", VA = "0x23ABC48", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6001147")]
				[Address(RVA = "0x23ABC40", Offset = "0x23ABC40", VA = "0x23ABC40")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000256")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x6001148")]
				[Address(RVA = "0x23AB868", Offset = "0x23AB868", VA = "0x23AB868", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001149")]
				[Address(RVA = "0x23AB8E8", Offset = "0x23AB8E8", VA = "0x23AB8E8", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600114A")]
				[Address(RVA = "0x23AB8E0", Offset = "0x23AB8E0", VA = "0x23AB8E0")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000257")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x600114B")]
				[Address(RVA = "0x23AB790", Offset = "0x23AB790", VA = "0x23AB790", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600114C")]
				[Address(RVA = "0x23AB810", Offset = "0x23AB810", VA = "0x23AB810", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600114D")]
				[Address(RVA = "0x23AB808", Offset = "0x23AB808", VA = "0x23AB808")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19183C", Offset = "0x19183C")]
			private sealed class agqvkkJwvSNalYXiVHOnoZKKtvPh : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000CE6")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CE7")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CE8")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CE9")]
				[FieldOffset(Offset = "0x28")]
				public Platform_NintendoSwitch_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CEA")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004AB")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6001151")]
					[Address(RVA = "0x23AC180", Offset = "0x23AC180", VA = "0x23AC180", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004AC")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001153")]
					[Address(RVA = "0x23AC1C8", Offset = "0x23AC1C8", VA = "0x23AC1C8", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600114E")]
				[Address(RVA = "0x23AC078", Offset = "0x23AC078", VA = "0x23AC078")]
				[DebuggerHidden]
				public agqvkkJwvSNalYXiVHOnoZKKtvPh(int P_0)
				{
				}

				[Token(Token = "0x600114F")]
				[Address(RVA = "0x23AC0C0", Offset = "0x23AC0C0", VA = "0x23AC0C0", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001150")]
				[Address(RVA = "0x23AC0C4", Offset = "0x23AC0C4", VA = "0x23AC0C4", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001151")]
				[Address(RVA = "0x23AC180", Offset = "0x23AC180", VA = "0x23AC180", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001152")]
				[Address(RVA = "0x23AC188", Offset = "0x23AC188", VA = "0x23AC188", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001153")]
				[Address(RVA = "0x23AC1C8", Offset = "0x23AC1C8", VA = "0x23AC1C8", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001154")]
				[Address(RVA = "0x23AC1D0", Offset = "0x23AC1D0", VA = "0x23AC1D0", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001155")]
				[Address(RVA = "0x23AC290", Offset = "0x23AC290", VA = "0x23AC290", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000259")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19184C", Offset = "0x19184C")]
			private sealed class uHRIjznIexJVWkzEpFhqYjAnjoAe : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000CEB")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CEC")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CED")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CEE")]
				[FieldOffset(Offset = "0x28")]
				public Platform_NintendoSwitch_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CEF")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004AD")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6001159")]
					[Address(RVA = "0x23AC39C", Offset = "0x23AC39C", VA = "0x23AC39C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004AE")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600115B")]
					[Address(RVA = "0x23AC3E4", Offset = "0x23AC3E4", VA = "0x23AC3E4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001156")]
				[Address(RVA = "0x23AC294", Offset = "0x23AC294", VA = "0x23AC294")]
				[DebuggerHidden]
				public uHRIjznIexJVWkzEpFhqYjAnjoAe(int P_0)
				{
				}

				[Token(Token = "0x6001157")]
				[Address(RVA = "0x23AC2DC", Offset = "0x23AC2DC", VA = "0x23AC2DC", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001158")]
				[Address(RVA = "0x23AC2E0", Offset = "0x23AC2E0", VA = "0x23AC2E0", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001159")]
				[Address(RVA = "0x23AC39C", Offset = "0x23AC39C", VA = "0x23AC39C", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600115A")]
				[Address(RVA = "0x23AC3A4", Offset = "0x23AC3A4", VA = "0x23AC3A4", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600115B")]
				[Address(RVA = "0x23AC3E4", Offset = "0x23AC3E4", VA = "0x23AC3E4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600115C")]
				[Address(RVA = "0x23AC3EC", Offset = "0x23AC3EC", VA = "0x23AC3EC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600115D")]
				[Address(RVA = "0x23AC4AC", Offset = "0x23AC4AC", VA = "0x23AC4AC", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000CDE")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000CDF")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000CE0")]
			[FieldOffset(Offset = "0x28")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000CE1")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x1700049C")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6001123")]
				[Address(RVA = "0x2474C50", Offset = "0x2474C50", VA = "0x2474C50", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700049D")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6001124")]
				[Address(RVA = "0x2474C68", Offset = "0x2474C68", VA = "0x2474C68", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700049E")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6001125")]
				[Address(RVA = "0x2474C80", Offset = "0x2474C80", VA = "0x2474C80", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700049F")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x6001126")]
				[Address(RVA = "0x2474C88", Offset = "0x2474C88", VA = "0x2474C88", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004A0")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x6001127")]
				[Address(RVA = "0x2474DB4", Offset = "0x2474DB4", VA = "0x2474DB4", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004A1")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6001128")]
				[Address(RVA = "0x2474D9C", Offset = "0x2474D9C", VA = "0x2474D9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004A2")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6001129")]
				[Address(RVA = "0x2474EC8", Offset = "0x2474EC8", VA = "0x2474EC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004A3")]
			internal override bool hasData
			{
				[Token(Token = "0x600112A")]
				[Address(RVA = "0x2474EE0", Offset = "0x2474EE0", VA = "0x2474EE0", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004A4")]
			internal override bool disabled
			{
				[Token(Token = "0x600112B")]
				[Address(RVA = "0x2474F40", Offset = "0x2474F40", VA = "0x2474F40", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004A5")]
			internal override bool isAllowed
			{
				[Token(Token = "0x600112C")]
				[Address(RVA = "0x2474F54", Offset = "0x2474F54", VA = "0x2474F54", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004A6")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x600112D")]
				[Address(RVA = "0x2474FD4", Offset = "0x2474FD4", VA = "0x2474FD4", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600112E")]
			[Address(RVA = "0x2474990", Offset = "0x2474990", VA = "0x2474990", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x600112F")]
			[Address(RVA = "0x2474FDC", Offset = "0x2474FDC", VA = "0x2474FDC", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6001130")]
			[Address(RVA = "0x2475050", Offset = "0x2475050", VA = "0x2475050", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6001131")]
			[Address(RVA = "0x24750C4", Offset = "0x24750C4", VA = "0x24750C4", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001132")]
			[Address(RVA = "0x2475748", Offset = "0x2475748", VA = "0x2475748", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6001133")]
			[Address(RVA = "0x2475E54", Offset = "0x2475E54", VA = "0x2475E54", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6001134")]
			[Address(RVA = "0x247609C", Offset = "0x247609C", VA = "0x247609C", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6001135")]
			[Address(RVA = "0x24763B0", Offset = "0x24763B0", VA = "0x24763B0", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6001136")]
			[Address(RVA = "0x2476548", Offset = "0x2476548", VA = "0x2476548", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6001137")]
			[Address(RVA = "0x2476560", Offset = "0x2476560", VA = "0x2476560", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6001138")]
			[Address(RVA = "0x247657C", Offset = "0x247657C", VA = "0x247657C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001139")]
			[Address(RVA = "0x2474B30", Offset = "0x2474B30", VA = "0x2474B30", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600113A")]
			[Address(RVA = "0x2474C48", Offset = "0x2474C48", VA = "0x2474C48")]
			public Platform_NintendoSwitch_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200025A")]
		public sealed class Platform_NintendoSwitch : Platform_NintendoSwitch_Base
		{
			[Token(Token = "0x4000CF0")]
			[FieldOffset(Offset = "0x38")]
			public Platform_NintendoSwitch_Base[] variants;

			[Token(Token = "0x170004AF")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x600115E")]
				[Address(RVA = "0x247487C", Offset = "0x247487C", VA = "0x247487C", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600115F")]
			[Address(RVA = "0x2474884", Offset = "0x2474884", VA = "0x2474884", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001160")]
			[Address(RVA = "0x24749DC", Offset = "0x24749DC", VA = "0x24749DC", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001161")]
			[Address(RVA = "0x2474A60", Offset = "0x2474A60", VA = "0x2474A60", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001162")]
			[Address(RVA = "0x2474A58", Offset = "0x2474A58", VA = "0x2474A58")]
			public Platform_NintendoSwitch()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200025B")]
		public class Platform_Stadia_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x200025C")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000CF6")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000CF7")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x170004BC")]
				internal override bool hasData
				{
					[Token(Token = "0x600117C")]
					[Address(RVA = "0x23B1910", Offset = "0x23B1910", VA = "0x23B1910", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004BD")]
				internal override bool isAllowed
				{
					[Token(Token = "0x600117D")]
					[Address(RVA = "0x23B1940", Offset = "0x23B1940", VA = "0x23B1940", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600117E")]
				[Address(RVA = "0x23B197C", Offset = "0x23B197C", VA = "0x23B197C", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x600117F")]
				[Address(RVA = "0x23B1AEC", Offset = "0x23B1AEC", VA = "0x23B1AEC", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001180")]
				[Address(RVA = "0x23B1B6C", Offset = "0x23B1B6C", VA = "0x23B1B6C", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001181")]
				[Address(RVA = "0x23B1B64", Offset = "0x23B1B64", VA = "0x23B1B64")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200025D")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000CF8")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000CF9")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x170004BE")]
				public override int buttonCount
				{
					[Token(Token = "0x6001182")]
					[Address(RVA = "0x23B132C", Offset = "0x23B132C", VA = "0x23B132C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004BF")]
				public override int axisCount
				{
					[Token(Token = "0x6001183")]
					[Address(RVA = "0x23B1344", Offset = "0x23B1344", VA = "0x23B1344", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001184")]
				[Address(RVA = "0x23B135C", Offset = "0x23B135C", VA = "0x23B135C", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6001185")]
				[Address(RVA = "0x23B1480", Offset = "0x23B1480", VA = "0x23B1480", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6001186")]
				[Address(RVA = "0x23B15B4", Offset = "0x23B15B4", VA = "0x23B15B4", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001187")]
				[Address(RVA = "0x23B1634", Offset = "0x23B1634", VA = "0x23B1634", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6001188")]
				[Address(RVA = "0x23B162C", Offset = "0x23B162C", VA = "0x23B162C")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200025E")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x6001189")]
				[Address(RVA = "0x23B1254", Offset = "0x23B1254", VA = "0x23B1254", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600118A")]
				[Address(RVA = "0x23B12D4", Offset = "0x23B12D4", VA = "0x23B12D4", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600118B")]
				[Address(RVA = "0x23B12CC", Offset = "0x23B12CC", VA = "0x23B12CC")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200025F")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x600118C")]
				[Address(RVA = "0x23B117C", Offset = "0x23B117C", VA = "0x23B117C", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600118D")]
				[Address(RVA = "0x23B11FC", Offset = "0x23B11FC", VA = "0x23B11FC", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x600118E")]
				[Address(RVA = "0x23B11F4", Offset = "0x23B11F4", VA = "0x23B11F4")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19185C", Offset = "0x19185C")]
			private sealed class JCNqUQOHmIdxmSwEIAMkxJzPbMciA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000CFA")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000CFB")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000CFC")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000CFD")]
				[FieldOffset(Offset = "0x28")]
				public Platform_Stadia_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000CFE")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004C0")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6001192")]
					[Address(RVA = "0x23B17FC", Offset = "0x23B17FC", VA = "0x23B17FC", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004C1")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001194")]
					[Address(RVA = "0x23B1844", Offset = "0x23B1844", VA = "0x23B1844", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600118F")]
				[Address(RVA = "0x23B16F4", Offset = "0x23B16F4", VA = "0x23B16F4")]
				[DebuggerHidden]
				public JCNqUQOHmIdxmSwEIAMkxJzPbMciA(int P_0)
				{
				}

				[Token(Token = "0x6001190")]
				[Address(RVA = "0x23B173C", Offset = "0x23B173C", VA = "0x23B173C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001191")]
				[Address(RVA = "0x23B1740", Offset = "0x23B1740", VA = "0x23B1740", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001192")]
				[Address(RVA = "0x23B17FC", Offset = "0x23B17FC", VA = "0x23B17FC", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001193")]
				[Address(RVA = "0x23B1804", Offset = "0x23B1804", VA = "0x23B1804", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001194")]
				[Address(RVA = "0x23B1844", Offset = "0x23B1844", VA = "0x23B1844", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001195")]
				[Address(RVA = "0x23B184C", Offset = "0x23B184C", VA = "0x23B184C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001196")]
				[Address(RVA = "0x23B190C", Offset = "0x23B190C", VA = "0x23B190C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000261")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19186C", Offset = "0x19186C")]
			private sealed class zklsVfWlglblHwVpcSYuDTHQvMTk : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000CFF")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D00")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D01")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D02")]
				[FieldOffset(Offset = "0x28")]
				public Platform_Stadia_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D03")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004C2")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x600119A")]
					[Address(RVA = "0x23B1D88", Offset = "0x23B1D88", VA = "0x23B1D88", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004C3")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600119C")]
					[Address(RVA = "0x23B1DD0", Offset = "0x23B1DD0", VA = "0x23B1DD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001197")]
				[Address(RVA = "0x23B1C80", Offset = "0x23B1C80", VA = "0x23B1C80")]
				[DebuggerHidden]
				public zklsVfWlglblHwVpcSYuDTHQvMTk(int P_0)
				{
				}

				[Token(Token = "0x6001198")]
				[Address(RVA = "0x23B1CC8", Offset = "0x23B1CC8", VA = "0x23B1CC8", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001199")]
				[Address(RVA = "0x23B1CCC", Offset = "0x23B1CCC", VA = "0x23B1CCC", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600119A")]
				[Address(RVA = "0x23B1D88", Offset = "0x23B1D88", VA = "0x23B1D88", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600119B")]
				[Address(RVA = "0x23B1D90", Offset = "0x23B1D90", VA = "0x23B1D90", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600119C")]
				[Address(RVA = "0x23B1DD0", Offset = "0x23B1DD0", VA = "0x23B1DD0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600119D")]
				[Address(RVA = "0x23B1DD8", Offset = "0x23B1DD8", VA = "0x23B1DD8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600119E")]
				[Address(RVA = "0x23B1E98", Offset = "0x23B1E98", VA = "0x23B1E98", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000CF1")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000CF2")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000CF3")]
			[FieldOffset(Offset = "0x28")]
			public string controllerName;

			[Token(Token = "0x4000CF4")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000CF5")]
			[FieldOffset(Offset = "0x38")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x170004B0")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6001163")]
				[Address(RVA = "0x247F730", Offset = "0x247F730", VA = "0x247F730", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004B1")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6001164")]
				[Address(RVA = "0x247F748", Offset = "0x247F748", VA = "0x247F748", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004B2")]
			public override string controllerNameOverride
			{
				[Token(Token = "0x6001165")]
				[Address(RVA = "0x247F760", Offset = "0x247F760", VA = "0x247F760", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B3")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x6001166")]
				[Address(RVA = "0x247F768", Offset = "0x247F768", VA = "0x247F768", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004B4")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x6001167")]
				[Address(RVA = "0x247F770", Offset = "0x247F770", VA = "0x247F770", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B5")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x6001168")]
				[Address(RVA = "0x247F89C", Offset = "0x247F89C", VA = "0x247F89C", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B6")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6001169")]
				[Address(RVA = "0x247F884", Offset = "0x247F884", VA = "0x247F884")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B7")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x600116A")]
				[Address(RVA = "0x247F9B0", Offset = "0x247F9B0", VA = "0x247F9B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B8")]
			internal override bool hasData
			{
				[Token(Token = "0x600116B")]
				[Address(RVA = "0x247F9C8", Offset = "0x247F9C8", VA = "0x247F9C8", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004B9")]
			internal override bool disabled
			{
				[Token(Token = "0x600116C")]
				[Address(RVA = "0x247FA28", Offset = "0x247FA28", VA = "0x247FA28", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004BA")]
			internal override bool isAllowed
			{
				[Token(Token = "0x600116D")]
				[Address(RVA = "0x247FA3C", Offset = "0x247FA3C", VA = "0x247FA3C", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004BB")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x600116E")]
				[Address(RVA = "0x247FA84", Offset = "0x247FA84", VA = "0x247FA84", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600116F")]
			[Address(RVA = "0x247F45C", Offset = "0x247F45C", VA = "0x247F45C", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001170")]
			[Address(RVA = "0x247FA8C", Offset = "0x247FA8C", VA = "0x247FA8C", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6001171")]
			[Address(RVA = "0x247FB00", Offset = "0x247FB00", VA = "0x247FB00", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6001172")]
			[Address(RVA = "0x247FB74", Offset = "0x247FB74", VA = "0x247FB74", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001173")]
			[Address(RVA = "0x24801F8", Offset = "0x24801F8", VA = "0x24801F8", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6001174")]
			[Address(RVA = "0x2480904", Offset = "0x2480904", VA = "0x2480904", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6001175")]
			[Address(RVA = "0x2480B50", Offset = "0x2480B50", VA = "0x2480B50", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6001176")]
			[Address(RVA = "0x2480E64", Offset = "0x2480E64", VA = "0x2480E64", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x6001177")]
			[Address(RVA = "0x2480FFC", Offset = "0x2480FFC", VA = "0x2480FFC", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x6001178")]
			[Address(RVA = "0x2481014", Offset = "0x2481014", VA = "0x2481014", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x6001179")]
			[Address(RVA = "0x2481030", Offset = "0x2481030", VA = "0x2481030", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x600117A")]
			[Address(RVA = "0x247F5FC", Offset = "0x247F5FC", VA = "0x247F5FC", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600117B")]
			[Address(RVA = "0x247F728", Offset = "0x247F728", VA = "0x247F728")]
			public Platform_Stadia_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000262")]
		public sealed class Platform_Stadia : Platform_Stadia_Base
		{
			[Token(Token = "0x4000D04")]
			[FieldOffset(Offset = "0x40")]
			public Platform_Stadia_Base[] variants;

			[Token(Token = "0x170004C4")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x600119F")]
				[Address(RVA = "0x247F348", Offset = "0x247F348", VA = "0x247F348", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60011A0")]
			[Address(RVA = "0x247F350", Offset = "0x247F350", VA = "0x247F350", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60011A1")]
			[Address(RVA = "0x247F4A8", Offset = "0x247F4A8", VA = "0x247F4A8", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60011A2")]
			[Address(RVA = "0x247F52C", Offset = "0x247F52C", VA = "0x247F52C", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60011A3")]
			[Address(RVA = "0x247F524", Offset = "0x247F524", VA = "0x247F524")]
			public Platform_Stadia()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000263")]
		public class Platform_GameCore_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x2000264")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000D0A")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000D0B")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x4000D0C")]
				[FieldOffset(Offset = "0x38")]
				public VidPid[] vidPid;

				[Token(Token = "0x4000D0D")]
				[FieldOffset(Offset = "0x40")]
				public DeviceType deviceType;

				[Token(Token = "0x4000D0E")]
				[FieldOffset(Offset = "0x44")]
				public GamepadSubType gamepadSubType;

				[Token(Token = "0x4000D0F")]
				[FieldOffset(Offset = "0x48")]
				public int hatCount;

				[Token(Token = "0x170004D1")]
				internal override bool hasData
				{
					[Token(Token = "0x60011BD")]
					[Address(RVA = "0x23A8CC8", Offset = "0x23A8CC8", VA = "0x23A8CC8", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004D2")]
				internal override bool isAllowed
				{
					[Token(Token = "0x60011BE")]
					[Address(RVA = "0x23A8D10", Offset = "0x23A8D10", VA = "0x23A8D10", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60011BF")]
				[Address(RVA = "0x23A8D4C", Offset = "0x23A8D4C", VA = "0x23A8D4C", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x60011C0")]
				[Address(RVA = "0x23A8D9C", Offset = "0x23A8D9C", VA = "0x23A8D9C", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x60011C1")]
				[Address(RVA = "0x23A91FC", Offset = "0x23A91FC", VA = "0x23A91FC", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60011C2")]
				[Address(RVA = "0x23A927C", Offset = "0x23A927C", VA = "0x23A927C", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x60011C3")]
				[Address(RVA = "0x23A90F0", Offset = "0x23A90F0", VA = "0x23A90F0")]
				private bool HasProductName()
				{
					return default;
				}

				[Token(Token = "0x60011C4")]
				[Address(RVA = "0x23A9170", Offset = "0x23A9170", VA = "0x23A9170")]
				private bool ProductNameMatches(string name)
				{
					return default;
				}

				[Token(Token = "0x60011C5")]
				[Address(RVA = "0x23A9274", Offset = "0x23A9274", VA = "0x23A9274")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000265")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000D10")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000D11")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x170004D3")]
				public override int buttonCount
				{
					[Token(Token = "0x60011C6")]
					[Address(RVA = "0x23A88D8", Offset = "0x23A88D8", VA = "0x23A88D8", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004D4")]
				public override int axisCount
				{
					[Token(Token = "0x60011C7")]
					[Address(RVA = "0x23A88F0", Offset = "0x23A88F0", VA = "0x23A88F0", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60011C8")]
				[Address(RVA = "0x23A8908", Offset = "0x23A8908", VA = "0x23A8908", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x60011C9")]
				[Address(RVA = "0x23A8A2C", Offset = "0x23A8A2C", VA = "0x23A8A2C", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x60011CA")]
				[Address(RVA = "0x23A8B88", Offset = "0x23A8B88", VA = "0x23A8B88", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60011CB")]
				[Address(RVA = "0x23A8C08", Offset = "0x23A8C08", VA = "0x23A8C08", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x60011CC")]
				[Address(RVA = "0x23A8C00", Offset = "0x23A8C00", VA = "0x23A8C00")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000266")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x4000D12")]
				[FieldOffset(Offset = "0x60")]
				public int sourceHat;

				[Token(Token = "0x4000D13")]
				[FieldOffset(Offset = "0x64")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000D14")]
				[FieldOffset(Offset = "0x68")]
				public HatType sourceHatType;

				[Token(Token = "0x60011CD")]
				[Address(RVA = "0x23A87C4", Offset = "0x23A87C4", VA = "0x23A87C4", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60011CE")]
				[Address(RVA = "0x23A8844", Offset = "0x23A8844", VA = "0x23A8844", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60011CF")]
				[Address(RVA = "0x23A883C", Offset = "0x23A883C", VA = "0x23A883C")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000267")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x4000D15")]
				[FieldOffset(Offset = "0x68")]
				public int sourceHat;

				[Token(Token = "0x4000D16")]
				[FieldOffset(Offset = "0x6C")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000D17")]
				[FieldOffset(Offset = "0x70")]
				public HatType sourceHatType;

				[Token(Token = "0x4000D18")]
				[FieldOffset(Offset = "0x74")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x60011D0")]
				[Address(RVA = "0x23A86B8", Offset = "0x23A86B8", VA = "0x23A86B8", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60011D1")]
				[Address(RVA = "0x23A8738", Offset = "0x23A8738", VA = "0x23A8738", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60011D2")]
				[Address(RVA = "0x23A8730", Offset = "0x23A8730", VA = "0x23A8730")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000268")]
			public enum DeviceType
			{
				[Token(Token = "0x4000D1A")]
				None = 0,
				[Token(Token = "0x4000D1B")]
				Gamepad = 1,
				[Token(Token = "0x4000D1C")]
				ArcadeStick = 2,
				[Token(Token = "0x4000D1D")]
				FlightStick = 3,
				[Token(Token = "0x4000D1E")]
				RacingWheel = 4,
				[Token(Token = "0x4000D1F")]
				Raw = 6
			}

			[Token(Token = "0x2000269")]
			public enum GamepadSubType
			{
				[Token(Token = "0x4000D21")]
				None = 0,
				[Token(Token = "0x4000D22")]
				Xbox360 = 1,
				[Token(Token = "0x4000D23")]
				XboxOne = 2,
				[Token(Token = "0x4000D24")]
				DualShock = 3,
				[Token(Token = "0x4000D25")]
				NintendoProController = 4,
				[Token(Token = "0x4000D26")]
				Unknown = 1000
			}

			[Token(Token = "0x200026A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19187C", Offset = "0x19187C")]
			private sealed class AFjZbofOGZVKiMjfZGiSkAmWOfXkA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000D27")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D28")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D29")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D2A")]
				[FieldOffset(Offset = "0x28")]
				public Platform_GameCore_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D2B")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004D5")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x60011D6")]
					[Address(RVA = "0x23A85A4", Offset = "0x23A85A4", VA = "0x23A85A4", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004D6")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60011D8")]
					[Address(RVA = "0x23A85EC", Offset = "0x23A85EC", VA = "0x23A85EC", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60011D3")]
				[Address(RVA = "0x23A849C", Offset = "0x23A849C", VA = "0x23A849C")]
				[DebuggerHidden]
				public AFjZbofOGZVKiMjfZGiSkAmWOfXkA(int P_0)
				{
				}

				[Token(Token = "0x60011D4")]
				[Address(RVA = "0x23A84E4", Offset = "0x23A84E4", VA = "0x23A84E4", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60011D5")]
				[Address(RVA = "0x23A84E8", Offset = "0x23A84E8", VA = "0x23A84E8", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60011D6")]
				[Address(RVA = "0x23A85A4", Offset = "0x23A85A4", VA = "0x23A85A4", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60011D7")]
				[Address(RVA = "0x23A85AC", Offset = "0x23A85AC", VA = "0x23A85AC", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60011D8")]
				[Address(RVA = "0x23A85EC", Offset = "0x23A85EC", VA = "0x23A85EC", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60011D9")]
				[Address(RVA = "0x23A85F4", Offset = "0x23A85F4", VA = "0x23A85F4", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60011DA")]
				[Address(RVA = "0x23A86B4", Offset = "0x23A86B4", VA = "0x23A86B4", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x200026B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19188C", Offset = "0x19188C")]
			private sealed class qMBVpSpLRtKOlpgRoFmNaigFdKKxA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000D2C")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D2D")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D2E")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D2F")]
				[FieldOffset(Offset = "0x28")]
				public Platform_GameCore_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D30")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004D7")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x60011DE")]
					[Address(RVA = "0x23A94CC", Offset = "0x23A94CC", VA = "0x23A94CC", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004D8")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60011E0")]
					[Address(RVA = "0x23A9514", Offset = "0x23A9514", VA = "0x23A9514", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60011DB")]
				[Address(RVA = "0x23A93C4", Offset = "0x23A93C4", VA = "0x23A93C4")]
				[DebuggerHidden]
				public qMBVpSpLRtKOlpgRoFmNaigFdKKxA(int P_0)
				{
				}

				[Token(Token = "0x60011DC")]
				[Address(RVA = "0x23A940C", Offset = "0x23A940C", VA = "0x23A940C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60011DD")]
				[Address(RVA = "0x23A9410", Offset = "0x23A9410", VA = "0x23A9410", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60011DE")]
				[Address(RVA = "0x23A94CC", Offset = "0x23A94CC", VA = "0x23A94CC", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60011DF")]
				[Address(RVA = "0x23A94D4", Offset = "0x23A94D4", VA = "0x23A94D4", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60011E0")]
				[Address(RVA = "0x23A9514", Offset = "0x23A9514", VA = "0x23A9514", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60011E1")]
				[Address(RVA = "0x23A951C", Offset = "0x23A951C", VA = "0x23A951C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60011E2")]
				[Address(RVA = "0x23A95DC", Offset = "0x23A95DC", VA = "0x23A95DC", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000D05")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000D06")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000D07")]
			[FieldOffset(Offset = "0x28")]
			public string controllerName;

			[Token(Token = "0x4000D08")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000D09")]
			[FieldOffset(Offset = "0x38")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x170004C5")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x60011A4")]
				[Address(RVA = "0x246F55C", Offset = "0x246F55C", VA = "0x246F55C", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004C6")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x60011A5")]
				[Address(RVA = "0x246F574", Offset = "0x246F574", VA = "0x246F574", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004C7")]
			public override string controllerNameOverride
			{
				[Token(Token = "0x60011A6")]
				[Address(RVA = "0x246F58C", Offset = "0x246F58C", VA = "0x246F58C", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004C8")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x60011A7")]
				[Address(RVA = "0x246F594", Offset = "0x246F594", VA = "0x246F594", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004C9")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x60011A8")]
				[Address(RVA = "0x246F59C", Offset = "0x246F59C", VA = "0x246F59C", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004CA")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x60011A9")]
				[Address(RVA = "0x246F6C8", Offset = "0x246F6C8", VA = "0x246F6C8", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004CB")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x60011AA")]
				[Address(RVA = "0x246F6B0", Offset = "0x246F6B0", VA = "0x246F6B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004CC")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x60011AB")]
				[Address(RVA = "0x246F7DC", Offset = "0x246F7DC", VA = "0x246F7DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004CD")]
			internal override bool hasData
			{
				[Token(Token = "0x60011AC")]
				[Address(RVA = "0x246F7F4", Offset = "0x246F7F4", VA = "0x246F7F4", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004CE")]
			internal override bool disabled
			{
				[Token(Token = "0x60011AD")]
				[Address(RVA = "0x246F854", Offset = "0x246F854", VA = "0x246F854", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004CF")]
			internal override bool isAllowed
			{
				[Token(Token = "0x60011AE")]
				[Address(RVA = "0x246F868", Offset = "0x246F868", VA = "0x246F868", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004D0")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60011AF")]
				[Address(RVA = "0x246F8E8", Offset = "0x246F8E8", VA = "0x246F8E8", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x246EE28", Offset = "0x246EE28", VA = "0x246EE28", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60011B1")]
			[Address(RVA = "0x246F8F0", Offset = "0x246F8F0", VA = "0x246F8F0", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x60011B2")]
			[Address(RVA = "0x246F964", Offset = "0x246F964", VA = "0x246F964", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x60011B3")]
			[Address(RVA = "0x246F9D8", Offset = "0x246F9D8", VA = "0x246F9D8", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x60011B4")]
			[Address(RVA = "0x247005C", Offset = "0x247005C", VA = "0x247005C", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x60011B5")]
			[Address(RVA = "0x2470768", Offset = "0x2470768", VA = "0x2470768", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x60011B6")]
			[Address(RVA = "0x24709C8", Offset = "0x24709C8", VA = "0x24709C8", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x2470D18", Offset = "0x2470D18", VA = "0x2470D18", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x60011B8")]
			[Address(RVA = "0x2470EB0", Offset = "0x2470EB0", VA = "0x2470EB0", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x60011B9")]
			[Address(RVA = "0x2470EC8", Offset = "0x2470EC8", VA = "0x2470EC8", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x60011BA")]
			[Address(RVA = "0x2470EE4", Offset = "0x2470EE4", VA = "0x2470EE4", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60011BB")]
			[Address(RVA = "0x246EFC8", Offset = "0x246EFC8", VA = "0x246EFC8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60011BC")]
			[Address(RVA = "0x246F554", Offset = "0x246F554", VA = "0x246F554")]
			public Platform_GameCore_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200026C")]
		public sealed class Platform_GameCore : Platform_GameCore_Base
		{
			[Token(Token = "0x4000D31")]
			[FieldOffset(Offset = "0x40")]
			public Platform_GameCore_Base[] variants;

			[Token(Token = "0x170004D9")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60011E3")]
				[Address(RVA = "0x246ED14", Offset = "0x246ED14", VA = "0x246ED14", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60011E4")]
			[Address(RVA = "0x246ED1C", Offset = "0x246ED1C", VA = "0x246ED1C", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x246EE74", Offset = "0x246EE74", VA = "0x246EE74", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x246EEF8", Offset = "0x246EEF8", VA = "0x246EEF8", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x246F0E4", Offset = "0x246F0E4", VA = "0x246F0E4")]
			internal static Platform_GameCore CreateDefaultMap(BridgedControllerHWInfo bridgedController)
			{
				return null;
			}

			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x246EEF0", Offset = "0x246EEF0", VA = "0x246EEF0")]
			public Platform_GameCore()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200026D")]
		public class Platform_PS5_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x200026E")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000D37")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000D38")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x170004E6")]
				internal override bool hasData
				{
					[Token(Token = "0x6001202")]
					[Address(RVA = "0x23AE808", Offset = "0x23AE808", VA = "0x23AE808", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004E7")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6001203")]
					[Address(RVA = "0x23AE838", Offset = "0x23AE838", VA = "0x23AE838", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001204")]
				[Address(RVA = "0x23AE874", Offset = "0x23AE874", VA = "0x23AE874", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6001205")]
				[Address(RVA = "0x23AE9E4", Offset = "0x23AE9E4", VA = "0x23AE9E4", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001206")]
				[Address(RVA = "0x23AEA64", Offset = "0x23AEA64", VA = "0x23AEA64", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001207")]
				[Address(RVA = "0x23AEA5C", Offset = "0x23AEA5C", VA = "0x23AEA5C")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200026F")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000D39")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000D3A")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x170004E8")]
				public override int buttonCount
				{
					[Token(Token = "0x6001208")]
					[Address(RVA = "0x23AE440", Offset = "0x23AE440", VA = "0x23AE440", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004E9")]
				public override int axisCount
				{
					[Token(Token = "0x6001209")]
					[Address(RVA = "0x23AE458", Offset = "0x23AE458", VA = "0x23AE458", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600120A")]
				[Address(RVA = "0x23AE470", Offset = "0x23AE470", VA = "0x23AE470", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x600120B")]
				[Address(RVA = "0x23AE594", Offset = "0x23AE594", VA = "0x23AE594", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x600120C")]
				[Address(RVA = "0x23AE6C8", Offset = "0x23AE6C8", VA = "0x23AE6C8", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600120D")]
				[Address(RVA = "0x23AE748", Offset = "0x23AE748", VA = "0x23AE748", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x600120E")]
				[Address(RVA = "0x23AE740", Offset = "0x23AE740", VA = "0x23AE740")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000270")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x600120F")]
				[Address(RVA = "0x23AE368", Offset = "0x23AE368", VA = "0x23AE368", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001210")]
				[Address(RVA = "0x23AE3E8", Offset = "0x23AE3E8", VA = "0x23AE3E8", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001211")]
				[Address(RVA = "0x23AE3E0", Offset = "0x23AE3E0", VA = "0x23AE3E0")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000271")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x6001212")]
				[Address(RVA = "0x23AE290", Offset = "0x23AE290", VA = "0x23AE290", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001213")]
				[Address(RVA = "0x23AE310", Offset = "0x23AE310", VA = "0x23AE310", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001214")]
				[Address(RVA = "0x23AE308", Offset = "0x23AE308", VA = "0x23AE308")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x2000272")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19189C", Offset = "0x19189C")]
			private sealed class fudvfDadezAodBCPGiYRawlAlnoxB : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000D3B")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D3C")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D3D")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D3E")]
				[FieldOffset(Offset = "0x28")]
				public Platform_PS5_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D3F")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004EA")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x6001218")]
					[Address(RVA = "0x23AEC80", Offset = "0x23AEC80", VA = "0x23AEC80", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004EB")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600121A")]
					[Address(RVA = "0x23AECC8", Offset = "0x23AECC8", VA = "0x23AECC8", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001215")]
				[Address(RVA = "0x23AEB78", Offset = "0x23AEB78", VA = "0x23AEB78")]
				[DebuggerHidden]
				public fudvfDadezAodBCPGiYRawlAlnoxB(int P_0)
				{
				}

				[Token(Token = "0x6001216")]
				[Address(RVA = "0x23AEBC0", Offset = "0x23AEBC0", VA = "0x23AEBC0", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001217")]
				[Address(RVA = "0x23AEBC4", Offset = "0x23AEBC4", VA = "0x23AEBC4", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001218")]
				[Address(RVA = "0x23AEC80", Offset = "0x23AEC80", VA = "0x23AEC80", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001219")]
				[Address(RVA = "0x23AEC88", Offset = "0x23AEC88", VA = "0x23AEC88", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600121A")]
				[Address(RVA = "0x23AECC8", Offset = "0x23AECC8", VA = "0x23AECC8", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600121B")]
				[Address(RVA = "0x23AECD0", Offset = "0x23AECD0", VA = "0x23AECD0", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600121C")]
				[Address(RVA = "0x23AED90", Offset = "0x23AED90", VA = "0x23AED90", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000273")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1918AC", Offset = "0x1918AC")]
			private sealed class ouKanObTDkECOEzxBnIEDxwsqOci : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000D40")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D41")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D42")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D43")]
				[FieldOffset(Offset = "0x28")]
				public Platform_PS5_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D44")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004EC")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6001220")]
					[Address(RVA = "0x23AEE9C", Offset = "0x23AEE9C", VA = "0x23AEE9C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004ED")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001222")]
					[Address(RVA = "0x23AEEE4", Offset = "0x23AEEE4", VA = "0x23AEEE4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600121D")]
				[Address(RVA = "0x23AED94", Offset = "0x23AED94", VA = "0x23AED94")]
				[DebuggerHidden]
				public ouKanObTDkECOEzxBnIEDxwsqOci(int P_0)
				{
				}

				[Token(Token = "0x600121E")]
				[Address(RVA = "0x23AEDDC", Offset = "0x23AEDDC", VA = "0x23AEDDC", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x600121F")]
				[Address(RVA = "0x23AEDE0", Offset = "0x23AEDE0", VA = "0x23AEDE0", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001220")]
				[Address(RVA = "0x23AEE9C", Offset = "0x23AEE9C", VA = "0x23AEE9C", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001221")]
				[Address(RVA = "0x23AEEA4", Offset = "0x23AEEA4", VA = "0x23AEEA4", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001222")]
				[Address(RVA = "0x23AEEE4", Offset = "0x23AEEE4", VA = "0x23AEEE4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001223")]
				[Address(RVA = "0x23AEEEC", Offset = "0x23AEEEC", VA = "0x23AEEEC", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001224")]
				[Address(RVA = "0x23AEFAC", Offset = "0x23AEFAC", VA = "0x23AEFAC", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000D32")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000D33")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000D34")]
			[FieldOffset(Offset = "0x28")]
			public string controllerName;

			[Token(Token = "0x4000D35")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000D36")]
			[FieldOffset(Offset = "0x38")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x170004DA")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x60011E9")]
				[Address(RVA = "0x247A2C4", Offset = "0x247A2C4", VA = "0x247A2C4", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004DB")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x60011EA")]
				[Address(RVA = "0x247A2DC", Offset = "0x247A2DC", VA = "0x247A2DC", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004DC")]
			public override string controllerNameOverride
			{
				[Token(Token = "0x60011EB")]
				[Address(RVA = "0x247A2F4", Offset = "0x247A2F4", VA = "0x247A2F4", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004DD")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x60011EC")]
				[Address(RVA = "0x247A2FC", Offset = "0x247A2FC", VA = "0x247A2FC", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004DE")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x60011ED")]
				[Address(RVA = "0x247A304", Offset = "0x247A304", VA = "0x247A304", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004DF")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x60011EE")]
				[Address(RVA = "0x247A430", Offset = "0x247A430", VA = "0x247A430", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004E0")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x60011EF")]
				[Address(RVA = "0x247A418", Offset = "0x247A418", VA = "0x247A418")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004E1")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x60011F0")]
				[Address(RVA = "0x247A544", Offset = "0x247A544", VA = "0x247A544")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004E2")]
			internal override bool hasData
			{
				[Token(Token = "0x60011F1")]
				[Address(RVA = "0x247A55C", Offset = "0x247A55C", VA = "0x247A55C", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004E3")]
			internal override bool disabled
			{
				[Token(Token = "0x60011F2")]
				[Address(RVA = "0x247A5BC", Offset = "0x247A5BC", VA = "0x247A5BC", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004E4")]
			internal override bool isAllowed
			{
				[Token(Token = "0x60011F3")]
				[Address(RVA = "0x247A5D0", Offset = "0x247A5D0", VA = "0x247A5D0", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004E5")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60011F4")]
				[Address(RVA = "0x247A650", Offset = "0x247A650", VA = "0x247A650", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x247A000", Offset = "0x247A000", VA = "0x247A000", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60011F6")]
			[Address(RVA = "0x247A658", Offset = "0x247A658", VA = "0x247A658", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x60011F7")]
			[Address(RVA = "0x247A6CC", Offset = "0x247A6CC", VA = "0x247A6CC", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x60011F8")]
			[Address(RVA = "0x247A740", Offset = "0x247A740", VA = "0x247A740", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x247ADC4", Offset = "0x247ADC4", VA = "0x247ADC4", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x60011FA")]
			[Address(RVA = "0x247B4D0", Offset = "0x247B4D0", VA = "0x247B4D0", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x247B718", Offset = "0x247B718", VA = "0x247B718", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x60011FC")]
			[Address(RVA = "0x247BA2C", Offset = "0x247BA2C", VA = "0x247BA2C", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x60011FD")]
			[Address(RVA = "0x247BBC4", Offset = "0x247BBC4", VA = "0x247BBC4", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x60011FE")]
			[Address(RVA = "0x247BBDC", Offset = "0x247BBDC", VA = "0x247BBDC", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x60011FF")]
			[Address(RVA = "0x247BBF8", Offset = "0x247BBF8", VA = "0x247BBF8", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001200")]
			[Address(RVA = "0x247A1A0", Offset = "0x247A1A0", VA = "0x247A1A0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001201")]
			[Address(RVA = "0x247A2BC", Offset = "0x247A2BC", VA = "0x247A2BC")]
			public Platform_PS5_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000274")]
		public sealed class Platform_PS5 : Platform_PS5_Base
		{
			[Token(Token = "0x4000D45")]
			[FieldOffset(Offset = "0x40")]
			public Platform_PS5_Base[] variants;

			[Token(Token = "0x170004EE")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001225")]
				[Address(RVA = "0x2479EEC", Offset = "0x2479EEC", VA = "0x2479EEC", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001226")]
			[Address(RVA = "0x2479EF4", Offset = "0x2479EF4", VA = "0x2479EF4", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001227")]
			[Address(RVA = "0x247A04C", Offset = "0x247A04C", VA = "0x247A04C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001228")]
			[Address(RVA = "0x247A0D0", Offset = "0x247A0D0", VA = "0x247A0D0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001229")]
			[Address(RVA = "0x247A0C8", Offset = "0x247A0C8", VA = "0x247A0C8")]
			public Platform_PS5()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000275")]
		public class Platform_InternalDriver_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x2000276")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000D4A")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000D4B")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x4000D4C")]
				[FieldOffset(Offset = "0x38")]
				public VidPid[] vidPid;

				[Token(Token = "0x4000D4D")]
				[FieldOffset(Offset = "0x40")]
				public int hatCount;

				[Token(Token = "0x170004FA")]
				internal override bool hasData
				{
					[Token(Token = "0x6001242")]
					[Address(RVA = "0x23A9BF0", Offset = "0x23A9BF0", VA = "0x23A9BF0", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004FB")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6001243")]
					[Address(RVA = "0x23A9C30", Offset = "0x23A9C30", VA = "0x23A9C30", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001244")]
				[Address(RVA = "0x23A9C6C", Offset = "0x23A9C6C", VA = "0x23A9C6C", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6001245")]
				[Address(RVA = "0x23A9FC8", Offset = "0x23A9FC8", VA = "0x23A9FC8", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6001246")]
				[Address(RVA = "0x23AA02C", Offset = "0x23AA02C", VA = "0x23AA02C", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001247")]
				[Address(RVA = "0x23AA0AC", Offset = "0x23AA0AC", VA = "0x23AA0AC", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001248")]
				[Address(RVA = "0x23A9F3C", Offset = "0x23A9F3C", VA = "0x23A9F3C")]
				private bool ProductNameMatches(string name)
				{
					return default;
				}

				[Token(Token = "0x6001249")]
				[Address(RVA = "0x23AA0A4", Offset = "0x23AA0A4", VA = "0x23AA0A4")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000277")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000D4E")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000D4F")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x170004FC")]
				public override int buttonCount
				{
					[Token(Token = "0x600124A")]
					[Address(RVA = "0x23A9800", Offset = "0x23A9800", VA = "0x23A9800", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x170004FD")]
				public override int axisCount
				{
					[Token(Token = "0x600124B")]
					[Address(RVA = "0x23A9818", Offset = "0x23A9818", VA = "0x23A9818", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600124C")]
				[Address(RVA = "0x23A9830", Offset = "0x23A9830", VA = "0x23A9830", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x600124D")]
				[Address(RVA = "0x23A9954", Offset = "0x23A9954", VA = "0x23A9954", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x600124E")]
				[Address(RVA = "0x23A9AB0", Offset = "0x23A9AB0", VA = "0x23A9AB0", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600124F")]
				[Address(RVA = "0x23A9B30", Offset = "0x23A9B30", VA = "0x23A9B30", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6001250")]
				[Address(RVA = "0x23A9B28", Offset = "0x23A9B28", VA = "0x23A9B28")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000278")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x4000D50")]
				[FieldOffset(Offset = "0x60")]
				public int sourceHat;

				[Token(Token = "0x4000D51")]
				[FieldOffset(Offset = "0x64")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000D52")]
				[FieldOffset(Offset = "0x68")]
				public HatType sourceHatType;

				[Token(Token = "0x6001251")]
				[Address(RVA = "0x23A96EC", Offset = "0x23A96EC", VA = "0x23A96EC", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001252")]
				[Address(RVA = "0x23A976C", Offset = "0x23A976C", VA = "0x23A976C", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001253")]
				[Address(RVA = "0x23A9764", Offset = "0x23A9764", VA = "0x23A9764")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000279")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x4000D53")]
				[FieldOffset(Offset = "0x68")]
				public int sourceHat;

				[Token(Token = "0x4000D54")]
				[FieldOffset(Offset = "0x6C")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000D55")]
				[FieldOffset(Offset = "0x70")]
				public HatType sourceHatType;

				[Token(Token = "0x4000D56")]
				[FieldOffset(Offset = "0x74")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x6001254")]
				[Address(RVA = "0x23A95E0", Offset = "0x23A95E0", VA = "0x23A95E0", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001255")]
				[Address(RVA = "0x23A9660", Offset = "0x23A9660", VA = "0x23A9660", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001256")]
				[Address(RVA = "0x23A9658", Offset = "0x23A9658", VA = "0x23A9658")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x200027A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1918BC", Offset = "0x1918BC")]
			private sealed class WGzjBLACrcLWCiqWlvuDLHdbeIWl : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000D57")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D58")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D59")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D5A")]
				[FieldOffset(Offset = "0x28")]
				public Platform_InternalDriver_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D5B")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x170004FE")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x600125A")]
					[Address(RVA = "0x23AA2F4", Offset = "0x23AA2F4", VA = "0x23AA2F4", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170004FF")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600125C")]
					[Address(RVA = "0x23AA33C", Offset = "0x23AA33C", VA = "0x23AA33C", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001257")]
				[Address(RVA = "0x23AA1EC", Offset = "0x23AA1EC", VA = "0x23AA1EC")]
				[DebuggerHidden]
				public WGzjBLACrcLWCiqWlvuDLHdbeIWl(int P_0)
				{
				}

				[Token(Token = "0x6001258")]
				[Address(RVA = "0x23AA234", Offset = "0x23AA234", VA = "0x23AA234", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001259")]
				[Address(RVA = "0x23AA238", Offset = "0x23AA238", VA = "0x23AA238", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600125A")]
				[Address(RVA = "0x23AA2F4", Offset = "0x23AA2F4", VA = "0x23AA2F4", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600125B")]
				[Address(RVA = "0x23AA2FC", Offset = "0x23AA2FC", VA = "0x23AA2FC", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600125C")]
				[Address(RVA = "0x23AA33C", Offset = "0x23AA33C", VA = "0x23AA33C", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600125D")]
				[Address(RVA = "0x23AA344", Offset = "0x23AA344", VA = "0x23AA344", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600125E")]
				[Address(RVA = "0x23AA404", Offset = "0x23AA404", VA = "0x23AA404", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x200027B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1918CC", Offset = "0x1918CC")]
			private sealed class lmCaQZAClsmXFaCfkaZsqajGXeHfD : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000D5C")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D5D")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D5E")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D5F")]
				[FieldOffset(Offset = "0x28")]
				public Platform_InternalDriver_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D60")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000500")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6001262")]
					[Address(RVA = "0x23AA510", Offset = "0x23AA510", VA = "0x23AA510", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000501")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001264")]
					[Address(RVA = "0x23AA558", Offset = "0x23AA558", VA = "0x23AA558", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600125F")]
				[Address(RVA = "0x23AA408", Offset = "0x23AA408", VA = "0x23AA408")]
				[DebuggerHidden]
				public lmCaQZAClsmXFaCfkaZsqajGXeHfD(int P_0)
				{
				}

				[Token(Token = "0x6001260")]
				[Address(RVA = "0x23AA450", Offset = "0x23AA450", VA = "0x23AA450", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001261")]
				[Address(RVA = "0x23AA454", Offset = "0x23AA454", VA = "0x23AA454", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001262")]
				[Address(RVA = "0x23AA510", Offset = "0x23AA510", VA = "0x23AA510", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001263")]
				[Address(RVA = "0x23AA518", Offset = "0x23AA518", VA = "0x23AA518", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001264")]
				[Address(RVA = "0x23AA558", Offset = "0x23AA558", VA = "0x23AA558", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001265")]
				[Address(RVA = "0x23AA560", Offset = "0x23AA560", VA = "0x23AA560", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001266")]
				[Address(RVA = "0x23AA620", Offset = "0x23AA620", VA = "0x23AA620", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000D46")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000D47")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000D48")]
			[FieldOffset(Offset = "0x28")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000D49")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x170004EF")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x600122A")]
				[Address(RVA = "0x2471334", Offset = "0x2471334", VA = "0x2471334", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004F0")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x600122B")]
				[Address(RVA = "0x247134C", Offset = "0x247134C", VA = "0x247134C", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004F1")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x600122C")]
				[Address(RVA = "0x2471364", Offset = "0x2471364", VA = "0x2471364", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004F2")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x600122D")]
				[Address(RVA = "0x247136C", Offset = "0x247136C", VA = "0x247136C", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004F3")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x600122E")]
				[Address(RVA = "0x2471498", Offset = "0x2471498", VA = "0x2471498", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004F4")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x600122F")]
				[Address(RVA = "0x2471480", Offset = "0x2471480", VA = "0x2471480")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004F5")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6001230")]
				[Address(RVA = "0x24715AC", Offset = "0x24715AC", VA = "0x24715AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004F6")]
			internal override bool hasData
			{
				[Token(Token = "0x6001231")]
				[Address(RVA = "0x24715C4", Offset = "0x24715C4", VA = "0x24715C4", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004F7")]
			internal override bool disabled
			{
				[Token(Token = "0x6001232")]
				[Address(RVA = "0x2471624", Offset = "0x2471624", VA = "0x2471624", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004F8")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6001233")]
				[Address(RVA = "0x2471638", Offset = "0x2471638", VA = "0x2471638", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170004F9")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001234")]
				[Address(RVA = "0x24716B8", Offset = "0x24716B8", VA = "0x24716B8", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001235")]
			[Address(RVA = "0x2471074", Offset = "0x2471074", VA = "0x2471074", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001236")]
			[Address(RVA = "0x24716C0", Offset = "0x24716C0", VA = "0x24716C0", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6001237")]
			[Address(RVA = "0x2471734", Offset = "0x2471734", VA = "0x2471734", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6001238")]
			[Address(RVA = "0x24717A8", Offset = "0x24717A8", VA = "0x24717A8", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001239")]
			[Address(RVA = "0x2471E2C", Offset = "0x2471E2C", VA = "0x2471E2C", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x600123A")]
			[Address(RVA = "0x2472538", Offset = "0x2472538", VA = "0x2472538", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x600123B")]
			[Address(RVA = "0x2472798", Offset = "0x2472798", VA = "0x2472798", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x600123C")]
			[Address(RVA = "0x2472AE8", Offset = "0x2472AE8", VA = "0x2472AE8", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x600123D")]
			[Address(RVA = "0x2472C80", Offset = "0x2472C80", VA = "0x2472C80", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x600123E")]
			[Address(RVA = "0x2472C98", Offset = "0x2472C98", VA = "0x2472C98", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x600123F")]
			[Address(RVA = "0x2472CB4", Offset = "0x2472CB4", VA = "0x2472CB4", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001240")]
			[Address(RVA = "0x2471214", Offset = "0x2471214", VA = "0x2471214", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001241")]
			[Address(RVA = "0x247132C", Offset = "0x247132C", VA = "0x247132C")]
			public Platform_InternalDriver_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200027C")]
		public sealed class Platform_InternalDriver : Platform_InternalDriver_Base
		{
			[Token(Token = "0x4000D61")]
			[FieldOffset(Offset = "0x38")]
			public Platform_InternalDriver_Base[] variants;

			[Token(Token = "0x17000502")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001267")]
				[Address(RVA = "0x2470F60", Offset = "0x2470F60", VA = "0x2470F60", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001268")]
			[Address(RVA = "0x2470F68", Offset = "0x2470F68", VA = "0x2470F68", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001269")]
			[Address(RVA = "0x24710C0", Offset = "0x24710C0", VA = "0x24710C0", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x600126A")]
			[Address(RVA = "0x2471144", Offset = "0x2471144", VA = "0x2471144", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600126B")]
			[Address(RVA = "0x247113C", Offset = "0x247113C", VA = "0x247113C")]
			public Platform_InternalDriver()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200027D")]
		public class Platform_SDL2_Base : Platform
		{
			[Serializable]
			[Token(Token = "0x200027E")]
			public sealed class MatchingCriteria : MatchingCriteria_Base
			{
				[Token(Token = "0x4000D64")]
				[FieldOffset(Offset = "0x28")]
				public int hatCount;

				[Token(Token = "0x4000D65")]
				[FieldOffset(Offset = "0x2C")]
				public bool manufacturer_useRegex;

				[Token(Token = "0x4000D66")]
				[FieldOffset(Offset = "0x2D")]
				public bool productName_useRegex;

				[Token(Token = "0x4000D67")]
				[FieldOffset(Offset = "0x2E")]
				public bool systemName_useRegex;

				[Token(Token = "0x4000D68")]
				[FieldOffset(Offset = "0x30")]
				public string[] manufacturer;

				[Token(Token = "0x4000D69")]
				[FieldOffset(Offset = "0x38")]
				public string[] productName;

				[Token(Token = "0x4000D6A")]
				[FieldOffset(Offset = "0x40")]
				public string[] systemName;

				[Token(Token = "0x4000D6B")]
				[FieldOffset(Offset = "0x48")]
				public string[] productGUID;

				[Token(Token = "0x1700050C")]
				internal override bool hasData
				{
					[Token(Token = "0x6001282")]
					[Address(RVA = "0x23B0888", Offset = "0x23B0888", VA = "0x23B0888", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700050D")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6001283")]
					[Address(RVA = "0x23B08C8", Offset = "0x23B08C8", VA = "0x23B08C8", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700050E")]
				internal override int alternateElementCount
				{
					[Token(Token = "0x6001285")]
					[Address(RVA = "0x23B0A74", Offset = "0x23B0A74", VA = "0x23B0A74", Slot = "8")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001284")]
				[Address(RVA = "0x23B08D0", Offset = "0x23B08D0", VA = "0x23B08D0", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6001286")]
				[Address(RVA = "0x23B0A7C", Offset = "0x23B0A7C", VA = "0x23B0A7C", Slot = "9")]
				internal override ElementCount_Base GetAlternateElementCount(int index)
				{
					return null;
				}

				[Token(Token = "0x6001287")]
				[Address(RVA = "0x23B0A84", Offset = "0x23B0A84", VA = "0x23B0A84", Slot = "10")]
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched)
				{
					return default;
				}

				[Token(Token = "0x6001288")]
				[Address(RVA = "0x23B0A1C", Offset = "0x23B0A1C", VA = "0x23B0A1C")]
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo)
				{
					return default;
				}

				[Token(Token = "0x6001289")]
				[Address(RVA = "0x23B0AE8", Offset = "0x23B0AE8", VA = "0x23B0AE8")]
				private bool NameMatches(string name, string[] names, bool useRegex)
				{
					return default;
				}

				[Token(Token = "0x600128A")]
				[Address(RVA = "0x23B0BD0", Offset = "0x23B0BD0", VA = "0x23B0BD0", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600128B")]
				[Address(RVA = "0x23B0C50", Offset = "0x23B0C50", VA = "0x23B0C50", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x600128C")]
				[Address(RVA = "0x23B0C48", Offset = "0x23B0C48", VA = "0x23B0C48")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200027F")]
			public sealed class Elements : Elements_Base
			{
				[Token(Token = "0x4000D6C")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000D6D")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x1700050F")]
				public override int buttonCount
				{
					[Token(Token = "0x600128D")]
					[Address(RVA = "0x23B0498", Offset = "0x23B0498", VA = "0x23B0498", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000510")]
				public override int axisCount
				{
					[Token(Token = "0x600128E")]
					[Address(RVA = "0x23B04B0", Offset = "0x23B04B0", VA = "0x23B04B0", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x600128F")]
				[Address(RVA = "0x23B04C8", Offset = "0x23B04C8", VA = "0x23B04C8", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x6001290")]
				[Address(RVA = "0x23B05EC", Offset = "0x23B05EC", VA = "0x23B05EC", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x6001291")]
				[Address(RVA = "0x23B0748", Offset = "0x23B0748", VA = "0x23B0748", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001292")]
				[Address(RVA = "0x23B07C8", Offset = "0x23B07C8", VA = "0x23B07C8", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x6001293")]
				[Address(RVA = "0x23B07C0", Offset = "0x23B07C0", VA = "0x23B07C0")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000280")]
			public abstract class Element : IDeepCloneable
			{
				[Token(Token = "0x6001294")]
				public abstract object DeepClone();

				[Token(Token = "0x6001295")]
				[Address(RVA = "0x23B0280", Offset = "0x23B0280", VA = "0x23B0280", Slot = "6")]
				protected virtual void ImportVars(Element source)
				{
				}

				[Token(Token = "0x6001296")]
				[Address(RVA = "0x23B0090", Offset = "0x23B0090", VA = "0x23B0090")]
				protected Element()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000281")]
			public class Button : Element
			{
				[Token(Token = "0x4000D6E")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000D6F")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000D70")]
				[FieldOffset(Offset = "0x18")]
				public int sourceButton;

				[Token(Token = "0x4000D71")]
				[FieldOffset(Offset = "0x1C")]
				public int sourceAxis;

				[Token(Token = "0x4000D72")]
				[FieldOffset(Offset = "0x20")]
				public Pole sourceAxisPole;

				[Token(Token = "0x4000D73")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000D74")]
				[FieldOffset(Offset = "0x28")]
				public int sourceHat;

				[Token(Token = "0x4000D75")]
				[FieldOffset(Offset = "0x2C")]
				public HatType sourceHatType;

				[Token(Token = "0x4000D76")]
				[FieldOffset(Offset = "0x30")]
				public HatDirection sourceHatDirection;

				[Token(Token = "0x4000D77")]
				[FieldOffset(Offset = "0x34")]
				public bool requireMultipleButtons;

				[Token(Token = "0x4000D78")]
				[FieldOffset(Offset = "0x38")]
				public int[] requiredButtons;

				[Token(Token = "0x4000D79")]
				[FieldOffset(Offset = "0x40")]
				public bool ignoreIfButtonsActive;

				[Token(Token = "0x4000D7A")]
				[FieldOffset(Offset = "0x48")]
				public int[] ignoreIfButtonsActiveButtons;

				[Token(Token = "0x4000D7B")]
				[FieldOffset(Offset = "0x50")]
				public HardwareButtonInfo buttonInfo;

				[Token(Token = "0x6001297")]
				[Address(RVA = "0x23B0284", Offset = "0x23B0284", VA = "0x23B0284")]
				public Button()
				{
				}

				[Token(Token = "0x6001298")]
				[Address(RVA = "0x23B02AC", Offset = "0x23B02AC", VA = "0x23B02AC", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001299")]
				[Address(RVA = "0x23B0330", Offset = "0x23B0330", VA = "0x23B0330", Slot = "6")]
				protected override void ImportVars(Element source)
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000282")]
			public class Axis : Element
			{
				[Token(Token = "0x4000D7C")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000D7D")]
				[FieldOffset(Offset = "0x14")]
				public HardwareElementSourceTypeWithHat sourceType;

				[Token(Token = "0x4000D7E")]
				[FieldOffset(Offset = "0x18")]
				public int sourceAxis;

				[Token(Token = "0x4000D7F")]
				[FieldOffset(Offset = "0x1C")]
				public AxisRange sourceAxisRange;

				[Token(Token = "0x4000D80")]
				[FieldOffset(Offset = "0x20")]
				public bool invert;

				[Token(Token = "0x4000D81")]
				[FieldOffset(Offset = "0x24")]
				public float axisDeadZone;

				[Token(Token = "0x4000D82")]
				[FieldOffset(Offset = "0x28")]
				public bool calibrateAxis;

				[Token(Token = "0x4000D83")]
				[FieldOffset(Offset = "0x2C")]
				public float axisZero;

				[Token(Token = "0x4000D84")]
				[FieldOffset(Offset = "0x30")]
				public float axisMin;

				[Token(Token = "0x4000D85")]
				[FieldOffset(Offset = "0x34")]
				public float axisMax;

				[Token(Token = "0x4000D86")]
				[FieldOffset(Offset = "0x38")]
				public AxisCalibrationInfoEntry[] alternateCalibrations;

				[Token(Token = "0x4000D87")]
				[FieldOffset(Offset = "0x40")]
				public HardwareAxisInfo axisInfo;

				[Token(Token = "0x4000D88")]
				[FieldOffset(Offset = "0x48")]
				public int sourceButton;

				[Token(Token = "0x4000D89")]
				[FieldOffset(Offset = "0x4C")]
				public Pole buttonAxisContribution;

				[Token(Token = "0x4000D8A")]
				[FieldOffset(Offset = "0x50")]
				public int sourceHat;

				[Token(Token = "0x4000D8B")]
				[FieldOffset(Offset = "0x54")]
				public AxisDirection sourceHatDirection;

				[Token(Token = "0x4000D8C")]
				[FieldOffset(Offset = "0x58")]
				public AxisRange sourceHatRange;

				[Token(Token = "0x600129A")]
				[Address(RVA = "0x23B0064", Offset = "0x23B0064", VA = "0x23B0064")]
				public Axis()
				{
				}

				[Token(Token = "0x600129B")]
				[Address(RVA = "0x23B0098", Offset = "0x23B0098", VA = "0x23B0098", Slot = "5")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600129C")]
				[Address(RVA = "0x23B0120", Offset = "0x23B0120", VA = "0x23B0120", Slot = "6")]
				protected override void ImportVars(Element source)
				{
				}
			}

			[Token(Token = "0x2000283")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1918DC", Offset = "0x1918DC")]
			private sealed class bZImnXuwsxacRMiixiFAnCVDKBlQ : IDisposable, IEnumerable, IEnumerator, IEnumerable<Axis>, IEnumerator<Axis>
			{
				[Token(Token = "0x4000D8D")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D8E")]
				[FieldOffset(Offset = "0x18")]
				private Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D8F")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D90")]
				[FieldOffset(Offset = "0x28")]
				public Platform_SDL2_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D91")]
				[FieldOffset(Offset = "0x30")]
				private int yGVazBNUxMSdXREcmvzWGmvkBjWk;

				[Token(Token = "0x4000D92")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000511")]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x60012A0")]
					[Address(RVA = "0x23B0E44", Offset = "0x23B0E44", VA = "0x23B0E44", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000512")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60012A2")]
					[Address(RVA = "0x23B0E8C", Offset = "0x23B0E8C", VA = "0x23B0E8C", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600129D")]
				[Address(RVA = "0x23B0D34", Offset = "0x23B0D34", VA = "0x23B0D34")]
				[DebuggerHidden]
				public bZImnXuwsxacRMiixiFAnCVDKBlQ(int P_0)
				{
				}

				[Token(Token = "0x600129E")]
				[Address(RVA = "0x23B0D7C", Offset = "0x23B0D7C", VA = "0x23B0D7C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x600129F")]
				[Address(RVA = "0x23B0D80", Offset = "0x23B0D80", VA = "0x23B0D80", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60012A0")]
				[Address(RVA = "0x23B0E44", Offset = "0x23B0E44", VA = "0x23B0E44", Slot = "10")]
				[DebuggerHidden]
				private Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012A1")]
				[Address(RVA = "0x23B0E4C", Offset = "0x23B0E4C", VA = "0x23B0E4C", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60012A2")]
				[Address(RVA = "0x23B0E8C", Offset = "0x23B0E8C", VA = "0x23B0E8C", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012A3")]
				[Address(RVA = "0x23B0E94", Offset = "0x23B0E94", VA = "0x23B0E94", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60012A4")]
				[Address(RVA = "0x23B0F54", Offset = "0x23B0F54", VA = "0x23B0F54", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x2000284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1918EC", Offset = "0x1918EC")]
			private sealed class rxrRTRZYiSlxoNsbatkFhGnGEPbi : IDisposable, IEnumerable, IEnumerator, IEnumerable<Button>, IEnumerator<Button>
			{
				[Token(Token = "0x4000D93")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000D94")]
				[FieldOffset(Offset = "0x18")]
				private Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000D95")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000D96")]
				[FieldOffset(Offset = "0x28")]
				public Platform_SDL2_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000D97")]
				[FieldOffset(Offset = "0x30")]
				private int pMgPWWjomCBqioCeCujXqJRwsmRk;

				[Token(Token = "0x4000D98")]
				[FieldOffset(Offset = "0x34")]
				private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

				[Token(Token = "0x17000513")]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x60012A8")]
					[Address(RVA = "0x23B1068", Offset = "0x23B1068", VA = "0x23B1068", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000514")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60012AA")]
					[Address(RVA = "0x23B10B0", Offset = "0x23B10B0", VA = "0x23B10B0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60012A5")]
				[Address(RVA = "0x23B0F58", Offset = "0x23B0F58", VA = "0x23B0F58")]
				[DebuggerHidden]
				public rxrRTRZYiSlxoNsbatkFhGnGEPbi(int P_0)
				{
				}

				[Token(Token = "0x60012A6")]
				[Address(RVA = "0x23B0FA0", Offset = "0x23B0FA0", VA = "0x23B0FA0", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60012A7")]
				[Address(RVA = "0x23B0FA4", Offset = "0x23B0FA4", VA = "0x23B0FA4", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60012A8")]
				[Address(RVA = "0x23B1068", Offset = "0x23B1068", VA = "0x23B1068", Slot = "10")]
				[DebuggerHidden]
				private Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012A9")]
				[Address(RVA = "0x23B1070", Offset = "0x23B1070", VA = "0x23B1070", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60012AA")]
				[Address(RVA = "0x23B10B0", Offset = "0x23B10B0", VA = "0x23B10B0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012AB")]
				[Address(RVA = "0x23B10B8", Offset = "0x23B10B8", VA = "0x23B10B8", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_SDL2_Base_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60012AC")]
				[Address(RVA = "0x23B1178", Offset = "0x23B1178", VA = "0x23B1178", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000D62")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000D63")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x17000503")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x600126C")]
				[Address(RVA = "0x247DBA4", Offset = "0x247DBA4", VA = "0x247DBA4", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000504")]
			internal override bool hasData
			{
				[Token(Token = "0x600126D")]
				[Address(RVA = "0x247DBAC", Offset = "0x247DBAC", VA = "0x247DBAC", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000505")]
			internal override bool disabled
			{
				[Token(Token = "0x600126E")]
				[Address(RVA = "0x247DC0C", Offset = "0x247DC0C", VA = "0x247DC0C", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000506")]
			internal override bool isAllowed
			{
				[Token(Token = "0x600126F")]
				[Address(RVA = "0x247DC20", Offset = "0x247DC20", VA = "0x247DC20", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000507")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x6001270")]
				[Address(RVA = "0x247DCA0", Offset = "0x247DCA0", VA = "0x247DCA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000508")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x6001271")]
				[Address(RVA = "0x247DCB8", Offset = "0x247DCB8", VA = "0x247DCB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000509")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001272")]
				[Address(RVA = "0x247DCD0", Offset = "0x247DCD0", VA = "0x247DCD0", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700050A")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x6001274")]
				[Address(RVA = "0x247DCD8", Offset = "0x247DCD8", VA = "0x247DCD8", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700050B")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x6001275")]
				[Address(RVA = "0x247DCF0", Offset = "0x247DCF0", VA = "0x247DCF0", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6001273")]
			[Address(RVA = "0x247D910", Offset = "0x247D910", VA = "0x247D910", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001276")]
			[Address(RVA = "0x247DD08", Offset = "0x247DD08", VA = "0x247DD08", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001277")]
			[Address(RVA = "0x247E474", Offset = "0x247E474", VA = "0x247E474", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6001278")]
			[Address(RVA = "0x247EB50", Offset = "0x247EB50", VA = "0x247EB50", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6001279")]
			[Address(RVA = "0x247EDB0", Offset = "0x247EDB0", VA = "0x247EDB0", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x600127A")]
			[Address(RVA = "0x247F100", Offset = "0x247F100", VA = "0x247F100", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x600127B")]
			[Address(RVA = "0x247F298", Offset = "0x247F298", VA = "0x247F298", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x600127C")]
			[Address(RVA = "0x247F2B0", Offset = "0x247F2B0", VA = "0x247F2B0", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x600127D")]
			[Address(RVA = "0x247E38C", Offset = "0x247E38C", VA = "0x247E38C")]
			internal IEnumerable<Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x600127E")]
			[Address(RVA = "0x247E400", Offset = "0x247E400", VA = "0x247E400")]
			internal IEnumerable<Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x600127F")]
			[Address(RVA = "0x247F2CC", Offset = "0x247F2CC", VA = "0x247F2CC", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x6001280")]
			[Address(RVA = "0x247DAB0", Offset = "0x247DAB0", VA = "0x247DAB0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x6001281")]
			[Address(RVA = "0x247DB9C", Offset = "0x247DB9C", VA = "0x247DB9C")]
			public Platform_SDL2_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000285")]
		public sealed class Platform_SDL2 : Platform_SDL2_Base
		{
			[Token(Token = "0x4000D99")]
			[FieldOffset(Offset = "0x28")]
			public Platform_SDL2_Base[] variants;

			[Token(Token = "0x17000515")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60012AD")]
				[Address(RVA = "0x247D7FC", Offset = "0x247D7FC", VA = "0x247D7FC", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60012AE")]
			[Address(RVA = "0x247D804", Offset = "0x247D804", VA = "0x247D804", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60012AF")]
			[Address(RVA = "0x247D95C", Offset = "0x247D95C", VA = "0x247D95C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60012B0")]
			[Address(RVA = "0x247D9E0", Offset = "0x247D9E0", VA = "0x247D9E0", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60012B1")]
			[Address(RVA = "0x247D9D8", Offset = "0x247D9D8", VA = "0x247D9D8")]
			public Platform_SDL2()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000286")]
		public class Platform_WebGL_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x2000287")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Serializable]
				[Token(Token = "0x2000288")]
				public sealed class ClientInfo : IDeepCloneable
				{
					[Token(Token = "0x4000DA4")]
					[FieldOffset(Offset = "0x10")]
					public int browser;

					[Token(Token = "0x4000DA5")]
					[FieldOffset(Offset = "0x18")]
					public string browserVersionMin;

					[Token(Token = "0x4000DA6")]
					[FieldOffset(Offset = "0x20")]
					public string browserVersionMax;

					[Token(Token = "0x4000DA7")]
					[FieldOffset(Offset = "0x28")]
					public int os;

					[Token(Token = "0x4000DA8")]
					[FieldOffset(Offset = "0x30")]
					public string osVersionMin;

					[Token(Token = "0x4000DA9")]
					[FieldOffset(Offset = "0x38")]
					public string osVersionMax;

					[Token(Token = "0x60012D2")]
					[Address(RVA = "0x23C2EB0", Offset = "0x23C2EB0", VA = "0x23C2EB0", Slot = "4")]
					public object DeepClone()
					{
						return null;
					}

					[Token(Token = "0x60012D3")]
					[Address(RVA = "0x23C2F3C", Offset = "0x23C2F3C", VA = "0x23C2F3C")]
					public ClientInfo()
					{
					}
				}

				[Token(Token = "0x4000D9E")]
				[FieldOffset(Offset = "0x29")]
				public bool productName_useRegex;

				[Token(Token = "0x4000D9F")]
				[FieldOffset(Offset = "0x30")]
				public string[] productName;

				[Token(Token = "0x4000DA0")]
				[FieldOffset(Offset = "0x38")]
				public string[] productGUID;

				[Token(Token = "0x4000DA1")]
				[FieldOffset(Offset = "0x40")]
				public int[] mapping;

				[Token(Token = "0x4000DA2")]
				[FieldOffset(Offset = "0x48")]
				public ElementCount_Base[] elementCount;

				[Token(Token = "0x4000DA3")]
				[FieldOffset(Offset = "0x50")]
				public ClientInfo[] clientInfo;

				[Token(Token = "0x17000521")]
				internal override bool hasData
				{
					[Token(Token = "0x60012CA")]
					[Address(RVA = "0x23B2630", Offset = "0x23B2630", VA = "0x23B2630", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000522")]
				internal override bool isAllowed
				{
					[Token(Token = "0x60012CB")]
					[Address(RVA = "0x23B26A0", Offset = "0x23B26A0", VA = "0x23B26A0", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60012CC")]
				[Address(RVA = "0x23B26DC", Offset = "0x23B26DC", VA = "0x23B26DC", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x60012CD")]
				[Address(RVA = "0x23B2B3C", Offset = "0x23B2B3C", VA = "0x23B2B3C")]
				private static bool CheckBrowserVersion(int browser, string versionMin, string versionMax, string[] currentVersion)
				{
					return default;
				}

				[Token(Token = "0x60012CE")]
				[Address(RVA = "0x23B2E2C", Offset = "0x23B2E2C", VA = "0x23B2E2C")]
				private static bool CheckOSVersion(string versionMin, string versionMax, string[] currentVersion)
				{
					return default;
				}

				[Token(Token = "0x60012CF")]
				[Address(RVA = "0x23B3114", Offset = "0x23B3114", VA = "0x23B3114", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60012D0")]
				[Address(RVA = "0x23B3194", Offset = "0x23B3194", VA = "0x23B3194", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x60012D1")]
				[Address(RVA = "0x23B318C", Offset = "0x23B318C", VA = "0x23B318C")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000289")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000DAA")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000DAB")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x17000523")]
				public override int buttonCount
				{
					[Token(Token = "0x60012D4")]
					[Address(RVA = "0x23B204C", Offset = "0x23B204C", VA = "0x23B204C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000524")]
				public override int axisCount
				{
					[Token(Token = "0x60012D5")]
					[Address(RVA = "0x23B2064", Offset = "0x23B2064", VA = "0x23B2064", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x60012D6")]
				[Address(RVA = "0x23B207C", Offset = "0x23B207C", VA = "0x23B207C", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x60012D7")]
				[Address(RVA = "0x23B21A0", Offset = "0x23B21A0", VA = "0x23B21A0", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x60012D8")]
				[Address(RVA = "0x23B22D4", Offset = "0x23B22D4", VA = "0x23B22D4", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60012D9")]
				[Address(RVA = "0x23B2354", Offset = "0x23B2354", VA = "0x23B2354", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x60012DA")]
				[Address(RVA = "0x23B234C", Offset = "0x23B234C", VA = "0x23B234C")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200028A")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x60012DB")]
				[Address(RVA = "0x23B1F74", Offset = "0x23B1F74", VA = "0x23B1F74", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60012DC")]
				[Address(RVA = "0x23B1FF4", Offset = "0x23B1FF4", VA = "0x23B1FF4", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60012DD")]
				[Address(RVA = "0x23B1FEC", Offset = "0x23B1FEC", VA = "0x23B1FEC")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x200028B")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x60012DE")]
				[Address(RVA = "0x23B1E9C", Offset = "0x23B1E9C", VA = "0x23B1E9C", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x60012DF")]
				[Address(RVA = "0x23B1F1C", Offset = "0x23B1F1C", VA = "0x23B1F1C", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x60012E0")]
				[Address(RVA = "0x23B1F14", Offset = "0x23B1F14", VA = "0x23B1F14")]
				public Axis()
				{
				}
			}

			[Token(Token = "0x200028C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1918FC", Offset = "0x1918FC")]
			private sealed class NuQPvYNngeqdbcvpRoPAJXAUgDLH : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000DAC")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000DAD")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000DAE")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000DAF")]
				[FieldOffset(Offset = "0x28")]
				public Platform_WebGL_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000DB0")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000525")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x60012E4")]
					[Address(RVA = "0x23B3434", Offset = "0x23B3434", VA = "0x23B3434", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000526")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60012E6")]
					[Address(RVA = "0x23B347C", Offset = "0x23B347C", VA = "0x23B347C", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60012E1")]
				[Address(RVA = "0x23B332C", Offset = "0x23B332C", VA = "0x23B332C")]
				[DebuggerHidden]
				public NuQPvYNngeqdbcvpRoPAJXAUgDLH(int P_0)
				{
				}

				[Token(Token = "0x60012E2")]
				[Address(RVA = "0x23B3374", Offset = "0x23B3374", VA = "0x23B3374", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60012E3")]
				[Address(RVA = "0x23B3378", Offset = "0x23B3378", VA = "0x23B3378", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60012E4")]
				[Address(RVA = "0x23B3434", Offset = "0x23B3434", VA = "0x23B3434", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012E5")]
				[Address(RVA = "0x23B343C", Offset = "0x23B343C", VA = "0x23B343C", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60012E6")]
				[Address(RVA = "0x23B347C", Offset = "0x23B347C", VA = "0x23B347C", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012E7")]
				[Address(RVA = "0x23B3484", Offset = "0x23B3484", VA = "0x23B3484", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60012E8")]
				[Address(RVA = "0x23B3544", Offset = "0x23B3544", VA = "0x23B3544", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x200028D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19190C", Offset = "0x19190C")]
			private sealed class IDZcjDZtOKSyFhUFwksPddYRpSod : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000DB1")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000DB2")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000DB3")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000DB4")]
				[FieldOffset(Offset = "0x28")]
				public Platform_WebGL_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000DB5")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x17000527")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x60012EC")]
					[Address(RVA = "0x23B251C", Offset = "0x23B251C", VA = "0x23B251C", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000528")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60012EE")]
					[Address(RVA = "0x23B2564", Offset = "0x23B2564", VA = "0x23B2564", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60012E9")]
				[Address(RVA = "0x23B2414", Offset = "0x23B2414", VA = "0x23B2414")]
				[DebuggerHidden]
				public IDZcjDZtOKSyFhUFwksPddYRpSod(int P_0)
				{
				}

				[Token(Token = "0x60012EA")]
				[Address(RVA = "0x23B245C", Offset = "0x23B245C", VA = "0x23B245C", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60012EB")]
				[Address(RVA = "0x23B2460", Offset = "0x23B2460", VA = "0x23B2460", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60012EC")]
				[Address(RVA = "0x23B251C", Offset = "0x23B251C", VA = "0x23B251C", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012ED")]
				[Address(RVA = "0x23B2524", Offset = "0x23B2524", VA = "0x23B2524", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60012EE")]
				[Address(RVA = "0x23B2564", Offset = "0x23B2564", VA = "0x23B2564", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x60012EF")]
				[Address(RVA = "0x23B256C", Offset = "0x23B256C", VA = "0x23B256C", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x60012F0")]
				[Address(RVA = "0x23B262C", Offset = "0x23B262C", VA = "0x23B262C", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000D9A")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000D9B")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000D9C")]
			[FieldOffset(Offset = "0x28")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000D9D")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x17000516")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x60012B2")]
				[Address(RVA = "0x2481490", Offset = "0x2481490", VA = "0x2481490", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000517")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x60012B3")]
				[Address(RVA = "0x24814A8", Offset = "0x24814A8", VA = "0x24814A8", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000518")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x60012B4")]
				[Address(RVA = "0x24814C0", Offset = "0x24814C0", VA = "0x24814C0", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000519")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x60012B5")]
				[Address(RVA = "0x24814C8", Offset = "0x24814C8", VA = "0x24814C8", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700051A")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x60012B6")]
				[Address(RVA = "0x24815F4", Offset = "0x24815F4", VA = "0x24815F4", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700051B")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x60012B7")]
				[Address(RVA = "0x24815DC", Offset = "0x24815DC", VA = "0x24815DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700051C")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x60012B8")]
				[Address(RVA = "0x2481708", Offset = "0x2481708", VA = "0x2481708")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700051D")]
			internal override bool hasData
			{
				[Token(Token = "0x60012B9")]
				[Address(RVA = "0x2481720", Offset = "0x2481720", VA = "0x2481720", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700051E")]
			internal override bool disabled
			{
				[Token(Token = "0x60012BA")]
				[Address(RVA = "0x2481780", Offset = "0x2481780", VA = "0x2481780", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700051F")]
			internal override bool isAllowed
			{
				[Token(Token = "0x60012BB")]
				[Address(RVA = "0x2481794", Offset = "0x2481794", VA = "0x2481794", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000520")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60012BC")]
				[Address(RVA = "0x24817DC", Offset = "0x24817DC", VA = "0x24817DC", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x24811C0", Offset = "0x24811C0", VA = "0x24811C0", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60012BE")]
			[Address(RVA = "0x24817E4", Offset = "0x24817E4", VA = "0x24817E4", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x60012BF")]
			[Address(RVA = "0x2481858", Offset = "0x2481858", VA = "0x2481858", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x60012C0")]
			[Address(RVA = "0x24818CC", Offset = "0x24818CC", VA = "0x24818CC", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x60012C1")]
			[Address(RVA = "0x2481F50", Offset = "0x2481F50", VA = "0x2481F50", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x60012C2")]
			[Address(RVA = "0x248265C", Offset = "0x248265C", VA = "0x248265C", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x60012C3")]
			[Address(RVA = "0x24828A8", Offset = "0x24828A8", VA = "0x24828A8", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x60012C4")]
			[Address(RVA = "0x2482BBC", Offset = "0x2482BBC", VA = "0x2482BBC", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x60012C5")]
			[Address(RVA = "0x2482D54", Offset = "0x2482D54", VA = "0x2482D54", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x60012C6")]
			[Address(RVA = "0x2482D6C", Offset = "0x2482D6C", VA = "0x2482D6C", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x60012C7")]
			[Address(RVA = "0x2482D88", Offset = "0x2482D88", VA = "0x2482D88", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60012C8")]
			[Address(RVA = "0x2481360", Offset = "0x2481360", VA = "0x2481360", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60012C9")]
			[Address(RVA = "0x2481488", Offset = "0x2481488", VA = "0x2481488")]
			public Platform_WebGL_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200028E")]
		public sealed class Platform_WebGL : Platform_WebGL_Base
		{
			[Token(Token = "0x4000DB6")]
			[FieldOffset(Offset = "0x38")]
			public Platform_WebGL_Base[] variants;

			[Token(Token = "0x17000529")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x60012F1")]
				[Address(RVA = "0x24810AC", Offset = "0x24810AC", VA = "0x24810AC", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60012F2")]
			[Address(RVA = "0x24810B4", Offset = "0x24810B4", VA = "0x24810B4", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x60012F3")]
			[Address(RVA = "0x248120C", Offset = "0x248120C", VA = "0x248120C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x60012F4")]
			[Address(RVA = "0x2481290", Offset = "0x2481290", VA = "0x2481290", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x60012F5")]
			[Address(RVA = "0x2481288", Offset = "0x2481288", VA = "0x2481288")]
			public Platform_WebGL()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200028F")]
		public class Platform_AppleGCController_Base : Platform_Custom
		{
			[Serializable]
			[Token(Token = "0x2000290")]
			public new sealed class MatchingCriteria : Platform_Custom.MatchingCriteria
			{
				[Token(Token = "0x4000DBD")]
				[FieldOffset(Offset = "0x29")]
				public bool productCategory_useRegex;

				[Token(Token = "0x4000DBE")]
				[FieldOffset(Offset = "0x30")]
				public string[] productCategory;

				[Token(Token = "0x4000DBF")]
				[FieldOffset(Offset = "0x38")]
				public AppleGCControllerProfileTypeFlags primaryProfileType;

				[Token(Token = "0x4000DC0")]
				[FieldOffset(Offset = "0x40")]
				public AppleGCControllerProfileSubType[] profileSubTypes;

				[Token(Token = "0x17000536")]
				internal override bool hasData
				{
					[Token(Token = "0x600130F")]
					[Address(RVA = "0x23A5DB0", Offset = "0x23A5DB0", VA = "0x23A5DB0", Slot = "5")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000537")]
				internal override bool isAllowed
				{
					[Token(Token = "0x6001310")]
					[Address(RVA = "0x23A5E0C", Offset = "0x23A5E0C", VA = "0x23A5E0C", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001311")]
				[Address(RVA = "0x23A5E48", Offset = "0x23A5E48", VA = "0x23A5E48", Slot = "7")]
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch)
				{
					return default;
				}

				[Token(Token = "0x6001312")]
				[Address(RVA = "0x23A60EC", Offset = "0x23A60EC", VA = "0x23A60EC", Slot = "12")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001313")]
				[Address(RVA = "0x23A616C", Offset = "0x23A616C", VA = "0x23A616C", Slot = "11")]
				internal override void CopyVars(MatchingCriteria_Base destination)
				{
				}

				[Token(Token = "0x6001314")]
				[Address(RVA = "0x23A5FE0", Offset = "0x23A5FE0", VA = "0x23A5FE0")]
				private bool HasProductCategory()
				{
					return default;
				}

				[Token(Token = "0x6001315")]
				[Address(RVA = "0x23A6060", Offset = "0x23A6060", VA = "0x23A6060")]
				private bool ProductCategoryMatches(string name)
				{
					return default;
				}

				[Token(Token = "0x6001316")]
				[Address(RVA = "0x23A6164", Offset = "0x23A6164", VA = "0x23A6164")]
				public MatchingCriteria()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000291")]
			public new sealed class Elements : Platform_Custom.Elements
			{
				[Token(Token = "0x4000DC1")]
				[FieldOffset(Offset = "0x10")]
				public Axis[] axes;

				[Token(Token = "0x4000DC2")]
				[FieldOffset(Offset = "0x18")]
				public Button[] buttons;

				[Token(Token = "0x4000DC3")]
				[FieldOffset(Offset = "0x20")]
				public CompoundElement[] compoundElements;

				[Token(Token = "0x17000538")]
				public override int buttonCount
				{
					[Token(Token = "0x6001317")]
					[Address(RVA = "0x23A59C4", Offset = "0x23A59C4", VA = "0x23A59C4", Slot = "6")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x17000539")]
				public override int axisCount
				{
					[Token(Token = "0x6001318")]
					[Address(RVA = "0x23A59DC", Offset = "0x23A59DC", VA = "0x23A59DC", Slot = "7")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6001319")]
				[Address(RVA = "0x23A59F4", Offset = "0x23A59F4", VA = "0x23A59F4", Slot = "8")]
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
				{
					return default;
				}

				[Token(Token = "0x600131A")]
				[Address(RVA = "0x23A5B18", Offset = "0x23A5B18", VA = "0x23A5B18", Slot = "9")]
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
				{
					return default;
				}

				[Token(Token = "0x600131B")]
				[Address(RVA = "0x23A5C4C", Offset = "0x23A5C4C", VA = "0x23A5C4C", Slot = "10")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600131C")]
				[Address(RVA = "0x23A5CCC", Offset = "0x23A5CCC", VA = "0x23A5CCC", Slot = "5")]
				internal override void CopyVars(Elements_Base destination)
				{
				}

				[Token(Token = "0x600131D")]
				[Address(RVA = "0x23A5CC4", Offset = "0x23A5CC4", VA = "0x23A5CC4")]
				public Elements()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000292")]
			public new sealed class Button : Platform_Custom.Button
			{
				[Token(Token = "0x4000DC4")]
				[FieldOffset(Offset = "0x60")]
				public AppleGCControllerElementIdentifier sourceElementId;

				[Token(Token = "0x600131E")]
				[Address(RVA = "0x23A54A0", Offset = "0x23A54A0", VA = "0x23A54A0", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x600131F")]
				[Address(RVA = "0x23A5520", Offset = "0x23A5520", VA = "0x23A5520", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001320")]
				[Address(RVA = "0x23A5518", Offset = "0x23A5518", VA = "0x23A5518")]
				public Button()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000293")]
			public new sealed class Axis : Platform_Custom.Axis
			{
				[Token(Token = "0x4000DC5")]
				[FieldOffset(Offset = "0x68")]
				public AppleGCControllerElementIdentifier sourceElementId;

				[Token(Token = "0x6001321")]
				[Address(RVA = "0x23A5240", Offset = "0x23A5240", VA = "0x23A5240", Slot = "6")]
				public override object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001322")]
				[Address(RVA = "0x23A52C0", Offset = "0x23A52C0", VA = "0x23A52C0", Slot = "5")]
				internal override void CopyVars(Element destination)
				{
				}

				[Token(Token = "0x6001323")]
				[Address(RVA = "0x23A52B8", Offset = "0x23A52B8", VA = "0x23A52B8")]
				public Axis()
				{
				}
			}

			[Serializable]
			[Token(Token = "0x2000294")]
			public sealed class CompoundElement : IDeepCloneable
			{
				[Token(Token = "0x4000DC6")]
				[FieldOffset(Offset = "0x10")]
				public int elementIdentifier;

				[Token(Token = "0x4000DC7")]
				[FieldOffset(Offset = "0x14")]
				public int sourceElementIndex;

				[Token(Token = "0x4000DC8")]
				[FieldOffset(Offset = "0x18")]
				public AppleGCControllerElementIdentifierCompoundElements sourceElementId;

				[Token(Token = "0x6001324")]
				[Address(RVA = "0x23A591C", Offset = "0x23A591C", VA = "0x23A591C")]
				internal void CopyVars(CompoundElement destination)
				{
				}

				[Token(Token = "0x6001325")]
				[Address(RVA = "0x23A5940", Offset = "0x23A5940", VA = "0x23A5940", Slot = "4")]
				public object DeepClone()
				{
					return null;
				}

				[Token(Token = "0x6001326")]
				[Address(RVA = "0x23A59BC", Offset = "0x23A59BC", VA = "0x23A59BC")]
				public CompoundElement()
				{
				}
			}

			[Token(Token = "0x2000295")]
			[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x19191C", Offset = "0x19191C")]
			public enum AppleGCControllerProfileTypeFlags
			{
				[Token(Token = "0x4000DCA")]
				None = 0,
				[Token(Token = "0x4000DCB")]
				Generic = 1,
				[Token(Token = "0x4000DCC")]
				ExtendedGamepad = 2,
				[Token(Token = "0x4000DCD")]
				MicroGamepad = 4,
				[Token(Token = "0x4000DCE")]
				Unknown = int.MinValue
			}

			[Token(Token = "0x2000296")]
			[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191930", Offset = "0x191930")]
			public enum AppleGCControllerProfileSubType
			{
				[Token(Token = "0x4000DD0")]
				None = 0,
				[Token(Token = "0x4000DD1")]
				Xbox = 1,
				[Token(Token = "0x4000DD2")]
				DualShock = 2,
				[Token(Token = "0x4000DD3")]
				DualSense = 3,
				[Token(Token = "0x4000DD4")]
				Unknown = -1
			}

			[Token(Token = "0x2000297")]
			[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191944", Offset = "0x191944")]
			public enum AppleGCControllerElementIdentifier
			{
				[Token(Token = "0x4000DD6")]
				None = 0,
				[Token(Token = "0x4000DD7")]
				A = 1,
				[Token(Token = "0x4000DD8")]
				B = 2,
				[Token(Token = "0x4000DD9")]
				X = 3,
				[Token(Token = "0x4000DDA")]
				Y = 4,
				[Token(Token = "0x4000DDB")]
				LeftShoulder = 5,
				[Token(Token = "0x4000DDC")]
				RightShoulder = 6,
				[Token(Token = "0x4000DDD")]
				Menu = 7,
				[Token(Token = "0x4000DDE")]
				Options = 8,
				[Token(Token = "0x4000DDF")]
				Home = 9,
				[Token(Token = "0x4000DE0")]
				LeftStickButton = 10,
				[Token(Token = "0x4000DE1")]
				RightStickButton = 11,
				[Token(Token = "0x4000DE2")]
				DPadUp = 12,
				[Token(Token = "0x4000DE3")]
				DPadRight = 13,
				[Token(Token = "0x4000DE4")]
				DPadDown = 14,
				[Token(Token = "0x4000DE5")]
				DPadLeft = 15,
				[Token(Token = "0x4000DE6")]
				LeftStickX = 16,
				[Token(Token = "0x4000DE7")]
				LeftStickY = 17,
				[Token(Token = "0x4000DE8")]
				RightStickX = 18,
				[Token(Token = "0x4000DE9")]
				RightStickY = 19,
				[Token(Token = "0x4000DEA")]
				LeftTrigger = 20,
				[Token(Token = "0x4000DEB")]
				RightTrigger = 21,
				[Token(Token = "0x4000DEC")]
				DPadVertical = 22,
				[Token(Token = "0x4000DED")]
				DPadHorizontal = 23,
				[Token(Token = "0x4000DEE")]
				TouchpadButton = 24,
				[Token(Token = "0x4000DEF")]
				Paddle1 = 25,
				[Token(Token = "0x4000DF0")]
				Paddle2 = 26,
				[Token(Token = "0x4000DF1")]
				Paddle3 = 27,
				[Token(Token = "0x4000DF2")]
				Paddle4 = 28,
				[Token(Token = "0x4000DF3")]
				IndexedButton = 29,
				[Token(Token = "0x4000DF4")]
				IndexedAxis = 30
			}

			[Token(Token = "0x2000298")]
			[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x191958", Offset = "0x191958")]
			public enum AppleGCControllerElementIdentifierCompoundElements
			{
				[Token(Token = "0x4000DF6")]
				None = 0,
				[Token(Token = "0x4000DF7")]
				IndexedStick = 31,
				[Token(Token = "0x4000DF8")]
				IndexedDPad = 32,
				[Token(Token = "0x4000DF9")]
				LeftStick = 33,
				[Token(Token = "0x4000DFA")]
				RightStick = 34,
				[Token(Token = "0x4000DFB")]
				DPad = 35
			}

			[Token(Token = "0x2000299")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19196C", Offset = "0x19196C")]
			private sealed class CPvoucKmEzEMFbWuObePjWBmemXyA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Axis>, IEnumerator<Platform_Custom.Axis>
			{
				[Token(Token = "0x4000DFC")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000DFD")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Axis VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000DFE")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000DFF")]
				[FieldOffset(Offset = "0x28")]
				public Platform_AppleGCController_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000E00")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x1700053A")]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002ECurrent
				{
					[Token(Token = "0x600132A")]
					[Address(RVA = "0x23A5808", Offset = "0x23A5808", VA = "0x23A5808", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700053B")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600132C")]
					[Address(RVA = "0x23A5850", Offset = "0x23A5850", VA = "0x23A5850", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001327")]
				[Address(RVA = "0x23A5700", Offset = "0x23A5700", VA = "0x23A5700")]
				[DebuggerHidden]
				public CPvoucKmEzEMFbWuObePjWBmemXyA(int P_0)
				{
				}

				[Token(Token = "0x6001328")]
				[Address(RVA = "0x23A5748", Offset = "0x23A5748", VA = "0x23A5748", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001329")]
				[Address(RVA = "0x23A574C", Offset = "0x23A574C", VA = "0x23A574C", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600132A")]
				[Address(RVA = "0x23A5808", Offset = "0x23A5808", VA = "0x23A5808", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Axis System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600132B")]
				[Address(RVA = "0x23A5810", Offset = "0x23A5810", VA = "0x23A5810", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600132C")]
				[Address(RVA = "0x23A5850", Offset = "0x23A5850", VA = "0x23A5850", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600132D")]
				[Address(RVA = "0x23A5858", Offset = "0x23A5858", VA = "0x23A5858", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Axis> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EAxis_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x600132E")]
				[Address(RVA = "0x23A5918", Offset = "0x23A5918", VA = "0x23A5918", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x200029A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19197C", Offset = "0x19197C")]
			private sealed class lnXEjlWkjmxfeNhLqZSHpfqLgoGkA : IDisposable, IEnumerable, IEnumerator, IEnumerable<Platform_Custom.Button>, IEnumerator<Platform_Custom.Button>
			{
				[Token(Token = "0x4000E01")]
				[FieldOffset(Offset = "0x10")]
				private int RxAoyfYzYDsYonLGXsvUgwChukLk;

				[Token(Token = "0x4000E02")]
				[FieldOffset(Offset = "0x18")]
				private Platform_Custom.Button VqEePGSMyrGKIqkWibsjeHcWPSIx;

				[Token(Token = "0x4000E03")]
				[FieldOffset(Offset = "0x20")]
				private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

				[Token(Token = "0x4000E04")]
				[FieldOffset(Offset = "0x28")]
				public Platform_AppleGCController_Base TtytLoUfsgUyhsklaKccrnoMiiek;

				[Token(Token = "0x4000E05")]
				[FieldOffset(Offset = "0x30")]
				private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

				[Token(Token = "0x1700053C")]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002ECurrent
				{
					[Token(Token = "0x6001332")]
					[Address(RVA = "0x23A6344", Offset = "0x23A6344", VA = "0x23A6344", Slot = "10")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700053D")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001334")]
					[Address(RVA = "0x23A638C", Offset = "0x23A638C", VA = "0x23A638C", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600132F")]
				[Address(RVA = "0x23A623C", Offset = "0x23A623C", VA = "0x23A623C")]
				[DebuggerHidden]
				public lnXEjlWkjmxfeNhLqZSHpfqLgoGkA(int P_0)
				{
				}

				[Token(Token = "0x6001330")]
				[Address(RVA = "0x23A6284", Offset = "0x23A6284", VA = "0x23A6284", Slot = "4")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6001331")]
				[Address(RVA = "0x23A6288", Offset = "0x23A6288", VA = "0x23A6288", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001332")]
				[Address(RVA = "0x23A6344", Offset = "0x23A6344", VA = "0x23A6344", Slot = "10")]
				[DebuggerHidden]
				private Platform_Custom.Button System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001333")]
				[Address(RVA = "0x23A634C", Offset = "0x23A634C", VA = "0x23A634C", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x6001334")]
				[Address(RVA = "0x23A638C", Offset = "0x23A638C", VA = "0x23A638C", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001335")]
				[Address(RVA = "0x23A6394", Offset = "0x23A6394", VA = "0x23A6394", Slot = "9")]
				[DebuggerHidden]
				private IEnumerator<Platform_Custom.Button> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EData_002EMapping_002EHardwareJoystickMap_002EPlatform_Custom_002EButton_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6001336")]
				[Address(RVA = "0x23A6454", Offset = "0x23A6454", VA = "0x23A6454", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000DB7")]
			[FieldOffset(Offset = "0x18")]
			public MatchingCriteria matchingCriteria;

			[Token(Token = "0x4000DB8")]
			[FieldOffset(Offset = "0x20")]
			public Elements elements;

			[Token(Token = "0x4000DB9")]
			[FieldOffset(Offset = "0x28")]
			public string controllerName;

			[Token(Token = "0x4000DBA")]
			[FieldOffset(Offset = "0x30")]
			private Platform_Custom.Axis[] _axesOrigGame;

			[Token(Token = "0x4000DBB")]
			[FieldOffset(Offset = "0x38")]
			private Platform_Custom.Button[] _buttonsOrigGame;

			[Token(Token = "0x4000DBC")]
			[FieldOffset(Offset = "0x40")]
			private CompoundElement[] _compoundElementsOrigGame;

			[Token(Token = "0x1700052A")]
			public override int assignedButtonCount
			{
				[Token(Token = "0x60012F6")]
				[Address(RVA = "0x2469C58", Offset = "0x2469C58", VA = "0x2469C58", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700052B")]
			public override int assignedAxisCount
			{
				[Token(Token = "0x60012F7")]
				[Address(RVA = "0x2469C70", Offset = "0x2469C70", VA = "0x2469C70", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700052C")]
			public override string controllerNameOverride
			{
				[Token(Token = "0x60012F8")]
				[Address(RVA = "0x2469C88", Offset = "0x2469C88", VA = "0x2469C88", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700052D")]
			internal override InputPlatform platform
			{
				[Token(Token = "0x60012F9")]
				[Address(RVA = "0x2469C90", Offset = "0x2469C90", VA = "0x2469C90", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700052E")]
			internal override Platform_Custom.Axis[] Axes
			{
				[Token(Token = "0x60012FA")]
				[Address(RVA = "0x2469C98", Offset = "0x2469C98", VA = "0x2469C98", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700052F")]
			internal override Platform_Custom.Button[] Buttons
			{
				[Token(Token = "0x60012FB")]
				[Address(RVA = "0x2469DC4", Offset = "0x2469DC4", VA = "0x2469DC4", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000530")]
			internal Axis[] Axes_orig
			{
				[Token(Token = "0x60012FC")]
				[Address(RVA = "0x2469DAC", Offset = "0x2469DAC", VA = "0x2469DAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000531")]
			internal Button[] Buttons_orig
			{
				[Token(Token = "0x60012FD")]
				[Address(RVA = "0x2469ED8", Offset = "0x2469ED8", VA = "0x2469ED8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000532")]
			internal override bool hasData
			{
				[Token(Token = "0x60012FE")]
				[Address(RVA = "0x2469EF0", Offset = "0x2469EF0", VA = "0x2469EF0", Slot = "13")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000533")]
			internal override bool disabled
			{
				[Token(Token = "0x60012FF")]
				[Address(RVA = "0x2469F50", Offset = "0x2469F50", VA = "0x2469F50", Slot = "14")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000534")]
			internal override bool isAllowed
			{
				[Token(Token = "0x6001300")]
				[Address(RVA = "0x2469F64", Offset = "0x2469F64", VA = "0x2469F64", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000535")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001301")]
				[Address(RVA = "0x2469FE4", Offset = "0x2469FE4", VA = "0x2469FE4", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001302")]
			[Address(RVA = "0x2469994", Offset = "0x2469994", VA = "0x2469994", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001303")]
			[Address(RVA = "0x2469FEC", Offset = "0x2469FEC", VA = "0x2469FEC", Slot = "25")]
			internal override IEnumerable<Platform_Custom.Axis> IterateAxes()
			{
				return null;
			}

			[Token(Token = "0x6001304")]
			[Address(RVA = "0x246A060", Offset = "0x246A060", VA = "0x246A060", Slot = "26")]
			internal override IEnumerable<Platform_Custom.Button> IterateButtons()
			{
				return null;
			}

			[Token(Token = "0x6001305")]
			[Address(RVA = "0x246A0D4", Offset = "0x246A0D4", VA = "0x246A0D4", Slot = "12")]
			internal override bool IsElementIdentifierMapped(int elementIdentifierId)
			{
				return default;
			}

			[Token(Token = "0x6001306")]
			[Address(RVA = "0x246A758", Offset = "0x246A758", VA = "0x246A758", Slot = "11")]
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes)
			{
			}

			[Token(Token = "0x6001307")]
			[Address(RVA = "0x246AE64", Offset = "0x246AE64", VA = "0x246AE64", Slot = "16")]
			internal override AxisCalibrationData[] GetAxisCalibrationData()
			{
				return null;
			}

			[Token(Token = "0x6001308")]
			[Address(RVA = "0x246B0AC", Offset = "0x246B0AC", VA = "0x246B0AC", Slot = "17")]
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos)
			{
			}

			[Token(Token = "0x6001309")]
			[Address(RVA = "0x246B3C0", Offset = "0x246B3C0", VA = "0x246B3C0", Slot = "18")]
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos)
			{
			}

			[Token(Token = "0x600130A")]
			[Address(RVA = "0x246B558", Offset = "0x246B558", VA = "0x246B558", Slot = "19")]
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier)
			{
				return default;
			}

			[Token(Token = "0x600130B")]
			[Address(RVA = "0x246B570", Offset = "0x246B570", VA = "0x246B570", Slot = "20")]
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange)
			{
				return default;
			}

			[Token(Token = "0x600130C")]
			[Address(RVA = "0x246B58C", Offset = "0x246B58C", VA = "0x246B58C", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x600130D")]
			[Address(RVA = "0x2469B34", Offset = "0x2469B34", VA = "0x2469B34", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600130E")]
			[Address(RVA = "0x2469C50", Offset = "0x2469C50", VA = "0x2469C50")]
			public Platform_AppleGCController_Base()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200029B")]
		public sealed class Platform_AppleGCController : Platform_AppleGCController_Base
		{
			[Token(Token = "0x4000E06")]
			[FieldOffset(Offset = "0x48")]
			public Platform_AppleGCController_Base[] variants;

			[Token(Token = "0x1700053E")]
			internal override IList<Platform> variants_base
			{
				[Token(Token = "0x6001337")]
				[Address(RVA = "0x2469880", Offset = "0x2469880", VA = "0x2469880", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001338")]
			[Address(RVA = "0x2469888", Offset = "0x2469888", VA = "0x2469888", Slot = "10")]
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
			{
				return default;
			}

			[Token(Token = "0x6001339")]
			[Address(RVA = "0x24699E0", Offset = "0x24699E0", VA = "0x24699E0", Slot = "21")]
			public override object DeepClone()
			{
				return null;
			}

			[Token(Token = "0x600133A")]
			[Address(RVA = "0x2469A64", Offset = "0x2469A64", VA = "0x2469A64", Slot = "22")]
			internal override void CopyVars(Platform destination)
			{
			}

			[Token(Token = "0x600133B")]
			[Address(RVA = "0x2469A5C", Offset = "0x2469A5C", VA = "0x2469A5C")]
			public Platform_AppleGCController()
			{
			}
		}

		[Token(Token = "0x200029C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19198C", Offset = "0x19198C")]
		private sealed class BhOqcGDGxzWvMnscUacFkkAhpmSy : IDisposable, IEnumerable, IEnumerator, IEnumerable<IControllerElementIdentifierCommon_Internal>, IEnumerator<IControllerElementIdentifierCommon_Internal>
		{
			[Token(Token = "0x4000E07")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000E08")]
			[FieldOffset(Offset = "0x18")]
			private IControllerElementIdentifierCommon_Internal VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000E09")]
			[FieldOffset(Offset = "0x20")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000E0A")]
			[FieldOffset(Offset = "0x28")]
			public HardwareJoystickMap TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000E0B")]
			[FieldOffset(Offset = "0x30")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x1700053F")]
			private IControllerElementIdentifierCommon_Internal System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002ECurrent
			{
				[Token(Token = "0x600133F")]
				[Address(RVA = "0x246632C", Offset = "0x246632C", VA = "0x246632C", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000540")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001341")]
				[Address(RVA = "0x2466374", Offset = "0x2466374", VA = "0x2466374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600133C")]
			[Address(RVA = "0x2466234", Offset = "0x2466234", VA = "0x2466234")]
			[DebuggerHidden]
			public BhOqcGDGxzWvMnscUacFkkAhpmSy(int P_0)
			{
			}

			[Token(Token = "0x600133D")]
			[Address(RVA = "0x246627C", Offset = "0x246627C", VA = "0x246627C", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600133E")]
			[Address(RVA = "0x2466280", Offset = "0x2466280", VA = "0x2466280", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600133F")]
			[Address(RVA = "0x246632C", Offset = "0x246632C", VA = "0x246632C", Slot = "10")]
			[DebuggerHidden]
			private IControllerElementIdentifierCommon_Internal System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001340")]
			[Address(RVA = "0x2466334", Offset = "0x2466334", VA = "0x2466334", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001341")]
			[Address(RVA = "0x2466374", Offset = "0x2466374", VA = "0x2466374", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001342")]
			[Address(RVA = "0x246637C", Offset = "0x246637C", VA = "0x246637C", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<IControllerElementIdentifierCommon_Internal> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EInterfaces_002EIControllerElementIdentifierCommon_Internal_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001343")]
			[Address(RVA = "0x246643C", Offset = "0x246643C", VA = "0x246643C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200029D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x19199C", Offset = "0x19199C")]
		private sealed class BiadorJhJQaOivPsmjdDkMbXajES : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerElementIdentifier>, IEnumerator<ControllerElementIdentifier>
		{
			[Token(Token = "0x4000E0C")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000E0D")]
			[FieldOffset(Offset = "0x18")]
			private ControllerElementIdentifier VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000E0E")]
			[FieldOffset(Offset = "0x20")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000E0F")]
			[FieldOffset(Offset = "0x28")]
			public HardwareJoystickMap TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000E10")]
			[FieldOffset(Offset = "0x30")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x17000541")]
			private ControllerElementIdentifier System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerElementIdentifier_003E_002ECurrent
			{
				[Token(Token = "0x6001347")]
				[Address(RVA = "0x2466538", Offset = "0x2466538", VA = "0x2466538", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerElementIdentifier_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000542")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001349")]
				[Address(RVA = "0x2466580", Offset = "0x2466580", VA = "0x2466580", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001344")]
			[Address(RVA = "0x2466440", Offset = "0x2466440", VA = "0x2466440")]
			[DebuggerHidden]
			public BiadorJhJQaOivPsmjdDkMbXajES(int P_0)
			{
			}

			[Token(Token = "0x6001345")]
			[Address(RVA = "0x2466488", Offset = "0x2466488", VA = "0x2466488", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001346")]
			[Address(RVA = "0x246648C", Offset = "0x246648C", VA = "0x246648C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001347")]
			[Address(RVA = "0x2466538", Offset = "0x2466538", VA = "0x2466538", Slot = "10")]
			[DebuggerHidden]
			private ControllerElementIdentifier System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerElementIdentifier_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001348")]
			[Address(RVA = "0x2466540", Offset = "0x2466540", VA = "0x2466540", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001349")]
			[Address(RVA = "0x2466580", Offset = "0x2466580", VA = "0x2466580", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600134A")]
			[Address(RVA = "0x2466588", Offset = "0x2466588", VA = "0x2466588", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<ControllerElementIdentifier> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EControllerElementIdentifier_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600134B")]
			[Address(RVA = "0x2466648", Offset = "0x2466648", VA = "0x2466648", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200029E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1919AC", Offset = "0x1919AC")]
		private sealed class kgKqGKgKPgxcqmKoPLbfqJjQcNfb : IDisposable, IEnumerable, IEnumerator, IEnumerable<JoystickType>, IEnumerator<JoystickType>
		{
			[Token(Token = "0x4000E11")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000E12")]
			[FieldOffset(Offset = "0x14")]
			private JoystickType VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000E13")]
			[FieldOffset(Offset = "0x18")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000E14")]
			[FieldOffset(Offset = "0x20")]
			public HardwareJoystickMap TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000E15")]
			[FieldOffset(Offset = "0x28")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x17000543")]
			private JoystickType System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EJoystickType_003E_002ECurrent
			{
				[Token(Token = "0x600134F")]
				[Address(RVA = "0x2488534", Offset = "0x2488534", VA = "0x2488534", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EJoystickType_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000544")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001351")]
				[Address(RVA = "0x248857C", Offset = "0x248857C", VA = "0x248857C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600134C")]
			[Address(RVA = "0x2488440", Offset = "0x2488440", VA = "0x2488440")]
			[DebuggerHidden]
			public kgKqGKgKPgxcqmKoPLbfqJjQcNfb(int P_0)
			{
			}

			[Token(Token = "0x600134D")]
			[Address(RVA = "0x2488488", Offset = "0x2488488", VA = "0x2488488", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600134E")]
			[Address(RVA = "0x248848C", Offset = "0x248848C", VA = "0x248848C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600134F")]
			[Address(RVA = "0x2488534", Offset = "0x2488534", VA = "0x2488534", Slot = "10")]
			[DebuggerHidden]
			private JoystickType System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EJoystickType_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6001350")]
			[Address(RVA = "0x248853C", Offset = "0x248853C", VA = "0x248853C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001351")]
			[Address(RVA = "0x248857C", Offset = "0x248857C", VA = "0x248857C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001352")]
			[Address(RVA = "0x24885E4", Offset = "0x24885E4", VA = "0x24885E4", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<JoystickType> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EJoystickType_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001353")]
			[Address(RVA = "0x24886A4", Offset = "0x24886A4", VA = "0x24886A4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200029F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1919BC", Offset = "0x1919BC")]
		private sealed class UNKPwqHUYvGvQgZxECtDVoTAnikj : IDisposable, IEnumerable, IEnumerator, IEnumerable<Guid>, IEnumerator<Guid>
		{
			[Token(Token = "0x4000E16")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000E17")]
			[FieldOffset(Offset = "0x14")]
			private Guid VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000E18")]
			[FieldOffset(Offset = "0x24")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000E19")]
			[FieldOffset(Offset = "0x28")]
			public HardwareJoystickMap TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000E1A")]
			[FieldOffset(Offset = "0x30")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x17000545")]
			private Guid System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EGuid_003E_002ECurrent
			{
				[Token(Token = "0x6001357")]
				[Address(RVA = "0x24882B8", Offset = "0x24882B8", VA = "0x24882B8", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EGuid_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000546")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001359")]
				[Address(RVA = "0x2488308", Offset = "0x2488308", VA = "0x2488308", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001354")]
			[Address(RVA = "0x2488164", Offset = "0x2488164", VA = "0x2488164")]
			[DebuggerHidden]
			public UNKPwqHUYvGvQgZxECtDVoTAnikj(int P_0)
			{
			}

			[Token(Token = "0x6001355")]
			[Address(RVA = "0x24881AC", Offset = "0x24881AC", VA = "0x24881AC", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001356")]
			[Address(RVA = "0x24881B0", Offset = "0x24881B0", VA = "0x24881B0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001357")]
			[Address(RVA = "0x24882B8", Offset = "0x24882B8", VA = "0x24882B8", Slot = "10")]
			[DebuggerHidden]
			private Guid System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EGuid_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6001358")]
			[Address(RVA = "0x24882C8", Offset = "0x24882C8", VA = "0x24882C8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001359")]
			[Address(RVA = "0x2488308", Offset = "0x2488308", VA = "0x2488308", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600135A")]
			[Address(RVA = "0x2488374", Offset = "0x2488374", VA = "0x2488374", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<Guid> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EGuid_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600135B")]
			[Address(RVA = "0x2488434", Offset = "0x2488434", VA = "0x2488434", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string controllerName;

		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string editorControllerName;

		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string description;

		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string controllerGuid;

		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] templateGuids;

		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool hideInLists;

		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private JoystickType[] joystickTypes;

		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ControllerElementIdentifier[] elementIdentifiers;

		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CompoundElement[] compoundElements;

		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Platform_DirectInput directInput;

		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Platform_RawInput rawInput;

		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Platform_XInput xInput;

		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Platform_OSX osx;

		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Platform_Linux linux;

		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Platform_WindowsUWP windowsUWP;

		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Platform_Fallback fallback_Windows;

		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Platform_Fallback fallback_WindowsUWP;

		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Platform_Fallback fallback_OSX;

		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Platform_Fallback fallback_Linux;

		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Platform_Fallback fallback_Linux_PreConfigured;

		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Platform_Fallback fallback_Android;

		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Platform_Fallback fallback_iOS;

		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Platform_Fallback fallback_XBoxOne;

		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Platform_Fallback fallback_PS4;

		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Platform_PS5 ps5;

		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Platform_Fallback fallback_PSM;

		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Platform_Fallback fallback_PSVita;

		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Platform_Fallback fallback_AmazonFireTV;

		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Platform_WebGL webGL;

		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Platform_XboxOne xboxOne;

		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Platform_GameCore gameCore;

		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Platform_PS4 ps4;

		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Platform_NintendoSwitch nintendoSwitch;

		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Platform_Stadia stadia;

		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Platform_InternalDriver internalDriver;

		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Platform_SDL2 sdl2_Linux;

		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Platform_SDL2 sdl2_Windows;

		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Platform_SDL2 sdl2_OSX;

		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Platform_AppleGCController appleGCController;

		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private int elementIdentifierIdCounter;

		[Token(Token = "0x170003D1")]
		public string ControllerName
		{
			[Token(Token = "0x6000E35")]
			[Address(RVA = "0x23CD390", Offset = "0x23CD390", VA = "0x23CD390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D2")]
		public string EditorControllerName
		{
			[Token(Token = "0x6000E36")]
			[Address(RVA = "0x23CD398", Offset = "0x23CD398", VA = "0x23CD398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D3")]
		public Guid Guid
		{
			[Token(Token = "0x6000E37")]
			[Address(RVA = "0x23CD3A0", Offset = "0x23CD3A0", VA = "0x23CD3A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003D4")]
		public IEnumerable<Guid> TemplateGuids
		{
			[Token(Token = "0x6000E38")]
			[Address(RVA = "0x23CD418", Offset = "0x23CD418", VA = "0x23CD418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D5")]
		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers
		{
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x23CD48C", Offset = "0x23CD48C", VA = "0x23CD48C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D6")]
		public int elementIdentifierCount
		{
			[Token(Token = "0x6000E3A")]
			[Address(RVA = "0x23CD500", Offset = "0x23CD500", VA = "0x23CD500")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003D7")]
		public bool HideInLists
		{
			[Token(Token = "0x6000E3B")]
			[Address(RVA = "0x23CD518", Offset = "0x23CD518", VA = "0x23CD518")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003D8")]
		internal IEnumerable<JoystickType> JoystickTypes
		{
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x23CD520", Offset = "0x23CD520", VA = "0x23CD520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D9")]
		private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002EElementIdentifiers
		{
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x23CF128", Offset = "0x23CF128", VA = "0x23CF128", Slot = "4")]
			get
			{
				return Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002Eget_ElementIdentifiers();
			}
		}

		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x23CC180", Offset = "0x23CC180", VA = "0x23CC180")]
		public HardwareJoystickMap()
		{
		}

		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x23CC860", Offset = "0x23CC860", VA = "0x23CC860")]
		public HardwareJoystickMap(HardwareJoystickMap P_0)
		{
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x23CD594", Offset = "0x23CD594", VA = "0x23CD594", Slot = "6")]
		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x23CD6A8", Offset = "0x23CD6A8", VA = "0x23CD6A8", Slot = "7")]
		public int[] GetElementIdentifierIds()
		{
			return null;
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x23CD780", Offset = "0x23CD780", VA = "0x23CD780")]
		public ControllerElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x23CD864", Offset = "0x23CD864", VA = "0x23CD864", Slot = "8")]
		public bool ContainsElementIdentifier(int id)
		{
			return default;
		}

		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x23CD8D0", Offset = "0x23CD8D0", VA = "0x23CD8D0")]
		public int GetElementIdentifierInfo(ControllerElementType type, out string[] names, out int[] ids)
		{
			return default;
		}

		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x23CDB40", Offset = "0x23CDB40", VA = "0x23CDB40", Slot = "9")]
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			return default;
		}

		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x23CDDB8", Offset = "0x23CDDB8", VA = "0x23CDDB8")]
		internal HardwareJoystickMap Clone()
		{
			return null;
		}

		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x23CD810", Offset = "0x23CD810", VA = "0x23CD810")]
		internal int IndexOfElementIdentifier(int id)
		{
			return default;
		}

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x23CDE1C", Offset = "0x23CDE1C", VA = "0x23CDE1C")]
		internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap)
		{
			return default;
		}

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x23CDF34", Offset = "0x23CDF34", VA = "0x23CDF34")]
		internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange)
		{
			return default;
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x23CE028", Offset = "0x23CE028", VA = "0x23CE028")]
		internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out int[] buttons, out int[] axes)
		{
		}

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x23CE0C4", Offset = "0x23CE0C4", VA = "0x23CE0C4")]
		internal static bool Matches(Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap)
		{
			return default;
		}

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x23CE0E4", Offset = "0x23CE0E4", VA = "0x23CE0E4")]
		internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out Platform platformMap)
		{
			return default;
		}

		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x23CE990", Offset = "0x23CE990", VA = "0x23CE990")]
		internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController)
		{
			return null;
		}

		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x23CF120", Offset = "0x23CF120", VA = "0x23CF120")]
		internal string[] GetTemplateGuidsOrig()
		{
			return null;
		}

		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x23CF128", Offset = "0x23CF128", VA = "0x23CF128", Slot = "4")]
		private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002Eget_ElementIdentifiers()
		{
			return null;
		}

		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x23CF19C", Offset = "0x23CF19C", VA = "0x23CF19C", Slot = "5")]
		private IControllerElementIdentifierCommon_Internal Rewired_002EData_002EMapping_002EIHardwareControllerMap_Internal_002EGetElementIdentifier(int id)
		{
			return null;
		}

		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x23CE448", Offset = "0x23CE448", VA = "0x23CE448")]
		private Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex)
		{
			return null;
		}

		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x23CEC10", Offset = "0x23CEC10", VA = "0x23CEC10")]
		private Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex)
		{
			return null;
		}

		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x23CE7FC", Offset = "0x23CE7FC", VA = "0x23CE7FC")]
		private Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex)
		{
			return null;
		}

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x23CEF8C", Offset = "0x23CEF8C", VA = "0x23CEF8C")]
		private Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex)
		{
			return null;
		}

		[Token(Token = "0x6000E52")]
		private T TryGetFirstValidMap<T>(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) where T : Platform
		{
			return null;
		}

		[Token(Token = "0x6000E53")]
		private T TryGetFirstMatchingMap<T>(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) where T : Platform
		{
			return null;
		}

		[Token(Token = "0x6000E54")]
		private T GetUniversalDefaultMap<T>(out InputPlatform actualInputPlatform, out int variantIndex) where T : Platform
		{
			return null;
		}

		[Token(Token = "0x6000E55")]
		private T GetUniversalDefaultMapRoot<T>(Type type, out InputPlatform actualInputPlatform) where T : Platform
		{
			return null;
		}

		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x23CDEF8", Offset = "0x23CDEF8", VA = "0x23CDEF8")]
		private Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier)
		{
			return null;
		}

		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x23CF22C", Offset = "0x23CF22C", VA = "0x23CF22C")]
		private Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform)
		{
			return null;
		}
	}
}
