using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200000E")]
	internal class RectangularVertexClipper
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private readonly Vector3[] m_WorldCorners;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		private readonly Vector3[] m_CanvasCorners;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2C304D8", Offset = "0x2C304D8", VA = "0x2C304D8")]
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			return default;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2C30664", Offset = "0x2C30664", VA = "0x2C30664")]
		public RectangularVertexClipper()
		{
		}
	}
}
