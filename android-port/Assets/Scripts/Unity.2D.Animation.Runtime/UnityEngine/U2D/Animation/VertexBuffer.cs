using Il2CppDummyDll;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x2000002")]
	internal class VertexBuffer
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private readonly int m_Id;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x14")]
		private bool m_IsActive;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private int m_DeactivateFrame;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		private NativeByteArray[] m_Buffers;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		private int m_ActiveIndex;

		[Token(Token = "0x17000001")]
		public int bufferCount
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2A0D748", Offset = "0x2A0D748", VA = "0x2A0D748")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2A0E1C4", Offset = "0x2A0E1C4", VA = "0x2A0E1C4")]
		public VertexBuffer(int id, int size, bool needDoubleBuffering)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2A11CD8", Offset = "0x2A11CD8", VA = "0x2A11CD8", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2A11CE0", Offset = "0x2A11CE0", VA = "0x2A11CE0")]
		private static int GetCurrentFrame()
		{
			return default;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2A0E068", Offset = "0x2A0E068", VA = "0x2A0E068")]
		public NativeByteArray GetBuffer(int size)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2A11CE8", Offset = "0x2A11CE8", VA = "0x2A11CE8")]
		private void ResizeBuffer(int bufferId, int newSize)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2A0E424", Offset = "0x2A0E424", VA = "0x2A0E424")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2A0DD88", Offset = "0x2A0DD88", VA = "0x2A0DD88")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A0E52C", Offset = "0x2A0E52C", VA = "0x2A0E52C")]
		public bool IsSafeToDispose()
		{
			return default;
		}
	}
}
