using System;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TiltControl : CustomControllerControl
	{
		public enum TiltDirection
		{
			Both = 0,
			Horizontal = 1,
			Forward = 2
		}

		private const float maxFullTiltAngle = 180f;

		private const float maxAngleOffset = 90f;

		[SerializeField]
		private TiltDirection _allowedTiltDirections;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement;

		[SerializeField]
		private float _horizontalTiltLimit;

		[SerializeField]
		private float _horizontalRestAngle;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement;

		[SerializeField]
		private float _forwardTiltLimit;

		[SerializeField]
		private float _forwardRestAngle;

		[SerializeField]
		private StandaloneAxis2D _axis2D;

		private bool _useHAxis;

		private bool _useFAxis;

		private Func<Vector3> _getAccelerationValue;

		public TiltDirection axesToUse
		{
			get
			{
				return TiltDirection.Both;
			}
			set
			{
			}
		}

		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement => null;

		public float horizontalTiltLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float horizontalRestAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement => null;

		public float forwardTiltLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float forwardRestAngle
		{
			get
			{
				return 0f;
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

		internal StandaloneAxis2D ACDlWRYqRUOGCISCfVnFWZBaWOxV => gNQvFCCTSioPGpasLuMXMIEqZNzw();

		private Vector3 yhrndLurWXsqntabhfRrBfoPRmTVA => sGTbkbxaTuHpDZfIaarobpZqCzho();

		internal StandaloneAxis2D gNQvFCCTSioPGpasLuMXMIEqZNzw()
		{
			return null;
		}

		private Vector3 sGTbkbxaTuHpDZfIaarobpZqCzho()
		{
			return default;
		}

		internal TiltControl()
		{
		}

		public void SetAccelerationSourceCallback(Func<Vector3> callback)
		{
		}

		public void SetRestOrientation()
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

		public override void ClearValue()
		{
		}

		private void LtpmYHqyVeOJJwEvCGkGjXoQaMAM()
		{
		}

		private void tDjBtqdbJKGmpkMhGSzXQOVLncJT()
		{
		}

		private void GIBVHpzXHQWngXozSfKaKeeIRfeQ(TiltDirection P_0)
		{
		}
	}
}
