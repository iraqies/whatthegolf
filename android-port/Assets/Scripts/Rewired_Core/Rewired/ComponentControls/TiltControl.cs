using System;
using Il2CppDummyDll;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002D3")]
	[DisallowMultipleComponent]
	public sealed class TiltControl : CustomControllerControl
	{
		[Token(Token = "0x20002D4")]
		public enum TiltDirection
		{
			[Token(Token = "0x4000ED3")]
			Both = 0,
			[Token(Token = "0x4000ED4")]
			Horizontal = 1,
			[Token(Token = "0x4000ED5")]
			Forward = 2
		}

		[Token(Token = "0x4000EC5")]
		private const float maxFullTiltAngle = 180f;

		[Token(Token = "0x4000EC6")]
		private const float maxAngleOffset = 90f;

		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TiltDirection _allowedTiltDirections;

		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement;

		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x194258", Offset = "0x194258")]
		private float _horizontalTiltLimit;

		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x19429C", Offset = "0x19429C")]
		private float _horizontalRestAngle;

		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement;

		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1942F4", Offset = "0x1942F4")]
		private float _forwardTiltLimit;

		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x194338", Offset = "0x194338")]
		[SerializeField]
		private float _forwardRestAngle;

		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StandaloneAxis2D _axis2D;

		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x58")]
		private bool _useHAxis;

		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x59")]
		private bool _useFAxis;

		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x60")]
		private Func<Vector3> _getAccelerationValue;

		[Token(Token = "0x1700059E")]
		public TiltDirection axesToUse
		{
			[Token(Token = "0x60014DD")]
			[Address(RVA = "0x241C0F8", Offset = "0x241C0F8", VA = "0x241C0F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60014DE")]
			[Address(RVA = "0x241C100", Offset = "0x241C100", VA = "0x241C100")]
			set
			{
			}
		}

		[Token(Token = "0x1700059F")]
		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement
		{
			[Token(Token = "0x60014DF")]
			[Address(RVA = "0x241C218", Offset = "0x241C218", VA = "0x241C218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A0")]
		public float horizontalTiltLimit
		{
			[Token(Token = "0x60014E0")]
			[Address(RVA = "0x241C220", Offset = "0x241C220", VA = "0x241C220")]
			get
			{
				return default;
			}
			[Token(Token = "0x60014E1")]
			[Address(RVA = "0x241C228", Offset = "0x241C228", VA = "0x241C228")]
			set
			{
			}
		}

		[Token(Token = "0x170005A1")]
		public float horizontalRestAngle
		{
			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x241C284", Offset = "0x241C284", VA = "0x241C284")]
			get
			{
				return default;
			}
			[Token(Token = "0x60014E3")]
			[Address(RVA = "0x241C28C", Offset = "0x241C28C", VA = "0x241C28C")]
			set
			{
			}
		}

		[Token(Token = "0x170005A2")]
		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement
		{
			[Token(Token = "0x60014E4")]
			[Address(RVA = "0x241C2EC", Offset = "0x241C2EC", VA = "0x241C2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A3")]
		public float forwardTiltLimit
		{
			[Token(Token = "0x60014E5")]
			[Address(RVA = "0x241C2F4", Offset = "0x241C2F4", VA = "0x241C2F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60014E6")]
			[Address(RVA = "0x241C2FC", Offset = "0x241C2FC", VA = "0x241C2FC")]
			set
			{
			}
		}

		[Token(Token = "0x170005A4")]
		public float forwardRestAngle
		{
			[Token(Token = "0x60014E7")]
			[Address(RVA = "0x241C358", Offset = "0x241C358", VA = "0x241C358")]
			get
			{
				return default;
			}
			[Token(Token = "0x60014E8")]
			[Address(RVA = "0x241C360", Offset = "0x241C360", VA = "0x241C360")]
			set
			{
			}
		}

		[Token(Token = "0x170005A5")]
		public AxisCalibration horizontalAxisCalibration
		{
			[Token(Token = "0x60014E9")]
			[Address(RVA = "0x241C3C0", Offset = "0x241C3C0", VA = "0x241C3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A6")]
		public AxisCalibration verticalAxisCalibration
		{
			[Token(Token = "0x60014EA")]
			[Address(RVA = "0x241C3E8", Offset = "0x241C3E8", VA = "0x241C3E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A7")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1975A0", Offset = "0x1975A0")]
		public Axis2DCalibration deadZoneType
		{
			[Token(Token = "0x60014EB")]
			[Address(RVA = "0x241C410", Offset = "0x241C410", VA = "0x241C410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A8")]
		public Axis2DCalibration axis2DCalibration
		{
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x241C42C", Offset = "0x241C42C", VA = "0x241C42C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A9")]
		internal StandaloneAxis2D ACDlWRYqRUOGCISCfVnFWZBaWOxV
		{
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x241C448", Offset = "0x241C448", VA = "0x241C448")]
			get
			{
				return gNQvFCCTSioPGpasLuMXMIEqZNzw();
			}
		}

		[Token(Token = "0x170005AA")]
		private Vector3 yhrndLurWXsqntabhfRrBfoPRmTVA
		{
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x241C450", Offset = "0x241C450", VA = "0x241C450")]
			get
			{
				return sGTbkbxaTuHpDZfIaarobpZqCzho();
			}
		}

		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x241C448", Offset = "0x241C448", VA = "0x241C448")]
		internal StandaloneAxis2D gNQvFCCTSioPGpasLuMXMIEqZNzw()
		{
			return null;
		}

		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x241C450", Offset = "0x241C450", VA = "0x241C450")]
		private Vector3 sGTbkbxaTuHpDZfIaarobpZqCzho()
		{
			return default;
		}

		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x241C4AC", Offset = "0x241C4AC", VA = "0x241C4AC")]
		internal TiltControl()
		{
		}

		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x241C568", Offset = "0x241C568", VA = "0x241C568")]
		public void SetAccelerationSourceCallback(Func<Vector3> callback)
		{
		}

		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x241C570", Offset = "0x241C570", VA = "0x241C570")]
		public void SetRestOrientation()
		{
		}

		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x241C694", Offset = "0x241C694", VA = "0x241C694", Slot = "11")]
		internal override void OnValidate()
		{
		}

		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x241C768", Offset = "0x241C768", VA = "0x241C768", Slot = "17")]
		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return default;
		}

		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x241C7A0", Offset = "0x241C7A0", VA = "0x241C7A0", Slot = "16")]
		internal override void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x241CAC8", Offset = "0x241CAC8", VA = "0x241CAC8", Slot = "26")]
		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x241CBBC", Offset = "0x241CBBC", VA = "0x241CBBC", Slot = "7")]
		public override void ClearValue()
		{
		}

		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x241C7E0", Offset = "0x241C7E0", VA = "0x241C7E0")]
		private void LtpmYHqyVeOJJwEvCGkGjXoQaMAM()
		{
		}

		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x241C6D4", Offset = "0x241C6D4", VA = "0x241C6D4")]
		private void tDjBtqdbJKGmpkMhGSzXQOVLncJT()
		{
		}

		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x241C140", Offset = "0x241C140", VA = "0x241C140")]
		private void GIBVHpzXHQWngXozSfKaKeeIRfeQ(TiltDirection P_0)
		{
		}
	}
}
