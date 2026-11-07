using System;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputBehavior
	{
		[SerializeField]
		private int _id;

		[SerializeField]
		private string _name;

		[SerializeField]
		private float _joystickAxisSensitivity;

		[SerializeField]
		private bool _digitalAxisSimulation;

		[SerializeField]
		private bool _digitalAxisSnap;

		[SerializeField]
		private bool _digitalAxisInstantReverse;

		[SerializeField]
		private float _digitalAxisGravity;

		[SerializeField]
		private float _digitalAxisSensitivity;

		[SerializeField]
		private MouseXYAxisMode _mouseXYAxisMode;

		[SerializeField]
		private MouseOtherAxisMode _mouseOtherAxisMode;

		[SerializeField]
		private float _mouseXYAxisSensitivity;

		[SerializeField]
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc;

		[SerializeField]
		private float _mouseOtherAxisSensitivity;

		[SerializeField]
		private float _customControllerAxisSensitivity;

		[SerializeField]
		private float _buttonDoublePressSpeed;

		[SerializeField]
		private float _buttonShortPressTime;

		[SerializeField]
		private float _buttonShortPressExpiresIn;

		[SerializeField]
		private float _buttonLongPressTime;

		[SerializeField]
		private float _buttonLongPressExpiresIn;

		[SerializeField]
		private float _buttonDeadZone;

		[SerializeField]
		private float _buttonDownBuffer;

		[SerializeField]
		private float _buttonRepeatRate;

		[SerializeField]
		private float _buttonRepeatDelay;

		public int id
		{
			get
			{
				return 0;
			}
			internal set
			{
				JPbZDUeCyFLRqbbbjNbTfHOyjoLk(num);
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
				CsQOAWYijZfmerTlmIiSxDfjlXTN(text);
			}
		}

		public float joystickAxisSensitivity => 0f;

		public bool digitalAxisSimulation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool digitalAxisSnap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool digitalAxisInstantReverse
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float digitalAxisGravity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float digitalAxisSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MouseXYAxisMode mouseXYAxisMode
		{
			get
			{
				return MouseXYAxisMode.MouseAxis;
			}
			set
			{
			}
		}

		public MouseOtherAxisMode mouseOtherAxisMode
		{
			get
			{
				return MouseOtherAxisMode.MouseAxis;
			}
			set
			{
			}
		}

		public float mouseXYAxisSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc => MouseXYAxisDeltaCalc.Normal;

		public float mouseOtherAxisSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float customControllerAxisSensitivity => 0f;

		public float buttonDoublePressSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonShortPressTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonShortPressExpiresIn
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonLongPressTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonLongPressExpiresIn
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonDownBuffer
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float buttonRepeatRate => 0f;

		public float buttonRepeatDelay => 0f;

		internal void JPbZDUeCyFLRqbbbjNbTfHOyjoLk(int P_0)
		{
		}

		internal void CsQOAWYijZfmerTlmIiSxDfjlXTN(string P_0)
		{
		}

		public InputBehavior()
		{
		}

		public InputBehavior(InputBehavior P_0)
		{
		}

		public string ToXmlString()
		{
			return null;
		}

		public bool ImportXmlString(string xmlString)
		{
			return false;
		}

		public InputBehavior Clone()
		{
			return null;
		}

		public void Reset()
		{
		}

		internal SerializedObject gaEyaPekKioygyfanwRwWfzwfdtQ()
		{
			return null;
		}

		internal void FOuxuJsHWhCpyXhouIptKEIcQGsIA(SerializedObject P_0)
		{
		}

		private static void weJCVCcVBndaPkhXYIkygFoCRNrIc(InputBehavior P_0, InputBehavior P_1, bool P_2)
		{
		}
	}
}
