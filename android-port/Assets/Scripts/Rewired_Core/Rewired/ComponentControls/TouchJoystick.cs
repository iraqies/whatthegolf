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
	[Token(Token = "0x20002E9")]
	[DisallowMultipleComponent]
	public sealed class TouchJoystick : TouchInteractable
	{
		[Token(Token = "0x20002EA")]
		public enum AxisDirection
		{
			[Token(Token = "0x4000F8F")]
			Both = 0,
			[Token(Token = "0x4000F90")]
			Horizontal = 1,
			[Token(Token = "0x4000F91")]
			Vertical = 2
		}

		[Token(Token = "0x20002EB")]
		public enum JoystickMode
		{
			[Token(Token = "0x4000F93")]
			Analog = 0,
			[Token(Token = "0x4000F94")]
			Digital = 1
		}

		[Token(Token = "0x20002EC")]
		public enum SnapDirections
		{
			[Token(Token = "0x4000F96")]
			None = 0,
			[Token(Token = "0x4000F97")]
			Four = 4,
			[Token(Token = "0x4000F98")]
			Eight = 8,
			[Token(Token = "0x4000F99")]
			Sixteen = 0x10,
			[Token(Token = "0x4000F9A")]
			ThirtyTwo = 0x20,
			[Token(Token = "0x4000F9B")]
			SixtyFour = 0x40
		}

		[Token(Token = "0x20002ED")]
		private enum HAucqZcqPbqeaRkOAvBFuZtmlrbX
		{
			[Token(Token = "0x4000F9D")]
			None = 0,
			[Token(Token = "0x4000F9E")]
			TowardTouch = 1,
			[Token(Token = "0x4000F9F")]
			TowardHome = 2
		}

		[Token(Token = "0x20002EE")]
		private enum AQQeIWhyIPZKFavzzcGnNuzAgdWEb
		{
			[Token(Token = "0x4000FA1")]
			Local = 0,
			[Token(Token = "0x4000FA2")]
			TouchRegion = 1
		}

		[Token(Token = "0x20002EF")]
		public enum StickBounds
		{
			[Token(Token = "0x4000FA4")]
			Circle = 0,
			[Token(Token = "0x4000FA5")]
			Square = 1
		}

		[Serializable]
		[Token(Token = "0x20002F0")]
		public class ValueChangedEventHandler : UnityEvent<Vector2>
		{
			[Token(Token = "0x6001699")]
			[Address(RVA = "0x239939C", Offset = "0x239939C", VA = "0x239939C")]
			public ValueChangedEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002F1")]
		public class TapEventHandler : UnityEvent
		{
			[Token(Token = "0x600169A")]
			[Address(RVA = "0x2399384", Offset = "0x2399384", VA = "0x2399384")]
			public TapEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002F2")]
		public class TouchStartedEventHandler : UnityEvent
		{
			[Token(Token = "0x600169B")]
			[Address(RVA = "0x2399394", Offset = "0x2399394", VA = "0x2399394")]
			public TouchStartedEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002F3")]
		public class TouchEndedEventHandler : UnityEvent
		{
			[Token(Token = "0x600169C")]
			[Address(RVA = "0x239938C", Offset = "0x239938C", VA = "0x239938C")]
			public TouchEndedEventHandler()
			{
			}
		}

		[Token(Token = "0x20002F4")]
		public interface IValueChangedHandler
		{
			[Token(Token = "0x600169D")]
			void OnValueChanged(Vector2 value);
		}

		[Token(Token = "0x20002F5")]
		public interface IStickPositionChangedHandler
		{
			[Token(Token = "0x600169E")]
			void OnStickPositionChanged(Vector2 value);
		}

		[Serializable]
		[Token(Token = "0x20002F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191C04", Offset = "0x191C04")]
		private sealed class ngnRiuTkxrVoOanVtjdtgQrNtVte
		{
			[Token(Token = "0x4000FA6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ngnRiuTkxrVoOanVtjdtgQrNtVte _003C_003E9;

			[Token(Token = "0x4000FA7")]
			[FieldOffset(Offset = "0x8")]
			public static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> _003C_003E9__277_0;

			[Token(Token = "0x4000FA8")]
			[FieldOffset(Offset = "0x10")]
			public static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> _003C_003E9__280_0;

			[Token(Token = "0x60016A0")]
			[Address(RVA = "0x2399454", Offset = "0x2399454", VA = "0x2399454")]
			public ngnRiuTkxrVoOanVtjdtgQrNtVte()
			{
			}

			[Token(Token = "0x60016A1")]
			[Address(RVA = "0x239945C", Offset = "0x239945C", VA = "0x239945C")]
			internal void soYOmwhqrGvbRItoviGirdtfERTp(IValueChangedHandler P_0, Vector2 P_1)
			{
			}

			[Token(Token = "0x60016A2")]
			[Address(RVA = "0x2399524", Offset = "0x2399524", VA = "0x2399524")]
			internal void DHmjQlbjFdELmcAZMiZLomjFsAU(IStickPositionChangedHandler P_0, Vector2 P_1)
			{
			}
		}

		[Token(Token = "0x20002F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191C14", Offset = "0x191C14")]
		private sealed class HTHcLOaXfkEsqLumLPjjbRjLqNLx : IDisposable, IEnumerator, IEnumerator<object>
		{
			[Token(Token = "0x4000FA9")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000FAA")]
			[FieldOffset(Offset = "0x18")]
			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000FAB")]
			[FieldOffset(Offset = "0x20")]
			public float QzkoAujiXELSEATTFbUXkPALueUS;

			[Token(Token = "0x4000FAC")]
			[FieldOffset(Offset = "0x28")]
			public TouchJoystick TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000FAD")]
			[FieldOffset(Offset = "0x30")]
			public PositionType NrdyBFMMWwnWFfEyWKBnxrSnZvnA;

			[Token(Token = "0x4000FAE")]
			[FieldOffset(Offset = "0x34")]
			public Vector2 JTKktbfSAqGDQjeacpqTtOeybKpt;

			[Token(Token = "0x4000FAF")]
			[FieldOffset(Offset = "0x3C")]
			public HAucqZcqPbqeaRkOAvBFuZtmlrbX sGqbUlnFwRgsWfMjUESVfFgHGuQnb;

			[Token(Token = "0x4000FB0")]
			[FieldOffset(Offset = "0x40")]
			private RectTransform zhIaopVbzvThffCKABmaaMXeNOEU;

			[Token(Token = "0x4000FB1")]
			[FieldOffset(Offset = "0x48")]
			private Vector2 MAKcOIKScodBQvETwJwUTnXGybGz;

			[Token(Token = "0x4000FB2")]
			[FieldOffset(Offset = "0x50")]
			private float EqWwPxCLglgHGkbPhQwGHBtsGbeTA;

			[Token(Token = "0x4000FB3")]
			[FieldOffset(Offset = "0x54")]
			private float ifUZPTedFJKUBUSvTHjRpfgDkWRg;

			[Token(Token = "0x1700060C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60016A6")]
				[Address(RVA = "0x2399334", Offset = "0x2399334", VA = "0x2399334", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700060D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60016A8")]
				[Address(RVA = "0x239937C", Offset = "0x239937C", VA = "0x239937C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60016A3")]
			[Address(RVA = "0x239917C", Offset = "0x239917C", VA = "0x239917C")]
			[DebuggerHidden]
			public HTHcLOaXfkEsqLumLPjjbRjLqNLx(int P_0)
			{
			}

			[Token(Token = "0x60016A4")]
			[Address(RVA = "0x23991A8", Offset = "0x23991A8", VA = "0x23991A8", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60016A5")]
			[Address(RVA = "0x23991AC", Offset = "0x23991AC", VA = "0x23991AC", Slot = "5")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60016A6")]
			[Address(RVA = "0x2399334", Offset = "0x2399334", VA = "0x2399334", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60016A7")]
			[Address(RVA = "0x239933C", Offset = "0x239933C", VA = "0x239933C", Slot = "7")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60016A8")]
			[Address(RVA = "0x239937C", Offset = "0x239937C", VA = "0x239937C", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000F4C")]
		private const float MAX_MOVE_SPEED = 20f;

		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement;

		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement;

		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement;

		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private RectTransform _stickTransform;

		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private JoystickMode _joystickMode;

		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x14C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1946B0", Offset = "0x1946B0")]
		[SerializeField]
		private float _digitalModeDeadZone;

		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1946F0", Offset = "0x1946F0")]
		[SerializeField]
		private float _stickRange;

		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private bool _scaleStickRange;

		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private StickBounds _stickBounds;

		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private AxisDirection _axesToUse;

		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private SnapDirections _snapDirections;

		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x164")]
		[SerializeField]
		private bool _snapStickToTouch;

		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x165")]
		[SerializeField]
		private bool _centerStickOnRelease;

		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private StandaloneAxis2D _axis2D;

		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private bool _activateOnSwipeIn;

		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x171")]
		[SerializeField]
		private bool _stayActiveOnSwipeOut;

		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x172")]
		[SerializeField]
		private bool _allowTap;

		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		private float _tapTimeout;

		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private int _tapDistanceLimit;

		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private TouchRegion _touchRegion;

		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private bool _useTouchRegionOnly;

		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x189")]
		[SerializeField]
		private bool _moveToTouchPosition;

		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x18A")]
		[SerializeField]
		private bool _returnOnRelease;

		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x18B")]
		[SerializeField]
		private bool _followTouchPosition;

		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private bool _animateOnMoveToTouch;

		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19485C", Offset = "0x19485C")]
		private float _moveToTouchSpeed;

		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		private bool _animateOnReturn;

		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1948AC", Offset = "0x1948AC")]
		[SerializeField]
		private float _returnSpeed;

		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x19C")]
		[SerializeField]
		private bool _manageRaycasting;

		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x19D")]
		private bool _useXAxis;

		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x19E")]
		private bool _useYAxis;

		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x1A0")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers;

		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x1A8")]
		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers;

		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x1B0")]
		private TouchRegion _workingTouchRegion;

		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x1B8")]
		private Vector2 _origAnchoredPosition;

		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x1C0")]
		private Vector2 _origStickAnchoredPosition;

		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x1C8")]
		private Vector2 _lastPressAnchoredPosition;

		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x1D0")]
		private bool _isMoving;

		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x1D1")]
		private bool _isMovedFromDefaultPosition;

		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x1D4")]
		private HAucqZcqPbqeaRkOAvBFuZtmlrbX _moveDirection;

		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x1D8")]
		private int _pointerId;

		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x1DC")]
		private int _realMousePointerId;

		[NonSerialized]
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x1E0")]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[NonSerialized]
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x1E1")]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x1E2")]
		private bool _pointerDownIsFake;

		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x1E4")]
		private Vector2 _lastPressStartingValue;

		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x1EC")]
		private AQQeIWhyIPZKFavzzcGnNuzAgdWEb _lastClaimSource;

		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x1F0")]
		private float _touchStartTime;

		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x1F4")]
		private Vector2 _touchStartPosition;

		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x200")]
		private IEnumerator _coroutineMove;

		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x208")]
		private orKfWSGFqzCFUysymbkGocsATicLA _imageRaycastHelper;

		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x210")]
		private int _calculatedStickRange_lastUpdatedFrame;

		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x214")]
		private int _lastTapFrame;

		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x218")]
		private bool _isEligibleForTap;

		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x21C")]
		private float __calculatedStickRange_cachedValue;

		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x220")]
		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> __moveStartedDelegate;

		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x228")]
		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> __moveEndedDelegate;

		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private ValueChangedEventHandler _onValueChanged;

		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private ValueChangedEventHandler _onStickPositionChanged;

		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private TouchStartedEventHandler _onTouchStarted;

		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private TouchEndedEventHandler _onTouchEnded;

		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		private TapEventHandler _onTap;

		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x258")]
		private Dictionary<int, PointerEventData> __fakePointerEventData;

		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x0")]
		private static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate;

		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x8")]
		private static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate;

		[Token(Token = "0x170005E1")]
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
		{
			[Token(Token = "0x60015FF")]
			[Address(RVA = "0x2427520", Offset = "0x2427520", VA = "0x2427520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E2")]
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement
		{
			[Token(Token = "0x6001600")]
			[Address(RVA = "0x2427528", Offset = "0x2427528", VA = "0x2427528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E3")]
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement
		{
			[Token(Token = "0x6001601")]
			[Address(RVA = "0x2427530", Offset = "0x2427530", VA = "0x2427530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E4")]
		public RectTransform stickTransform
		{
			[Token(Token = "0x6001602")]
			[Address(RVA = "0x2427538", Offset = "0x2427538", VA = "0x2427538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001603")]
			[Address(RVA = "0x2427540", Offset = "0x2427540", VA = "0x2427540")]
			set
			{
			}
		}

		[Token(Token = "0x170005E5")]
		public JoystickMode joystickMode
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x24275EC", Offset = "0x24275EC", VA = "0x24275EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x24275F4", Offset = "0x24275F4", VA = "0x24275F4")]
			set
			{
			}
		}

		[Token(Token = "0x170005E6")]
		public float digitalModeDeadZone
		{
			[Token(Token = "0x6001606")]
			[Address(RVA = "0x2427618", Offset = "0x2427618", VA = "0x2427618")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001607")]
			[Address(RVA = "0x2427620", Offset = "0x2427620", VA = "0x2427620")]
			set
			{
			}
		}

		[Token(Token = "0x170005E7")]
		public float stickRange
		{
			[Token(Token = "0x6001608")]
			[Address(RVA = "0x2427670", Offset = "0x2427670", VA = "0x2427670")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001609")]
			[Address(RVA = "0x2427678", Offset = "0x2427678", VA = "0x2427678")]
			set
			{
			}
		}

		[Token(Token = "0x170005E8")]
		public bool scaleStickRange
		{
			[Token(Token = "0x600160A")]
			[Address(RVA = "0x24276D4", Offset = "0x24276D4", VA = "0x24276D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600160B")]
			[Address(RVA = "0x24276DC", Offset = "0x24276DC", VA = "0x24276DC")]
			set
			{
			}
		}

		[Token(Token = "0x170005E9")]
		private StickBounds mcPkZahauhqShOrqPIJhykUvoUKW
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x2427700", Offset = "0x2427700", VA = "0x2427700")]
			get
			{
				return KRfgemZDzphITaXuSDdcFCXdqvCY();
			}
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x2427708", Offset = "0x2427708", VA = "0x2427708")]
			set
			{
				sznURolKtaEECqNLyqDzEGocjuuF(stickBounds);
			}
		}

		[Token(Token = "0x170005EA")]
		public AxisDirection axesToUse
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x242772C", Offset = "0x242772C", VA = "0x242772C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x2427734", Offset = "0x2427734", VA = "0x2427734")]
			set
			{
			}
		}

		[Token(Token = "0x170005EB")]
		public SnapDirections snapDirections
		{
			[Token(Token = "0x6001610")]
			[Address(RVA = "0x24278FC", Offset = "0x24278FC", VA = "0x24278FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001611")]
			[Address(RVA = "0x2427904", Offset = "0x2427904", VA = "0x2427904")]
			set
			{
			}
		}

		[Token(Token = "0x170005EC")]
		public bool snapStickToTouch
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x2427928", Offset = "0x2427928", VA = "0x2427928")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x2427930", Offset = "0x2427930", VA = "0x2427930")]
			set
			{
			}
		}

		[Token(Token = "0x170005ED")]
		public bool centerStickOnRelease
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x2427954", Offset = "0x2427954", VA = "0x2427954")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x242795C", Offset = "0x242795C", VA = "0x242795C")]
			set
			{
			}
		}

		[Token(Token = "0x170005EE")]
		public bool activateOnSwipeIn
		{
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x2427980", Offset = "0x2427980", VA = "0x2427980")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001617")]
			[Address(RVA = "0x2427988", Offset = "0x2427988", VA = "0x2427988")]
			set
			{
			}
		}

		[Token(Token = "0x170005EF")]
		public bool stayActiveOnSwipeOut
		{
			[Token(Token = "0x6001618")]
			[Address(RVA = "0x24279AC", Offset = "0x24279AC", VA = "0x24279AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x2427AEC", Offset = "0x2427AEC", VA = "0x2427AEC")]
			set
			{
			}
		}

		[Token(Token = "0x170005F0")]
		public bool allowTap
		{
			[Token(Token = "0x600161A")]
			[Address(RVA = "0x2427B10", Offset = "0x2427B10", VA = "0x2427B10")]
			get
			{
				return default;
			}
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x2427B18", Offset = "0x2427B18", VA = "0x2427B18")]
			set
			{
			}
		}

		[Token(Token = "0x170005F1")]
		public float tapTimeout
		{
			[Token(Token = "0x600161C")]
			[Address(RVA = "0x2427B3C", Offset = "0x2427B3C", VA = "0x2427B3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600161D")]
			[Address(RVA = "0x2427B44", Offset = "0x2427B44", VA = "0x2427B44")]
			set
			{
			}
		}

		[Token(Token = "0x170005F2")]
		public int tapDistanceLimit
		{
			[Token(Token = "0x600161E")]
			[Address(RVA = "0x2427B9C", Offset = "0x2427B9C", VA = "0x2427B9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600161F")]
			[Address(RVA = "0x2427BA4", Offset = "0x2427BA4", VA = "0x2427BA4")]
			set
			{
			}
		}

		[Token(Token = "0x170005F3")]
		public TouchRegion touchRegion
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x2427BF8", Offset = "0x2427BF8", VA = "0x2427BF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x2427C00", Offset = "0x2427C00", VA = "0x2427C00")]
			set
			{
			}
		}

		[Token(Token = "0x170005F4")]
		public bool useTouchRegionOnly
		{
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x2427CAC", Offset = "0x2427CAC", VA = "0x2427CAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x2427CB4", Offset = "0x2427CB4", VA = "0x2427CB4")]
			set
			{
			}
		}

		[Token(Token = "0x170005F5")]
		public bool moveToTouchPosition
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x2427CD8", Offset = "0x2427CD8", VA = "0x2427CD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x2427CE0", Offset = "0x2427CE0", VA = "0x2427CE0")]
			set
			{
			}
		}

		[Token(Token = "0x170005F6")]
		public bool returnOnRelease
		{
			[Token(Token = "0x6001626")]
			[Address(RVA = "0x2427D04", Offset = "0x2427D04", VA = "0x2427D04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001627")]
			[Address(RVA = "0x2427D0C", Offset = "0x2427D0C", VA = "0x2427D0C")]
			set
			{
			}
		}

		[Token(Token = "0x170005F7")]
		public bool followTouchPosition
		{
			[Token(Token = "0x6001628")]
			[Address(RVA = "0x2427D30", Offset = "0x2427D30", VA = "0x2427D30")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001629")]
			[Address(RVA = "0x2427D38", Offset = "0x2427D38", VA = "0x2427D38")]
			set
			{
			}
		}

		[Token(Token = "0x170005F8")]
		public bool animateOnMoveToTouch
		{
			[Token(Token = "0x600162A")]
			[Address(RVA = "0x2427D5C", Offset = "0x2427D5C", VA = "0x2427D5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x2427D64", Offset = "0x2427D64", VA = "0x2427D64")]
			set
			{
			}
		}

		[Token(Token = "0x170005F9")]
		public float moveToTouchSpeed
		{
			[Token(Token = "0x600162C")]
			[Address(RVA = "0x2427D88", Offset = "0x2427D88", VA = "0x2427D88")]
			get
			{
				return default;
			}
			[Token(Token = "0x600162D")]
			[Address(RVA = "0x2427D90", Offset = "0x2427D90", VA = "0x2427D90")]
			set
			{
			}
		}

		[Token(Token = "0x170005FA")]
		public bool animateOnReturn
		{
			[Token(Token = "0x600162E")]
			[Address(RVA = "0x2427DE8", Offset = "0x2427DE8", VA = "0x2427DE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600162F")]
			[Address(RVA = "0x2427DF0", Offset = "0x2427DF0", VA = "0x2427DF0")]
			set
			{
			}
		}

		[Token(Token = "0x170005FB")]
		public float returnSpeed
		{
			[Token(Token = "0x6001630")]
			[Address(RVA = "0x2427E14", Offset = "0x2427E14", VA = "0x2427E14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001631")]
			[Address(RVA = "0x2427E1C", Offset = "0x2427E1C", VA = "0x2427E1C")]
			set
			{
			}
		}

		[Token(Token = "0x170005FC")]
		public bool manageRaycasting
		{
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x2427E74", Offset = "0x2427E74", VA = "0x2427E74")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x2427E7C", Offset = "0x2427E7C", VA = "0x2427E7C")]
			set
			{
			}
		}

		[Token(Token = "0x170005FD")]
		public AxisCalibration horizontalAxisCalibration
		{
			[Token(Token = "0x6001634")]
			[Address(RVA = "0x2427FC8", Offset = "0x2427FC8", VA = "0x2427FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FE")]
		public AxisCalibration verticalAxisCalibration
		{
			[Token(Token = "0x6001635")]
			[Address(RVA = "0x2427FF0", Offset = "0x2427FF0", VA = "0x2427FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1975DC", Offset = "0x1975DC")]
		public Axis2DCalibration deadZoneType
		{
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x2428018", Offset = "0x2428018", VA = "0x2428018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000600")]
		public Axis2DCalibration axis2DCalibration
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x2428034", Offset = "0x2428034", VA = "0x2428034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000601")]
		public int pointerId
		{
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x2428050", Offset = "0x2428050", VA = "0x2428050")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x2428058", Offset = "0x2428058", VA = "0x2428058")]
			set
			{
			}
		}

		[Token(Token = "0x17000602")]
		public bool hasPointer
		{
			[Token(Token = "0x600163A")]
			[Address(RVA = "0x2428060", Offset = "0x2428060", VA = "0x2428060")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000603")]
		private bool yjikdyNyZFDrkcdNNgEgZYvwGHKQ
		{
			[Token(Token = "0x600163B")]
			[Address(RVA = "0x2428074", Offset = "0x2428074", VA = "0x2428074")]
			get
			{
				return GBWHYOhFxHgCyhIadoMrqMDmUSpIA();
			}
		}

		[Token(Token = "0x17000604")]
		internal StandaloneAxis2D ACDlWRYqRUOGCISCfVnFWZBaWOxV
		{
			[Token(Token = "0x600163C")]
			[Address(RVA = "0x24280A0", Offset = "0x24280A0", VA = "0x24280A0")]
			get
			{
				return gNQvFCCTSioPGpasLuMXMIEqZNzw();
			}
		}

		[Token(Token = "0x17000605")]
		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> sYYYyCpyZfOyIwxaAvXQFATMFmho
		{
			[Token(Token = "0x600163D")]
			[Address(RVA = "0x24280A8", Offset = "0x24280A8", VA = "0x24280A8")]
			get
			{
				return gNAmPModgOnTGQNOFdvniFjIqAtIA();
			}
		}

		[Token(Token = "0x17000606")]
		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> pCTEPHMlMUJAWuyayBZlAAjMxtTy
		{
			[Token(Token = "0x600163E")]
			[Address(RVA = "0x2428140", Offset = "0x2428140", VA = "0x2428140")]
			get
			{
				return ArcFTIKWHTlheRJUlpwHPRlQJByib();
			}
		}

		[Token(Token = "0x17000607")]
		private int RdKVxosdmPbtxnVbOZiHUHSPKFAe
		{
			[Token(Token = "0x600163F")]
			[Address(RVA = "0x24281D8", Offset = "0x24281D8", VA = "0x24281D8")]
			get
			{
				return GjrFlwkYGCpgHlpOAGJAeBjJqEGyA();
			}
		}

		[Token(Token = "0x17000608")]
		private RectTransform CemuTvKBxSlWusQeIceOjYYrEMlr
		{
			[Token(Token = "0x6001640")]
			[Address(RVA = "0x24281FC", Offset = "0x24281FC", VA = "0x24281FC")]
			get
			{
				return cjJcFDSRaFjcAsobBStYSoIzEbnC();
			}
		}

		[Token(Token = "0x17000609")]
		private float QNkuiWUZthEWSYPljzmqFaGIdebL
		{
			[Token(Token = "0x6001641")]
			[Address(RVA = "0x2428280", Offset = "0x2428280", VA = "0x2428280")]
			get
			{
				return lInwEmDPAljJjqYZicnhkOWYJecp();
			}
		}

		[Token(Token = "0x1700060A")]
		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> iucgcTjctUgiESJftOWYTkXrkXNHA
		{
			[Token(Token = "0x6001697")]
			[Address(RVA = "0x242A298", Offset = "0x242A298", VA = "0x242A298")]
			get
			{
				return bGDCuGDrmmLOftvAmowLCavjIGnJb();
			}
		}

		[Token(Token = "0x1700060B")]
		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> WlcekNxMkJpWXiTrWPtArhIsjaTZ
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x242A3C8", Offset = "0x242A3C8", VA = "0x242A3C8")]
			get
			{
				return CUWWtxVeYsvRRMXmivrSOyOsaJKV();
			}
		}

		[Token(Token = "0x14000031")]
		public event UnityAction<Vector2> ValueChangedEvent
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x2428440", Offset = "0x2428440", VA = "0x2428440")]
			add
			{
			}
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x24284A4", Offset = "0x24284A4", VA = "0x24284A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000032")]
		public event UnityAction<Vector2> StickPositionChangedEvent
		{
			[Token(Token = "0x6001644")]
			[Address(RVA = "0x2428508", Offset = "0x2428508", VA = "0x2428508")]
			add
			{
			}
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x242856C", Offset = "0x242856C", VA = "0x242856C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000033")]
		public event UnityAction TouchDownEvent
		{
			[Token(Token = "0x6001646")]
			[Address(RVA = "0x24285D0", Offset = "0x24285D0", VA = "0x24285D0")]
			add
			{
			}
			[Token(Token = "0x6001647")]
			[Address(RVA = "0x24285EC", Offset = "0x24285EC", VA = "0x24285EC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000034")]
		public event UnityAction TouchUpEvent
		{
			[Token(Token = "0x6001648")]
			[Address(RVA = "0x2428608", Offset = "0x2428608", VA = "0x2428608")]
			add
			{
			}
			[Token(Token = "0x6001649")]
			[Address(RVA = "0x2428624", Offset = "0x2428624", VA = "0x2428624")]
			remove
			{
			}
		}

		[Token(Token = "0x14000035")]
		public event UnityAction TapEvent
		{
			[Token(Token = "0x600164A")]
			[Address(RVA = "0x2428640", Offset = "0x2428640", VA = "0x2428640")]
			add
			{
			}
			[Token(Token = "0x600164B")]
			[Address(RVA = "0x242865C", Offset = "0x242865C", VA = "0x242865C")]
			remove
			{
			}
		}

		[Token(Token = "0x600160C")]
		[Address(RVA = "0x2427700", Offset = "0x2427700", VA = "0x2427700")]
		private StickBounds KRfgemZDzphITaXuSDdcFCXdqvCY()
		{
			return default;
		}

		[Token(Token = "0x600160D")]
		[Address(RVA = "0x2427708", Offset = "0x2427708", VA = "0x2427708")]
		private void sznURolKtaEECqNLyqDzEGocjuuF(StickBounds P_0)
		{
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x2428074", Offset = "0x2428074", VA = "0x2428074")]
		private bool GBWHYOhFxHgCyhIadoMrqMDmUSpIA()
		{
			return default;
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x24280A0", Offset = "0x24280A0", VA = "0x24280A0")]
		internal StandaloneAxis2D gNQvFCCTSioPGpasLuMXMIEqZNzw()
		{
			return null;
		}

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x24280A8", Offset = "0x24280A8", VA = "0x24280A8")]
		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> gNAmPModgOnTGQNOFdvniFjIqAtIA()
		{
			return null;
		}

		[Token(Token = "0x600163E")]
		[Address(RVA = "0x2428140", Offset = "0x2428140", VA = "0x2428140")]
		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> ArcFTIKWHTlheRJUlpwHPRlQJByib()
		{
			return null;
		}

		[Token(Token = "0x600163F")]
		[Address(RVA = "0x24281D8", Offset = "0x24281D8", VA = "0x24281D8")]
		private int GjrFlwkYGCpgHlpOAGJAeBjJqEGyA()
		{
			return default;
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x24281FC", Offset = "0x24281FC", VA = "0x24281FC")]
		private RectTransform cjJcFDSRaFjcAsobBStYSoIzEbnC()
		{
			return null;
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x2428280", Offset = "0x2428280", VA = "0x2428280")]
		private float lInwEmDPAljJjqYZicnhkOWYJecp()
		{
			return default;
		}

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x2428678", Offset = "0x2428678", VA = "0x2428678")]
		private TouchJoystick()
		{
		}

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x24288E8", Offset = "0x24288E8", VA = "0x24288E8")]
		public Vector2 GetValue()
		{
			return default;
		}

		[Token(Token = "0x600164E")]
		[Address(RVA = "0x24289BC", Offset = "0x24289BC", VA = "0x24289BC")]
		public Vector2 GetRawValue()
		{
			return default;
		}

		[Token(Token = "0x600164F")]
		[Address(RVA = "0x2428AA8", Offset = "0x2428AA8", VA = "0x2428AA8")]
		public void SetRawValue(Vector2 value)
		{
		}

		[Token(Token = "0x6001650")]
		[Address(RVA = "0x2428CA0", Offset = "0x2428CA0", VA = "0x2428CA0")]
		public void SetDefaultPosition()
		{
		}

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x2428D2C", Offset = "0x2428D2C", VA = "0x2428D2C")]
		private void ILkWicEjdmMiShclEHEAqLqIsFgs(Vector2 P_0)
		{
		}

		[Token(Token = "0x6001652")]
		[Address(RVA = "0x2428D44", Offset = "0x2428D44", VA = "0x2428D44")]
		public void ReturnToDefaultPosition(bool instant)
		{
		}

		[Token(Token = "0x6001653")]
		[Address(RVA = "0x242923C", Offset = "0x242923C", VA = "0x242923C")]
		public void ReturnToDefaultPosition()
		{
		}

		[Token(Token = "0x6001654")]
		[Address(RVA = "0x2429278", Offset = "0x2429278", VA = "0x2429278", Slot = "8")]
		internal override void Awake()
		{
		}

		[Token(Token = "0x6001655")]
		[Address(RVA = "0x24293F8", Offset = "0x24293F8", VA = "0x24293F8", Slot = "9")]
		internal override void OnEnable()
		{
		}

		[Token(Token = "0x6001656")]
		[Address(RVA = "0x242949C", Offset = "0x242949C", VA = "0x242949C", Slot = "10")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x6001657")]
		[Address(RVA = "0x2429500", Offset = "0x2429500", VA = "0x2429500", Slot = "11")]
		internal override void OnValidate()
		{
		}

		[Token(Token = "0x6001658")]
		[Address(RVA = "0x2429650", Offset = "0x2429650", VA = "0x2429650", Slot = "16")]
		internal override void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		[Token(Token = "0x6001659")]
		[Address(RVA = "0x2429B04", Offset = "0x2429B04", VA = "0x2429B04", Slot = "17")]
		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return default;
		}

		[Token(Token = "0x600165A")]
		[Address(RVA = "0x2429B5C", Offset = "0x2429B5C", VA = "0x2429B5C", Slot = "26")]
		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		[Token(Token = "0x600165B")]
		[Address(RVA = "0x2429CA8", Offset = "0x2429CA8", VA = "0x2429CA8", Slot = "19")]
		internal override void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		[Token(Token = "0x600165C")]
		[Address(RVA = "0x2429DB8", Offset = "0x2429DB8", VA = "0x2429DB8", Slot = "20")]
		internal override void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		[Token(Token = "0x600165D")]
		[Address(RVA = "0x2429EC8", Offset = "0x2429EC8", VA = "0x2429EC8", Slot = "21")]
		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x600165E")]
		[Address(RVA = "0x2429F34", Offset = "0x2429F34", VA = "0x2429F34", Slot = "22")]
		internal override void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		[Token(Token = "0x600165F")]
		[Address(RVA = "0x242A134", Offset = "0x242A134", VA = "0x242A134", Slot = "23")]
		internal override void AOKLCSwSOHWHrUKFiqLEizXMqAyJ()
		{
		}

		[Token(Token = "0x6001660")]
		[Address(RVA = "0x242A4F8", Offset = "0x242A4F8", VA = "0x242A4F8", Slot = "7")]
		public override void ClearValue()
		{
		}

		[Token(Token = "0x6001661")]
		[Address(RVA = "0x242A614", Offset = "0x242A614", VA = "0x242A614", Slot = "34")]
		internal override bool jlMJYbxJlzjsBwCBJxvDZPhnPAZF()
		{
			return default;
		}

		[Token(Token = "0x6001662")]
		[Address(RVA = "0x242A660", Offset = "0x242A660", VA = "0x242A660", Slot = "35")]
		internal override bool mxaQUajJeAklKpqxemiTJFTBFCaq(GameObject P_0)
		{
			return default;
		}

		[Token(Token = "0x6001663")]
		[Address(RVA = "0x2429434", Offset = "0x2429434", VA = "0x2429434")]
		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		[Token(Token = "0x6001664")]
		[Address(RVA = "0x2427EE4", Offset = "0x2427EE4", VA = "0x2427EE4")]
		private void aaiAJUIcGSdONuPwfwJBPYnPJCarA()
		{
		}

		[Token(Token = "0x6001665")]
		[Address(RVA = "0x242A7D4", Offset = "0x242A7D4", VA = "0x242A7D4")]
		private bool UZuPaidSRpiDUdxlqCyJWkepnHav()
		{
			return default;
		}

		[Token(Token = "0x6001666")]
		[Address(RVA = "0x242A86C", Offset = "0x242A86C", VA = "0x242A86C")]
		private void duaIiAtDTEcsqfybpdyfGRlfYedB(TouchRegion P_0)
		{
		}

		[Token(Token = "0x6001667")]
		[Address(RVA = "0x242AAFC", Offset = "0x242AAFC", VA = "0x242AAFC")]
		private void dlnLVQxHbOeHUrCToOHILuLpTVKI(TouchRegion P_0)
		{
		}

		[Token(Token = "0x6001668")]
		[Address(RVA = "0x2429A50", Offset = "0x2429A50", VA = "0x2429A50")]
		private void SUSGFUJwfFASbZtQzNdxeGuaWaYnA()
		{
		}

		[Token(Token = "0x6001669")]
		[Address(RVA = "0x242AD80", Offset = "0x242AD80", VA = "0x242AD80")]
		private void jbQgKcxKQGzETsTgYjuvYckRsvZo(Vector2 P_0, bool P_1, float P_2, HAucqZcqPbqeaRkOAvBFuZtmlrbX P_3)
		{
		}

		[Token(Token = "0x600166A")]
		[Address(RVA = "0x2428DC0", Offset = "0x2428DC0", VA = "0x2428DC0")]
		private void xHovnLtQkBnCuETzVQnpnWVuJUuI(Vector2 P_0, PositionType P_1, bool P_2, float P_3, HAucqZcqPbqeaRkOAvBFuZtmlrbX P_4)
		{
		}

		[Token(Token = "0x600166B")]
		[Address(RVA = "0x242AFA4", Offset = "0x242AFA4", VA = "0x242AFA4")]
		private IEnumerator tIfcRAEhuytogERPthhbDYOlhzfR(Vector2 P_0, PositionType P_1, float P_2, HAucqZcqPbqeaRkOAvBFuZtmlrbX P_3)
		{
			return null;
		}

		[Token(Token = "0x600166C")]
		[Address(RVA = "0x242B054", Offset = "0x242B054", VA = "0x242B054")]
		private void ROeJSkZhnkTDcLHfcKCeHhXUonug(HAucqZcqPbqeaRkOAvBFuZtmlrbX P_0, Vector2 P_1, PositionType P_2)
		{
		}

		[Token(Token = "0x600166D")]
		[Address(RVA = "0x242B1D8", Offset = "0x242B1D8", VA = "0x242B1D8")]
		private void XNKImEVsUNPavzxgPJMfIdoSEAWgA(HAucqZcqPbqeaRkOAvBFuZtmlrbX P_0)
		{
		}

		[Token(Token = "0x600166E")]
		[Address(RVA = "0x242B35C", Offset = "0x242B35C", VA = "0x242B35C")]
		private void UkrWacxKoOMuRkiKLRmEmILrFhRJ(HAucqZcqPbqeaRkOAvBFuZtmlrbX P_0)
		{
		}

		[Token(Token = "0x600166F")]
		[Address(RVA = "0x242A090", Offset = "0x242A090", VA = "0x242A090")]
		private void zPMUivaPRCCBydGFdfPeBETKRYnmc()
		{
		}

		[Token(Token = "0x6001670")]
		[Address(RVA = "0x242B57C", Offset = "0x242B57C", VA = "0x242B57C")]
		private void GmcjKJeaVVcqXFRzEcparhxCpdPsA(int P_0, Vector2 P_1, PositionType P_2)
		{
		}

		[Token(Token = "0x6001671")]
		[Address(RVA = "0x24297C0", Offset = "0x24297C0", VA = "0x24297C0")]
		private void nxTbtLCLjbyuyRGfsvxPBPMmlZRq()
		{
		}

		[Token(Token = "0x6001672")]
		[Address(RVA = "0x24296A0", Offset = "0x24296A0", VA = "0x24296A0")]
		private void uiycTgIPBbGghVXEDqOPpxkdfEhq()
		{
		}

		[Token(Token = "0x6001673")]
		[Address(RVA = "0x242BC50", Offset = "0x242BC50", VA = "0x242BC50")]
		private void QKLGRQbsDyoftuuWluaENjTJJkboA(ref Vector2 P_0)
		{
		}

		[Token(Token = "0x6001674")]
		[Address(RVA = "0x2427A50", Offset = "0x2427A50", VA = "0x2427A50")]
		private bool NDhTMIQItThJsXWyCtLUVEorVCTb()
		{
			return default;
		}

		[Token(Token = "0x6001675")]
		[Address(RVA = "0x242BCF0", Offset = "0x242BCF0", VA = "0x242BCF0")]
		private void rEkWtHXjAKTOKMkJBxWaofkAFFvH()
		{
		}

		[Token(Token = "0x6001676")]
		[Address(RVA = "0x242BD00", Offset = "0x242BD00", VA = "0x242BD00")]
		private bool SBhvinEbIDGWUMwfXythhrIpigKu(int P_0)
		{
			return default;
		}

		[Token(Token = "0x6001677")]
		[Address(RVA = "0x242BDAC", Offset = "0x242BDAC", VA = "0x242BDAC")]
		private PointerEventData utfJPhgnwTqKykeFFJYQHUTouefi(int P_0, GameObject P_1)
		{
			return null;
		}

		[Token(Token = "0x6001678")]
		[Address(RVA = "0x242BAD4", Offset = "0x242BAD4", VA = "0x242BAD4")]
		private PointerEventData lhPOsOAoYCOtTCHWjaXddmYdLcxRA(int P_0, GameObject P_1)
		{
			return null;
		}

		[Token(Token = "0x6001679")]
		[Address(RVA = "0x242C068", Offset = "0x242C068", VA = "0x242C068")]
		private PointerEventData pVfmwALlLutDLwJmMFqcBjCFoHIS(int P_0)
		{
			return null;
		}

		[Token(Token = "0x600167A")]
		[Address(RVA = "0x242B8A8", Offset = "0x242B8A8", VA = "0x242B8A8")]
		private void LQXnlCGWVQCMAatUhwMXImJPGHhKA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600167B")]
		[Address(RVA = "0x242BBA4", Offset = "0x242BBA4", VA = "0x242BBA4")]
		private void WxHbRRhLgInuzWPzlqWmcIMfWEbmA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x600167C")]
		[Address(RVA = "0x242B69C", Offset = "0x242B69C", VA = "0x242B69C")]
		private PointerEventData HyACTUHUMITHJlwRMGbSiKvZntNC(int P_0)
		{
			return null;
		}

		[Token(Token = "0x600167D")]
		[Address(RVA = "0x2429544", Offset = "0x2429544", VA = "0x2429544")]
		private void GxzFEFeJIqsFFABrybfdpQNfDFNi()
		{
		}

		[Token(Token = "0x600167E")]
		[Address(RVA = "0x2427774", Offset = "0x2427774", VA = "0x2427774")]
		private void GIBVHpzXHQWngXozSfKaKeeIRfeQ(AxisDirection P_0)
		{
		}

		[Token(Token = "0x600167F")]
		[Address(RVA = "0x242C2D0", Offset = "0x242C2D0", VA = "0x242C2D0")]
		private void kenMZNZStIQnTAavioStPdqUwyIF(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001680")]
		[Address(RVA = "0x242C694", Offset = "0x242C694", VA = "0x242C694")]
		private void ZEbUZdUWFIEfiSqeUnrGJHjcPybD(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001681")]
		[Address(RVA = "0x242C7DC", Offset = "0x242C7DC", VA = "0x242C7DC")]
		private void ZWAzvWwAMRawEGwPixAMPjfyqNgpA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001682")]
		[Address(RVA = "0x242CB18", Offset = "0x242CB18", VA = "0x242CB18")]
		private void zHqZkjRbrFTkqMfkkoUpBAuhCzKfA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001683")]
		[Address(RVA = "0x242CC90", Offset = "0x242CC90", VA = "0x242CC90")]
		private void ojGbWuDiNTcQBJhQBRTYbvGTjlqpA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001684")]
		[Address(RVA = "0x242CD7C", Offset = "0x242CD7C", VA = "0x242CD7C")]
		private void NjjRPLcHoUjpwCFvtzZQbZnNETGqA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001685")]
		[Address(RVA = "0x242D188", Offset = "0x242D188", VA = "0x242D188")]
		private void BLlpBBqEIQYHGAZMZaujMMEjFrsdA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		[Token(Token = "0x6001686")]
		[Address(RVA = "0x242C3F8", Offset = "0x242C3F8", VA = "0x242C3F8")]
		private void PARBcfOJshIGNJtBDsuAyiETdYwy(int P_0, Vector2 P_1, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_2)
		{
		}

		[Token(Token = "0x6001687")]
		[Address(RVA = "0x242B8FC", Offset = "0x242B8FC", VA = "0x242B8FC")]
		private void MHcBbLUbNvVfJsmQBGwoxkdhumdt()
		{
		}

		[Token(Token = "0x6001688")]
		[Address(RVA = "0x242D274", Offset = "0x242D274", VA = "0x242D274", Slot = "37")]
		internal void MbXbjtguZaBfbfqmjlBSCyVMORejB(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001689")]
		[Address(RVA = "0x242D3D0", Offset = "0x242D3D0", VA = "0x242D3D0", Slot = "36")]
		internal void jdTaWudIAtigvcgWdtrrcBEKJLcPB(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600168A")]
		[Address(RVA = "0x242D530", Offset = "0x242D530", VA = "0x242D530", Slot = "38")]
		internal void vpQLxEpNsNjHEQUMTNafaJqaWgfe(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600168B")]
		[Address(RVA = "0x242D6A0", Offset = "0x242D6A0", VA = "0x242D6A0", Slot = "39")]
		internal void OCiTmGENfjrRiUQnHUcKDaHRzTDj(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600168C")]
		[Address(RVA = "0x242D80C", Offset = "0x242D80C", VA = "0x242D80C", Slot = "40")]
		internal void CeCjfxfrPRDIAfCVrQPnmMvELNpzA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600168D")]
		[Address(RVA = "0x242D968", Offset = "0x242D968", VA = "0x242D968", Slot = "41")]
		internal void JuzlkzmoAOuJMYLEkFxWgiAjnolW(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600168E")]
		[Address(RVA = "0x242DAC4", Offset = "0x242DAC4", VA = "0x242DAC4", Slot = "42")]
		internal void LgBQosPAyBTzQOLHtYNFjeRHthOd(PointerEventData P_0)
		{
		}

		[Token(Token = "0x600168F")]
		[Address(RVA = "0x242DC20", Offset = "0x242DC20", VA = "0x242DC20")]
		private void lEDjUpnxqBucRFkEDyJKbVEmsmkA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001690")]
		[Address(RVA = "0x242DD34", Offset = "0x242DD34", VA = "0x242DD34")]
		private void EuQQZFwdcthAzHoBOBDBcyHGjRwyB(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001691")]
		[Address(RVA = "0x242DE44", Offset = "0x242DE44", VA = "0x242DE44")]
		private void OmQwIffSZPImRUCIYEOwFrZRxIQW(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001692")]
		[Address(RVA = "0x242DF68", Offset = "0x242DF68", VA = "0x242DF68")]
		private void PnDoCbelFWRcICvBVIgnpCPKYTkI(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001693")]
		[Address(RVA = "0x242E088", Offset = "0x242E088", VA = "0x242E088")]
		private void ElBBXVTrkqqOSaAcSRJhTyyORDhq(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001694")]
		[Address(RVA = "0x242C1C0", Offset = "0x242C1C0", VA = "0x242C1C0")]
		private void smhAMMKHqpAxqkfKwVnFAxcYqokSA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001695")]
		[Address(RVA = "0x242E198", Offset = "0x242E198", VA = "0x242E198")]
		private void xApIcLqpCsqKyGaPkToTqMKtCkTcA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001696")]
		[Address(RVA = "0x242E2A8", Offset = "0x242E2A8", VA = "0x242E2A8")]
		private void ghoFULOHEeeqyJlbKyZkQSyDIDpV(Vector2 P_0)
		{
		}

		[Token(Token = "0x6001697")]
		[Address(RVA = "0x242A298", Offset = "0x242A298", VA = "0x242A298")]
		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> bGDCuGDrmmLOftvAmowLCavjIGnJb()
		{
			return null;
		}

		[Token(Token = "0x6001698")]
		[Address(RVA = "0x242A3C8", Offset = "0x242A3C8", VA = "0x242A3C8")]
		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> CUWWtxVeYsvRRMXmivrSOyOsaJKV()
		{
			return null;
		}
	}
}
