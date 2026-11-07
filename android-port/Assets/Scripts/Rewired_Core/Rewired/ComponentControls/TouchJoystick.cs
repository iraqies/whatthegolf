using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TouchJoystick : TouchInteractable
	{
		public enum AxisDirection
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}

		public enum JoystickMode
		{
			Analog = 0,
			Digital = 1
		}

		public enum SnapDirections
		{
			None = 0,
			Four = 4,
			Eight = 8,
			Sixteen = 0x10,
			ThirtyTwo = 0x20,
			SixtyFour = 0x40
		}

		private enum HAucqZcqPbqeaRkOAvBFuZtmlrbX
		{
			None = 0,
			TowardTouch = 1,
			TowardHome = 2
		}

		private enum AQQeIWhyIPZKFavzzcGnNuzAgdWEb
		{
			Local = 0,
			TouchRegion = 1
		}

		public enum StickBounds
		{
			Circle = 0,
			Square = 1
		}

		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2>
		{
		}

		[Serializable]
		public class TapEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class TouchStartedEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class TouchEndedEventHandler : UnityEvent
		{
		}

		public interface IValueChangedHandler
		{
			void OnValueChanged(Vector2 value);
		}

		public interface IStickPositionChangedHandler
		{
			void OnStickPositionChanged(Vector2 value);
		}

		[Serializable]
		private sealed class ngnRiuTkxrVoOanVtjdtgQrNtVte
		{
			public static readonly ngnRiuTkxrVoOanVtjdtgQrNtVte _003C_003E9;

			public static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> _003C_003E9__277_0;

			public static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> _003C_003E9__280_0;

			internal void soYOmwhqrGvbRItoviGirdtfERTp(IValueChangedHandler P_0, Vector2 P_1)
			{
			}

			internal void DHmjQlbjFdELmcAZMiZLomjFsAU(IStickPositionChangedHandler P_0, Vector2 P_1)
			{
			}
		}

		private sealed class HTHcLOaXfkEsqLumLPjjbRjLqNLx : IDisposable, IEnumerator, IEnumerator<object>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			public float QzkoAujiXELSEATTFbUXkPALueUS;

			public TouchJoystick TtytLoUfsgUyhsklaKccrnoMiiek;

			public PositionType NrdyBFMMWwnWFfEyWKBnxrSnZvnA;

			public Vector2 JTKktbfSAqGDQjeacpqTtOeybKpt;

			public HAucqZcqPbqeaRkOAvBFuZtmlrbX sGqbUlnFwRgsWfMjUESVfFgHGuQnb;

			private RectTransform zhIaopVbzvThffCKABmaaMXeNOEU;

			private Vector2 MAKcOIKScodBQvETwJwUTnXGybGz;

			private float EqWwPxCLglgHGkbPhQwGHBtsGbeTA;

			private float ifUZPTedFJKUBUSvTHjRpfgDkWRg;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public HTHcLOaXfkEsqLumLPjjbRjLqNLx(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const float MAX_MOVE_SPEED = 20f;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement;

		[SerializeField]
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement;

		[SerializeField]
		private RectTransform _stickTransform;

		[SerializeField]
		private JoystickMode _joystickMode;

		[SerializeField]
		private float _digitalModeDeadZone;

		[SerializeField]
		private float _stickRange;

		[SerializeField]
		private bool _scaleStickRange;

		[SerializeField]
		private StickBounds _stickBounds;

		[SerializeField]
		private AxisDirection _axesToUse;

		[SerializeField]
		private SnapDirections _snapDirections;

		[SerializeField]
		private bool _snapStickToTouch;

		[SerializeField]
		private bool _centerStickOnRelease;

		[SerializeField]
		private StandaloneAxis2D _axis2D;

		[SerializeField]
		private bool _activateOnSwipeIn;

		[SerializeField]
		private bool _stayActiveOnSwipeOut;

		[SerializeField]
		private bool _allowTap;

		[SerializeField]
		private float _tapTimeout;

		[SerializeField]
		private int _tapDistanceLimit;

		[SerializeField]
		private TouchRegion _touchRegion;

		[SerializeField]
		private bool _useTouchRegionOnly;

		[SerializeField]
		private bool _moveToTouchPosition;

		[SerializeField]
		private bool _returnOnRelease;

		[SerializeField]
		private bool _followTouchPosition;

		[SerializeField]
		private bool _animateOnMoveToTouch;

		[SerializeField]
		private float _moveToTouchSpeed;

		[SerializeField]
		private bool _animateOnReturn;

		[SerializeField]
		private float _returnSpeed;

		[SerializeField]
		private bool _manageRaycasting;

		private bool _useXAxis;

		private bool _useYAxis;

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers;

		private tASbVocwrkZfBjDhttUGkjNilJQyA.HierarchyEventHelper<IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers;

		private TouchRegion _workingTouchRegion;

		private Vector2 _origAnchoredPosition;

		private Vector2 _origStickAnchoredPosition;

		private Vector2 _lastPressAnchoredPosition;

		private bool _isMoving;

		private bool _isMovedFromDefaultPosition;

		private HAucqZcqPbqeaRkOAvBFuZtmlrbX _moveDirection;

		private int _pointerId;

		private int _realMousePointerId;

		[NonSerialized]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[NonSerialized]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		private bool _pointerDownIsFake;

		private Vector2 _lastPressStartingValue;

		private AQQeIWhyIPZKFavzzcGnNuzAgdWEb _lastClaimSource;

		private float _touchStartTime;

		private Vector2 _touchStartPosition;

		private IEnumerator _coroutineMove;

		private orKfWSGFqzCFUysymbkGocsATicLA _imageRaycastHelper;

		private int _calculatedStickRange_lastUpdatedFrame;

		private int _lastTapFrame;

		private bool _isEligibleForTap;

		private float __calculatedStickRange_cachedValue;

		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> __moveStartedDelegate;

		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> __moveEndedDelegate;

		[SerializeField]
		private ValueChangedEventHandler _onValueChanged;

		[SerializeField]
		private ValueChangedEventHandler _onStickPositionChanged;

		[SerializeField]
		private TouchStartedEventHandler _onTouchStarted;

		[SerializeField]
		private TouchEndedEventHandler _onTouchEnded;

		[SerializeField]
		private TapEventHandler _onTap;

		private Dictionary<int, PointerEventData> __fakePointerEventData;

		private static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate;

		private static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate;

		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement => null;

		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement => null;

		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement => null;

		public RectTransform stickTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JoystickMode joystickMode
		{
			get
			{
				return JoystickMode.Analog;
			}
			set
			{
			}
		}

		public float digitalModeDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float stickRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool scaleStickRange
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private StickBounds mcPkZahauhqShOrqPIJhykUvoUKW
		{
			get
			{
				return KRfgemZDzphITaXuSDdcFCXdqvCY();
			}
			set
			{
				sznURolKtaEECqNLyqDzEGocjuuF(stickBounds);
			}
		}

		public AxisDirection axesToUse
		{
			get
			{
				return AxisDirection.Both;
			}
			set
			{
			}
		}

		public SnapDirections snapDirections
		{
			get
			{
				return SnapDirections.None;
			}
			set
			{
			}
		}

		public bool snapStickToTouch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool centerStickOnRelease
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool activateOnSwipeIn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stayActiveOnSwipeOut
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool allowTap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float tapTimeout
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int tapDistanceLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TouchRegion touchRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useTouchRegionOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool moveToTouchPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool returnOnRelease
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool followTouchPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool animateOnMoveToTouch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float moveToTouchSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool animateOnReturn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float returnSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool manageRaycasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AxisCalibration horizontalAxisCalibration => null;

		public AxisCalibration verticalAxisCalibration => null;

		[Obsolete]
		public Axis2DCalibration deadZoneType => null;

		public Axis2DCalibration axis2DCalibration => null;

		public int pointerId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool hasPointer => false;

		private bool yjikdyNyZFDrkcdNNgEgZYvwGHKQ => GBWHYOhFxHgCyhIadoMrqMDmUSpIA();

		internal StandaloneAxis2D ACDlWRYqRUOGCISCfVnFWZBaWOxV => gNQvFCCTSioPGpasLuMXMIEqZNzw();

		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> sYYYyCpyZfOyIwxaAvXQFATMFmho => gNAmPModgOnTGQNOFdvniFjIqAtIA();

		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> pCTEPHMlMUJAWuyayBZlAAjMxtTy => ArcFTIKWHTlheRJUlpwHPRlQJByib();

		private int RdKVxosdmPbtxnVbOZiHUHSPKFAe => GjrFlwkYGCpgHlpOAGJAeBjJqEGyA();

		private RectTransform CemuTvKBxSlWusQeIceOjYYrEMlr => cjJcFDSRaFjcAsobBStYSoIzEbnC();

		private float QNkuiWUZthEWSYPljzmqFaGIdebL => lInwEmDPAljJjqYZicnhkOWYJecp();

		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> iucgcTjctUgiESJftOWYTkXrkXNHA => bGDCuGDrmmLOftvAmowLCavjIGnJb();

		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> WlcekNxMkJpWXiTrWPtArhIsjaTZ => CUWWtxVeYsvRRMXmivrSOyOsaJKV();

		public event UnityAction<Vector2> ValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<Vector2> StickPositionChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction TouchDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction TouchUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction TapEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private StickBounds KRfgemZDzphITaXuSDdcFCXdqvCY()
		{
			return StickBounds.Circle;
		}

		private void sznURolKtaEECqNLyqDzEGocjuuF(StickBounds P_0)
		{
		}

		private bool GBWHYOhFxHgCyhIadoMrqMDmUSpIA()
		{
			return false;
		}

		internal StandaloneAxis2D gNQvFCCTSioPGpasLuMXMIEqZNzw()
		{
			return null;
		}

		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> gNAmPModgOnTGQNOFdvniFjIqAtIA()
		{
			return null;
		}

		private Action<HAucqZcqPbqeaRkOAvBFuZtmlrbX> ArcFTIKWHTlheRJUlpwHPRlQJByib()
		{
			return null;
		}

		private int GjrFlwkYGCpgHlpOAGJAeBjJqEGyA()
		{
			return 0;
		}

		private RectTransform cjJcFDSRaFjcAsobBStYSoIzEbnC()
		{
			return null;
		}

		private float lInwEmDPAljJjqYZicnhkOWYJecp()
		{
			return 0f;
		}

		private TouchJoystick()
		{
		}

		public Vector2 GetValue()
		{
			return default;
		}

		public Vector2 GetRawValue()
		{
			return default;
		}

		public void SetRawValue(Vector2 value)
		{
		}

		public void SetDefaultPosition()
		{
		}

		private void ILkWicEjdmMiShclEHEAqLqIsFgs(Vector2 P_0)
		{
		}

		public void ReturnToDefaultPosition(bool instant)
		{
		}

		public void ReturnToDefaultPosition()
		{
		}

		internal override void Awake()
		{
		}

		internal override void OnEnable()
		{
		}

		internal override void OnDisable()
		{
		}

		internal override void OnValidate()
		{
		}

		internal override void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		internal override void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		internal override void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		internal override void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		internal override void AOKLCSwSOHWHrUKFiqLEizXMqAyJ()
		{
		}

		public override void ClearValue()
		{
		}

		internal override bool jlMJYbxJlzjsBwCBJxvDZPhnPAZF()
		{
			return false;
		}

		internal override bool mxaQUajJeAklKpqxemiTJFTBFCaq(GameObject P_0)
		{
			return false;
		}

		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		private void aaiAJUIcGSdONuPwfwJBPYnPJCarA()
		{
		}

		private bool UZuPaidSRpiDUdxlqCyJWkepnHav()
		{
			return false;
		}

		private void duaIiAtDTEcsqfybpdyfGRlfYedB(TouchRegion P_0)
		{
		}

		private void dlnLVQxHbOeHUrCToOHILuLpTVKI(TouchRegion P_0)
		{
		}

		private void SUSGFUJwfFASbZtQzNdxeGuaWaYnA()
		{
		}

		private void jbQgKcxKQGzETsTgYjuvYckRsvZo(Vector2 P_0, bool P_1, float P_2, HAucqZcqPbqeaRkOAvBFuZtmlrbX P_3)
		{
		}

		private void xHovnLtQkBnCuETzVQnpnWVuJUuI(Vector2 P_0, PositionType P_1, bool P_2, float P_3, HAucqZcqPbqeaRkOAvBFuZtmlrbX P_4)
		{
		}

		private IEnumerator tIfcRAEhuytogERPthhbDYOlhzfR(Vector2 P_0, PositionType P_1, float P_2, HAucqZcqPbqeaRkOAvBFuZtmlrbX P_3)
		{
			return null;
		}

		private void ROeJSkZhnkTDcLHfcKCeHhXUonug(HAucqZcqPbqeaRkOAvBFuZtmlrbX P_0, Vector2 P_1, PositionType P_2)
		{
		}

		private void XNKImEVsUNPavzxgPJMfIdoSEAWgA(HAucqZcqPbqeaRkOAvBFuZtmlrbX P_0)
		{
		}

		private void UkrWacxKoOMuRkiKLRmEmILrFhRJ(HAucqZcqPbqeaRkOAvBFuZtmlrbX P_0)
		{
		}

		private void zPMUivaPRCCBydGFdfPeBETKRYnmc()
		{
		}

		private void GmcjKJeaVVcqXFRzEcparhxCpdPsA(int P_0, Vector2 P_1, PositionType P_2)
		{
		}

		private void nxTbtLCLjbyuyRGfsvxPBPMmlZRq()
		{
		}

		private void uiycTgIPBbGghVXEDqOPpxkdfEhq()
		{
		}

		private void QKLGRQbsDyoftuuWluaENjTJJkboA(ref Vector2 P_0)
		{
		}

		private bool NDhTMIQItThJsXWyCtLUVEorVCTb()
		{
			return false;
		}

		private void rEkWtHXjAKTOKMkJBxWaofkAFFvH()
		{
		}

		private bool SBhvinEbIDGWUMwfXythhrIpigKu(int P_0)
		{
			return false;
		}

		private PointerEventData utfJPhgnwTqKykeFFJYQHUTouefi(int P_0, GameObject P_1)
		{
			return null;
		}

		private PointerEventData lhPOsOAoYCOtTCHWjaXddmYdLcxRA(int P_0, GameObject P_1)
		{
			return null;
		}

		private PointerEventData pVfmwALlLutDLwJmMFqcBjCFoHIS(int P_0)
		{
			return null;
		}

		private void LQXnlCGWVQCMAatUhwMXImJPGHhKA(PointerEventData P_0)
		{
		}

		private void WxHbRRhLgInuzWPzlqWmcIMfWEbmA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private PointerEventData HyACTUHUMITHJlwRMGbSiKvZntNC(int P_0)
		{
			return null;
		}

		private void GxzFEFeJIqsFFABrybfdpQNfDFNi()
		{
		}

		private void GIBVHpzXHQWngXozSfKaKeeIRfeQ(AxisDirection P_0)
		{
		}

		private void kenMZNZStIQnTAavioStPdqUwyIF(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void ZEbUZdUWFIEfiSqeUnrGJHjcPybD(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void ZWAzvWwAMRawEGwPixAMPjfyqNgpA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void zHqZkjRbrFTkqMfkkoUpBAuhCzKfA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void ojGbWuDiNTcQBJhQBRTYbvGTjlqpA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void NjjRPLcHoUjpwCFvtzZQbZnNETGqA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void BLlpBBqEIQYHGAZMZaujMMEjFrsdA(PointerEventData P_0, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_1)
		{
		}

		private void PARBcfOJshIGNJtBDsuAyiETdYwy(int P_0, Vector2 P_1, AQQeIWhyIPZKFavzzcGnNuzAgdWEb P_2)
		{
		}

		private void MHcBbLUbNvVfJsmQBGwoxkdhumdt()
		{
		}

		internal override void OnPointerUp(PointerEventData P_0)
		{
		}

		internal override void OnPointerDown(PointerEventData P_0)
		{
		}

		internal override void OnPointerEnter(PointerEventData P_0)
		{
		}

		internal override void OnPointerExit(PointerEventData P_0)
		{
		}

		internal override void OnBeginDrag(PointerEventData P_0)
		{
		}

		internal override void OnDrag(PointerEventData P_0)
		{
		}

		internal override void OnEndDrag(PointerEventData P_0)
		{
		}

		private void lEDjUpnxqBucRFkEDyJKbVEmsmkA(PointerEventData P_0)
		{
		}

		private void EuQQZFwdcthAzHoBOBDBcyHGjRwyB(PointerEventData P_0)
		{
		}

		private void OmQwIffSZPImRUCIYEOwFrZRxIQW(PointerEventData P_0)
		{
		}

		private void PnDoCbelFWRcICvBVIgnpCPKYTkI(PointerEventData P_0)
		{
		}

		private void ElBBXVTrkqqOSaAcSRJhTyyORDhq(PointerEventData P_0)
		{
		}

		private void smhAMMKHqpAxqkfKwVnFAxcYqokSA(PointerEventData P_0)
		{
		}

		private void xApIcLqpCsqKyGaPkToTqMKtCkTcA(PointerEventData P_0)
		{
		}

		private void ghoFULOHEeeqyJlbKyZkQSyDIDpV(Vector2 P_0)
		{
		}

		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IValueChangedHandler, Vector2> bGDCuGDrmmLOftvAmowLCavjIGnJb()
		{
			return null;
		}

		internal static tASbVocwrkZfBjDhttUGkjNilJQyA.EventFunction<IStickPositionChangedHandler, Vector2> CUWWtxVeYsvRRMXmivrSOyOsaJKV()
		{
			return null;
		}
	}
}
