using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x2000003")]
	internal class BufferManager : ScriptableObject
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static BufferManager s_Instance;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, VertexBuffer> m_Buffers;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		private Queue<VertexBuffer> m_BuffersToDispose;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0948", Offset = "0x1B0948")]
		private bool needDoubleBuffering__BackingField;

		[Token(Token = "0x17000002")]
		public int bufferCount
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2A0D5B8", Offset = "0x2A0D5B8", VA = "0x2A0D5B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		public bool needDoubleBuffering
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2A0D764", Offset = "0x2A0D764", VA = "0x2A0D764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B09C8", Offset = "0x1B09C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2A0D76C", Offset = "0x2A0D76C", VA = "0x2A0D76C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B09D8", Offset = "0x1B09D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public static BufferManager instance
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2A0D774", Offset = "0x2A0D774", VA = "0x2A0D774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A0D898", Offset = "0x2A0D898", VA = "0x2A0D898")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A0D9A4", Offset = "0x2A0D9A4", VA = "0x2A0D9A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A0DAA4", Offset = "0x2A0DAA4", VA = "0x2A0DAA4")]
		private void ForceClearBuffers()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A0DEB8", Offset = "0x2A0DEB8", VA = "0x2A0DEB8")]
		public NativeByteArray GetBuffer(int id, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A0DF5C", Offset = "0x2A0DF5C", VA = "0x2A0DF5C")]
		private VertexBuffer CreateBuffer(int id, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A0E334", Offset = "0x2A0E334", VA = "0x2A0E334")]
		public void ReturnBuffer(int id)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A0E45C", Offset = "0x2A0E45C", VA = "0x2A0E45C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A0E56C", Offset = "0x2A0E56C", VA = "0x2A0E56C")]
		public BufferManager()
		{
		}
	}
}
