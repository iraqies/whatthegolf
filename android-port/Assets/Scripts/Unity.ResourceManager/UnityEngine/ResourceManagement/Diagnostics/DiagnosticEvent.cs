using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	[Serializable]
	[Token(Token = "0x2000067")]
	public struct DiagnosticEvent
	{
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Graph;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int[] m_Dependencies;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ObjectId;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_DisplayName;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_Stream;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_Frame;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_Value;

		[Token(Token = "0x17000077")]
		public string Graph
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2A64E98", Offset = "0x2A64E98", VA = "0x2A64E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public int ObjectId
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2A64EA0", Offset = "0x2A64EA0", VA = "0x2A64EA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000079")]
		public string DisplayName
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2A64EA8", Offset = "0x2A64EA8", VA = "0x2A64EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public int[] Dependencies
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x2A64EB0", Offset = "0x2A64EB0", VA = "0x2A64EB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public int Stream
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2A64EB8", Offset = "0x2A64EB8", VA = "0x2A64EB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007C")]
		public int Frame
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2A64EC0", Offset = "0x2A64EC0", VA = "0x2A64EC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007D")]
		public int Value
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2A64EC8", Offset = "0x2A64EC8", VA = "0x2A64EC8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2A64ED0", Offset = "0x2A64ED0", VA = "0x2A64ED0")]
		public DiagnosticEvent(string graph, string name, int id, int stream, int frame, int value, int[] deps)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2A64EE8", Offset = "0x2A64EE8", VA = "0x2A64EE8")]
		internal byte[] Serialize()
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2A64F8C", Offset = "0x2A64F8C", VA = "0x2A64F8C")]
		public static DiagnosticEvent Deserialize(byte[] data)
		{
			return default;
		}
	}
}
