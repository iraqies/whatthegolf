using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	internal sealed class StandaloneAxis2D
	{
		public delegate void ValueChangedEventHandler(Vector2 value);

		[SerializeField]
		private Axis2DCalibration _calibration;

		[SerializeField]
		private StandaloneAxis _xAxis;

		[SerializeField]
		private StandaloneAxis _yAxis;

		private bool _allowEvents;

		[CompilerGenerated]
		private ValueChangedEventHandler m__ValueChangedEvent;

		[CompilerGenerated]
		private ValueChangedEventHandler _RawValueChangedEvent;

		public Axis2DCalibration calibration => null;

		public StandaloneAxis xAxis => null;

		public StandaloneAxis yAxis => null;

		public Vector2 value => default;

		public Vector2 valuePrev => default;

		public Vector2 valueDelta => default;

		public Vector2 rawValue => default;

		public Vector2 rawValuePrev => default;

		public Vector2 rawValueDelta => default;

		internal Vector2 rawZero => default;

		private event ValueChangedEventHandler _ValueChangedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ValueChangedEventHandler ValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal StandaloneAxis2D()
		{
		}

		internal StandaloneAxis2D(StandaloneAxis P_0, StandaloneAxis P_1)
		{
		}

		public void SetRawValue(float x, float y)
		{
		}

		public void SetRawValue(Vector2 value)
		{
		}

		public void Clear()
		{
		}

		internal void Initialize()
		{
		}

		internal void Deinitialize()
		{
		}

		private void EvalAndSendValueChangeEvents()
		{
		}

		private void Subscribe()
		{
		}

		private void Unsubscribe()
		{
		}

		private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			return default;
		}

		private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			return default;
		}

		private void OnAxisValueChanged(float value)
		{
		}

		private void OnAxisRawValueChanged(float value)
		{
		}

		internal static StandaloneAxis2D CreateRelative()
		{
			return null;
		}
	}
}
