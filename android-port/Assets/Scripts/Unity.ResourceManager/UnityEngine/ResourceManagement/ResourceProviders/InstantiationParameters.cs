using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x200004D")]
	public struct InstantiationParameters
	{
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 m_Position;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xC")]
		private Quaternion m_Rotation;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Parent;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_InstantiateInWorldPosition;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x29")]
		private bool m_SetPositionRotation;

		[Token(Token = "0x17000049")]
		public Vector3 Position
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2A6866C", Offset = "0x2A6866C", VA = "0x2A6866C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004A")]
		public Quaternion Rotation
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x2A68678", Offset = "0x2A68678", VA = "0x2A68678")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004B")]
		public Transform Parent
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x2A68684", Offset = "0x2A68684", VA = "0x2A68684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public bool InstantiateInWorldPosition
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2A6868C", Offset = "0x2A6868C", VA = "0x2A6868C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004D")]
		public bool SetPositionRotation
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x2A68694", Offset = "0x2A68694", VA = "0x2A68694")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2A6869C", Offset = "0x2A6869C", VA = "0x2A6869C")]
		public InstantiationParameters(Transform parent, bool instantiateInWorldSpace)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2A686F4", Offset = "0x2A686F4", VA = "0x2A686F4")]
		public InstantiationParameters(Vector3 position, Quaternion rotation, Transform parent)
		{
		}

		[Token(Token = "0x60001D8")]
		public TObject Instantiate<TObject>(TObject source) where TObject : Object
		{
			return null;
		}
	}
}
