using System;
using System.Collections.Generic;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public enum AxisDirection
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}

		public enum TouchPadMode
		{
			Delta = 0,
			ScreenPosition = 1,
			VectorFromCenter = 2,
			VectorFromInitialTouch = 3
		}

		public enum ValueFormat
		{
			Pixels = 0,
			Screen = 1,
			Physical = 2,
			Direction = 3
		}

		private class GcbCkzFgdspYvXjGAvrdBxvawKnQ
		{
			private class nKkGWGseMmfMqOWCbUnSeXqiccpH
			{
				public float MoPTGRsFgXdMwTraXsxZonteyAEm;

				public float eBUQwXOmrrriDgdoiVUdsZqKsHQo;

				public uint XhKxIzDXGwEJghbHIgWHJwLzJsmD;
			}

			private int BhpPNlwkatLKIqHayHczxNXLLkSE;

			private nKkGWGseMmfMqOWCbUnSeXqiccpH[] cnRAHhGwbBYXolTSTEoaPYuDorOJA;

			private int aVOlNuRVvCOJdZFGeiVVgfpKNgOsA;

			public GcbCkzFgdspYvXjGAvrdBxvawKnQ(int P_0)
			{
			}

			public void tzfYrQaBdsWHACSbQzIxoLZqqtry(float P_0, float P_1)
			{
			}

			public Vector2 tsMpNUyOXnUQVPjMscdXFFdEHcWC()
			{
				return default;
			}

			private void vvrKfKclDpgNvELvDxraZuIuCBnL()
			{
			}

			private static int HFpRVJKckAeAyUfLgKvrQLbobKpd(int P_0, int P_1)
			{
				return 0;
			}

			private int gmaTZqwvDVelmvFlFCVPFwLnNJLZ(int P_0, int P_1)
			{
				return 0;
			}

			private static bool qsQzTOVMTjZtCEykQHzvcpAEPnCq(uint P_0, uint P_1)
			{
				return false;
			}
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
		public class PressDownEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class PressUpEventHandler : UnityEvent
		{
		}

		private const int SMOOTH_DELTA_FRAME_COUNT = 3;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement;

		[SerializeField]
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement;

		[SerializeField]
		private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement;

		[SerializeField]
		private AxisDirection _axesToUse;

		[SerializeField]
		private TouchPadMode _touchPadMode;

		[SerializeField]
		private ValueFormat _valueFormat;

		[SerializeField]
		private bool _useInertia;

		[SerializeField]
		private float _inertiaFriction;

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
		private bool _allowPress;

		[SerializeField]
		private float _pressStartDelay;

		[SerializeField]
		private int _pressDistanceLimit;

		[SerializeField]
		private bool _hideAtRuntime;

		[SerializeField]
		private StandaloneAxis2D _axis2D;

		[SerializeField]
		private ValueChangedEventHandler _onValueChanged;

		[SerializeField]
		private TapEventHandler _onTap;

		[SerializeField]
		private PressDownEventHandler _onPressDown;

		[SerializeField]
		private PressUpEventHandler _onPressUp;

		private bool _useXAxis;

		private bool _useYAxis;

		private int _pointerId;

		private int _realMousePointerId;

		[NonSerialized]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[NonSerialized]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		private bool _pointerDownIsFake;

		private Vector2 _touchStartPosition;

		private float _touchStartTime;

		private Vector3 _currentCenter;

		private Vector2 _previousTouchPosition;

		private int _lastTapFrame;

		private bool _isEligibleForTap;

		private bool _isEligibleForPress;

		private bool _pressValue;

		private GcbCkzFgdspYvXjGAvrdBxvawKnQ _smoothDelta;

		private Dictionary<int, PointerEventData> __fakePointerEventData;

		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement => null;

		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement => null;

		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement => null;

		public CustomControllerElementTargetSetForBoolean pressCustomControllerElement => null;

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

		public TouchPadMode touchPadMode
		{
			get
			{
				return TouchPadMode.Delta;
			}
			set
			{
			}
		}

		public ValueFormat valueFormat
		{
			get
			{
				return ValueFormat.Pixels;
			}
			set
			{
			}
		}

		public bool useInertia
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float inertiaFriction
		{
			get
			{
				return 0f;
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

		public bool allowPress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float pressStartDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int pressDistanceLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool hideAtRuntime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public Vector2 touchStartPosition => default;

		public Vector2 touchPosition => default;

		public AxisCalibration horizontalAxisCalibration => null;

		public AxisCalibration verticalAxisCalibration => null;

		public Axis2DCalibration axis2DCalibration => null;

		internal StandaloneAxis2D ACDlWRYqRUOGCISCfVnFWZBaWOxV => gNQvFCCTSioPGpasLuMXMIEqZNzw();

		private int RdKVxosdmPbtxnVbOZiHUHSPKFAe => GjrFlwkYGCpgHlpOAGJAeBjJqEGyA();

		private bool yjikdyNyZFDrkcdNNgEgZYvwGHKQ => GBWHYOhFxHgCyhIadoMrqMDmUSpIA();

		public event UnityAction<Vector2> ValueChangedEvent
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

		public event UnityAction PressDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction PressUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal StandaloneAxis2D gNQvFCCTSioPGpasLuMXMIEqZNzw()
		{
			return null;
		}

		private int GjrFlwkYGCpgHlpOAGJAeBjJqEGyA()
		{
			return 0;
		}

		private bool GBWHYOhFxHgCyhIadoMrqMDmUSpIA()
		{
			return false;
		}

		private TouchPad()
		{
		}

		internal override void Awake()
		{
		}

		internal override void OnValidate()
		{
		}

		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal override void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		internal override void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		public override void ClearValue()
		{
		}

		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		private void GxzFEFeJIqsFFABrybfdpQNfDFNi()
		{
		}

		private void GIBVHpzXHQWngXozSfKaKeeIRfeQ(AxisDirection P_0)
		{
		}

		private void nxTbtLCLjbyuyRGfsvxPBPMmlZRq()
		{
		}

		private void iriXtBpUKxiZfHBywtkhLeFWPDxr()
		{
		}

		private void togwggFTtwmzGOzMQNndhLBrYoJk()
		{
		}

		private void uiycTgIPBbGghVXEDqOPpxkdfEhq()
		{
		}

		private void QKLGRQbsDyoftuuWluaENjTJJkboA(ref Vector2 P_0)
		{
		}

		private void xsFfBubpiFWpSGqQpCPifdUCjMgj(ref Vector2 P_0)
		{
		}

		private void aWUWpIcCIgATqZRkbFWrLxrwjoEo()
		{
		}

		private Vector2 gfuFxNXGHkBsWSHRMGHdjmvDlUbRA(Vector2 P_0)
		{
			return default;
		}

		private void EiLFJmVuVmsQcybkTdMUeCmZTgWB(bool P_0)
		{
		}

		private void kenMZNZStIQnTAavioStPdqUwyIF(PointerEventData P_0)
		{
		}

		private void ZEbUZdUWFIEfiSqeUnrGJHjcPybD(PointerEventData P_0)
		{
		}

		private void ZWAzvWwAMRawEGwPixAMPjfyqNgpA(PointerEventData P_0)
		{
		}

		private void zHqZkjRbrFTkqMfkkoUpBAuhCzKfA(PointerEventData P_0)
		{
		}

		private void PARBcfOJshIGNJtBDsuAyiETdYwy(int P_0, Vector2 P_1)
		{
		}

		private void MHcBbLUbNvVfJsmQBGwoxkdhumdt()
		{
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
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

		private PointerEventData HyACTUHUMITHJlwRMGbSiKvZntNC(int P_0)
		{
			return null;
		}
	}
}
