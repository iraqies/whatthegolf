using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000AE")]
	public struct RaycastResult
	{
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x0")]
		private GameObject m_GameObject;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x8")]
		public BaseRaycaster module;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x10")]
		public float distance;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x14")]
		public float index;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x18")]
		public int depth;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x1C")]
		public int sortingGroupID;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x20")]
		public int sortingGroupOrder;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x24")]
		public int sortingLayer;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x28")]
		public int sortingOrder;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 worldPosition;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 worldNormal;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 screenPosition;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x4C")]
		public int displayIndex;

		[Token(Token = "0x170001B3")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x2C2EDA0", Offset = "0x2C2EDA0", VA = "0x2C2EDA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x2C2EDA8", Offset = "0x2C2EDA8", VA = "0x2C2EDA8")]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		public bool isValid
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x2C2EDB0", Offset = "0x2C2EDB0", VA = "0x2C2EDB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2C2C77C", Offset = "0x2C2C77C", VA = "0x2C2C77C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
