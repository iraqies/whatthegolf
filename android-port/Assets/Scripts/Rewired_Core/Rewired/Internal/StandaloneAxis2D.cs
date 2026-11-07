using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	[Token(Token = "0x2000320")]
	internal sealed class StandaloneAxis2D
	{
		[Token(Token = "0x2000321")]
		public delegate void ValueChangedEventHandler(Vector2 value);

		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Axis2DCalibration _calibration;

		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StandaloneAxis _xAxis;

		[Token(Token = "0x400106C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StandaloneAxis _yAxis;

		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x28")]
		private bool _allowEvents;

		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F54", Offset = "0x194F54")]
		private ValueChangedEventHandler m__ValueChangedEvent;

		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F64", Offset = "0x194F64")]
		private ValueChangedEventHandler _RawValueChangedEvent;

		[Token(Token = "0x1700067E")]
		public Axis2DCalibration calibration
		{
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x2419784", Offset = "0x2419784", VA = "0x2419784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067F")]
		public StandaloneAxis xAxis
		{
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x241978C", Offset = "0x241978C", VA = "0x241978C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000680")]
		public StandaloneAxis yAxis
		{
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x2419794", Offset = "0x2419794", VA = "0x2419794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000681")]
		public Vector2 value
		{
			[Token(Token = "0x600182D")]
			[Address(RVA = "0x241979C", Offset = "0x241979C", VA = "0x241979C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000682")]
		public Vector2 valuePrev
		{
			[Token(Token = "0x600182E")]
			[Address(RVA = "0x2419834", Offset = "0x2419834", VA = "0x2419834")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000683")]
		public Vector2 valueDelta
		{
			[Token(Token = "0x600182F")]
			[Address(RVA = "0x24198CC", Offset = "0x24198CC", VA = "0x24198CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000684")]
		public Vector2 rawValue
		{
			[Token(Token = "0x6001830")]
			[Address(RVA = "0x2419998", Offset = "0x2419998", VA = "0x2419998")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000685")]
		public Vector2 rawValuePrev
		{
			[Token(Token = "0x6001831")]
			[Address(RVA = "0x2419A14", Offset = "0x2419A14", VA = "0x2419A14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000686")]
		public Vector2 rawValueDelta
		{
			[Token(Token = "0x6001832")]
			[Address(RVA = "0x2419A90", Offset = "0x2419A90", VA = "0x2419A90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000687")]
		internal Vector2 rawZero
		{
			[Token(Token = "0x6001833")]
			[Address(RVA = "0x2419B74", Offset = "0x2419B74", VA = "0x2419B74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1400004B")]
		private event ValueChangedEventHandler _ValueChangedEvent
		{
			[Token(Token = "0x6001834")]
			[Address(RVA = "0x2419BD0", Offset = "0x2419BD0", VA = "0x2419BD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197430", Offset = "0x197430")]
			add
			{
			}
			[Token(Token = "0x6001835")]
			[Address(RVA = "0x2419C74", Offset = "0x2419C74", VA = "0x2419C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197440", Offset = "0x197440")]
			remove
			{
			}
		}

		[Token(Token = "0x1400004C")]
		public event ValueChangedEventHandler ValueChangedEvent
		{
			[Token(Token = "0x6001836")]
			[Address(RVA = "0x2419D18", Offset = "0x2419D18", VA = "0x2419D18")]
			add
			{
			}
			[Token(Token = "0x6001837")]
			[Address(RVA = "0x2419DBC", Offset = "0x2419DBC", VA = "0x2419DBC")]
			remove
			{
			}
		}

		[Token(Token = "0x6001838")]
		[Address(RVA = "0x2419E60", Offset = "0x2419E60", VA = "0x2419E60")]
		internal StandaloneAxis2D()
		{
		}

		[Token(Token = "0x6001839")]
		[Address(RVA = "0x2419FB0", Offset = "0x2419FB0", VA = "0x2419FB0")]
		internal StandaloneAxis2D(StandaloneAxis P_0, StandaloneAxis P_1)
		{
		}

		[Token(Token = "0x600183A")]
		[Address(RVA = "0x241A118", Offset = "0x241A118", VA = "0x241A118")]
		public void SetRawValue(float x, float y)
		{
		}

		[Token(Token = "0x600183B")]
		[Address(RVA = "0x241A2BC", Offset = "0x241A2BC", VA = "0x241A2BC")]
		public void SetRawValue(Vector2 value)
		{
		}

		[Token(Token = "0x600183C")]
		[Address(RVA = "0x241A310", Offset = "0x241A310", VA = "0x241A310")]
		public void Clear()
		{
		}

		[Token(Token = "0x600183D")]
		[Address(RVA = "0x241A38C", Offset = "0x241A38C", VA = "0x241A38C")]
		internal void Initialize()
		{
		}

		[Token(Token = "0x600183E")]
		[Address(RVA = "0x241A680", Offset = "0x241A680", VA = "0x241A680")]
		internal void Deinitialize()
		{
		}

		[Token(Token = "0x600183F")]
		[Address(RVA = "0x241A16C", Offset = "0x241A16C", VA = "0x241A16C")]
		private void EvalAndSendValueChangeEvents()
		{
		}

		[Token(Token = "0x6001840")]
		[Address(RVA = "0x241A390", Offset = "0x241A390", VA = "0x241A390")]
		private void Subscribe()
		{
		}

		[Token(Token = "0x6001841")]
		[Address(RVA = "0x241A684", Offset = "0x241A684", VA = "0x241A684")]
		private void Unsubscribe()
		{
		}

		[Token(Token = "0x6001842")]
		[Address(RVA = "0x24197EC", Offset = "0x24197EC", VA = "0x24197EC")]
		private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			return default;
		}

		[Token(Token = "0x6001843")]
		[Address(RVA = "0x2419884", Offset = "0x2419884", VA = "0x2419884")]
		private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			return default;
		}

		[Token(Token = "0x6001844")]
		[Address(RVA = "0x241A96C", Offset = "0x241A96C", VA = "0x241A96C")]
		private void OnAxisValueChanged(float value)
		{
		}

		[Token(Token = "0x6001845")]
		[Address(RVA = "0x241A9F8", Offset = "0x241A9F8", VA = "0x241A9F8")]
		private void OnAxisRawValueChanged(float value)
		{
		}

		[Token(Token = "0x6001846")]
		[Address(RVA = "0x241AAA4", Offset = "0x241AAA4", VA = "0x241AAA4")]
		internal static StandaloneAxis2D CreateRelative()
		{
			return null;
		}
	}
}
