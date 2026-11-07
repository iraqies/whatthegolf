using System;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x2000100")]
	public sealed class InputBehavior
	{
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _joystickAxisSensitivity;

		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _digitalAxisSimulation;

		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _digitalAxisSnap;

		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool _digitalAxisInstantReverse;

		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _digitalAxisGravity;

		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _digitalAxisSensitivity;

		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MouseXYAxisMode _mouseXYAxisMode;

		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MouseOtherAxisMode _mouseOtherAxisMode;

		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _mouseXYAxisSensitivity;

		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc;

		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _mouseOtherAxisSensitivity;

		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _customControllerAxisSensitivity;

		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _buttonDoublePressSpeed;

		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _buttonShortPressTime;

		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _buttonShortPressExpiresIn;

		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _buttonLongPressTime;

		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _buttonLongPressExpiresIn;

		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _buttonDeadZone;

		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _buttonDownBuffer;

		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _buttonRepeatRate;

		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _buttonRepeatDelay;

		[Token(Token = "0x17000244")]
		public int id
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x23D2A58", Offset = "0x23D2A58", VA = "0x23D2A58")]
			get
			{
				return default;
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x23D2A60", Offset = "0x23D2A60", VA = "0x23D2A60")]
			internal set
			{
				JPbZDUeCyFLRqbbbjNbTfHOyjoLk(num);
			}
		}

		[Token(Token = "0x17000245")]
		public string name
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x23D2A68", Offset = "0x23D2A68", VA = "0x23D2A68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x23D2A70", Offset = "0x23D2A70", VA = "0x23D2A70")]
			internal set
			{
				CsQOAWYijZfmerTlmIiSxDfjlXTN(text);
			}
		}

		[Token(Token = "0x17000246")]
		public float joystickAxisSensitivity
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x23D2A78", Offset = "0x23D2A78", VA = "0x23D2A78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000247")]
		public bool digitalAxisSimulation
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x23D2A80", Offset = "0x23D2A80", VA = "0x23D2A80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x23D2A88", Offset = "0x23D2A88", VA = "0x23D2A88")]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		public bool digitalAxisSnap
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x23D2A90", Offset = "0x23D2A90", VA = "0x23D2A90")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x23D2A98", Offset = "0x23D2A98", VA = "0x23D2A98")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public bool digitalAxisInstantReverse
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x23D2AA0", Offset = "0x23D2AA0", VA = "0x23D2AA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x23D2AA8", Offset = "0x23D2AA8", VA = "0x23D2AA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public float digitalAxisGravity
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x23D2AB0", Offset = "0x23D2AB0", VA = "0x23D2AB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x23D2AB8", Offset = "0x23D2AB8", VA = "0x23D2AB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public float digitalAxisSensitivity
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x23D2AEC", Offset = "0x23D2AEC", VA = "0x23D2AEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x23D2AF4", Offset = "0x23D2AF4", VA = "0x23D2AF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public MouseXYAxisMode mouseXYAxisMode
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x23D2B28", Offset = "0x23D2B28", VA = "0x23D2B28")]
			get
			{
				return default;
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x23D2B30", Offset = "0x23D2B30", VA = "0x23D2B30")]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public MouseOtherAxisMode mouseOtherAxisMode
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x23D2B38", Offset = "0x23D2B38", VA = "0x23D2B38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x23D2B40", Offset = "0x23D2B40", VA = "0x23D2B40")]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		public float mouseXYAxisSensitivity
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x23D2B48", Offset = "0x23D2B48", VA = "0x23D2B48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x23D2B50", Offset = "0x23D2B50", VA = "0x23D2B50")]
			set
			{
			}
		}

		[Token(Token = "0x1700024F")]
		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x23D2B84", Offset = "0x23D2B84", VA = "0x23D2B84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000250")]
		public float mouseOtherAxisSensitivity
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x23D2B8C", Offset = "0x23D2B8C", VA = "0x23D2B8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x23D2B94", Offset = "0x23D2B94", VA = "0x23D2B94")]
			set
			{
			}
		}

		[Token(Token = "0x17000251")]
		public float customControllerAxisSensitivity
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x23D2BC8", Offset = "0x23D2BC8", VA = "0x23D2BC8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000252")]
		public float buttonDoublePressSpeed
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x23D2BD0", Offset = "0x23D2BD0", VA = "0x23D2BD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x23D2BD8", Offset = "0x23D2BD8", VA = "0x23D2BD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000253")]
		public float buttonShortPressTime
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x23D2C10", Offset = "0x23D2C10", VA = "0x23D2C10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x23D2C18", Offset = "0x23D2C18", VA = "0x23D2C18")]
			set
			{
			}
		}

		[Token(Token = "0x17000254")]
		public float buttonShortPressExpiresIn
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x23D2C4C", Offset = "0x23D2C4C", VA = "0x23D2C4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x23D2C54", Offset = "0x23D2C54", VA = "0x23D2C54")]
			set
			{
			}
		}

		[Token(Token = "0x17000255")]
		public float buttonLongPressTime
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x23D2C88", Offset = "0x23D2C88", VA = "0x23D2C88")]
			get
			{
				return default;
			}
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x23D2C90", Offset = "0x23D2C90", VA = "0x23D2C90")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		public float buttonLongPressExpiresIn
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x23D2CC4", Offset = "0x23D2CC4", VA = "0x23D2CC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x23D2CCC", Offset = "0x23D2CCC", VA = "0x23D2CCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000257")]
		public float buttonDeadZone
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x23D2D00", Offset = "0x23D2D00", VA = "0x23D2D00")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x23D2D08", Offset = "0x23D2D08", VA = "0x23D2D08")]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		public float buttonDownBuffer
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x23D2D38", Offset = "0x23D2D38", VA = "0x23D2D38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x23D2D40", Offset = "0x23D2D40", VA = "0x23D2D40")]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		public float buttonRepeatRate
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x23D2D74", Offset = "0x23D2D74", VA = "0x23D2D74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700025A")]
		public float buttonRepeatDelay
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x23D2D7C", Offset = "0x23D2D7C", VA = "0x23D2D7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x23D2A60", Offset = "0x23D2A60", VA = "0x23D2A60")]
		internal void JPbZDUeCyFLRqbbbjNbTfHOyjoLk(int P_0)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x23D2A70", Offset = "0x23D2A70", VA = "0x23D2A70")]
		internal void CsQOAWYijZfmerTlmIiSxDfjlXTN(string P_0)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x23D2D84", Offset = "0x23D2D84", VA = "0x23D2D84")]
		public InputBehavior()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x23D2DB4", Offset = "0x23D2DB4", VA = "0x23D2DB4")]
		public InputBehavior(InputBehavior P_0)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x23D2EB0", Offset = "0x23D2EB0", VA = "0x23D2EB0")]
		public string ToXmlString()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x23D392C", Offset = "0x23D392C", VA = "0x23D392C")]
		public bool ImportXmlString(string xmlString)
		{
			return default;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x23D3E90", Offset = "0x23D3E90", VA = "0x23D3E90")]
		public InputBehavior Clone()
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x23D3F2C", Offset = "0x23D3F2C", VA = "0x23D3F2C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x23D2FDC", Offset = "0x23D2FDC", VA = "0x23D2FDC")]
		internal SerializedObject gaEyaPekKioygyfanwRwWfzwfdtQ()
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x23D3A84", Offset = "0x23D3A84", VA = "0x23D3A84")]
		internal void FOuxuJsHWhCpyXhouIptKEIcQGsIA(SerializedObject P_0)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x23D2E10", Offset = "0x23D2E10", VA = "0x23D2E10")]
		private static void weJCVCcVBndaPkhXYIkygFoCRNrIc(InputBehavior P_0, InputBehavior P_1, bool P_2)
		{
		}
	}
}
