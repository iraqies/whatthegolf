using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002D5")]
	[DisallowMultipleComponent]
	public sealed class TouchButton : TouchInteractable
	{
		[Token(Token = "0x20002D6")]
		public enum ButtonType
		{
			[Token(Token = "0x4000EFE")]
			Standard = 0,
			[Token(Token = "0x4000EFF")]
			ToggleSwitch = 1
		}

		[Token(Token = "0x20002D7")]
		private enum OpkLqbttkDfdWPvVmlLCialkmZyE
		{
			[Token(Token = "0x4000F01")]
			None = 0,
			[Token(Token = "0x4000F02")]
			TowardTouch = 1,
			[Token(Token = "0x4000F03")]
			TowardHome = 2
		}

		[Token(Token = "0x20002D8")]
		private enum KNuxcpaopMTVUOnDxSWfwXInKYgs
		{
			[Token(Token = "0x4000F05")]
			Local = 0,
			[Token(Token = "0x4000F06")]
			TouchRegion = 1
		}

		[Serializable]
		[Token(Token = "0x20002D9")]
		public class AxisValueChangedEventHandler : UnityEvent<float>
		{
			[Token(Token = "0x6001571")]
			[Address(RVA = "0x2398CAC", Offset = "0x2398CAC", VA = "0x2398CAC")]
			public AxisValueChangedEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002DA")]
		public class ButtonValueChangedEventHandler : UnityEvent<bool>
		{
			[Token(Token = "0x6001572")]
			[Address(RVA = "0x2398D14", Offset = "0x2398D14", VA = "0x2398D14")]
			public ButtonValueChangedEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002DB")]
		public class ButtonDownEventHandler : UnityEvent
		{
			[Token(Token = "0x6001573")]
			[Address(RVA = "0x2398D04", Offset = "0x2398D04", VA = "0x2398D04")]
			public ButtonDownEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002DC")]
		public class ButtonUpEventHandler : UnityEvent
		{
			[Token(Token = "0x6001574")]
			[Address(RVA = "0x2398D0C", Offset = "0x2398D0C", VA = "0x2398D0C")]
			public ButtonUpEventHandler()
			{
			}
		}

		[Token(Token = "0x20002DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191A8C", Offset = "0x191A8C")]
		private sealed class KykhxUELCIErMkPZtnTHwKXXpCVb : IDisposable, IEnumerator, IEnumerator<object>
		{
			[Token(Token = "0x4000F07")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000F08")]
			[FieldOffset(Offset = "0x18")]
			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000F09")]
			[FieldOffset(Offset = "0x20")]
			public float QzkoAujiXELSEATTFbUXkPALueUS;

			[Token(Token = "0x4000F0A")]
			[FieldOffset(Offset = "0x28")]
			public TouchButton TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000F0B")]
			[FieldOffset(Offset = "0x30")]
			public PositionType NrdyBFMMWwnWFfEyWKBnxrSnZvnA;

			[Token(Token = "0x4000F0C")]
			[FieldOffset(Offset = "0x34")]
			public Vector2 JTKktbfSAqGDQjeacpqTtOeybKpt;

			[Token(Token = "0x4000F0D")]
			[FieldOffset(Offset = "0x3C")]
			public OpkLqbttkDfdWPvVmlLCialkmZyE sGqbUlnFwRgsWfMjUESVfFgHGuQnb;

			[Token(Token = "0x4000F0E")]
			[FieldOffset(Offset = "0x40")]
			private RectTransform zhIaopVbzvThffCKABmaaMXeNOEU;

			[Token(Token = "0x4000F0F")]
			[FieldOffset(Offset = "0x48")]
			private Vector2 MAKcOIKScodBQvETwJwUTnXGybGz;

			[Token(Token = "0x4000F10")]
			[FieldOffset(Offset = "0x50")]
			private float EqWwPxCLglgHGkbPhQwGHBtsGbeTA;

			[Token(Token = "0x4000F11")]
			[FieldOffset(Offset = "0x54")]
			private float ifUZPTedFJKUBUSvTHjRpfgDkWRg;

			[Token(Token = "0x170005C6")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6001578")]
				[Address(RVA = "0x2398F24", Offset = "0x2398F24", VA = "0x2398F24", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170005C7")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600157A")]
				[Address(RVA = "0x2398F6C", Offset = "0x2398F6C", VA = "0x2398F6C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001575")]
			[Address(RVA = "0x2398D6C", Offset = "0x2398D6C", VA = "0x2398D6C")]
			[DebuggerHidden]
			public KykhxUELCIErMkPZtnTHwKXXpCVb(int P_0)
			{
			}

			[Token(Token = "0x6001576")]
			[Address(RVA = "0x2398D98", Offset = "0x2398D98", VA = "0x2398D98", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001577")]
			[Address(RVA = "0x2398D9C", Offset = "0x2398D9C", VA = "0x2398D9C", Slot = "5")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001578")]
			[Address(RVA = "0x2398F24", Offset = "0x2398F24", VA = "0x2398F24", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001579")]
			[Address(RVA = "0x2398F2C", Offset = "0x2398F2C", VA = "0x2398F2C", Slot = "7")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600157A")]
			[Address(RVA = "0x2398F6C", Offset = "0x2398F6C", VA = "0x2398F6C", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000ED6")]
		private const float SCWAmlAYUdOqKHXMQDaAhhwDAjLJb = 20f;

		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement;

		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private ButtonType _buttonType;

		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private bool _activateOnSwipeIn;

		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x135")]
		[SerializeField]
		private bool _stayActiveOnSwipeOut;

		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x136")]
		[SerializeField]
		private bool _useDigitalAxisSimulation;

		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float _digitalAxisGravity;

		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private float _digitalAxisSensitivity;

		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private StandaloneAxis _axis;

		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TouchRegion _touchRegion;

		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _useTouchRegionOnly;

		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x151")]
		[SerializeField]
		private bool _moveToTouchPosition;

		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x152")]
		[SerializeField]
		private bool _returnOnRelease;

		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x153")]
		[SerializeField]
		private bool _followTouchPosition;

		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private bool _animateOnMoveToTouch;

		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x194470", Offset = "0x194470")]
		private float _moveToTouchSpeed;

		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private bool _animateOnReturn;

		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1944C0", Offset = "0x1944C0")]
		[SerializeField]
		private float _returnSpeed;

		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x164")]
		[SerializeField]
		private bool _manageRaycasting;

		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x168")]
		private float GayFivmQsrHyXTnOsAoGyZrYONky;

		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x16C")]
		private float ZxGKbhZcbUmwqArGhtrVMLaWEajZ;

		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x170")]
		private TouchRegion DdEciANgMGwGEPvgxnWPHBeJPbOd;

		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x178")]
		private Vector2 lhmAxKFWhlSHZJoCEAJNVcCScTPH;

		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x180")]
		private bool zAGNVhMcIKxGEzzgSRljWYiyquPd;

		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x181")]
		private bool sTmRLabKJLmxGbwWDHHbRrMNNrqn;

		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x184")]
		private OpkLqbttkDfdWPvVmlLCialkmZyE yJgkQZuMZrJUEaNCzYYZYngtVmoe;

		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x188")]
		private int aXEzyiFgJCCEqWfKXxtFBJTVbEHIA;

		[Token(Token = "0x4000EF1")]
		[FieldOffset(Offset = "0x18C")]
		private int RxCFBSfZGSaxvGjcDdHvHngyjaKGB;

		[NonSerialized]
		[Token(Token = "0x4000EF2")]
		[FieldOffset(Offset = "0x190")]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[NonSerialized]
		[Token(Token = "0x4000EF3")]
		[FieldOffset(Offset = "0x191")]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		[Token(Token = "0x4000EF4")]
		[FieldOffset(Offset = "0x198")]
		private IEnumerator FcwfREdgzibGQMOLZwevNMKYBahxA;

		[Token(Token = "0x4000EF5")]
		[FieldOffset(Offset = "0x1A0")]
		private orKfWSGFqzCFUysymbkGocsATicLA RnmnTCNSMxWpWOEFwiXbynsDrRsy;

		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0x1A8")]
		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> hQWAhuEEpQgIIlrOEloKQoXoiIpCb;

		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x1B0")]
		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> MnHeXlNYnTFAvDUkeuUfMXqRumEH;

		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private AxisValueChangedEventHandler _onAxisValueChanged;

		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private ButtonValueChangedEventHandler _onButtonValueChanged;

		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private ButtonDownEventHandler _onButtonDown;

		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private ButtonUpEventHandler _onButtonUp;

		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x1D8")]
		private Dictionary<int, PointerEventData> EeRYMczwTzlgDjdFdgjMeYiqqewh;

		[Token(Token = "0x170005AB")]
		public CustomControllerElementTargetSetForFloat targetCustomControllerElement
		{
			[Token(Token = "0x6001502")]
			[Address(RVA = "0x241D084", Offset = "0x241D084", VA = "0x241D084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AC")]
		public ButtonType buttonType
		{
			[Token(Token = "0x6001503")]
			[Address(RVA = "0x241D08C", Offset = "0x241D08C", VA = "0x241D08C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001504")]
			[Address(RVA = "0x241D094", Offset = "0x241D094", VA = "0x241D094")]
			set
			{
			}
		}

		[Token(Token = "0x170005AD")]
		public bool activateOnSwipeIn
		{
			[Token(Token = "0x6001505")]
			[Address(RVA = "0x241D0B8", Offset = "0x241D0B8", VA = "0x241D0B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001506")]
			[Address(RVA = "0x241D0C0", Offset = "0x241D0C0", VA = "0x241D0C0")]
			set
			{
			}
		}

		[Token(Token = "0x170005AE")]
		public bool stayActiveOnSwipeOut
		{
			[Token(Token = "0x6001507")]
			[Address(RVA = "0x241D0E4", Offset = "0x241D0E4", VA = "0x241D0E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001508")]
			[Address(RVA = "0x241D224", Offset = "0x241D224", VA = "0x241D224")]
			set
			{
			}
		}

		[Token(Token = "0x170005AF")]
		public bool useDigitalAxisSimulation
		{
			[Token(Token = "0x6001509")]
			[Address(RVA = "0x241D248", Offset = "0x241D248", VA = "0x241D248")]
			get
			{
				return default;
			}
			[Token(Token = "0x600150A")]
			[Address(RVA = "0x241D250", Offset = "0x241D250", VA = "0x241D250")]
			set
			{
			}
		}

		[Token(Token = "0x170005B0")]
		public float digitalAxisGravity
		{
			[Token(Token = "0x600150B")]
			[Address(RVA = "0x241D274", Offset = "0x241D274", VA = "0x241D274")]
			get
			{
				return default;
			}
			[Token(Token = "0x600150C")]
			[Address(RVA = "0x241D27C", Offset = "0x241D27C", VA = "0x241D27C")]
			set
			{
			}
		}

		[Token(Token = "0x170005B1")]
		public float digitalAxisSensitivity
		{
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x241D2A0", Offset = "0x241D2A0", VA = "0x241D2A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600150E")]
			[Address(RVA = "0x241D2A8", Offset = "0x241D2A8", VA = "0x241D2A8")]
			set
			{
			}
		}

		[Token(Token = "0x170005B2")]
		public TouchRegion touchRegion
		{
			[Token(Token = "0x600150F")]
			[Address(RVA = "0x241D2CC", Offset = "0x241D2CC", VA = "0x241D2CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001510")]
			[Address(RVA = "0x241D2D4", Offset = "0x241D2D4", VA = "0x241D2D4")]
			set
			{
			}
		}

		[Token(Token = "0x170005B3")]
		public bool useTouchRegionOnly
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x241D380", Offset = "0x241D380", VA = "0x241D380")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x241D388", Offset = "0x241D388", VA = "0x241D388")]
			set
			{
			}
		}

		[Token(Token = "0x170005B4")]
		public bool moveToTouchPosition
		{
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x241D3AC", Offset = "0x241D3AC", VA = "0x241D3AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x241D3B4", Offset = "0x241D3B4", VA = "0x241D3B4")]
			set
			{
			}
		}

		[Token(Token = "0x170005B5")]
		public bool returnOnRelease
		{
			[Token(Token = "0x6001515")]
			[Address(RVA = "0x241D3D8", Offset = "0x241D3D8", VA = "0x241D3D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x241D3E0", Offset = "0x241D3E0", VA = "0x241D3E0")]
			set
			{
			}
		}

		[Token(Token = "0x170005B6")]
		public bool followTouchPosition
		{
			[Token(Token = "0x6001517")]
			[Address(RVA = "0x241D404", Offset = "0x241D404", VA = "0x241D404")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x241D40C", Offset = "0x241D40C", VA = "0x241D40C")]
			set
			{
			}
		}

		[Token(Token = "0x170005B7")]
		public bool animateOnMoveToTouch
		{
			[Token(Token = "0x6001519")]
			[Address(RVA = "0x241D430", Offset = "0x241D430", VA = "0x241D430")]
			get
			{
				return default;
			}
			[Token(Token = "0x600151A")]
			[Address(RVA = "0x241D438", Offset = "0x241D438", VA = "0x241D438")]
			set
			{
			}
		}

		[Token(Token = "0x170005B8")]
		public float moveToTouchSpeed
		{
			[Token(Token = "0x600151B")]
			[Address(RVA = "0x241D45C", Offset = "0x241D45C", VA = "0x241D45C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600151C")]
			[Address(RVA = "0x241D464", Offset = "0x241D464", VA = "0x241D464")]
			set
			{
			}
		}

		[Token(Token = "0x170005B9")]
		public bool animateOnReturn
		{
			[Token(Token = "0x600151D")]
			[Address(RVA = "0x241D4BC", Offset = "0x241D4BC", VA = "0x241D4BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600151E")]
			[Address(RVA = "0x241D4C4", Offset = "0x241D4C4", VA = "0x241D4C4")]
			set
			{
			}
		}

		[Token(Token = "0x170005BA")]
		public float returnSpeed
		{
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x241D4E8", Offset = "0x241D4E8", VA = "0x241D4E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001520")]
			[Address(RVA = "0x241D4F0", Offset = "0x241D4F0", VA = "0x241D4F0")]
			set
			{
			}
		}

		[Token(Token = "0x170005BB")]
		public bool manageRaycasting
		{
			[Token(Token = "0x6001521")]
			[Address(RVA = "0x241D548", Offset = "0x241D548", VA = "0x241D548")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001522")]
			[Address(RVA = "0x241D550", Offset = "0x241D550", VA = "0x241D550")]
			set
			{
			}
		}

		[Token(Token = "0x170005BC")]
		public int pointerId
		{
			[Token(Token = "0x6001523")]
			[Address(RVA = "0x241D69C", Offset = "0x241D69C", VA = "0x241D69C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001524")]
			[Address(RVA = "0x241D6A4", Offset = "0x241D6A4", VA = "0x241D6A4")]
			set
			{
			}
		}

		[Token(Token = "0x170005BD")]
		public bool hasPointer
		{
			[Token(Token = "0x6001525")]
			[Address(RVA = "0x241D6AC", Offset = "0x241D6AC", VA = "0x241D6AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170005BE")]
		internal StandaloneAxis axis
		{
			[Token(Token = "0x6001526")]
			[Address(RVA = "0x241D6C0", Offset = "0x241D6C0", VA = "0x241D6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BF")]
		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> moveStartedDelegate
		{
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x241D6C8", Offset = "0x241D6C8", VA = "0x241D6C8")]
			get
			{
				return gNAmPModgOnTGQNOFdvniFjIqAtIA();
			}
		}

		[Token(Token = "0x170005C0")]
		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> moveEndedDelegate
		{
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x241D760", Offset = "0x241D760", VA = "0x241D760")]
			get
			{
				return ArcFTIKWHTlheRJUlpwHPRlQJByib();
			}
		}

		[Token(Token = "0x170005C1")]
		private float axisValue
		{
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x241D7F8", Offset = "0x241D7F8", VA = "0x241D7F8")]
			get
			{
				return iQxCxdSsmUdMvhhyiopIwEuiAjwfb();
			}
		}

		[Token(Token = "0x170005C2")]
		private float axisValuePrev
		{
			[Token(Token = "0x600152A")]
			[Address(RVA = "0x241D834", Offset = "0x241D834", VA = "0x241D834")]
			get
			{
				return PmTErSmrMWtvPqEJAGGfBmNOOztHA();
			}
		}

		[Token(Token = "0x170005C3")]
		private bool buttonValue
		{
			[Token(Token = "0x600152B")]
			[Address(RVA = "0x241D870", Offset = "0x241D870", VA = "0x241D870")]
			get
			{
				return hWAMrPFVNkAChGJnTzqjVWFOlpTR();
			}
		}

		[Token(Token = "0x170005C4")]
		private bool buttonValuePrev
		{
			[Token(Token = "0x600152C")]
			[Address(RVA = "0x241D8D0", Offset = "0x241D8D0", VA = "0x241D8D0")]
			get
			{
				return kQOwnBHmFOdVIgTYYPLkFJqcyioZA();
			}
		}

		[Token(Token = "0x170005C5")]
		private int effectivePointerId
		{
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x241D930", Offset = "0x241D930", VA = "0x241D930")]
			get
			{
				return GjrFlwkYGCpgHlpOAGJAeBjJqEGyA();
			}
		}

		[Token(Token = "0x14000027")]
		public event UnityAction<float> AxisValueChangedEvent
		{
			[Token(Token = "0x60014FA")]
			[Address(RVA = "0x241CE84", Offset = "0x241CE84", VA = "0x241CE84")]
			add
			{
			}
			[Token(Token = "0x60014FB")]
			[Address(RVA = "0x241CEE8", Offset = "0x241CEE8", VA = "0x241CEE8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000028")]
		public event UnityAction<bool> ButtonValueChangedEvent
		{
			[Token(Token = "0x60014FC")]
			[Address(RVA = "0x241CF4C", Offset = "0x241CF4C", VA = "0x241CF4C")]
			add
			{
			}
			[Token(Token = "0x60014FD")]
			[Address(RVA = "0x241CFB0", Offset = "0x241CFB0", VA = "0x241CFB0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public event UnityAction ButtonDownEvent
		{
			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x241D014", Offset = "0x241D014", VA = "0x241D014")]
			add
			{
			}
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x241D030", Offset = "0x241D030", VA = "0x241D030")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		public event UnityAction ButtonUpEvent
		{
			[Token(Token = "0x6001500")]
			[Address(RVA = "0x241D04C", Offset = "0x241D04C", VA = "0x241D04C")]
			add
			{
			}
			[Token(Token = "0x6001501")]
			[Address(RVA = "0x241D068", Offset = "0x241D068", VA = "0x241D068")]
			remove
			{
			}
		}

		[Token(Token = "0x6001527")]
		[Address(RVA = "0x241D6C8", Offset = "0x241D6C8", VA = "0x241D6C8")]
		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> gNAmPModgOnTGQNOFdvniFjIqAtIA()
		{
			return null;
		}

		[Token(Token = "0x6001528")]
		[Address(RVA = "0x241D760", Offset = "0x241D760", VA = "0x241D760")]
		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> ArcFTIKWHTlheRJUlpwHPRlQJByib()
		{
			return null;
		}

		[Token(Token = "0x6001529")]
		[Address(RVA = "0x241D7F8", Offset = "0x241D7F8", VA = "0x241D7F8")]
		private float iQxCxdSsmUdMvhhyiopIwEuiAjwfb()
		{
			return default;
		}

		[Token(Token = "0x600152A")]
		[Address(RVA = "0x241D834", Offset = "0x241D834", VA = "0x241D834")]
		private float PmTErSmrMWtvPqEJAGGfBmNOOztHA()
		{
			return default;
		}

		[Token(Token = "0x600152B")]
		[Address(RVA = "0x241D870", Offset = "0x241D870", VA = "0x241D870")]
		private bool hWAMrPFVNkAChGJnTzqjVWFOlpTR()
		{
			return default;
		}

		[Token(Token = "0x600152C")]
		[Address(RVA = "0x241D8D0", Offset = "0x241D8D0", VA = "0x241D8D0")]
		private bool kQOwnBHmFOdVIgTYYPLkFJqcyioZA()
		{
			return default;
		}

		[Token(Token = "0x600152D")]
		[Address(RVA = "0x241D930", Offset = "0x241D930", VA = "0x241D930")]
		private int GjrFlwkYGCpgHlpOAGJAeBjJqEGyA()
		{
			return default;
		}

		[Token(Token = "0x600152E")]
		[Address(RVA = "0x241D954", Offset = "0x241D954", VA = "0x241D954")]
		private TouchButton()
		{
		}

		[Token(Token = "0x600152F")]
		[Address(RVA = "0x241DE60", Offset = "0x241DE60", VA = "0x241DE60")]
		public void SetRawValue(float value)
		{
		}

		[Token(Token = "0x6001530")]
		[Address(RVA = "0x241DE88", Offset = "0x241DE88", VA = "0x241DE88")]
		public void SetDefaultPosition()
		{
		}

		[Token(Token = "0x6001531")]
		[Address(RVA = "0x241DF70", Offset = "0x241DF70", VA = "0x241DF70")]
		private void ILkWicEjdmMiShclEHEAqLqIsFgs(Vector2 P_0)
		{
		}

		[Token(Token = "0x6001532")]
		[Address(RVA = "0x241DF88", Offset = "0x241DF88", VA = "0x241DF88")]
		public void ReturnToDefaultPosition(bool instant)
		{
		}

		[Token(Token = "0x6001533")]
		[Address(RVA = "0x241E480", Offset = "0x241E480", VA = "0x241E480")]
		public void ReturnToDefaultPosition()
		{
		}

		[Token(Token = "0x6001534")]
		[Address(RVA = "0x241E4BC", Offset = "0x241E4BC", VA = "0x241E4BC", Slot = "8")]
		internal override void Awake()
		{
		}

		[Token(Token = "0x6001535")]
		[Address(RVA = "0x241E624", Offset = "0x241E624", VA = "0x241E624", Slot = "9")]
		internal override void OnEnable()
		{
		}

		[Token(Token = "0x6001536")]
		[Address(RVA = "0x241E770", Offset = "0x241E770", VA = "0x241E770", Slot = "10")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x6001537")]
		[Address(RVA = "0x241E7EC", Offset = "0x241E7EC", VA = "0x241E7EC", Slot = "11")]
		internal override void OnValidate()
		{
		}

		[Token(Token = "0x6001538")]
		[Address(RVA = "0x241EA70", Offset = "0x241EA70", VA = "0x241EA70", Slot = "15")]
		internal override void Reset()
		{
		}

		[Token(Token = "0x6001539")]
		[Address(RVA = "0x241EBAC", Offset = "0x241EBAC", VA = "0x241EBAC", Slot = "16")]
		internal void OnUpdate()
		{
		}

		[Token(Token = "0x600153A")]
		[Address(RVA = "0x241EFA0", Offset = "0x241EFA0", VA = "0x241EFA0", Slot = "17")]
		internal bool OnInitialize()
		{
			return default;
		}

		[Token(Token = "0x600153B")]
		[Address(RVA = "0x241F020", Offset = "0x241F020", VA = "0x241F020", Slot = "26")]
		internal void OnCustomControllerUpdate()
		{
		}

		[Token(Token = "0x600153C")]
		[Address(RVA = "0x241F0B4", Offset = "0x241F0B4", VA = "0x241F0B4", Slot = "19")]
		internal void OnSubscribeEvents()
		{
		}

		[Token(Token = "0x600153D")]
		[Address(RVA = "0x241F414", Offset = "0x241F414", VA = "0x241F414", Slot = "20")]
		internal void OnUnsubscribeEvents()
		{
		}

		[Token(Token = "0x600153E")]
		[Address(RVA = "0x241F774", Offset = "0x241F774", VA = "0x241F774", Slot = "21")]
		internal void OnSetProperty()
		{
		}

		[Token(Token = "0x600153F")]
		[Address(RVA = "0x241F83C", Offset = "0x241F83C", VA = "0x241F83C", Slot = "22")]
		internal void OnClear()
		{
		}

		[Token(Token = "0x6001540")]
		[Address(RVA = "0x241F9D0", Offset = "0x241F9D0", VA = "0x241F9D0", Slot = "7")]
		public override void ClearValue()
		{
		}

		[Token(Token = "0x6001541")]
		[Address(RVA = "0x241FA60", Offset = "0x241FA60", VA = "0x241FA60", Slot = "34")]
		internal bool IsPressed()
		{
			return default;
		}

		[Token(Token = "0x6001542")]
		[Address(RVA = "0x241FB18", Offset = "0x241FB18", VA = "0x241FB18", Slot = "35")]
		internal bool IsThisOrTouchRegionGameObject(GameObject gameObject)
		{
			return default;
		}

		[Token(Token = "0x6001543")]
		[Address(RVA = "0x241EE50", Offset = "0x241EE50", VA = "0x241EE50")]
		private void gvfEiYjewRKHGGOAcrURxtSizbWi()
		{
		}

		[Token(Token = "0x6001544")]
		[Address(RVA = "0x241FD18", Offset = "0x241FD18", VA = "0x241FD18")]
		private void YusCwCBXNYifDsXyufhFJipnEDYfA()
		{
		}

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x241FE1C", Offset = "0x241FE1C", VA = "0x241FE1C")]
		private void iPyjXvavVUKajQoZZSeerbagLuMc()
		{
		}

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x241FF38", Offset = "0x241FF38", VA = "0x241FF38")]
		private void SEATEbfdDvHdSchwPlVRmUEOleEvA(float P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x24200EC", Offset = "0x24200EC", VA = "0x24200EC")]
		private void nUjZujKpQkHytBBpLGGvYeLbADacA()
		{
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x24201E0", Offset = "0x24201E0", VA = "0x24201E0")]
		private void xDmhrzXrrUeSovFVkqiudNvSOwvT()
		{
		}

		[Token(Token = "0x6001549")]
		[Address(RVA = "0x241E730", Offset = "0x241E730", VA = "0x241E730")]
		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		[Token(Token = "0x600154A")]
		[Address(RVA = "0x241D5B8", Offset = "0x241D5B8", VA = "0x241D5B8")]
		private void aaiAJUIcGSdONuPwfwJBPYnPJCarA()
		{
		}

		[Token(Token = "0x600154B")]
		[Address(RVA = "0x2420220", Offset = "0x2420220", VA = "0x2420220")]
		private bool UZuPaidSRpiDUdxlqCyJWkepnHav()
		{
			return default;
		}

		[Token(Token = "0x600154C")]
		[Address(RVA = "0x24202B8", Offset = "0x24202B8", VA = "0x24202B8")]
		private void duaIiAtDTEcsqfybpdyfGRlfYedB(TouchRegion P_0)
		{
		}

		[Token(Token = "0x600154D")]
		[Address(RVA = "0x2420488", Offset = "0x2420488", VA = "0x2420488")]
		private void dlnLVQxHbOeHUrCToOHILuLpTVKI(TouchRegion P_0)
		{
		}

		[Token(Token = "0x600154E")]
		[Address(RVA = "0x241ED9C", Offset = "0x241ED9C", VA = "0x241ED9C")]
		private void SUSGFUJwfFASbZtQzNdxeGuaWaYnA()
		{
		}

		[Token(Token = "0x600154F")]
		[Address(RVA = "0x242064C", Offset = "0x242064C", VA = "0x242064C")]
		private void jbQgKcxKQGzETsTgYjuvYckRsvZo(Vector2 P_0, bool P_1, float P_2, OpkLqbttkDfdWPvVmlLCialkmZyE P_3)
		{
		}

		[Token(Token = "0x6001550")]
		[Address(RVA = "0x241E004", Offset = "0x241E004", VA = "0x241E004")]
		private void xHovnLtQkBnCuETzVQnpnWVuJUuI(Vector2 P_0, PositionType P_1, bool P_2, float P_3, OpkLqbttkDfdWPvVmlLCialkmZyE P_4)
		{
		}

		[Token(Token = "0x6001551")]
		[Address(RVA = "0x2420930", Offset = "0x2420930", VA = "0x2420930")]
		private IEnumerator tIfcRAEhuytogERPthhbDYOlhzfR(Vector2 P_0, PositionType P_1, float P_2, OpkLqbttkDfdWPvVmlLCialkmZyE P_3)
		{
			return null;
		}

		[Token(Token = "0x6001552")]
		[Address(RVA = "0x24209E0", Offset = "0x24209E0", VA = "0x24209E0")]
		private void ROeJSkZhnkTDcLHfcKCeHhXUonug(OpkLqbttkDfdWPvVmlLCialkmZyE P_0, Vector2 P_1, PositionType P_2)
		{
		}

		[Token(Token = "0x6001553")]
		[Address(RVA = "0x2420B64", Offset = "0x2420B64", VA = "0x2420B64")]
		private void XNKImEVsUNPavzxgPJMfIdoSEAWgA(OpkLqbttkDfdWPvVmlLCialkmZyE P_0)
		{
		}

		[Token(Token = "0x6001554")]
		[Address(RVA = "0x2420CE8", Offset = "0x2420CE8", VA = "0x2420CE8")]
		private void UkrWacxKoOMuRkiKLRmEmILrFhRJ(OpkLqbttkDfdWPvVmlLCialkmZyE P_0)
		{
		}

		[Token(Token = "0x6001555")]
		[Address(RVA = "0x241EEEC", Offset = "0x241EEEC", VA = "0x241EEEC")]
		private void GmcjKJeaVVcqXFRzEcparhxCpdPsA(int P_0)
		{
		}

		[Token(Token = "0x6001556")]
		[Address(RVA = "0x241F92C", Offset = "0x241F92C", VA = "0x241F92C")]
		private void zPMUivaPRCCBydGFdfPeBETKRYnmc()
		{
		}

		[Token(Token = "0x6001557")]
		[Address(RVA = "0x241EC2C", Offset = "0x241EC2C", VA = "0x241EC2C")]
		private void nxTbtLCLjbyuyRGfsvxPBPMmlZRq()
		{
		}

		[Token(Token = "0x6001558")]
		[Address(RVA = "0x241D188", Offset = "0x241D188", VA = "0x241D188")]
		private bool NDhTMIQItThJsXWyCtLUVEorVCTb()
		{
			return default;
		}

		[Token(Token = "0x6001559")]
		[Address(RVA = "0x2421518", Offset = "0x2421518", VA = "0x2421518")]
		private void rEkWtHXjAKTOKMkJBxWaofkAFFvH()
		{
		}

		[Token(Token = "0x600155A")]
		[Address(RVA = "0x2421524", Offset = "0x2421524", VA = "0x2421524")]
		private bool SBhvinEbIDGWUMwfXythhrIpigKu(int P_0)
		{
			return default;
		}

		[Token(Token = "0x600155B")]
		[Address(RVA = "0x24215DC", Offset = "0x24215DC", VA = "0x24215DC")]
		private PointerEventData utfJPhgnwTqKykeFFJYQHUTouefi(int P_0, GameObject P_1)
		{
			return null;
		}

		[Token(Token = "0x600155C")]
		[Address(RVA = "0x24218A4", Offset = "0x24218A4", VA = "0x24218A4")]
		private PointerEventData pVfmwALlLutDLwJmMFqcBjCFoHIS(int P_0)
		{
			return null;
		}

		[Token(Token = "0x600155D")]
		[Address(RVA = "0x2421404", Offset = "0x2421404", VA = "0x2421404")]
		private void LQXnlCGWVQCMAatUhwMXImJPGHhKA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600155E")]
		[Address(RVA = "0x24211F8", Offset = "0x24211F8", VA = "0x24211F8")]
		private PointerEventData HyACTUHUMITHJlwRMGbSiKvZntNC(int P_0)
		{
			return null;
		}

		[Token(Token = "0x600155F")]
		[Address(RVA = "0x24219FC", Offset = "0x24219FC", VA = "0x24219FC")]
		private void kenMZNZStIQnTAavioStPdqUwyIF(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		[Token(Token = "0x6001560")]
		[Address(RVA = "0x2421CFC", Offset = "0x2421CFC", VA = "0x2421CFC")]
		private void ZEbUZdUWFIEfiSqeUnrGJHjcPybD(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		[Token(Token = "0x6001561")]
		[Address(RVA = "0x2421F44", Offset = "0x2421F44", VA = "0x2421F44")]
		private void ZWAzvWwAMRawEGwPixAMPjfyqNgpA(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		[Token(Token = "0x6001562")]
		[Address(RVA = "0x242248C", Offset = "0x242248C", VA = "0x242248C")]
		private void zHqZkjRbrFTkqMfkkoUpBAuhCzKfA(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		[Token(Token = "0x6001563")]
		[Address(RVA = "0x2421B8C", Offset = "0x2421B8C", VA = "0x2421B8C")]
		private void PARBcfOJshIGNJtBDsuAyiETdYwy(int P_0, Vector2 P_1, KNuxcpaopMTVUOnDxSWfwXInKYgs P_2)
		{
		}

		[Token(Token = "0x6001564")]
		[Address(RVA = "0x2421458", Offset = "0x2421458", VA = "0x2421458")]
		private void MHcBbLUbNvVfJsmQBGwoxkdhumdt()
		{
		}

		[Token(Token = "0x6001565")]
		[Address(RVA = "0x2422714", Offset = "0x2422714", VA = "0x2422714", Slot = "36")]
		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001566")]
		[Address(RVA = "0x242291C", Offset = "0x242291C", VA = "0x242291C", Slot = "37")]
		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001567")]
		[Address(RVA = "0x2422A78", Offset = "0x2422A78", VA = "0x2422A78", Slot = "38")]
		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001568")]
		[Address(RVA = "0x2422BE8", Offset = "0x2422BE8", VA = "0x2422BE8", Slot = "39")]
		internal override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6001569")]
		[Address(RVA = "0x2422D54", Offset = "0x2422D54", VA = "0x2422D54")]
		private void lEDjUpnxqBucRFkEDyJKbVEmsmkA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600156A")]
		[Address(RVA = "0x2422E68", Offset = "0x2422E68", VA = "0x2422E68")]
		private void EuQQZFwdcthAzHoBOBDBcyHGjRwyB(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600156B")]
		[Address(RVA = "0x2422F78", Offset = "0x2422F78", VA = "0x2422F78")]
		private void OmQwIffSZPImRUCIYEOwFrZRxIQW(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600156C")]
		[Address(RVA = "0x242309C", Offset = "0x242309C", VA = "0x242309C")]
		private void PnDoCbelFWRcICvBVIgnpCPKYTkI(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600156D")]
		[Address(RVA = "0x24231BC", Offset = "0x24231BC", VA = "0x24231BC")]
		private void ghoFULOHEeeqyJlbKyZkQSyDIDpV(float P_0)
		{
		}

		[Token(Token = "0x600156E")]
		[Address(RVA = "0x2423250", Offset = "0x2423250", VA = "0x2423250")]
		private void qfUERXIuwfqiizHPBEEFkyvphQUUA(bool P_0)
		{
		}

		[Token(Token = "0x600156F")]
		[Address(RVA = "0x24232DC", Offset = "0x24232DC", VA = "0x24232DC")]
		private void nmsMSxYgtKmGYShDHFAdlkxbERSEA()
		{
		}

		[Token(Token = "0x6001570")]
		[Address(RVA = "0x2423328", Offset = "0x2423328", VA = "0x2423328")]
		private void KJnsAwDdnlgDqIbLNFXBLxAueot()
		{
		}
	}
}
