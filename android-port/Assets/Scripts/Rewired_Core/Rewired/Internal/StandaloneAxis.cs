using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	internal sealed class StandaloneAxis
	{
		public delegate void AxisValueChangedEventHandler(float value);

		public delegate void ButtonValueChangedEventHandler(bool value);

		public delegate void ButtonDownEventHandler();

		public delegate void ButtonUpEventHandler();

		[SerializeField]
		private float _buttonActivationThreshold;

		[SerializeField]
		private AxisCalibration _calibration;

		private float _valueRaw;

		private float _valueRawPrev;

		[CompilerGenerated]
		private AxisValueChangedEventHandler QNrCqvatavEJcWTIgbPSkLjfyicxA;

		[CompilerGenerated]
		private AxisValueChangedEventHandler oBjAdLZUVOmXJXCEMBvEAswUIAZz;

		[CompilerGenerated]
		private ButtonDownEventHandler vVVxSUwxUFLqYHHwdPpNCqlcvtkR;

		[CompilerGenerated]
		private ButtonUpEventHandler JDybOVVTuPaXSFNkAXlbqAxSkXAAb;

		[CompilerGenerated]
		private ButtonValueChangedEventHandler PzFiUmVEXzZrQfceZdtWQIJJeFTKA;

		[CompilerGenerated]
		private ButtonDownEventHandler XYJcmgVxsFrDhMNFejImljCGdBdn;

		[CompilerGenerated]
		private ButtonUpEventHandler OJCfamrLPmnglBpGQltFSmxEUUpq;

		[CompilerGenerated]
		private ButtonValueChangedEventHandler AGzBkAfEIMZVJxQEVLkUwrmubOfV;

		public float buttonActivationThreshold => 0f;

		public AxisCalibration calibration => null;

		public float valueRaw => 0f;

		public float valueRawPrev => 0f;

		public float value => 0f;

		public float valuePrev => 0f;

		public bool rawButtonValue => false;

		public bool rawButtonValuePrev => false;

		public bool buttonValue => false;

		public bool buttonValuePrev => false;

		internal float rawMax => 0f;

		internal float rawZero => 0f;

		private event AxisValueChangedEventHandler _AxisValueChangedEvent
		{
			add
			{
				AeSzurUEgoPLNVVeZVUCgcFdEgPk(value);
			}
			remove
			{
				hRhbvzDKQmlJZEbUDVQFfHfnfvomb(value);
			}
		}

		public event AxisValueChangedEventHandler AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent
		{
			add
			{
				oIgOQRlUJEzaBypcjimwROpFpOnb(value);
			}
			remove
			{
				DaCBKygiAYtLFgQeYqpykyBnnWki(value);
			}
		}

		public event AxisValueChangedEventHandler RawAxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonDownEventHandler _ButtonDownEvent
		{
			add
			{
				nhDoObcXFlMvhCXoqGBIKpnqAnQU(value);
			}
			remove
			{
				SpnGPCkIVBftNFVRyTcVfKYBmHBi(value);
			}
		}

		public event ButtonDownEventHandler ButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonUpEventHandler _ButtonUpEvent
		{
			add
			{
				fbljwImkNgDtxVZTrvFGGoLwmfJ(value);
			}
			remove
			{
				XgZiRkAQovdxaBqkYiHIjLPtTBODb(value);
			}
		}

		public event ButtonUpEventHandler ButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent
		{
			add
			{
				bxhnOYxOdSZdCgLyydabQBHDudkG(value);
			}
			remove
			{
				fbgqqUpGhGfDdTTzSBupoSPVMFDN(value);
			}
		}

		public event ButtonValueChangedEventHandler ButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private void AeSzurUEgoPLNVVeZVUCgcFdEgPk(AxisValueChangedEventHandler P_0)
		{
		}

		private void hRhbvzDKQmlJZEbUDVQFfHfnfvomb(AxisValueChangedEventHandler P_0)
		{
		}

		private void oIgOQRlUJEzaBypcjimwROpFpOnb(AxisValueChangedEventHandler P_0)
		{
		}

		private void DaCBKygiAYtLFgQeYqpykyBnnWki(AxisValueChangedEventHandler P_0)
		{
		}

		private void nhDoObcXFlMvhCXoqGBIKpnqAnQU(ButtonDownEventHandler P_0)
		{
		}

		private void SpnGPCkIVBftNFVRyTcVfKYBmHBi(ButtonDownEventHandler P_0)
		{
		}

		private void fbljwImkNgDtxVZTrvFGGoLwmfJ(ButtonUpEventHandler P_0)
		{
		}

		private void XgZiRkAQovdxaBqkYiHIjLPtTBODb(ButtonUpEventHandler P_0)
		{
		}

		private void bxhnOYxOdSZdCgLyydabQBHDudkG(ButtonValueChangedEventHandler P_0)
		{
		}

		private void fbgqqUpGhGfDdTTzSBupoSPVMFDN(ButtonValueChangedEventHandler P_0)
		{
		}

		internal StandaloneAxis()
		{
		}

		public void SetRawValue(float value)
		{
		}

		public void Clear()
		{
		}

		internal static StandaloneAxis CreateRelative()
		{
			return null;
		}
	}
}
