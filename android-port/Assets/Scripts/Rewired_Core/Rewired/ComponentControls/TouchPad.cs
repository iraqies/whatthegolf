using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002F8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x191C24", Offset = "0x191C24")]
	[DisallowMultipleComponent]
	public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x20002F9")]
		public enum AxisDirection
		{
			[Token(Token = "0x4000FDE")]
			Both = 0,
			[Token(Token = "0x4000FDF")]
			Horizontal = 1,
			[Token(Token = "0x4000FE0")]
			Vertical = 2
		}

		[Token(Token = "0x20002FA")]
		public enum TouchPadMode
		{
			[Token(Token = "0x4000FE2")]
			Delta = 0,
			[Token(Token = "0x4000FE3")]
			ScreenPosition = 1,
			[Token(Token = "0x4000FE4")]
			VectorFromCenter = 2,
			[Token(Token = "0x4000FE5")]
			VectorFromInitialTouch = 3
		}

		[Token(Token = "0x20002FB")]
		public enum ValueFormat
		{
			[Token(Token = "0x4000FE7")]
			Pixels = 0,
			[Token(Token = "0x4000FE8")]
			Screen = 1,
			[Token(Token = "0x4000FE9")]
			Physical = 2,
			[Token(Token = "0x4000FEA")]
			Direction = 3
		}

		[Token(Token = "0x20002FC")]
		private class GcbCkzFgdspYvXjGAvrdBxvawKnQ
		{
			[Token(Token = "0x20002FD")]
			private class nKkGWGseMmfMqOWCbUnSeXqiccpH
			{
				[Token(Token = "0x4000FEE")]
				[FieldOffset(Offset = "0x10")]
				public float MoPTGRsFgXdMwTraXsxZonteyAEm;

				[Token(Token = "0x4000FEF")]
				[FieldOffset(Offset = "0x14")]
				public float eBUQwXOmrrriDgdoiVUdsZqKsHQo;

				[Token(Token = "0x4000FF0")]
				[FieldOffset(Offset = "0x18")]
				public uint XhKxIzDXGwEJghbHIgWHJwLzJsmD;

				[Token(Token = "0x6001709")]
				[Address(RVA = "0x23C1730", Offset = "0x23C1730", VA = "0x23C1730")]
				public nKkGWGseMmfMqOWCbUnSeXqiccpH()
				{
				}
			}

			[Token(Token = "0x4000FEB")]
			[FieldOffset(Offset = "0x10")]
			private int BhpPNlwkatLKIqHayHczxNXLLkSE;

			[Token(Token = "0x4000FEC")]
			[FieldOffset(Offset = "0x18")]
			private nKkGWGseMmfMqOWCbUnSeXqiccpH[] cnRAHhGwbBYXolTSTEoaPYuDorOJA;

			[Token(Token = "0x4000FED")]
			[FieldOffset(Offset = "0x20")]
			private int aVOlNuRVvCOJdZFGeiVVgfpKNgOsA;

			[Token(Token = "0x6001702")]
			[Address(RVA = "0x23995EC", Offset = "0x23995EC", VA = "0x23995EC")]
			public GcbCkzFgdspYvXjGAvrdBxvawKnQ(int P_0)
			{
			}

			[Token(Token = "0x6001703")]
			[Address(RVA = "0x23996CC", Offset = "0x23996CC", VA = "0x23996CC")]
			public void tzfYrQaBdsWHACSbQzIxoLZqqtry(float P_0, float P_1)
			{
			}

			[Token(Token = "0x6001704")]
			[Address(RVA = "0x23997E8", Offset = "0x23997E8", VA = "0x23997E8")]
			public Vector2 tsMpNUyOXnUQVPjMscdXFFdEHcWC()
			{
				return default;
			}

			[Token(Token = "0x6001705")]
			[Address(RVA = "0x23997CC", Offset = "0x23997CC", VA = "0x23997CC")]
			private void vvrKfKclDpgNvELvDxraZuIuCBnL()
			{
			}

			[Token(Token = "0x6001706")]
			[Address(RVA = "0x23998E8", Offset = "0x23998E8", VA = "0x23998E8")]
			private static int HFpRVJKckAeAyUfLgKvrQLbobKpd(int P_0, int P_1)
			{
				return default;
			}

			[Token(Token = "0x6001707")]
			[Address(RVA = "0x23998D8", Offset = "0x23998D8", VA = "0x23998D8")]
			private int gmaTZqwvDVelmvFlFCVPFwLnNJLZ(int P_0, int P_1)
			{
				return default;
			}

			[Token(Token = "0x6001708")]
			[Address(RVA = "0x23998C8", Offset = "0x23998C8", VA = "0x23998C8")]
			private static bool qsQzTOVMTjZtCEykQHzvcpAEPnCq(uint P_0, uint P_1)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x20002FE")]
		public class ValueChangedEventHandler : UnityEvent<Vector2>
		{
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x2399910", Offset = "0x2399910", VA = "0x2399910")]
			public ValueChangedEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20002FF")]
		public class TapEventHandler : UnityEvent
		{
			[Token(Token = "0x600170B")]
			[Address(RVA = "0x2399908", Offset = "0x2399908", VA = "0x2399908")]
			public TapEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000300")]
		public class PressDownEventHandler : UnityEvent
		{
			[Token(Token = "0x600170C")]
			[Address(RVA = "0x23998F8", Offset = "0x23998F8", VA = "0x23998F8")]
			public PressDownEventHandler()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000301")]
		public class PressUpEventHandler : UnityEvent
		{
			[Token(Token = "0x600170D")]
			[Address(RVA = "0x2399900", Offset = "0x2399900", VA = "0x2399900")]
			public PressUpEventHandler()
			{
			}
		}

		[Token(Token = "0x4000FB4")]
		private const int SMOOTH_DELTA_FRAME_COUNT = 3;

		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement;

		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement;

		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement;

		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement;

		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private AxisDirection _axesToUse;

		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private TouchPadMode _touchPadMode;

		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private ValueFormat _valueFormat;

		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private bool _useInertia;

		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private float _inertiaFriction;

		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private bool _activateOnSwipeIn;

		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x15D")]
		[SerializeField]
		private bool _stayActiveOnSwipeOut;

		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x15E")]
		[SerializeField]
		private bool _allowTap;

		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private float _tapTimeout;

		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x164")]
		[SerializeField]
		private int _tapDistanceLimit;

		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private bool _allowPress;

		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private float _pressStartDelay;

		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private int _pressDistanceLimit;

		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		private bool _hideAtRuntime;

		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private StandaloneAxis2D _axis2D;

		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private ValueChangedEventHandler _onValueChanged;

		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private TapEventHandler _onTap;

		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private PressDownEventHandler _onPressDown;

		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private PressUpEventHandler _onPressUp;

		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x1A0")]
		private bool _useXAxis;

		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x1A1")]
		private bool _useYAxis;

		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x1A4")]
		private int _pointerId;

		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x1A8")]
		private int _realMousePointerId;

		[NonSerialized]
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x1AC")]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[NonSerialized]
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x1AD")]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x1AE")]
		private bool _pointerDownIsFake;

		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x1B0")]
		private Vector2 _touchStartPosition;

		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x1B8")]
		private float _touchStartTime;

		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0x1BC")]
		private Vector3 _currentCenter;

		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0x1C8")]
		private Vector2 _previousTouchPosition;

		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x1D0")]
		private int _lastTapFrame;

		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x1D4")]
		private bool _isEligibleForTap;

		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x1D5")]
		private bool _isEligibleForPress;

		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0x1D6")]
		private bool _pressValue;

		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x1D8")]
		private GcbCkzFgdspYvXjGAvrdBxvawKnQ _smoothDelta;

		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x1E0")]
		private Dictionary<int, PointerEventData> __fakePointerEventData;

		[Token(Token = "0x1700060E")]
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
		{
			[Token(Token = "0x60016B1")]
			[Address(RVA = "0x2430130", Offset = "0x2430130", VA = "0x2430130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060F")]
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement
		{
			[Token(Token = "0x60016B2")]
			[Address(RVA = "0x2430138", Offset = "0x2430138", VA = "0x2430138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000610")]
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement
		{
			[Token(Token = "0x60016B3")]
			[Address(RVA = "0x2430140", Offset = "0x2430140", VA = "0x2430140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000611")]
		public CustomControllerElementTargetSetForBoolean pressCustomControllerElement
		{
			[Token(Token = "0x60016B4")]
			[Address(RVA = "0x2430148", Offset = "0x2430148", VA = "0x2430148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000612")]
		public AxisDirection axesToUse
		{
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x2430150", Offset = "0x2430150", VA = "0x2430150")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016B6")]
			[Address(RVA = "0x2430158", Offset = "0x2430158", VA = "0x2430158")]
			set
			{
			}
		}

		[Token(Token = "0x17000613")]
		public TouchPadMode touchPadMode
		{
			[Token(Token = "0x60016B7")]
			[Address(RVA = "0x2430270", Offset = "0x2430270", VA = "0x2430270")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016B8")]
			[Address(RVA = "0x2430278", Offset = "0x2430278", VA = "0x2430278")]
			set
			{
			}
		}

		[Token(Token = "0x17000614")]
		public ValueFormat valueFormat
		{
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x243029C", Offset = "0x243029C", VA = "0x243029C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x24302A4", Offset = "0x24302A4", VA = "0x24302A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000615")]
		public bool useInertia
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x24302C8", Offset = "0x24302C8", VA = "0x24302C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x24302D0", Offset = "0x24302D0", VA = "0x24302D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000616")]
		public float inertiaFriction
		{
			[Token(Token = "0x60016BD")]
			[Address(RVA = "0x24302F4", Offset = "0x24302F4", VA = "0x24302F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016BE")]
			[Address(RVA = "0x24302FC", Offset = "0x24302FC", VA = "0x24302FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000617")]
		public bool activateOnSwipeIn
		{
			[Token(Token = "0x60016BF")]
			[Address(RVA = "0x2430354", Offset = "0x2430354", VA = "0x2430354")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016C0")]
			[Address(RVA = "0x243035C", Offset = "0x243035C", VA = "0x243035C")]
			set
			{
			}
		}

		[Token(Token = "0x17000618")]
		public bool stayActiveOnSwipeOut
		{
			[Token(Token = "0x60016C1")]
			[Address(RVA = "0x2430380", Offset = "0x2430380", VA = "0x2430380")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016C2")]
			[Address(RVA = "0x2430388", Offset = "0x2430388", VA = "0x2430388")]
			set
			{
			}
		}

		[Token(Token = "0x17000619")]
		public bool allowTap
		{
			[Token(Token = "0x60016C3")]
			[Address(RVA = "0x24303AC", Offset = "0x24303AC", VA = "0x24303AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016C4")]
			[Address(RVA = "0x24303B4", Offset = "0x24303B4", VA = "0x24303B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061A")]
		public float tapTimeout
		{
			[Token(Token = "0x60016C5")]
			[Address(RVA = "0x24303D8", Offset = "0x24303D8", VA = "0x24303D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016C6")]
			[Address(RVA = "0x24303E0", Offset = "0x24303E0", VA = "0x24303E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700061B")]
		public int tapDistanceLimit
		{
			[Token(Token = "0x60016C7")]
			[Address(RVA = "0x2430438", Offset = "0x2430438", VA = "0x2430438")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016C8")]
			[Address(RVA = "0x2430440", Offset = "0x2430440", VA = "0x2430440")]
			set
			{
			}
		}

		[Token(Token = "0x1700061C")]
		public bool allowPress
		{
			[Token(Token = "0x60016C9")]
			[Address(RVA = "0x2430494", Offset = "0x2430494", VA = "0x2430494")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016CA")]
			[Address(RVA = "0x243049C", Offset = "0x243049C", VA = "0x243049C")]
			set
			{
			}
		}

		[Token(Token = "0x1700061D")]
		public float pressStartDelay
		{
			[Token(Token = "0x60016CB")]
			[Address(RVA = "0x24304C0", Offset = "0x24304C0", VA = "0x24304C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016CC")]
			[Address(RVA = "0x24304C8", Offset = "0x24304C8", VA = "0x24304C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700061E")]
		public int pressDistanceLimit
		{
			[Token(Token = "0x60016CD")]
			[Address(RVA = "0x2430520", Offset = "0x2430520", VA = "0x2430520")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016CE")]
			[Address(RVA = "0x2430528", Offset = "0x2430528", VA = "0x2430528")]
			set
			{
			}
		}

		[Token(Token = "0x1700061F")]
		public bool hideAtRuntime
		{
			[Token(Token = "0x60016CF")]
			[Address(RVA = "0x243057C", Offset = "0x243057C", VA = "0x243057C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016D0")]
			[Address(RVA = "0x2430584", Offset = "0x2430584", VA = "0x2430584")]
			set
			{
			}
		}

		[Token(Token = "0x17000620")]
		public int pointerId
		{
			[Token(Token = "0x60016D1")]
			[Address(RVA = "0x24305A8", Offset = "0x24305A8", VA = "0x24305A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60016D2")]
			[Address(RVA = "0x24305B0", Offset = "0x24305B0", VA = "0x24305B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000621")]
		public bool hasPointer
		{
			[Token(Token = "0x60016D3")]
			[Address(RVA = "0x24305B8", Offset = "0x24305B8", VA = "0x24305B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000622")]
		public Vector2 touchStartPosition
		{
			[Token(Token = "0x60016D4")]
			[Address(RVA = "0x24305CC", Offset = "0x24305CC", VA = "0x24305CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000623")]
		public Vector2 touchPosition
		{
			[Token(Token = "0x60016D5")]
			[Address(RVA = "0x24305F0", Offset = "0x24305F0", VA = "0x24305F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000624")]
		public AxisCalibration horizontalAxisCalibration
		{
			[Token(Token = "0x60016D6")]
			[Address(RVA = "0x2430704", Offset = "0x2430704", VA = "0x2430704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000625")]
		public AxisCalibration verticalAxisCalibration
		{
			[Token(Token = "0x60016D7")]
			[Address(RVA = "0x243072C", Offset = "0x243072C", VA = "0x243072C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000626")]
		public Axis2DCalibration axis2DCalibration
		{
			[Token(Token = "0x60016D8")]
			[Address(RVA = "0x2430754", Offset = "0x2430754", VA = "0x2430754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000627")]
		internal StandaloneAxis2D ACDlWRYqRUOGCISCfVnFWZBaWOxV
		{
			[Token(Token = "0x60016D9")]
			[Address(RVA = "0x2430770", Offset = "0x2430770", VA = "0x2430770")]
			get
			{
				return gNQvFCCTSioPGpasLuMXMIEqZNzw();
			}
		}

		[Token(Token = "0x17000628")]
		private int RdKVxosdmPbtxnVbOZiHUHSPKFAe
		{
			[Token(Token = "0x60016DA")]
			[Address(RVA = "0x24306E0", Offset = "0x24306E0", VA = "0x24306E0")]
			get
			{
				return GjrFlwkYGCpgHlpOAGJAeBjJqEGyA();
			}
		}

		[Token(Token = "0x17000629")]
		private bool yjikdyNyZFDrkcdNNgEgZYvwGHKQ
		{
			[Token(Token = "0x60016DB")]
			[Address(RVA = "0x2430778", Offset = "0x2430778", VA = "0x2430778")]
			get
			{
				return GBWHYOhFxHgCyhIadoMrqMDmUSpIA();
			}
		}

		[Token(Token = "0x14000036")]
		public event UnityAction<Vector2> ValueChangedEvent
		{
			[Token(Token = "0x60016A9")]
			[Address(RVA = "0x242FFC0", Offset = "0x242FFC0", VA = "0x242FFC0")]
			add
			{
			}
			[Token(Token = "0x60016AA")]
			[Address(RVA = "0x2430024", Offset = "0x2430024", VA = "0x2430024")]
			remove
			{
			}
		}

		[Token(Token = "0x14000037")]
		public event UnityAction TapEvent
		{
			[Token(Token = "0x60016AB")]
			[Address(RVA = "0x2430088", Offset = "0x2430088", VA = "0x2430088")]
			add
			{
			}
			[Token(Token = "0x60016AC")]
			[Address(RVA = "0x24300A4", Offset = "0x24300A4", VA = "0x24300A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000038")]
		public event UnityAction PressDownEvent
		{
			[Token(Token = "0x60016AD")]
			[Address(RVA = "0x24300C0", Offset = "0x24300C0", VA = "0x24300C0")]
			add
			{
			}
			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x24300DC", Offset = "0x24300DC", VA = "0x24300DC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000039")]
		public event UnityAction PressUpEvent
		{
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x24300F8", Offset = "0x24300F8", VA = "0x24300F8")]
			add
			{
			}
			[Token(Token = "0x60016B0")]
			[Address(RVA = "0x2430114", Offset = "0x2430114", VA = "0x2430114")]
			remove
			{
			}
		}

		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x2430770", Offset = "0x2430770", VA = "0x2430770")]
		internal StandaloneAxis2D gNQvFCCTSioPGpasLuMXMIEqZNzw()
		{
			return null;
		}

		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x24306E0", Offset = "0x24306E0", VA = "0x24306E0")]
		private int GjrFlwkYGCpgHlpOAGJAeBjJqEGyA()
		{
			return default;
		}

		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x2430778", Offset = "0x2430778", VA = "0x2430778")]
		private bool GBWHYOhFxHgCyhIadoMrqMDmUSpIA()
		{
			return default;
		}

		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x24307A4", Offset = "0x24307A4", VA = "0x24307A4")]
		private TouchPad()
		{
		}

		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x24309E0", Offset = "0x24309E0", VA = "0x24309E0", Slot = "8")]
		internal override void Awake()
		{
		}

		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x2430A34", Offset = "0x2430A34", VA = "0x2430A34", Slot = "11")]
		internal override void OnValidate()
		{
		}

		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x2430BE8", Offset = "0x2430BE8", VA = "0x2430BE8", Slot = "17")]
		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return default;
		}

		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x2430C20", Offset = "0x2430C20", VA = "0x2430C20", Slot = "16")]
		internal override void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x2431418", Offset = "0x2431418", VA = "0x2431418", Slot = "26")]
		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x243155C", Offset = "0x243155C", VA = "0x243155C", Slot = "21")]
		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x24315A4", Offset = "0x24315A4", VA = "0x24315A4", Slot = "22")]
		internal override void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x2431630", Offset = "0x2431630", VA = "0x2431630", Slot = "7")]
		public override void ClearValue()
		{
		}

		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x2430B7C", Offset = "0x2430B7C", VA = "0x2430B7C")]
		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x2430A7C", Offset = "0x2430A7C", VA = "0x2430A7C")]
		private void GxzFEFeJIqsFFABrybfdpQNfDFNi()
		{
		}

		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x2430198", Offset = "0x2430198", VA = "0x2430198")]
		private void GIBVHpzXHQWngXozSfKaKeeIRfeQ(AxisDirection P_0)
		{
		}

		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x2430DC0", Offset = "0x2430DC0", VA = "0x2430DC0")]
		private void nxTbtLCLjbyuyRGfsvxPBPMmlZRq()
		{
		}

		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x2430F2C", Offset = "0x2430F2C", VA = "0x2430F2C")]
		private void iriXtBpUKxiZfHBywtkhLeFWPDxr()
		{
		}

		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x243121C", Offset = "0x243121C", VA = "0x243121C")]
		private void togwggFTtwmzGOzMQNndhLBrYoJk()
		{
		}

		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x2430C80", Offset = "0x2430C80", VA = "0x2430C80")]
		private void uiycTgIPBbGghVXEDqOPpxkdfEhq()
		{
		}

		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x2431B98", Offset = "0x2431B98", VA = "0x2431B98")]
		private void QKLGRQbsDyoftuuWluaENjTJJkboA(ref Vector2 P_0)
		{
		}

		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x2431C38", Offset = "0x2431C38", VA = "0x2431C38")]
		private void xsFfBubpiFWpSGqQpCPifdUCjMgj(ref Vector2 P_0)
		{
		}

		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x2431338", Offset = "0x2431338", VA = "0x2431338")]
		private void aWUWpIcCIgATqZRkbFWrLxrwjoEo()
		{
		}

		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x2431A78", Offset = "0x2431A78", VA = "0x2431A78")]
		private Vector2 gfuFxNXGHkBsWSHRMGHdjmvDlUbRA(Vector2 P_0)
		{
			return default;
		}

		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x2431D14", Offset = "0x2431D14", VA = "0x2431D14")]
		private void EiLFJmVuVmsQcybkTdMUeCmZTgWB(bool P_0)
		{
		}

		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x2431D58", Offset = "0x2431D58", VA = "0x2431D58")]
		private void kenMZNZStIQnTAavioStPdqUwyIF(PointerEventData P_0)
		{
		}

		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x2431FEC", Offset = "0x2431FEC", VA = "0x2431FEC")]
		private void ZEbUZdUWFIEfiSqeUnrGJHjcPybD(PointerEventData P_0)
		{
		}

		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x2432144", Offset = "0x2432144", VA = "0x2432144")]
		private void ZWAzvWwAMRawEGwPixAMPjfyqNgpA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x24326A4", Offset = "0x24326A4", VA = "0x24326A4")]
		private void zHqZkjRbrFTkqMfkkoUpBAuhCzKfA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x2431F74", Offset = "0x2431F74", VA = "0x2431F74")]
		private void PARBcfOJshIGNJtBDsuAyiETdYwy(int P_0, Vector2 P_1)
		{
		}

		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x243196C", Offset = "0x243196C", VA = "0x243196C")]
		private void MHcBbLUbNvVfJsmQBGwoxkdhumdt()
		{
		}

		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x24327D0", Offset = "0x24327D0", VA = "0x24327D0", Slot = "37")]
		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x2432890", Offset = "0x2432890", VA = "0x2432890", Slot = "36")]
		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x2432950", Offset = "0x2432950", VA = "0x2432950", Slot = "38")]
		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x2432A10", Offset = "0x2432A10", VA = "0x2432A10", Slot = "39")]
		internal override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x24327C0", Offset = "0x24327C0", VA = "0x24327C0")]
		private void rEkWtHXjAKTOKMkJBxWaofkAFFvH()
		{
		}

		[Token(Token = "0x60016FC")]
		[Address(RVA = "0x2431EC0", Offset = "0x2431EC0", VA = "0x2431EC0")]
		private bool SBhvinEbIDGWUMwfXythhrIpigKu(int P_0)
		{
			return default;
		}

		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x24323D0", Offset = "0x24323D0", VA = "0x24323D0")]
		private PointerEventData utfJPhgnwTqKykeFFJYQHUTouefi(int P_0, GameObject P_1)
		{
			return null;
		}

		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x2432AD0", Offset = "0x2432AD0", VA = "0x2432AD0")]
		private PointerEventData lhPOsOAoYCOtTCHWjaXddmYdLcxRA(int P_0, GameObject P_1)
		{
			return null;
		}

		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x2432BA4", Offset = "0x2432BA4", VA = "0x2432BA4")]
		private PointerEventData pVfmwALlLutDLwJmMFqcBjCFoHIS(int P_0)
		{
			return null;
		}

		[Token(Token = "0x6001700")]
		[Address(RVA = "0x2431918", Offset = "0x2431918", VA = "0x2431918")]
		private void LQXnlCGWVQCMAatUhwMXImJPGHhKA(PointerEventData P_0)
		{
		}

		[Token(Token = "0x6001701")]
		[Address(RVA = "0x24316E8", Offset = "0x24316E8", VA = "0x24316E8")]
		private PointerEventData HyACTUHUMITHJlwRMGbSiKvZntNC(int P_0)
		{
			return null;
		}
	}
}
